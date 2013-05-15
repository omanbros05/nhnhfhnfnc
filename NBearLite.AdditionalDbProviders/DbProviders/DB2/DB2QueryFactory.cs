using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using IBM.Data.DB2;

namespace NBearLite.DbProviders.DB2
{
    public class DB2QueryFactory : NBearLite.SqlQueryFactory
    {
        public DB2QueryFactory() : base('"', '"', '@', '%', '_', DB2Factory.Instance)
        {
        }

        protected override void PrepareCommand(DbCommand cmd)
        {
            base.PrepareCommand(cmd);

            List<DbParameter> parametersToDelete = new List<DbParameter>();

            foreach (DbParameter p in cmd.Parameters)
            {
                if (p.Direction == ParameterDirection.Output || p.Direction == ParameterDirection.ReturnValue)
                {
                    continue;
                }

                object value = p.Value;
                if (value == DBNull.Value)
                {
                    continue;
                }
                Type type = value.GetType();

                if ((p.DbType == DbType.Time || p.DbType == DbType.DateTime) && type == typeof(TimeSpan))
                {
                    parametersToDelete.Add(p);
                    cmd.CommandText = cmd.CommandText.Replace(p.ParameterName, ((TimeSpan)value).TotalDays + " DAYS");
                }
                else
                {
                    cmd.CommandText = cmd.CommandText.Replace(p.ParameterName, "?");
                }
                
                DB2Parameter DB2Param = (DB2Parameter)p;

                if (DB2Param.DbType != DbType.Guid && type == typeof(Guid))
                {
                    DB2Param.DB2Type = DB2Type.Char;
                    DB2Param.Size = 36;
                    continue;
                }

                switch (p.DbType)
                {
                    case DbType.Binary:
                        if (((byte[])value).Length > 2000)
                        {
                            DB2Param.DB2Type = DB2Type.Blob;
                        }
                        break;
                    case DbType.Time:
                        DB2Param.DB2Type = DB2Type.Timestamp;
                        break;
                    case DbType.DateTime:
                        DB2Param.DB2Type = DB2Type.Timestamp;
                        break;
                    case DbType.AnsiString:
                        if (value.ToString().Length > 2000)
                        {
                            DB2Param.DB2Type = DB2Type.Clob;
                        }
                        break;
                    case DbType.String:
                        if (value.ToString().Length > 1000)
                        {
                            DB2Param.DB2Type = DB2Type.DbClob;
                        }
                        break;
                    case DbType.Object:
                        DB2Param.DB2Type = DB2Type.DbClob;
                        p.Value = SerializationManager.Instance.Serialize(value);
                        break;
                }
            }

            if (parametersToDelete.Count > 0)
            {
                for (int i = 0; i < parametersToDelete.Count; ++i)
                    cmd.Parameters.Remove(parametersToDelete[i]);
            }

            //replace DB2 specific function names in cmd.CommandText
            cmd.CommandText = cmd.CommandText
                .Replace("LEN(", "LENGTH(")
                .Replace("SUBSTRING(", "SUBSTR(")
                .Replace("CHARINDEX(", "1+LOCATE(")
                .Replace("GETDATE()", "CURRENT_TIMESTAMP")
                .Replace("GETUTCDATE()", "CURRENT_TIMESTAMP - CURRENT_TIMEZONE")
                .Replace("DATEPART(Year,", "YEAR(")
                .Replace("DATEPART(Month,", "MONTH(")
                .Replace("DATEPART(Day,", "DAY(");

            //replace TONUMBER to cast
            int pos = cmd.CommandText.IndexOf("TO_NUMBER(");
            if (pos > 0)
            {
                int bracketCount = 1;
                string columnName = null;
                int i = pos + "TO_NUMBER(".Length;
                for (; i < cmd.CommandText.Length; ++i)
                {
                    if (cmd.CommandText[i] == ')')
                        --bracketCount;
                    else if (cmd.CommandText[i] == '(')
                        ++bracketCount;

                    if (bracketCount == 0)
                        break;
                }
                columnName = cmd.CommandText.Substring(pos + "TO_NUMBER(".Length, i - pos - "TO_NUMBER(".Length);
                string newSql = cmd.CommandText.Substring(0, pos) + string.Format("cast(cast({0} as decimal) as double)", columnName);
                if (i < cmd.CommandText.Length - 1)
                    newSql += cmd.CommandText.Substring(i + 1);
                cmd.CommandText = newSql;
            }
        }

        public override DbCommand CreateSelectRangeCommand(WhereClip where, string[] columns, int topCount, int skipCount, string identyColumn, bool identyColumnIsNumber)
        {
            Check.Require(((object)where) != null && where.From != null, "expr and expr.From could not be null!");
            Check.Require(columns != null && columns.Length > 0, "columns could not be null or empty!");
            Check.Require(topCount > 0, "topCount must > 0!");

            if (string.IsNullOrEmpty(where.OrderBy) && identyColumn != null)
            {
                where.SetOrderBy(new KeyValuePair<string,bool>[] { new KeyValuePair<string,bool>(identyColumn, false) });
            }

            if (topCount == int.MaxValue && skipCount == 0)
            {
                return CreateSelectCommand(where, columns);
            }
            else
            {
                Check.Require(!string.IsNullOrEmpty(identyColumn), "identyColumn could not be null or empty!");

                identyColumn = ColumnFormatter.ValidColumnName(identyColumn);

                //page split algorithm using ROWNUMBER()

                DbCommand cmd = fac.CreateCommand();
                cmd.CommandType = CommandType.Text;

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT *");
                //for (int i = 0; i < columns.Length; ++i)
                //{
                //    sb.Append("[__T].[__C");
                //    sb.Append(i);
                //    sb.Append(']');

                //    if (i < columns.Length - 1)
                //    {
                //        sb.Append(',');
                //    }
                //}
                sb.Append(" FROM (");
                sb.Append("SELECT ");
                for (int i = 0; i < columns.Length; ++i)
                {
                    SqlQueryUtils.AppendColumnName(sb, columns[i]);

                    if (i < columns.Length - 1)
                    {
                        sb.Append(',');
                    }
                }
                sb.Append(",ROWNUMBER() OVER (ORDER BY ");
                if (string.IsNullOrEmpty(where.OrderBy))
                {
                    sb.Append(identyColumn);
                }
                else
                {
                    sb.Append(where.OrderBy);
                }
                sb.Append(") AS [__Pos]");
                sb.Append(" FROM ");

                if (string.IsNullOrEmpty(where.OrderBy))
                {
                    sb.Append(where.ToString());
                }
                else
                {
                    lock (where)
                    {
                        string tempOrderBy = where.OrderBy;
                        where.OrderBy = null;
                        sb.Append(where.ToString());
                        where.OrderBy = tempOrderBy;
                    }
                }
                sb.Append(") [__T] WHERE [__T].[__Pos]>");
                sb.Append(skipCount);
                if (topCount < int.MaxValue && (int.MaxValue - topCount > skipCount))
                {
                    sb.Append(" AND [__T].[__Pos]<=");
                    sb.Append(topCount + skipCount);
                    sb.Append(' ');
                }

                AddExpressionParameters(where, cmd);

                cmd.CommandText = SqlQueryUtils.ReplaceDatabaseTokens(sb.ToString(), leftToken, rightToken, paramPrefixToken, wildcharToken, wildsinglecharToken);
                PrepareCommand(cmd);
                return cmd;    
            }
        }
    }
}

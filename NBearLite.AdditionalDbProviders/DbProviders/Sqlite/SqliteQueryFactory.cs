using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;



namespace NBearLite.DbProviders.Sqlite
{
    public class SqliteQueryFactory : NBearLite.SqlQueryFactory
    {
        public SqliteQueryFactory() : base('[', ']', '?', '%', '_', SQLiteFactory.Instance)
        {
        }

        protected override void PrepareCommand(DbCommand cmd)
        {
            base.PrepareCommand(cmd);

            foreach (DbParameter p in cmd.Parameters)
            {
                cmd.CommandText = cmd.CommandText.Replace(p.ParameterName, "?");
                p.ParameterName = "?";

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
                SQLiteParameter sqliteParam = (SQLiteParameter)p;

                if (sqliteParam.DbType != DbType.Guid && type == typeof(Guid))
                {
                    sqliteParam.DbType = DbType.String;
                    sqliteParam.Size = 36;
                    continue;
                }

                if ((p.DbType == DbType.Time || p.DbType == DbType.DateTime) && type == typeof(TimeSpan))
                {
                    sqliteParam.DbType = DbType.Double;
                    sqliteParam.Value = ((TimeSpan)value).TotalDays;
                    continue;
                }

                switch (p.DbType)
                {
                    case DbType.Object:
                        sqliteParam.DbType = DbType.String;
                        p.Value = SerializationManager.Instance.Serialize(value);
                        break;
                }
            }

            //replace sqlite specific function names in cmd.CommandText
            cmd.CommandText = cmd.CommandText
                .Replace("SUBSTRING(", "substr(")
                .Replace("LEN(", "length(")
                .Replace("GETDATE()", "datetime('now')")
                .Replace("GETUTCDATE()", "datetime('now')");

            //remove "("s after FROM and remove ")"s before INNER JOIN
            cmd.CommandText = new System.Text.RegularExpressions.Regex(@"\)+(\sINNER JOIN\s)").Replace(
                new System.Text.RegularExpressions.Regex(@"(\sFROM\s)\(+").Replace(cmd.CommandText, "$1"), "$1");

            //remove "("s after FROM and remove ")"s before LEFT OUTER JOIN
            cmd.CommandText = new System.Text.RegularExpressions.Regex(@"\)+(\sLEFT OUTER JOIN\s)").Replace(
                new System.Text.RegularExpressions.Regex(@"(\sFROM\s)\(+").Replace(cmd.CommandText, "$1"), "$1");

            //remove "("s after FROM and remove ")"s before RIGHT OUTER JOIN
            cmd.CommandText = new System.Text.RegularExpressions.Regex(@"\)+(\sRIGHT OUTER JOIN\s)").Replace(
                new System.Text.RegularExpressions.Regex(@"(\sFROM\s)\(+").Replace(cmd.CommandText, "$1"), "$1");

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

            if (cmd.CommandText.Contains("TRIM("))
            {
                throw new NotSupportedException("Sqlite provider does not support Trim() function.");
            }
            if (cmd.CommandText.Contains("CHARINDEX("))
            {
                throw new NotSupportedException("Sqlite provider does not support IndexOf() function.");
            }
            if (cmd.CommandText.Contains("REPLACE("))
            {
                throw new NotSupportedException("Sqlite provider does not support Replace() function.");
            }
            if (cmd.CommandText.Contains("DATEPART("))
            {
                throw new NotSupportedException("Sqlite provider does not support GetYear()/GetMonth()/GetDay() functions.");
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
                DbCommand cmd = CreateSelectCommand(where, columns);
                if (skipCount == 0)
                {
                    cmd.CommandText += " LIMIT " + topCount;
                }
                else
                {
                    cmd.CommandText +=  " LIMIT " + skipCount;
                    cmd.CommandText +=  "," + topCount;
                }
                return cmd;
            }
        }
    }
}

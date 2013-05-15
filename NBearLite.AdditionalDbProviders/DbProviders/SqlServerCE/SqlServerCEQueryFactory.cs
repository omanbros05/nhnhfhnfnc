using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;

namespace NBearLite.DbProviders.SqlServerCE
{
    public class SqlServerCEQueryFactory : NBearLite.SqlQueryFactory
    {
        public SqlServerCEQueryFactory()
            : base('[', ']', '@', '%', '_', SqlCeProviderFactory.Instance)
        {

        }

        protected override void PrepareCommand(DbCommand cmd)
        {
            base.PrepareCommand(cmd);

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
                SqlCeParameter sqlParam = (SqlCeParameter)p;

                if (type == typeof(Guid))
                {
                    sqlParam.SqlDbType = SqlDbType.UniqueIdentifier;
                    continue;
                }

                switch (p.DbType)
                {
                    case DbType.Binary:
                        if (((byte[])value).Length > 8000)
                        {
                            sqlParam.SqlDbType = SqlDbType.Image;
                        }
                        break;
                    case DbType.Time:
                        sqlParam.SqlDbType = SqlDbType.DateTime;
                        break;
                    case DbType.DateTime:
                        sqlParam.SqlDbType = SqlDbType.DateTime;
                        break;
                    case DbType.AnsiString:
                        if (value.ToString().Length > 8000)
                        {
                            sqlParam.SqlDbType = SqlDbType.Text;
                        }
                        break;
                    case DbType.String:
                        if (value.ToString().Length > 4000)
                        {
                            sqlParam.SqlDbType = SqlDbType.NText;
                        }
                        break;
                    case DbType.Object:
                        sqlParam.SqlDbType = SqlDbType.NText;
                        p.Value = SerializationManager.Instance.Serialize(value);
                        break;
                }

                if (sqlParam.SqlDbType == SqlDbType.DateTime && type == typeof(TimeSpan))
                {
                    sqlParam.Value = new DateTime(1900, 1, 1).Add((TimeSpan)value);
                    continue;
                }
            }

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
                string newSql = cmd.CommandText.Substring(0, pos) + string.Format("cast(cast({0} as money) as float)", columnName);
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
                where.SetOrderBy(new KeyValuePair<string, bool>[] { new KeyValuePair<string, bool>(identyColumn, false) });
            }

            if (topCount == int.MaxValue && skipCount == 0)
            {
                return CreateSelectCommand(where, columns);
            }
            else if (skipCount == 0)
            {
                return CreateSelectTopCommand(where, columns, topCount);
            }
            else
            {
                Check.Require(!string.IsNullOrEmpty(identyColumn), "identyColumn could not be null or empty!");

                identyColumn = ColumnFormatter.ValidColumnName(identyColumn);

                if (identyColumnIsNumber && where.OrderByStartsWith(identyColumn) && (string.IsNullOrEmpty(where.GroupBy) || where.GroupBy == identyColumn))
                {
                    return CreateSelectRangeCommandForSortedRows(where, columns, topCount, skipCount, identyColumn, where.OrderByStartsWith(identyColumn + " DESC"));
                }
                else
                {
                    return CreateSelectRangeCommandForUnsortedRows(where, columns, topCount, skipCount, identyColumn);
                }
            }
        }

        protected virtual DbCommand CreateSelectTopCommand(WhereClip where, string[] columns, int topCount)
        {
            DbCommand cmd = fac.CreateCommand();
            cmd.CommandType = CommandType.Text;

            StringBuilder sb = new StringBuilder("SELECT TOP ");
            sb.Append(topCount);
            sb.Append(' ');
            for (int i = 0; i < columns.Length; ++i)
            {
                SqlQueryUtils.AppendColumnName(sb, columns[i]);

                if (i < columns.Length - 1)
                {
                    sb.Append(',');
                }
            }
            sb.Append(" FROM ");
            sb.Append(where.ToString());

            AddExpressionParameters(where, cmd);

            cmd.CommandText = SqlQueryUtils.ReplaceDatabaseTokens(sb.ToString(), leftToken, rightToken, paramPrefixToken, wildcharToken, wildsinglecharToken);
            PrepareCommand(cmd);
            return cmd;
        }

        protected virtual DbCommand CreateSelectRangeCommandForSortedRows(WhereClip where, string[] columns, int topCount, int skipCount, string identyColumn, bool isIdentyColumnDesc)
        {
            DbCommand cmd = fac.CreateCommand();
            cmd.CommandType = CommandType.Text;

            StringBuilder sb = new StringBuilder("SELECT ");
            if (topCount < int.MaxValue)
            {
                sb.Append("TOP ");
                sb.Append(topCount);
                sb.Append(' ');
            }
            for (int i = 0; i < columns.Length; ++i)
            {
                SqlQueryUtils.AppendColumnName(sb, columns[i]);

                if (i < columns.Length - 1)
                {
                    sb.Append(',');
                }
            }
            sb.Append(" FROM ");

            WhereClip cloneWhere = (WhereClip)where.Clone();

            #region Construct & extend CloneWhere

            StringBuilder sbInside = new StringBuilder();
            sbInside.Append(identyColumn);
            sbInside.Append(" NOT IN (SELECT TOP ");
            sbInside.Append(skipCount);
            sbInside.Append(' ');
            sbInside.Append(identyColumn);
            sbInside.Append(" FROM ");
            sbInside.Append(where.ToString());
            sbInside.Append(")");

            if (cloneWhere.Sql.Length == 0)
            {
                cloneWhere.Sql = sbInside.ToString();
            }
            else
            {
                cloneWhere.Sql = "(" + cloneWhere.Sql.ToString() + ") AND " + sbInside.ToString();
            }

            #endregion

            sb.Append(cloneWhere.ToString());

            AddExpressionParameters(where, cmd);
            AddExpressionParameters(cloneWhere, cmd);

            cmd.CommandText = SqlQueryUtils.ReplaceDatabaseTokens(sb.ToString(), leftToken, rightToken, paramPrefixToken, wildcharToken, wildsinglecharToken);
            PrepareCommand(cmd);
            return cmd;    
        }

        protected virtual System.Data.Common.DbCommand CreateSelectRangeCommandForUnsortedRows(WhereClip where, string[] columns, int topCount, int skipCount, string identyColumn)
        {
            DbCommand cmd = fac.CreateCommand();
            cmd.CommandType = CommandType.Text;

            StringBuilder sb = new StringBuilder("SELECT ");
            if (topCount < int.MaxValue)
            {
                sb.Append("TOP ");
                sb.Append(topCount);
                sb.Append(' ');
            }
            for (int i = 0; i < columns.Length; ++i)
            {
                SqlQueryUtils.AppendColumnName(sb, columns[i]);

                if (i < columns.Length - 1)
                {
                    sb.Append(',');
                }
            }
            sb.Append(" FROM ");

            WhereClip cloneWhere = (WhereClip)where.Clone();

            #region Construct & extend CloneWhere

            StringBuilder sbInside = new StringBuilder();
            sbInside.Append(identyColumn);
            sbInside.Append(" NOT IN (SELECT TOP ");
            sbInside.Append(skipCount);
            sbInside.Append(' ');
            sbInside.Append(identyColumn);
            sbInside.Append(" FROM ");
            sbInside.Append(where.ToString());
            sbInside.Append(")");

            if (cloneWhere.Sql.Length == 0)
            {
                cloneWhere.Sql = sbInside.ToString();
            }
            else
            {
                cloneWhere.Sql = "(" + cloneWhere.Sql.ToString() + ") AND " + sbInside.ToString();
            }

            #endregion

            sb.Append(cloneWhere.ToString());

            AddExpressionParameters(where, cmd);
            AddExpressionParameters(cloneWhere, cmd);

            cmd.CommandText = SqlQueryUtils.ReplaceDatabaseTokens(sb.ToString(), leftToken, rightToken, paramPrefixToken, wildcharToken, wildsinglecharToken);
            PrepareCommand(cmd);
            return cmd;    
        }
    }
}

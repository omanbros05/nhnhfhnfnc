using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Reflection;
using NBearLite;

namespace NBearLite
{
    public sealed class CustomSqlSection
    {
        #region Private Members

        private readonly Database db;
        internal string sql;
        private DbTransaction tran;
        private List<string> inputParamNames = new List<string>();
        private List<DbType> inputParamTypes = new List<DbType>();
        private List<object> inputParamValues = new List<object>();

        private IDataReader FindDataReader()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteReader(cmd) : db.ExecuteReader(cmd, tran);
        }

        private DbCommand PrepareCommand()
        {
            DbCommand cmd = db.QueryFactory.CreateCustomSqlCommand(sql, inputParamNames.ToArray(),
                inputParamTypes.ToArray(), inputParamValues.ToArray());
            return cmd;
        }

        private DataSet FindDataSet()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteDataSet(cmd) : db.ExecuteDataSet(cmd, tran);
        }

        #endregion

        #region Constructors

        public CustomSqlSection(Database db, string sql)
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(sql != null, "sql could not be null.");

            if (System.Configuration.ConfigurationManager.AppSettings[sql] != null)
                sql = System.Configuration.ConfigurationManager.AppSettings[sql];

            this.db = db;
            this.sql = sql;
        }

        #endregion

        #region Public Members

        public CustomSqlSection AddInputParameter(string name, DbType type, object value)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty!");

            inputParamNames.Add(name);
            inputParamTypes.Add(type);
            inputParamValues.Add(value);

            return this;
        }
        
        public CustomSqlSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public int ExecuteNonQuery()
        {
            DbCommand cmd = db.QueryFactory.CreateCustomSqlCommand(sql, inputParamNames.ToArray(),
                inputParamTypes.ToArray(), inputParamValues.ToArray());
            return tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran);
        }

        public object ToScalar()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteScalar(cmd) : db.ExecuteScalar(cmd, tran);
        }

        public object ToScalar(Type returnType)
        {
            Check.Require(returnType, "returnType");

            object retValue = ToScalar();

            if (retValue == null || retValue == DBNull.Value)
                return CommonUtils.DefaultValue(returnType);

            if (returnType == typeof(Guid))
            {
                return DataUtils.ToGuid(ToScalar());
            }

            return Convert.ChangeType(retValue, returnType);
        }

        public ReturnType ToScalar<ReturnType>()
        {
            return (ReturnType)ToScalar(typeof(ReturnType));
        }

        public SubQuery ToSubQuery()
        {
            DbCommand cmd = PrepareCommand();
            SubQuery expr = new SubQuery(this.db);
            expr.Sql = "(" + cmd.CommandText + ")";
            for (int i = 0; i < cmd.Parameters.Count; ++i)
            {
                expr.Parameters.Add('@' + cmd.Parameters[i].ParameterName.TrimStart("@:?".ToCharArray()), new KeyValuePair<DbType, object>(cmd.Parameters[i].DbType, cmd.Parameters[i].Value));
            }
            return expr;
        }

        public T ToSingleObject<T>()
            where T : class
        {
            T retObj = default(T);

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObj;

                if (reader.Read())
                    retObj = NBear.Mapping.ObjectConvertor.ToObject<IDataReader, T>(reader);

                reader.Close();
            }

            return retObj;
        }

        public T ToSingleObject<T>(string viewName)
            where T : class
        {
            Check.Require(viewName, "viewName", Check.NotNullOrEmpty);

            T retObj = default(T);

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObj;

                if (reader.Read())
                    retObj = NBear.Mapping.ObjectConvertor.ToObject<IDataReader, T>(reader, viewName);

                reader.Close();
            }

            return retObj;
        }

        public T[] ToArray<T>()
            where T : class
        {
            T[] retObjs = null;

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObjs;

                retObjs = NBear.Mapping.ObjectConvertor.ToArray<IDataReader, T>(reader);

                reader.Close();
            }

            return retObjs;
        }

        public List<T> ToList<T>()
            where T : class
        {
            return CommonUtils.ConvertArrayToList<T>(ToArray<T>());
        }

        public T[] ToArray<T>(string viewName)
            where T : class
        {
            Check.Require(viewName, "viewName", Check.NotNullOrEmpty);

            T[] retObjs = null;

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObjs;

                retObjs = NBear.Mapping.ObjectConvertor.ToArray<IDataReader, T>(reader, viewName);

                reader.Close();
            }

            return retObjs;
        }

        public List<T> ToList<T>(string viewName)
            where T : class
        {
            return CommonUtils.ConvertArrayToList<T>(ToArray<T>(viewName));
        }

        public IDataReader ToDataReader()
        {
            return FindDataReader();
        }

        public DataSet ToDataSet()
        {
            return FindDataSet();
        }

        #endregion
    }
    
    public sealed class SelectSqlSection
    {
        #region Private Members

        private readonly Database db;
        private readonly string tableName;
        private string[] columnNames = new string[] { "*" };
        private DbTransaction tran;
        private WhereClip whereClip;
        private int topItemCount = int.MaxValue;
        private int skipItemCount = 0;
        private string identyColumnName;
        private bool identyColumnIsNumber = false;

        private DbCommand PrepareCommand()
        {
            DbCommand cmd = db.QueryFactory.CreateSelectRangeCommand(whereClip, columnNames, topItemCount,
                skipItemCount, identyColumnName, identyColumnIsNumber);
            if (cmd != null)
            {
                string topDistinctPrefix = "SELECT TOP " + this.topItemCount.ToString() + " DISTINCT";
                if (this.topItemCount > 0 && this.skipItemCount == 0 && cmd.CommandText.StartsWith(topDistinctPrefix))
                {
                    cmd.CommandText = cmd.CommandText.Replace(topDistinctPrefix, "SELECT DISTINCT TOP " + this.topItemCount.ToString());
                }
            }
            return cmd;
        }

        #endregion

        #region Constructors

        public SelectSqlSection(Database db, IQueryTable table, params ExpressionClip[] columns)
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(table != null, "table could not be null.");

            this.db = db;
            this.tableName = table.___GetTableName();

            this.whereClip = new WhereClip(new FromClip(this.tableName));

            if (table is IExpression)
                SqlQueryUtils.AddParameters(this.whereClip.Parameters, table as IExpression);

            if (columns != null && columns.Length > 0)
            {
                this.columnNames = new string[columns.Length];
                for (int i = 0; i < columns.Length; ++i)
                {
                    this.columnNames[i] = columns[i].ToString();

                    //add parameters in column to whereClip
                    if (columns[i].Parameters.Count > 0)
                    {
                        SqlQueryUtils.AddParameters(this.whereClip.Parameters, columns[i]);
                    }
                }
            }            
        }

        #endregion

        #region Public Methods

        public SelectSqlSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public SelectSqlSection Where(List<WhereClip> Clips)
        {
            foreach (WhereClip clip in Clips)
                whereClip.And(clip);

            return this;
        }

        public SelectSqlSection Where(WhereClip where)
        {
            whereClip.And(where);

            return this;
        }

        public SelectSqlSection OrderBy(params OrderByClip[] orderBys)
        {
            if (orderBys != null && orderBys.Length > 0)
            {
                if (orderBys.Length == 1)
                {
                    whereClip.SetOrderBy(orderBys[0].OrderBys.ToArray());
                }
                else
                {
                    OrderByClip combinedOrderBy = new OrderByClip();
                    for (int i = 0; i < orderBys.Length; ++i)
                    {
                        combinedOrderBy = combinedOrderBy & orderBys[i];
                    }
                    whereClip.SetOrderBy(combinedOrderBy.OrderBys.ToArray());
                }
            }

            return this;
        }

        public SelectSqlSection GroupBy(params QueryColumn[] columns)
        {
            if (columns != null && columns.Length > 0)
            {
                string[] columnNames = new string[columns.Length];
                for (int i = 0; i < columns.Length; ++i)
                {
                    columnNames[i] = columns[i].Name;
                }
                this.whereClip.SetGroupBy(columnNames);
            }

            return this;
        }

        public SelectSqlSection SetSelectRange(int topItemCount, int skipItemCount, QueryColumn identyColumn)
        {
            Check.Require(topItemCount > 0, "topItemCount MUST > 0");
            Check.Require(skipItemCount >= 0, "skipItemCount MUST >= 0");
            Check.Require(!QueryColumn.IsNullOrEmpty(identyColumn), "identyColumn could not be null.");

            this.topItemCount = topItemCount;
            this.skipItemCount = skipItemCount;
            this.identyColumnName = identyColumn.Name;
            this.identyColumnIsNumber = 
                (identyColumn.DbType == DbType.Int32) ||
                (identyColumn.DbType == DbType.Int16) ||
                (identyColumn.DbType == DbType.Int64) ||
                (identyColumn.DbType == DbType.Byte) ||
                (identyColumn.DbType == DbType.Double) ||
                (identyColumn.DbType == DbType.Currency) ||
                (identyColumn.DbType == DbType.Decimal) ||
                (identyColumn.DbType == DbType.SByte) ||
                (identyColumn.DbType == DbType.Single) ||
                (identyColumn.DbType == DbType.UInt16) ||
                (identyColumn.DbType == DbType.UInt32) ||
                (identyColumn.DbType == DbType.UInt64);

            return this;
        }

        public SelectSqlSection Join(IQueryTable joinTable, string joinTableAliasName, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");
            Check.Require(!string.IsNullOrEmpty(joinTableAliasName), "joinTableAliasName could not be null or empty.");
            Check.Require(!WhereClip.IsNullOrEmpty(joinOnWhere), "joinOnWhere could not be null or empty.");

            this.whereClip.From.Join(joinTable.___GetTableName(), joinTableAliasName, joinOnWhere);

            return this;
        }

        public SelectSqlSection Join(IQueryTable joinTable, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");

            return Join(joinTable, joinTable.___GetTableName(), joinOnWhere);
        }

        public SelectSqlSection LeftJoin(IQueryTable joinTable, string joinTableAliasName, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");
            Check.Require(!string.IsNullOrEmpty(joinTableAliasName), "joinTableAliasName could not be null or empty.");
            Check.Require(!WhereClip.IsNullOrEmpty(joinOnWhere), "joinOnWhere could not be null or empty.");

            this.whereClip.From.LeftJoin(joinTable.___GetTableName(), joinTableAliasName, joinOnWhere);

            return this;
        }

        public SelectSqlSection LeftJoin(IQueryTable joinTable, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");

            return LeftJoin(joinTable, joinTable.___GetTableName(), joinOnWhere);
        }

        public SelectSqlSection RightJoin(IQueryTable joinTable, string joinTableAliasName, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");
            Check.Require(!string.IsNullOrEmpty(joinTableAliasName), "joinTableAliasName could not be null or empty.");
            Check.Require(!WhereClip.IsNullOrEmpty(joinOnWhere), "joinOnWhere could not be null or empty.");

            this.whereClip.From.RightJoin(joinTable.___GetTableName(), joinTableAliasName, joinOnWhere);

            return this;
        }

        public SelectSqlSection RightJoin(IQueryTable joinTable, WhereClip joinOnWhere)
        {
            Check.Require(joinTable != null, "joinTable could not be null.");

            return RightJoin(joinTable, joinTable.___GetTableName(), joinOnWhere);
        }

        public object ToScalar()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteScalar(cmd) : db.ExecuteScalar(cmd, tran);
        }

        public object ToScalar(Type returnType)
        {
            Check.Require(returnType, "returnType");

            object retValue = ToScalar();

            if (retValue == null || retValue == DBNull.Value)
                return CommonUtils.DefaultValue(returnType);

            if (returnType == typeof(Guid))
            {
                return DataUtils.ToGuid(ToScalar());
            }

            return Convert.ChangeType(retValue, returnType);
        }

        public ReturnType ToScalar<ReturnType>()
        {
            return (ReturnType)ToScalar(typeof(ReturnType));
        }

        public IDataReader ToDataReader()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteReader(cmd) : db.ExecuteReader(cmd, tran);
        }

        public DataSet ToDataSet()
        {
            DbCommand cmd = PrepareCommand();
            return tran == null ? db.ExecuteDataSet(cmd) : db.ExecuteDataSet(cmd, tran);
        }

        public DbCommand ToDbCommand()
        {
            return PrepareCommand();
        }

        public string ToDbCommandText()
        {
            return ToDbCommandText(true);
        }

        /// <summary>
        /// If fillParameterValues == false, you must specify the parameter names you want to be in the returning sql.
        /// </summary>
        /// <param name="fillParameterValues"></param>
        /// <param name="parameterNames"></param>
        /// <returns></returns>
        public string ToDbCommandText(bool fillParameterValues, params string[] parameterNames)
        {
            if (fillParameterValues)
                return DataUtils.ToString(ToDbCommand());
            else
            {
                DbCommand cmd = ToDbCommand();
                string sql = cmd.CommandText;

                if (!string.IsNullOrEmpty(sql) && parameterNames != null)
                {
                    Check.Require(parameterNames.Length == cmd.Parameters.Count, "The Specified count of parameter names does not equal the count of parameter names in the query.");

                    System.Collections.IEnumerator en = cmd.Parameters.GetEnumerator();
                    int i = 0;
                    while (en.MoveNext())
                    {
                        Check.Require(parameterNames[i], "parameterNames[" + i + "]", Check.NotNullOrEmpty);

                        System.Data.Common.DbParameter p = (System.Data.Common.DbParameter)en.Current;
                        sql = sql.Replace(p.ParameterName, p.ParameterName[0] + parameterNames[i].TrimStart(p.ParameterName[0]));
                        ++i;
                    }
                }

                return sql;
            }
        }

        public SubQuery ToSubQuery()
        {
            DbCommand cmd = PrepareCommand();
            SubQuery expr = new SubQuery(this.db);
            expr.Sql = "(" + cmd.CommandText + ")";
            for (int i = 0; i < cmd.Parameters.Count; ++i)
            {
                expr.Parameters.Add('@' + cmd.Parameters[i].ParameterName.TrimStart("@:?".ToCharArray()), new KeyValuePair<DbType, object>(cmd.Parameters[i].DbType, cmd.Parameters[i].Value));
            }
            return expr;
        }

        public T ToSingleObject<T>()
            where T : class
        {
            T retObj = default(T);

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObj;

                if (reader.Read())
                    retObj = NBear.Mapping.ObjectConvertor.ToObject<IDataReader, T>(reader);

                reader.Close();
            }

            return retObj;
        }

        public T ToSingleObject<T>(string viewName)
            where T : class
        {
            Check.Require(viewName, "viewName", Check.NotNullOrEmpty);

            T retObj = default(T);

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObj;

                if (reader.Read())
                    retObj = NBear.Mapping.ObjectConvertor.ToObject<IDataReader, T>(reader, viewName);

                reader.Close();
            }

            return retObj;
        }

        public T[] ToArray<T>()
            where T : class
        {
            T[] retObjs = null;

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObjs;

                retObjs = NBear.Mapping.ObjectConvertor.ToArray<IDataReader, T>(reader);

                reader.Close();
            }

            return retObjs;
        }

        public List<T> ToList<T>()
            where T : class
        {
            return CommonUtils.ConvertArrayToList<T>(ToArray<T>());
        }

        public T[] ToArray<T>(string viewName)
            where T : class
        {
            Check.Require(viewName, "viewName", Check.NotNullOrEmpty);

            T[] retObjs = null;

            using (IDataReader reader = this.ToDataReader())
            {
                if (reader == null)
                    return retObjs;

                retObjs = NBear.Mapping.ObjectConvertor.ToArray<IDataReader, T>(reader, viewName);

                reader.Close();
            }

            return retObjs;
        }

        public List<T> ToList<T>(string viewName)
            where T : class
        {
            return CommonUtils.ConvertArrayToList<T>(ToArray<T>(viewName));
        }

        #endregion
    }

    public sealed class UpdateSqlSection
    {
        #region Private Members

        private readonly Database db;
        private readonly string tableName;
        private List<string> columnNames = new List<string>();
        private List<DbType> columnTypes = new List<DbType>();
        private List<object> columnValues = new List<object>();
        private DbTransaction tran;
        private WhereClip whereClip = new WhereClip();

        #endregion

        #region Constructors

        public UpdateSqlSection(Database db, IQueryTable table)
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(table != null, "table could not be null.");

            this.db = db;
            this.tableName = table.___GetTableName();
        }

        #endregion

        #region Public Methods

        public UpdateSqlSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public UpdateSqlSection AddColumn(QueryColumn column, object value)
        {
            Check.Require(!QueryColumn.IsNullOrEmpty(column), "column could not be null.");

            columnNames.Add(column.Name.IndexOf('.') > 0 ? column.Name.Split('.')[1] : column.Name);
            columnTypes.Add(column.DbType);
            columnValues.Add(value);

            return this;
        }

        public UpdateSqlSection Where(WhereClip where)
        {
            whereClip.And(where);

            return this;
        }

        public int Execute()
        {
            DbCommand cmd = db.QueryFactory.CreateUpdateCommand(tableName, whereClip, columnNames.ToArray(),
                columnTypes.ToArray(), columnValues.ToArray());
            return tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran);
        }

        public DbCommand ToDbCommand()
        {
            return db.QueryFactory.CreateUpdateCommand(tableName, whereClip, columnNames.ToArray(),
                columnTypes.ToArray(), columnValues.ToArray());
        }

        public string ToDbCommandText()
        {
            return ToDbCommandText(true);
        }

        /// <summary>
        /// If fillParameterValues == false, you must specify the parameter names you want to be in the returning sql.
        /// </summary>
        /// <param name="fillParameterValues"></param>
        /// <param name="parameterNames"></param>
        /// <returns></returns>
        public string ToDbCommandText(bool fillParameterValues, params string[] parameterNames)
        {
            if (fillParameterValues)
                return DataUtils.ToString(ToDbCommand());
            else
            {
                DbCommand cmd = ToDbCommand();
                string sql = cmd.CommandText;

                if (!string.IsNullOrEmpty(sql) && parameterNames != null)
                {
                    Check.Require(parameterNames.Length == cmd.Parameters.Count, "The Specified count of parameter names does not equal the count of parameter names in the query.");

                    System.Collections.IEnumerator en = cmd.Parameters.GetEnumerator();
                    int i = 0;
                    while (en.MoveNext())
                    {
                        Check.Require(parameterNames[i], "parameterNames[" + i + "]", Check.NotNullOrEmpty);

                        System.Data.Common.DbParameter p = (System.Data.Common.DbParameter)en.Current;
                        sql = sql.Replace(p.ParameterName, p.ParameterName[0] + parameterNames[i].TrimStart(p.ParameterName[0]));
                        ++i;
                    }
                }

                return sql;
            }
        }

        #endregion
    }

    public sealed class InsertSqlSection
    {
        #region Private Members

        private readonly Database db;
        private readonly string tableName;
        private List<string> columnNames = new List<string>();
        private List<DbType> columnTypes = new List<DbType>();
        private List<object> columnValues = new List<object>();
        private DbTransaction tran;

        #endregion

        #region Constructors

        public InsertSqlSection(Database db, IQueryTable table)
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(table != null, "table could not be null.");

            this.db = db;
            this.tableName = table.___GetTableName();
        }

        #endregion

        #region Public Methods

        public InsertSqlSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public InsertSqlSection AddColumn(QueryColumn column, object value)
        {
            Check.Require(!QueryColumn.IsNullOrEmpty(column), "column could not be null.");

            columnNames.Add(column.Name.IndexOf('.') > 0 ? column.Name.Split('.')[1] : column.Name);
            columnTypes.Add(column.DbType);
            columnValues.Add(value);

            return this;
        }

        public int Execute()
        {
            DbCommand cmd = db.QueryFactory.CreateInsertCommand(tableName, columnNames.ToArray(),
                columnTypes.ToArray(), columnValues.ToArray());
            return tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran);
        }

        public int ExecuteReturnAutoIncrementID(QueryColumn autoIncrementColumn)
        {
            Check.Require(!QueryColumn.IsNullOrEmpty(autoIncrementColumn), "autoIncrementColumn could not be null or empty.");

            string filteredAutoColumn = autoIncrementColumn.Name.IndexOf('.') > 0 ? autoIncrementColumn.Name.Split('.')[1] : autoIncrementColumn.Name;

            DbCommand cmd = db.QueryFactory.CreateInsertCommand(tableName, columnNames.ToArray(),
                columnTypes.ToArray(), columnValues.ToArray());
            return tran == null ? db.ExecuteInsertReturnAutoIncrementID(cmd, tableName, filteredAutoColumn)
                : db.ExecuteInsertReturnAutoIncrementID(cmd, tran, tableName, 
                filteredAutoColumn);
        }

        public DbCommand ToDbCommand()
        {
            return db.QueryFactory.CreateInsertCommand(tableName, columnNames.ToArray(),
                columnTypes.ToArray(), columnValues.ToArray());
        }

        public string ToDbCommandText()
        {
            return ToDbCommandText(true);
        }

        /// <summary>
        /// If fillParameterValues == false, you must specify the parameter names you want to be in the returning sql.
        /// </summary>
        /// <param name="fillParameterValues"></param>
        /// <param name="parameterNames"></param>
        /// <returns></returns>
        public string ToDbCommandText(bool fillParameterValues, params string[] parameterNames)
        {
            if (fillParameterValues)
                return DataUtils.ToString(ToDbCommand());
            else
            {
                DbCommand cmd = ToDbCommand();
                string sql = cmd.CommandText;

                if (!string.IsNullOrEmpty(sql) && parameterNames != null)
                {
                    Check.Require(parameterNames.Length == cmd.Parameters.Count, "The Specified count of parameter names does not equal the count of parameter names in the query.");

                    System.Collections.IEnumerator en = cmd.Parameters.GetEnumerator();
                    int i = 0;
                    while (en.MoveNext())
                    {
                        Check.Require(parameterNames[i], "parameterNames[" + i + "]", Check.NotNullOrEmpty);

                        System.Data.Common.DbParameter p = (System.Data.Common.DbParameter)en.Current;
                        sql = sql.Replace(p.ParameterName, p.ParameterName[0] + parameterNames[i].TrimStart(p.ParameterName[0]));
                        ++i;
                    }
                }

                return sql;
            }
        }
        #endregion
    }

    public sealed class DeleteSqlSection
    {
        #region Private Members

        private readonly Database db;
        private readonly string tableName;
        private DbTransaction tran;
        private WhereClip whereClip = new WhereClip();

        #endregion

        #region Constructors

        public DeleteSqlSection(Database db, IQueryTable table)
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(table != null, "table could not be null.");

            this.db = db;
            this.tableName = table.___GetTableName();
        }

        #endregion

        #region Public Methods

        public DeleteSqlSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public DeleteSqlSection Where(WhereClip where)
        {
            whereClip.And(where);

            return this;
        }

        public int Execute()
        {
            DbCommand cmd = db.QueryFactory.CreateDeleteCommand(tableName, whereClip);
            return tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran);
        }

        public DbCommand ToDbCommand()
        {
            return db.QueryFactory.CreateDeleteCommand(tableName, whereClip);
        }

        public string ToDbCommandText()
        {
            return ToDbCommandText(true);
        }

        /// <summary>
        /// If fillParameterValues == false, you must specify the parameter names you want to be in the returning sql.
        /// </summary>
        /// <param name="fillParameterValues"></param>
        /// <param name="parameterNames"></param>
        /// <returns></returns>
        public string ToDbCommandText(bool fillParameterValues, params string[] parameterNames)
        {
            if (fillParameterValues)
                return DataUtils.ToString(ToDbCommand());
            else
            {
                DbCommand cmd = ToDbCommand();
                string sql = cmd.CommandText;

                if (!string.IsNullOrEmpty(sql) && parameterNames != null)
                {
                    Check.Require(parameterNames.Length == cmd.Parameters.Count, "The Specified count of parameter names does not equal the count of parameter names in the query.");

                    System.Collections.IEnumerator en = cmd.Parameters.GetEnumerator();
                    int i = 0;
                    while (en.MoveNext())
                    {
                        Check.Require(parameterNames[i], "parameterNames[" + i + "]", Check.NotNullOrEmpty);

                        System.Data.Common.DbParameter p = (System.Data.Common.DbParameter)en.Current;
                        sql = sql.Replace(p.ParameterName, p.ParameterName[0] + parameterNames[i].TrimStart(p.ParameterName[0]));
                        ++i;
                    }
                }

                return sql;
            }
        }

        #endregion
    }

    public sealed class StoredProcedureSection
    {
        #region Private Members

        private Database db;
        private string spName;
        private DbTransaction tran;

        private List<string> inputParamNames = new List<string>();
        private List<DbType> inputParamTypes = new List<DbType>();
        private List<object> inputParamValues = new List<object>();

        private List<string> outputParamNames = new List<string>();
        private List<DbType> outputParamTypes = new List<DbType>();
        private List<int> outputParamSizes = new List<int>();

        private List<string> inputOutputParamNames = new List<string>();
        private List<DbType> inputOutputParamTypes = new List<DbType>();
        private List<object> inputOutputParamValues = new List<object>();
        private List<int> inputOutputParamSizes = new List<int>();

        private string returnValueParamName;
        private DbType returnValueParamType;
        private int returnValueParamSize;

        private IDataReader FindDataReader()
        {
            DbCommand cmd = db.QueryFactory.CreateStoredProcedureCommand(spName, 
                inputParamNames.ToArray(), inputParamTypes.ToArray(), inputParamValues.ToArray(),
                outputParamNames.ToArray(), outputParamTypes.ToArray(), outputParamSizes.ToArray(),
                inputOutputParamNames.ToArray(), inputOutputParamTypes.ToArray(), inputOutputParamSizes.ToArray(), inputOutputParamValues.ToArray(),
                returnValueParamName, returnValueParamType, returnValueParamSize);
            return tran == null ? db.ExecuteReader(cmd) : db.ExecuteReader(cmd, tran);
        }

        private DataSet FindDataSet()
        {
            DbCommand cmd = db.QueryFactory.CreateStoredProcedureCommand(spName, 
                inputParamNames.ToArray(), inputParamTypes.ToArray(), inputParamValues.ToArray(),
                outputParamNames.ToArray(), outputParamTypes.ToArray(), outputParamSizes.ToArray(),
                inputOutputParamNames.ToArray(), inputOutputParamTypes.ToArray(), inputOutputParamSizes.ToArray(), inputOutputParamValues.ToArray(),
                returnValueParamName, returnValueParamType, returnValueParamSize);
            return tran == null ? db.ExecuteDataSet(cmd) : db.ExecuteDataSet(cmd, tran);
        }

        private DataSet FindDataSet(out Dictionary<string, object> outValues)
        {
            DbCommand cmd = db.QueryFactory.CreateStoredProcedureCommand(spName, 
                inputParamNames.ToArray(), inputParamTypes.ToArray(), inputParamValues.ToArray(),
                outputParamNames.ToArray(), outputParamTypes.ToArray(), outputParamSizes.ToArray(),
                inputOutputParamNames.ToArray(), inputOutputParamTypes.ToArray(), inputOutputParamSizes.ToArray(), inputOutputParamValues.ToArray(),
                returnValueParamName, returnValueParamType, returnValueParamSize);
            DataSet ds = (tran == null ? db.ExecuteDataSet(cmd) : db.ExecuteDataSet(cmd, tran));
            outValues = GetOutputParameterValues(cmd);
            return ds;
        }

        private static Dictionary<string, object> GetOutputParameterValues(DbCommand cmd)
        {
            Dictionary<string, object> outValues;
            outValues = new Dictionary<string, object>();
            for (int i = 0; i < cmd.Parameters.Count; ++i)
            {
                if (cmd.Parameters[i].Direction == ParameterDirection.InputOutput || cmd.Parameters[i].Direction == ParameterDirection.Output || cmd.Parameters[i].Direction == ParameterDirection.ReturnValue)
                {
                    outValues.Add(cmd.Parameters[i].ParameterName.Substring(1, cmd.Parameters[i].ParameterName.Length - 1),
                        cmd.Parameters[i].Value == DBNull.Value ? null : cmd.Parameters[i].Value);
                }
            }
            return outValues;
        }

        #endregion

        #region Constructors

        public StoredProcedureSection(Database db, string spName) : base()
        {
            Check.Require(db != null, "db could not be null.");
            Check.Require(spName != null, "spName could not be null.");

            this.db = db;
            this.spName = spName;
        }

        #endregion

        #region Public Members

        public StoredProcedureSection AddInputParameter(string name, DbType type, object value)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty!");

            inputParamNames.Add(name);
            inputParamTypes.Add(type);
            inputParamValues.Add(value);

            return this;
        }

        public StoredProcedureSection AddOutputParameter(string name, DbType type, int size)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty!");

            outputParamNames.Add(name);
            outputParamTypes.Add(type);
            outputParamSizes.Add(size);

            return this;
        }

        public StoredProcedureSection AddInputOutputParameter(string name, DbType type, int size, object value)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty!");

            inputOutputParamNames.Add(name);
            inputOutputParamTypes.Add(type);
            inputOutputParamSizes.Add(size);
            inputOutputParamValues.Add(value);

            return this;
        }

        public StoredProcedureSection SetReturnParameter(string name, DbType type, int size)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty!");

            returnValueParamName = name;
            returnValueParamType = type;
            returnValueParamSize = size;

            return this;
        }
        
        public StoredProcedureSection SetTransaction(DbTransaction tran)
        {
            this.tran = tran;

            return this;
        }

        public int ExecuteNonQuery()
        {
            DbCommand cmd = db.QueryFactory.CreateStoredProcedureCommand(spName, 
                inputParamNames.ToArray(), inputParamTypes.ToArray(), inputParamValues.ToArray(),
                outputParamNames.ToArray(), outputParamTypes.ToArray(), outputParamSizes.ToArray(),
                inputOutputParamNames.ToArray(), inputOutputParamTypes.ToArray(), inputOutputParamSizes.ToArray(), inputOutputParamValues.ToArray(),
                returnValueParamName, returnValueParamType, returnValueParamSize);
            return tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran);
        }

        public int ExecuteNonQuery(out Dictionary<string, object> outValues)
        {
            DbCommand cmd = db.QueryFactory.CreateStoredProcedureCommand(spName, 
                inputParamNames.ToArray(), inputParamTypes.ToArray(), inputParamValues.ToArray(),
                outputParamNames.ToArray(), outputParamTypes.ToArray(), outputParamSizes.ToArray(),
                inputOutputParamNames.ToArray(), inputOutputParamTypes.ToArray(), inputOutputParamSizes.ToArray(), inputOutputParamValues.ToArray(),
                returnValueParamName, returnValueParamType, returnValueParamSize);
            int affactRows = (tran == null ? db.ExecuteNonQuery(cmd) : db.ExecuteNonQuery(cmd, tran));
            outValues = GetOutputParameterValues(cmd);
            return affactRows;
        }

        public object ToScalar()
        {
            IDataReader reader = FindDataReader();
            object retObj = null;
            if (reader.Read())
            {
                retObj = reader.GetValue(0);
            }
            reader.Close();
            reader.Dispose();

            return retObj;
        }

        public IDataReader ToDataReader()
        {
            return FindDataReader();
        }

        public DataSet ToDataSet()
        {
            return FindDataSet();
        }

        public object ToScalar(out Dictionary<string, object> outValues)
        {
            DataSet ds = FindDataSet(out outValues);
            object retObj = null;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                retObj = ds.Tables[0].Rows[0][0];
            }
            ds.Dispose();

            return retObj;
        }

        public DataSet ToDataSet(out Dictionary<string, object> outValues)
        {
            return FindDataSet(out outValues);
        }

        #endregion
    }

    public interface IQueryTable
    {
        string ___GetTableName();
    }

    public class CustomQueryTable : IQueryTable, IExpression
    {
        private readonly string tableName;
        private readonly Dictionary<string, KeyValuePair<DbType, object>> parameters = new Dictionary<string, KeyValuePair<DbType, object>>();

        public CustomQueryTable(string tableName)
        {
            Check.Require(tableName, "tableName", Check.NotNullOrEmpty);

            this.tableName = tableName;
        }

        public CustomQueryTable(SubQuery subQuery)
        {
            Check.Require(subQuery, "subQuery");

            this.tableName = subQuery.ToString();
            SqlQueryUtils.AddParameters(this.parameters, subQuery);
        }

        #region IQueryTable Members

        public string ___GetTableName()
        {
            return tableName;
        }

        #endregion

        #region IExpression Members

        public string Sql
        {
            get
            {
                return tableName;
            }
            set
            {
                throw new Exception("Could not change table name of a CustomQueryTable, you can only specify the table name in constructor.");
            }
        }

        public Dictionary<string, KeyValuePair<DbType, object>> Parameters
        {
            get 
            {
                return parameters;
            }
        }

        #endregion
    }

    public sealed class QueryColumn : ExpressionClip
    {
        public static QueryColumn All()
        {
            return new QueryColumn("*", DbType.Int32);
        }

        public static QueryColumn All(IQueryTable table)
        {
            if (table == null)
                return new QueryColumn("*", DbType.Int32);

            return new QueryColumn(string.Format("[{0}].*", table.___GetTableName()), DbType.Int32);
        }

        public string Name
        {
            get
            {
                return this.ToString().Replace("[", string.Empty).Replace("]", string.Empty);
            }
        }

        public OrderByClip Desc
        {
            get
            {
                return new OrderByClip(this, true);
            }
        }

        public OrderByClip Asc
        {
            get
            {
                return new OrderByClip(this, false);
            }
        }

        public QueryColumn(string name, DbType type)
        {
            Check.Require(!string.IsNullOrEmpty(name), "name could not be null or empty.");

            SqlQueryUtils.AppendColumnName(this.sql, name);
            this.DbType = type;
        }
    }

    /// <summary>
    /// Strong typed orderby clip, used internal only.
    /// </summary>
    public class OrderByClip
    {
        List<KeyValuePair<string, bool>> orderBys = new List<KeyValuePair<string, bool>>();

        /// <summary>
        /// Returns a <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            List<KeyValuePair<string, bool>>.Enumerator en = orderBys.GetEnumerator();
            while (en.MoveNext())
            {
                if (sb.Length > 0)
                {
                    sb.Append(',');
                }

                if ((!en.Current.Key.Contains("(")) && (!en.Current.Key.Contains(",")))
                {
                    if (en.Current.Key.Contains("."))
                    {
                        string[] splittedColumnSections = en.Current.Key.Split('.');
                        for (int i = 0; i < splittedColumnSections.Length; ++i)
                        {
                            if (splittedColumnSections[i][0] != '[')
                            {
                                sb.Append('[');
                                sb.Append(splittedColumnSections[i]);
                                sb.Append(']');
                            }
                            else
                                sb.Append(splittedColumnSections[i]);


                            if (i < splittedColumnSections.Length - 1)
                            {
                                sb.Append('.');
                            }
                        }
                    }
                    else
                    {
                        if (en.Current.Key[0] != '[')
                        {
                            sb.Append('[');
                            sb.Append(en.Current.Key);
                            sb.Append(']');
                        }
                        else
                            sb.Append(en.Current.Key);
                    }
                }
                else
                {
                    sb.Append(en.Current.Key);
                }

                if (en.Current.Value)
                {
                    sb.Append(" DESC");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByClip"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="descend">if set to <c>true</c> [descend].</param>
        public OrderByClip(ExpressionClip item, bool descend)
        {
            Check.Require(!ExpressionClip.IsNullOrEmpty(item), "item could not be null or empty.");

            string itemStr = item.ToString();
            while (itemStr.IndexOf("] [") > 0)
                itemStr = itemStr.Substring(itemStr.IndexOf("] [") + 2);

            orderBys.Add(new KeyValuePair<string, bool>(itemStr, descend));
        }
        
        internal OrderByClip()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByClip"/> class.
        /// </summary>
        /// <param name="orderByStr">The order by STR.</param>
        public OrderByClip(string orderByStr)
        {
            if (orderByStr == null)
            {
                return;
            }

            if ((!orderByStr.Contains("(")) && (!orderByStr.Contains(",")))
            {
                string[] splittedOrderByStr = orderByStr.Split(',');
                for (int i = 0; i < splittedOrderByStr.Length; ++i)
                {
                    bool isDesc = false;
                    splittedOrderByStr[i] = splittedOrderByStr[i].Trim();
                    if (splittedOrderByStr[i].ToUpper().EndsWith(" DESC"))
                    {
                        isDesc = true;
                        splittedOrderByStr[i] = splittedOrderByStr[i].Substring(0, splittedOrderByStr[i].Length - 5);
                    }
                    else if (splittedOrderByStr[i].ToUpper().EndsWith(" ASC"))
                    {
                        splittedOrderByStr[i] = splittedOrderByStr[i].Substring(0, splittedOrderByStr[i].Length - 4);
                    }
                    orderBys.Add(new KeyValuePair<string, bool>(splittedOrderByStr[i], isDesc));
                }
            }
            else
            {
                orderBys.Add(new KeyValuePair<string, bool>(orderByStr, false));
            }
        }

        /// <summary>
        /// And two orderby clips.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>The combined order by clip.</returns>
        public static OrderByClip operator &(OrderByClip left, OrderByClip right)
        {
            Check.Require(left != null, "left could not be null.");
            Check.Require(right != null, "right could not be null.");

            if (left.orderBys.Count >= 0 && right.orderBys.Count >= 0)
            {
                OrderByClip newOrderBy = new OrderByClip();
                List<KeyValuePair<string, bool>>.Enumerator en = left.orderBys.GetEnumerator();
                while (en.MoveNext())
                {
                    newOrderBy.orderBys.Add(new KeyValuePair<string, bool>(en.Current.Key, en.Current.Value));
                }
                en = right.orderBys.GetEnumerator();
                while (en.MoveNext())
                {
                    newOrderBy.orderBys.Add(new KeyValuePair<string, bool>(en.Current.Key, en.Current.Value));
                }
                return newOrderBy;
            }
            else if (left.orderBys.Count >= 0 && right.orderBys.Count == 0)
            {
                return left;
            }
            else if (left.orderBys.Count == 0 && right.orderBys.Count > 0)
            {
                return right;
            }
            else
            {
                return new OrderByClip();
            }
        }

        /// <summary>
        /// Operator trues the specified right.
        /// </summary>
        /// <param name="right">The right.</param>
        /// <returns></returns>
        public static bool operator true(OrderByClip right)
        {
            return false;
        }

        /// <summary>
        /// Operator falses the specified right.
        /// </summary>
        /// <param name="right">The right.</param>
        /// <returns></returns>
        public static bool operator false(OrderByClip right)
        {
            return false;
        }

        public List<KeyValuePair<string, bool>> OrderBys
        {
            get
            {
                return orderBys;
            }
        }
    }

    public class SubQuery : ExpressionClip
    {
        public readonly Database Db;

        internal SubQuery(Database db)
        {
            Check.Require(db, "db");

            this.Db = db;
        }

        public new SubQuery Alias(string aliasName)
        {
            Check.Require(aliasName, "aliasName", Check.NotNullOrEmpty);

            this.sql.Append(' ');
            SqlQueryUtils.AppendColumnName(this.sql, aliasName);

            return this;
        }

        public SelectSqlSection Select(params ExpressionClip[] columns)
        {
            Check.Require(columns, "columns", Check.NotNullOrEmpty);

            SelectSqlSection select = this.Db.Select(new CustomQueryTable(this), columns);
            return select;
        }
    }
}

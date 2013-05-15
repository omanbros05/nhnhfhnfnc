using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using System.Data;
using System.Data.Common;
using NBearLite;
using NBear.Mapping;
using Common;

namespace SOA.ORM
{
    public abstract class BaseEntity<T> : EntityInterface where T : EntityInterface, new()
    {
        private string _ExchangeGUID;
        /// <summary>
        /// GUID
        /// </summary>
        [Field("ExchangeGUID", DbType.String, false)]
        public string ExchangeGUID
        {
            get { return _ExchangeGUID; }
            set { _ExchangeGUID = value; }
        }

        private DateTime _CreateTime;
        /// <summary>
        /// 创建时间 [CreateTime]
        /// </summary>
        [Field("CreateTime", DbType.DateTime, false)]
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set { this._CreateTime = value; }
        }

        /// <summary>
        /// 反射缓存
        /// </summary>
        internal static Dictionary<string, EntityProp> Cache = new Dictionary<string, EntityProp>();
        /// <summary>
        /// 表缓存
        /// </summary>
        internal static Dictionary<string, IQueryTable> TableCache = new Dictionary<string, IQueryTable>();

        internal static T ReadRow(DataRowView row)
        {
            T t = ObjectConvertor.ToObject<T>(row);
            t.IsExists = true;
            t.IsInit = true;
            return t;
        }

        internal static T ReadRow(DataRow row)
        {
            T t = ObjectConvertor.ToObject<T>(row);
            t.IsExists = true;
            t.IsInit = true;
            return t;
        }

        internal static T ReadRow(IDataReader reader)
        {
            T t = ObjectConvertor.ToObject<T>(reader);
            t.IsExists = true;
            t.IsInit = true;
            return t;
        }



        protected BaseEntity()
        {
            InitCache();
        }

        private void InitTableCache()
        {
            if (TableCache.Count > 0)
                return;
            try
            {
                TableCache.Clear();
                Type type = typeof(DataBases);
                FieldInfo[] Fields = type.GetFields();
                foreach (FieldInfo field in Fields)
                {
                    IQueryTable queryTable = (IQueryTable)field.GetValue(null);
                    TableCache.Add(queryTable.___GetTableName(), queryTable);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<EntityInterface> GetSynchroAll()
        {
            Type type = this.GetType();
            List<EntityInterface> Entiys = new List<EntityInterface>();
            Entiys.Clear();
            TableAttribute[] TableAttributes = (TableAttribute[])type.GetCustomAttributes(typeof(TableAttribute), true);
            if (TableAttributes.Length > 0)
            {
                InitTableCache();
                string tableName = TableAttributes[0].Name;
                if (TableCache.ContainsKey(tableName))
                {
                    DataTable table = DB.Select(TableCache[tableName]).ToDataSet().Tables[0];
                    foreach (DataRow row in table.Rows)
                    {
                        T t = ReadRow(row);
                        t.Init();
                        Entiys.Add(t);
                    }
                }
            }

            return Entiys;
        }


        /// <summary>
        /// 初始化缓存
        /// </summary>
        protected void InitCache()
        {
            try
            {
                InitTableCache();

                Type type = this.GetType();

                if (Cache.ContainsKey(type.FullName))
                    return;

                EntityProp entityProp = new EntityProp();
                TableAttribute[] TableAttributes = (TableAttribute[])type.GetCustomAttributes(typeof(TableAttribute), true);

                if (TableAttributes.Length > 0)
                {
                    entityProp.Table = TableAttributes[0];
                }

                IQueryTable queryTable = TableCache[entityProp.Table.Name];

                PropertyInfo[] tablePropertyInfos = queryTable.GetType().GetProperties();
                PropertyInfo[] fields = type.GetProperties();
                //建立数据库字段和实体类字段的对应关系
                for (int i = 0; i < fields.Length; i++)
                {
                    FieldAttribute[] FieldAttributes = (FieldAttribute[])fields[i].GetCustomAttributes(typeof(FieldAttribute), true);

                    if (FieldAttributes != null && FieldAttributes.Length > 0)
                    {
                        EntityItem entityItem = null;
                        if (FieldAttributes[0].PrimaryKey)
                        {
                            entityItem = new EntityItem(fields[i].Name, FieldAttributes[0]);
                            entityProp.PrimaryKeyEntityItems.Add(entityItem);
                        }
                        else
                        {
                            entityItem = new EntityItem(fields[i].Name, FieldAttributes[0]);
                            entityProp.EntityItems.Add(entityItem);
                        }

                        if (entityItem != null)
                        {
                            foreach (PropertyInfo propertyInfo in tablePropertyInfos)
                            {
                                if (propertyInfo.Name == entityItem.Name)
                                {
                                    entityItem.Property = propertyInfo;
                                    break;
                                }
                            }
                            entityProp.Items.Add(entityItem.Field.Name, entityItem);
                        }
                    }
                }

                //加入缓存
                Cache.Add(type.FullName, entityProp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 取得指定表唯一编号
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        protected int GetTableSequence(string TableName,DbTransaction tran)
        {
            try
            {
                SelectSqlSection section = DB.Select(DataBases.TableSequence,DataBases.TableSequence.Sequence).Where(DataBases.TableSequence.TableName == TableName).SetTransaction(tran);
                int Sequence = Convert.ToInt32(section.ToScalar());
                if (Sequence == 0)
                {
                    Sequence = 1;
                    DB.Insert(DataBases.TableSequence)
                        .AddColumn(DataBases.TableSequence.TableName, TableName)
                        .AddColumn(DataBases.TableSequence.Sequence, Sequence)
                        .AddColumn(DataBases.TableSequence.ExchangeGUID, ExchangeGUID)
                        .AddColumn(DataBases.TableSequence.CreateTime, CreateTime)
                        .SetTransaction(tran).Execute();
                }
                else
                {
                    Sequence += 1;
                    DB.Update(DataBases.TableSequence).AddColumn(DataBases.TableSequence.Sequence, Sequence)
                        .AddColumn(DataBases.TableSequence.CreateTime, CreateTime)
                        .Where(DataBases.TableSequence.TableName == TableName)
                        .SetTransaction(tran).Execute();
                }
                //if (table.Rows.Count == 0)
                //{
                //    Sequence = 1;
                //    DataRow row = table.NewRow();
                //    row["TableName"] = TableName;
                //    row["Sequence"] = Sequence;
                //    table.Rows.Add(row);

                //}
                //else
                //{
                //    Sequence = Convert.ToInt32(table.Rows[0]["Sequence"]) + 1;
                //    table.Rows[0]["Sequence"] = Sequence;
                //}

                //DB.Save(section.ToDbCommand(), table);

                return Sequence;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region 初始化

        protected virtual void BeginInit()
        { }

        protected virtual void EndInit()
        { }

        protected void Init(SelectSqlSection section,IQueryTable queryTable)
        {
            try
            {
                InitCache();

                if (callBegin)
                    BeginInit();

                using (IDataReader reader = section.ToDataReader())
                {
                    Type type = this.GetType();

                    EntityProp entityProp = Cache[type.FullName];

                    if (!reader.Read())
                    {
                        string temp = "";

                        for (int i = 0; i < entityProp.PrimaryKeyEntityItems.Count; i++)
                            temp += "," + entityProp.PrimaryKeyEntityItems[i].Field.Name + " = " + type.InvokeMember(entityProp.PrimaryKeyEntityItems[i].Name, BindingFlags.GetProperty, null, this, null).ToString();

                        if (temp.Length > 0)
                            temp = temp.Substring(1);

                        throw new NoExistsException(Cache[type.FullName].Table.Name + " 未找到记录 " + temp);
                    }


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        EntityItem item = entityProp.GetEntityItem(reader.GetName(i));
                        if (item.Name != "")
                        {
                            object value = reader[i];
                            Type propertyType = type.GetProperty(item.Name).PropertyType;
                            if (propertyType.BaseType == typeof(Enum))
                                value = Enum.Parse(type.GetProperty(item.Name).PropertyType, value.ToString());
                            type.InvokeMember(item.Name, BindingFlags.SetProperty,
                                null, this, new object[] { value });
                        }
                    }
                }


                if (callEnd)
                    EndInit();
            }
            catch (NoExistsException nex)
            {
                throw nex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            IsExists = true;
            IsInit = true;
        }

        public override object GetFieldProperty(string name)
        {
            FieldAttribute attribute = new FieldAttribute("", DbType.Object, false);
            Type type = this.GetType();
            PropertyInfo[] fields = type.GetProperties();
            for (int i = 0; i < fields.Length; i++)
            {
                FieldAttribute[] FieldAttributes = (FieldAttribute[])fields[i].GetCustomAttributes(typeof(FieldAttribute), true);
                if (FieldAttributes != null && FieldAttributes.Length > 0)
                {
                    if (FieldAttributes[0].Name == name)
                    {
                        attribute = FieldAttributes[0];
                        break;
                    }
                }
            }

            return attribute;
        }

        public override void UpdateSynchro()
        {
            base.UpdateSynchro();

            Type type = this.GetType();
            TableAttribute[] TableAttributes = (TableAttribute[])type.GetCustomAttributes(typeof(TableAttribute), true);
            if (TableAttributes.Length > 0)
            {
                InitCache();
                string tableName = TableAttributes[0].Name;
                if (TableCache.ContainsKey(tableName))
                {
                    IQueryTable queryTable = TableCache[tableName];
                    object obj = null;
                    using (DataTable table = DB.CustomSql("select * from " + queryTable.___GetTableName() + " where ExchangeGUID = '" + ExchangeGUID + "'").ToDataSet().Tables[0])
                    {
                        if (table.Rows.Count > 0)
                        {
                            T t = ReadRow(table.Rows[0]);
                            Type entityType = t.GetType();
                            obj = entityType.InvokeMember("CreateTime", BindingFlags.GetProperty, null, t, null);
                            DateTime currentDatetime = Convert.ToDateTime(obj);
                            if (currentDatetime >= CreateTime)
                                return;

                            EntityProp entityProp = Cache[type.FullName];
                            for (int i = 0; i < entityProp.PrimaryKeyEntityItems.Count; i++)
                            {
                                type.InvokeMember(entityProp.PrimaryKeyEntityItems[i].Name, BindingFlags.SetProperty, null, this
                                    , new object[] { entityType.InvokeMember(entityProp.PrimaryKeyEntityItems[i].Name, BindingFlags.GetProperty, null, t, null) });
                            }
                        }
                        else
                        {
                            IsExists = false;
                            IsInit = false;
                        }
                    }
                    Update();
                }
            }
        }
        #endregion

        #region 更新或添加

        protected virtual void BeginUpdate(DbTransaction trans)
        { }
        protected virtual void EndUpdate(DbTransaction trans)
        { }

        private void SubUpdate(SelectSqlSection section,IQueryTable queryTable,DbTransaction trans)
        {
            try
            {
                InitCache();
                CreateTime = DateTime.Now;
                ExchangeGUID = CommonInvoke.NewGuid;
                Type type = this.GetType();
                EntityProp entityProp = Cache[type.FullName];
                section.SetTransaction(trans);
                int count = Convert.ToInt32(section.ToScalar());

                InsertSqlSection insert = null;
                UpdateSqlSection update = null;

                if (!IsExists)
                {
                    insert = new InsertSqlSection(DB, queryTable);
                    if (Cache[type.FullName].PrimaryKeyEntityItems.Count == 1 && Cache[type.FullName].Table.AutoID)
                    {
                        int id = GetTableSequence(Cache[type.FullName].Table.Name, trans);
                        type.InvokeMember(Cache[type.FullName].PrimaryKeyEntityItems[0].Name, BindingFlags.SetProperty, null, this, new object[] { id });
                        insert.AddColumn((QueryColumn)Cache[type.FullName].PrimaryKeyEntityItems[0].Property.GetValue(queryTable, null), id);
                    }
                    else
                    {
                        if (count != 0) throw new PrimaryKeyDuplicateException("主键重复\n" + section.ToDbCommandText());
                        for (int i = 0; i < entityProp.PrimaryKeyEntityItems.Count; i++)
                            insert.AddColumn((QueryColumn)Cache[type.FullName].PrimaryKeyEntityItems[i].Property.GetValue(queryTable, null), type.InvokeMember(entityProp.PrimaryKeyEntityItems[i].Name, BindingFlags.GetProperty, null, this, null));
                    }

                    for (int i = 0; i < entityProp.EntityItems.Count; i++)
                    {
                        insert.AddColumn((QueryColumn)Cache[type.FullName].EntityItems[i].Property.GetValue(queryTable, null), type.InvokeMember(entityProp.EntityItems[i].Name, BindingFlags.GetProperty, null, this, null));
                    }

                    insert.SetTransaction(trans);
                }
                else
                {
                    if (count == 0) throw new NoExistsException("未找到要更新的记录\n" + section.ToDbCommandText());
                    update = new UpdateSqlSection(DB, queryTable);
                    for (int i = 0; i < entityProp.EntityItems.Count; i++)
                    {
                        update.AddColumn((QueryColumn)Cache[type.FullName].EntityItems[i].Property.GetValue(queryTable, null), type.InvokeMember(entityProp.EntityItems[i].Name, BindingFlags.GetProperty, null, this, null));
                    }

                    for (int i = 0; i < entityProp.PrimaryKeyEntityItems.Count; i++)
                    {
                        QueryColumn queryColumn = (QueryColumn)Cache[type.FullName].PrimaryKeyEntityItems[i].Property.GetValue(queryTable, null);
                        update.Where(queryColumn == type.InvokeMember(entityProp.PrimaryKeyEntityItems[i].Name, BindingFlags.GetProperty, null, this, null));
                    }
                    update.SetTransaction(trans);
                }

                if (insert != null)
                {
                    if (insert.Execute() == 0)
                        throw new NoExistsException("执行错误,语句未执行.");
                }
                else if (update != null)
                {
                    if( update.Execute() == 0)
                        throw new NoExistsException("执行错误,语句未执行.");
                }
                else
                    throw new NoExistsException("执行错误,语句未执行.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Update(SelectSqlSection section,IQueryTable queryTable)
        {
            try
            {
                using (CreateTranscation())
                {
                    if (callBegin)
                        BeginUpdate(SQLtransaction.transation);

                    if (callUpdate)
                        SubUpdate(section, queryTable, SQLtransaction.transation);


                    if (callEnd)
                        EndUpdate(SQLtransaction.transation);

                    IsExists = true;
                    IsInit = true;
                    SQLtransaction.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 删除

        protected virtual void BeginRemove(DbTransaction trans)
        { }
        protected virtual void EndRemove(DbTransaction trans)
        { }

        protected void Remove(DeleteSqlSection section,IQueryTable queryTable)
        {
            try
            {
                using (CreateTranscation())
                {
                    if (callBegin)
                        BeginRemove(SQLtransaction.transation);

                    section.SetTransaction(SQLtransaction.transation).Execute();

                    if (callEnd)
                        EndRemove(SQLtransaction.transation);

                    SQLtransaction.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// 对象克隆
        /// </summary>
        /// <returns>T</returns>
        public T Clone()
        {
            return (T)MemberwiseClone();
        }
    }



    public class EntityProp
    {
        public TableAttribute Table = new TableAttribute();
        public List<EntityItem> EntityItems = new List<EntityItem>();
        public List<EntityItem> PrimaryKeyEntityItems = new List<EntityItem>();

        public Dictionary<string, EntityItem> Items = new Dictionary<string, EntityItem>();

        public EntityItem GetEntityItem(string fieldName)
        {
            EntityItem e = new EntityItem("", null);
            if (Items.ContainsKey(fieldName))
                e = Items[fieldName];

            return e;
        }
    }

    public class EntityItem
    {
        public string Name;
        public FieldAttribute Field;
        public PropertyInfo Property;
        public EntityItem(string name, FieldAttribute field)
        {
            Name = name;
            Field = field;
        }

        public EntityItem(string name, FieldAttribute field,PropertyInfo property)
            : this(name,field)
        {
            Property = property;
        }
    }

    /// <summary>
    /// 指示实体类对应的数据表
    /// </summary>
    public class TableAttribute : System.Attribute
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string Name;
        /// <summary>
        /// 表的主键是否自动编号
        /// </summary>
        public bool AutoID;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">表名</param>
        /// <param name="autoID">表的主键是否自动编号</param>
        public TableAttribute(string name, bool autoID)
        {
            Name = name;
            AutoID = autoID;
        }

        public TableAttribute()
        {
        }
    }

    /// <summary>
    /// 指示实体类的字段对应数据表的字段
    /// </summary>
    public class FieldAttribute : System.Attribute
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name;
        /// <summary>
        /// 字段数据类型
        /// </summary>
        public DbType DbType;
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool PrimaryKey;
        /// <summary>
        /// 是否进行验证
        /// </summary>
        public bool Verify;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">字段名</param>
        /// <param name="dbType">数据类型</param>
        /// <param name="primaryKey">是否主键</param>
        public FieldAttribute(string name, DbType dbType, bool primaryKey)
            : this(name, dbType, primaryKey, true)
        {

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">字段名</param>
        /// <param name="dbType">数据类型</param>
        /// <param name="primaryKey">是否主键</param>
        /// <param name="ifRead">是否只用于读取</param>
        public FieldAttribute(string name, DbType dbType, bool primaryKey, bool verify)
        {
            Name = name;
            DbType = dbType;
            PrimaryKey = primaryKey;
            Verify = verify;
        }
    }

    public class SynchroAttribute : Attribute
    {
        public SynchroAttribute() { }
    }
}

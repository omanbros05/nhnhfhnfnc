using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Reflection;
using System.Transactions;
using System.Data.Common;
using System.Xml.Linq;
using System.Xml.Serialization;
using NBearLite;

namespace SOA
{
    public enum EEnable
    {
        是,
        否,
        所有
    }

    [Serializable]
    public abstract class EntityInterface
    {
        internal SystemService SystemService;

        internal virtual void Init() { }

        internal virtual void Update() { }

        internal virtual void Remove() { }

        public virtual object GetFieldProperty(string name)
        {
            return new FieldAttributes();
        }

        public virtual void InitQueryTableCache() { }

        public virtual string SearchColumn()
        {
            return string.Empty;
        }

        public virtual List<EntityInterface> GetSynchroAll()
        {
            return null;
        }

        public virtual void UpdateSynchro()
        { 
            
        }

        public virtual EntityInterface UpdateImportDocument(string docName)
        {
            return null;
        }

        #region 数据库
        private static Database db;

        /// <summary>
        /// 数据库对象
        /// </summary>
        internal static Database DB
        {
            get
            {
                if (db == null) {
                    NBearLite.DbProviders.DbProvider provider =
                        NBearLite.DbProviders.DbProviderFactory.CreateDbProvider(
                                null,
                                "System.Data.SqlServerCe",
                                @"Data Source=enforce.sdf;
                                  Encrypt Database=True;
                                  Password=enforce_123456;
                                  File Mode=shared read;
                                  Persist Security Info=False;");
                    db = new Database(provider);
                }

                return db;
            }
        }

        #endregion

        /// <summary>
        /// 实体是否在数据库中存在
        /// </summary>
        //[DataMember]
        public bool IsExists
        {
            get;
            set;
        }

        /// <summary>
        /// 实体是否已初始化
        /// </summary>
        //[DataMember]
        public bool IsInit
        {
            get;
            set;
        }

        protected bool callBegin = true;
        /// <summary>
        /// Init/Update/Remove时是否调用Begin虚函数
        /// </summary>
        //[DataMember]
        public bool CallBegin
        {
            get
            {
                return callBegin;
            }
            set
            {
                callBegin = value;
            }
        }

        protected bool callUpdate = true;
        public bool CallUpdate
        {
            get { return callUpdate; }
            set { callUpdate = value; }
        }


        protected bool callEnd = true;
        /// <summary>
        /// Init/Update/Remove时是否调用End虚函数
        /// </summary>
        //[DataMember]
        public bool CallEnd
        {
            get
            {
                return callEnd;
            }
            set
            {
                callEnd = value;
            }
        }

        #region 事务封装
        [System.Xml.Serialization.XmlIgnore, NonSerialized]
        public SQLTranscation SQLtransaction;
        public SQLTranscation CreateTranscation()
        {
            if (SQLtransaction == null)
                SQLtransaction = new SQLTranscation(DB);
            else
                SQLtransaction.AddRef();

            return SQLtransaction;
        }

        //[System.Xml.Serialization.XmlIgnore, NonSerialized]
        //public TransScope TransScope;

        //public TransScope CreateTransScope()
        //{
        //    if (TransScope == null)
        //    {
        //        TransScope = new TransScope();
        //    }
        //    else
        //    {
        //        TransScope.AddRef();
        //    }
        //    return TransScope;
        //}

        #endregion
    }

    public class SQLTranscation : IDisposable
    {
        private int refCompleteCount = 0;
        private int refDisposeCount = 0;
        private Database db;
        public DbTransaction transation;

        public SQLTranscation(Database db)
        {
            this.transation = db.BeginTransaction();
            this.db = db;
        }

        public void Complete()
        {
            if (refCompleteCount > 0)
                refCompleteCount -= 1;
            else
            {
                transation.Commit();
                db.CloseConnection(transation);
            }
        }

        public void AddRef()
        {
            refCompleteCount += 1;
            refDisposeCount += 1;
        }

        public void Dispose()
        {
            if (refDisposeCount > 0)
                refDisposeCount -= 1;
            else
            {
                transation.Dispose();
                transation = null;
            }
        }
    }

    public class TransScope : IDisposable
    {
        private int refCompleteCount = 0;
        private int refDisposeCount = 0;
        public TransactionScope transactionScope;
        private DependentTransaction dependentTransaction;

        public TransScope()
        {
            transactionScope = new TransactionScope(TransactionScopeOption.Required);
        }

        public TransScope(DependentTransaction dt)
        {
            dependentTransaction = dt;
            transactionScope = new TransactionScope(dt);
        }

        public void Complete()
        {
            if (refCompleteCount > 0)
                refCompleteCount -= 1;
            else
            {
                transactionScope.Complete();

                if (dependentTransaction != null)
                    dependentTransaction.Complete();
            }
        }

        public void AddRef()
        {
            refCompleteCount += 1;
            refDisposeCount += 1;
        }

        public void Dispose()
        {
            if (refDisposeCount > 0)
                refDisposeCount -= 1;
            else
            {
                transactionScope.Dispose();
                transactionScope = null;

                if (dependentTransaction != null)
                {
                    dependentTransaction.Dispose();
                    dependentTransaction = null;
                }
            }
        }
    }
}

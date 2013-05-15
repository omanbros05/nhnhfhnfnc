using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 银行信息
    /// </summary>
    [Table("Bank", true)]
    public partial class Bank : BaseEntity<Bank>
    {
        private int _ID;
        /// <summary>
        /// 自增 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _BankName = String.Empty;
        /// <summary>
        /// 银行名称 [BankName]
        /// </summary>
        [Field("BankName", DbType.String, false)]
        public string BankName
        {
            get { return _BankName; }
            set { this._BankName = value; }
        }
        private string _Account = String.Empty;
        /// <summary>
        /// 银行帐号 [Account]
        /// </summary>
        [Field("Account", DbType.String, false)]
        public string Account
        {
            get { return _Account; }
            set { this._Account = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Bank()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal Bank(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.Bank).Where(DataBases.Bank.ID == ID);
            Init(section, DataBases.Bank);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.Bank, DataBases.Bank.ID.Count()).Where(DataBases.Bank.ID == ID);
            Update(section, DataBases.Bank);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.Bank).Where(DataBases.Bank.ID == ID);
            Remove(section, DataBases.Bank);
        }
    }
}

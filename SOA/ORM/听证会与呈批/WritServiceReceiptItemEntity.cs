using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 文书送达回执
    /// </summary>
    [Table("WritServiceReceiptItem", true)]
    public partial class WritServiceReceiptItem : BaseEntity<WritServiceReceiptItem>
    {
        private int _ID;
        /// <summary>
        /// 自动编号 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private int _ReceiptID;
        /// <summary>
        /// 送达回执主表编号 [ReceiptID]
        /// </summary>
        [Field("ReceiptID", DbType.Int32, false)]
        public int ReceiptID
        {
            get { return _ReceiptID; }
            set { this._ReceiptID = value; }
        }
        private string _WritName = String.Empty;
        /// <summary>
        /// 送达文书名称、文号 [WritName]
        /// </summary>
        [Field("WritName", DbType.String, false)]
        public string WritName
        {
            get { return _WritName; }
            set { this._WritName = value; }
        }
        private string _Recipient = String.Empty;
        /// <summary>
        /// 收件人签名 [Recipient]
        /// </summary>
        [Field("Recipient", DbType.String, false)]
        public string Recipient
        {
            get { return _Recipient; }
            set { this._Recipient = value; }
        }
        private DateTime _ServiceDate;
        /// <summary>
        /// 送达日期 [ServiceDate]
        /// </summary>
        [Field("ServiceDate", DbType.DateTime, false)]
        public DateTime ServiceDate
        {
            get { return _ServiceDate; }
            set { this._ServiceDate = value; }
        }
        private string _ServiceAddress = String.Empty;
        /// <summary>
        /// 送达地点 [ServiceAddress]
        /// </summary>
        [Field("ServiceAddress", DbType.String, false)]
        public string ServiceAddress
        {
            get { return _ServiceAddress; }
            set { this._ServiceAddress = value; }
        }
        private string _ServiceWay = String.Empty;
        /// <summary>
        /// 送达方式 [ServiceWay]
        /// </summary>
        [Field("ServiceWay", DbType.String, false)]
        public string ServiceWay
        {
            get { return _ServiceWay; }
            set { this._ServiceWay = value; }
        }
        private string _ServicePerson = String.Empty;
        /// <summary>
        /// 送达人 [ServicePerson]
        /// </summary>
        [Field("ServicePerson", DbType.String, false)]
        public string ServicePerson
        {
            get { return _ServicePerson; }
            set { this._ServicePerson = value; }
        }

        private byte _Status = 0;

        [Field("Status", DbType.Byte, false)]
        public byte Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _FilePath;

        [Field("FilePath", DbType.String, false)]
        public string FilePath
        {
            get { return _FilePath; }
            set { this._FilePath = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public WritServiceReceiptItem()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal WritServiceReceiptItem(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.WritServiceReceiptItem).Where(DataBases.WritServiceReceiptItem.ID == ID);
            Init(section, DataBases.WritServiceReceiptItem);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.WritServiceReceiptItem, DataBases.WritServiceReceiptItem.ID.Count()).Where(DataBases.WritServiceReceiptItem.ID == ID);
            Update(section, DataBases.WritServiceReceiptItem);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.WritServiceReceiptItem).Where(DataBases.WritServiceReceiptItem.ID == ID);
            Remove(section, DataBases.WritServiceReceiptItem);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 罚款催缴通知书
    /// </summary>
    [Table("FineCallsNotice", true)]
    public partial class FineCallsNotice : BaseEntity<FineCallsNotice>
    {
        private int _ID;
        /// <summary>
        ///  [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private int _CompanyID = -1;
        /// <summary>
        /// 公司编号 [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, false)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
        }
        private string _CompanyName = String.Empty;
        /// <summary>
        /// 公司名称 [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private DateTime _SendCallsDate;
        /// <summary>
        /// 发送日期 [SendCallsDate]
        /// </summary>
        [Field("SendCallsDate", DbType.DateTime, false)]
        public DateTime SendCallsDate
        {
            get { return _SendCallsDate; }
            set { this._SendCallsDate = value; }
        }
        private string _DecideNumber = String.Empty;
        /// <summary>
        /// 第几号行政处罚决定书 [DecideNumber]
        /// </summary>
        [Field("DecideNumber", DbType.String, false)]
        public string DecideNumber
        {
            get { return _DecideNumber; }
            set { this._DecideNumber = value; }
        }
        private DateTime _EndDate;
        /// <summary>
        /// 缴款截止日期 [EndDate]
        /// </summary>
        [Field("EndDate", DbType.DateTime, false)]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { this._EndDate = value; }
        }
        private string _Location = String.Empty;
        /// <summary>
        /// 缴款地点 [Location]
        /// </summary>
        [Field("Location", DbType.String, false)]
        public string Location
        {
            get { return _Location; }
            set { this._Location = value; }
        }
        private DateTime _FormDate;
        /// <summary>
        /// 文书发出日期 [FormDate]
        /// </summary>
        [Field("FormDate", DbType.DateTime, false)]
        public DateTime FormDate
        {
            get { return _FormDate; }
            set { this._FormDate = value; }
        }
        private string _DocTitle = String.Empty;
        /// <summary>
        ///  [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        ///  [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
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
        public FineCallsNotice()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal FineCallsNotice(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.FineCallsNotice).Where(DataBases.FineCallsNotice.ID == ID);
            Init(section, DataBases.FineCallsNotice);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.FineCallsNotice, DataBases.FineCallsNotice.ID.Count()).Where(DataBases.FineCallsNotice.ID == ID);
            Update(section, DataBases.FineCallsNotice);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.FineCallsNotice).Where(DataBases.FineCallsNotice.ID == ID);
            Remove(section, DataBases.FineCallsNotice);
        }
    }
}

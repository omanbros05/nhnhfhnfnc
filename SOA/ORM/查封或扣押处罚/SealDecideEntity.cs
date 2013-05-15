using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 查封（扣押）决定审批表
    /// </summary>
    [Table("SealDecide", true)]
    public partial class SealDecide : BaseEntity<SealDecide>
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
        private int _CompanyID =-1;
        /// <summary>
        /// 公司ID [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, false)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
        }
        private string _SealReason = String.Empty;
        /// <summary>
        /// 查封简要原因 [SealReason]
        /// </summary>
        [Field("SealReason", DbType.String, false)]
        public string SealReason
        {
            get { return _SealReason; }
            set { this._SealReason = value; }
        }
        private string _SealLaw = String.Empty;
        /// <summary>
        /// 查封的法律依据 [SealLaw]
        /// </summary>
        [Field("SealLaw", DbType.String, false)]
        public string SealLaw
        {
            get { return _SealLaw; }
            set { this._SealLaw = value; }
        }
        private string _Government = String.Empty;
        /// <summary>
        /// 人民政府 [Government]
        /// </summary>
        [Field("Government", DbType.String, false)]
        public string Government
        {
            get { return _Government; }
            set { this._Government = value; }
        }
        private string _ManageDepartment = String.Empty;
        /// <summary>
        /// 管理部门 [ManageDepartment]
        /// </summary>
        [Field("ManageDepartment", DbType.String, false)]
        public string ManageDepartment
        {
            get { return _ManageDepartment; }
            set { this._ManageDepartment = value; }
        }
        private string _Court = String.Empty;
        /// <summary>
        /// 法院 [Court]
        /// </summary>
        [Field("Court", DbType.String, false)]
        public string Court
        {
            get { return _Court; }
            set { this._Court = value; }
        }
        private string _SealLocation = String.Empty;
        /// <summary>
        /// 查封地点 [SealLocation]
        /// </summary>
        [Field("SealLocation", DbType.String, false)]
        public string SealLocation
        {
            get { return _SealLocation; }
            set { this._SealLocation = value; }
        }
        private DateTime _SealStartDate;
        /// <summary>
        /// 查封起始日期 [SealStartDate]
        /// </summary>
        [Field("SealStartDate", DbType.DateTime, false)]
        public DateTime SealStartDate
        {
            get { return _SealStartDate; }
            set { this._SealStartDate = value; }
        }
        private DateTime _SealEndDate;
        /// <summary>
        /// 查封结束日期 [SealEndDate]
        /// </summary>
        [Field("SealEndDate", DbType.DateTime, false)]
        public DateTime SealEndDate
        {
            get { return _SealEndDate; }
            set { this._SealEndDate = value; }
        }
        private string _UserName1 = String.Empty;
        /// <summary>
        /// 执法人员1 [UserName1]
        /// </summary>
        [Field("UserName1", DbType.String, false)]
        public string UserName1
        {
            get { return _UserName1; }
            set { this._UserName1 = value; }
        }
        private string _UserName2 = String.Empty;
        /// <summary>
        /// 执法人员2 [UserName2]
        /// </summary>
        [Field("UserName2", DbType.String, false)]
        public string UserName2
        {
            get { return _UserName2; }
            set { this._UserName2 = value; }
        }
        private DateTime _HandleDate;
        /// <summary>
        ///  [HandleDate]
        /// </summary>
        [Field("HandleDate", DbType.DateTime, false)]
        public DateTime HandleDate
        {
            get { return _HandleDate; }
            set { this._HandleDate = value; }
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
        public SealDecide()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SealDecide(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SealDecide).Where(DataBases.SealDecide.ID == ID);
            Init(section, DataBases.SealDecide);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SealDecide, DataBases.SealDecide.ID.Count()).Where(DataBases.SealDecide.ID == ID);
            Update(section, DataBases.SealDecide);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SealDecide).Where(DataBases.SealDecide.ID == ID);
            Remove(section, DataBases.SealDecide);
        }
    }
}

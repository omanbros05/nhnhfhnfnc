using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 听证会通知书
    /// </summary>
    [Table("HearingNotice", true)]
    public partial class HearingNotice : BaseEntity<HearingNotice>
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
        private string _DocTitle = String.Empty;
        /// <summary>
        /// 地域简称 [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
        }
        private string _Informant = String.Empty;
        /// <summary>
        /// 被通知人 [Informant]
        /// </summary>
        [Field("Informant", DbType.String, false)]
        public string Informant
        {
            get { return _Informant; }
            set { this._Informant = value; }
        }
        private string _About = String.Empty;
        /// <summary>
        /// 关于 [About]
        /// </summary>
        [Field("About", DbType.String, false)]
        public string About
        {
            get { return _About; }
            set { this._About = value; }
        }
        private DateTime _HearDate;
        /// <summary>
        /// 通知时间 [HearDate]
        /// </summary>
        [Field("HearDate", DbType.DateTime, false)]
        public DateTime HearDate
        {
            get { return _HearDate; }
            set { this._HearDate = value; }
        }
        private string _HearAddress = String.Empty;
        /// <summary>
        /// 听证会地址 [HearAddress]
        /// </summary>
        [Field("HearAddress", DbType.String, false)]
        public string HearAddress
        {
            get { return _HearAddress; }
            set { this._HearAddress = value; }
        }
        private string _CompereName = String.Empty;
        /// <summary>
        /// 听证主持人 [CompereName]
        /// </summary>
        [Field("CompereName", DbType.String, false)]
        public string CompereName
        {
            get { return _CompereName; }
            set { this._CompereName = value; }
        }
        private string _CompereJob = String.Empty;
        /// <summary>
        /// 主持人职务 [CompereJob]
        /// </summary>
        [Field("CompereJob", DbType.String, false)]
        public string CompereJob
        {
            get { return _CompereJob; }
            set { this._CompereJob = value; }
        }
        private string _SecretaryName = String.Empty;
        /// <summary>
        /// 书记 [SecretaryName]
        /// </summary>
        [Field("SecretaryName", DbType.String, false)]
        public string SecretaryName
        {
            get { return _SecretaryName; }
            set { this._SecretaryName = value; }
        }
        private string _SecretaryJob = String.Empty;
        /// <summary>
        /// 书记职务 [SecretaryJob]
        /// </summary>
        [Field("SecretaryJob", DbType.String, false)]
        public string SecretaryJob
        {
            get { return _SecretaryJob; }
            set { this._SecretaryJob = value; }
        }
        private string _HearName1 = String.Empty;
        /// <summary>
        /// 听证员1 [HearName1]
        /// </summary>
        [Field("HearName1", DbType.String, false)]
        public string HearName1
        {
            get { return _HearName1; }
            set { this._HearName1 = value; }
        }
        private string _HearJob1 = String.Empty;
        /// <summary>
        /// 听症员职务1 [HearJob1]
        /// </summary>
        [Field("HearJob1", DbType.String, false)]
        public string HearJob1
        {
            get { return _HearJob1; }
            set { this._HearJob1 = value; }
        }
        private string _HearName2 = String.Empty;
        /// <summary>
        /// 听证员2 [HearName2]
        /// </summary>
        [Field("HearName2", DbType.String, false)]
        public string HearName2
        {
            get { return _HearName2; }
            set { this._HearName2 = value; }
        }
        private string _HearJob2 = String.Empty;
        /// <summary>
        /// 听症员职务2 [HearJob2]
        /// </summary>
        [Field("HearJob2", DbType.String, false)]
        public string HearJob2
        {
            get { return _HearJob2; }
            set { this._HearJob2 = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        /// 文档管理局全称 [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
        }
        private DateTime _DocDate;
        /// <summary>
        /// 文档日期 [DocDate]
        /// </summary>
        [Field("DocDate", DbType.DateTime, false)]
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { this._DocDate = value; }
        }
        private string _DocManageAddress = String.Empty;
        /// <summary>
        /// 安监局地址 [DocManageAddress]
        /// </summary>
        [Field("DocManageAddress", DbType.String, false)]
        public string DocManageAddress
        {
            get { return _DocManageAddress; }
            set { this._DocManageAddress = value; }
        }
        private string _DocManagePost = String.Empty;
        /// <summary>
        /// 邮编 [DocManagePost]
        /// </summary>
        [Field("DocManagePost", DbType.String, false)]
        public string DocManagePost
        {
            get { return _DocManagePost; }
            set { this._DocManagePost = value; }
        }
        private string _LinkMan = String.Empty;
        /// <summary>
        /// 联系人 [LinkMan]
        /// </summary>
        [Field("LinkMan", DbType.String, false)]
        public string LinkMan
        {
            get { return _LinkMan; }
            set { this._LinkMan = value; }
        }
        private string _Phone = String.Empty;
        /// <summary>
        /// 联系电话 [Phone]
        /// </summary>
        [Field("Phone", DbType.String, false)]
        public string Phone
        {
            get { return _Phone; }
            set { this._Phone = value; }
        }
        private int _CompanyID;
        /// <summary>
        /// 企业编号 [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, false)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
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
        public HearingNotice()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal HearingNotice(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.HearingNotice).Where(DataBases.HearingNotice.ID == ID);
            Init(section, DataBases.HearingNotice);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.HearingNotice, DataBases.HearingNotice.ID.Count()).Where(DataBases.HearingNotice.ID == ID);
            Update(section, DataBases.HearingNotice);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.HearingNotice).Where(DataBases.HearingNotice.ID == ID);
            Remove(section, DataBases.HearingNotice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 行政处罚告知书
    /// </summary>
    [Table("AdminPunishNotification", true)]
    public partial class AdminPunishNotification : BaseEntity<AdminPunishNotification>
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
        ///  [CompanyID]
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
        private string _BriefCase = String.Empty;
        /// <summary>
        /// 简要情况 [BriefCase]
        /// </summary>
        [Field("BriefCase", DbType.String, false)]
        public string BriefCase
        {
            get { return _BriefCase; }
            set { this._BriefCase = value; }
        }
        private string _CompanyBehavior = String.Empty;
        /// <summary>
        /// 单位存在的行为 [CompanyBehavior]
        /// </summary>
        [Field("CompanyBehavior", DbType.String, false)]
        public string CompanyBehavior
        {
            get { return _CompanyBehavior; }
            set { this._CompanyBehavior = value; }
        }
        private string _LawProvision = String.Empty;
        /// <summary>
        /// 违反的规定 [LawProvision]
        /// </summary>
        [Field("LawProvision", DbType.String, false)]
        public string LawProvision
        {
            get { return _LawProvision; }
            set { this._LawProvision = value; }
        }
        private string _Certificate = String.Empty;
        /// <summary>
        /// 要处罚的根据 [Certificate]
        /// </summary>
        [Field("Certificate", DbType.String, false)]
        public string Certificate
        {
            get { return _Certificate; }
            set { this._Certificate = value; }
        }
        private string _AdminPunish = String.Empty;
        /// <summary>
        /// 作出的行政处罚 [AdminPunish]
        /// </summary>
        [Field("AdminPunish", DbType.String, false)]
        public string AdminPunish
        {
            get { return _AdminPunish; }
            set { this._AdminPunish = value; }
        }
        private string _Address = String.Empty;
        /// <summary>
        /// 本局地址 [Address]
        /// </summary>
        [Field("Address", DbType.String, false)]
        public string Address
        {
            get { return _Address; }
            set { this._Address = value; }
        }
        private string _Post = String.Empty;
        /// <summary>
        /// 邮政编码 [Post]
        /// </summary>
        [Field("Post", DbType.String, false)]
        public string Post
        {
            get { return _Post; }
            set { this._Post = value; }
        }
        private string _Contacter = String.Empty;
        /// <summary>
        /// 联系人 [Contacter]
        /// </summary>
        [Field("Contacter", DbType.String, false)]
        public string Contacter
        {
            get { return _Contacter; }
            set { this._Contacter = value; }
        }
        private string _Tel = String.Empty;
        /// <summary>
        /// 联系电话 [Tel]
        /// </summary>
        [Field("Tel", DbType.String, false)]
        public string Tel
        {
            get { return _Tel; }
            set { this._Tel = value; }
        }
        private DateTime _SendDate;
        /// <summary>
        /// 日期 [SendDate]
        /// </summary>
        [Field("SendDate", DbType.DateTime, false)]
        public DateTime SendDate
        {
            get { return _SendDate; }
            set { this._SendDate = value; }
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
        public AdminPunishNotification()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal AdminPunishNotification(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.AdminPunishNotification).Where(DataBases.AdminPunishNotification.ID == ID);
            Init(section, DataBases.AdminPunishNotification);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.AdminPunishNotification, DataBases.AdminPunishNotification.ID.Count()).Where(DataBases.AdminPunishNotification.ID == ID);
            Update(section, DataBases.AdminPunishNotification);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.AdminPunishNotification).Where(DataBases.AdminPunishNotification.ID == ID);
            Remove(section, DataBases.AdminPunishNotification);
        }
    }
}

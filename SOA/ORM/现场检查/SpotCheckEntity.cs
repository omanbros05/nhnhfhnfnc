using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using Common;

namespace SOA.ORM
{
    /// <summary>
    /// 现场检查记录
    /// </summary>
    [Table("SpotCheck", true)]
    public partial class SpotCheck : BaseEntity<SpotCheck>
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
        private string _CompanyName = String.Empty;
        /// <summary>
        /// 被检查单位 [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private string _CompanyAddress = String.Empty;
        /// <summary>
        /// 单位地址 [CompanyAddress]
        /// </summary>
        [Field("CompanyAddress", DbType.String, false)]
        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { this._CompanyAddress = value; }
        }
        private string _JuridicalName = String.Empty;
        /// <summary>
        /// 法人姓名 [JuridicalName]
        /// </summary>
        [Field("JuridicalName", DbType.String, false)]
        public string JuridicalName
        {
            get { return _JuridicalName; }
            set { this._JuridicalName = value; }
        }
        private string _JuridicalJob = String.Empty;
        /// <summary>
        /// 法人职务 [JuridicalJob]
        /// </summary>
        [Field("JuridicalJob", DbType.String, false)]
        public string JuridicalJob
        {
            get { return _JuridicalJob; }
            set { this._JuridicalJob = value; }
        }
        private string _JuridicalTel = String.Empty;
        /// <summary>
        /// 法人电话 [JuridicalTel]
        /// </summary>
        [Field("JuridicalTel", DbType.String, false)]
        public string JuridicalTel
        {
            get { return _JuridicalTel; }
            set { this._JuridicalTel = value; }
        }
        private string _CheckAddress = String.Empty;
        /// <summary>
        /// 检查场所 [CheckAddress]
        /// </summary>
        [Field("CheckAddress", DbType.String, false)]
        public string CheckAddress
        {
            get { return _CheckAddress; }
            set { this._CheckAddress = value; }
        }
        private DateTime _CheckStartTime;
        /// <summary>
        /// 检查起始时间 [CheckStartTime]
        /// </summary>
        [Field("CheckStartTime", DbType.DateTime, false)]
        public DateTime CheckStartTime
        {
            get { return _CheckStartTime; }
            set { this._CheckStartTime = value; }
        }
        private DateTime _CheckEndTime;
        /// <summary>
        /// 检查结束时间 [CheckEndTime]
        /// </summary>
        [Field("CheckEndTime", DbType.DateTime, false)]
        public DateTime CheckEndTime
        {
            get { return _CheckEndTime; }
            set { this._CheckEndTime = value; }
        }
        private string _Area = String.Empty;
        /// <summary>
        /// 检查单位地域 [Area]
        /// </summary>
        [Field("Area", DbType.String, false)]
        public string Area
        {
            get { return _Area; }
            set { this._Area = value; }
        }
        private string _OfficerName1 = String.Empty;
        /// <summary>
        /// 执法人员1 [OfficerName1]
        /// </summary>
        [Field("OfficerName1", DbType.String, false)]
        public string OfficerName1
        {
            get { return _OfficerName1; }
            set { this._OfficerName1 = value; }
        }
        private string _CID1 = String.Empty;
        /// <summary>
        /// 证件号1 [CID1]
        /// </summary>
        [Field("CID1", DbType.String, false)]
        public string CID1
        {
            get { return _CID1; }
            set { this._CID1 = value; }
        }
        private string _OfficerName2 = String.Empty;
        /// <summary>
        /// 检查人员2 [OfficerName2]
        /// </summary>
        [Field("OfficerName2", DbType.String, false)]
        public string OfficerName2
        {
            get { return _OfficerName2; }
            set { this._OfficerName2 = value; }
        }
        private string _CID2 = String.Empty;
        /// <summary>
        /// 证件号2 [CID2]
        /// </summary>
        [Field("CID2", DbType.String, false)]
        public string CID2
        {
            get { return _CID2; }
            set { this._CID2 = value; }
        }
        private string _CheckCondition = String.Empty;
        /// <summary>
        /// 检查情况 [CheckCondition]
        /// </summary>
        [Field("CheckCondition", DbType.String, false)]
        public string CheckCondition
        {
            get { return _CheckCondition; }
            set { this._CheckCondition = value; }
        }
        private string _SpotCondition = String.Empty;
        /// <summary>
        /// 现场处置情况 [SpotCondition]
        /// </summary>
        [Field("SpotCondition", DbType.String, false)]
        public string SpotCondition
        {
            get { return _SpotCondition; }
            set { this._SpotCondition = value; }
        }
        private string _CheckPerson1 = String.Empty;
        /// <summary>
        /// 检查人员1 [CheckPerson1]
        /// </summary>
        [Field("CheckPerson1", DbType.String, false)]
        public string CheckPerson1
        {
            get { return _CheckPerson1; }
            set { this._CheckPerson1 = value; }
        }
        private string _CheckPerson2 = String.Empty;
        /// <summary>
        /// 检查人员2 [CheckPerson2]
        /// </summary>
        [Field("CheckPerson2", DbType.String, false)]
        public string CheckPerson2
        {
            get { return _CheckPerson2; }
            set { this._CheckPerson2 = value; }
        }
        private DateTime _CheckDate;
        /// <summary>
        /// 现场检查日期 [CheckDate]
        /// </summary>
        [Field("CheckDate", DbType.DateTime, false)]
        public DateTime CheckDate
        {
            get { return _CheckDate; }
            set { this._CheckDate = value; }
        }
        private string _SiteJuridical = String.Empty;
        /// <summary>
        /// 被检查单位现场负责人 [SiteJuridical]
        /// </summary>
        [Field("SiteJuridical", DbType.String, false)]
        public string SiteJuridical
        {
            get { return _SiteJuridical; }
            set { this._SiteJuridical = value; }
        }

        private byte _Status = 0;

        [Field("Status", DbType.Byte, false)]
        public byte Status {
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
        public SpotCheck()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SpotCheck(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotCheck).Where(DataBases.SpotCheck.ID == ID);
            Init(section, DataBases.SpotCheck);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotCheck, DataBases.SpotCheck.ID.Count()).Where(DataBases.SpotCheck.ID == ID);
            Update(section, DataBases.SpotCheck);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SpotCheck).Where(DataBases.SpotCheck.ID == ID);
            Remove(section, DataBases.SpotCheck);
        }
    }
}

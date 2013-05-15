using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 企业信息
    /// </summary>
    [Table("Company", true)]
    public partial class Company : BaseEntity<Company>
    {
        private int _CompanyID;
        /// <summary>
        /// 企业自动编号 [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, true)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
        }
        private string _CompanyName = String.Empty;
        /// <summary>
        /// 企业名称 [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private string _CompanyAddress = String.Empty;
        /// <summary>
        /// 企业地址 [CompanyAddress]
        /// </summary>
        [Field("CompanyAddress", DbType.String, false)]
        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { this._CompanyAddress = value; }
        }
        private string _CompanyPost = String.Empty;
        /// <summary>
        /// 企业邮编 [CompanyPost]
        /// </summary>
        [Field("CompanyPost", DbType.String, false)]
        public string CompanyPost
        {
            get { return _CompanyPost; }
            set { this._CompanyPost = value; }
        }
        private string _JuridicalPerson = String.Empty;
        /// <summary>
        /// 法人/负责人 [JuridicalPerson]
        /// </summary>
        [Field("JuridicalPerson", DbType.String, false)]
        public string JuridicalPerson
        {
            get { return _JuridicalPerson; }
            set { this._JuridicalPerson = value; }
        }
        private string _JuridicalPersonSex = String.Empty;
        /// <summary>
        /// 法人性别 [JuridicalPersonSex]
        /// </summary>
        [Field("JuridicalPersonSex", DbType.String, false)]
        public string JuridicalPersonSex
        {
            get { return _JuridicalPersonSex; }
            set { this._JuridicalPersonSex = value; }
        }
        private string _JuridicalPersonAge = String.Empty;
        /// <summary>
        /// 法人年龄 [JuridicalPersonAge]
        /// </summary>
        [Field("JuridicalPersonAge", DbType.String, false)]
        public string JuridicalPersonAge
        {
            get { return _JuridicalPersonAge; }
            set { this._JuridicalPersonAge = value; }
        }
        private string _JuridicalPersonJob = String.Empty;
        /// <summary>
        /// 法人职务 [JuridicalPersonJob]
        /// </summary>
        [Field("JuridicalPersonJob", DbType.String, false)]
        public string JuridicalPersonJob
        {
            get { return _JuridicalPersonJob; }
            set { this._JuridicalPersonJob = value; }
        }
        private string _Mobile = String.Empty;
        /// <summary>
        /// 联系方式(手机) [Mobile]
        /// </summary>
        [Field("Mobile", DbType.String, false)]
        public string Mobile
        {
            get { return _Mobile; }
            set { this._Mobile = value; }
        }
        private string _Tel = String.Empty;
        /// <summary>
        /// 联系方式(电话) [Tel]
        /// </summary>
        [Field("Tel", DbType.String, false)]
        public string Tel
        {
            get { return _Tel; }
            set { this._Tel = value; }
        }
        private int _CompanyType = -1;
        /// <summary>
        /// 企业类型 [CompanyType]
        /// </summary>
        [Field("CompanyType", DbType.Int32, false)]
        public int CompanyType
        {
            get { return _CompanyType; }
            set { this._CompanyType = value; }
        }
        private int _IsCity = 0;
        /// <summary>
        ///  是否市区[IsCity]
        /// </summary>
        [Field("IsCity", DbType.Int32, false)]
        public int IsCity
        {
            get { return _IsCity; }
            set { this._IsCity = value; }
        }
        private int _CompanyAreaID = -1;
        /// <summary>
        ///  地区编号[CompanyAreaID]
        /// </summary>
        [Field("CompanyAreaID", DbType.Int32, false)]
        public int CompanyAreaID
        {
            get { return _CompanyAreaID; }
            set { this._CompanyAreaID = value; }
        }
        private string _WarehousAddress = String.Empty;
        /// <summary>
        /// 仓储地址 [WarehousAddress]
        /// </summary>
        [Field("WarehousAddress", DbType.String, false)]
        public string WarehousAddress
        {
            get { return _WarehousAddress; }
            set { this._WarehousAddress = value; }
        }
        private string _PermitRange = String.Empty;
        /// <summary>
        /// 许可范围 [PermitRange]
        /// </summary>
        [Field("PermitRange", DbType.String, false)]
        public string PermitRange
        {
            get { return _PermitRange; }
            set { this._PermitRange = value; }
        }
        private string _BusinessMode = String.Empty;
        /// <summary>
        /// 经营方式 [BusinessMode]
        /// </summary>
        [Field("BusinessMode", DbType.String, false)]
        public string BusinessMode
        {
            get { return _BusinessMode; }
            set { this._BusinessMode = value; }
        }
        private string _PermitValid = String.Empty;
        /// <summary>
        /// 许可有效期 [PermitValid]
        /// </summary>
        [Field("PermitValid", DbType.String, false)]
        public string PermitValid
        {
            get { return _PermitValid; }
            set { this._PermitValid = value; }
        }
        private string _IDCard = String.Empty;
        /// <summary>
        ///  身份证[IDCard]
        /// </summary>
        [Field("IDCard", DbType.String, false)]
        public string IDCard
        {
            get { return _IDCard; }
            set { this._IDCard = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Company()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal Company(int companyID)
        {
            CompanyID = companyID;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.Company).Where(DataBases.Company.CompanyID == CompanyID);
            Init(section, DataBases.Company);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.Company, DataBases.Company.CompanyID.Count()).Where(DataBases.Company.CompanyID == CompanyID);
            Update(section, DataBases.Company);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.Company).Where(DataBases.Company.CompanyID == CompanyID);
            Remove(section, DataBases.Company);
        }
    }
}

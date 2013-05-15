using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 行政处罚决定书(个人)
    /// </summary>
    [Table("AdministrativePenaltyPerson", true)]
    public partial class AdministrativePenaltyPerson : BaseEntity<AdministrativePenaltyPerson>
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
        private string _SentPeople = String.Empty;
        /// <summary>
        /// 被罚人 [SentPeople]
        /// </summary>
        [Field("SentPeople", DbType.String, false)]
        public string SentPeople
        {
            get { return _SentPeople; }
            set { this._SentPeople = value; }
        }
        private string _SentSex = String.Empty;
        /// <summary>
        /// 性别 [SentSex]
        /// </summary>
        [Field("SentSex", DbType.String, false)]
        public string SentSex
        {
            get { return _SentSex; }
            set { this._SentSex = value; }
        }
        private string _SentAge = String.Empty;
        /// <summary>
        /// 年龄 [SentAge]
        /// </summary>
        [Field("SentAge", DbType.String, false)]
        public string SentAge
        {
            get { return _SentAge; }
            set { this._SentAge = value; }
        }
        private string _SentIDCard = String.Empty;
        /// <summary>
        /// 身份证号 [SentIDCard]
        /// </summary>
        [Field("SentIDCard", DbType.String, false)]
        public string SentIDCard
        {
            get { return _SentIDCard; }
            set { this._SentIDCard = value; }
        }
        private string _SentAddress = String.Empty;
        /// <summary>
        /// 被罚人地址 [SentAddress]
        /// </summary>
        [Field("SentAddress", DbType.String, false)]
        public string SentAddress
        {
            get { return _SentAddress; }
            set { this._SentAddress = value; }
        }
        private string _SentCompany = String.Empty;
        /// <summary>
        /// 所在单位 [SentCompany]
        /// </summary>
        [Field("SentCompany", DbType.String, false)]
        public string SentCompany
        {
            get { return _SentCompany; }
            set { this._SentCompany = value; }
        }
        private string _SentJob = String.Empty;
        /// <summary>
        /// 职务 [SentJob]
        /// </summary>
        [Field("SentJob", DbType.String, false)]
        public string SentJob
        {
            get { return _SentJob; }
            set { this._SentJob = value; }
        }
        private string _SentCompanyAddress = String.Empty;
        /// <summary>
        /// 单位地址 [SentCompanyAddress]
        /// </summary>
        [Field("SentCompanyAddress", DbType.String, false)]
        public string SentCompanyAddress
        {
            get { return _SentCompanyAddress; }
            set { this._SentCompanyAddress = value; }
        }
        private string _SentTel = String.Empty;
        /// <summary>
        /// 联系电话 [SentTel]
        /// </summary>
        [Field("SentTel", DbType.String, false)]
        public string SentTel
        {
            get { return _SentTel; }
            set { this._SentTel = value; }
        }
        private string _Proof = String.Empty;
        /// <summary>
        /// 违法事实及证据 [Proof]
        /// </summary>
        [Field("Proof", DbType.String, false)]
        public string Proof
        {
            get { return _Proof; }
            set { this._Proof = value; }
        }
        private string _Deregulation = String.Empty;
        /// <summary>
        /// 违反的规定 [Deregulation]
        /// </summary>
        [Field("Deregulation", DbType.String, false)]
        public string Deregulation
        {
            get { return _Deregulation; }
            set { this._Deregulation = value; }
        }
        private string _LegalRule = String.Empty;
        /// <summary>
        /// 法律规定 [LegalRule]
        /// </summary>
        [Field("LegalRule", DbType.String, false)]
        public string LegalRule
        {
            get { return _LegalRule; }
            set { this._LegalRule = value; }
        }
        private string _AdministrativePenalty = String.Empty;
        /// <summary>
        /// 行政处罚内容 [AdministrativePenalty]
        /// </summary>
        [Field("AdministrativePenalty", DbType.String, false)]
        public string AdministrativePenalty
        {
            get { return _AdministrativePenalty; }
            set { this._AdministrativePenalty = value; }
        }
        private string _PromptCash = String.Empty;
        /// <summary>
        /// 是否当场缴纳 [PromptCash]
        /// </summary>
        [Field("PromptCash", DbType.String, false)]
        public string PromptCash
        {
            get { return _PromptCash; }
            set { this._PromptCash = value; }
        }
        private string _TimeQuantumCash = String.Empty;
        /// <summary>
        /// 是否时间段缴纳 [TimeQuantumCash]
        /// </summary>
        [Field("TimeQuantumCash", DbType.String, false)]
        public string TimeQuantumCash
        {
            get { return _TimeQuantumCash; }
            set { this._TimeQuantumCash = value; }
        }
        private string _PaymentAddress = String.Empty;
        /// <summary>
        /// 缴纳地址 [PaymentAddress]
        /// </summary>
        [Field("PaymentAddress", DbType.String, false)]
        public string PaymentAddress
        {
            get { return _PaymentAddress; }
            set { this._PaymentAddress = value; }
        }
        private string _PaymentAccount = String.Empty;
        /// <summary>
        /// 缴纳帐号 [PaymentAccount]
        /// </summary>
        [Field("PaymentAccount", DbType.String, false)]
        public string PaymentAccount
        {
            get { return _PaymentAccount; }
            set { this._PaymentAccount = value; }
        }
        private string _GovArea = String.Empty;
        /// <summary>
        /// 人民政府地域 [GovArea]
        /// </summary>
        [Field("GovArea", DbType.String, false)]
        public string GovArea
        {
            get { return _GovArea; }
            set { this._GovArea = value; }
        }
        private string _ManageArea = String.Empty;
        /// <summary>
        /// 管理局地域 [ManageArea]
        /// </summary>
        [Field("ManageArea", DbType.String, false)]
        public string ManageArea
        {
            get { return _ManageArea; }
            set { this._ManageArea = value; }
        }
        private string _CourtArea = String.Empty;
        /// <summary>
        /// 人民法院地域 [CourtArea]
        /// </summary>
        [Field("CourtArea", DbType.String, false)]
        public string CourtArea
        {
            get { return _CourtArea; }
            set { this._CourtArea = value; }
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
        /// 证号1 [CID1]
        /// </summary>
        [Field("CID1", DbType.String, false)]
        public string CID1
        {
            get { return _CID1; }
            set { this._CID1 = value; }
        }
        private string _OfficerName2 = String.Empty;
        /// <summary>
        /// 执法人员2 [OfficerName2]
        /// </summary>
        [Field("OfficerName2", DbType.String, false)]
        public string OfficerName2
        {
            get { return _OfficerName2; }
            set { this._OfficerName2 = value; }
        }
        private string _CID2 = String.Empty;
        /// <summary>
        /// 证号2 [CID2]
        /// </summary>
        [Field("CID2", DbType.String, false)]
        public string CID2
        {
            get { return _CID2; }
            set { this._CID2 = value; }
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

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public AdministrativePenaltyPerson()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal AdministrativePenaltyPerson(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.AdministrativePenaltyPerson).Where(DataBases.AdministrativePenaltyPerson.ID == ID);
            Init(section, DataBases.AdministrativePenaltyPerson);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.AdministrativePenaltyPerson, DataBases.AdministrativePenaltyPerson.ID.Count()).Where(DataBases.AdministrativePenaltyPerson.ID == ID);
            Update(section, DataBases.AdministrativePenaltyPerson);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.AdministrativePenaltyPerson).Where(DataBases.AdministrativePenaltyPerson.ID == ID);
            Remove(section, DataBases.AdministrativePenaltyPerson);
        }
    }
}

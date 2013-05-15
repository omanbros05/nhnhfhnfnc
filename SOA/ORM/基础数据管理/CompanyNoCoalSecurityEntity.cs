using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 非煤矿山安全生产许可企业详情表
    /// </summary>
    [Table("CompanyNoCoalSecurity", true)]
    public partial class CompanyNoCoalSecurity : BaseEntity<CompanyNoCoalSecurity>
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
        private int _CompanyID;
        /// <summary>
        ///  [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, false)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
        }
        private string _MiningMethods = String.Empty;
        /// <summary>
        /// 开采方式 [MiningMethods]
        /// </summary>
        [Field("MiningMethods", DbType.String, false)]
        public string MiningMethods
        {
            get { return _MiningMethods; }
            set { this._MiningMethods = value; }
        }
        private string _EconomicType = String.Empty;
        /// <summary>
        /// 经济类型 [EconomicType]
        /// </summary>
        [Field("EconomicType", DbType.String, false)]
        public string EconomicType
        {
            get { return _EconomicType; }
            set { this._EconomicType = value; }
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
        private string _CertificateNumber = String.Empty;
        /// <summary>
        /// 证书编号 [CertificateNumber]
        /// </summary>
        [Field("CertificateNumber", DbType.String, false)]
        public string CertificateNumber
        {
            get { return _CertificateNumber; }
            set { this._CertificateNumber = value; }
        }
        private bool _IsStandard;
        /// <summary>
        /// 是否标准化 [IsStandard]
        /// </summary>
        [Field("IsStandard", DbType.Boolean, false)]
        public bool IsStandard
        {
            get { return _IsStandard; }
            set { this._IsStandard = value; }
        }
        private string _StandardizationRegister = String.Empty;
        /// <summary>
        /// 标准化登记 [StandardizationRegister]
        /// </summary>
        [Field("StandardizationRegister", DbType.String, false)]
        public string StandardizationRegister
        {
            get { return _StandardizationRegister; }
            set { this._StandardizationRegister = value; }
        }
        private DateTime _ValidStartDate;
        /// <summary>
        /// 有效期 [ValidStartDate]
        /// </summary>
        [Field("ValidStartDate", DbType.DateTime, false)]
        public DateTime ValidStartDate
        {
            get { return _ValidStartDate; }
            set { this._ValidStartDate = value; }
        }
        private DateTime _ValidEndDate;
        /// <summary>
        ///  [ValidEndDate]
        /// </summary>
        [Field("ValidEndDate", DbType.DateTime, false)]
        public DateTime ValidEndDate
        {
            get { return _ValidEndDate; }
            set { this._ValidEndDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CompanyNoCoalSecurity()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyNoCoalSecurity(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyNoCoalSecurity).Where(DataBases.CompanyNoCoalSecurity.ID == ID);
            Init(section, DataBases.CompanyNoCoalSecurity);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyNoCoalSecurity, DataBases.CompanyNoCoalSecurity.ID.Count()).Where(DataBases.CompanyNoCoalSecurity.ID == ID);
            Update(section, DataBases.CompanyNoCoalSecurity);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyNoCoalSecurity).Where(DataBases.CompanyNoCoalSecurity.ID == ID);
            Remove(section, DataBases.CompanyNoCoalSecurity);
        }
    }
}

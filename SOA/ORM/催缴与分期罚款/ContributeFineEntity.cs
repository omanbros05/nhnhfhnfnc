using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 延期（分期）缴纳罚款批准书
    /// </summary>
    [Table("ContributeFine", true)]
    public partial class ContributeFine : BaseEntity<ContributeFine>
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
        private int _CompanyID =-1;
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
        ///  [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private DateTime _ContributionsDate;
        /// <summary>
        /// 缴款日期 [ContributionsDate]
        /// </summary>
        [Field("ContributionsDate", DbType.DateTime, false)]
        public DateTime ContributionsDate
        {
            get { return _ContributionsDate; }
            set { this._ContributionsDate = value; }
        }
        private string _InstrumentNo = String.Empty;
        /// <summary>
        /// 文书号 [InstrumentNo]
        /// </summary>
        [Field("InstrumentNo", DbType.String, false)]
        public string InstrumentNo
        {
            get { return _InstrumentNo; }
            set { this._InstrumentNo = value; }
        }
        private string _FineSumString = String.Empty;
        /// <summary>
        /// 罚款金额（大写） [FineSumString]
        /// </summary>
        [Field("FineSumString", DbType.String, false)]
        public string FineSumString
        {
            get { return _FineSumString; }
            set { this._FineSumString = value; }
        }
        private decimal _FineSum;
        /// <summary>
        /// 罚款金额 [FineSum]
        /// </summary>
        [Field("FineSum", DbType.Decimal, false)]
        public decimal FineSum
        {
            get { return _FineSum; }
            set { this._FineSum = value; }
        }
        private DateTime _ExtensionDate;
        /// <summary>
        /// 缴纳罚款延长结束日期 [ExtensionDate]
        /// </summary>
        [Field("ExtensionDate", DbType.DateTime, false)]
        public DateTime ExtensionDate
        {
            get { return _ExtensionDate; }
            set { this._ExtensionDate = value; }
        }
        private string _ExtensionDateString = String.Empty;
        /// <summary>
        /// 缴纳罚款延长结束日期（大写） [ExtensionDateString]
        /// </summary>
        [Field("ExtensionDateString", DbType.String, false)]
        public string ExtensionDateString
        {
            get { return _ExtensionDateString; }
            set { this._ExtensionDateString = value; }
        }
        private string _Period = String.Empty;
        /// <summary>
        /// 分期第几期开始 [Period]
        /// </summary>
        [Field("Period", DbType.String, false)]
        public string Period
        {
            get { return _Period; }
            set { this._Period = value; }
        }
        private DateTime _InstallmentsDate;
        /// <summary>
        /// 分期结束日期 [InstallmentsDate]
        /// </summary>
        [Field("InstallmentsDate", DbType.DateTime, false)]
        public DateTime InstallmentsDate
        {
            get { return _InstallmentsDate; }
            set { this._InstallmentsDate = value; }
        }
        private string _InstallmentsDateString = String.Empty;
        /// <summary>
        /// 分期结束日期（大写） [InstallmentsDateString]
        /// </summary>
        [Field("InstallmentsDateString", DbType.String, false)]
        public string InstallmentsDateString
        {
            get { return _InstallmentsDateString; }
            set { this._InstallmentsDateString = value; }
        }
        private decimal _InstallmentsSum;
        /// <summary>
        /// 分期总金额 [InstallmentsSum]
        /// </summary>
        [Field("InstallmentsSum", DbType.Decimal, false)]
        public decimal InstallmentsSum
        {
            get { return _InstallmentsSum; }
            set { this._InstallmentsSum = value; }
        }
        private string _InstallmentsSumString = String.Empty;
        /// <summary>
        /// 分期总金额（大写） [InstallmentsSumString]
        /// </summary>
        [Field("InstallmentsSumString", DbType.String, false)]
        public string InstallmentsSumString
        {
            get { return _InstallmentsSumString; }
            set { this._InstallmentsSumString = value; }
        }
        private decimal _InstallmentsBalance;
        /// <summary>
        /// 分期余额 [InstallmentsBalance]
        /// </summary>
        [Field("InstallmentsBalance", DbType.Decimal, false)]
        public decimal InstallmentsBalance
        {
            get { return _InstallmentsBalance; }
            set { this._InstallmentsBalance = value; }
        }
        private string _InstallmentsBalanceString = String.Empty;
        /// <summary>
        /// 分期余额（大写） [InstallmentsBalanceString]
        /// </summary>
        [Field("InstallmentsBalanceString", DbType.String, false)]
        public string InstallmentsBalanceString
        {
            get { return _InstallmentsBalanceString; }
            set { this._InstallmentsBalanceString = value; }
        }
        private DateTime _FormDate;
        /// <summary>
        /// 文书日期 [FormDate]
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

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ContributeFine()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ContributeFine(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ContributeFine).Where(DataBases.ContributeFine.ID == ID);
            Init(section, DataBases.ContributeFine);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ContributeFine, DataBases.ContributeFine.ID.Count()).Where(DataBases.ContributeFine.ID == ID);
            Update(section, DataBases.ContributeFine);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ContributeFine).Where(DataBases.ContributeFine.ID == ID);
            Remove(section, DataBases.ContributeFine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
	/// <summary>
	/// 实体类
	/// </summary>
	[Table("PunishmentDecisionPersonal", true)]
	public partial class PunishmentDecisionPersonal : BaseEntity<PunishmentDecisionPersonal>
	{
		private int _ID ;
		/// <summary>
		///  [ID]
		/// </summary>
		[Field("ID", DbType.Int32, true)]
		public int ID
		{
			get { return _ID; }
			set { this._ID = value; }
		}
		private string _DocTitle  = String.Empty;
		/// <summary>
		/// 名称编号 [DocTitle]
		/// </summary>
		[Field("DocTitle", DbType.String, false)]
		public string DocTitle
		{
			get { return _DocTitle; }
			set { this._DocTitle = value; }
		}
		private string _FieldEPeopleName  = String.Empty;
		/// <summary>
		/// 被处罚人 [FieldEPeopleName]
		/// </summary>
		[Field("FieldEPeopleName", DbType.String, false)]
		public string FieldEPeopleName
		{
			get { return _FieldEPeopleName; }
			set { this._FieldEPeopleName = value; }
		}
		private string _FieldEPeopleSex  = String.Empty;
		/// <summary>
		/// 性别 [FieldEPeopleSex]
		/// </summary>
		[Field("FieldEPeopleSex", DbType.String, false)]
		public string FieldEPeopleSex
		{
			get { return _FieldEPeopleSex; }
			set { this._FieldEPeopleSex = value; }
		}
		private string _FieldEPeopleAge  = String.Empty;
		/// <summary>
		/// 年龄 [FieldEPeopleAge]
		/// </summary>
		[Field("FieldEPeopleAge", DbType.String, false)]
		public string FieldEPeopleAge
		{
			get { return _FieldEPeopleAge; }
			set { this._FieldEPeopleAge = value; }
		}
		private string _FieldEPeoplePhone  = String.Empty;
		/// <summary>
		/// 联系电话 [FieldEPeoplePhone]
		/// </summary>
		[Field("FieldEPeoplePhone", DbType.String, false)]
		public string FieldEPeoplePhone
		{
			get { return _FieldEPeoplePhone; }
			set { this._FieldEPeoplePhone = value; }
		}
		private string _FieldEPeopleAddress  = String.Empty;
		/// <summary>
		/// 住址 [FieldEPeopleAddress]
		/// </summary>
		[Field("FieldEPeopleAddress", DbType.String, false)]
		public string FieldEPeopleAddress
		{
			get { return _FieldEPeopleAddress; }
			set { this._FieldEPeopleAddress = value; }
		}
		private string _FieldEPeopleCompanyName  = String.Empty;
		/// <summary>
		/// 所在单位 [FieldEPeopleCompanyName]
		/// </summary>
		[Field("FieldEPeopleCompanyName", DbType.String, false)]
		public string FieldEPeopleCompanyName
		{
			get { return _FieldEPeopleCompanyName; }
			set { this._FieldEPeopleCompanyName = value; }
		}
		private string _FieldEPeoplePosition  = String.Empty;
		/// <summary>
		/// 职务 [FieldEPeoplePosition]
		/// </summary>
		[Field("FieldEPeoplePosition", DbType.String, false)]
		public string FieldEPeoplePosition
		{
			get { return _FieldEPeoplePosition; }
			set { this._FieldEPeoplePosition = value; }
		}
		private string _FieldEPeopleCompanyAddress  = String.Empty;
		/// <summary>
		/// 单位地址 [FieldEPeopleCompanyAddress]
		/// </summary>
		[Field("FieldEPeopleCompanyAddress", DbType.String, false)]
		public string FieldEPeopleCompanyAddress
		{
			get { return _FieldEPeopleCompanyAddress; }
			set { this._FieldEPeopleCompanyAddress = value; }
		}
		private string _FieldEPeopleZip  = String.Empty;
		/// <summary>
		/// 邮编 [FieldEPeopleZip]
		/// </summary>
		[Field("FieldEPeopleZip", DbType.String, false)]
		public string FieldEPeopleZip
		{
			get { return _FieldEPeopleZip; }
			set { this._FieldEPeopleZip = value; }
		}
		private string _IllegalEvidence  = String.Empty;
		/// <summary>
		/// 违法事实及证据 [IllegalEvidence]
		/// </summary>
		[Field("IllegalEvidence", DbType.String, false)]
		public string IllegalEvidence
		{
			get { return _IllegalEvidence; }
			set { this._IllegalEvidence = value; }
        }
        private string _IllegalProvisions = String.Empty;
        /// <summary>
        ///  [IllegalProvisions]
        /// </summary>
        [Field("IllegalProvisions", DbType.String, false)]
        public string IllegalProvisions
        {
            get { return _IllegalProvisions; }
            set { this._IllegalProvisions = value; }
        }
        private string _According = String.Empty;
        /// <summary>
        ///  [According]
        /// </summary>
        [Field("According", DbType.String, false)]
        public string According
        {
            get { return _According; }
            set { this._According = value; }
        }
        private decimal _PunishmentMoney;
        /// <summary>
        /// 行政处罚金额 [PunishmentMoney]
        /// </summary>
        [Field("PunishmentMoney", DbType.Decimal, false)]
        public decimal PunishmentMoney
        {
            get { return _PunishmentMoney; }
            set { this._PunishmentMoney = value; }
        }
        private string _PunishmentAmount = String.Empty;
        /// <summary>
        ///  [PunishmentAmount]
        /// </summary>
        [Field("PunishmentAmount", DbType.String, false)]
        public string PunishmentAmount
        {
            get { return _PunishmentAmount; }
            set { this._PunishmentAmount = value; }
        }
        private string _BankName = String.Empty;
        /// <summary>
        ///  [BankName]
        /// </summary>
        [Field("BankName", DbType.String, false)]
        public string BankName
        {
            get { return _BankName; }
            set { this._BankName = value; }
        }
        private string _BankID = String.Empty;
        /// <summary>
        ///  [BankID]
        /// </summary>
        [Field("BankID", DbType.String, false)]
        public string BankID
        {
            get { return _BankID; }
            set { this._BankID = value; }
        }
        private string _ReconsiderationUnitName1 = String.Empty;
        /// <summary>
        ///  [ReconsiderationUnitName1]
        /// </summary>
        [Field("ReconsiderationUnitName1", DbType.String, false)]
        public string ReconsiderationUnitName1
        {
            get { return _ReconsiderationUnitName1; }
            set { this._ReconsiderationUnitName1 = value; }
        }
        private string _ReconsiderationUnitName2 = String.Empty;
        /// <summary>
        ///  [ReconsiderationUnitName2]
        /// </summary>
        [Field("ReconsiderationUnitName2", DbType.String, false)]
        public string ReconsiderationUnitName2
        {
            get { return _ReconsiderationUnitName2; }
            set { this._ReconsiderationUnitName2 = value; }
        }
        private string _LitigationUnitName = String.Empty;
        /// <summary>
        ///  [LitigationUnitName]
        /// </summary>
        [Field("LitigationUnitName", DbType.String, false)]
        public string LitigationUnitName
        {
            get { return _LitigationUnitName; }
            set { this._LitigationUnitName = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        /// 安检局 [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
        }
		private DateTime _FillDate ;
		/// <summary>
		///  [FillDate]
		/// </summary>
		[Field("FillDate", DbType.Date, false)]
		public DateTime FillDate
		{
			get { return _FillDate; }
			set { this._FillDate = value; }
		}
		private DateTime _CreateTime=DateTime.Now ;
		/// <summary>
		///  [CreateTime]
		/// </summary>
		[Field("CreateTime", DbType.DateTime, false)]
		public DateTime CreateTime
		{
			get { return _CreateTime; }
			set { this._CreateTime = value; }
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
		public PunishmentDecisionPersonal()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal PunishmentDecisionPersonal(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.PunishmentDecisionPersonal).Where(DataBases.PunishmentDecisionPersonal.ID == ID);
			Init(section,DataBases.PunishmentDecisionPersonal);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.PunishmentDecisionPersonal,DataBases.PunishmentDecisionPersonal.ID.Count()).Where(DataBases.PunishmentDecisionPersonal.ID == ID);
			Update(section,DataBases.PunishmentDecisionPersonal);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.PunishmentDecisionPersonal).Where(DataBases.PunishmentDecisionPersonal.ID == ID);
			Remove(section,DataBases.PunishmentDecisionPersonal);
		}
	}
}

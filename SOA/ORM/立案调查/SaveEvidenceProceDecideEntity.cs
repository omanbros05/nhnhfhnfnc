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
	[Table("SaveEvidenceProceDecide", true)]
	public partial class SaveEvidenceProceDecide : BaseEntity<SaveEvidenceProceDecide>
	{
		private int _ID ;
		/// <summary>
		/// 编号 [ID]
		/// </summary>
		[Field("ID", DbType.Int32, true)]
		public int ID
		{
			get { return _ID; }
			set { this._ID = value; }
		}
		private string _DocTitle  = String.Empty;
		/// <summary>
		///  [DocTitle]
		/// </summary>
		[Field("DocTitle", DbType.String, false)]
		public string DocTitle
		{
			get { return _DocTitle; }
			set { this._DocTitle = value; }
		}
		private string _FieldECompanyName  = String.Empty;
		/// <summary>
		/// 单位名称 [FieldECompanyName]
		/// </summary>
		[Field("FieldECompanyName", DbType.String, false)]
		public string FieldECompanyName
		{
			get { return _FieldECompanyName; }
			set { this._FieldECompanyName = value; }
		}
		private DateTime _JData ;
		/// <summary>
		/// 检查日期 [JData]
		/// </summary>
		[Field("JData", DbType.Date, false)]
		public DateTime JData
		{
			get { return _JData; }
			set { this._JData = value; }
		}
		private string _SamplingContent  = String.Empty;
		/// <summary>
		/// 抽样取证凭证 [SamplingContent]
		/// </summary>
		[Field("SamplingContent", DbType.String, false)]
		public string SamplingContent
		{
			get { return _SamplingContent; }
			set { this._SamplingContent = value; }
		}
		private string _SaveEvidenceProceAuditDocTitle  = String.Empty;
		/// <summary>
		/// 保存证据编号 [SaveEvidenceProceAuditDocTitle]
		/// </summary>
		[Field("SaveEvidenceProceAuditDocTitle", DbType.String, false)]
		public string SaveEvidenceProceAuditDocTitle
		{
			get { return _SaveEvidenceProceAuditDocTitle; }
			set { this._SaveEvidenceProceAuditDocTitle = value; }
		}
		private string _DecideContent  = String.Empty;
		/// <summary>
		/// 处理内容 [DecideContent]
		/// </summary>
		[Field("DecideContent", DbType.String, false)]
		public string DecideContent
		{
			get { return _DecideContent; }
			set { this._DecideContent = value; }
		}
		private string _LitigationUnitName1  = String.Empty;
		/// <summary>
		/// 诉讼单位1 [LitigationUnitName1]
		/// </summary>
		[Field("LitigationUnitName1", DbType.String, false)]
		public string LitigationUnitName1
		{
			get { return _LitigationUnitName1; }
			set { this._LitigationUnitName1 = value; }
		}
		private string _LitigationUnitName2  = String.Empty;
		/// <summary>
		/// 诉讼单位2 [LitigationUnitName2]
		/// </summary>
		[Field("LitigationUnitName2", DbType.String, false)]
		public string LitigationUnitName2
		{
			get { return _LitigationUnitName2; }
			set { this._LitigationUnitName2 = value; }
		}
		private string _LitigationUnitName3  = String.Empty;
		/// <summary>
		/// 诉讼单位3 [LitigationUnitName3]
		/// </summary>
		[Field("LitigationUnitName3", DbType.String, false)]
		public string LitigationUnitName3
		{
			get { return _LitigationUnitName3; }
			set { this._LitigationUnitName3 = value; }
		}
        private string _DocManageArea = String.Empty;
		/// <summary>
        /// 安检局 [DocManageArea]
		/// </summary>
        [Field("[DocManageArea]", DbType.String, false)]
        public string DocManageArea
		{
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
		}
		private DateTime _FillDate ;
		/// <summary>
		/// 生成填写日期 [FillDate]
		/// </summary>
		[Field("FillDate", DbType.Date, false)]
		public DateTime FillDate
		{
			get { return _FillDate; }
			set { this._FillDate = value; }
		}
		private DateTime _CreateTime=DateTime.Now ;
		/// <summary>
		/// 创建时间 [CreateTime]
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
		public SaveEvidenceProceDecide()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal SaveEvidenceProceDecide(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceProceDecide).Where(DataBases.SaveEvidenceProceDecide.ID == ID);
			Init(section,DataBases.SaveEvidenceProceDecide);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceProceDecide,DataBases.SaveEvidenceProceDecide.ID.Count()).Where(DataBases.SaveEvidenceProceDecide.ID == ID);
			Update(section,DataBases.SaveEvidenceProceDecide);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.SaveEvidenceProceDecide).Where(DataBases.SaveEvidenceProceDecide.ID == ID);
			Remove(section,DataBases.SaveEvidenceProceDecide);
		}
	}
}

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
	[Table("SaveEvidenceAudit", true)]
	public partial class SaveEvidenceAudit : BaseEntity<SaveEvidenceAudit>
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
		private string _PutOnRecordCaseName  = String.Empty;
		/// <summary>
		/// 案件名称 [PutOnRecordCaseName]
		/// </summary>
		[Field("PutOnRecordCaseName", DbType.String, false)]
		public string PutOnRecordCaseName
		{
			get { return _PutOnRecordCaseName; }
			set { this._PutOnRecordCaseName = value; }
		}
		private string _PutOnRecordCasePeopleInfo  = String.Empty;
		/// <summary>
		/// 当事人及情况 [PutOnRecordCasePeopleInfo]
		/// </summary>
		[Field("PutOnRecordCasePeopleInfo", DbType.String, false)]
		public string PutOnRecordCasePeopleInfo
		{
			get { return _PutOnRecordCasePeopleInfo; }
			set { this._PutOnRecordCasePeopleInfo = value; }
		}
		private string _PutOnRecordCaseContent  = String.Empty;
		/// <summary>
		/// 案件基本情况 [PutOnRecordCaseContent]
		/// </summary>
		[Field("PutOnRecordCaseContent", DbType.String, false)]
		public string PutOnRecordCaseContent
		{
			get { return _PutOnRecordCaseContent; }
			set { this._PutOnRecordCaseContent = value; }
		}
        private string _SamplingID;
		/// <summary>
		/// 抽样取证凭证表编号 [SamplingID]
		/// </summary>
        [Field("SamplingID", DbType.String, false)]
        public string SamplingID
		{
			get { return _SamplingID; }
			set { this._SamplingID = value; }
		}
		private string _ReasonBasis  = String.Empty;
		/// <summary>
		/// 提请理由及依据 [ReasonBasis]
		/// </summary>
		[Field("ReasonBasis", DbType.String, false)]
		public string ReasonBasis
		{
			get { return _ReasonBasis; }
			set { this._ReasonBasis = value; }
		}
		private string _SavaWay  = String.Empty;
		/// <summary>
		/// 保存方式 [SavaWay]
		/// </summary>
		[Field("SavaWay", DbType.String, false)]
		public string SavaWay
		{
			get { return _SavaWay; }
			set { this._SavaWay = value; }
		}
		private string _UndertakerOpinion  = String.Empty;
		/// <summary>
		/// 承办人意见 [UndertakerOpinion]
		/// </summary>
		[Field("UndertakerOpinion", DbType.String, false)]
		public string UndertakerOpinion
		{
			get { return _UndertakerOpinion; }
			set { this._UndertakerOpinion = value; }
		}
		private string _UndertakerUserName1  = String.Empty;
		/// <summary>
		/// 承办人1 [UndertakerUserName1]
		/// </summary>
		[Field("UndertakerUserName1", DbType.String, false)]
		public string UndertakerUserName1
		{
			get { return _UndertakerUserName1; }
			set { this._UndertakerUserName1 = value; }
		}
		private string _UndertakerUserName2  = String.Empty;
		/// <summary>
		/// 承办人2 [UndertakerUserName2]
		/// </summary>
		[Field("UndertakerUserName2", DbType.String, false)]
		public string UndertakerUserName2
		{
			get { return _UndertakerUserName2; }
			set { this._UndertakerUserName2 = value; }
		}
		private DateTime _UndertakerData ;
		/// <summary>
		/// 承办人承办日期 [UndertakerData]
		/// </summary>
		[Field("UndertakerData", DbType.Date, false)]
		public DateTime UndertakerData
		{
			get { return _UndertakerData; }
			set { this._UndertakerData = value; }
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
		public SaveEvidenceAudit()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal SaveEvidenceAudit(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceAudit).Where(DataBases.SaveEvidenceAudit.ID == ID);
			Init(section,DataBases.SaveEvidenceAudit);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceAudit,DataBases.SaveEvidenceAudit.ID.Count()).Where(DataBases.SaveEvidenceAudit.ID == ID);
			Update(section,DataBases.SaveEvidenceAudit);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.SaveEvidenceAudit).Where(DataBases.SaveEvidenceAudit.ID == ID);
			Remove(section,DataBases.SaveEvidenceAudit);
		}
	}
}

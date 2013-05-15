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
	[Table("CaseCancel", true)]
	public partial class CaseCancel : BaseEntity<CaseCancel>
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
		/// 名称编号 [DocTitle]
		/// </summary>
		[Field("DocTitle", DbType.String, false)]
		public string DocTitle
		{
			get { return _DocTitle; }
			set { this._DocTitle = value; }
		}
        private string _PutOnRecordCaseName;
		/// <summary>
		/// 案件名称 [PutOnRecordCaseName]
		/// </summary>
        [Field("PutOnRecordCaseName", DbType.String, false)]
        public string PutOnRecordCaseName
		{
			get { return _PutOnRecordCaseName; }
			set { this._PutOnRecordCaseName = value; }
		}
		private DateTime _PutOnRecordThisDate ;
		/// <summary>
		/// 立案日期 [PutOnRecordThisDate]
		/// </summary>
		[Field("PutOnRecordThisDate", DbType.Date, false)]
		public DateTime PutOnRecordThisDate
		{
			get { return _PutOnRecordThisDate; }
			set { this._PutOnRecordThisDate = value; }
		}
		private string _PutOnRecordDocTitle  = String.Empty;
		/// <summary>
		/// 立案名称编号 [PutOnRecordDocTitle]
		/// </summary>
		[Field("PutOnRecordDocTitle", DbType.String, false)]
		public string PutOnRecordDocTitle
		{
			get { return _PutOnRecordDocTitle; }
			set { this._PutOnRecordDocTitle = value; }
		}
		private string _PutOnRecordPeopleName  = String.Empty;
		/// <summary>
		/// 立案当事人 [PutOnRecordPeopleName]
		/// </summary>
		[Field("PutOnRecordPeopleName", DbType.String, false)]
		public string PutOnRecordPeopleName
		{
			get { return _PutOnRecordPeopleName; }
			set { this._PutOnRecordPeopleName = value; }
		}
		private string _PutOnRecordFName  = String.Empty;
		/// <summary>
		/// 立案法定代表人 [PutOnRecordFName]
		/// </summary>
		[Field("PutOnRecordFName", DbType.String, false)]
		public string PutOnRecordFName
		{
			get { return _PutOnRecordFName; }
			set { this._PutOnRecordFName = value; }
		}
		private string _PutOnRecordPeopleAddress  = String.Empty;
		/// <summary>
		/// 立案当事人地址 [PutOnRecordPeopleAddress]
		/// </summary>
		[Field("PutOnRecordPeopleAddress", DbType.String, false)]
		public string PutOnRecordPeopleAddress
		{
			get { return _PutOnRecordPeopleAddress; }
			set { this._PutOnRecordPeopleAddress = value; }
		}
		private string _PutOnRecordPeoplePhone  = String.Empty;
		/// <summary>
		/// 立案电话 [PutOnRecordPeoplePhone]
		/// </summary>
		[Field("PutOnRecordPeoplePhone", DbType.String, false)]
		public string PutOnRecordPeoplePhone
		{
			get { return _PutOnRecordPeoplePhone; }
			set { this._PutOnRecordPeoplePhone = value; }
		}
		private string _PutOnRecordSourceName  = String.Empty;
		/// <summary>
		/// 案件来源 [PutOnRecordSourceName]
		/// </summary>
		[Field("PutOnRecordSourceName", DbType.String, false)]
		public string PutOnRecordSourceName
		{
			get { return _PutOnRecordSourceName; }
			set { this._PutOnRecordSourceName = value; }
		}
		private string _PutOnRecordUserNames1  = String.Empty;
		/// <summary>
		/// 立案审批承办人1 [PutOnRecordUserNames1]
		/// </summary>
		[Field("PutOnRecordUserNames1", DbType.StringFixedLength, false)]
		public string PutOnRecordUserNames1
		{
			get { return _PutOnRecordUserNames1; }
			set { this._PutOnRecordUserNames1 = value; }
		}
		private string _PutOnRecordUserNames2  = String.Empty;
		/// <summary>
		/// 立案审批承办人2 [PutOnRecordUserNames2]
		/// </summary>
		[Field("PutOnRecordUserNames2", DbType.StringFixedLength, false)]
		public string PutOnRecordUserNames2
		{
			get { return _PutOnRecordUserNames2; }
			set { this._PutOnRecordUserNames2 = value; }
		}
		private string _ResearchDetail  = String.Empty;
		/// <summary>
		/// 案件调查情况 [ResearchDetail]
		/// </summary>
		[Field("ResearchDetail", DbType.String, false)]
		public string ResearchDetail
		{
			get { return _ResearchDetail; }
			set { this._ResearchDetail = value; }
		}
		private string _RevocationReason  = String.Empty;
		/// <summary>
		/// 撤消理由 [RevocationReason]
		/// </summary>
		[Field("RevocationReason", DbType.String, false)]
		public string RevocationReason
		{
			get { return _RevocationReason; }
			set { this._RevocationReason = value; }
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
		private string _UndertakerUserName3  = String.Empty;
		/// <summary>
		/// 承办人3 [UndertakerUserName3]
		/// </summary>
		[Field("UndertakerUserName3", DbType.String, false)]
		public string UndertakerUserName3
		{
			get { return _UndertakerUserName3; }
			set { this._UndertakerUserName3 = value; }
		}
		private DateTime _UndertakerData ;
		/// <summary>
		/// 承办人办理日期 [UndertakerData]
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
		public CaseCancel()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal CaseCancel(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.CaseCancel).Where(DataBases.CaseCancel.ID == ID);
			Init(section,DataBases.CaseCancel);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.CaseCancel,DataBases.CaseCancel.ID.Count()).Where(DataBases.CaseCancel.ID == ID);
			Update(section,DataBases.CaseCancel);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.CaseCancel).Where(DataBases.CaseCancel.ID == ID);
			Remove(section,DataBases.CaseCancel);
		}
	}
}

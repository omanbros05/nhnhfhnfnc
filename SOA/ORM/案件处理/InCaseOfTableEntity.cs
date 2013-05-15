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
	[Table("InCaseOfTable", true)]
	public partial class InCaseOfTable : BaseEntity<InCaseOfTable>
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
		private string _CaseSourceName  = String.Empty;
		/// <summary>
		/// 案件来源 [CaseSourceName]
		/// </summary>
		[Field("CaseSourceName", DbType.String, false)]
		public string CaseSourceName
		{
			get { return _CaseSourceName; }
			set { this._CaseSourceName = value; }
		}
		private string _GeneralCase  = String.Empty;
		/// <summary>
		/// 案情概况 [GeneralCase]
		/// </summary>
		[Field("GeneralCase", DbType.String, false)]
		public string GeneralCase
		{
			get { return _GeneralCase; }
			set { this._GeneralCase = value; }
		}
		private string _IllegalFact  = String.Empty;
		/// <summary>
		/// 违法事实 [IllegalFact]
		/// </summary>
		[Field("IllegalFact", DbType.String, false)]
		public string IllegalFact
		{
			get { return _IllegalFact; }
			set { this._IllegalFact = value; }
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
		public InCaseOfTable()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal InCaseOfTable(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.InCaseOfTable).Where(DataBases.InCaseOfTable.ID == ID);
			Init(section,DataBases.InCaseOfTable);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.InCaseOfTable,DataBases.InCaseOfTable.ID.Count()).Where(DataBases.InCaseOfTable.ID == ID);
			Update(section,DataBases.InCaseOfTable);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.InCaseOfTable).Where(DataBases.InCaseOfTable.ID == ID);
			Remove(section,DataBases.InCaseOfTable);
		}
	}
}

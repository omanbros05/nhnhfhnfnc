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
	[Table("PutOnRecord", true)]
	public partial class PutOnRecord : BaseEntity<PutOnRecord>
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
		private string _IllegalTypeName  = String.Empty;
		/// <summary>
		/// 案由违法行为分类 [IllegalTypeName]
		/// </summary>
		[Field("IllegalTypeName", DbType.String, false)]
		public string IllegalTypeName
		{
			get { return _IllegalTypeName; }
			set { this._IllegalTypeName = value; }
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
		private DateTime _ThisDate ;
		/// <summary>
		/// 立案日期 [ThisDate]
		/// </summary>
		[Field("ThisDate", DbType.Date, false)]
		public DateTime ThisDate
		{
			get { return _ThisDate; }
			set { this._ThisDate = value; }
		}
		private string _CaseName  = String.Empty;
		/// <summary>
		/// 案件名称 [CaseName]
		/// </summary>
		[Field("CaseName", DbType.String, false)]
		public string CaseName
		{
			get { return _CaseName; }
			set { this._CaseName = value; }
		}
		private string _CompanyName  = String.Empty;
		/// <summary>
		/// 企业名称 [CompanyName]
		/// </summary>
		[Field("CompanyName", DbType.String, false)]
		public string CompanyName
		{
			get { return _CompanyName; }
			set { this._CompanyName = value; }
		}
		private string _PeopleName  = String.Empty;
		/// <summary>
		/// 当事人 [PeopleName]
		/// </summary>
		[Field("PeopleName", DbType.String, false)]
		public string PeopleName
		{
			get { return _PeopleName; }
			set { this._PeopleName = value; }
		}
		private string _PeoplePhone  = String.Empty;
		/// <summary>
		/// 电话 [PeoplePhone]
		/// </summary>
		[Field("PeoplePhone", DbType.String, false)]
		public string PeoplePhone
		{
			get { return _PeoplePhone; }
			set { this._PeoplePhone = value; }
		}
		private string _PeopleCondition  = String.Empty;
		/// <summary>
		/// 当事人基本情况 [PeopleCondition]
		/// </summary>
		[Field("PeopleCondition", DbType.String, false)]
		public string PeopleCondition
		{
			get { return _PeopleCondition; }
			set { this._PeopleCondition = value; }
		}
		private string _PeopleAddress  = String.Empty;
		/// <summary>
		/// 当事人地址 [PeopleAddress]
		/// </summary>
		[Field("PeopleAddress", DbType.String, false)]
		public string PeopleAddress
		{
			get { return _PeopleAddress; }
			set { this._PeopleAddress = value; }
		}
		private string _PeopleZip  = String.Empty;
		/// <summary>
		/// 邮编 [PeopleZip]
		/// </summary>
		[Field("PeopleZip", DbType.String, false)]
		public string PeopleZip
		{
			get { return _PeopleZip; }
			set { this._PeopleZip = value; }
		}
		private string _CaseStatus  = String.Empty;
		/// <summary>
		/// 案件基本情况 [CaseStatus]
		/// </summary>
		[Field("CaseStatus", DbType.String, false)]
		public string CaseStatus
		{
			get { return _CaseStatus; }
			set { this._CaseStatus = value; }
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
		public PutOnRecord()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal PutOnRecord(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.PutOnRecord).Where(DataBases.PutOnRecord.ID == ID);
			Init(section,DataBases.PutOnRecord);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.PutOnRecord,DataBases.PutOnRecord.ID.Count()).Where(DataBases.PutOnRecord.ID == ID);
			Update(section,DataBases.PutOnRecord);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.PutOnRecord).Where(DataBases.PutOnRecord.ID == ID);
			Remove(section,DataBases.PutOnRecord);
		}
	}
}

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
	[Table("InterrogationRecord", true)]
	public partial class InterrogationRecord : BaseEntity<InterrogationRecord>
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
		private int _InterrogationRecordCount ;
		/// <summary>
		/// 次数 [InterrogationRecordCount]
		/// </summary>
		[Field("InterrogationRecordCount", DbType.Int32, false)]
		public int InterrogationRecordCount
		{
			get { return _InterrogationRecordCount; }
			set { this._InterrogationRecordCount = value; }
		}
		private DateTime _BeganTime ;
		/// <summary>
		/// 询问开始时间 [BeganTime]
		/// </summary>
		[Field("BeganTime", DbType.DateTime, false)]
		public DateTime BeganTime
		{
			get { return _BeganTime; }
			set { this._BeganTime = value; }
		}
		private DateTime _ToTime ;
		/// <summary>
		/// 询问结束时间 [ToTime]
		/// </summary>
		[Field("ToTime", DbType.DateTime, false)]
		public DateTime ToTime
		{
			get { return _ToTime; }
			set { this._ToTime = value; }
		}
		private string _AskAddress  = String.Empty;
		/// <summary>
		/// 询问地点 [AskAddress]
		/// </summary>
		[Field("AskAddress", DbType.String, false)]
		public string AskAddress
		{
			get { return _AskAddress; }
			set { this._AskAddress = value; }
		}
		private string _BeAskEPeopleName  = String.Empty;
		/// <summary>
		/// 被询问企业人员姓名 [BeAskEPeopleName]
		/// </summary>
		[Field("BeAskEPeopleName", DbType.String, false)]
		public string BeAskEPeopleName
		{
			get { return _BeAskEPeopleName; }
			set { this._BeAskEPeopleName = value; }
		}
		private string _BeAskEPeopleSex  = String.Empty;
		/// <summary>
		/// 被询问企业人员性别 [BeAskEPeopleSex]
		/// </summary>
		[Field("BeAskEPeopleSex", DbType.String, false)]
		public string BeAskEPeopleSex
		{
			get { return _BeAskEPeopleSex; }
			set { this._BeAskEPeopleSex = value; }
		}
		private string _BeAskEPeopleAge  = String.Empty;
		/// <summary>
		/// 被询问企业人员年龄 [BeAskEPeopleAge]
		/// </summary>
		[Field("BeAskEPeopleAge", DbType.String, false)]
		public string BeAskEPeopleAge
		{
			get { return _BeAskEPeopleAge; }
			set { this._BeAskEPeopleAge = value; }
		}
		private string _BeAskEPeopleID  = String.Empty;
		/// <summary>
		/// 被询问企业人员身份证 [BeAskEPeopleID]
		/// </summary>
		[Field("BeAskEPeopleID", DbType.String, false)]
		public string BeAskEPeopleID
		{
			get { return _BeAskEPeopleID; }
			set { this._BeAskEPeopleID = value; }
		}
		private string _BeAskEPeopleCompanyName  = String.Empty;
		/// <summary>
		/// 被询问企业名称 [BeAskEPeopleCompanyName]
		/// </summary>
		[Field("BeAskEPeopleCompanyName", DbType.String, false)]
		public string BeAskEPeopleCompanyName
		{
			get { return _BeAskEPeopleCompanyName; }
			set { this._BeAskEPeopleCompanyName = value; }
		}
		private string _BeAskEPeoplePosition  = String.Empty;
		/// <summary>
		/// 被询问企业人员职务 [BeAskEPeoplePosition]
		/// </summary>
		[Field("BeAskEPeoplePosition", DbType.String, false)]
		public string BeAskEPeoplePosition
		{
			get { return _BeAskEPeoplePosition; }
			set { this._BeAskEPeoplePosition = value; }
		}
		private string _BeAskEPeopleAddress  = String.Empty;
		/// <summary>
		/// 被询问企业人员住址 [BeAskEPeopleAddress]
		/// </summary>
		[Field("BeAskEPeopleAddress", DbType.String, false)]
		public string BeAskEPeopleAddress
		{
			get { return _BeAskEPeopleAddress; }
			set { this._BeAskEPeopleAddress = value; }
		}
		private string _BeAskEPeoplePhone  = String.Empty;
		/// <summary>
		/// 被询问企业人员电话 [BeAskEPeoplePhone]
		/// </summary>
		[Field("BeAskEPeoplePhone", DbType.String, false)]
		public string BeAskEPeoplePhone
		{
			get { return _BeAskEPeoplePhone; }
			set { this._BeAskEPeoplePhone = value; }
		}
		private string _AskUserName  = String.Empty;
		/// <summary>
		/// 询问人 [AskUserName]
		/// </summary>
		[Field("AskUserName", DbType.String, false)]
		public string AskUserName
		{
			get { return _AskUserName; }
			set { this._AskUserName = value; }
		}
		private string _AskUserCompanyName  = String.Empty;
		/// <summary>
		/// 询问人单位 [AskUserCompanyName]
		/// </summary>
		[Field("AskUserCompanyName", DbType.String, false)]
		public string AskUserCompanyName
		{
			get { return _AskUserCompanyName; }
			set { this._AskUserCompanyName = value; }
		}
		private string _RecordUserName  = String.Empty;
		/// <summary>
		/// 记录人 [RecordUserName]
		/// </summary>
		[Field("RecordUserName", DbType.String, false)]
		public string RecordUserName
		{
			get { return _RecordUserName; }
			set { this._RecordUserName = value; }
		}
		private string _RecordCompanyName  = String.Empty;
		/// <summary>
		/// 单位及职务 [RecordCompanyName]
		/// </summary>
		[Field("RecordCompanyName", DbType.String, false)]
		public string RecordCompanyName
		{
			get { return _RecordCompanyName; }
			set { this._RecordCompanyName = value; }
		}
		private string _PresentEPeopleName  = String.Empty;
		/// <summary>
		/// 在场人 [PresentEPeopleName]
		/// </summary>
		[Field("PresentEPeopleName", DbType.String, false)]
		public string PresentEPeopleName
		{
			get { return _PresentEPeopleName; }
			set { this._PresentEPeopleName = value; }
		}
		private string _QFirstPerson1  = String.Empty;
		/// <summary>
		/// 问题1安监局单位 [QFirstPerson1]
		/// </summary>
		[Field("QFirstPerson1", DbType.String, false)]
		public string QFirstPerson1
		{
			get { return _QFirstPerson1; }
			set { this._QFirstPerson1 = value; }
		}
		private string _QFirstPersonName1  = String.Empty;
		/// <summary>
		/// 问题1人员1 [QFirstPersonName1]
		/// </summary>
		[Field("QFirstPersonName1", DbType.String, false)]
		public string QFirstPersonName1
		{
			get { return _QFirstPersonName1; }
			set { this._QFirstPersonName1 = value; }
		}
		private string _QFirstPersonIDC1  = String.Empty;
		/// <summary>
		/// 问题1人员1证件号 [QFirstPersonIDC1]
		/// </summary>
		[Field("QFirstPersonIDC1", DbType.String, false)]
		public string QFirstPersonIDC1
		{
			get { return _QFirstPersonIDC1; }
			set { this._QFirstPersonIDC1 = value; }
		}
		private string _QFirstPerson2  = String.Empty;
		/// <summary>
		/// 问题1人员2 [QFirstPerson2]
		/// </summary>
		[Field("QFirstPerson2", DbType.String, false)]
		public string QFirstPerson2
		{
			get { return _QFirstPerson2; }
			set { this._QFirstPerson2 = value; }
		}
		private string _QFirstPerson2IDC2  = String.Empty;
		/// <summary>
		/// 问题1人员2证件号 [QFirstPerson2IDC2]
		/// </summary>
		[Field("QFirstPerson2IDC2", DbType.String, false)]
		public string QFirstPerson2IDC2
		{
			get { return _QFirstPerson2IDC2; }
			set { this._QFirstPerson2IDC2 = value; }
		}
		private string _QFirstAnswer  = String.Empty;
		/// <summary>
		/// 问题1回答 [QFirstAnswer]
		/// </summary>
		[Field("QFirstAnswer", DbType.String, false)]
		public string QFirstAnswer
		{
			get { return _QFirstAnswer; }
			set { this._QFirstAnswer = value; }
		}
		private string _QuestionSecond  = String.Empty;
		/// <summary>
		/// 问题2 [QuestionSecond]
		/// </summary>
		[Field("QuestionSecond", DbType.String, false)]
		public string QuestionSecond
		{
			get { return _QuestionSecond; }
			set { this._QuestionSecond = value; }
		}
		private string _QuestionSecondAnswer  = String.Empty;
		/// <summary>
		/// 问题2回答 [QuestionSecondAnswer]
		/// </summary>
		[Field("QuestionSecondAnswer", DbType.String, false)]
		public string QuestionSecondAnswer
		{
			get { return _QuestionSecondAnswer; }
			set { this._QuestionSecondAnswer = value; }
		}
		private string _QuestionThirdAnswer  = String.Empty;
		/// <summary>
		/// 问题3回答 [QuestionThirdAnswer]
		/// </summary>
		[Field("QuestionThirdAnswer", DbType.String, false)]
		public string QuestionThirdAnswer
		{
			get { return _QuestionThirdAnswer; }
			set { this._QuestionThirdAnswer = value; }
		}
		private string _Questions  = String.Empty;
		/// <summary>
		/// 问答内容 [Questions]
		/// </summary>
		[Field("Questions", DbType.String, false)]
		public string Questions
		{
			get { return _Questions; }
			set { this._Questions = value; }
		}
		private DateTime _RecordDate ;
		/// <summary>
		/// 记录日期 [RecordDate]
		/// </summary>
		[Field("RecordDate", DbType.Date, false)]
		public DateTime RecordDate
		{
			get { return _RecordDate; }
			set { this._RecordDate = value; }
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
		public InterrogationRecord()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal InterrogationRecord(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.InterrogationRecord).Where(DataBases.InterrogationRecord.ID == ID);
			Init(section,DataBases.InterrogationRecord);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.InterrogationRecord,DataBases.InterrogationRecord.ID.Count()).Where(DataBases.InterrogationRecord.ID == ID);
			Update(section,DataBases.InterrogationRecord);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.InterrogationRecord).Where(DataBases.InterrogationRecord.ID == ID);
			Remove(section,DataBases.InterrogationRecord);
		}
	}
}

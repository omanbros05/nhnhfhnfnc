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
	[Table("ExplorationRecord", true)]
	public partial class ExplorationRecord : BaseEntity<ExplorationRecord>
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
		private DateTime _BeganTime ;
		/// <summary>
		/// 勘查开始时间 [BeganTime]
		/// </summary>
		[Field("BeganTime", DbType.DateTime, false)]
		public DateTime BeganTime
		{
			get { return _BeganTime; }
			set { this._BeganTime = value; }
		}
		private DateTime _ToTime ;
		/// <summary>
		/// 勘查结束时间 [ToTime]
		/// </summary>
		[Field("ToTime", DbType.DateTime, false)]
		public DateTime ToTime
		{
			get { return _ToTime; }
			set { this._ToTime = value; }
        }
		private string _Address  = String.Empty;
		/// <summary>
		/// 勘查地点 [Address]
		/// </summary>
		[Field("Address", DbType.String, false)]
		public string Address
		{
			get { return _Address; }
			set { this._Address = value; }
		}
		private string _Weather  = String.Empty;
		/// <summary>
		/// 天气情况 [Weather]
		/// </summary>
		[Field("Weather", DbType.String, false)]
		public string Weather
		{
			get { return _Weather; }
			set { this._Weather = value; }
		}
		private string _EUserName1  = String.Empty;
		/// <summary>
		/// 勘查人1 [EUserName1]
		/// </summary>
		[Field("EUserName1", DbType.String, false)]
		public string EUserName1
		{
			get { return _EUserName1; }
			set { this._EUserName1 = value; }
		}
		private string _ECompanyName1  = String.Empty;
		/// <summary>
		/// 勘查人单位职务 [ECompanyName1]
		/// </summary>
		[Field("ECompanyName1", DbType.String, false)]
		public string ECompanyName1
		{
			get { return _ECompanyName1; }
			set { this._ECompanyName1 = value; }
		}
		private string _EUserName2  = String.Empty;
		/// <summary>
		/// 勘查人2 [EUserName2]
		/// </summary>
		[Field("EUserName2", DbType.String, false)]
		public string EUserName2
		{
			get { return _EUserName2; }
			set { this._EUserName2 = value; }
		}
		private string _ECompanyName2  = String.Empty;
		/// <summary>
		/// 勘查人单位职务 [ECompanyName2]
		/// </summary>
		[Field("ECompanyName2", DbType.String, false)]
		public string ECompanyName2
		{
			get { return _ECompanyName2; }
			set { this._ECompanyName2 = value; }
		}
		private string _TheEPeopleName1  = String.Empty;
		/// <summary>
		/// 当事人员1 [TheEPeopleName1]
		/// </summary>
		[Field("TheEPeopleName1", DbType.String, false)]
		public string TheEPeopleName1
		{
			get { return _TheEPeopleName1; }
			set { this._TheEPeopleName1 = value; }
		}
		private string _TheECompanyName1  = String.Empty;
		/// <summary>
		/// 当事人单位职务 [TheECompanyName1]
		/// </summary>
		[Field("TheECompanyName1", DbType.String, false)]
		public string TheECompanyName1
		{
			get { return _TheECompanyName1; }
			set { this._TheECompanyName1 = value; }
		}
		private string _TheEPeopleName2  = String.Empty;
		/// <summary>
		/// 当事人员2 [TheEPeopleName2]
		/// </summary>
		[Field("TheEPeopleName2", DbType.String, false)]
		public string TheEPeopleName2
		{
			get { return _TheEPeopleName2; }
			set { this._TheEPeopleName2 = value; }
		}
		private string _TheECompanyName2  = String.Empty;
		/// <summary>
		/// 当事人单位职务2 [TheECompanyName2]
		/// </summary>
		[Field("TheECompanyName2", DbType.String, false)]
		public string TheECompanyName2
		{
			get { return _TheECompanyName2; }
			set { this._TheECompanyName2 = value; }
		}
		private string _InvitedEPeopleName  = String.Empty;
		/// <summary>
		/// 被邀请人员编号 [InvitedEPeopleName]
		/// </summary>
		[Field("InvitedEPeopleName", DbType.String, false)]
		public string InvitedEPeopleName
		{
			get { return _InvitedEPeopleName; }
			set { this._InvitedEPeopleName = value; }
		}
		private string _InvitedECompanyName  = String.Empty;
		/// <summary>
		/// 被邀请人单位职务 [InvitedECompanyName]
		/// </summary>
		[Field("InvitedECompanyName", DbType.String, false)]
		public string InvitedECompanyName
		{
			get { return _InvitedECompanyName; }
			set { this._InvitedECompanyName = value; }
		}
		private string _RecordUserName  = String.Empty;
		/// <summary>
		/// 记录人 ID [RecordUserName]
		/// </summary>
		[Field("RecordUserName", DbType.String, false)]
		public string RecordUserName
		{
			get { return _RecordUserName; }
			set { this._RecordUserName = value; }
		}
		private string _RecordCompanyName  = String.Empty;
		/// <summary>
		/// 记录人单位职务 [RecordCompanyName]
		/// </summary>
		[Field("RecordCompanyName", DbType.String, false)]
		public string RecordCompanyName
		{
			get { return _RecordCompanyName; }
			set { this._RecordCompanyName = value; }
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
		private string _QFirstPersonUser1  = String.Empty;
		/// <summary>
		/// 问题1人员1 [QFirstPersonUser1]
		/// </summary>
		[Field("QFirstPersonUser1", DbType.String, false)]
		public string QFirstPersonUser1
		{
			get { return _QFirstPersonUser1; }
			set { this._QFirstPersonUser1 = value; }
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
		///  [QFirstPerson2IDC2]
		/// </summary>
		[Field("QFirstPerson2IDC2", DbType.String, false)]
		public string QFirstPerson2IDC2
		{
			get { return _QFirstPerson2IDC2; }
			set { this._QFirstPerson2IDC2 = value; }
		}
		private string _ESituation  = String.Empty;
		/// <summary>
		/// 勘验情况 [ESituation]
		/// </summary>
		[Field("ESituation", DbType.String, false)]
		public string ESituation
		{
			get { return _ESituation; }
			set { this._ESituation = value; }
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
		public ExplorationRecord()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal ExplorationRecord(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.ExplorationRecord).Where(DataBases.ExplorationRecord.ID == ID);
			Init(section,DataBases.ExplorationRecord);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.ExplorationRecord,DataBases.ExplorationRecord.ID.Count()).Where(DataBases.ExplorationRecord.ID == ID);
			Update(section,DataBases.ExplorationRecord);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.ExplorationRecord).Where(DataBases.ExplorationRecord.ID == ID);
			Remove(section,DataBases.ExplorationRecord);
		}
	}
}

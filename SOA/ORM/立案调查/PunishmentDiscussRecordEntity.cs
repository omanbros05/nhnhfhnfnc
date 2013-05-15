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
	[Table("PunishmentDiscussRecord", true)]
	public partial class PunishmentDiscussRecord : BaseEntity<PunishmentDiscussRecord>
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
		private DateTime _DiscussDate ;
		/// <summary>
		/// 讨论时间 [DiscussDate]
		/// </summary>
		[Field("DiscussDate", DbType.Date, false)]
		public DateTime DiscussDate
		{
			get { return _DiscussDate; }
			set { this._DiscussDate = value; }
		}
		private string _DiscussAddress  = String.Empty;
		/// <summary>
		/// 讨论地点 [DiscussAddress]
		/// </summary>
		[Field("DiscussAddress", DbType.String, false)]
		public string DiscussAddress
		{
			get { return _DiscussAddress; }
			set { this._DiscussAddress = value; }
		}
		private string _HostName  = String.Empty;
		/// <summary>
		/// 主持人 [HostName]
		/// </summary>
		[Field("HostName", DbType.String, false)]
		public string HostName
		{
			get { return _HostName; }
			set { this._HostName = value; }
		}
		private string _ReportName  = String.Empty;
		/// <summary>
		/// 汇报人 [ReportName]
		/// </summary>
		[Field("ReportName", DbType.String, false)]
		public string ReportName
		{
			get { return _ReportName; }
			set { this._ReportName = value; }
		}
		private string _RecordUserName  = String.Empty;
		/// <summary>
		/// 记录人  [RecordUserName]
		/// </summary>
		[Field("RecordUserName", DbType.String, false)]
		public string RecordUserName
		{
			get { return _RecordUserName; }
			set { this._RecordUserName = value; }
		}
		private string _PDRPeople1  = String.Empty;
		/// <summary>
		/// 出席人员姓名及职务 [PDRPeople1]
		/// </summary>
		[Field("PDRPeople1", DbType.String, false)]
		public string PDRPeople1
		{
			get { return _PDRPeople1; }
			set { this._PDRPeople1 = value; }
		}
		private string _PDRPeople2  = String.Empty;
		/// <summary>
		/// 列席人员 [PDRPeople2]
		/// </summary>
		[Field("PDRPeople2", DbType.String, false)]
		public string PDRPeople2
		{
			get { return _PDRPeople2; }
			set { this._PDRPeople2 = value; }
		}
		private string _DiscussContent  = String.Empty;
		/// <summary>
		/// 讨论内容 [DiscussContent]
		/// </summary>
		[Field("DiscussContent", DbType.String, false)]
		public string DiscussContent
		{
			get { return _DiscussContent; }
			set { this._DiscussContent = value; }
		}
		private string _RecordContent  = String.Empty;
		/// <summary>
		/// 讨论记录 [RecordContent]
		/// </summary>
		[Field("RecordContent", DbType.String, false)]
		public string RecordContent
		{
			get { return _RecordContent; }
			set { this._RecordContent = value; }
		}
		private string _Conclusion  = String.Empty;
		/// <summary>
		/// 结论性意见 [Conclusion]
		/// </summary>
		[Field("Conclusion", DbType.String, false)]
		public string Conclusion
		{
			get { return _Conclusion; }
			set { this._Conclusion = value; }
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
		public PunishmentDiscussRecord()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal PunishmentDiscussRecord(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.PunishmentDiscussRecord).Where(DataBases.PunishmentDiscussRecord.ID == ID);
			Init(section,DataBases.PunishmentDiscussRecord);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.PunishmentDiscussRecord,DataBases.PunishmentDiscussRecord.ID.Count()).Where(DataBases.PunishmentDiscussRecord.ID == ID);
			Update(section,DataBases.PunishmentDiscussRecord);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.PunishmentDiscussRecord).Where(DataBases.PunishmentDiscussRecord.ID == ID);
			Remove(section,DataBases.PunishmentDiscussRecord);
		}
	}
}

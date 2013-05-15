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
	[Table("Sampling", true)]
	public partial class Sampling : BaseEntity<Sampling>
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
		private string _FieldEPeopleName  = String.Empty;
		/// <summary>
		/// 现场负责人 [FieldEPeopleName]
		/// </summary>
		[Field("FieldEPeopleName", DbType.String, false)]
		public string FieldEPeopleName
		{
			get { return _FieldEPeopleName; }
			set { this._FieldEPeopleName = value; }
		}
		private string _FieldEAddress  = String.Empty;
		/// <summary>
		/// 单位地址 [FieldEAddress]
		/// </summary>
		[Field("FieldEAddress", DbType.String, false)]
		public string FieldEAddress
		{
			get { return _FieldEAddress; }
			set { this._FieldEAddress = value; }
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
		private string _FieldEPeopleZio  = String.Empty;
		/// <summary>
		/// 邮编 [FieldEPeopleZio]
		/// </summary>
		[Field("FieldEPeopleZio", DbType.String, false)]
		public string FieldEPeopleZio
		{
			get { return _FieldEPeopleZio; }
			set { this._FieldEPeopleZio = value; }
		}
		private DateTime _BeganTime ;
		/// <summary>
		/// 抽样取证开始时间 [BeganTime]
		/// </summary>
		[Field("BeganTime", DbType.DateTime, false)]
		public DateTime BeganTime
		{
			get { return _BeganTime; }
			set { this._BeganTime = value; }
		}
		private DateTime _ToTime ;
		/// <summary>
		/// 抽样取证结束时间 [ToTime]
		/// </summary>
		[Field("ToTime", DbType.DateTime, false)]
		public DateTime ToTime
		{
			get { return _ToTime; }
			set { this._ToTime = value; }
		}
		private string _SamplingAddress  = String.Empty;
		/// <summary>
		/// 抽样地点 [SamplingAddress]
		/// </summary>
		[Field("SamplingAddress", DbType.String, false)]
		public string SamplingAddress
		{
			get { return _SamplingAddress; }
			set { this._SamplingAddress = value; }
		}
		private string _FieldEPeopleName1  = String.Empty;
		/// <summary>
		/// 现场负责人1 [FieldEPeopleName1]
		/// </summary>
		[Field("FieldEPeopleName1", DbType.String, false)]
		public string FieldEPeopleName1
		{
			get { return _FieldEPeopleName1; }
			set { this._FieldEPeopleName1 = value; }
		}
		private string _ExecUserName1  = String.Empty;
		/// <summary>
		/// 执法人员1 [ExecUserName1]
		/// </summary>
		[Field("ExecUserName1", DbType.String, false)]
		public string ExecUserName1
		{
			get { return _ExecUserName1; }
			set { this._ExecUserName1 = value; }
		}
		private string _ExecUserNumber1  = String.Empty;
		/// <summary>
		/// 执法人员证号1 [ExecUserNumber1]
		/// </summary>
		[Field("ExecUserNumber1", DbType.String, false)]
		public string ExecUserNumber1
		{
			get { return _ExecUserNumber1; }
			set { this._ExecUserNumber1 = value; }
		}
		private string _ExecUserName2  = String.Empty;
		/// <summary>
		/// 执法人员2 [ExecUserName2]
		/// </summary>
		[Field("ExecUserName2", DbType.String, false)]
		public string ExecUserName2
		{
			get { return _ExecUserName2; }
			set { this._ExecUserName2 = value; }
		}
		private string _ExecUserNumber2  = String.Empty;
		/// <summary>
		/// 执法人员证号2 [ExecUserNumber2]
		/// </summary>
		[Field("ExecUserNumber2", DbType.String, false)]
		public string ExecUserNumber2
		{
			get { return _ExecUserNumber2; }
			set { this._ExecUserNumber2 = value; }
		}
		private string _WitnesEPeopleName1  = String.Empty;
		/// <summary>
		/// 见证人1 [WitnesEPeopleName1]
		/// </summary>
		[Field("WitnesEPeopleName1", DbType.String, false)]
		public string WitnesEPeopleName1
		{
			get { return _WitnesEPeopleName1; }
			set { this._WitnesEPeopleName1 = value; }
		}
		private string _WitnesEPeopleName2  = String.Empty;
		/// <summary>
		/// 见证人2 [WitnesEPeopleName2]
		/// </summary>
		[Field("WitnesEPeopleName2", DbType.String, false)]
		public string WitnesEPeopleName2
		{
			get { return _WitnesEPeopleName2; }
			set { this._WitnesEPeopleName2 = value; }
		}
		private string _DocManageArea  = String.Empty;
		/// <summary>
		/// 文档章 [DocManageArea]
		/// </summary>
		[Field("DocManageArea", DbType.String, false)]
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
		public Sampling()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal Sampling(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.Sampling).Where(DataBases.Sampling.ID == ID);
			Init(section,DataBases.Sampling);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.Sampling,DataBases.Sampling.ID.Count()).Where(DataBases.Sampling.ID == ID);
			Update(section,DataBases.Sampling);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.Sampling).Where(DataBases.Sampling.ID == ID);
			Remove(section,DataBases.Sampling);
		}
	}
}

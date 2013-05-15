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
	[Table("NoticeOfEnquiry", true)]
	public partial class NoticeOfEnquiry : BaseEntity<NoticeOfEnquiry>
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
		private DateTime _ToDateTime ;
		/// <summary>
		/// 到达时间 [ToDateTime]
		/// </summary>
		[Field("ToDateTime", DbType.DateTime, false)]
		public DateTime ToDateTime
		{
			get { return _ToDateTime; }
			set { this._ToDateTime = value; }
		}
		private string _ToAddress  = String.Empty;
		/// <summary>
		/// 到达地址 [ToAddress]
		/// </summary>
		[Field("ToAddress", DbType.String, false)]
		public string ToAddress
		{
			get { return _ToAddress; }
			set { this._ToAddress = value; }
		}
		private bool _IfID ;
		/// <summary>
		/// 身份证 [IfID]
		/// </summary>
		[Field("IfID", DbType.Boolean, false)]
		public bool IfID
		{
			get { return _IfID; }
			set { this._IfID = value; }
		}
		private bool _IfBusinessLicense ;
		/// <summary>
		/// 营业执照 [IfBusinessLicense]
		/// </summary>
		[Field("IfBusinessLicense", DbType.Boolean, false)]
		public bool IfBusinessLicense
		{
			get { return _IfBusinessLicense; }
			set { this._IfBusinessLicense = value; }
		}
		private bool _IfLawID ;
		/// <summary>
		/// 法人身份证 [IfLawID]
		/// </summary>
		[Field("IfLawID", DbType.Boolean, false)]
		public bool IfLawID
		{
			get { return _IfLawID; }
			set { this._IfLawID = value; }
		}
		private bool _IfOther ;
		/// <summary>
		/// 是否其它证件 [IfOther]
		/// </summary>
		[Field("IfOther", DbType.Boolean, false)]
		public bool IfOther
		{
			get { return _IfOther; }
			set { this._IfOther = value; }
		}
		private string _OtherDocument  = String.Empty;
		/// <summary>
		/// 其它证件 [OtherDocument]
		/// </summary>
		[Field("OtherDocument", DbType.String, false)]
		public string OtherDocument
		{
			get { return _OtherDocument; }
			set { this._OtherDocument = value; }
		}
		private string _DetpAddress  = String.Empty;
		/// <summary>
		/// 管理部门地址 [DetpAddress]
		/// </summary>
		[Field("DetpAddress", DbType.String, false)]
		public string DetpAddress
		{
			get { return _DetpAddress; }
			set { this._DetpAddress = value; }
		}
		private string _DetpName  = String.Empty;
		/// <summary>
		/// 联系人 [DetpName]
		/// </summary>
		[Field("DetpName", DbType.String, false)]
		public string DetpName
		{
			get { return _DetpName; }
			set { this._DetpName = value; }
		}
		private string _DetpPhone  = String.Empty;
		/// <summary>
		/// 联系电话 [DetpPhone]
		/// </summary>
		[Field("DetpPhone", DbType.String, false)]
		public string DetpPhone
		{
			get { return _DetpPhone; }
			set { this._DetpPhone = value; }
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
		[Field("FillDate", DbType.DateTime, false)]
		public DateTime FillDate
		{
			get { return _FillDate; }
			set { this._FillDate = value; }
		}
		private DateTime _CreateTime =DateTime.Now;
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
		public NoticeOfEnquiry()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal NoticeOfEnquiry(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.NoticeOfEnquiry).Where(DataBases.NoticeOfEnquiry.ID == ID);
			Init(section,DataBases.NoticeOfEnquiry);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.NoticeOfEnquiry,DataBases.NoticeOfEnquiry.ID.Count()).Where(DataBases.NoticeOfEnquiry.ID == ID);
			Update(section,DataBases.NoticeOfEnquiry);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.NoticeOfEnquiry).Where(DataBases.NoticeOfEnquiry.ID == ID);
			Remove(section,DataBases.NoticeOfEnquiry);
		}
	}
}

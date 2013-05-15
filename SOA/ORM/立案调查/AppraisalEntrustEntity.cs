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
	[Table("AppraisalEntrust", true)]
	public partial class AppraisalEntrust : BaseEntity<AppraisalEntrust>
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
		private int _SamplingID ;
		/// <summary>
		/// 抽样取证凭证表编号 [SamplingID]
		/// </summary>
		[Field("SamplingID", DbType.Int32, false)]
		public int SamplingID
		{
			get { return _SamplingID; }
			set { this._SamplingID = value; }
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
		private string _AppraisalUnit  = String.Empty;
		/// <summary>
		/// 鉴定机构 [AppraisalUnit]
		/// </summary>
		[Field("AppraisalUnit", DbType.String, false)]
		public string AppraisalUnit
		{
			get { return _AppraisalUnit; }
			set { this._AppraisalUnit = value; }
		}
		private string _AppraisalPoints  = String.Empty;
		/// <summary>
		/// 鉴定要求 [AppraisalPoints]
		/// </summary>
		[Field("AppraisalPoints", DbType.String, false)]
		public string AppraisalPoints
		{
			get { return _AppraisalPoints; }
			set { this._AppraisalPoints = value; }
		}
		private DateTime _AppraisaDate ;
		/// <summary>
		///  [AppraisaDate]
		/// </summary>
		[Field("AppraisaDate", DbType.Date, false)]
		public DateTime AppraisaDate
		{
			get { return _AppraisaDate; }
			set { this._AppraisaDate = value; }
		}
		private string _ContactUserName  = String.Empty;
		/// <summary>
		/// 联系人 [ContactUserName]
		/// </summary>
		[Field("ContactUserName", DbType.String, false)]
		public string ContactUserName
		{
			get { return _ContactUserName; }
			set { this._ContactUserName = value; }
		}
		private string _ContactUserPhone  = String.Empty;
		/// <summary>
		/// 联系电话 [ContactUserPhone]
		/// </summary>
		[Field("ContactUserPhone", DbType.String, false)]
		public string ContactUserPhone
		{
			get { return _ContactUserPhone; }
			set { this._ContactUserPhone = value; }
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
		public AppraisalEntrust()
		{ 
            
        }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal AppraisalEntrust(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.AppraisalEntrust).Where(DataBases.AppraisalEntrust.ID == ID);
			Init(section,DataBases.AppraisalEntrust);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.AppraisalEntrust,DataBases.AppraisalEntrust.ID.Count()).Where(DataBases.AppraisalEntrust.ID == ID);
			Update(section,DataBases.AppraisalEntrust);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.AppraisalEntrust).Where(DataBases.AppraisalEntrust.ID == ID);
			Remove(section,DataBases.AppraisalEntrust);
		}
	}
}

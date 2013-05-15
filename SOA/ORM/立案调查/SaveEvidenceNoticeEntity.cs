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
	[Table("SaveEvidenceNotice", true)]
	public partial class SaveEvidenceNotice : BaseEntity<SaveEvidenceNotice>
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
		private DateTime _ToTime ;
		/// <summary>
		/// 来接受处理的日期 [ToTime]
		/// </summary>
		[Field("ToTime", DbType.Date, false)]
		public DateTime ToTime
		{
			get { return _ToTime; }
			set { this._ToTime = value; }
		}
		private string _QFirstPerson  = String.Empty;
		/// <summary>
		/// 安检局 [QFirstPerson]
		/// </summary>
		[Field("QFirstPerson", DbType.String, false)]
		public string QFirstPerson
		{
			get { return _QFirstPerson; }
			set { this._QFirstPerson = value; }
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
		public SaveEvidenceNotice()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal SaveEvidenceNotice(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceNotice).Where(DataBases.SaveEvidenceNotice.ID == ID);
			Init(section,DataBases.SaveEvidenceNotice);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.SaveEvidenceNotice,DataBases.SaveEvidenceNotice.ID.Count()).Where(DataBases.SaveEvidenceNotice.ID == ID);
			Update(section,DataBases.SaveEvidenceNotice);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.SaveEvidenceNotice).Where(DataBases.SaveEvidenceNotice.ID == ID);
			Remove(section,DataBases.SaveEvidenceNotice);
		}
	}
}

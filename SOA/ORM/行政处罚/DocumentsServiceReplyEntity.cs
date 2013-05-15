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
	[Table("DocumentsServiceReply", true)]
	public partial class DocumentsServiceReply : BaseEntity<DocumentsServiceReply>
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
		private string _CompanyName  = String.Empty;
		/// <summary>
		/// 受送达单位 [CompanyName]
		/// </summary>
		[Field("CompanyName", DbType.String, false)]
		public string CompanyName
		{
			get { return _CompanyName; }
			set { this._CompanyName = value; }
		}
		private string _DocManageArea  = String.Empty;
		/// <summary>
		/// 安检局 [DocManageArea]
		/// </summary>
		[Field("DocManageArea", DbType.String, false)]
		public string DocManageArea
		{
			get { return _DocManageArea; }
			set { this._DocManageArea = value; }
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
		
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public DocumentsServiceReply()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal DocumentsServiceReply(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.DocumentsServiceReply).Where(DataBases.DocumentsServiceReply.ID == ID);
			Init(section,DataBases.DocumentsServiceReply);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.DocumentsServiceReply,DataBases.DocumentsServiceReply.ID.Count()).Where(DataBases.DocumentsServiceReply.ID == ID);
			Update(section,DataBases.DocumentsServiceReply);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.DocumentsServiceReply).Where(DataBases.DocumentsServiceReply.ID == ID);
			Remove(section,DataBases.DocumentsServiceReply);
		}
	}
}

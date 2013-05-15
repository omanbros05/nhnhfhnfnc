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
	[Table("LawRegulations", true)]
	public partial class LawRegulations : BaseEntity<LawRegulations>
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
		private string _Title  = String.Empty;
		/// <summary>
		/// 名称 [Title]
		/// </summary>
		[Field("Title", DbType.String, false)]
		public string Title
		{
			get { return _Title; }
			set { this._Title = value; }
		}
		private string _Content  = String.Empty;
		/// <summary>
		/// 法规内容 [Content]
		/// </summary>
		[Field("Content", DbType.String, false)]
		public string Content
		{
			get { return _Content; }
			set { this._Content = value; }
		}
		private DateTime _CreateTime ;
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
		public LawRegulations()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal LawRegulations(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.LawRegulations).Where(DataBases.LawRegulations.ID == ID);
			Init(section,DataBases.LawRegulations);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.LawRegulations,DataBases.LawRegulations.ID.Count()).Where(DataBases.LawRegulations.ID == ID);
			Update(section,DataBases.LawRegulations);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.LawRegulations).Where(DataBases.LawRegulations.ID == ID);
			Remove(section,DataBases.LawRegulations);
		}
	}
}

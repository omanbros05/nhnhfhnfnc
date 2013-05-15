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
	[Table("CaseSource", true)]
	public partial class CaseSource : BaseEntity<CaseSource>
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
		private string _SourceName  = String.Empty;
		/// <summary>
		/// 来源名称 [SourceName]
		/// </summary>
		[Field("SourceName", DbType.String, false)]
		public string SourceName
		{
			get { return _SourceName; }
			set { this._SourceName = value; }
		}
		private int _OrderID ;
		/// <summary>
		/// 排序编号 [OrderID]
		/// </summary>
		[Field("OrderID", DbType.Int32, false)]
		public int OrderID
		{
			get { return _OrderID; }
			set { this._OrderID = value; }
		}
		
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public CaseSource()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal CaseSource(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.CaseSource).Where(DataBases.CaseSource.ID == ID);
			Init(section,DataBases.CaseSource);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.CaseSource,DataBases.CaseSource.ID.Count()).Where(DataBases.CaseSource.ID == ID);
			Update(section,DataBases.CaseSource);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.CaseSource).Where(DataBases.CaseSource.ID == ID);
			Remove(section,DataBases.CaseSource);
		}
	}
}

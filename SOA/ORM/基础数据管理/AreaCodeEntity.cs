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
	[Table("AreaCode", true)]
	public partial class AreaCode : BaseEntity<AreaCode>
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
		private string _CodeID  = String.Empty;
		/// <summary>
		/// 区域编码 [CodeID]
		/// </summary>
		[Field("CodeID", DbType.String, false)]
		public string CodeID
		{
			get { return _CodeID; }
			set { this._CodeID = value; }
		}
		private string _CodeName  = String.Empty;
		/// <summary>
		///  [CodeName]
		/// </summary>
		[Field("CodeName", DbType.String, false)]
		public string CodeName
		{
			get { return _CodeName; }
			set { this._CodeName = value; }
		}
		private int _ParentID ;
		/// <summary>
		/// 父级ID号 [ParentID]
		/// </summary>
		[Field("ParentID", DbType.Int32, false)]
		public int ParentID
		{
			get { return _ParentID; }
			set { this._ParentID = value; }
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
		private int _LevelID ;
		/// <summary>
		/// 级别编号 [LevelID]
		/// </summary>
		[Field("LevelID", DbType.Int32, false)]
		public int LevelID
		{
			get { return _LevelID; }
			set { this._LevelID = value; }
		}
		private string _LevelName  = String.Empty;
		/// <summary>
		/// 级别名称 [LevelName]
		/// </summary>
		[Field("LevelName", DbType.String, false)]
		public string LevelName
		{
			get { return _LevelName; }
			set { this._LevelName = value; }
		}
		private string _Path  = String.Empty;
		/// <summary>
		/// 节点路径 [Path]
		/// </summary>
		[Field("Path", DbType.String, false)]
		public string Path
		{
			get { return _Path; }
			set { this._Path = value; }
		}
		
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public AreaCode()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal AreaCode(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.AreaCode).Where(DataBases.AreaCode.ID == ID);
			Init(section,DataBases.AreaCode);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.AreaCode,DataBases.AreaCode.ID.Count()).Where(DataBases.AreaCode.ID == ID);
			Update(section,DataBases.AreaCode);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.AreaCode).Where(DataBases.AreaCode.ID == ID);
			Remove(section,DataBases.AreaCode);
		}
	}
}

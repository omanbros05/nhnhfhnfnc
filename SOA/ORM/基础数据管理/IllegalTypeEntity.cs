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
	[Table("IllegalType", true)]
	public partial class IllegalType : BaseEntity<IllegalType>
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
		private string _TypeName  = String.Empty;
		/// <summary>
		/// 类型名称 [TypeName]
		/// </summary>
		[Field("TypeName", DbType.String, false)]
		public string TypeName
		{
			get { return _TypeName; }
			set { this._TypeName = value; }
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
		public IllegalType()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal IllegalType(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.IllegalType).Where(DataBases.IllegalType.ID == ID);
			Init(section,DataBases.IllegalType);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.IllegalType,DataBases.IllegalType.ID.Count()).Where(DataBases.IllegalType.ID == ID);
			Update(section,DataBases.IllegalType);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.IllegalType).Where(DataBases.IllegalType.ID == ID);
			Remove(section,DataBases.IllegalType);
		}
	}
}

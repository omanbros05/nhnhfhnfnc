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
	[Table("Officers", true)]
	public partial class Officers : BaseEntity<Officers>
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
		private string _OfficersName  = String.Empty;
		/// <summary>
		/// 执法人员名称 [OfficersName]
		/// </summary>
		[Field("OfficersName", DbType.String, false)]
		public string OfficersName
		{
			get { return _OfficersName; }
			set { this._OfficersName = value; }
		}
		private string _Unit  = String.Empty;
		/// <summary>
		/// 单位 [Unit]
		/// </summary>
		[Field("Unit", DbType.String, false)]
		public string Unit
		{
			get { return _Unit; }
			set { this._Unit = value; }
		}
		private string _Position  = String.Empty;
		/// <summary>
		/// 职务 [Position]
		/// </summary>
		[Field("Position", DbType.String, false)]
		public string Position
		{
			get { return _Position; }
			set { this._Position = value; }
		}
		private string _CID  = String.Empty;
		/// <summary>
		/// 执法人员证件编号 [CID]
		/// </summary>
		[Field("CID", DbType.String, false)]
		public string CID
		{
			get { return _CID; }
			set { this._CID = value; }
		}
		
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public Officers()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal Officers(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.Officers).Where(DataBases.Officers.ID == ID);
			Init(section,DataBases.Officers);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.Officers,DataBases.Officers.ID.Count()).Where(DataBases.Officers.ID == ID);
			Update(section,DataBases.Officers);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.Officers).Where(DataBases.Officers.ID == ID);
			Remove(section,DataBases.Officers);
		}
	}
}

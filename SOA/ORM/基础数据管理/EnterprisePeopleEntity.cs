using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
	/// <summary>
    /// 企业人员表
	/// </summary>
	[Table("EnterprisePeople", true)]
	public partial class EnterprisePeople : BaseEntity<EnterprisePeople>
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
		private int _EnterpriseID ;
		/// <summary>
		/// 企业编号 [EnterpriseID]
		/// </summary>
		[Field("EnterpriseID", DbType.Int32, false)]
		public int EnterpriseID
		{
			get { return _EnterpriseID; }
			set { this._EnterpriseID = value; }
		}
		private string _EnterprisePeopleName  = String.Empty;
		/// <summary>
		/// 姓名 [EnterprisePeopleName]
		/// </summary>
		[Field("EnterprisePeopleName", DbType.String, false)]
		public string EnterprisePeopleName
		{
			get { return _EnterprisePeopleName; }
			set { this._EnterprisePeopleName = value; }
		}
		private bool _Sex ;
		/// <summary>
		/// 性别 [Sex]
		/// </summary>
		[Field("Sex", DbType.Boolean, false)]
		public bool Sex
		{
			get { return _Sex; }
			set { this._Sex = value; }
		}
		private int _Age ;
		/// <summary>
		/// 年龄 [Age]
		/// </summary>
		[Field("Age", DbType.Int32, false)]
		public int Age
		{
			get { return _Age; }
			set { this._Age = value; }
		}
		private string _IdNumber  = String.Empty;
		/// <summary>
		/// 身份证号 [IdNumber]
		/// </summary>
		[Field("IdNumber", DbType.String, false)]
		public string IdNumber
		{
			get { return _IdNumber; }
			set { this._IdNumber = value; }
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
		private string _Address  = String.Empty;
		/// <summary>
		/// 住址 [Address]
		/// </summary>
		[Field("Address", DbType.String, false)]
		public string Address
		{
			get { return _Address; }
			set { this._Address = value; }
		}
		private string _Phone  = String.Empty;
		/// <summary>
		/// 电话 [Phone]
		/// </summary>
		[Field("Phone", DbType.String, false)]
		public string Phone
		{
			get { return _Phone; }
			set { this._Phone = value; }
		}
		private string _Note  = String.Empty;
		/// <summary>
		/// 备注 [Note]
		/// </summary>
		[Field("Note", DbType.String, false)]
		public string Note
		{
			get { return _Note; }
			set { this._Note = value; }
		}
		
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public EnterprisePeople()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal EnterprisePeople(int enterprisePeopleID)
		{
			ID = enterprisePeopleID;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.EnterprisePeople).Where(DataBases.EnterprisePeople.ID == ID);
			Init(section,DataBases.EnterprisePeople);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.EnterprisePeople,DataBases.EnterprisePeople.ID.Count()).Where(DataBases.EnterprisePeople.ID == ID);
			Update(section,DataBases.EnterprisePeople);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.EnterprisePeople).Where(DataBases.EnterprisePeople.ID == ID);
			Remove(section,DataBases.EnterprisePeople);
		}
	}
}

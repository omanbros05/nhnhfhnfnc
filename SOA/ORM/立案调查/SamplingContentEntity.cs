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
	[Table("SamplingContent", true)]
	public partial class SamplingContent : BaseEntity<SamplingContent>
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
		private string _SDocTitle  = String.Empty;
		/// <summary>
		/// 抽样内容编号 [SDocTitle]
		/// </summary>
		[Field("SDocTitle", DbType.String, false)]
		public string SDocTitle
		{
			get { return _SDocTitle; }
			set { this._SDocTitle = value; }
		}
		private string _ItemName  = String.Empty;
		/// <summary>
		/// 证据物品名称 [ItemName]
		/// </summary>
		[Field("ItemName", DbType.String, false)]
		public string ItemName
		{
			get { return _ItemName; }
			set { this._ItemName = value; }
		}
		private string _ItemRule  = String.Empty;
		/// <summary>
		/// 规格及批号 [ItemRule]
		/// </summary>
		[Field("ItemRule", DbType.String, false)]
		public string ItemRule
		{
			get { return _ItemRule; }
			set { this._ItemRule = value; }
		}
		private int _Origin ;
		/// <summary>
		/// 产地编号 [Origin]
		/// </summary>
		[Field("Origin", DbType.Int32, false)]
		public int Origin
		{
			get { return _Origin; }
			set { this._Origin = value; }
		}
		private string _Grade  = String.Empty;
		/// <summary>
		/// 成色（品级） [Grade]
		/// </summary>
		[Field("Grade", DbType.String, false)]
		public string Grade
		{
			get { return _Grade; }
			set { this._Grade = value; }
		}
		private int _Count ;
		/// <summary>
		/// 数量 [Count]
		/// </summary>
		[Field("Count", DbType.Int32, false)]
		public int Count
		{
			get { return _Count; }
			set { this._Count = value; }
		}
		private string _ItemUnit  = String.Empty;
		/// <summary>
		/// 物品单位 [ItemUnit]
		/// </summary>
		[Field("ItemUnit", DbType.String, false)]
		public string ItemUnit
		{
			get { return _ItemUnit; }
			set { this._ItemUnit = value; }
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
		public SamplingContent()
		{ }

		
		/// <summary>
		/// 构造函数
		/// </summary>
		internal SamplingContent(int id)
		{
			ID = id;
			Init();
		}
		
	
		/// <summary>
		/// 初始化实体
		/// </summary>
		internal override void Init()
		{
			SelectSqlSection section = DB.Select(DataBases.SamplingContent).Where(DataBases.SamplingContent.ID == ID);
			Init(section,DataBases.SamplingContent);
		}
		
		/// <summary>
		/// 更新实体到数据库(带事务)
		/// </summary>
		internal override void Update()
		{
			SelectSqlSection section = DB.Select(DataBases.SamplingContent,DataBases.SamplingContent.ID.Count()).Where(DataBases.SamplingContent.ID == ID);
			Update(section,DataBases.SamplingContent);
		}
		
		/// <summary>
		/// 从数据库中删除实体(带事务)
		/// </summary>
		internal override void Remove()
		{
			DeleteSqlSection section = DB.Delete(DataBases.SamplingContent).Where(DataBases.SamplingContent.ID == ID);
			Remove(section,DataBases.SamplingContent);
		}
	}
}

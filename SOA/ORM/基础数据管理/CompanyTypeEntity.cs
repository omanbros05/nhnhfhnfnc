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
    [Table("CompanyType", true)]
    public partial class CompanyType : BaseEntity<CompanyType>
    {
        private int _ID;
        /// <summary>
        ///  [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _CompanyTypeName = String.Empty;
        /// <summary>
        ///  [CompanyTypeName]
        /// </summary>
        [Field("CompanyTypeName", DbType.String, false)]
        public string CompanyTypeName
        {
            get { return _CompanyTypeName; }
            set { this._CompanyTypeName = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CompanyType()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyType(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyType).Where(DataBases.CompanyType.ID == ID);
            Init(section, DataBases.CompanyType);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyType, DataBases.CompanyType.ID.Count()).Where(DataBases.CompanyType.ID == ID);
            Update(section, DataBases.CompanyType);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyType).Where(DataBases.CompanyType.ID == ID);
            Remove(section, DataBases.CompanyType);
        }
    }
}

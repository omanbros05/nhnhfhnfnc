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
    [Table("CompanyArea", true)]
    public partial class CompanyArea : BaseEntity<CompanyArea>
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
        private string _AreaName = String.Empty;
        /// <summary>
        ///  [AreaName]
        /// </summary>
        [Field("AreaName", DbType.String, false)]
        public string AreaName
        {
            get { return _AreaName; }
            set { this._AreaName = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CompanyArea()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyArea(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyArea).Where(DataBases.CompanyArea.ID == ID);
            Init(section, DataBases.CompanyArea);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyArea, DataBases.CompanyArea.ID.Count()).Where(DataBases.CompanyArea.ID == ID);
            Update(section, DataBases.CompanyArea);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyArea).Where(DataBases.CompanyArea.ID == ID);
            Remove(section, DataBases.CompanyArea);
        }
    }
}

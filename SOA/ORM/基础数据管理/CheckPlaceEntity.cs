using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 检查场所
    /// </summary>
    [Table("CheckPlace", true)]
    public partial class CheckPlace : BaseEntity<CheckPlace>
    {
        private int _ID;
        /// <summary>
        /// 自增编号 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _CheckContent = String.Empty;
        /// <summary>
        /// 检查场所 [CheckContent]
        /// </summary>
        [Field("CheckContent", DbType.String, false)]
        public string CheckContent
        {
            get { return _CheckContent; }
            set { this._CheckContent = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CheckPlace()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CheckPlace(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CheckPlace).Where(DataBases.CheckPlace.ID == ID);
            Init(section, DataBases.CheckPlace);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CheckPlace, DataBases.CheckPlace.ID.Count()).Where(DataBases.CheckPlace.ID == ID);
            Update(section, DataBases.CheckPlace);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CheckPlace).Where(DataBases.CheckPlace.ID == ID);
            Remove(section, DataBases.CheckPlace);
        }
    }
}

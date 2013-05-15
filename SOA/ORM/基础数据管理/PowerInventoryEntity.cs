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
    [Table("PowerInventory", true)]
    public partial class PowerInventory : BaseEntity<PowerInventory>
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
        private string _PowerName = String.Empty;
        /// <summary>
        ///  [PowerName]
        /// </summary>
        [Field("PowerName", DbType.String, false)]
        public string PowerName
        {
            get { return _PowerName; }
            set { this._PowerName = value; }
        }
        private string _PowerNumber = String.Empty;
        /// <summary>
        ///  [PowerNumber]
        /// </summary>
        [Field("PowerNumber", DbType.String, false)]
        public string PowerNumber
        {
            get { return _PowerNumber; }
            set { this._PowerNumber = value; }
        }
        private int _PowerType;
        /// <summary>
        ///  [PowerType]
        /// </summary>
        [Field("PowerType", DbType.Int32, false)]
        public int PowerType
        {
            get { return _PowerType; }
            set { this._PowerType = value; }
        }
        private string _PowerSubject = String.Empty;
        /// <summary>
        ///  [PowerSubject]
        /// </summary>
        [Field("PowerSubject", DbType.String, false)]
        public string PowerSubject
        {
            get { return _PowerSubject; }
            set { this._PowerSubject = value; }
        }
        private string _PowerContent = String.Empty;
        /// <summary>
        ///  [PowerContent]
        /// </summary>
        [Field("PowerContent", DbType.String, false)]
        public string PowerContent
        {
            get { return _PowerContent; }
            set { this._PowerContent = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public PowerInventory()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal PowerInventory(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.PowerInventory).Where(DataBases.PowerInventory.ID == ID);
            Init(section, DataBases.PowerInventory);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.PowerInventory, DataBases.PowerInventory.ID.Count()).Where(DataBases.PowerInventory.ID == ID);
            Update(section, DataBases.PowerInventory);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.PowerInventory).Where(DataBases.PowerInventory.ID == ID);
            Remove(section, DataBases.PowerInventory);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 历史文书文件夹管理
    /// </summary>
    [Table("InstrumentsHistoryFolder", true)]
    public partial class InstrumentsHistoryFolder : BaseEntity<InstrumentsHistoryFolder>
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
        private int _InstrumentsParentType = -1;
        /// <summary>
        ///  [InstrumentsParentType]
        /// </summary>
        [Field("InstrumentsParentType", DbType.Int32, false)]
        public int InstrumentsParentType
        {
            get { return _InstrumentsParentType; }
            set { this._InstrumentsParentType = value; }
        }
        private int _InstrumentsChildType = -1;
        /// <summary>
        ///  [InstrumentsChildType]
        /// </summary>
        [Field("InstrumentsChildType", DbType.Int32, false)]
        public int InstrumentsChildType
        {
            get { return _InstrumentsChildType; }
            set { this._InstrumentsChildType = value; }
        }
        private int _InstrumentsYear = -1;
        /// <summary>
        ///  [InstrumentsYear]
        /// </summary>
        [Field("InstrumentsYear", DbType.Int32, false)]
        public int InstrumentsYear
        {
            get { return _InstrumentsYear; }
            set { this._InstrumentsYear = value; }
        }
        private int _InstrumentsMonth = -1;
        /// <summary>
        ///  [InstrumentsMonth]
        /// </summary>
        [Field("InstrumentsMonth", DbType.Int32, false)]
        public int InstrumentsMonth
        {
            get { return _InstrumentsMonth; }
            set { this._InstrumentsMonth = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public InstrumentsHistoryFolder()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal InstrumentsHistoryFolder(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFolder).Where(DataBases.InstrumentsHistoryFolder.ID == ID);
            Init(section, DataBases.InstrumentsHistoryFolder);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFolder, DataBases.InstrumentsHistoryFolder.ID.Count()).Where(DataBases.InstrumentsHistoryFolder.ID == ID);
            Update(section, DataBases.InstrumentsHistoryFolder);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.InstrumentsHistoryFolder).Where(DataBases.InstrumentsHistoryFolder.ID == ID);
            Remove(section, DataBases.InstrumentsHistoryFolder);
        }
    }
}

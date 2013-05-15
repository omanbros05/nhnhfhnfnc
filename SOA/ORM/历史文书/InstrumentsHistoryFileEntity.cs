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
    [Table("InstrumentsHistoryFile", true)]
    public partial class InstrumentsHistoryFile : BaseEntity<InstrumentsHistoryFile>
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
        private string _InstrumentsTitle = String.Empty;
        /// <summary>
        ///  [InstrumentsTitle]
        /// </summary>
        [Field("InstrumentsTitle", DbType.String, false)]
        public string InstrumentsTitle
        {
            get { return _InstrumentsTitle; }
            set { this._InstrumentsTitle = value; }
        }
        private string _InstrumentsPath = String.Empty;
        /// <summary>
        ///  [InstrumentsPath]
        /// </summary>
        [Field("InstrumentsPath", DbType.String, false)]
        public string InstrumentsPath
        {
            get { return _InstrumentsPath; }
            set { this._InstrumentsPath = value; }
        }
        private int _InstrumentsFolderID = -1;
        /// <summary>
        ///  [InstrumentsFolderID]
        /// </summary>
        [Field("InstrumentsFolderID", DbType.Int32, false)]
        public int InstrumentsFolderID
        {
            get { return _InstrumentsFolderID; }
            set { this._InstrumentsFolderID = value; }
        }
        private string _TableName = String.Empty;
        /// <summary>
        ///  [TableName]
        /// </summary>
        [Field("TableName", DbType.String, false)]
        public string TableName
        {
            get { return _TableName; }
            set { this._TableName = value; }
        }
        private int _TableID = -1;
        /// <summary>
        ///  [TableID]
        /// </summary>
        [Field("TableID", DbType.Int32, false)]
        public int TableID
        {
            get { return _TableID; }
            set { this._TableID = value; }
        }
        private string _CompanyName = String.Empty;
        /// <summary>
        ///  [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public InstrumentsHistoryFile()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal InstrumentsHistoryFile(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFile).Where(DataBases.InstrumentsHistoryFile.ID == ID);
            Init(section, DataBases.InstrumentsHistoryFile);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFile, DataBases.InstrumentsHistoryFile.ID.Count()).Where(DataBases.InstrumentsHistoryFile.ID == ID);
            Update(section, DataBases.InstrumentsHistoryFile);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.InstrumentsHistoryFile).Where(DataBases.InstrumentsHistoryFile.ID == ID);
            Remove(section, DataBases.InstrumentsHistoryFile);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 存档
    /// </summary>
    [Table("ImportDocument", true)]
    public partial class ImportDocument : BaseEntity<ImportDocument>
    {
        private int _ID;
        /// <summary>
        /// 自增列 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _TableName = String.Empty;
        /// <summary>
        /// 表名 [TableName]
        /// </summary>
        [Field("TableName", DbType.String, false)]
        public string TableName
        {
            get { return _TableName; }
            set { this._TableName = value; }
        }
        private string _TableID = String.Empty;
        /// <summary>
        ///  [TableID]
        /// </summary>
        [Field("TableID", DbType.String, false)]
        public string TableID
        {
            get { return _TableID; }
            set { this._TableID = value; }
        }
        private string _DocName = String.Empty;
        /// <summary>
        /// 用户输入文档名称 [DocName]
        /// </summary>
        [Field("DocName", DbType.String, false)]
        public string DocName
        {
            get { return _DocName; }
            set { this._DocName = value; }
        }
        private string _DiskDocName = String.Empty;
        /// <summary>
        /// 磁盘中文件名称 [DiskDocName]
        /// </summary>
        [Field("DiskDocName", DbType.String, false)]
        public string DiskDocName
        {
            get { return _DiskDocName; }
            set { this._DiskDocName = value; }
        }
        private EDocumentState _DocState = EDocumentState.存档;
        /// <summary>
        /// 文档状态 [DocState]
        /// </summary>
        [Field("DocState", DbType.Int32, false)]
        public EDocumentState DocState
        {
            get { return _DocState; }
            set { this._DocState = value; }
        }
        private int _DirectoryID;
        /// <summary>
        ///  [DirectoryID]
        /// </summary>
        [Field("DirectoryID", DbType.Int32, false)]
        public int DirectoryID
        {
            get { return _DirectoryID; }
            set { this._DirectoryID = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ImportDocument()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ImportDocument(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ImportDocument).Where(DataBases.ImportDocument.ID == ID);
            Init(section, DataBases.ImportDocument);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ImportDocument, DataBases.ImportDocument.ID.Count()).Where(DataBases.ImportDocument.ID == ID);
            Update(section, DataBases.ImportDocument);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ImportDocument).Where(DataBases.ImportDocument.ID == ID);
            Remove(section, DataBases.ImportDocument);
        }
    }
}

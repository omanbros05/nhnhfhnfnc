using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NBearLite;

namespace SOA.ORM
{
    [Table("ArchiveExt", true)]
    public partial class ArchiveExtEntity : BaseEntity<ArchiveExtEntity>
    {
        private int _archiveId;

        private string _tableName;

        private int _primaryValue;

        private string _fileName;

        private string _title;


        [Field("Title", System.Data.DbType.String, false)]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Field("FileName", System.Data.DbType.String, false)]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        [Field("archiveID", System.Data.DbType.Int32, true)]
        public int ArchiveId
        {
            get { return _archiveId; }
            set { _archiveId = value; }
        }

        [Field("tableName", System.Data.DbType.String, true)]
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        [Field("primaryValue", System.Data.DbType.Int32, true)]
        public int PrimaryValue
        {
            get { return _primaryValue; }
            set { _primaryValue = value; }
        }

        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ArchiveExt).Where(DataBases.ArchiveExt.ArchiveID == ArchiveId);
            Init(section, DataBases.ArchiveExt);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ArchiveExt, DataBases.ArchiveExt.ArchiveID.Count()).Where(DataBases.ArchiveExt.ArchiveID == ArchiveId);
            Update(section, DataBases.ArchiveExt);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ArchiveExt).Where(DataBases.ArchiveExt.ArchiveID == ArchiveId);
            Remove(section, DataBases.ArchiveExt);
        }

        public void RemoveByID(int archiveId)
        {
            DeleteSqlSection section = DB.Delete(DataBases.ArchiveExt).Where(DataBases.ArchiveExt.ArchiveID == archiveId);
            Remove(section, DataBases.ArchiveExt);

            // string sql = "UPDATE (SELECT TableName FROM ArchiveExt WHERE ArchiveID=archiveId) SET Status=1;"
        }
    }
}

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
    [Table("LawFile", true)]
    public partial class LawFile : BaseEntity<LawFile>
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
        private string _LawTitle = String.Empty;
        /// <summary>
        /// 法律法规的文件名 [LawTitle]
        /// </summary>
        [Field("LawTitle", DbType.String, false)]
        public string LawTitle
        {
            get { return _LawTitle; }
            set { this._LawTitle = value; }
        }
        private string _LawFilePath = String.Empty;
        /// <summary>
        /// 法律法规文件的路径 [LawFilePath]
        /// </summary>
        [Field("LawFilePath", DbType.String, false)]
        public string LawFilePath
        {
            get { return _LawFilePath; }
            set { this._LawFilePath = value; }
        }
        private int _LawType = -1;
        /// <summary>
        /// 法律法规类型 [LawType]
        /// </summary>
        [Field("LawType", DbType.Int32, false)]
        public int LawType
        {
            get { return _LawType; }
            set { this._LawType = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public LawFile()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal LawFile(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.LawFile).Where(DataBases.LawFile.ID == ID);
            Init(section, DataBases.LawFile);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.LawFile, DataBases.LawFile.ID.Count()).Where(DataBases.LawFile.ID == ID);
            Update(section, DataBases.LawFile);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.LawFile).Where(DataBases.LawFile.ID == ID);
            Remove(section, DataBases.LawFile);
        }
    }
}

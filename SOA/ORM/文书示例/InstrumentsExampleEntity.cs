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
    [Table("InstrumentsExample", true)]
    public partial class InstrumentsExample : BaseEntity<InstrumentsExample>
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
        /// 文书示例标题 [InstrumentsTitle]
        /// </summary>
        [Field("InstrumentsTitle", DbType.String, false)]
        public string InstrumentsTitle
        {
            get { return _InstrumentsTitle; }
            set { this._InstrumentsTitle = value; }
        }
        private string _InstrumentsPath = String.Empty;
        /// <summary>
        /// 文书示例路径 [InstrumentsPath]
        /// </summary>
        [Field("InstrumentsPath", DbType.String, false)]
        public string InstrumentsPath
        {
            get { return _InstrumentsPath; }
            set { this._InstrumentsPath = value; }
        }
        private int _InstrumentsType;
        /// <summary>
        /// 文书示例类型 [InstrumentsType]
        /// </summary>
        [Field("InstrumentsType", DbType.Int32, false)]
        public int InstrumentsType
        {
            get { return _InstrumentsType; }
            set { this._InstrumentsType = value; }
        }
        private int _InstrumentsChildType;
        /// <summary>
        /// 文书示例子类型 [InstrumentsChildType]
        /// </summary>
        [Field("InstrumentsChildType", DbType.Int32, false)]
        public int InstrumentsChildType
        {
            get { return _InstrumentsChildType; }
            set { this._InstrumentsChildType = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public InstrumentsExample()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal InstrumentsExample(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsExample).Where(DataBases.InstrumentsExample.ID == ID);
            Init(section, DataBases.InstrumentsExample);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsExample, DataBases.InstrumentsExample.ID.Count()).Where(DataBases.InstrumentsExample.ID == ID);
            Update(section, DataBases.InstrumentsExample);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.InstrumentsExample).Where(DataBases.InstrumentsExample.ID == ID);
            Remove(section, DataBases.InstrumentsExample);
        }
    }
}

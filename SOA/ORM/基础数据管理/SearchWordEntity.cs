using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 搜索表
    /// </summary>
    [Table("SearchWord", true)]
    public partial class SearchWord : BaseEntity<SearchWord>
    {
        private int _ID;
        /// <summary>
        /// GUID [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _Words = String.Empty;
        /// <summary>
        /// 文字 [Words]
        /// </summary>
        [Field("Words", DbType.String, false)]
        public string Words
        {
            get { return _Words; }
            set { this._Words = value; }
        }
        private string _SearchIndex = String.Empty;
        /// <summary>
        /// 查询索引 [SearchIndex]
        /// </summary>
        [Field("SearchIndex", DbType.String, false)]
        public string SearchIndex
        {
            get { return _SearchIndex; }
            set { this._SearchIndex = value; }
        }
        private string _Fields = String.Empty;
        /// <summary>
        ///  [Fields]
        /// </summary>
        [Field("Fields", DbType.String, false)]
        public string Fields
        {
            get { return _Fields; }
            set { this._Fields = value; }
        }
        private int _Rate;
        /// <summary>
        /// 使用频率 [Rate]
        /// </summary>
        [Field("Rate", DbType.Int32, false)]
        public int Rate
        {
            get { return _Rate; }
            set { this._Rate = value; }
        }
        private string _WordClassType = String.Empty;
        /// <summary>
        /// 类型 [WordClassType]
        /// </summary>
        [Field("WordClassType", DbType.String, false)]
        public string WordClassType
        {
            get { return _WordClassType; }
            set { this._WordClassType = value; }
        }
        private string _TableID = String.Empty;
        /// <summary>
        /// 表主键字段编号 [TableID]
        /// </summary>
        [Field("TableID", DbType.String, false)]
        public string TableID
        {
            get { return _TableID; }
            set { this._TableID = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SearchWord()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SearchWord(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SearchWord).Where(DataBases.SearchWord.ID == ID);
            Init(section, DataBases.SearchWord);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SearchWord, DataBases.SearchWord.ID.Count()).Where(DataBases.SearchWord.ID == ID);
            Update(section, DataBases.SearchWord);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SearchWord).Where(DataBases.SearchWord.ID == ID);
            Remove(section, DataBases.SearchWord);
        }
    }
}

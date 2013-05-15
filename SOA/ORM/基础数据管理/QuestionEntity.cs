using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 问题表
    /// </summary>
    [Table("Question", true)]
    public partial class Question : BaseEntity<Question>
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
        private string _QuestionInfo = String.Empty;
        /// <summary>
        /// 问题内容 [QuestionInfo]
        /// </summary>
        [Field("QuestionInfo", DbType.String, false)]
        public string QuestionInfo
        {
            get { return _QuestionInfo; }
            set { this._QuestionInfo = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Question()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal Question(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.Question).Where(DataBases.Question.ID == ID);
            Init(section, DataBases.Question);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.Question, DataBases.Question.ID.Count()).Where(DataBases.Question.ID == ID);
            Update(section, DataBases.Question);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.Question).Where(DataBases.Question.ID == ID);
            Remove(section, DataBases.Question);
        }
    }
}

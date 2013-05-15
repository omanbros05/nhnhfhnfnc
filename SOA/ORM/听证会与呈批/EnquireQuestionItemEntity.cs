using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 问题项表
    /// </summary>
    [Table("EnquireQuestionItem", true)]
    public partial class EnquireQuestionItem : BaseEntity<EnquireQuestionItem>
    {
        private int _ID;
        /// <summary>
        /// 自动编号 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private int _EnquireID;
        /// <summary>
        /// 询问笔录主表编号 [EnquireID]
        /// </summary>
        [Field("EnquireID", DbType.Int32, false)]
        public int EnquireID
        {
            get { return _EnquireID; }
            set { this._EnquireID = value; }
        }
        private string _Question = String.Empty;
        /// <summary>
        /// 问题 [Question]
        /// </summary>
        [Field("Question", DbType.String, false)]
        public string Question
        {
            get { return _Question; }
            set { this._Question = value; }
        }
        private string _Anwser = String.Empty;
        /// <summary>
        /// 回答 [Anwser]
        /// </summary>
        [Field("Anwser", DbType.String, false)]
        public string Anwser
        {
            get { return _Anwser; }
            set { this._Anwser = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public EnquireQuestionItem()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal EnquireQuestionItem(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.EnquireQuestionItem).Where(DataBases.EnquireQuestionItem.ID == ID);
            Init(section, DataBases.EnquireQuestionItem);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.EnquireQuestionItem, DataBases.EnquireQuestionItem.ID.Count()).Where(DataBases.EnquireQuestionItem.ID == ID);
            Update(section, DataBases.EnquireQuestionItem);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.EnquireQuestionItem).Where(DataBases.EnquireQuestionItem.ID == ID);
            Remove(section, DataBases.EnquireQuestionItem);
        }
    }
}

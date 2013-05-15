using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 律师
    /// </summary>
    [Table("Lawyer", true)]
    public partial class Lawyer : BaseEntity<Lawyer>
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
        private string _LawyerName = String.Empty;
        /// <summary>
        /// 姓名 [LawyerName]
        /// </summary>
        [Field("LawyerName", DbType.String, false)]
        public string LawyerName
        {
            get { return _LawyerName; }
            set { this._LawyerName = value; }
        }
        private string _Sex = String.Empty;
        /// <summary>
        /// 性别 [Sex]
        /// </summary>
        [Field("Sex", DbType.String, false)]
        public string Sex
        {
            get { return _Sex; }
            set { this._Sex = value; }
        }
        private string _Age = String.Empty;
        /// <summary>
        /// 年龄 [Age]
        /// </summary>
        [Field("Age", DbType.String, false)]
        public string Age
        {
            get { return _Age; }
            set { this._Age = value; }
        }
        private string _Job = String.Empty;
        /// <summary>
        ///  [Job]
        /// </summary>
        [Field("Job", DbType.String, false)]
        public string Job
        {
            get { return _Job; }
            set { this._Job = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Lawyer()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal Lawyer(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.Lawyer).Where(DataBases.Lawyer.ID == ID);
            Init(section, DataBases.Lawyer);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.Lawyer, DataBases.Lawyer.ID.Count()).Where(DataBases.Lawyer.ID == ID);
            Update(section, DataBases.Lawyer);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.Lawyer).Where(DataBases.Lawyer.ID == ID);
            Remove(section, DataBases.Lawyer);
        }
    }
}

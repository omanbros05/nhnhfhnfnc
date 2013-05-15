using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 自然人
    /// </summary>
    [Table("NaturalPerson", true)]
    public partial class NaturalPerson : BaseEntity<NaturalPerson>
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
        private string _PersonName = String.Empty;
        /// <summary>
        /// 姓名 [PersonName]
        /// </summary>
        [Field("PersonName", DbType.String, false)]
        public string PersonName
        {
            get { return _PersonName; }
            set { this._PersonName = value; }
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
        private string _IDcard = String.Empty;
        /// <summary>
        /// 身份证号 [IDcard]
        /// </summary>
        [Field("IDcard", DbType.String, false)]
        public string IDcard
        {
            get { return _IDcard; }
            set { this._IDcard = value; }
        }
        private string _Address = String.Empty;
        /// <summary>
        /// 住址 [Address]
        /// </summary>
        [Field("Address", DbType.String, false)]
        public string Address
        {
            get { return _Address; }
            set { this._Address = value; }
        }
        private string _CompanyName = String.Empty;
        /// <summary>
        /// 单位名称 [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private string _Job = String.Empty;
        /// <summary>
        /// 职务 [Job]
        /// </summary>
        [Field("Job", DbType.String, false)]
        public string Job
        {
            get { return _Job; }
            set { this._Job = value; }
        }
        private string _CompanyAddress = String.Empty;
        /// <summary>
        /// 单位地址 [CompanyAddress]
        /// </summary>
        [Field("CompanyAddress", DbType.String, false)]
        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { this._CompanyAddress = value; }
        }
        private string _CompanyTel = String.Empty;
        /// <summary>
        /// 联系电话 [CompanyTel]
        /// </summary>
        [Field("CompanyTel", DbType.String, false)]
        public string CompanyTel
        {
            get { return _CompanyTel; }
            set { this._CompanyTel = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public NaturalPerson()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal NaturalPerson(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.NaturalPerson).Where(DataBases.NaturalPerson.ID == ID);
            Init(section, DataBases.NaturalPerson);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.NaturalPerson, DataBases.NaturalPerson.ID.Count()).Where(DataBases.NaturalPerson.ID == ID);
            Update(section, DataBases.NaturalPerson);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.NaturalPerson).Where(DataBases.NaturalPerson.ID == ID);
            Remove(section, DataBases.NaturalPerson);
        }
    }
}

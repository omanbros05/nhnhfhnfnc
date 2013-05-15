using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Table("UserInfo", true)]
    public partial class UserInfo : BaseEntity<UserInfo>
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
        private string _FullName = String.Empty;
        /// <summary>
        /// 单位全称 [FullName]
        /// </summary>
        [Field("FullName", DbType.String, false)]
        public string FullName
        {
            get { return _FullName; }
            set { this._FullName = value; }
        }
        private string _Abb = String.Empty;
        /// <summary>
        /// 单位简称 [Abb]
        /// </summary>
        [Field("Abb", DbType.String, false)]
        public string Abb
        {
            get { return _Abb; }
            set { this._Abb = value; }
        }
        private string _Address = String.Empty;
        /// <summary>
        /// 单位地址 [Address]
        /// </summary>
        [Field("Address", DbType.String, false)]
        public string Address
        {
            get { return _Address; }
            set { this._Address = value; }
        }
        private string _Tel = String.Empty;
        /// <summary>
        /// 单位联系方式 [Tel]
        /// </summary>
        [Field("Tel", DbType.String, false)]
        public string Tel
        {
            get { return _Tel; }
            set { this._Tel = value; }
        }
        private string _Post = String.Empty;
        /// <summary>
        /// 单位地区邮编 [Post]
        /// </summary>
        [Field("Post", DbType.String, false)]
        public string Post
        {
            get { return _Post; }
            set { this._Post = value; }
        }
        private string _Area = String.Empty;
        /// <summary>
        /// 地区名称 [Area]
        /// </summary>
        [Field("Area", DbType.String, false)]
        public string Area
        {
            get { return _Area; }
            set { this._Area = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public UserInfo()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal UserInfo(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.UserInfo).Where(DataBases.UserInfo.ID == ID);
            Init(section, DataBases.UserInfo);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.UserInfo, DataBases.UserInfo.ID.Count()).Where(DataBases.UserInfo.ID == ID);
            Update(section, DataBases.UserInfo);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.UserInfo).Where(DataBases.UserInfo.ID == ID);
            Remove(section, DataBases.UserInfo);
        }
    }
}

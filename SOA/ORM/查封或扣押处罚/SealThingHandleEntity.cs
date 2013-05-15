using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 查封（扣押）物品处理决定书
    /// </summary>
    [Table("SealThingHandle", true)]
    public partial class SealThingHandle : BaseEntity<SealThingHandle>
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
        private string _CompanyName = String.Empty;
        /// <summary>
        /// 公司名称 [CompanyName]
        /// </summary>
        [Field("CompanyName", DbType.String, false)]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { this._CompanyName = value; }
        }
        private DateTime _SealDate;
        /// <summary>
        /// 查封日期 [SealDate]
        /// </summary>
        [Field("SealDate", DbType.DateTime, false)]
        public DateTime SealDate
        {
            get { return _SealDate; }
            set { this._SealDate = value; }
        }
        private string _SealContent = String.Empty;
        /// <summary>
        /// 查封内容 [SealContent]
        /// </summary>
        [Field("SealContent", DbType.String, false)]
        public string SealContent
        {
            get { return _SealContent; }
            set { this._SealContent = value; }
        }
        private string _SealResult = String.Empty;
        /// <summary>
        /// 查封结果 [SealResult]
        /// </summary>
        [Field("SealResult", DbType.String, false)]
        public string SealResult
        {
            get { return _SealResult; }
            set { this._SealResult = value; }
        }
        private string _Government = String.Empty;
        /// <summary>
        /// 人民政府 [Government]
        /// </summary>
        [Field("Government", DbType.String, false)]
        public string Government
        {
            get { return _Government; }
            set { this._Government = value; }
        }
        private string _ManageDepartment = String.Empty;
        /// <summary>
        /// 管理部门 [ManageDepartment]
        /// </summary>
        [Field("ManageDepartment", DbType.String, false)]
        public string ManageDepartment
        {
            get { return _ManageDepartment; }
            set { this._ManageDepartment = value; }
        }
        private string _Court = String.Empty;
        /// <summary>
        /// 法院 [Court]
        /// </summary>
        [Field("Court", DbType.String, false)]
        public string Court
        {
            get { return _Court; }
            set { this._Court = value; }
        }
        private DateTime _HandleDate;
        /// <summary>
        ///  [HandleDate]
        /// </summary>
        [Field("HandleDate", DbType.DateTime, false)]
        public DateTime HandleDate
        {
            get { return _HandleDate; }
            set { this._HandleDate = value; }
        }
        private string _DocTitle = String.Empty;
        /// <summary>
        ///  [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
        }
        private string _ThingCheckNo = String.Empty;
        /// <summary>
        /// 安监管查（扣）文号 [ThingCheckNo]
        /// </summary>
        [Field("ThingCheckNo", DbType.String, false)]
        public string ThingCheckNo
        {
            get { return _ThingCheckNo; }
            set { this._ThingCheckNo = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        ///  [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
        }

        private byte _Status = 0;

        [Field("Status", DbType.Byte, false)]
        public byte Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _FilePath;

        [Field("FilePath", DbType.String, false)]
        public string FilePath
        {
            get { return _FilePath; }
            set { this._FilePath = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SealThingHandle()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SealThingHandle(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SealThingHandle).Where(DataBases.SealThingHandle.ID == ID);
            Init(section, DataBases.SealThingHandle);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SealThingHandle, DataBases.SealThingHandle.ID.Count()).Where(DataBases.SealThingHandle.ID == ID);
            Update(section, DataBases.SealThingHandle);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SealThingHandle).Where(DataBases.SealThingHandle.ID == ID);
            Remove(section, DataBases.SealThingHandle);
        }
    }
}

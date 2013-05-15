using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 责令限期整改指令书（30日内）
    /// </summary>
    [Table("OrderDeadlineReform", true)]
    public partial class OrderDeadlineReform : BaseEntity<OrderDeadlineReform>
    {
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
        private string _DocTitle = String.Empty;
        /// <summary>
        /// 文号 [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
        }
        private string _OrderCompany = String.Empty;
        /// <summary>
        /// 责令单位 [OrderCompany]
        /// </summary>
        [Field("OrderCompany", DbType.String, false)]
        public string OrderCompany
        {
            get { return _OrderCompany; }
            set { this._OrderCompany = value; }
        }
        private string _Matter = String.Empty;
        /// <summary>
        /// 存在问题 [Matter]
        /// </summary>
        [Field("Matter", DbType.String, false)]
        public string Matter
        {
            get { return _Matter; }
            set { this._Matter = value; }
        }
        private string _MatterCount = String.Empty;
        /// <summary>
        /// 问题数量 [MatterCount]
        /// </summary>
        [Field("MatterCount", DbType.String, false)]
        public string MatterCount
        {
            get { return _MatterCount; }
            set { this._MatterCount = value; }
        }
        private DateTime _ReformDate;
        /// <summary>
        /// 整改日期 [ReformDate]
        /// </summary>
        [Field("ReformDate", DbType.DateTime, false)]
        public DateTime ReformDate
        {
            get { return _ReformDate; }
            set { this._ReformDate = value; }
        }
        private string _GovArea = String.Empty;
        /// <summary>
        /// 人民政府地域 [GovArea]
        /// </summary>
        [Field("GovArea", DbType.String, false)]
        public string GovArea
        {
            get { return _GovArea; }
            set { this._GovArea = value; }
        }
        private string _ManageArea = String.Empty;
        /// <summary>
        /// 管理局地域 [ManageArea]
        /// </summary>
        [Field("ManageArea", DbType.String, false)]
        public string ManageArea
        {
            get { return _ManageArea; }
            set { this._ManageArea = value; }
        }
        private string _CourtArea = String.Empty;
        /// <summary>
        /// 人民法院 [CourtArea]
        /// </summary>
        [Field("CourtArea", DbType.String, false)]
        public string CourtArea
        {
            get { return _CourtArea; }
            set { this._CourtArea = value; }
        }
        private string _OfficerName1 = String.Empty;
        /// <summary>
        /// 执法人员1 [OfficerName1]
        /// </summary>
        [Field("OfficerName1", DbType.String, false)]
        public string OfficerName1
        {
            get { return _OfficerName1; }
            set { this._OfficerName1 = value; }
        }
        private string _CID1 = String.Empty;
        /// <summary>
        /// 证号 [CID1]
        /// </summary>
        [Field("CID1", DbType.String, false)]
        public string CID1
        {
            get { return _CID1; }
            set { this._CID1 = value; }
        }
        private string _OfficerName2 = String.Empty;
        /// <summary>
        /// 执法人员2 [OfficerName2]
        /// </summary>
        [Field("OfficerName2", DbType.String, false)]
        public string OfficerName2
        {
            get { return _OfficerName2; }
            set { this._OfficerName2 = value; }
        }
        private string _CID2 = String.Empty;
        /// <summary>
        /// 证号2 [CID2]
        /// </summary>
        [Field("CID2", DbType.String, false)]
        public string CID2
        {
            get { return _CID2; }
            set { this._CID2 = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        /// 文档中管理局全称 [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
        }
        private DateTime _DocDate;
        /// <summary>
        /// 文档日期 [DocDate]
        /// </summary>
        [Field("DocDate", DbType.DateTime, false)]
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { this._DocDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public OrderDeadlineReform()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal OrderDeadlineReform(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.OrderDeadlineReform).Where(DataBases.OrderDeadlineReform.ID == ID);
            Init(section, DataBases.OrderDeadlineReform);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.OrderDeadlineReform, DataBases.OrderDeadlineReform.ID.Count()).Where(DataBases.OrderDeadlineReform.ID == ID);
            Update(section, DataBases.OrderDeadlineReform);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.OrderDeadlineReform).Where(DataBases.OrderDeadlineReform.ID == ID);
            Remove(section, DataBases.OrderDeadlineReform);
        }
    }
}

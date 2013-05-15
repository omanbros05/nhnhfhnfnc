using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 整改复查意见书
    /// </summary>
    [Table("ReformReView", true)]
    public partial class ReformReView : BaseEntity<ReformReView>
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
        private string _ReviewCompany = String.Empty;
        /// <summary>
        /// 复查单位 [ReviewCompany]
        /// </summary>
        [Field("ReviewCompany", DbType.String, false)]
        public string ReviewCompany
        {
            get { return _ReviewCompany; }
            set { this._ReviewCompany = value; }
        }
        private DateTime _ReviewDate;
        /// <summary>
        /// 复查日期 [ReviewDate]
        /// </summary>
        [Field("ReviewDate", DbType.DateTime, false)]
        public DateTime ReviewDate
        {
            get { return _ReviewDate; }
            set { this._ReviewDate = value; }
        }
        private string _Decide = String.Empty;
        /// <summary>
        /// 决定 [Decide]
        /// </summary>
        [Field("Decide", DbType.String, false)]
        public string Decide
        {
            get { return _Decide; }
            set { this._Decide = value; }
        }
        private string _DocTitle2 = String.Empty;
        /// <summary>
        /// 决定安监管简写 [DocTitle2]
        /// </summary>
        [Field("DocTitle2", DbType.String, false)]
        public string DocTitle2
        {
            get { return _DocTitle2; }
            set { this._DocTitle2 = value; }
        }
        private string _Idea = String.Empty;
        /// <summary>
        /// 复查意见 [Idea]
        /// </summary>
        [Field("Idea", DbType.String, false)]
        public string Idea
        {
            get { return _Idea; }
            set { this._Idea = value; }
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
        /// 证号1 [CID1]
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
        /// 文档安监管全称 [DocManageArea]
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
        public ReformReView()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ReformReView(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ReformReView).Where(DataBases.ReformReView.ID == ID);
            Init(section, DataBases.ReformReView);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ReformReView, DataBases.ReformReView.ID.Count()).Where(DataBases.ReformReView.ID == ID);
            Update(section, DataBases.ReformReView);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ReformReView).Where(DataBases.ReformReView.ID == ID);
            Remove(section, DataBases.ReformReView);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 现场处理措施决定书（6个月内）
    /// </summary>
    [Table("SpotHandelDesisionSixtyDay", true)]
    public partial class SpotHandelDesisionSixtyDay : BaseEntity<SpotHandelDesisionSixtyDay>
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
        private string _DocTitle = String.Empty;
        /// <summary>
        /// 文件头 [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
        }
        private string _HandleComp = String.Empty;
        /// <summary>
        /// 处理单位 [HandleComp]
        /// </summary>
        [Field("HandleComp", DbType.String, false)]
        public string HandleComp
        {
            get { return _HandleComp; }
            set { this._HandleComp = value; }
        }
        private DateTime _CheckDate;
        /// <summary>
        /// 检查日期 [CheckDate]
        /// </summary>
        [Field("CheckDate", DbType.DateTime, false)]
        public DateTime CheckDate
        {
            get { return _CheckDate; }
            set { this._CheckDate = value; }
        }
        private string _Danger = String.Empty;
        /// <summary>
        /// 违规行为事故隐患 [Danger]
        /// </summary>
        [Field("Danger", DbType.String, false)]
        public string Danger
        {
            get { return _Danger; }
            set { this._Danger = value; }
        }
        private string _LegalBasis = String.Empty;
        /// <summary>
        /// 法律依据 [LegalBasis]
        /// </summary>
        [Field("LegalBasis", DbType.String, false)]
        public string LegalBasis
        {
            get { return _LegalBasis; }
            set { this._LegalBasis = value; }
        }
        private string _SitHandel = String.Empty;
        /// <summary>
        /// 现场处理决定 [SitHandel]
        /// </summary>
        [Field("SitHandel", DbType.String, false)]
        public string SitHandel
        {
            get { return _SitHandel; }
            set { this._SitHandel = value; }
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
        /// 人民法院地域 [CourtArea]
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
        /// 文档管理局全称 [DocManageArea]
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
        public SpotHandelDesisionSixtyDay()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SpotHandelDesisionSixtyDay(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotHandelDesisionSixtyDay).Where(DataBases.SpotHandelDesisionSixtyDay.ID == ID);
            Init(section, DataBases.SpotHandelDesisionSixtyDay);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotHandelDesisionSixtyDay, DataBases.SpotHandelDesisionSixtyDay.ID.Count()).Where(DataBases.SpotHandelDesisionSixtyDay.ID == ID);
            Update(section, DataBases.SpotHandelDesisionSixtyDay);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SpotHandelDesisionSixtyDay).Where(DataBases.SpotHandelDesisionSixtyDay.ID == ID);
            Remove(section, DataBases.SpotHandelDesisionSixtyDay);
        }
    }
}

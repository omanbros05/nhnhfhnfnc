using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 强制措施决定书（15日内）
    /// </summary>
    [Table("ForceMeasureDecision", true)]
    public partial class ForceMeasureDecision : BaseEntity<ForceMeasureDecision>
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
        /// 文档标题 [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
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
        private string _Matter = String.Empty;
        /// <summary>
        /// 存在的问题 [Matter]
        /// </summary>
        [Field("Matter", DbType.String, false)]
        public string Matter
        {
            get { return _Matter; }
            set { this._Matter = value; }
        }
        private string _Accord = String.Empty;
        /// <summary>
        /// 法律依据 [Accord]
        /// </summary>
        [Field("Accord", DbType.String, false)]
        public string Accord
        {
            get { return _Accord; }
            set { this._Accord = value; }
        }
        private string _EnforceMea = String.Empty;
        /// <summary>
        /// 强制措施内容 [EnforceMea]
        /// </summary>
        [Field("EnforceMea", DbType.String, false)]
        public string EnforceMea
        {
            get { return _EnforceMea; }
            set { this._EnforceMea = value; }
        }
        private string _GovArea = String.Empty;
        /// <summary>
        /// 人民政府区域 [GovArea]
        /// </summary>
        [Field("GovArea", DbType.String, false)]
        public string GovArea
        {
            get { return _GovArea; }
            set { this._GovArea = value; }
        }
        private string _ManageArea = String.Empty;
        /// <summary>
        /// 安监管理局 [ManageArea]
        /// </summary>
        [Field("ManageArea", DbType.String, false)]
        public string ManageArea
        {
            get { return _ManageArea; }
            set { this._ManageArea = value; }
        }
        private string _CourtArea = String.Empty;
        /// <summary>
        /// 人民法院区域 [CourtArea]
        /// </summary>
        [Field("CourtArea", DbType.String, false)]
        public string CourtArea
        {
            get { return _CourtArea; }
            set { this._CourtArea = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        /// 文档底部监督管理局 [DocManageArea]
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
        public ForceMeasureDecision()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ForceMeasureDecision(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecision).Where(DataBases.ForceMeasureDecision.ID == ID);
            Init(section, DataBases.ForceMeasureDecision);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecision, DataBases.ForceMeasureDecision.ID.Count()).Where(DataBases.ForceMeasureDecision.ID == ID);
            Update(section, DataBases.ForceMeasureDecision);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ForceMeasureDecision).Where(DataBases.ForceMeasureDecision.ID == ID);
            Remove(section, DataBases.ForceMeasureDecision);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 强制措施决定审批表（15日内）
    /// </summary>
    [Table("ForceMeasureDecisionApprove", true)]
    public partial class ForceMeasureDecisionApprove : BaseEntity<ForceMeasureDecisionApprove>
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
        private string _Party = String.Empty;
        /// <summary>
        /// 当事人 [Party]
        /// </summary>
        [Field("Party", DbType.String, false)]
        public string Party
        {
            get { return _Party; }
            set { this._Party = value; }
        }
        private string _PartyAddress = String.Empty;
        /// <summary>
        /// 当事人地址 [PartyAddress]
        /// </summary>
        [Field("PartyAddress", DbType.String, false)]
        public string PartyAddress
        {
            get { return _PartyAddress; }
            set { this._PartyAddress = value; }
        }
        private string _LegalRepre = String.Empty;
        /// <summary>
        /// 法定代表人 [LegalRepre]
        /// </summary>
        [Field("LegalRepre", DbType.String, false)]
        public string LegalRepre
        {
            get { return _LegalRepre; }
            set { this._LegalRepre = value; }
        }
        private string _Tel = String.Empty;
        /// <summary>
        /// 联系电话 [Tel]
        /// </summary>
        [Field("Tel", DbType.String, false)]
        public string Tel
        {
            get { return _Tel; }
            set { this._Tel = value; }
        }
        private string _Matter = String.Empty;
        /// <summary>
        /// 存在的主要问题 [Matter]
        /// </summary>
        [Field("Matter", DbType.String, false)]
        public string Matter
        {
            get { return _Matter; }
            set { this._Matter = value; }
        }
        private string _Accord = String.Empty;
        /// <summary>
        /// 建议措施及依据 [Accord]
        /// </summary>
        [Field("Accord", DbType.String, false)]
        public string Accord
        {
            get { return _Accord; }
            set { this._Accord = value; }
        }
        private string _Supervise = String.Empty;
        /// <summary>
        /// 监督检查人员 [Supervise]
        /// </summary>
        [Field("Supervise", DbType.String, false)]
        public string Supervise
        {
            get { return _Supervise; }
            set { this._Supervise = value; }
        }
        private DateTime _SuperviseDate;
        /// <summary>
        /// 监督检查人员填写日期 [SuperviseDate]
        /// </summary>
        [Field("SuperviseDate", DbType.DateTime, false)]
        public DateTime SuperviseDate
        {
            get { return _SuperviseDate; }
            set { this._SuperviseDate = value; }
        }
        private string _Undertake = String.Empty;
        /// <summary>
        /// 承办机构意见 [Undertake]
        /// </summary>
        [Field("Undertake", DbType.String, false)]
        public string Undertake
        {
            get { return _Undertake; }
            set { this._Undertake = value; }
        }
        private string _Principal = String.Empty;
        /// <summary>
        /// 负责人 [Principal]
        /// </summary>
        [Field("Principal", DbType.String, false)]
        public string Principal
        {
            get { return _Principal; }
            set { this._Principal = value; }
        }
        private DateTime _PrincipalDate;
        /// <summary>
        /// 负责人填写时间 [PrincipalDate]
        /// </summary>
        [Field("PrincipalDate", DbType.DateTime, false)]
        public DateTime PrincipalDate
        {
            get { return _PrincipalDate; }
            set { this._PrincipalDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ForceMeasureDecisionApprove()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ForceMeasureDecisionApprove(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecisionApprove).Where(DataBases.ForceMeasureDecisionApprove.ID == ID);
            Init(section, DataBases.ForceMeasureDecisionApprove);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecisionApprove, DataBases.ForceMeasureDecisionApprove.ID.Count()).Where(DataBases.ForceMeasureDecisionApprove.ID == ID);
            Update(section, DataBases.ForceMeasureDecisionApprove);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ForceMeasureDecisionApprove).Where(DataBases.ForceMeasureDecisionApprove.ID == ID);
            Remove(section, DataBases.ForceMeasureDecisionApprove);
        }
    }
}

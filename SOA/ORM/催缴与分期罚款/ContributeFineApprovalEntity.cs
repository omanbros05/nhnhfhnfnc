using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 延期（分期）缴纳罚款审批表
    /// </summary>
    [Table("ContributeFineApproval", true)]
    public partial class ContributeFineApproval : BaseEntity<ContributeFineApproval>
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
        private int _CaseID = -1;
        /// <summary>
        /// 案件ID [CaseID]
        /// </summary>
        [Field("CaseID", DbType.Int32, false)]
        public int CaseID
        {
            get { return _CaseID; }
            set { this._CaseID = value; }
        }
        private string _CaseName = String.Empty;
        /// <summary>
        /// 案件名称 [CaseName]
        /// </summary>
        [Field("CaseName", DbType.String, false)]
        public string CaseName
        {
            get { return _CaseName; }
            set { this._CaseName = value; }
        }
        private string _PunishInstrumentNo = String.Empty;
        /// <summary>
        /// 处罚决定书文号 [PunishInstrumentNo]
        /// </summary>
        [Field("PunishInstrumentNo", DbType.String, false)]
        public string PunishInstrumentNo
        {
            get { return _PunishInstrumentNo; }
            set { this._PunishInstrumentNo = value; }
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
        private string _Address = String.Empty;
        /// <summary>
        /// 地址 [Address]
        /// </summary>
        [Field("Address", DbType.String, false)]
        public string Address
        {
            get { return _Address; }
            set { this._Address = value; }
        }
        private string _LawFactPunish = String.Empty;
        /// <summary>
        /// 违法行为及处罚 [LawFactPunish]
        /// </summary>
        [Field("LawFactPunish", DbType.String, false)]
        public string LawFactPunish
        {
            get { return _LawFactPunish; }
            set { this._LawFactPunish = value; }
        }
        private string _ExtensionReason = String.Empty;
        /// <summary>
        /// 延期（分期）缴款理由 [ExtensionReason]
        /// </summary>
        [Field("ExtensionReason", DbType.String, false)]
        public string ExtensionReason
        {
            get { return _ExtensionReason; }
            set { this._ExtensionReason = value; }
        }
        private string _UserOpinion = String.Empty;
        /// <summary>
        /// 承办人意见 [UserOpinion]
        /// </summary>
        [Field("UserOpinion", DbType.String, false)]
        public string UserOpinion
        {
            get { return _UserOpinion; }
            set { this._UserOpinion = value; }
        }
        private DateTime _FormDate;
        /// <summary>
        /// 文书日期 [FormDate]
        /// </summary>
        [Field("FormDate", DbType.DateTime, false)]
        public DateTime FormDate
        {
            get { return _FormDate; }
            set { this._FormDate = value; }
        }
        private string _UserName1 = String.Empty;
        /// <summary>
        ///  [UserName1]
        /// </summary>
        [Field("UserName1", DbType.String, false)]
        public string UserName1
        {
            get { return _UserName1; }
            set { this._UserName1 = value; }
        }
        private string _UserName2 = String.Empty;
        /// <summary>
        ///  [UserName2]
        /// </summary>
        [Field("UserName2", DbType.String, false)]
        public string UserName2
        {
            get { return _UserName2; }
            set { this._UserName2 = value; }
        }

        private byte _Status = 0;

        [Field("Status", DbType.Byte, false)]
        public byte Status {
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
        public ContributeFineApproval()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ContributeFineApproval(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ContributeFineApproval).Where(DataBases.ContributeFineApproval.ID == ID);
            Init(section, DataBases.ContributeFineApproval);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ContributeFineApproval, DataBases.ContributeFineApproval.ID.Count()).Where(DataBases.ContributeFineApproval.ID == ID);
            Update(section, DataBases.ContributeFineApproval);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ContributeFineApproval).Where(DataBases.ContributeFineApproval.ID == ID);
            Remove(section, DataBases.ContributeFineApproval);
        }
    }
}

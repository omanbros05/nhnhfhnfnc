using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 案子审批表
    /// </summary>
    [Table("CaseClosedApproval", true)]
    public partial class CaseClosedApproval : BaseEntity<CaseClosedApproval>
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
        private int _CaseID =-1;
        /// <summary>
        /// 案子ID [CaseID]
        /// </summary>
        [Field("CaseID", DbType.Int32, false)]
        public int CaseID
        {
            get { return _CaseID; }
            set { this._CaseID = value; }
        }
        private string _CaseName = String.Empty;
        /// <summary>
        /// 案子名称 [CaseName]
        /// </summary>
        [Field("CaseName", DbType.String, false)]
        public string CaseName
        {
            get { return _CaseName; }
            set { this._CaseName = value; }
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
        private string _Legal = String.Empty;
        /// <summary>
        /// 法人 [Legal]
        /// </summary>
        [Field("Legal", DbType.String, false)]
        public string Legal
        {
            get { return _Legal; }
            set { this._Legal = value; }
        }

        private string _PeopleAddress = String.Empty;
        /// <summary>
        /// 联系地址 [PeopleAddress]
        /// </summary>
        [Field("PeopleAddress", DbType.String, false)]
        public string PeopleAddress
        {
            get { return _PeopleAddress; }
            set { this._PeopleAddress = value; }
        }

        private string _PeoplePhone = String.Empty;
        /// <summary>
        /// 联系电话 [PeoplePhone]
        /// </summary>
        [Field("PeoplePhone", DbType.String, false)]
        public string PeoplePhone
        {
            get { return _PeoplePhone; }
            set { this._PeoplePhone = value; }
        }

        private int _CaseSourceID;
        /// <summary>
        /// 案子来源 [CaseSourceID]
        /// </summary>
        [Field("CaseSourceID", DbType.Int32, false)]
        public int CaseSourceID
        {
            get { return _CaseSourceID; }
            set { this._CaseSourceID = value; }
        }
        private string _PunishInstrumentNo = String.Empty;
        /// <summary>
        /// 处罚文书号 [PunishInstrumentNo]
        /// </summary>
        [Field("PunishInstrumentNo", DbType.String, false)]
        public string PunishInstrumentNo
        {
            get { return _PunishInstrumentNo; }
            set { this._PunishInstrumentNo = value; }
        }
        private DateTime _CaseStartDate;
        /// <summary>
        /// 立案日期 [CaseStartDate]
        /// </summary>
        [Field("CaseStartDate", DbType.DateTime, false)]
        public DateTime CaseStartDate
        {
            get { return _CaseStartDate; }
            set { this._CaseStartDate = value; }
        }
        private DateTime _CaseEndDate;
        /// <summary>
        /// 申请结案日期 [CaseEndDate]
        /// </summary>
        [Field("CaseEndDate", DbType.DateTime, false)]
        public DateTime CaseEndDate
        {
            get { return _CaseEndDate; }
            set { this._CaseEndDate = value; }
        }
        private DateTime _PunishDate;
        /// <summary>
        /// 处罚日期 [PunishDate]
        /// </summary>
        [Field("PunishDate", DbType.DateTime, false)]
        public DateTime PunishDate
        {
            get { return _PunishDate; }
            set { this._PunishDate = value; }
        }
        private int _UserID1 =-1;
        /// <summary>
        /// 承办人1 [UserID1]
        /// </summary>
        [Field("UserID1", DbType.Int32, false)]
        public int UserID1
        {
            get { return _UserID1; }
            set { this._UserID1 = value; }
        }
        private int _UserID2 =-1;
        /// <summary>
        /// 承办人2 [UserID2]
        /// </summary>
        [Field("UserID2", DbType.Int32, false)]
        public int UserID2
        {
            get { return _UserID2; }
            set { this._UserID2 = value; }
        }
        private string _PunishContent = String.Empty;
        /// <summary>
        /// 处罚内容 [PunishContent]
        /// </summary>
        [Field("PunishContent", DbType.String, false)]
        public string PunishContent
        {
            get { return _PunishContent; }
            set { this._PunishContent = value; }
        }
        private string _ExecutionResult = String.Empty;
        /// <summary>
        /// 执行结果 [ExecutionResult]
        /// </summary>
        [Field("ExecutionResult", DbType.String, false)]
        public string ExecutionResult
        {
            get { return _ExecutionResult; }
            set { this._ExecutionResult = value; }
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
        private string _CaseSourceName = String.Empty;
        /// <summary>
        /// 案子来源 [CaseSourceName]
        /// </summary>
        [Field("CaseSourceName", DbType.String, false)]
        public string CaseSourceName
        {
            get { return _CaseSourceName; }
            set { this._CaseSourceName = value; }
        }
        private string _UserName1 = String.Empty;
        /// <summary>
        /// 承办人1 [UserName1]
        /// </summary>
        [Field("UserName1", DbType.String, false)]
        public string UserName1
        {
            get { return _UserName1; }
            set { this._UserName1 = value; }
        }
        private string _UserName2 = String.Empty;
        /// <summary>
        /// 承办人2 [UserName2]
        /// </summary>
        [Field("UserName2", DbType.String, false)]
        public string UserName2
        {
            get { return _UserName2; }
            set { this._UserName2 = value; }
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
        public CaseClosedApproval()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CaseClosedApproval(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseClosedApproval).Where(DataBases.CaseClosedApproval.ID == ID);
            Init(section, DataBases.CaseClosedApproval);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseClosedApproval, DataBases.CaseClosedApproval.ID.Count()).Where(DataBases.CaseClosedApproval.ID == ID);
            Update(section, DataBases.CaseClosedApproval);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CaseClosedApproval).Where(DataBases.CaseClosedApproval.ID == ID);
            Remove(section, DataBases.CaseClosedApproval);
        }
    }
}

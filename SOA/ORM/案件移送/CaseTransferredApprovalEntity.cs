using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 案件移送审批表
    /// </summary>
    [Table("CaseTransferredApproval", true)]
    public partial class CaseTransferredApproval : BaseEntity<CaseTransferredApproval>
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
        private string _ReceiverUnit = String.Empty;
        /// <summary>
        /// 受移送机关 [ReceiverUnit]
        /// </summary>
        [Field("ReceiverUnit", DbType.String, false)]
        public string ReceiverUnit
        {
            get { return _ReceiverUnit; }
            set { this._ReceiverUnit = value; }
        }
        private string _CaseInfo = String.Empty;
        /// <summary>
        /// 案情简介 [CaseInfo]
        /// </summary>
        [Field("CaseInfo", DbType.String, false)]
        public string CaseInfo
        {
            get { return _CaseInfo; }
            set { this._CaseInfo = value; }
        }
        private string _TransferredReason = String.Empty;
        /// <summary>
        /// 移送理由 [TransferredReason]
        /// </summary>
        [Field("TransferredReason", DbType.String, false)]
        public string TransferredReason
        {
            get { return _TransferredReason; }
            set { this._TransferredReason = value; }
        }
        private int _UserID1;
        /// <summary>
        /// 承办人1 [UserID1]
        /// </summary>
        [Field("UserID1", DbType.Int32, false)]
        public int UserID1
        {
            get { return _UserID1; }
            set { this._UserID1 = value; }
        }
        private int _UserID2;
        /// <summary>
        /// 承办人2 [UserID2]
        /// </summary>
        [Field("UserID2", DbType.Int32, false)]
        public int UserID2
        {
            get { return _UserID2; }
            set { this._UserID2 = value; }
        }
        private string _UserReason = String.Empty;
        /// <summary>
        /// 承办人意见 [UserReason]
        /// </summary>
        [Field("UserReason", DbType.String, false)]
        public string UserReason
        {
            get { return _UserReason; }
            set { this._UserReason = value; }
        }
        private DateTime _HandleDate;
        /// <summary>
        /// 办理时间 [HandleDate]
        /// </summary>
        [Field("HandleDate", DbType.DateTime, false)]
        public DateTime HandleDate
        {
            get { return _HandleDate; }
            set { this._HandleDate = value; }
        }
        private string _Party = String.Empty;
        /// <summary>
        ///  [Party]
        /// </summary>
        [Field("Party", DbType.String, false)]
        public string Party
        {
            get { return _Party; }
            set { this._Party = value; }
        }
        private string _Address = String.Empty;
        /// <summary>
        ///  [Address]
        /// </summary>
        [Field("Address", DbType.String, false)]
        public string Address
        {
            get { return _Address; }
            set { this._Address = value; }
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
        public CaseTransferredApproval()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CaseTransferredApproval(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseTransferredApproval).Where(DataBases.CaseTransferredApproval.ID == ID);
            Init(section, DataBases.CaseTransferredApproval);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseTransferredApproval, DataBases.CaseTransferredApproval.ID.Count()).Where(DataBases.CaseTransferredApproval.ID == ID);
            Update(section, DataBases.CaseTransferredApproval);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CaseTransferredApproval).Where(DataBases.CaseTransferredApproval.ID == ID);
            Remove(section, DataBases.CaseTransferredApproval);
        }
    }
}

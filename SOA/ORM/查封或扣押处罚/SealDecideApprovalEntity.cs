using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 查封(扣押)决定审批表
    /// </summary>
    [Table("SealDecideApproval", true)]
    public partial class SealDecideApproval : BaseEntity<SealDecideApproval>
    {
        private int _ID;
        /// <summary>
        /// 主键ID [ID]
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
        private string _CaseStatus = String.Empty;
        /// <summary>
        /// 案件基本情况 [CaseStatus]
        /// </summary>
        [Field("CaseStatus", DbType.String, false)]
        public string CaseStatus
        {
            get { return _CaseStatus; }
            set { this._CaseStatus = value; }
        }
        private string _PartyBaseInfo = String.Empty;
        /// <summary>
        /// 当事人及基本情况 [PartyBaseInfo]
        /// </summary>
        [Field("PartyBaseInfo", DbType.String, false)]
        public string PartyBaseInfo
        {
            get { return _PartyBaseInfo; }
            set { this._PartyBaseInfo = value; }
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
        private string _SealReason = String.Empty;
        /// <summary>
        /// 查封理由 [SealReason]
        /// </summary>
        [Field("SealReason", DbType.String, false)]
        public string SealReason
        {
            get { return _SealReason; }
            set { this._SealReason = value; }
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
        private int _ThingID =-1;
        /// <summary>
        /// 物品总表的ID [ThingID]
        /// </summary>
        [Field("ThingID", DbType.Int32, false)]
        public int ThingID
        {
            get { return _ThingID; }
            set { this._ThingID = value; }
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
        public SealDecideApproval()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SealDecideApproval(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SealDecideApproval).Where(DataBases.SealDecideApproval.ID == ID);
            Init(section, DataBases.SealDecideApproval);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SealDecideApproval, DataBases.SealDecideApproval.ID.Count()).Where(DataBases.SealDecideApproval.ID == ID);
            Update(section, DataBases.SealDecideApproval);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SealDecideApproval).Where(DataBases.SealDecideApproval.ID == ID);
            Remove(section, DataBases.SealDecideApproval);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 复查意见审批表
    /// </summary>
    [Table("ReviewOptionApprove", true)]
    public partial class ReviewOptionApprove : BaseEntity<ReviewOptionApprove>
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
        private string _RawDecisionID = String.Empty;
        /// <summary>
        /// 原决定书编号 [RawDecisionID]
        /// </summary>
        [Field("RawDecisionID", DbType.String, false)]
        public string RawDecisionID
        {
            get { return _RawDecisionID; }
            set { this._RawDecisionID = value; }
        }
        private DateTime _LeaveTime;
        /// <summary>
        /// 出发时间 [LeaveTime]
        /// </summary>
        [Field("LeaveTime", DbType.DateTime, false)]
        public DateTime LeaveTime
        {
            get { return _LeaveTime; }
            set { this._LeaveTime = value; }
        }
        private DateTime _ReceiveTime;
        /// <summary>
        /// 复查验收报告收到时间 [ReceiveTime]
        /// </summary>
        [Field("ReceiveTime", DbType.DateTime, false)]
        public DateTime ReceiveTime
        {
            get { return _ReceiveTime; }
            set { this._ReceiveTime = value; }
        }
        private DateTime _ReviewTime;
        /// <summary>
        /// 复查时间 [ReviewTime]
        /// </summary>
        [Field("ReviewTime", DbType.DateTime, false)]
        public DateTime ReviewTime
        {
            get { return _ReviewTime; }
            set { this._ReviewTime = value; }
        }
        private string _MajorProblems = String.Empty;
        /// <summary>
        /// 要求整改的主要问题 [MajorProblems]
        /// </summary>
        [Field("MajorProblems", DbType.String, false)]
        public string MajorProblems
        {
            get { return _MajorProblems; }
            set { this._MajorProblems = value; }
        }
        private string _ReviewCondition = String.Empty;
        /// <summary>
        /// 复查情况及意见 [ReviewCondition]
        /// </summary>
        [Field("ReviewCondition", DbType.String, false)]
        public string ReviewCondition
        {
            get { return _ReviewCondition; }
            set { this._ReviewCondition = value; }
        }
        private string _Reviewer = String.Empty;
        /// <summary>
        /// 复查人员 [Reviewer]
        /// </summary>
        [Field("Reviewer", DbType.String, false)]
        public string Reviewer
        {
            get { return _Reviewer; }
            set { this._Reviewer = value; }
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
        /// 负责人填写日期 [PrincipalDate]
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
        public ReviewOptionApprove()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ReviewOptionApprove(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ReviewOptionApprove).Where(DataBases.ReviewOptionApprove.ID == ID);
            Init(section, DataBases.ReviewOptionApprove);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ReviewOptionApprove, DataBases.ReviewOptionApprove.ID.Count()).Where(DataBases.ReviewOptionApprove.ID == ID);
            Update(section, DataBases.ReviewOptionApprove);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ReviewOptionApprove).Where(DataBases.ReviewOptionApprove.ID == ID);
            Remove(section, DataBases.ReviewOptionApprove);
        }
    }
}

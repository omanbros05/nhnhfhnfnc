using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 查封（扣押）物品处理决定审批表
    /// </summary>
    [Table("SealThingHandleApproval", true)]
    public partial class SealThingHandleApproval : BaseEntity<SealThingHandleApproval>
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
        private string _CaseSurveyInfo = String.Empty;
        /// <summary>
        /// 案件调查情况 [CaseSurveyInfo]
        /// </summary>
        [Field("CaseSurveyInfo", DbType.String, false)]
        public string CaseSurveyInfo
        {
            get { return _CaseSurveyInfo; }
            set { this._CaseSurveyInfo = value; }
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
        private string _SealDecideNo = String.Empty;
        /// <summary>
        ///  [SealDecideNo]
        /// </summary>
        [Field("SealDecideNo", DbType.String, false)]
        public string SealDecideNo
        {
            get { return _SealDecideNo; }
            set { this._SealDecideNo = value; }
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
        public SealThingHandleApproval()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SealThingHandleApproval(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SealThingHandleApproval).Where(DataBases.SealThingHandleApproval.ID == ID);
            Init(section, DataBases.SealThingHandleApproval);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SealThingHandleApproval, DataBases.SealThingHandleApproval.ID.Count()).Where(DataBases.SealThingHandleApproval.ID == ID);
            Update(section, DataBases.SealThingHandleApproval);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SealThingHandleApproval).Where(DataBases.SealThingHandleApproval.ID == ID);
            Remove(section, DataBases.SealThingHandleApproval);
        }
    }
}

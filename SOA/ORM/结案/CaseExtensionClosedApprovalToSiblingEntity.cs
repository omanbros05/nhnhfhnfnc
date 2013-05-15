using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 案件延期办结审批表(本级)
    /// </summary>
    [Table("CaseExtensionClosedApprovalToSibling", true)]
    public partial class CaseExtensionClosedApprovalToSibling : BaseEntity<CaseExtensionClosedApprovalToSibling>
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
        private int _CaseSourceID = -1;
        /// <summary>
        /// 案子来源 [CaseSourceID]
        /// </summary>
        [Field("CaseSourceID", DbType.Int32, false)]
        public int CaseSourceID
        {
            get { return _CaseSourceID; }
            set { this._CaseSourceID = value; }
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
        private string _ExtensionApproval = String.Empty;
        /// <summary>
        /// 案子延期办结申请理由 [ExtensionApproval]
        /// </summary>
        [Field("ExtensionApproval", DbType.String, false)]
        public string ExtensionApproval
        {
            get { return _ExtensionApproval; }
            set { this._ExtensionApproval = value; }
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
        private int _UserID1;
        /// <summary>
        ///  [UserID1]
        /// </summary>
        [Field("UserID1", DbType.Int32, false)]
        public int UserID1
        {
            get { return _UserID1; }
            set { this._UserID1 = value; }
        }
        private int _UserID2;
        /// <summary>
        ///  [UserID2]
        /// </summary>
        [Field("UserID2", DbType.Int32, false)]
        public int UserID2
        {
            get { return _UserID2; }
            set { this._UserID2 = value; }
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
        public CaseExtensionClosedApprovalToSibling()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CaseExtensionClosedApprovalToSibling(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseExtensionClosedApprovalToSibling).Where(DataBases.CaseExtensionClosedApprovalToSibling.ID == ID);
            Init(section, DataBases.CaseExtensionClosedApprovalToSibling);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseExtensionClosedApprovalToSibling, DataBases.CaseExtensionClosedApprovalToSibling.ID.Count()).Where(DataBases.CaseExtensionClosedApprovalToSibling.ID == ID);
            Update(section, DataBases.CaseExtensionClosedApprovalToSibling);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CaseExtensionClosedApprovalToSibling).Where(DataBases.CaseExtensionClosedApprovalToSibling.ID == ID);
            Remove(section, DataBases.CaseExtensionClosedApprovalToSibling);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 案件移送表
    /// </summary>
    [Table("CaseTransferred", true)]
    public partial class CaseTransferred : BaseEntity<CaseTransferred>
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
        private string _UnitName = String.Empty;
        /// <summary>
        /// 接收机关名称 [UnitName]
        /// </summary>
        [Field("UnitName", DbType.String, false)]
        public string UnitName
        {
            get { return _UnitName; }
            set { this._UnitName = value; }
        }
        private DateTime _TransferredDate;
        /// <summary>
        /// 移送日期 [TransferredDate]
        /// </summary>
        [Field("TransferredDate", DbType.DateTime, false)]
        public DateTime TransferredDate
        {
            get { return _TransferredDate; }
            set { this._TransferredDate = value; }
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
        private string _TransferredReason = String.Empty;
        /// <summary>
        /// 移送说明 [TransferredReason]
        /// </summary>
        [Field("TransferredReason", DbType.String, false)]
        public string TransferredReason
        {
            get { return _TransferredReason; }
            set { this._TransferredReason = value; }
        }
        private string _TransferredLaw = String.Empty;
        /// <summary>
        /// 移送条例 [TransferredLaw]
        /// </summary>
        [Field("TransferredLaw", DbType.String, false)]
        public string TransferredLaw
        {
            get { return _TransferredLaw; }
            set { this._TransferredLaw = value; }
        }
        private string _CaseMaterial = String.Empty;
        /// <summary>
        /// 案件材料 [CaseMaterial]
        /// </summary>
        [Field("CaseMaterial", DbType.String, false)]
        public string CaseMaterial
        {
            get { return _CaseMaterial; }
            set { this._CaseMaterial = value; }
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
        private string _DocManageArea = String.Empty;
        /// <summary>
        ///  [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
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
        public CaseTransferred()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CaseTransferred(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseTransferred).Where(DataBases.CaseTransferred.ID == ID);
            Init(section, DataBases.CaseTransferred);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseTransferred, DataBases.CaseTransferred.ID.Count()).Where(DataBases.CaseTransferred.ID == ID);
            Update(section, DataBases.CaseTransferred);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CaseTransferred).Where(DataBases.CaseTransferred.ID == ID);
            Remove(section, DataBases.CaseTransferred);
        }
    }
}

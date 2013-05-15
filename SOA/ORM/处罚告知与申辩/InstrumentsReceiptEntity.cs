using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 实体类
    /// </summary>
    [Table("InstrumentsReceipt", true)]
    public partial class InstrumentsReceipt : BaseEntity<InstrumentsReceipt>
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
        private int _CaseID;
        /// <summary>
        ///  [CaseID]
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
        /// 受送达单位（个人） [ReceiverUnit]
        /// </summary>
        [Field("ReceiverUnit", DbType.String, false)]
        public string ReceiverUnit
        {
            get { return _ReceiverUnit; }
            set { this._ReceiverUnit = value; }
        }
        private string _InstrumentsNameSymbol = String.Empty;
        /// <summary>
        /// 送达文书名称、文号 [InstrumentsNameSymbol]
        /// </summary>
        [Field("InstrumentsNameSymbol", DbType.String, false)]
        public string InstrumentsNameSymbol
        {
            get { return _InstrumentsNameSymbol; }
            set { this._InstrumentsNameSymbol = value; }
        }
        private DateTime _ServiceDate;
        /// <summary>
        /// 送达日期 [ServiceDate]
        /// </summary>
        [Field("ServiceDate", DbType.DateTime, false)]
        public DateTime ServiceDate
        {
            get { return _ServiceDate; }
            set { this._ServiceDate = value; }
        }
        private string _ServiceLocation = String.Empty;
        /// <summary>
        /// 送达地点 [ServiceLocation]
        /// </summary>
        [Field("ServiceLocation", DbType.String, false)]
        public string ServiceLocation
        {
            get { return _ServiceLocation; }
            set { this._ServiceLocation = value; }
        }
        private string _ServiceMode = String.Empty;
        /// <summary>
        /// 送达方式 [ServiceMode]
        /// </summary>
        [Field("ServiceMode", DbType.String, false)]
        public string ServiceMode
        {
            get { return _ServiceMode; }
            set { this._ServiceMode = value; }
        }
        private string _ServiceUser = String.Empty;
        /// <summary>
        /// 送达人 [ServiceUser]
        /// </summary>
        [Field("ServiceUser", DbType.String, false)]
        public string ServiceUser
        {
            get { return _ServiceUser; }
            set { this._ServiceUser = value; }
        }
        private string _Area = String.Empty;
        /// <summary>
        /// 执法局所在区域 [Area]
        /// </summary>
        [Field("Area", DbType.String, false)]
        public string Area
        {
            get { return _Area; }
            set { this._Area = value; }
        }
        private string _Note = String.Empty;
        /// <summary>
        /// 备注 [Note]
        /// </summary>
        [Field("Note", DbType.String, false)]
        public string Note
        {
            get { return _Note; }
            set { this._Note = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public InstrumentsReceipt()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal InstrumentsReceipt(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsReceipt).Where(DataBases.InstrumentsReceipt.ID == ID);
            Init(section, DataBases.InstrumentsReceipt);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.InstrumentsReceipt, DataBases.InstrumentsReceipt.ID.Count()).Where(DataBases.InstrumentsReceipt.ID == ID);
            Update(section, DataBases.InstrumentsReceipt);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.InstrumentsReceipt).Where(DataBases.InstrumentsReceipt.ID == ID);
            Remove(section, DataBases.InstrumentsReceipt);
        }
    }
}

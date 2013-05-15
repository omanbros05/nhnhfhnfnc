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
    [Table("CompanyDangerChemicals", true)]
    public partial class CompanyDangerChemicals : BaseEntity<CompanyDangerChemicals>
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
        private int _CompanyID;
        /// <summary>
        ///  [CompanyID]
        /// </summary>
        [Field("CompanyID", DbType.Int32, false)]
        public int CompanyID
        {
            get { return _CompanyID; }
            set { this._CompanyID = value; }
        }
        private string _Certificate = String.Empty;
        /// <summary>
        /// 证书 [Certificate]
        /// </summary>
        [Field("Certificate", DbType.String, false)]
        public string Certificate
        {
            get { return _Certificate; }
            set { this._Certificate = value; }
        }
        private string _WarehousAddress = String.Empty;
        /// <summary>
        /// 仓储地址 [WarehousAddress]
        /// </summary>
        [Field("WarehousAddress", DbType.String, false)]
        public string WarehousAddress
        {
            get { return _WarehousAddress; }
            set { this._WarehousAddress = value; }
        }
        private string _BusinessScope = String.Empty;
        /// <summary>
        /// 经营范围 [BusinessScope]
        /// </summary>
        [Field("BusinessScope", DbType.String, false)]
        public string BusinessScope
        {
            get { return _BusinessScope; }
            set { this._BusinessScope = value; }
        }
        private string _EconomicTypes = String.Empty;
        /// <summary>
        /// 经济类型 [EconomicTypes]
        /// </summary>
        [Field("EconomicTypes", DbType.String, false)]
        public string EconomicTypes
        {
            get { return _EconomicTypes; }
            set { this._EconomicTypes = value; }
        }
        private string _BusinessMode = String.Empty;
        /// <summary>
        /// 经营方式 [BusinessMode]
        /// </summary>
        [Field("BusinessMode", DbType.String, false)]
        public string BusinessMode
        {
            get { return _BusinessMode; }
            set { this._BusinessMode = value; }
        }
        private DateTime _ValidStartDate;
        /// <summary>
        /// 有效期 [ValidStartDate]
        /// </summary>
        [Field("ValidStartDate", DbType.DateTime, false)]
        public DateTime ValidStartDate
        {
            get { return _ValidStartDate; }
            set { this._ValidStartDate = value; }
        }
        private DateTime _ValidEndDate;
        /// <summary>
        ///  [ValidEndDate]
        /// </summary>
        [Field("ValidEndDate", DbType.DateTime, false)]
        public DateTime ValidEndDate
        {
            get { return _ValidEndDate; }
            set { this._ValidEndDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CompanyDangerChemicals()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyDangerChemicals(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyDangerChemicals).Where(DataBases.CompanyDangerChemicals.ID == ID);
            Init(section, DataBases.CompanyDangerChemicals);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyDangerChemicals, DataBases.CompanyDangerChemicals.ID.Count()).Where(DataBases.CompanyDangerChemicals.ID == ID);
            Update(section, DataBases.CompanyDangerChemicals);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyDangerChemicals).Where(DataBases.CompanyDangerChemicals.ID == ID);
            Remove(section, DataBases.CompanyDangerChemicals);
        }
    }
}

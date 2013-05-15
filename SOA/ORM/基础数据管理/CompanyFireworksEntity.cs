using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 烟花爆竹零售详情表
    /// </summary>
    [Table("CompanyFireworks", true)]
    public partial class CompanyFireworks : BaseEntity<CompanyFireworks>
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
        private string _PermitCertificateNo = String.Empty;
        /// <summary>
        /// 许可证书号 [PermitCertificateNo]
        /// </summary>
        [Field("PermitCertificateNo", DbType.String, false)]
        public string PermitCertificateNo
        {
            get { return _PermitCertificateNo; }
            set { this._PermitCertificateNo = value; }
        }
        private string _PermitBusinessScope = String.Empty;
        /// <summary>
        /// 许可经营范围 [PermitBusinessScope]
        /// </summary>
        [Field("PermitBusinessScope", DbType.String, false)]
        public string PermitBusinessScope
        {
            get { return _PermitBusinessScope; }
            set { this._PermitBusinessScope = value; }
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
        public CompanyFireworks()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyFireworks(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyFireworks).Where(DataBases.CompanyFireworks.ID == ID);
            Init(section, DataBases.CompanyFireworks);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyFireworks, DataBases.CompanyFireworks.ID.Count()).Where(DataBases.CompanyFireworks.ID == ID);
            Update(section, DataBases.CompanyFireworks);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyFireworks).Where(DataBases.CompanyFireworks.ID == ID);
            Remove(section, DataBases.CompanyFireworks);
        }
    }
}

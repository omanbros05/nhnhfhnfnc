using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 剧毒化学品使用详情表
    /// </summary>
    [Table("CompanyHighlyToxicChemicals", true)]
    public partial class CompanyHighlyToxicChemicals : BaseEntity<CompanyHighlyToxicChemicals>
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
        private string _MainProducts = String.Empty;
        /// <summary>
        /// 主要产品 [MainProducts]
        /// </summary>
        [Field("MainProducts", DbType.String, false)]
        public string MainProducts
        {
            get { return _MainProducts; }
            set { this._MainProducts = value; }
        }
        private string _Registration = String.Empty;
        /// <summary>
        /// 登记备案品种、用量 [Registration]
        /// </summary>
        [Field("Registration", DbType.String, false)]
        public string Registration
        {
            get { return _Registration; }
            set { this._Registration = value; }
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
        public CompanyHighlyToxicChemicals()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyHighlyToxicChemicals(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyHighlyToxicChemicals).Where(DataBases.CompanyHighlyToxicChemicals.ID == ID);
            Init(section, DataBases.CompanyHighlyToxicChemicals);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyHighlyToxicChemicals, DataBases.CompanyHighlyToxicChemicals.ID.Count()).Where(DataBases.CompanyHighlyToxicChemicals.ID == ID);
            Update(section, DataBases.CompanyHighlyToxicChemicals);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyHighlyToxicChemicals).Where(DataBases.CompanyHighlyToxicChemicals.ID == ID);
            Remove(section, DataBases.CompanyHighlyToxicChemicals);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 危险化学品生产（含溶剂回收）、储存详情表
    /// </summary>
    [Table("CompanyDangerChemicalsProduce", true)]
    public partial class CompanyDangerChemicalsProduce : BaseEntity<CompanyDangerChemicalsProduce>
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
        private string _PermitRange = String.Empty;
        /// <summary>
        /// 许可范围 [PermitRange]
        /// </summary>
        [Field("PermitRange", DbType.String, false)]
        public string PermitRange
        {
            get { return _PermitRange; }
            set { this._PermitRange = value; }
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
        public CompanyDangerChemicalsProduce()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CompanyDangerChemicalsProduce(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyDangerChemicalsProduce).Where(DataBases.CompanyDangerChemicalsProduce.ID == ID);
            Init(section, DataBases.CompanyDangerChemicalsProduce);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CompanyDangerChemicalsProduce, DataBases.CompanyDangerChemicalsProduce.ID.Count()).Where(DataBases.CompanyDangerChemicalsProduce.ID == ID);
            Update(section, DataBases.CompanyDangerChemicalsProduce);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CompanyDangerChemicalsProduce).Where(DataBases.CompanyDangerChemicalsProduce.ID == ID);
            Remove(section, DataBases.CompanyDangerChemicalsProduce);
        }
    }
}

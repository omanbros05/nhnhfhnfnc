using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 剧毒化学品目录
    /// </summary>
    [Table("ChemicalsHighlyToxic", true)]
    public partial class ChemicalsHighlyToxic : BaseEntity<ChemicalsHighlyToxic>
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
        private string _ChemicalName = String.Empty;
        /// <summary>
        /// 化学名 [ChemicalName]
        /// </summary>
        [Field("ChemicalName", DbType.String, false)]
        public string ChemicalName
        {
            get { return _ChemicalName; }
            set { this._ChemicalName = value; }
        }
        private string _ChemicalAlias = String.Empty;
        /// <summary>
        /// 别名 [ChemicalAlias]
        /// </summary>
        [Field("ChemicalAlias", DbType.String, false)]
        public string ChemicalAlias
        {
            get { return _ChemicalAlias; }
            set { this._ChemicalAlias = value; }
        }
        private string _ChemicalNameEn = String.Empty;
        /// <summary>
        /// 化学名 [ChemicalNameEn]
        /// </summary>
        [Field("ChemicalNameEn", DbType.String, false)]
        public string ChemicalNameEn
        {
            get { return _ChemicalNameEn; }
            set { this._ChemicalNameEn = value; }
        }
        private string _ChemicalAliasEn = String.Empty;
        /// <summary>
        /// 别名 [ChemicalAliasEn]
        /// </summary>
        [Field("ChemicalAliasEn", DbType.String, false)]
        public string ChemicalAliasEn
        {
            get { return _ChemicalAliasEn; }
            set { this._ChemicalAliasEn = value; }
        }
        private string _Formula = String.Empty;
        /// <summary>
        /// 分子式 [Formula]
        /// </summary>
        [Field("Formula", DbType.String, false)]
        public string Formula
        {
            get { return _Formula; }
            set { this._Formula = value; }
        }
        private string _CAS = String.Empty;
        /// <summary>
        ///  [CAS]
        /// </summary>
        [Field("CAS", DbType.String, false)]
        public string CAS
        {
            get { return _CAS; }
            set { this._CAS = value; }
        }
        private string _UN = String.Empty;
        /// <summary>
        ///  [UN]
        /// </summary>
        [Field("UN", DbType.String, false)]
        public string UN
        {
            get { return _UN; }
            set { this._UN = value; }
        }
        private string _LimitedRange = String.Empty;
        /// <summary>
        /// 受限范围 [LimitedRange]
        /// </summary>
        [Field("LimitedRange", DbType.String, false)]
        public string LimitedRange
        {
            get { return _LimitedRange; }
            set { this._LimitedRange = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ChemicalsHighlyToxic()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ChemicalsHighlyToxic(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ChemicalsHighlyToxic).Where(DataBases.ChemicalsHighlyToxic.ID == ID);
            Init(section, DataBases.ChemicalsHighlyToxic);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ChemicalsHighlyToxic, DataBases.ChemicalsHighlyToxic.ID.Count()).Where(DataBases.ChemicalsHighlyToxic.ID == ID);
            Update(section, DataBases.ChemicalsHighlyToxic);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ChemicalsHighlyToxic).Where(DataBases.ChemicalsHighlyToxic.ID == ID);
            Remove(section, DataBases.ChemicalsHighlyToxic);
        }
    }
}

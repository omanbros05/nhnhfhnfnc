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
    [Table("ChemicalsList", true)]
    public partial class ChemicalsList : BaseEntity<ChemicalsList>
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
        private int _ChemicalsType = -1;
        /// <summary>
        /// 危化品类型 [ChemicalsType]
        /// </summary>
        [Field("ChemicalsType", DbType.Int32, false)]
        public int ChemicalsType
        {
            get { return _ChemicalsType; }
            set { this._ChemicalsType = value; }
        }
        private string _ChemicalsNumber = String.Empty;
        /// <summary>
        /// 编号 [ChemicalsNumber]
        /// </summary>
        [Field("ChemicalsNumber", DbType.String, false)]
        public string ChemicalsNumber
        {
            get { return _ChemicalsNumber; }
            set { this._ChemicalsNumber = value; }
        }
        private string _ChemicalsName = String.Empty;
        /// <summary>
        /// 名称 [ChemicalsName]
        /// </summary>
        [Field("ChemicalsName", DbType.String, false)]
        public string ChemicalsName
        {
            get { return _ChemicalsName; }
            set { this._ChemicalsName = value; }
        }
        private string _ChemicalsAlias = String.Empty;
        /// <summary>
        /// 别名 [ChemicalsAlias]
        /// </summary>
        [Field("ChemicalsAlias", DbType.String, false)]
        public string ChemicalsAlias
        {
            get { return _ChemicalsAlias; }
            set { this._ChemicalsAlias = value; }
        }
        private string _ChemicalsUN = String.Empty;
        /// <summary>
        /// UN号 [ChemicalsUN]
        /// </summary>
        [Field("ChemicalsUN", DbType.String, false)]
        public string ChemicalsUN
        {
            get { return _ChemicalsUN; }
            set { this._ChemicalsUN = value; }
        }
        private int _ChemicalsChildType = -1;
        /// <summary>
        ///  子类[ChemicalsChildType]
        /// </summary>
        [Field("ChemicalsChildType", DbType.Int32, false)]
        public int ChemicalsChildType
        {
            get { return _ChemicalsChildType; }
            set { this._ChemicalsChildType = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ChemicalsList()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal ChemicalsList(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.ChemicalsList).Where(DataBases.ChemicalsList.ID == ID);
            Init(section, DataBases.ChemicalsList);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.ChemicalsList, DataBases.ChemicalsList.ID.Count()).Where(DataBases.ChemicalsList.ID == ID);
            Update(section, DataBases.ChemicalsList);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.ChemicalsList).Where(DataBases.ChemicalsList.ID == ID);
            Remove(section, DataBases.ChemicalsList);
        }
    }
}

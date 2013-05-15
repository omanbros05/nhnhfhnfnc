using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 案件处理呈批表
    /// </summary>
    [Table("CaseHandel", true)]
    public partial class CaseHandel : BaseEntity<CaseHandel>
    {
        private int _ID;
        /// <summary>
        /// 自动编号 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _UnitAbb = String.Empty;
        /// <summary>
        /// 地域简称 [UnitAbb]
        /// </summary>
        [Field("UnitAbb", DbType.String, false)]
        public string UnitAbb
        {
            get { return _UnitAbb; }
            set { this._UnitAbb = value; }
        }
        private string _DocYear = String.Empty;
        /// <summary>
        /// 文档年份 [DocYear]
        /// </summary>
        [Field("DocYear", DbType.String, false)]
        public string DocYear
        {
            get { return _DocYear; }
            set { this._DocYear = value; }
        }
        private string _DocIndex = String.Empty;
        /// <summary>
        /// 文档序号 [DocIndex]
        /// </summary>
        [Field("DocIndex", DbType.String, false)]
        public string DocIndex
        {
            get { return _DocIndex; }
            set { this._DocIndex = value; }
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
        private string _LegalRepre = String.Empty;
        /// <summary>
        /// 法定代表人 [LegalRepre]
        /// </summary>
        [Field("LegalRepre", DbType.String, false)]
        public string LegalRepre
        {
            get { return _LegalRepre; }
            set { this._LegalRepre = value; }
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
        private string _CaseSource = String.Empty;
        /// <summary>
        /// 案件来源 [CaseSource]
        /// </summary>
        [Field("CaseSource", DbType.String, false)]
        public string CaseSource
        {
            get { return _CaseSource; }
            set { this._CaseSource = value; }
        }
        private string _CaseSituation = String.Empty;
        /// <summary>
        /// 案情概况 [CaseSituation]
        /// </summary>
        [Field("CaseSituation", DbType.AnsiString, false)]
        public string CaseSituation
        {
            get { return _CaseSituation; }
            set { this._CaseSituation = value; }
        }
        private string _Fact = String.Empty;
        /// <summary>
        /// 违法事实 [Fact]
        /// </summary>
        [Field("Fact", DbType.AnsiString, false)]
        public string Fact
        {
            get { return _Fact; }
            set { this._Fact = value; }
        }
        private string _Undertake = String.Empty;
        /// <summary>
        /// 承办人 [Undertake]
        /// </summary>
        [Field("Undertake", DbType.String, false)]
        public string Undertake
        {
            get { return _Undertake; }
            set { this._Undertake = value; }
        }
        private string _UndertakeOpinion = String.Empty;
        /// <summary>
        /// 承办人意见 [UndertakeOpinion]
        /// </summary>
        [Field("UndertakeOpinion", DbType.AnsiString, false)]
        public string UndertakeOpinion
        {
            get { return _UndertakeOpinion; }
            set { this._UndertakeOpinion = value; }
        }
        private DateTime _UndertakeDate;
        /// <summary>
        /// 承办日期 [UndertakeDate]
        /// </summary>
        [Field("UndertakeDate", DbType.DateTime, false)]
        public DateTime UndertakeDate
        {
            get { return _UndertakeDate; }
            set { this._UndertakeDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CaseHandel()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal CaseHandel(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseHandel).Where(DataBases.CaseHandel.ID == ID);
            Init(section, DataBases.CaseHandel);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.CaseHandel, DataBases.CaseHandel.ID.Count()).Where(DataBases.CaseHandel.ID == ID);
            Update(section, DataBases.CaseHandel);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.CaseHandel).Where(DataBases.CaseHandel.ID == ID);
            Remove(section, DataBases.CaseHandel);
        }
    }
}

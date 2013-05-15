using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 听证笔录
    /// </summary>
    [Table("PutDown", true)]
    public partial class PutDown : BaseEntity<PutDown>
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
        private string _Organ = String.Empty;
        /// <summary>
        /// 主持听证机关 [Organ]
        /// </summary>
        [Field("Organ", DbType.String, false)]
        public string Organ
        {
            get { return _Organ; }
            set { this._Organ = value; }
        }
        private string _OrganAddress = String.Empty;
        /// <summary>
        /// 听证机关地点 [OrganAddress]
        /// </summary>
        [Field("OrganAddress", DbType.String, false)]
        public string OrganAddress
        {
            get { return _OrganAddress; }
            set { this._OrganAddress = value; }
        }
        private DateTime _HearBeginDate;
        /// <summary>
        /// 听证起始时间 [HearBeginDate]
        /// </summary>
        [Field("HearBeginDate", DbType.DateTime, false)]
        public DateTime HearBeginDate
        {
            get { return _HearBeginDate; }
            set { this._HearBeginDate = value; }
        }
        private DateTime _HearEndDate;
        /// <summary>
        /// 听证结束时间 [HearEndDate]
        /// </summary>
        [Field("HearEndDate", DbType.DateTime, false)]
        public DateTime HearEndDate
        {
            get { return _HearEndDate; }
            set { this._HearEndDate = value; }
        }
        private string _CompereName = String.Empty;
        /// <summary>
        /// 听证主持人 [CompereName]
        /// </summary>
        [Field("CompereName", DbType.String, false)]
        public string CompereName
        {
            get { return _CompereName; }
            set { this._CompereName = value; }
        }
        private string _HearName = String.Empty;
        /// <summary>
        /// 听证员 [HearName]
        /// </summary>
        [Field("HearName", DbType.String, false)]
        public string HearName
        {
            get { return _HearName; }
            set { this._HearName = value; }
        }
        private string _SecretaryName = String.Empty;
        /// <summary>
        /// 书记 [SecretaryName]
        /// </summary>
        [Field("SecretaryName", DbType.String, false)]
        public string SecretaryName
        {
            get { return _SecretaryName; }
            set { this._SecretaryName = value; }
        }
        private string _Investigador1 = String.Empty;
        /// <summary>
        /// 调查人员1 [Investigador1]
        /// </summary>
        [Field("Investigador1", DbType.String, false)]
        public string Investigador1
        {
            get { return _Investigador1; }
            set { this._Investigador1 = value; }
        }
        private string _InvestigadorIDC1 = String.Empty;
        /// <summary>
        /// 调查人员证号1 [InvestigadorIDC1]
        /// </summary>
        [Field("InvestigadorIDC1", DbType.String, false)]
        public string InvestigadorIDC1
        {
            get { return _InvestigadorIDC1; }
            set { this._InvestigadorIDC1 = value; }
        }
        private string _Investigador2 = String.Empty;
        /// <summary>
        /// 调查人员2 [Investigador2]
        /// </summary>
        [Field("Investigador2", DbType.String, false)]
        public string Investigador2
        {
            get { return _Investigador2; }
            set { this._Investigador2 = value; }
        }
        private string _InvestigadorIDC2 = String.Empty;
        /// <summary>
        /// 调查人员证号2 [InvestigadorIDC2]
        /// </summary>
        [Field("InvestigadorIDC2", DbType.String, false)]
        public string InvestigadorIDC2
        {
            get { return _InvestigadorIDC2; }
            set { this._InvestigadorIDC2 = value; }
        }
        private string _ProposerCompany = String.Empty;
        /// <summary>
        /// 听证申请人(单位) [ProposerCompany]
        /// </summary>
        [Field("ProposerCompany", DbType.String, false)]
        public string ProposerCompany
        {
            get { return _ProposerCompany; }
            set { this._ProposerCompany = value; }
        }
        private string _ProposerAddress = String.Empty;
        /// <summary>
        /// 听证申请人(单位)地址 [ProposerAddress]
        /// </summary>
        [Field("ProposerAddress", DbType.String, false)]
        public string ProposerAddress
        {
            get { return _ProposerAddress; }
            set { this._ProposerAddress = value; }
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
        private string _LegalRepreSex = String.Empty;
        /// <summary>
        /// 法定代表人性别 [LegalRepreSex]
        /// </summary>
        [Field("LegalRepreSex", DbType.String, false)]
        public string LegalRepreSex
        {
            get { return _LegalRepreSex; }
            set { this._LegalRepreSex = value; }
        }
        private int _LegalRepreAge;
        /// <summary>
        /// 法定代表人年龄 [LegalRepreAge]
        /// </summary>
        [Field("LegalRepreAge", DbType.Int32, false)]
        public int LegalRepreAge
        {
            get { return _LegalRepreAge; }
            set { this._LegalRepreAge = value; }
        }
        private string _LegalRepreAgent1 = String.Empty;
        /// <summary>
        /// 委托代理人1 [LegalRepreAgent1]
        /// </summary>
        [Field("LegalRepreAgent1", DbType.String, false)]
        public string LegalRepreAgent1
        {
            get { return _LegalRepreAgent1; }
            set { this._LegalRepreAgent1 = value; }
        }
        private string _LegalRepreAgentSex1 = String.Empty;
        /// <summary>
        /// 委托代理人1性别 [LegalRepreAgentSex1]
        /// </summary>
        [Field("LegalRepreAgentSex1", DbType.String, false)]
        public string LegalRepreAgentSex1
        {
            get { return _LegalRepreAgentSex1; }
            set { this._LegalRepreAgentSex1 = value; }
        }
        private int _LegalRepreAgentAge1;
        /// <summary>
        /// 委托代理人1年龄 [LegalRepreAgentAge1]
        /// </summary>
        [Field("LegalRepreAgentAge1", DbType.Int32, false)]
        public int LegalRepreAgentAge1
        {
            get { return _LegalRepreAgentAge1; }
            set { this._LegalRepreAgentAge1 = value; }
        }
        private string _LegalRepreAgentJob1 = String.Empty;
        /// <summary>
        /// 委托代理人1职务 [LegalRepreAgentJob1]
        /// </summary>
        [Field("LegalRepreAgentJob1", DbType.String, false)]
        public string LegalRepreAgentJob1
        {
            get { return _LegalRepreAgentJob1; }
            set { this._LegalRepreAgentJob1 = value; }
        }
        private string _LegalRepreAgent2 = String.Empty;
        /// <summary>
        /// 委托代理人2 [LegalRepreAgent2]
        /// </summary>
        [Field("LegalRepreAgent2", DbType.String, false)]
        public string LegalRepreAgent2
        {
            get { return _LegalRepreAgent2; }
            set { this._LegalRepreAgent2 = value; }
        }
        private string _LegalRepreAgentSex2 = String.Empty;
        /// <summary>
        /// 委托代理人2性别 [LegalRepreAgentSex2]
        /// </summary>
        [Field("LegalRepreAgentSex2", DbType.String, false)]
        public string LegalRepreAgentSex2
        {
            get { return _LegalRepreAgentSex2; }
            set { this._LegalRepreAgentSex2 = value; }
        }
        private int _LegalRepreAgentAge2;
        /// <summary>
        /// 委托代理人2年龄 [LegalRepreAgentAge2]
        /// </summary>
        [Field("LegalRepreAgentAge2", DbType.Int32, false)]
        public int LegalRepreAgentAge2
        {
            get { return _LegalRepreAgentAge2; }
            set { this._LegalRepreAgentAge2 = value; }
        }
        private string _LegalRepreAgentJob2 = String.Empty;
        /// <summary>
        /// 委托代理人2职务 [LegalRepreAgentJob2]
        /// </summary>
        [Field("LegalRepreAgentJob2", DbType.String, false)]
        public string LegalRepreAgentJob2
        {
            get { return _LegalRepreAgentJob2; }
            set { this._LegalRepreAgentJob2 = value; }
        }
        private string _Proposer = String.Empty;
        /// <summary>
        /// 听证申请人(自然人) [Proposer]
        /// </summary>
        [Field("Proposer", DbType.String, false)]
        public string Proposer
        {
            get { return _Proposer; }
            set { this._Proposer = value; }
        }
        private int _ProposerSex;
        /// <summary>
        /// 听证申请人性别 [ProposerSex]
        /// </summary>
        [Field("ProposerSex", DbType.Int32, false)]
        public int ProposerSex
        {
            get { return _ProposerSex; }
            set { this._ProposerSex = value; }
        }
        private int _ProposerAge;
        /// <summary>
        /// 听证申请人年龄 [ProposerAge]
        /// </summary>
        [Field("ProposerAge", DbType.Int32, false)]
        public int ProposerAge
        {
            get { return _ProposerAge; }
            set { this._ProposerAge = value; }
        }
        private string _ProposerJob = String.Empty;
        /// <summary>
        /// 听证申请人职务 [ProposerJob]
        /// </summary>
        [Field("ProposerJob", DbType.String, false)]
        public string ProposerJob
        {
            get { return _ProposerJob; }
            set { this._ProposerJob = value; }
        }
        private string _ProposerAgent1 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人 [ProposerAgent1]
        /// </summary>
        [Field("ProposerAgent1", DbType.String, false)]
        public string ProposerAgent1
        {
            get { return _ProposerAgent1; }
            set { this._ProposerAgent1 = value; }
        }
        private string _ProposerAgentSex1 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人1性别 [ProposerAgentSex1]
        /// </summary>
        [Field("ProposerAgentSex1", DbType.String, false)]
        public string ProposerAgentSex1
        {
            get { return _ProposerAgentSex1; }
            set { this._ProposerAgentSex1 = value; }
        }
        private int _ProposerAgentAge1;
        /// <summary>
        /// 听证申请委托代理人1年龄 [ProposerAgentAge1]
        /// </summary>
        [Field("ProposerAgentAge1", DbType.Int32, false)]
        public int ProposerAgentAge1
        {
            get { return _ProposerAgentAge1; }
            set { this._ProposerAgentAge1 = value; }
        }
        private string _ProposerAgentJob1 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人1职务 [ProposerAgentJob1]
        /// </summary>
        [Field("ProposerAgentJob1", DbType.String, false)]
        public string ProposerAgentJob1
        {
            get { return _ProposerAgentJob1; }
            set { this._ProposerAgentJob1 = value; }
        }
        private string _ProposerAgen2 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人2 [ProposerAgen2]
        /// </summary>
        [Field("ProposerAgen2", DbType.String, false)]
        public string ProposerAgen2
        {
            get { return _ProposerAgen2; }
            set { this._ProposerAgen2 = value; }
        }
        private string _ProposerAgentSex2 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人2性别 [ProposerAgentSex2]
        /// </summary>
        [Field("ProposerAgentSex2", DbType.String, false)]
        public string ProposerAgentSex2
        {
            get { return _ProposerAgentSex2; }
            set { this._ProposerAgentSex2 = value; }
        }
        private int _ProposerAgentAge2;
        /// <summary>
        /// 听证申请委托代理人2年龄 [ProposerAgentAge2]
        /// </summary>
        [Field("ProposerAgentAge2", DbType.Int32, false)]
        public int ProposerAgentAge2
        {
            get { return _ProposerAgentAge2; }
            set { this._ProposerAgentAge2 = value; }
        }
        private string _ProposerAgentJob2 = String.Empty;
        /// <summary>
        /// 听证申请委托代理人2职务 [ProposerAgentJob2]
        /// </summary>
        [Field("ProposerAgentJob2", DbType.String, false)]
        public string ProposerAgentJob2
        {
            get { return _ProposerAgentJob2; }
            set { this._ProposerAgentJob2 = value; }
        }
        private string _ThirdPerson = String.Empty;
        /// <summary>
        /// 第三人 [ThirdPerson]
        /// </summary>
        [Field("ThirdPerson", DbType.String, false)]
        public string ThirdPerson
        {
            get { return _ThirdPerson; }
            set { this._ThirdPerson = value; }
        }
        private string _OhterPerson = String.Empty;
        /// <summary>
        /// 其他参与人员 [OhterPerson]
        /// </summary>
        [Field("OhterPerson", DbType.String, false)]
        public string OhterPerson
        {
            get { return _OhterPerson; }
            set { this._OhterPerson = value; }
        }
        private string _Record = String.Empty;
        /// <summary>
        /// 听证记录 [Record]
        /// </summary>
        [Field("Record", DbType.String, false)]
        public string Record
        {
            get { return _Record; }
            set { this._Record = value; }
        }
        private string _ProposerOrAgent = String.Empty;
        /// <summary>
        /// 听证申请人或其委托代理人 [ProposerOrAgent]
        /// </summary>
        [Field("ProposerOrAgent", DbType.String, false)]
        public string ProposerOrAgent
        {
            get { return _ProposerOrAgent; }
            set { this._ProposerOrAgent = value; }
        }
        private DateTime _DocDate;
        /// <summary>
        /// 文档日期 [DocDate]
        /// </summary>
        [Field("DocDate", DbType.DateTime, false)]
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { this._DocDate = value; }
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
        public PutDown()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal PutDown(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.PutDown).Where(DataBases.PutDown.ID == ID);
            Init(section, DataBases.PutDown);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.PutDown, DataBases.PutDown.ID.Count()).Where(DataBases.PutDown.ID == ID);
            Update(section, DataBases.PutDown);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.PutDown).Where(DataBases.PutDown.ID == ID);
            Remove(section, DataBases.PutDown);
        }
    }
}

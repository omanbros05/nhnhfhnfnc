using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 行政处罚案件调查终结报告
    /// </summary>
    [Table("SurveyEndReport", true)]
    public partial class SurveyEndReport : BaseEntity<SurveyEndReport>
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
        private int _CaseID =-1;
        /// <summary>
        /// 案件ID [CaseID]
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
        private string _CaseHandleResult = String.Empty;
        /// <summary>
        /// 处理结果 [CaseHandleResult]
        /// </summary>
        [Field("CaseHandleResult", DbType.String, false)]
        public string CaseHandleResult
        {
            get { return _CaseHandleResult; }
            set { this._CaseHandleResult = value; }
        }
        private DateTime _CaseStartDate;
        /// <summary>
        /// 立案时间 [CaseStartDate]
        /// </summary>
        [Field("CaseStartDate", DbType.DateTime, false)]
        public DateTime CaseStartDate
        {
            get { return _CaseStartDate; }
            set { this._CaseStartDate = value; }
        }
        private DateTime _CaseEndDate;
        /// <summary>
        /// 结案时间 [CaseEndDate]
        /// </summary>
        [Field("CaseEndDate", DbType.DateTime, false)]
        public DateTime CaseEndDate
        {
            get { return _CaseEndDate; }
            set { this._CaseEndDate = value; }
        }
        private string _CaseVolume = String.Empty;
        /// <summary>
        /// 卷 [CaseVolume]
        /// </summary>
        [Field("CaseVolume", DbType.String, false)]
        public string CaseVolume
        {
            get { return _CaseVolume; }
            set { this._CaseVolume = value; }
        }
        private string _CaseItem = String.Empty;
        /// <summary>
        /// 件 [CaseItem]
        /// </summary>
        [Field("CaseItem", DbType.String, false)]
        public string CaseItem
        {
            get { return _CaseItem; }
            set { this._CaseItem = value; }
        }
        private string _CasePage = String.Empty;
        /// <summary>
        /// 页 [CasePage]
        /// </summary>
        [Field("CasePage", DbType.String, false)]
        public string CasePage
        {
            get { return _CasePage; }
            set { this._CasePage = value; }
        }
        private string _CaseRetention = String.Empty;
        /// <summary>
        /// 保管期限 [CaseRetention]
        /// </summary>
        [Field("CaseRetention", DbType.String, false)]
        public string CaseRetention
        {
            get { return _CaseRetention; }
            set { this._CaseRetention = value; }
        }
        private string _CaseArchivingNo = String.Empty;
        /// <summary>
        /// 归档号 [CaseArchivingNo]
        /// </summary>
        [Field("CaseArchivingNo", DbType.String, false)]
        public string CaseArchivingNo
        {
            get { return _CaseArchivingNo; }
            set { this._CaseArchivingNo = value; }
        }
        private string _AllCaseVolume = String.Empty;
        /// <summary>
        /// 案卷号 [AllCaseVolume]
        /// </summary>
        [Field("AllCaseVolume", DbType.String, false)]
        public string AllCaseVolume
        {
            get { return _AllCaseVolume; }
            set { this._AllCaseVolume = value; }
        }
        private string _AllCaseCatalogNo = String.Empty;
        /// <summary>
        /// 目录号（类别号） [AllCaseCatalogNo]
        /// </summary>
        [Field("AllCaseCatalogNo", DbType.String, false)]
        public string AllCaseCatalogNo
        {
            get { return _AllCaseCatalogNo; }
            set { this._AllCaseCatalogNo = value; }
        }
        private string _AllFondsNo = String.Empty;
        /// <summary>
        /// 全宗号 [AllFondsNo]
        /// </summary>
        [Field("AllFondsNo", DbType.String, false)]
        public string AllFondsNo
        {
            get { return _AllFondsNo; }
            set { this._AllFondsNo = value; }
        }
        private string _FormHeadUnitAbb = String.Empty;
        /// <summary>
        /// 表单单位简称 [FormHeadUnitAbb]
        /// </summary>
        [Field("FormHeadUnitAbb", DbType.String, false)]
        public string FormHeadUnitAbb
        {
            get { return _FormHeadUnitAbb; }
            set { this._FormHeadUnitAbb = value; }
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
        private string _UserName1 = String.Empty;
        /// <summary>
        ///  [UserName1]
        /// </summary>
        [Field("UserName1", DbType.String, false)]
        public string UserName1
        {
            get { return _UserName1; }
            set { this._UserName1 = value; }
        }
        private string _UserName2 = String.Empty;
        /// <summary>
        ///  [UserName2]
        /// </summary>
        [Field("UserName2", DbType.String, false)]
        public string UserName2
        {
            get { return _UserName2; }
            set { this._UserName2 = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SurveyEndReport()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SurveyEndReport(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SurveyEndReport).Where(DataBases.SurveyEndReport.ID == ID);
            Init(section, DataBases.SurveyEndReport);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SurveyEndReport, DataBases.SurveyEndReport.ID.Count()).Where(DataBases.SurveyEndReport.ID == ID);
            Update(section, DataBases.SurveyEndReport);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SurveyEndReport).Where(DataBases.SurveyEndReport.ID == ID);
            Remove(section, DataBases.SurveyEndReport);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 询问笔录
    /// </summary>
    [Table("EnquireQuestion", true)]
    public partial class EnquireQuestion : BaseEntity<EnquireQuestion>
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
        private DateTime _EnquireBeginDate;
        /// <summary>
        /// 询问开始时间 [EnquireBeginDate]
        /// </summary>
        [Field("EnquireBeginDate", DbType.DateTime, false)]
        public DateTime EnquireBeginDate
        {
            get { return _EnquireBeginDate; }
            set { this._EnquireBeginDate = value; }
        }
        private DateTime _EnquireEndDate;
        /// <summary>
        /// 询问结束时间 [EnquireEndDate]
        /// </summary>
        [Field("EnquireEndDate", DbType.DateTime, false)]
        public DateTime EnquireEndDate
        {
            get { return _EnquireEndDate; }
            set { this._EnquireEndDate = value; }
        }
        private string _EnquireCount = String.Empty;
        /// <summary>
        /// 询问次数 [EnquireCount]
        /// </summary>
        [Field("EnquireCount", DbType.String, false)]
        public string EnquireCount
        {
            get { return _EnquireCount; }
            set { this._EnquireCount = value; }
        }
        private string _EnquireAddress = String.Empty;
        /// <summary>
        /// 询问地点 [EnquireAddress]
        /// </summary>
        [Field("EnquireAddress", DbType.String, false)]
        public string EnquireAddress
        {
            get { return _EnquireAddress; }
            set { this._EnquireAddress = value; }
        }
        private string _EnquirePerson = String.Empty;
        /// <summary>
        /// 被询问人姓名 [EnquirePerson]
        /// </summary>
        [Field("EnquirePerson", DbType.String, false)]
        public string EnquirePerson
        {
            get { return _EnquirePerson; }
            set { this._EnquirePerson = value; }
        }
        private string _EnquirePersonSex = String.Empty;
        /// <summary>
        /// 被询问人性别 [EnquirePersonSex]
        /// </summary>
        [Field("EnquirePersonSex", DbType.String, false)]
        public string EnquirePersonSex
        {
            get { return _EnquirePersonSex; }
            set { this._EnquirePersonSex = value; }
        }
        private string _EnquirePersonAge = String.Empty;
        /// <summary>
        /// 被询问人年龄 [EnquirePersonAge]
        /// </summary>
        [Field("EnquirePersonAge", DbType.String, false)]
        public string EnquirePersonAge
        {
            get { return _EnquirePersonAge; }
            set { this._EnquirePersonAge = value; }
        }
        private string _EnquirePersonIDC = String.Empty;
        /// <summary>
        /// 被询问人身份证号 [EnquirePersonIDC]
        /// </summary>
        [Field("EnquirePersonIDC", DbType.String, false)]
        public string EnquirePersonIDC
        {
            get { return _EnquirePersonIDC; }
            set { this._EnquirePersonIDC = value; }
        }
        private string _EnquirePersonUnit = String.Empty;
        /// <summary>
        /// 工作单位 [EnquirePersonUnit]
        /// </summary>
        [Field("EnquirePersonUnit", DbType.String, false)]
        public string EnquirePersonUnit
        {
            get { return _EnquirePersonUnit; }
            set { this._EnquirePersonUnit = value; }
        }
        private string _EnquirePersonJob = String.Empty;
        /// <summary>
        /// 职务 [EnquirePersonJob]
        /// </summary>
        [Field("EnquirePersonJob", DbType.String, false)]
        public string EnquirePersonJob
        {
            get { return _EnquirePersonJob; }
            set { this._EnquirePersonJob = value; }
        }
        private string _EnquirePersonAddress = String.Empty;
        /// <summary>
        /// 住址 [EnquirePersonAddress]
        /// </summary>
        [Field("EnquirePersonAddress", DbType.String, false)]
        public string EnquirePersonAddress
        {
            get { return _EnquirePersonAddress; }
            set { this._EnquirePersonAddress = value; }
        }
        private string _EnquirePersonTel = String.Empty;
        /// <summary>
        /// 电话 [EnquirePersonTel]
        /// </summary>
        [Field("EnquirePersonTel", DbType.String, false)]
        public string EnquirePersonTel
        {
            get { return _EnquirePersonTel; }
            set { this._EnquirePersonTel = value; }
        }
        private string _EnquirerName = String.Empty;
        /// <summary>
        /// 询问人 [EnquirerName]
        /// </summary>
        [Field("EnquirerName", DbType.String, false)]
        public string EnquirerName
        {
            get { return _EnquirerName; }
            set { this._EnquirerName = value; }
        }
        private string _EnquirerUnit = String.Empty;
        /// <summary>
        /// 询问人单位 [EnquirerUnit]
        /// </summary>
        [Field("EnquirerUnit", DbType.String, false)]
        public string EnquirerUnit
        {
            get { return _EnquirerUnit; }
            set { this._EnquirerUnit = value; }
        }
        private string _WriterName = String.Empty;
        /// <summary>
        /// 记录人 [WriterName]
        /// </summary>
        [Field("WriterName", DbType.String, false)]
        public string WriterName
        {
            get { return _WriterName; }
            set { this._WriterName = value; }
        }
        private string _WriterUnit = String.Empty;
        /// <summary>
        /// 记录人单位 [WriterUnit]
        /// </summary>
        [Field("WriterUnit", DbType.String, false)]
        public string WriterUnit
        {
            get { return _WriterUnit; }
            set { this._WriterUnit = value; }
        }
        private string _Attendee = String.Empty;
        /// <summary>
        /// 在场人 [Attendee]
        /// </summary>
        [Field("Attendee", DbType.String, false)]
        public string Attendee
        {
            get { return _Attendee; }
            set { this._Attendee = value; }
        }
        private string _QFirstUnit = String.Empty;
        /// <summary>
        /// 问题1安监局单位 [QFirstUnit]
        /// </summary>
        [Field("QFirstUnit", DbType.String, false)]
        public string QFirstUnit
        {
            get { return _QFirstUnit; }
            set { this._QFirstUnit = value; }
        }
        private string _QFirstPerson1 = String.Empty;
        /// <summary>
        /// 问题1人员1 [QFirstPerson1]
        /// </summary>
        [Field("QFirstPerson1", DbType.String, false)]
        public string QFirstPerson1
        {
            get { return _QFirstPerson1; }
            set { this._QFirstPerson1 = value; }
        }
        private string _QFirstPersonIDC1 = String.Empty;
        /// <summary>
        /// 问题1人员1证件号 [QFirstPersonIDC1]
        /// </summary>
        [Field("QFirstPersonIDC1", DbType.String, false)]
        public string QFirstPersonIDC1
        {
            get { return _QFirstPersonIDC1; }
            set { this._QFirstPersonIDC1 = value; }
        }
        private string _QFirstPerson2 = String.Empty;
        /// <summary>
        /// 问题1人员2 [QFirstPerson2]
        /// </summary>
        [Field("QFirstPerson2", DbType.String, false)]
        public string QFirstPerson2
        {
            get { return _QFirstPerson2; }
            set { this._QFirstPerson2 = value; }
        }
        private string _QFirstPerson2IDC2 = String.Empty;
        /// <summary>
        /// 问题1人员2证件号 [QFirstPerson2IDC2]
        /// </summary>
        [Field("QFirstPerson2IDC2", DbType.String, false)]
        public string QFirstPerson2IDC2
        {
            get { return _QFirstPerson2IDC2; }
            set { this._QFirstPerson2IDC2 = value; }
        }
        private string _QFirstAnswer = String.Empty;
        /// <summary>
        /// 问题1回答 [QFirstAnswer]
        /// </summary>
        [Field("QFirstAnswer", DbType.String, false)]
        public string QFirstAnswer
        {
            get { return _QFirstAnswer; }
            set { this._QFirstAnswer = value; }
        }
        private string _QuestionSecond = String.Empty;
        /// <summary>
        /// 问题2 [QuestionSecond]
        /// </summary>
        [Field("QuestionSecond", DbType.String, false)]
        public string QuestionSecond
        {
            get { return _QuestionSecond; }
            set { this._QuestionSecond = value; }
        }
        private string _QuestionSecondAnswer = String.Empty;
        /// <summary>
        /// 问题2回答 [QuestionSecondAnswer]
        /// </summary>
        [Field("QuestionSecondAnswer", DbType.String, false)]
        public string QuestionSecondAnswer
        {
            get { return _QuestionSecondAnswer; }
            set { this._QuestionSecondAnswer = value; }
        }
        private string _QuestionThirdAnswer = String.Empty;
        /// <summary>
        /// 问题3回答 [QuestionThirdAnswer]
        /// </summary>
        [Field("QuestionThirdAnswer", DbType.String, false)]
        public string QuestionThirdAnswer
        {
            get { return _QuestionThirdAnswer; }
            set { this._QuestionThirdAnswer = value; }
        }
        private string _Questions = String.Empty;
        /// <summary>
        /// 问答内容 [Questions]
        /// </summary>
        [Field("Questions", DbType.String, false)]
        public string Questions
        {
            get { return _Questions; }
            set { this._Questions = value; }
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
        public EnquireQuestion()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal EnquireQuestion(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.EnquireQuestion).Where(DataBases.EnquireQuestion.ID == ID);
            Init(section, DataBases.EnquireQuestion);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.EnquireQuestion, DataBases.EnquireQuestion.ID.Count()).Where(DataBases.EnquireQuestion.ID == ID);
            Update(section, DataBases.EnquireQuestion);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.EnquireQuestion).Where(DataBases.EnquireQuestion.ID == ID);
            Remove(section, DataBases.EnquireQuestion);
        }
    }
}

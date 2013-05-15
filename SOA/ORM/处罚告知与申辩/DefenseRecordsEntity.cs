using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 当事人陈诉申辩笔录
    /// </summary>
    [Table("DefenseRecords", true)]
    public partial class DefenseRecords : BaseEntity<DefenseRecords>
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
        private DateTime _DefenseStartDate;
        /// <summary>
        /// 申辩开始时间 [DefenseStartDate]
        /// </summary>
        [Field("DefenseStartDate", DbType.DateTime, false)]
        public DateTime DefenseStartDate
        {
            get { return _DefenseStartDate; }
            set { this._DefenseStartDate = value; }
        }
        private DateTime _DefenseEndDate;
        /// <summary>
        /// 申辩结束时间 [DefenseEndDate]
        /// </summary>
        [Field("DefenseEndDate", DbType.DateTime, false)]
        public DateTime DefenseEndDate
        {
            get { return _DefenseEndDate; }
            set { this._DefenseEndDate = value; }
        }
        private string _Location = String.Empty;
        /// <summary>
        /// 地点 [Location]
        /// </summary>
        [Field("Location", DbType.String, false)]
        public string Location
        {
            get { return _Location; }
            set { this._Location = value; }
        }
        private string _DefenseUser = String.Empty;
        /// <summary>
        /// 陈诉申辩人 [DefenseUser]
        /// </summary>
        [Field("DefenseUser", DbType.String, false)]
        public string DefenseUser
        {
            get { return _DefenseUser; }
            set { this._DefenseUser = value; }
        }
        private string _Sex = String.Empty;
        /// <summary>
        /// 性别 [Sex]
        /// </summary>
        [Field("Sex", DbType.String, false)]
        public string Sex
        {
            get { return _Sex; }
            set { this._Sex = value; }
        }
        private string _Position = String.Empty;
        /// <summary>
        /// 职务 [Position]
        /// </summary>
        [Field("Position", DbType.String, false)]
        public string Position
        {
            get { return _Position; }
            set { this._Position = value; }
        }
        private string _WorkUnit = String.Empty;
        /// <summary>
        /// 工作单位 [WorkUnit]
        /// </summary>
        [Field("WorkUnit", DbType.String, false)]
        public string WorkUnit
        {
            get { return _WorkUnit; }
            set { this._WorkUnit = value; }
        }
        private string _Tel = String.Empty;
        /// <summary>
        /// 联系电话 [Tel]
        /// </summary>
        [Field("Tel", DbType.String, false)]
        public string Tel
        {
            get { return _Tel; }
            set { this._Tel = value; }
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
        private string _ZipCode = String.Empty;
        /// <summary>
        /// 邮编 [ZipCode]
        /// </summary>
        [Field("ZipCode", DbType.String, false)]
        public string ZipCode
        {
            get { return _ZipCode; }
            set { this._ZipCode = value; }
        }
        private string _UserName1 = String.Empty;
        /// <summary>
        /// 承办人1 [UserName1]
        /// </summary>
        [Field("UserName1", DbType.String, false)]
        public string UserName1
        {
            get { return _UserName1; }
            set { this._UserName1 = value; }
        }
        private string _UserName2 = String.Empty;
        /// <summary>
        /// 承办人2 [UserName2]
        /// </summary>
        [Field("UserName2", DbType.String, false)]
        public string UserName2
        {
            get { return _UserName2; }
            set { this._UserName2 = value; }
        }
        private string _UserName3 = String.Empty;
        /// <summary>
        /// 记录人 [UserName3]
        /// </summary>
        [Field("UserName3", DbType.String, false)]
        public string UserName3
        {
            get { return _UserName3; }
            set { this._UserName3 = value; }
        }
        private string _LawUnit = String.Empty;
        /// <summary>
        /// 执法单位 [LawUnit]
        /// </summary>
        [Field("LawUnit", DbType.String, false)]
        public string LawUnit
        {
            get { return _LawUnit; }
            set { this._LawUnit = value; }
        }
        private string _ProblemResult1 = String.Empty;
        /// <summary>
        /// 第一个问题回答 [ProblemResult1]
        /// </summary>
        [Field("ProblemResult1", DbType.String, false)]
        public string ProblemResult1
        {
            get { return _ProblemResult1; }
            set { this._ProblemResult1 = value; }
        }
        private string _ProblemResult2 = String.Empty;
        /// <summary>
        /// 第二个问题回答 [ProblemResult2]
        /// </summary>
        [Field("ProblemResult2", DbType.String, false)]
        public string ProblemResult2
        {
            get { return _ProblemResult2; }
            set { this._ProblemResult2 = value; }
        }
        private string _ProblemResult3 = String.Empty;
        /// <summary>
        /// 第三个问题回答 [ProblemResult3]
        /// </summary>
        [Field("ProblemResult3", DbType.String, false)]
        public string ProblemResult3
        {
            get { return _ProblemResult3; }
            set { this._ProblemResult3 = value; }
        }
        private int _CaseID;
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
        private DateTime _DefenseDate;
        /// <summary>
        /// 申辩日期 [DefenseDate]
        /// </summary>
        [Field("DefenseDate", DbType.DateTime, false)]
        public DateTime DefenseDate
        {
            get { return _DefenseDate; }
            set { this._DefenseDate = value; }
        }
        private string _ProblemUser1 = String.Empty;
        /// <summary>
        ///  [ProblemUser1]
        /// </summary>
        [Field("ProblemUser1", DbType.String, false)]
        public string ProblemUser1
        {
            get { return _ProblemUser1; }
            set { this._ProblemUser1 = value; }
        }
        private string _ProblemUser2 = String.Empty;
        /// <summary>
        ///  [ProblemUser2]
        /// </summary>
        [Field("ProblemUser2", DbType.String, false)]
        public string ProblemUser2
        {
            get { return _ProblemUser2; }
            set { this._ProblemUser2 = value; }
        }
        private string _ProblemUserCode1 = String.Empty;
        /// <summary>
        ///  [ProblemUserCode1]
        /// </summary>
        [Field("ProblemUserCode1", DbType.String, false)]
        public string ProblemUserCode1
        {
            get { return _ProblemUserCode1; }
            set { this._ProblemUserCode1 = value; }
        }
        private string _ProblemUserCode2 = String.Empty;
        /// <summary>
        ///  [ProblemUserCode2]
        /// </summary>
        [Field("ProblemUserCode2", DbType.String, false)]
        public string ProblemUserCode2
        {
            get { return _ProblemUserCode2; }
            set { this._ProblemUserCode2 = value; }
        }
        private string _ProblemResult4 = String.Empty;
        /// <summary>
        ///  [ProblemResult4]
        /// </summary>
        [Field("ProblemResult4", DbType.String, false)]
        public string ProblemResult4
        {
            get { return _ProblemResult4; }
            set { this._ProblemResult4 = value; }
        }

        private string _ProblemContent = String.Empty;
        /// <summary>
        /// 问题补充及回答 [ProblemContent]
        /// </summary>
        [Field("ProblemContent", DbType.String, false)]
        public string ProblemContent
        {
            get { return _ProblemContent; }
            set { this._ProblemContent = value; }
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
        public DefenseRecords()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal DefenseRecords(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.DefenseRecords).Where(DataBases.DefenseRecords.ID == ID);
            Init(section, DataBases.DefenseRecords);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.DefenseRecords, DataBases.DefenseRecords.ID.Count()).Where(DataBases.DefenseRecords.ID == ID);
            Update(section, DataBases.DefenseRecords);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.DefenseRecords).Where(DataBases.DefenseRecords.ID == ID);
            Remove(section, DataBases.DefenseRecords);
        }
    }
}

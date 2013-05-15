using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 听证会报告书
    /// </summary>
    [Table("HearingInform", true)]
    public partial class HearingInform : BaseEntity<HearingInform>
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
        private string _DocTitle = String.Empty;
        /// <summary>
        /// 文号 [DocTitle]
        /// </summary>
        [Field("DocTitle", DbType.String, false)]
        public string DocTitle
        {
            get { return _DocTitle; }
            set { this._DocTitle = value; }
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
        private string _Summary = String.Empty;
        /// <summary>
        /// 摘要 [Summary]
        /// </summary>
        [Field("Summary", DbType.String, false)]
        public string Summary
        {
            get { return _Summary; }
            set { this._Summary = value; }
        }
        private string _Suggest = String.Empty;
        /// <summary>
        /// 听证主持人意见及建议 [Suggest]
        /// </summary>
        [Field("Suggest", DbType.String, false)]
        public string Suggest
        {
            get { return _Suggest; }
            set { this._Suggest = value; }
        }
        private string _PrincipalSuggest = String.Empty;
        /// <summary>
        /// 负责人审核意见 [PrincipalSuggest]
        /// </summary>
        [Field("PrincipalSuggest", DbType.String, false)]
        public string PrincipalSuggest
        {
            get { return _PrincipalSuggest; }
            set { this._PrincipalSuggest = value; }
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
        public HearingInform()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal HearingInform(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.HearingInform).Where(DataBases.HearingInform.ID == ID);
            Init(section, DataBases.HearingInform);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.HearingInform, DataBases.HearingInform.ID.Count()).Where(DataBases.HearingInform.ID == ID);
            Update(section, DataBases.HearingInform);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.HearingInform).Where(DataBases.HearingInform.ID == ID);
            Remove(section, DataBases.HearingInform);
        }
    }
}

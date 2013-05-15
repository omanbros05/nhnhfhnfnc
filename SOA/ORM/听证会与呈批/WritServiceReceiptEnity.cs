using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 文书送达回执
    /// </summary>
    [Table("WritServiceReceipt", true)]
    public partial class WritServiceReceipt : BaseEntity<WritServiceReceipt>
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
        private string _ServiceCompany = String.Empty;
        /// <summary>
        /// 送达单位 [ServiceCompany]
        /// </summary>
        [Field("ServiceCompany", DbType.String, false)]
        public string ServiceCompany
        {
            get { return _ServiceCompany; }
            set { this._ServiceCompany = value; }
        }
        private string _DocManageArea = String.Empty;
        /// <summary>
        /// 文档中监督管理局 [DocManageArea]
        /// </summary>
        [Field("DocManageArea", DbType.String, false)]
        public string DocManageArea
        {
            get { return _DocManageArea; }
            set { this._DocManageArea = value; }
        }
        private string _Note = String.Empty;
        /// <summary>
        /// 备注 [Note]
        /// </summary>
        [Field("Note", DbType.String, false)]
        public string Note
        {
            get { return _Note; }
            set { this._Note = value; }
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
        public WritServiceReceipt()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal WritServiceReceipt(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.WritServiceReceipt).Where(DataBases.WritServiceReceipt.ID == ID);
            Init(section, DataBases.WritServiceReceipt);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.WritServiceReceipt, DataBases.WritServiceReceipt.ID.Count()).Where(DataBases.WritServiceReceipt.ID == ID);
            Update(section, DataBases.WritServiceReceipt);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.WritServiceReceipt).Where(DataBases.WritServiceReceipt.ID == ID);
            Remove(section, DataBases.WritServiceReceipt);
        }
    }
}

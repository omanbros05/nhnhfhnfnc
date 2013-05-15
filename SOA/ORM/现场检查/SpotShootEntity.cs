using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 现场取证
    /// </summary>
    [Table("SpotShoot", true)]
    public partial class SpotShoot : BaseEntity<SpotShoot>
    {
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

        private int _ID;
        /// <summary>
        /// 自增编号 [ID]
        /// </summary>
        [Field("ID", DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }
        private string _SpotName = String.Empty;
        /// <summary>
        /// 现场取证名称 [SpotName]
        /// </summary>
        [Field("SpotName", DbType.String, false)]
        public string SpotName
        {
            get { return _SpotName; }
            set { this._SpotName = value; }
        }
        private DateTime _ShootDate;
        /// <summary>
        /// 拍摄日期 [ShootDate]
        /// </summary>
        [Field("ShootDate", DbType.DateTime, false)]
        public DateTime ShootDate
        {
            get { return _ShootDate; }
            set { this._ShootDate = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SpotShoot()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SpotShoot(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotShoot).Where(DataBases.SpotShoot.ID == ID);
            Init(section, DataBases.SpotShoot);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotShoot, DataBases.SpotShoot.ID.Count()).Where(DataBases.SpotShoot.ID == ID);
            Update(section, DataBases.SpotShoot);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SpotShoot).Where(DataBases.SpotShoot.ID == ID);
            Remove(section, DataBases.SpotShoot);
        }
    }
}

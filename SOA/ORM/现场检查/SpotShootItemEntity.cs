using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    /// <summary>
    /// 现场取证图片项
    /// </summary>
    [Table("SpotShootItem", true)]
    public partial class SpotShootItem : BaseEntity<SpotShootItem>
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
        private int _SpotID;
        /// <summary>
        /// 现场取证编号 [SpotID]
        /// </summary>
        [Field("SpotID", DbType.Int32, false)]
        public int SpotID
        {
            get { return _SpotID; }
            set { this._SpotID = value; }
        }
        private string _SpotPhoto;
        /// <summary>
        /// 现场取证照片 [SpotPhoto]
        /// </summary>
        [Field("SpotPhoto", DbType.String, false)]
        public string SpotPhoto
        {
            get { return _SpotPhoto; }
            set { this._SpotPhoto = value; }
        }
        private string _ShootAddress = String.Empty;
        /// <summary>
        /// 拍摄地点 [ShootAddress]
        /// </summary>
        [Field("ShootAddress", DbType.String, false)]
        public string ShootAddress
        {
            get { return _ShootAddress; }
            set { this._ShootAddress = value; }
        }
        private string _PhotoIllustr = String.Empty;
        /// <summary>
        /// 图片说明 [PhotoIllustr]
        /// </summary>
        [Field("PhotoIllustr", DbType.String, false)]
        public string PhotoIllustr
        {
            get { return _PhotoIllustr; }
            set { this._PhotoIllustr = value; }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SpotShootItem()
        { }


        /// <summary>
        /// 构造函数
        /// </summary>
        internal SpotShootItem(int id)
        {
            ID = id;
            Init();
        }


        /// <summary>
        /// 初始化实体
        /// </summary>
        internal override void Init()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotShootItem).Where(DataBases.SpotShootItem.ID == ID);
            Init(section, DataBases.SpotShootItem);
        }

        /// <summary>
        /// 更新实体到数据库(带事务)
        /// </summary>
        internal override void Update()
        {
            SelectSqlSection section = DB.Select(DataBases.SpotShootItem, DataBases.SpotShootItem.ID.Count()).Where(DataBases.SpotShootItem.ID == ID);
            Update(section, DataBases.SpotShootItem);
        }

        /// <summary>
        /// 从数据库中删除实体(带事务)
        /// </summary>
        internal override void Remove()
        {
            DeleteSqlSection section = DB.Delete(DataBases.SpotShootItem).Where(DataBases.SpotShootItem.ID == ID);
            Remove(section, DataBases.SpotShootItem);
        }
    }
}

using System;
using NBearLite;
using System.Data;
using System.Text;

namespace SOA.ORM
{
    [Table("Archive", true)]
    public partial class Archive : BaseEntity<Archive>
    {
        /// <summary>
        /// 主键GUID
        /// </summary>
        private int _ID;

        private string _name = String.Empty;

        private int _status;

        private DateTime _createtimes;

        [Field("CreateTimes", System.Data.DbType.DateTime, false)]
        public DateTime CreateTimes {
            get { return _createtimes; }
            set { _createtimes = value; }
        }

        [Field("ID", System.Data.DbType.Int32, true)]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// 类型名称[name]
        /// </summary>
        [Field("Name", System.Data.DbType.String, false)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Field("Status", System.Data.DbType.Byte, false)]
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Archive() { }

        internal Archive(int id) {
            ID = id;
            Init();
        }

        internal override void Init() {

            SelectSqlSection section = DB.Select(SOA.DataBases.Archive).Where(SOA.DataBases.Archive.ID == ID);
            Init(section, SOA.DataBases.Archive);
        }

        internal override void Update() {
            SelectSqlSection section = DB.Select(DataBases.Archive, SOA.DataBases.Archive.ID.Count()).Where(SOA.DataBases.Archive.ID == ID);
            Update(section, SOA.DataBases.Archive);
        }

        internal override void Remove() {

            DeleteSqlSection section = DB.Delete(SOA.DataBases.Archive).Where(SOA.DataBases.Archive.ID == ID);
            Remove(section, SOA.DataBases.Archive);
        }

        public  void RemoveByID(int id) {
            DeleteSqlSection section = DB.Delete(SOA.DataBases.Archive).Where(SOA.DataBases.Archive.ID == id);
            Remove(section, SOA.DataBases.Archive);
        }

        public int UpdateByID(int id, int status) {

            return DB.Update(DataBases.Archive).AddColumn(DataBases.Archive.Status, 1).Where(DataBases.Archive.ID == id).Execute();
        }

        public byte GetStatus(int id) {
            byte status = 0;
            SelectSqlSection section = DB.Select(DataBases.Archive).Where(DataBases.Archive.ID == id);
            using (IDataReader reader = section.ToDataReader()) {

                while (reader.Read()) {

                    status = (byte)reader["Status"];
                }
            }

            return status;
        }

        public DataSet GetDataSetWithoutArchived() {

            SelectSqlSection section = DB.Select(DataBases.Archive).Where(DataBases.Archive.Status != 1);
            DataSet ds = section.ToDataSet();

            return ds;
        }
    }
}

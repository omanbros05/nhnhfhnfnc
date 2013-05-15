using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class Officers
    {
        public override string SearchColumn()
        {
            return OfficersName;
        }

        /// <summary>
        /// 根据参数更新工作人员
        /// </summary>
        /// <param name="officersName">姓名</param>
        /// <param name="officers">工作人员</param>
        internal void UpdateOfficersByArgs(Officers officers)
        {
            if (officers.OfficersName == "")
                return;

            Officers databaseOfficers = null;

            SelectSqlSection section = DB.Select(DataBases.Officers).Where(DataBases.Officers.OfficersName == officers.OfficersName);
            if (officers.CID != "" && officers.OfficersName != "")
                section.Where(DataBases.Officers.CID == officers.CID);
            else if (officers.Position != "" && officers.OfficersName != "")
                section.Where(DataBases.Officers.Position == officers.Position);

            using (IDataReader reader = section.ToDataReader())
            {
                if (reader.Read())
                {
                    databaseOfficers = ReadRow(reader);
                }
            }

            if (databaseOfficers != null)
            {
                if (officers.CID != "")
                    databaseOfficers.CID = officers.CID;

                if (officers.OfficersName != "")
                    databaseOfficers.OfficersName = officers.OfficersName;

                if (officers.Position != "")
                    databaseOfficers.Position = officers.Position;

                if (officers.Unit != "")
                    databaseOfficers.Unit = officers.Unit;

                databaseOfficers.SystemService = this.SystemService;
                databaseOfficers.SQLtransaction = this.SQLtransaction;
                databaseOfficers.Update();
            }
            else
            {
                officers.SystemService = this.SystemService;
                officers.SQLtransaction = this.SQLtransaction;
                officers.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<Officers>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }

        /// <summary>
        /// 获取工作人员信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">工作人员姓名</param>
        /// <returns>实体集合</returns>
        internal EList<Officers> OfficersGetAll(int page, int pageSize, string name)
        {
            EList<Officers> Officerss = new EList<Officers>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
                Clips.Add(DataBases.Officers.OfficersName.Like("%" + name + "%"));

            SelectSqlSection section = DB.Select(DataBases.Officers, DataBases.Officers.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Officerss.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.Officers);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.Officers.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Officers officers = ReadRow(reader);
                        Officerss.Items.Add(officers);
                    }
                }
            }

            return Officerss;
        }
    }
}

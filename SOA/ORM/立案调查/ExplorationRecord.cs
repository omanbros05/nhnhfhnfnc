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
    public partial class ExplorationRecord
    {
        /// <summary>
        /// 获取勘验笔录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<ExplorationRecord> ExplorationRecordGetAll(int page, int pageSize, string DocTitle)
        {
            EList<ExplorationRecord> ExplorationRecords = new EList<ExplorationRecord>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.ExplorationRecord.DocTitle.Like("%" + DocTitle + "%"));
            Clips.Add(DataBases.ExplorationRecord.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.ExplorationRecord, DataBases.ExplorationRecord.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ExplorationRecords.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ExplorationRecord);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ExplorationRecord.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ExplorationRecord putOnRecord = ReadRow(reader);
                        ExplorationRecords.Items.Add(putOnRecord);
                    }
                }
            }

            return ExplorationRecords;
        }
    }
}

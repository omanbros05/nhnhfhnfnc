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
    public partial class PunishmentDiscussRecord
    {
        /// <summary>
        /// 获取行政处罚集体讨论记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<PunishmentDiscussRecord> PunishmentDiscussRecordGetAll(int page, int pageSize, string PutOnRecordCaseName, DateTime beginDate, DateTime endDate)
        {
            EList<PunishmentDiscussRecord> PunishmentDiscussRecords = new EList<PunishmentDiscussRecord>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (PutOnRecordCaseName != "")
                Clips.Add(DataBases.PunishmentDiscussRecord.PutOnRecordCaseName.Like("%" + PutOnRecordCaseName + "%"));
            Clips.Add(DataBases.PunishmentDiscussRecord.DiscussDate >= beginDate.Date && DataBases.PunishmentDiscussRecord.DiscussDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.PunishmentDiscussRecord.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.PunishmentDiscussRecord, DataBases.PunishmentDiscussRecord.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            PunishmentDiscussRecords.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PunishmentDiscussRecord);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PunishmentDiscussRecord.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PunishmentDiscussRecord putOnRecord = ReadRow(reader);
                        PunishmentDiscussRecords.Items.Add(putOnRecord);
                    }
                }
            }

            return PunishmentDiscussRecords;
        }
    }
}

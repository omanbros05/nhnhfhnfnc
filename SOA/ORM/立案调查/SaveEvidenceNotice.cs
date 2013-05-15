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
    public partial class SaveEvidenceNotice
    {
        /// <summary>
        /// 获取先行登记保存证据通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SaveEvidenceNotice> SaveEvidenceNoticeGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<SaveEvidenceNotice> SaveEvidenceNotices = new EList<SaveEvidenceNotice>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SaveEvidenceNotice.ToTime >= beginDate.Date && DataBases.SaveEvidenceNotice.ToTime <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.SaveEvidenceNotice.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SaveEvidenceNotice, DataBases.SaveEvidenceNotice.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SaveEvidenceNotices.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SaveEvidenceNotice);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SaveEvidenceNotice.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SaveEvidenceNotice putOnRecord = ReadRow(reader);
                        SaveEvidenceNotices.Items.Add(putOnRecord);
                    }
                }
            }

            return SaveEvidenceNotices;
        }
    }
}

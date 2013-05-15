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
    public partial class HearingNotice
    {
        /// <summary>
        /// 听证会通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<HearingNotice> HearingNoticeGetAll(int page, int pageSize, string docTitle)
        {
            EList<HearingNotice> HearingNotices = new EList<HearingNotice>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.HearingNotice.DocTitle.Like("%" + docTitle + "%"));
            Clips.Add(DataBases.HearingNotice.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.HearingNotice, DataBases.HearingNotice.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            HearingNotices.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.HearingNotice);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.HearingNotice.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        HearingNotice hearingNotice = ReadRow(reader);
                        HearingNotices.Items.Add(hearingNotice);
                    }
                }
            }

            return HearingNotices;
        }
    }
}

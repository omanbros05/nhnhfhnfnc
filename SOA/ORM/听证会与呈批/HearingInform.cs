using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class HearingInform
    {
        /// <summary>
        /// 听证会报告书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<HearingInform> HearingInformGetAll(int page, int pageSize, string docTitle)
        {
            EList<HearingInform> HearingInforms = new EList<HearingInform>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.HearingInform.DocTitle.Like("%" + docTitle + "%"));
            Clips.Add(DataBases.HearingInform.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.HearingInform, DataBases.HearingInform.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            HearingInforms.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.HearingInform);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.HearingInform.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        HearingInform hearingNotice = ReadRow(reader);
                        HearingInforms.Items.Add(hearingNotice);
                    }
                }
            }

            return HearingInforms;
        }
    }
}

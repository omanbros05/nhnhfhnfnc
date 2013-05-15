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
    public partial class SpotHandelDesisionSixtyDay
    {
        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<SpotHandelDesisionSixtyDay> SpotHandelDesisionSixtyDayGetAll(int page, int pageSize, string docTitle)
        {
            EList<SpotHandelDesisionSixtyDay> SpotHandelDesisionSixtyDays = new EList<SpotHandelDesisionSixtyDay>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.SpotHandelDesisionSixtyDay.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.SpotHandelDesisionSixtyDay, DataBases.SpotHandelDesisionSixtyDay.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotHandelDesisionSixtyDays.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotHandelDesisionSixtyDay);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotHandelDesisionSixtyDay.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay = ReadRow(reader);
                        SpotHandelDesisionSixtyDays.Items.Add(spotHandelDesisionSixtyDay);
                    }
                }
            }

            return SpotHandelDesisionSixtyDays;
        }
    }
}

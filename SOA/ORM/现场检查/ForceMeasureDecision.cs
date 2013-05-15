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
    public partial class ForceMeasureDecision
    {
        /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<ForceMeasureDecision> ForceMeasureDecisionGetAll(int page, int pageSize, string docTitle)
        {
            EList<ForceMeasureDecision> ForceMeasureDecisions = new EList<ForceMeasureDecision>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.ForceMeasureDecision.DocTitle.Like("%" + docTitle + "%"));
            Clips.Add(DataBases.ForceMeasureDecision.Status < 2);

            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecision, DataBases.ForceMeasureDecision.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ForceMeasureDecisions.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ForceMeasureDecision);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ForceMeasureDecision.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ForceMeasureDecision forceMeasureDecision = ReadRow(reader);
                        ForceMeasureDecisions.Items.Add(forceMeasureDecision);
                    }
                }
            }

            return ForceMeasureDecisions;
        }
    }
}

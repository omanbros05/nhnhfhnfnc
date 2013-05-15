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
    public partial class ForceMeasureDecisionApprove
    {
        /// <summary>
        /// 强制措施决定审批集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="partyName">当事人姓名</param>
        /// <returns>实体集合</returns>
        internal EList<ForceMeasureDecisionApprove> ForceMeasureDecisionApproveGetAll(int page, int pageSize, string partyName)
        {
            EList<ForceMeasureDecisionApprove> ForceMeasureDecisionApproves = new EList<ForceMeasureDecisionApprove>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (partyName != "")
                Clips.Add(DataBases.ForceMeasureDecisionApprove.Party.Like("%" + partyName + "%"));

            SelectSqlSection section = DB.Select(DataBases.ForceMeasureDecisionApprove, DataBases.ForceMeasureDecisionApprove.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ForceMeasureDecisionApproves.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ForceMeasureDecisionApprove);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ForceMeasureDecisionApprove.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ForceMeasureDecisionApprove forceMeasureDecisionApprove = ReadRow(reader);
                        ForceMeasureDecisionApproves.Items.Add(forceMeasureDecisionApprove);
                    }
                }
            }

            return ForceMeasureDecisionApproves;
        }
    }
}

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
    public partial class ContributeFineApproval
    {
        /// <summary>
        /// 获取延期（分期）缴纳罚款审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<ContributeFineApproval> ContributeFineApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<ContributeFineApproval> Objs = new EList<ContributeFineApproval>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.ContributeFineApproval.FormDate >= beginDate.Date && DataBases.ContributeFineApproval.FormDate <= endDate.AddDays(1).Date);

            SelectSqlSection section = DB.Select(DataBases.ContributeFineApproval, DataBases.ContributeFineApproval.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ContributeFineApproval);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ContributeFineApproval.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ContributeFineApproval Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

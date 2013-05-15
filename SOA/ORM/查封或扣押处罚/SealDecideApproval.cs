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
    public partial class SealDecideApproval
    {
        /// <summary>
        /// 查封（扣押）决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SealDecideApproval> SealDecideApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<SealDecideApproval> Objs = new EList<SealDecideApproval>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SealDecideApproval.HandleDate >= beginDate.Date && DataBases.SealDecideApproval.HandleDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.SealDecideApproval.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SealDecideApproval, DataBases.SealDecideApproval.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SealDecideApproval);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SealDecideApproval.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SealDecideApproval Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

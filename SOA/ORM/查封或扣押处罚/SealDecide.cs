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
    public partial class SealDecide
    {
        /// <summary>
        /// 查封（扣押）决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SealDecide> SealDecideByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<SealDecide> Objs = new EList<SealDecide>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SealDecide.HandleDate >= beginDate.Date && DataBases.SealDecide.HandleDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.SealDecide.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SealDecide, DataBases.SealDecide.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SealDecide);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SealDecide.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SealDecide Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

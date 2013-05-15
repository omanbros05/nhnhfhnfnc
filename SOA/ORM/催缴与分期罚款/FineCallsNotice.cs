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
    public partial class FineCallsNotice
    {
        /// <summary>
        /// 获取罚款催缴通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<FineCallsNotice> FineCallsNoticeByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<FineCallsNotice> Objs = new EList<FineCallsNotice>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.FineCallsNotice.FormDate >= beginDate.Date && DataBases.FineCallsNotice.FormDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.FineCallsNotice.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.FineCallsNotice, DataBases.FineCallsNotice.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.FineCallsNotice);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.FineCallsNotice.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        FineCallsNotice Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

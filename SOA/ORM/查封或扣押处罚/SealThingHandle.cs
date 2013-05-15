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
    public partial class SealThingHandle
    {
        /// <summary>
        /// 查封（扣押）物品处理决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SealThingHandle> SealThingHandleByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<SealThingHandle> Objs = new EList<SealThingHandle>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SealThingHandle.HandleDate >= beginDate.Date && DataBases.SealThingHandle.HandleDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.SealThingHandle.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SealThingHandle, DataBases.SealThingHandle.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SealThingHandle);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SealThingHandle.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SealThingHandle Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

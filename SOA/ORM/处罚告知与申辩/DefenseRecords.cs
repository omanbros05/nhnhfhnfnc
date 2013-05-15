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
    public partial class DefenseRecords
    {
        /// <summary>
        /// 当事人陈诉申辩笔录
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<DefenseRecords> DefenseRecordsByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<DefenseRecords> Objs = new EList<DefenseRecords>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.DefenseRecords.DefenseDate >= beginDate.Date && DataBases.DefenseRecords.DefenseDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.DefenseRecords.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.DefenseRecords, DataBases.DefenseRecords.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.DefenseRecords);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.DefenseRecords.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        DefenseRecords Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

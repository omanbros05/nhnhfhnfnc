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
    public partial class CaseTransferred
    {
        /// <summary>
        /// 案件移送表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<CaseTransferred> CaseTransferredByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<CaseTransferred> Objs = new EList<CaseTransferred>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.CaseTransferred.HandleDate >= beginDate.Date && DataBases.CaseTransferred.HandleDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.CaseTransferred.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.CaseTransferred, DataBases.CaseTransferred.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.CaseTransferred);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.CaseTransferred.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CaseTransferred Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

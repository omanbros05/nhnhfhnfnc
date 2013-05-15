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
    public partial class CaseCancel
    {
        /// <summary>
        /// 获取案件终止（撤销）审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<CaseCancel> CaseCancelGetAll(int page, int pageSize, string PutOnRecordDocTitle, DateTime beginDate, DateTime endDate)
        {
            EList<CaseCancel> CaseCancels = new EList<CaseCancel>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (PutOnRecordDocTitle != "")
                Clips.Add(DataBases.CaseCancel.PutOnRecordDocTitle.Like("%" + PutOnRecordDocTitle + "%"));
            Clips.Add(DataBases.CaseCancel.UndertakerData >= beginDate.Date && DataBases.CaseCancel.UndertakerData <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.CaseCancel.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.CaseCancel, DataBases.CaseCancel.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            CaseCancels.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.CaseCancel);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.CaseCancel.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CaseCancel putOnRecord = ReadRow(reader);
                        CaseCancels.Items.Add(putOnRecord);
                    }
                }
            }

            return CaseCancels;
        }
    }
}

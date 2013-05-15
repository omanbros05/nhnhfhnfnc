using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    [Synchro]
    public partial class CaseExtensionClosedApprovalToSibling
    {
        /// <summary>
        /// 获取案件延期办结审批表(本级)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<CaseExtensionClosedApprovalToSibling> CaseExtensionClosedApprovalToSiblingByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<CaseExtensionClosedApprovalToSibling> Objs = new EList<CaseExtensionClosedApprovalToSibling>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.CaseExtensionClosedApprovalToSibling.FormDate >= beginDate.Date && DataBases.CaseExtensionClosedApprovalToSibling.FormDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.CaseExtensionClosedApprovalToSibling.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.CaseExtensionClosedApprovalToSibling, DataBases.CaseExtensionClosedApprovalToSibling.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Objs.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.CaseExtensionClosedApprovalToSibling);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.CaseExtensionClosedApprovalToSibling.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CaseExtensionClosedApprovalToSibling Obj = ReadRow(reader);
                        Objs.Items.Add(Obj);
                    }
                }
            }

            return Objs;
        }
    }
}

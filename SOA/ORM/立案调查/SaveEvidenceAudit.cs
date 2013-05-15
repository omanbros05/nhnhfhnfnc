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
    public partial class SaveEvidenceAudit
    {
        /// <summary>
        /// 获取先行登记保存证据审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SaveEvidenceAudit> SaveEvidenceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName)
        {
            EList<SaveEvidenceAudit> SaveEvidenceAudits = new EList<SaveEvidenceAudit>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (PutOnRecordCaseName != "")
                Clips.Add(DataBases.SaveEvidenceAudit.PutOnRecordCaseName.Like("%" + PutOnRecordCaseName + "%"));
            Clips.Add(DataBases.SaveEvidenceAudit.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SaveEvidenceAudit, DataBases.SaveEvidenceAudit.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SaveEvidenceAudits.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SaveEvidenceAudit);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SaveEvidenceAudit.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SaveEvidenceAudit putOnRecord = ReadRow(reader);
                        SaveEvidenceAudits.Items.Add(putOnRecord);
                    }
                }
            }

            return SaveEvidenceAudits;
        }
    }
}

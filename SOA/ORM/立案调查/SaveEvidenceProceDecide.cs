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
    public partial class SaveEvidenceProceDecide
    {
        /// <summary>
        /// 获取先行登记保存证据处理决定书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldECompanyName">企业名称</param>
        /// <returns>实体集合</returns>
        internal EList<SaveEvidenceProceDecide> SaveEvidenceProceDecideGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName)
        {
            EList<SaveEvidenceProceDecide> SaveEvidenceProceDecides = new EList<SaveEvidenceProceDecide>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.SaveEvidenceProceDecide.DocTitle.Like("%" + DocTitle + "%"));
            if (FieldECompanyName != "")
                Clips.Add(DataBases.SaveEvidenceProceDecide.FieldECompanyName.Like("%" + FieldECompanyName + "%"));
            Clips.Add(DataBases.SaveEvidenceProceDecide.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SaveEvidenceProceDecide, DataBases.SaveEvidenceProceDecide.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SaveEvidenceProceDecides.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SaveEvidenceProceDecide);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SaveEvidenceProceDecide.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SaveEvidenceProceDecide putOnRecord = ReadRow(reader);
                        SaveEvidenceProceDecides.Items.Add(putOnRecord);
                    }
                }
            }

            return SaveEvidenceProceDecides;
        }
    }
}

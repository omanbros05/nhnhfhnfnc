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
    public partial class SpotCheck
    {
        /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SpotCheck> SpotCheckGetAll(int page, int pageSize, DateTime beginDate,DateTime endDate)
        {
            EList<SpotCheck> SpotChecks = new EList<SpotCheck>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SpotCheck.CheckStartTime >= beginDate.Date && DataBases.SpotCheck.CheckEndTime <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.SpotCheck.Status < 2);

            SelectSqlSection section = DB.Select(DataBases.SpotCheck, DataBases.SpotCheck.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotChecks.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotCheck);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotCheck.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotCheck spotCheck = ReadRow(reader);
                        SpotChecks.Items.Add(spotCheck);
                    }
                }
            }

            return SpotChecks;
        }

        public override EntityInterface UpdateImportDocument(string docName)
        {
            ImportDocument doc = null;
            SelectSqlSection section = DB.Select(DataBases.ImportDocument).Where(DataBases.ImportDocument.TableName == DataBases.SpotCheck.___GetTableName() && DataBases.ImportDocument.TableID == ID.ToString());
            using (IDataReader reader = section.ToDataReader())
            {
                if (reader.Read())
                    doc = ImportDocument.ReadRow(reader);
            }

            if (doc == null)
            {
                doc = new ImportDocument();
                doc.DiskDocName = Common.CommonInvoke.NewGuid;
                doc.DocName = docName;
                doc.TableName = DataBases.SpotCheck.___GetTableName();
                doc.TableID = ID.ToString();

                doc.Update();
            }

            return doc;
        }
    }
}

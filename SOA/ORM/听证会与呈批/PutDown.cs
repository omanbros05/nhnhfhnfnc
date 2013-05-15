using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;


namespace SOA.ORM
{
    [Synchro]
    public partial class PutDown
    {
        /// <summary>
        /// 听证笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<PutDown> PutDownGetAll(int page, int pageSize, string caseName)
        {
            EList<PutDown> PutDowns = new EList<PutDown>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (caseName != "")
                Clips.Add(DataBases.PutDown.CaseName.Like("%" + caseName + "%"));
            Clips.Add(DataBases.PutDown.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.PutDown, DataBases.PutDown.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            PutDowns.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PutDown);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PutDown.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PutDown putDown = ReadRow(reader);
                        PutDowns.Items.Add(putDown);
                    }
                }
            }

            return PutDowns;
        }
    }
}

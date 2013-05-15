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
    public partial class SpotHandelDesision
    {
        /// <summary>
        /// 获取现场处理措施决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        ///<param name="docTitle">文档号</param>
        /// <returns>实体集合</returns>
        internal EList<SpotHandelDesision> SpotHandelDesisionGetAll(int page, int pageSize, string docTitle)
        {
            EList<SpotHandelDesision> SpotHandelDesisions = new EList<SpotHandelDesision>();

            List<WhereClip> Clips = new List<WhereClip>();
            if(docTitle != "")
                Clips.Add(DataBases.SpotHandelDesision.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.SpotHandelDesision, DataBases.SpotHandelDesision.ID.Count());
            // 只查询未归档的数据
            Clips.Add(DataBases.SpotHandelDesision.Status < 2);
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotHandelDesisions.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotHandelDesision);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotHandelDesision.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotHandelDesision spotHandelDesision = ReadRow(reader);
                        SpotHandelDesisions.Items.Add(spotHandelDesision);
                    }
                }
            }

            return SpotHandelDesisions;
        }
    }
}

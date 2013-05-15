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
    public partial class ReformReView
    {
        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<ReformReView> ReformReViewGetAll(int page, int pageSize, string docTitle)
        {
            EList<ReformReView> ReformReViews = new EList<ReformReView>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.ReformReView.DocTitle.Like("%" + docTitle + "%"));
            // 查询未归档记录
            Clips.Add(DataBases.ReformReView.Status < 2); 

            SelectSqlSection section = DB.Select(DataBases.ReformReView, DataBases.ReformReView.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ReformReViews.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ReformReView);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ReformReView.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ReformReView reformReView = ReadRow(reader);
                        ReformReViews.Items.Add(reformReView);
                    }
                }
            }

            return ReformReViews;
        }
    }
}

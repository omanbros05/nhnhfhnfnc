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
    public partial class OrderDeadlineReform
    {
        /// <summary>
        /// 责令限期整改指令记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<OrderDeadlineReform> OrderDeadlineReformGetAll(int page, int pageSize, string docTitle)
        {
            EList<OrderDeadlineReform> OrderDeadlineReforms = new EList<OrderDeadlineReform>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.OrderDeadlineReform.DocTitle.Like("%" + docTitle + "%"));
            // 仅查询未归档数据
            Clips.Add(DataBases.OrderDeadlineReform.Status < 2);

            SelectSqlSection section = DB.Select(DataBases.OrderDeadlineReform, DataBases.OrderDeadlineReform.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            OrderDeadlineReforms.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.OrderDeadlineReform);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.OrderDeadlineReform.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        OrderDeadlineReform orderDeadlineReform = ReadRow(reader);
                        OrderDeadlineReforms.Items.Add(orderDeadlineReform);
                    }
                }
            }

            return OrderDeadlineReforms;
        }
    }
}

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
    public partial class DocumentsServiceReply
    {
        /// <summary>
        /// 获取文书送达回执集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<DocumentsServiceReply> DocumentsServiceReplyGetAll(int page, int pageSize, string DocTitle)
        {
            EList<DocumentsServiceReply> DocumentsServiceReplys = new EList<DocumentsServiceReply>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.DocumentsServiceReply.DocTitle.Like("%" + DocTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.DocumentsServiceReply, DataBases.DocumentsServiceReply.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            DocumentsServiceReplys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.DocumentsServiceReply);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.DocumentsServiceReply.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        DocumentsServiceReply putOnRecord = ReadRow(reader);
                        DocumentsServiceReplys.Items.Add(putOnRecord);
                    }
                }
            }

            return DocumentsServiceReplys;
        }
    }
}

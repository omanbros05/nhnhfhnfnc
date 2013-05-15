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
    public partial class NoticeOfEnquiry
    {
        /// <summary>
        /// 获取询问通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<NoticeOfEnquiry> NoticeOfEnquiryGetAll(int page, int pageSize, string DocTitle, string CompanyName)
        {
            EList<NoticeOfEnquiry> NoticeOfEnquirys = new EList<NoticeOfEnquiry>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.NoticeOfEnquiry.DocTitle.Like("%" + DocTitle + "%"));
            if (CompanyName != "")
                Clips.Add(DataBases.NoticeOfEnquiry.CompanyName.Like("%" + CompanyName + "%"));
            Clips.Add(DataBases.NoticeOfEnquiry.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.NoticeOfEnquiry, DataBases.NoticeOfEnquiry.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            NoticeOfEnquirys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.NoticeOfEnquiry);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.NoticeOfEnquiry.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        NoticeOfEnquiry putOnRecord = ReadRow(reader);
                        NoticeOfEnquirys.Items.Add(putOnRecord);
                    }
                }
            }

            return NoticeOfEnquirys;
        }
    }
}

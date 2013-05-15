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
    public partial class AppraisalEntrust
    {
        public List<SamplingContent> Items = new List<SamplingContent>();
        protected override void EndInit()
        {
            base.EndInit();

            Items.Clear();
            SelectSqlSection section = DB.Select(DataBases.SamplingContent).Where(DataBases.SamplingContent.SamplingID == ID);
            using (IDataReader reader = section.ToDataReader())
            {
                while (reader.Read())
                {
                    SamplingContent item = SamplingContent.ReadRow(reader);
                    Items.Add(item);
                }
            }
        }
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<AppraisalEntrust> AppraisalEntrustGetAll(int page, int pageSize, string DocTitle, string AppraisalUnit)
        {
            EList<AppraisalEntrust> AppraisalEntrusts = new EList<AppraisalEntrust>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.AppraisalEntrust.DocTitle.Like("%" + DocTitle + "%"));
            if (AppraisalUnit != "")
                Clips.Add(DataBases.AppraisalEntrust.AppraisalUnit.Like("%" + AppraisalUnit + "%"));
            Clips.Add(DataBases.AppraisalEntrust.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.AppraisalEntrust, DataBases.AppraisalEntrust.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            AppraisalEntrusts.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.AppraisalEntrust);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.AppraisalEntrust.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        AppraisalEntrust putOnRecord = ReadRow(reader);
                        AppraisalEntrusts.Items.Add(putOnRecord);
                    }
                }
            }

            return AppraisalEntrusts;
        }
    }
}

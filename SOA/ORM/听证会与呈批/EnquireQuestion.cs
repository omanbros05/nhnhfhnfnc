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
    public partial class EnquireQuestion
    {
        /// <summary>
        /// 问答项
        /// </summary>
        public List<EnquireQuestionItem> Items = new List<EnquireQuestionItem>();

        protected override void EndInit()
        {
            base.EndInit();

            Items.Clear();
            using (IDataReader reader = DB.Select(DataBases.EnquireQuestionItem).Where(DataBases.EnquireQuestionItem.EnquireID == ID).ToDataReader())
            {
                while (reader.Read())
                {
                    Items.Add(EnquireQuestionItem.ReadRow(reader));
                }
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            DB.Delete(DataBases.EnquireQuestionItem).Where(DataBases.EnquireQuestionItem.EnquireID == ID).SetTransaction(trans).Execute();

            foreach (EnquireQuestionItem item in Items)
            {
                item.EnquireID = ID;
                item.SystemService = this.SystemService;
                item.SQLtransaction = this.SQLtransaction;
                item.IsExists = false;
                item.IsInit = false;
                item.Update();
            }
        }

        /// <summary>
        /// 获取询问笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<EnquireQuestion> EnquireQuestionGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<EnquireQuestion> EnquireQuestions = new EList<EnquireQuestion>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.EnquireQuestion.EnquireBeginDate >= beginDate.Date && DataBases.EnquireQuestion.EnquireEndDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.EnquireQuestion.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.EnquireQuestion, DataBases.EnquireQuestion.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            EnquireQuestions.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.EnquireQuestion);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.EnquireQuestion.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        EnquireQuestion enquireQuestion = ReadRow(reader);
                        EnquireQuestions.Items.Add(enquireQuestion);
                    }
                }
            }

            return EnquireQuestions;
        }
    }
}

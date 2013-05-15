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
    public partial class PutOnRecord
    {
        public override string SearchColumn()
        {
            return CaseName;
        }
        /// <summary>
        /// 获取立案审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<PutOnRecord> PutOnRecordGetAll(int page, int pageSize, string DocTitle, DateTime beginDate, DateTime endDate)
        {
            EList<PutOnRecord> PutOnRecords = new EList<PutOnRecord>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.PutOnRecord.DocTitle.Like("%" + DocTitle + "%"));
            Clips.Add(DataBases.PutOnRecord.ThisDate >= beginDate.Date && DataBases.PutOnRecord.ThisDate <= endDate.AddDays(1).Date);
            Clips.Add(DataBases.PutOnRecord.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.PutOnRecord, DataBases.PutOnRecord.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            PutOnRecords.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PutOnRecord);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PutOnRecord.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PutOnRecord putOnRecord = ReadRow(reader);
                        PutOnRecords.Items.Add(putOnRecord);
                    }
                }
            }

            return PutOnRecords;
        }


        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<PutOnRecord>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

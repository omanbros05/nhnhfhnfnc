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
    public partial class Sampling
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
        /// 获取抽样取证凭证集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<Sampling> SamplingGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName)
        {
            EList<Sampling> Samplings = new EList<Sampling>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.Sampling.DocTitle.Like("%" + DocTitle + "%"));
            if (FieldECompanyName != "")
                Clips.Add(DataBases.Sampling.FieldECompanyName.Like("%" + FieldECompanyName + "%"));
            Clips.Add(DataBases.Sampling.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.Sampling, DataBases.Sampling.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Samplings.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.Sampling);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.Sampling.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Sampling putOnRecord = ReadRow(reader);
                        Samplings.Items.Add(putOnRecord);
                    }
                }
            }

            return Samplings;
        }
        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            DB.Delete(DataBases.SamplingContent)
                .Where(DataBases.SamplingContent.SamplingID == ID)
                .SetTransaction(trans).Execute();

            foreach (SamplingContent item in Items)
            {
                item.SystemService = this.SystemService;
                item.IsExists = false;
                item.SamplingID = ID;
                item.SQLtransaction = this.SQLtransaction;
                item.Update();
            }

        }

        protected override void BeginRemove(DbTransaction trans)
        {
            base.BeginRemove(trans);

            DB.Delete(DataBases.SamplingContent)
                .Where(DataBases.SamplingContent.SamplingID == ID)
                .SetTransaction(trans).Execute();
        }

        /// <summary>
        /// 取抽样取证凭证表文号
        /// </summary>
        /// <param name="SamplingID">编号</param>
        /// <returns></returns>
        internal string GetSamplingDocTitle(int SamplingID)
        {
            SelectSqlSection section = DB.Select(DataBases.Sampling, DataBases.Sampling.DocTitle);
            section.Where(DataBases.Sampling.ID == SamplingID);
            DataTable table = section.ToDataSet().Tables[0];
            if (table.Rows.Count > 0)
                return table.Rows[0][0].ToString();
            return "";
        }
        /// <summary>
        /// 取抽样取证凭证表编号
        /// </summary>
        /// <param name="SamplingDocTitle">文号</param>
        /// <returns></returns>
        internal int GetSamplingID(string SamplingDocTitle)
        {
            SelectSqlSection section = DB.Select(DataBases.Sampling, DataBases.Sampling.ID);
            section.Where(DataBases.Sampling.DocTitle == SamplingDocTitle);
            DataTable table = section.ToDataSet().Tables[0];
            if (table.Rows.Count > 0)
                return (int)table.Rows[0][0];
            return 0;
        }
    }
}

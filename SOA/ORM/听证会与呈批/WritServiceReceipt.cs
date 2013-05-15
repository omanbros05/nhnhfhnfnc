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
    public partial class WritServiceReceipt
    {
        public List<WritServiceReceiptItem> Items = new List<WritServiceReceiptItem>();

        protected override void EndInit()
        {
            base.EndInit();

            Items.Clear();
            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.WritServiceReceiptItem.ReceiptID == ID);
            Clips.Add(DataBases.WritServiceReceiptItem.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.WritServiceReceiptItem).Where(Clips);
            using (IDataReader reader = section.ToDataReader())
            {
                while (reader.Read())
                {
                    WritServiceReceiptItem item = WritServiceReceiptItem.ReadRow(reader);
                    Items.Add(item);
                }
            }
        }

        /// <summary>
        /// 文书送达回执记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<WritServiceReceipt> WritServiceReceiptGetAll(int page, int pageSize, string docTitle)
        {
            EList<WritServiceReceipt> WritServiceReceipts = new EList<WritServiceReceipt>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.WritServiceReceipt.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.WritServiceReceipt, DataBases.WritServiceReceipt.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            WritServiceReceipts.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.WritServiceReceipt);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.WritServiceReceipt.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        WritServiceReceipt hearingNotice = ReadRow(reader);
                        WritServiceReceipts.Items.Add(hearingNotice);
                    }
                }
            }

            return WritServiceReceipts;
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            DB.Delete(DataBases.WritServiceReceiptItem)
                .Where(DataBases.WritServiceReceiptItem.ReceiptID == ID)
                .SetTransaction(trans).Execute();

            foreach (WritServiceReceiptItem item in Items)
            {
                item.SystemService = this.SystemService;
                item.IsExists = false;
                item.ReceiptID = ID;
                item.SQLtransaction = this.SQLtransaction;
                item.Update();
            }

        }

        protected override void BeginRemove(DbTransaction trans)
        {
            base.BeginRemove(trans);

            DB.Delete(DataBases.WritServiceReceiptItem)
                .Where(DataBases.WritServiceReceiptItem.ReceiptID == ID)
                .SetTransaction(trans).Execute();
        }
    }
}

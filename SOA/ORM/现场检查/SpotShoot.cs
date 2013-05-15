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
    public partial class SpotShoot
    {
        public List<SpotShootItem> Items = new List<SpotShootItem>();

        protected override void EndInit()
        {
            base.EndInit();

            Items.Clear();
            using (IDataReader reader = DB.Select(DataBases.SpotShootItem).Where(DataBases.SpotShootItem.SpotID == ID).ToDataReader())
            {
                while (reader.Read())
                {
                    SpotShootItem item = SpotShootItem.ReadRow(reader);
                    Items.Add(item);
                }
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            DB.Delete(DataBases.SpotShootItem).Where(DataBases.SpotShootItem.SpotID == ID).SetTransaction(trans).Execute();

            foreach (SpotShootItem item in Items)
            {
                item.SystemService = this.SystemService;
                item.SQLtransaction = this.SQLtransaction;
                item.SpotID = ID;
                item.IsInit = false;
                item.IsExists = false;
                item.Update();
            }
        }

        /// <summary>
        /// 获取现场照片记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SpotShoot> SpotShootGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            EList<SpotShoot> SpotShoots = new EList<SpotShoot>();

            List<WhereClip> Clips = new List<WhereClip>();
            Clips.Add(DataBases.SpotShoot.ShootDate >= beginDate.Date && DataBases.SpotShoot.ShootDate <= endDate.AddDays(1).Date);

            SelectSqlSection section = DB.Select(DataBases.SpotShoot, DataBases.SpotShoot.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotShoots.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotShoot);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotShoot.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotShoot spotCheck = ReadRow(reader);
                        SpotShoots.Items.Add(spotCheck);
                    }
                }
            }

            return SpotShoots;
        }
    }
}

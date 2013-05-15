using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    public partial class PowerInventory
    {
        /// <summary>
        /// 权力清单类型
        /// </summary>
        public enum EPowerType
        {
            行政处罚 = 0,
            行政强制,
        }

        /// <summary>
        /// 获取权力清单集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="Name">权力名称</param>
        /// <param name="PowerType">权力类型</param>
        /// <returns>实体集合</returns>
        internal EList<PowerInventory> PowerGetAll(int page, int pageSize, string Name, int PowerType)
        {
            EList<PowerInventory> Powers = new EList<PowerInventory>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (Name != "")
            {
                Clips.Add(DataBases.PowerInventory.PowerName.Like("%" + Name + "%"));
            }
            if (PowerType != -1)
            {
                Clips.Add(DataBases.PowerInventory.PowerType == PowerType);
            }
            SelectSqlSection section = DB.Select(DataBases.PowerInventory, DataBases.PowerInventory.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Powers.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PowerInventory);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PowerInventory.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PowerInventory areaCode = ReadRow(reader);
                        Powers.Items.Add(areaCode);
                    }
                }
            }

            return Powers;
        }
    }
}

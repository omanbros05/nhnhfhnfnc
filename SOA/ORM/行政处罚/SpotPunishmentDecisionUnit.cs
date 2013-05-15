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
    public partial class SpotPunishmentDecisionUnit
    {
        /// <summary>
        /// 获取行政当场处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        internal EList<SpotPunishmentDecisionUnit> SpotPunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName)
        {
            EList<SpotPunishmentDecisionUnit> SpotPunishmentDecisionUnits = new EList<SpotPunishmentDecisionUnit>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.SpotPunishmentDecisionUnit.DocTitle.Like("%" + DocTitle + "%"));
            if (PutOnRecordCompanyName != "")
                Clips.Add(DataBases.SpotPunishmentDecisionUnit.PutOnRecordCompanyName.Like("%" + PutOnRecordCompanyName + "%"));
            Clips.Add(DataBases.SpotPunishmentDecisionUnit.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SpotPunishmentDecisionUnit, DataBases.SpotPunishmentDecisionUnit.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotPunishmentDecisionUnits.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotPunishmentDecisionUnit);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotPunishmentDecisionUnit.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotPunishmentDecisionUnit putOnRecord = ReadRow(reader);
                        SpotPunishmentDecisionUnits.Items.Add(putOnRecord);
                    }
                }
            }

            return SpotPunishmentDecisionUnits;
        }
    }
}

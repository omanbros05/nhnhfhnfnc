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
    public partial class SpotPunishmentDecisionPersonal
    {
        /// <summary>
        /// 获取行政当场处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        internal EList<SpotPunishmentDecisionPersonal> SpotPunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName)
        {
            EList<SpotPunishmentDecisionPersonal> SpotPunishmentDecisionPersonals = new EList<SpotPunishmentDecisionPersonal>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.SpotPunishmentDecisionPersonal.DocTitle.Like("%" + DocTitle + "%"));
            if (FieldEPeopleName != "")
                Clips.Add(DataBases.SpotPunishmentDecisionPersonal.FieldEPeopleName.Like("%" + FieldEPeopleName + "%"));
            Clips.Add(DataBases.SpotPunishmentDecisionPersonal.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SpotPunishmentDecisionPersonal, DataBases.SpotPunishmentDecisionPersonal.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SpotPunishmentDecisionPersonals.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SpotPunishmentDecisionPersonal);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SpotPunishmentDecisionPersonal.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SpotPunishmentDecisionPersonal putOnRecord = ReadRow(reader);
                        SpotPunishmentDecisionPersonals.Items.Add(putOnRecord);
                    }
                }
            }

            return SpotPunishmentDecisionPersonals;
        }
    }
}

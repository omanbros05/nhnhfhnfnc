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
    public partial class PunishmentDecisionPersonal
    {
        /// <summary>
        /// 获取行政处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        internal EList<PunishmentDecisionPersonal> PunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName)
        {
            EList<PunishmentDecisionPersonal> PunishmentDecisionPersonals = new EList<PunishmentDecisionPersonal>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.PunishmentDecisionPersonal.DocTitle.Like("%" + DocTitle + "%"));
            if (FieldEPeopleName != "")
                Clips.Add(DataBases.PunishmentDecisionPersonal.FieldEPeopleName.Like("%" + FieldEPeopleName + "%"));
            Clips.Add(DataBases.PunishmentDecisionPersonal.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.PunishmentDecisionPersonal, DataBases.PunishmentDecisionPersonal.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            PunishmentDecisionPersonals.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PunishmentDecisionPersonal);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PunishmentDecisionPersonal.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PunishmentDecisionPersonal putOnRecord = ReadRow(reader);
                        PunishmentDecisionPersonals.Items.Add(putOnRecord);
                    }
                }
            }

            return PunishmentDecisionPersonals;
        }
    }
}

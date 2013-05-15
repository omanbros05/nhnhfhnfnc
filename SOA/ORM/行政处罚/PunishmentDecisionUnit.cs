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
    public partial class PunishmentDecisionUnit
    {
        /// <summary>
        /// 获取行政处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        internal EList<PunishmentDecisionUnit> PunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName)
        {
            EList<PunishmentDecisionUnit> PunishmentDecisionUnits = new EList<PunishmentDecisionUnit>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.PunishmentDecisionUnit.DocTitle.Like("%" + DocTitle + "%"));
            if (PutOnRecordCompanyName != "")
                Clips.Add(DataBases.PunishmentDecisionUnit.PutOnRecordCaseName.Like("%" + PutOnRecordCompanyName + "%"));
            Clips.Add(DataBases.PunishmentDecisionUnit.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.PunishmentDecisionUnit, DataBases.PunishmentDecisionUnit.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            PunishmentDecisionUnits.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.PunishmentDecisionUnit);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.PunishmentDecisionUnit.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        PunishmentDecisionUnit putOnRecord = ReadRow(reader);
                        PunishmentDecisionUnits.Items.Add(putOnRecord);
                    }
                }
            }

            return PunishmentDecisionUnits;
        }
    }
}

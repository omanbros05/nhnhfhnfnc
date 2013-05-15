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
    public partial class ChemicalsHighlyToxic
    {
        /// <summary>
        /// 剧毒化学品目录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="ChemicalName">化学名</param>
        /// <param name="ChemicalAlias">别名</param>
        /// <returns></returns>
        internal EList<ChemicalsHighlyToxic> ChemicalsHighlyToxicGetAll(int page, int pageSize, string ChemicalName, string ChemicalAlias)
        {
            EList<ChemicalsHighlyToxic> ChemicalsHighlyToxics = new EList<ChemicalsHighlyToxic>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (ChemicalName != "")
            {
                Clips.Add(DataBases.ChemicalsHighlyToxic.ChemicalName.Like("%" + ChemicalName + "%"));
            }
            if (ChemicalAlias != "")
            {
                Clips.Add(DataBases.ChemicalsHighlyToxic.ChemicalAlias.Like("%" + ChemicalAlias + "%"));
            }

            SelectSqlSection section = DB.Select(DataBases.ChemicalsHighlyToxic, DataBases.ChemicalsHighlyToxic.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ChemicalsHighlyToxics.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ChemicalsHighlyToxic);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ChemicalsHighlyToxic.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ChemicalsHighlyToxic ChemicalsHighlyToxic = ReadRow(reader);
                        ChemicalsHighlyToxics.Items.Add(ChemicalsHighlyToxic);
                    }
                }
            }

            return ChemicalsHighlyToxics;
        }
    }
}

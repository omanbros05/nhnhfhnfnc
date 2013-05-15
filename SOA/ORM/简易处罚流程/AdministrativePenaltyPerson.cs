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
    public partial class AdministrativePenaltyPerson
    {
        /// <summary>
        /// 行政处罚决定书(个人)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<AdministrativePenaltyPerson> AdministrativePenaltyPersonGetAll(int page, int pageSize, string docTitle)
        {
            EList<AdministrativePenaltyPerson> AdministrativePenaltyPersons = new EList<AdministrativePenaltyPerson>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.AdministrativePenaltyPerson.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.AdministrativePenaltyPerson, DataBases.AdministrativePenaltyPerson.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            AdministrativePenaltyPersons.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.AdministrativePenaltyPerson);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.AdministrativePenaltyPerson.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        AdministrativePenaltyPerson sdministrativePenaltyCompany = ReadRow(reader);
                        AdministrativePenaltyPersons.Items.Add(sdministrativePenaltyCompany);
                    }
                }
            }

            return AdministrativePenaltyPersons;
        }
    }
}

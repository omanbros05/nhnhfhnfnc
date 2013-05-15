using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    public partial class CompanyArea
    {
        /// <summary>
        /// 地区实体
        /// </summary>
        /// <param name="name">地区名称</param>
        /// <returns>实体</returns>
        internal CompanyArea CompanyAreaGetOne(string name)
        {
            CompanyArea CompanyArea = new ORM.CompanyArea();

            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
            {
                Clips.Add(DataBases.CompanyArea.AreaName.Like("%" + name + "%"));
            }
            SelectSqlSection section = DB.Select(DataBases.CompanyArea, DataBases.CompanyArea.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            if (count > 0)
            {
                section = DB.Select(DataBases.CompanyArea);
                if (Clips.Count > 0)
                    section.Where(Clips);
                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CompanyArea = ReadRow(reader);
                    }
                }
            }
            return CompanyArea;
        }

        /// <summary>
        /// 地区集合
        /// </summary>
        /// <returns>实体集合</returns>
        internal EList<CompanyArea> CompanyAreaGetAll()
        {
            EList<CompanyArea> CompanyAreas = new EList<CompanyArea> { };

            SelectSqlSection section = DB.Select(DataBases.CompanyArea, DataBases.CompanyArea.ID.Count());
            int count = Convert.ToInt32(section.ToScalar());
            if (count > 0)
            {
                section = DB.Select(DataBases.CompanyArea);
                //section.SetSelectRange(1, 100, DataBases.CompanyArea.ID);
                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CompanyArea area = ReadRow(reader);
                        CompanyAreas.Items.Add(area);
                    }
                }
            }
            return CompanyAreas;
        }
    }
}

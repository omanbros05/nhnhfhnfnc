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
    public partial class LawFile
    {
        public enum ELawType
        { 
            综合 = 0,
            事故调查处理,
            危险化学品安全,
            烟花爆竹安全,
            矿山安全,
            宣传教育,//宣传教育、培训考核
            职业卫生安全,
            劳动防护用品,
            标准,
        }
        /// <summary>
        /// 法律法规
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<LawFile> LawFileGetAll(int page, int pageSize, string LawFileTitle,int LawType)
        {
            EList<LawFile> LawFiles = new EList<LawFile>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (LawFileTitle != "")
            {
                Clips.Add(DataBases.LawFile.LawTitle.Like("%" + LawFileTitle + "%"));
            }
            if (LawType >= (int)SOA.ORM.LawFile.ELawType.综合)
            {
                Clips.Add(DataBases.LawFile.LawType == LawType);
            }
            SelectSqlSection section = DB.Select(DataBases.LawFile, DataBases.LawFile.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            LawFiles.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.LawFile);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.LawFile.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        LawFile LawFile = ReadRow(reader);
                        LawFiles.Items.Add(LawFile);
                    }
                }
            }

            return LawFiles;
        }
    }
}

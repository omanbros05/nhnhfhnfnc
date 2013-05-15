using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    public partial class InstrumentsHistoryFolder
    {
        /// <summary>
        /// 历史文书的文件夹集合
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="ParentType"></param>
        /// <param name="ChildType"></param>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        internal EList<InstrumentsHistoryFolder> InstrumentsHistoryFolderGetAll(int page, int pageSize, int ParentType, int ChildType, int Year, int Month)
        {
            EList<InstrumentsHistoryFolder> InstrumentsHistoryFolders = new EList<InstrumentsHistoryFolder>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (ParentType >= (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                Clips.Add(DataBases.InstrumentsHistoryFolder.InstrumentsParentType == ParentType);
            }
            if (ChildType >= (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场检查记录)
            {
                Clips.Add(DataBases.InstrumentsHistoryFolder.InstrumentsChildType == ChildType);
            }
            if (Year >= -1)
            {
                Clips.Add(DataBases.InstrumentsHistoryFolder.InstrumentsYear == Year);
            }
            if (Month >= -1)
            {
                Clips.Add(DataBases.InstrumentsHistoryFolder.InstrumentsMonth == Month);
            }
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFolder, DataBases.InstrumentsHistoryFolder.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            InstrumentsHistoryFolders.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.InstrumentsHistoryFolder);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.InstrumentsHistoryFolder.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        InstrumentsHistoryFolder InstrumentsHistoryFolder = ReadRow(reader);
                        InstrumentsHistoryFolders.Items.Add(InstrumentsHistoryFolder);
                    }
                }
            }

            return InstrumentsHistoryFolders;
        }
    }
}

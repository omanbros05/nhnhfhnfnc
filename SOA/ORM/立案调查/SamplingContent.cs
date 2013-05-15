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
    public partial class SamplingContent
    {
        /// <summary>
        /// 取物品内容
        /// </summary>
        /// <param name="SamplingID">抽样取证凭证编号</param>
        /// <returns></returns>
        internal List<SamplingContent> GetSamplingContentAll(int SamplingID)
        {
            List<SamplingContent> Items = new List<SamplingContent>();
            List<WhereClip> clips = new List<WhereClip>();
            clips.Add(DataBases.SamplingContent.SamplingID == SamplingID);
            clips.Add(DataBases.SamplingContent.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SamplingContent).Where(clips);
            using (IDataReader reader = section.ToDataReader())
            {
                while (reader.Read())
                {
                    SamplingContent item = SamplingContent.ReadRow(reader);
                    Items.Add(item);
                }
            }
            return Items;
        }
    }
}

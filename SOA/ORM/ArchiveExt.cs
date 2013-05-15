using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NBearLite;
using System.Data;

namespace SOA.ORM
{
    [Synchro]
    public partial class ArchiveExtEntity
    {
        internal EList<ArchiveExtEntity> ArchiveExtGetAll(int archiveID) {
            
            EList<ArchiveExtEntity> archiveExts = new EList<ArchiveExtEntity>();

            List<WhereClip> clips = new List<WhereClip>();
            clips.Add(DataBases.ArchiveExt.ArchiveID == archiveID);
            SelectSqlSection section = DB.Select(DataBases.ArchiveExt);
            section.Where(clips);
            section.OrderBy(new OrderByClip(new ExpressionClip("createtime", DbType.DateTime), true));
            using (IDataReader reader = section.ToDataReader()) {
                while (reader.Read()) {

                    ArchiveExtEntity entity = ReadRow(reader);
                    entity.CreateTime = (DateTime)reader["CreateTime"];
                    archiveExts.Items.Add(entity);
                }
            }

            return archiveExts;
        }
    }
}

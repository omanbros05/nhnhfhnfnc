using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NBearLite;
using System.Data.Common;
using System.Data;

namespace SOA.ORM
{
    [Synchro]
    public partial class Archive {

        internal EList<Archive> ArchiveGetAll() {

            EList<Archive> archives = new EList<Archive>();
            SelectSqlSection section = DB.Select(DataBases.Archive);
            section.OrderBy(new OrderByClip(new ExpressionClip("CreateTimes", DbType.DateTime), true));
            using (IDataReader reader = section.ToDataReader()) {

                while (reader.Read()) {

                    Archive entity = ReadRow(reader);
                    entity.CreateTimes = (DateTime)reader["CreateTimes"];
                    entity.Status = (Byte)reader["Status"];
                    archives.Items.Add(entity);
                }
            }
            // 获取所有顶级目录
            // SELECT * FROM archive WHERE parent = 0;
            // 根据顶级ID获取子集
            // SELECT * FROM archive WHERE parent = [PARENT_ID];

            return archives;
        }
    }
}

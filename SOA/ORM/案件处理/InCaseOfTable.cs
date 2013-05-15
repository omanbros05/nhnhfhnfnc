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
    public partial class InCaseOfTable
    {
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <returns>实体集合</returns>
        internal EList<InCaseOfTable> InCaseOfTableGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCaseName)
        {
            EList<InCaseOfTable> InCaseOfTables = new EList<InCaseOfTable>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (DocTitle != "")
                Clips.Add(DataBases.InCaseOfTable.DocTitle.Like("%" + DocTitle + "%"));
            if (PutOnRecordCaseName != "")
                Clips.Add(DataBases.InCaseOfTable.PutOnRecordCaseName.Like("%" + PutOnRecordCaseName + "%"));
            Clips.Add(DataBases.InCaseOfTable.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.InCaseOfTable, DataBases.InCaseOfTable.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            InCaseOfTables.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.InCaseOfTable);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.InCaseOfTable.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        InCaseOfTable inCaseOfTable = ReadRow(reader);
                        InCaseOfTables.Items.Add(inCaseOfTable);
                    }
                }
            }

            return InCaseOfTables;
        }
    }
}

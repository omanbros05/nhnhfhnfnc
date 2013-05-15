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
    public partial class CaseSource
    {
        public override string SearchColumn()
        {
            return SourceName;
        }

        /// <summary>
        /// 根据名称更新案件来源
        /// </summary>
        /// <param name="caseSource">案件来源对象</param>
        internal void UpdateCaseSourceByName(CaseSource caseSource)
        {
            if (caseSource.SourceName == "")
                return;

            CaseSource databaseCaseSource = null;
            using (IDataReader reader = DB.Select(DataBases.CaseSource).Where(DataBases.CaseSource.SourceName == caseSource.SourceName).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseCaseSource = ReadRow(reader);
                }
            }

            if (databaseCaseSource != null)
            {
                if (caseSource.SourceName != "")
                    databaseCaseSource.SourceName = caseSource.SourceName;
                databaseCaseSource.SystemService = this.SystemService;
                databaseCaseSource.SQLtransaction = this.SQLtransaction;
                databaseCaseSource.Update();
            }
            else
            {
                caseSource.SystemService = this.SystemService;
                caseSource.SQLtransaction = this.SQLtransaction;
                caseSource.Update();
            }
        }

        /// <summary>
        /// 获取案件来源表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">名称</param>
        /// <returns>实体集合</returns>
        internal EList<CaseSource> CaseSourceGetAll(int page, int pageSize, string SourceName)
        {
            EList<CaseSource> CaseSources = new EList<CaseSource>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (SourceName != "")
                Clips.Add(DataBases.CaseSource.SourceName.Like("%" + SourceName + "%"));

            SelectSqlSection section = DB.Select(DataBases.CaseSource, DataBases.CaseSource.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            CaseSources.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.CaseSource);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.CaseSource.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CaseSource illegalType = ReadRow(reader);
                        CaseSources.Items.Add(illegalType);
                    }
                }
            }

            return CaseSources;
        }
        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<CaseSource>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

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
    public partial class SurveyEndReport
    {
        /// <summary>
        /// 行政处罚案件调查终结报告列表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<SurveyEndReport> SurveyEndReportGetAll(int page, int pageSize, string docTitle)
        {
            EList<SurveyEndReport> SurveyEndReports = new EList<SurveyEndReport>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.SurveyEndReport.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.SurveyEndReport, DataBases.SurveyEndReport.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SurveyEndReports.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SurveyEndReport);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SurveyEndReport.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SurveyEndReport surveyEndReport = ReadRow(reader);
                        SurveyEndReports.Items.Add(surveyEndReport);
                    }
                }
            }

            return SurveyEndReports;
        }
    }
}

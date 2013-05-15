using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    [Synchro]
    public partial class CompanyHighlyToxicChemicals
    {
        public Company Company = new Company();
        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        internal EList<CompanyHighlyToxicChemicals> CompanyHighlyToxicChemicalsGetAll(int page, int pageSize, string name, int IsCity, int AreaID)
        {
            EList<CompanyHighlyToxicChemicals> Companys = new EList<CompanyHighlyToxicChemicals>();
            SelectSqlSection section = DB.Select(DataBases.CompanyHighlyToxicChemicals, DataBases.CompanyHighlyToxicChemicals.ID.Count());
            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
            {
                Clips.Add(DataBases.Company.CompanyName.Like("%" + name + "%"));
            }
            if (IsCity >= 0)
            {
                Clips.Add(DataBases.Company.IsCity == IsCity);
            }
            if (AreaID >= 0)
            {
                Clips.Add(DataBases.Company.CompanyAreaID == AreaID);
            }

            if (Clips.Count > 0)
            {
                section.Where(DataBases.CompanyHighlyToxicChemicals.CompanyID.In(DB.Select(DataBases.Company, DataBases.Company.CompanyID).Where(Clips).ToSubQuery()));
            }

            int count = Convert.ToInt32(section.ToScalar());
            Companys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.CompanyHighlyToxicChemicals);
                if (Clips.Count > 0)
                {
                    section.Where(DataBases.CompanyHighlyToxicChemicals.CompanyID.In(DB.Select(DataBases.Company, DataBases.Company.CompanyID).Where(Clips).ToSubQuery()));
                }

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.CompanyHighlyToxicChemicals.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        CompanyHighlyToxicChemicals areaCode = ReadRow(reader);
                        Companys.Items.Add(areaCode);
                    }
                }
                int k = 0;
                foreach (CompanyHighlyToxicChemicals company in Companys.Items)
                {
                    if (company.CompanyID >= 0)
                    {
                        int CompanyID = company.CompanyID;
                        SelectSqlSection sectionCompany = DB.Select(DataBases.Company).Where(DataBases.Company.CompanyID == CompanyID);
                        using (IDataReader readerCompany = sectionCompany.ToDataReader())
                        {
                            while (readerCompany.Read())
                            {
                                Companys.Items[k].Company.CompanyAddress = readerCompany["CompanyAddress"].ToString();
                                Companys.Items[k].Company.CompanyID = Convert.ToInt32(readerCompany["CompanyID"].ToString());
                                Companys.Items[k].Company.CompanyName = readerCompany["CompanyName"].ToString();
                                Companys.Items[k].Company.CompanyPost = readerCompany["CompanyPost"].ToString();
                                Companys.Items[k].Company.JuridicalPerson = readerCompany["JuridicalPerson"].ToString();
                                Companys.Items[k].Company.JuridicalPersonAge = readerCompany["JuridicalPersonAge"].ToString();
                                Companys.Items[k].Company.JuridicalPersonJob = readerCompany["JuridicalPersonJob"].ToString();
                                Companys.Items[k].Company.JuridicalPersonSex = readerCompany["JuridicalPersonSex"].ToString();
                                Companys.Items[k].Company.Mobile = readerCompany["Mobile"].ToString();
                                Companys.Items[k].Company.Tel = readerCompany["Tel"].ToString();
                                Companys.Items[k].Company.IsCity = Convert.ToInt32(readerCompany["IsCity"].ToString());
                                Companys.Items[k].Company.CompanyAreaID = Convert.ToInt32(readerCompany["CompanyAreaID"].ToString());
                            }
                        }
                    }
                    k++;
                }
            }

            return Companys;
        }
        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        internal CompanyHighlyToxicChemicals CompanyHighlyToxicChemicalsGetOne(int CompanyID)
        {
            CompanyHighlyToxicChemicals Company = new CompanyHighlyToxicChemicals();
            SelectSqlSection section = DB.Select(DataBases.CompanyHighlyToxicChemicals, DataBases.CompanyHighlyToxicChemicals.ID.Count());
            if (CompanyID >= 0)
            {
                section.Where(DataBases.CompanyHighlyToxicChemicals.CompanyID == CompanyID);
            }

            int count = Convert.ToInt32(section.ToScalar());
            if (count > 0)
            {
                section = DB.Select(DataBases.CompanyHighlyToxicChemicals);
                if (CompanyID >= 0)
                {
                    section.Where(DataBases.CompanyHighlyToxicChemicals.CompanyID == CompanyID);
                }
                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Company = ReadRow(reader);
                        break;
                    }
                }
                if (Company.CompanyID >= 0)
                {

                    SelectSqlSection sectionCompany = DB.Select(DataBases.Company).Where(DataBases.Company.CompanyID == CompanyID);
                    using (IDataReader readerCompany = sectionCompany.ToDataReader())
                    {
                        while (readerCompany.Read())
                        {
                            Company.Company.CompanyAddress = readerCompany["CompanyAddress"].ToString();
                            Company.Company.CompanyID = Convert.ToInt32(readerCompany["CompanyID"].ToString());
                            Company.Company.CompanyName = readerCompany["CompanyName"].ToString();
                            Company.Company.CompanyPost = readerCompany["CompanyPost"].ToString();
                            Company.Company.JuridicalPerson = readerCompany["JuridicalPerson"].ToString();
                            Company.Company.JuridicalPersonAge = readerCompany["JuridicalPersonAge"].ToString();
                            Company.Company.JuridicalPersonJob = readerCompany["JuridicalPersonJob"].ToString();
                            Company.Company.JuridicalPersonSex = readerCompany["JuridicalPersonSex"].ToString();
                            Company.Company.Mobile = readerCompany["Mobile"].ToString();
                            Company.Company.Tel = readerCompany["Tel"].ToString();
                            Company.Company.IsCity = Convert.ToInt32(readerCompany["IsCity"].ToString());
                            Company.Company.CompanyAreaID = Convert.ToInt32(readerCompany["CompanyAreaID"].ToString());
                        }
                    }
                }
            }

            return Company;
        }
        protected override void BeginUpdate(System.Data.Common.DbTransaction trans)
        {
            base.BeginUpdate(trans);
            Company.CompanyType = (int)Company.ECompanyType.剧毒化学品使用详情表;
            Company.SQLtransaction = this.SQLtransaction;
            Company.SystemService = this.SystemService;
            Company.Update();
            this.CompanyID = Company.CompanyID;

        }

        protected override void BeginRemove(System.Data.Common.DbTransaction trans)
        {
            base.BeginRemove(trans);
            Company.SQLtransaction = this.SQLtransaction;
            Company.SystemService = this.SystemService;
            Company.Remove();
        }
    }
}

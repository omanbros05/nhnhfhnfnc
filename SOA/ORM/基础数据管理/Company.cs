using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    public partial class Company
    {
        /// <summary>
        /// 企业类型
        /// </summary>
        public enum ECompanyType
        { 
            危险化学品经营许可表 = 1,
            危险化学品生产L含溶剂回收RD储存详情表,
            烟花爆竹零售详情表,
            剧毒化学品使用详情表,
            非煤矿山安全生产许可企业详情表,
        }
        /// <summary>
        /// 企业类型名
        /// </summary>
        public string CompanyTypeName = String.Empty;

        [Synchro]
        public override string SearchColumn()
        {
            return CompanyName;
        }

        /// <summary>
        /// 获取所有企业数据
        /// </summary>
        /// <returns>企业数据集合</returns>
        internal List<Company> CompanyGetFastAll()
        {
            List<Company> Companys = new List<Company>();
            using (IDataReader reader = DB.Select(DataBases.Company).ToDataReader())
            {
                while (reader.Read())
                {
                    Companys.Add(ReadRow(reader));
                }
            }

            return Companys;
        }

        /// <summary>
        /// 根据名称更新企业信息
        /// </summary>
        /// <param name="company">企业对象</param>
        internal void UpdateCompanyByName(Company company)
        {
            if (company.CompanyName == "")
                return;

            Company databaseCompany = null;
            using (IDataReader reader = DB.Select(DataBases.Company).Where(DataBases.Company.CompanyName == company.CompanyName).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseCompany = ReadRow(reader);
                }
            }

            if (databaseCompany != null)
            {
                databaseCompany.setNewValue(company);
                databaseCompany.SystemService = this.SystemService;
                databaseCompany.SQLtransaction = this.SQLtransaction;
                databaseCompany.Update();
            }
            else
            {
                company.SystemService = this.SystemService;
                company.SQLtransaction = this.SQLtransaction;
                company.Update();
            }
        }

        protected override void EndUpdate(System.Data.Common.DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<Company>(this);
            searchWord.TableID = CompanyID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();

        }

        private void setNewValue(Company company)
        {
            if (!string.IsNullOrEmpty(company.CompanyName))
                this.CompanyName = company.CompanyName;

            if (!string.IsNullOrEmpty(company.CompanyAddress))
                this.CompanyAddress = company.CompanyAddress;

            if (!string.IsNullOrEmpty(company.CompanyPost))
                this.CompanyPost = company.CompanyPost;

            if (!string.IsNullOrEmpty(company.JuridicalPerson))
                this.JuridicalPerson = company.JuridicalPerson;

            if (!string.IsNullOrEmpty(company.JuridicalPersonSex))
                this.JuridicalPersonSex = company.JuridicalPersonSex;

            if (!string.IsNullOrEmpty(company.JuridicalPersonAge))
                this.JuridicalPersonAge = company.JuridicalPersonAge;

            if (!string.IsNullOrEmpty(company.JuridicalPersonJob))
                this.JuridicalPersonJob = company.JuridicalPersonJob;

            if (!string.IsNullOrEmpty(company.Mobile))
                this.Mobile = company.Mobile;

            if (!string.IsNullOrEmpty(company.Tel))
                this.Tel = company.Tel;
        }

        /// <summary>
        /// 获取公司信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        internal EList<Company> CompanyGetAll(int page, int pageSize,string name,int CompanyType)
        {
            EList<Company> Companys = new EList<Company>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
            {
                Clips.Add(DataBases.Company.CompanyName.Like("%" + name + "%"));
            }
            if (CompanyType != 0)
            {
                Clips.Add(DataBases.Company.CompanyType == CompanyType);
            }
            SelectSqlSection section = DB.Select(DataBases.Company, DataBases.Company.CompanyID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Companys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.Company);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.Company.CompanyID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Company areaCode = ReadRow(reader);
                        if (reader["CompanyType"].ToString() == "-1")
                        {
                            areaCode.CompanyTypeName = "无";
                        }
                        else
                        {
                            areaCode.CompanyTypeName = ((Company.ECompanyType)Convert.ToInt32(reader["CompanyType"])).ToString();
                        }
                        Companys.Items.Add(areaCode);
                    }
                }
            }

            return Companys;
        }

        /// <summary>
        /// 获取公司信息结合
        /// </summary>
        /// <param name="page">分页</param>
        /// <param name="pageSize"></param>
        /// <param name="name">名称</param>
        /// <param name="CompanyType">类型</param>
        /// <param name="CompanyArea">区域</param>
        /// <param name="IsCity">是否市级</param>
        /// <returns></returns>
        internal EList<Company> CompanyNewGetAll(int page, int pageSize, string name, int CompanyType,int CompanyArea,int IsCity)
        {
            EList<Company> Companys = new EList<Company>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
            {
                Clips.Add(DataBases.Company.CompanyName.Like("%" + name + "%"));
            }
            if(CompanyType == -2)
            {
                Clips.Add(DataBases.Company.CompanyType == -1);
            }
            else if (CompanyType != -1)
            {
                Clips.Add(DataBases.Company.CompanyType == CompanyType);
            }
            if (CompanyArea != -1)
            {
                Clips.Add(DataBases.Company.CompanyAreaID == CompanyArea);
            }
            if (IsCity != -1)
            {
                Clips.Add(DataBases.Company.IsCity == IsCity);
            }
            SelectSqlSection section = DB.Select(DataBases.Company, DataBases.Company.CompanyID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            Companys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.Company);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.Company.CompanyID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Company areaCode = ReadRow(reader);
                        if (reader["CompanyType"].ToString() == "-1")
                        {
                            areaCode.CompanyTypeName = "--";
                        }
                        else
                        {
                            areaCode.CompanyTypeName = ((Company.ECompanyType)Convert.ToInt32(reader["CompanyType"])).ToString();
                        }
                        Companys.Items.Add(areaCode);
                    }
                }
            }

            return Companys;
        }

        /// <summary>
        /// 获取公司信息结合
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        internal EList<Company> CompanyGetAllByName(string name)
        {
            EList<Company> Companys = new EList<Company>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (name != "")
            {
                Clips.Add(DataBases.Company.CompanyName == name);
            }
            SelectSqlSection section = DB.Select(DataBases.Company, DataBases.Company.CompanyID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());

            Companys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.Company);
                if (Clips.Count > 0)
                    section.Where(Clips);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        Company areaCode = ReadRow(reader);
                        Companys.Items.Add(areaCode);
                    }
                }
            }

            return Companys;
        }
    }
}

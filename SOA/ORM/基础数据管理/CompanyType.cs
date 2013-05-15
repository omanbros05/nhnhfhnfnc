using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;

namespace SOA.ORM
{
    public partial class CompanyType
    {
        /// <summary>
        /// 获取所有企业类型数据
        /// </summary>
        /// <returns>企业类型集合</returns>
        internal List<CompanyType> CompanyTypeGetFastAll()
        {
            List<CompanyType> Companys = new List<CompanyType>();
            using (IDataReader reader = DB.Select(DataBases.CompanyType).ToDataReader())
            {
                while (reader.Read())
                {
                    Companys.Add(ReadRow(reader));
                }
            }

            return Companys;
        }
    }
}

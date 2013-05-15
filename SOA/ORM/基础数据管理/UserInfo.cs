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
    public partial class UserInfo
    {
        /// <summary>
        /// 获取活动用户对象
        /// </summary>
        /// <returns></returns>
        internal UserInfo GetActiveUser()
        {
            UserInfo userInfo = null;

            using (IDataReader reader = DB.Select(DataBases.UserInfo).ToDataReader())
            {
                if (reader.Read())
                {
                    userInfo = ReadRow(reader);
                }
            }

            return userInfo;
        }
    }
}

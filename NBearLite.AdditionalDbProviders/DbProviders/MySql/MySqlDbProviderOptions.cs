using System;
using System.Collections.Generic;
using System.Text;

namespace NBearLite.DbProviders.MySql
{
    public class MySqlDbProviderOptions : NBearLite.DbProviders.DbProviderOptions
    {
        public override string GetSelectLastInsertAutoIncrementIDSql(string tableName, string columnName, Dictionary<string, string> options)
        {
            return "SELECT LAST_INSERT_ID()";
        }
    }
}

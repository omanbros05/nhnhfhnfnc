using System;
using System.Collections.Generic;
using System.Text;

namespace NBearLite.DbProviders.DB2
{
    internal class DB2DbProviderOptions : NBearLite.DbProviders.DbProviderOptions
    {
        public override string GetSelectLastInsertAutoIncrementIDSql(string tableName, string columnName, Dictionary<string, string> options)
        {
            return "VALUES (IDENTITY_VAL_LOCAL())";
        }

        public override bool SupportMultiSqlStatementInOneCommand
        {
            get
            {
                return true;
            }
        }
    }
}

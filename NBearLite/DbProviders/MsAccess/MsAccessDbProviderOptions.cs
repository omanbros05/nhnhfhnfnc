using System;
using System.Collections.Generic;
using System.Text;

namespace NBearLite.DbProviders.MsAccess
{
    public class MsAccessDbProviderOptions : NBearLite.DbProviders.DbProviderOptions
    {
        public override string GetSelectLastInsertAutoIncrementIDSql(string tableName, string columnName, Dictionary<string, string> options)
        {
            return "SELECT @@IDENTITY";
        }

        public override bool SupportADO20Transaction
        {
            get
            {
                return false;
            }
        }

        public override bool SupportMultiSqlStatementInOneCommand
        {
            get
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace NBearLite.DbProviders.SqlServerCE
{
    public class SqlServerCEDbProviderOptions : NBearLite.DbProviders.DbProviderOptions
    {
        public override string GetSelectLastInsertAutoIncrementIDSql(string tableName, string columnName, Dictionary<string, string> options)
        {
            return "SELECT SCOPE_IDENTITY()";
        }

        public override bool SupportADO20Transaction
        {
            get
            {
                return true;
            }
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

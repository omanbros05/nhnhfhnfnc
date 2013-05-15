using System;
using System.Collections.Generic;
using System.Text;

namespace NBearLite.DbProviders.Sqlite
{
    public class SqliteDbProviderOptions : NBearLite.DbProviders.DbProviderOptions
    {
        public override string GetSelectLastInsertAutoIncrementIDSql(string tableName, string columnName, Dictionary<string, string> options)
        {
            return "SELECT last_insert_rowid()";
        }
    }
}

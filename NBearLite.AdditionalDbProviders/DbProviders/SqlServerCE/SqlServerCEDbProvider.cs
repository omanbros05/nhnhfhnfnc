using System;
using System.Data;
using System.Data.Common;
using System.Xml;
using System.Data.SqlServerCe;

namespace NBearLite.DbProviders.SqlServerCE
{
    public class SqlServerCEDbProvider : DbProvider
    {
        #region Public Members

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDbProvider"/> class.
        /// </summary>
        /// <param name="connStr">The conn STR.</param>
        public SqlServerCEDbProvider(string connStr)
            : base(connStr, SqlCeProviderFactory.Instance)
        {
            CheckOptionsConfiguration(new SqlServerCEDbProviderOptions(), "SqlServerCEDbProviderOptions");
        }

        public override NBearLite.ISqlQueryFactory GetQueryFactory()
        {
            return new NBearLite.DbProviders.SqlServerCE.SqlServerCEQueryFactory();
        }

        #endregion
    }
}

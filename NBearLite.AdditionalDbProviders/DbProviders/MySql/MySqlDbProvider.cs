using System;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Xml;

namespace NBearLite.DbProviders.MySql
{
	/// <summary>
	/// <para>Represents a MySql Database Provider.</para>
	/// </summary>
    public class MySqlDbProvider : DbProvider
    {
        #region Public Members

        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlDbProvider"/> class.
        /// </summary>
        /// <param name="connStr">The conn STR.</param>
        public MySqlDbProvider(string connStr)
            : base(connStr, global::MySql.Data.MySqlClient.MySqlClientFactory.Instance)
        {
            CheckOptionsConfiguration(new MySqlDbProviderOptions(), "MySqlProviderOptions");
        }

        public override NBearLite.ISqlQueryFactory GetQueryFactory()
        {
            return new NBearLite.DbProviders.MySql.MySqlQueryFactory();
        }        

        #endregion
    }
}
using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Xml;

namespace NBearLite.DbProviders.Sqlite
{
	/// <summary>
	/// <para>Represents a Sqlite Database Provider.</para>
	/// </summary>
	/// <remarks> 
	/// <para>
	/// Internally uses Sqlite .NET Managed Provider to connect to the database.
	/// </para>  
	/// </remarks>
    public class SqliteDbProvider : DbProvider
    {
        #region Public Members

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessDbProvider"/> class.
        /// </summary>
        /// <param name="connStr">The conn STR.</param>
        public SqliteDbProvider(string connStr)
            : base(connStr, System.Data.SQLite.SQLiteFactory.Instance)
        {
            CheckOptionsConfiguration(new SqliteDbProviderOptions(), "SqliteProviderOptions");
        }

        public override NBearLite.ISqlQueryFactory GetQueryFactory()
        {
            return new NBearLite.DbProviders.Sqlite.SqliteQueryFactory();
        }
        #endregion
    }
}
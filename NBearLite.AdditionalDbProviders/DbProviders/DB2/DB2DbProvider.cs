using System;
using System.Data;
using System.Data.Common;
using IBM.Data.DB2;
using System.Xml;



namespace NBearLite.DbProviders.DB2
{
    /// <summary>
    /// <para>Represents an DB2 Database.</para>
    /// </summary>
    /// <remarks> 
    /// <para>
    /// Internally uses DB2 .NET Managed Provider from Microsoft (IBM.Data.DB2) to connect to the database.
    /// </para>  
    /// </remarks>
    public class DB2DbProvider : DbProvider
    {
        #region Public Members

        /// <summary>
        /// Initializes a new instance of the <see cref="DB2DbProvider"/> class.
        /// </summary>
        /// <param name="connStr">The conn STR.</param>
        public DB2DbProvider(string connStr)
            : base(connStr, DB2Factory.Instance)
        {
            CheckOptionsConfiguration(new DB2DbProviderOptions(), "DB2ProviderOptions");
        }

        public override NBearLite.ISqlQueryFactory GetQueryFactory()
        {
            return new NBearLite.DbProviders.DB2.DB2QueryFactory();
        }

        #endregion
    }
}
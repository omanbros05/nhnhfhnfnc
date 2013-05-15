namespace @__SOA
{

        public class Archive_Columns : NBearLite.IQueryTable
        {

            private const string ___TABLE_NAME = "Archive";

            private string ___aliasName;

            private static NBearLite.QueryColumn _ID = new NBearLite.QueryColumn((___TABLE_NAME + ".ID"), System.Data.DbType.Int32);

            private static NBearLite.QueryColumn _name = new NBearLite.QueryColumn((___TABLE_NAME + ".name"), System.Data.DbType.String);

            private static NBearLite.QueryColumn _status = new NBearLite.QueryColumn((___TABLE_NAME + ".status"), System.Data.DbType.Byte);

            private static NBearLite.QueryColumn _CreateTime = new NBearLite.QueryColumn((___TABLE_NAME + ".CreateTime"), System.Data.DbType.DateTime);

            private static NBearLite.QueryColumn _exchangeGUID = new NBearLite.QueryColumn((___TABLE_NAME + ".exchangeGUID"), System.Data.DbType.String);

            private static NBearLite.QueryColumn _CreateTimes = new NBearLite.QueryColumn((___TABLE_NAME + ".CreateTimes"), System.Data.DbType.DateTime);

            public Archive_Columns(string aliasName)
            {
                this.___aliasName = aliasName;
            }

            public Archive_Columns()
            {
                this.___aliasName = ___TABLE_NAME;
            }

            public NBearLite.QueryColumn ID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _ID;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".ID"), System.Data.DbType.Int32);
                    }
                }
            }

            public NBearLite.QueryColumn Name
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _name;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".name"), System.Data.DbType.String);
                    }
                }
            }
            public NBearLite.QueryColumn Status
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _status;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".status"), System.Data.DbType.Byte);
                    }
                }
            }

            public NBearLite.QueryColumn CreateTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _CreateTime;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".CreateTime"), System.Data.DbType.DateTime);
                    }
                }
            }

            public NBearLite.QueryColumn CreateTimes
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _CreateTimes;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".CreateTimes"), System.Data.DbType.DateTime);
                    }
                }
            }

            public NBearLite.QueryColumn ExchangeGUID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME))
                    {
                        return _exchangeGUID;
                    }
                    else
                    {
                        return new NBearLite.QueryColumn((this.___aliasName + ".exchangeGUID"), System.Data.DbType.String);
                    }
                }
            }

            public string ___GetTableName()
            {
                return ___TABLE_NAME;
            }

            public @__SOA.Archive_Columns @__Alias(string aliasName)
            {
                return new @__SOA.Archive_Columns(aliasName);
            }
        }


    public class ArchiveExt_Columns : NBearLite.IQueryTable
    {

        private const string ___TABLE_NAME = "ArchiveExt";

        private string ___aliasName;

        private static NBearLite.QueryColumn _archiveID = new NBearLite.QueryColumn((___TABLE_NAME + ".archiveID"), System.Data.DbType.Int32);

        private static NBearLite.QueryColumn _tableName = new NBearLite.QueryColumn((___TABLE_NAME + ".tableName"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _primaryValue = new NBearLite.QueryColumn((___TABLE_NAME + ".primaryValue"), System.Data.DbType.Int32);

        private static NBearLite.QueryColumn _CreateTime = new NBearLite.QueryColumn((___TABLE_NAME + ".CreateTime"), System.Data.DbType.DateTime);

        private static NBearLite.QueryColumn _exchangeGUID = new NBearLite.QueryColumn((___TABLE_NAME + ".exchangeGUID"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _FileName = new NBearLite.QueryColumn((___TABLE_NAME + ".FileName"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _Title = new NBearLite.QueryColumn((___TABLE_NAME + ".Title"), System.Data.DbType.String);

        public ArchiveExt_Columns(string aliasName)
        {
            this.___aliasName = aliasName;
        }

        public ArchiveExt_Columns()
        {
            this.___aliasName = ___TABLE_NAME;
        }

        public NBearLite.QueryColumn ArchiveID
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _archiveID;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".archiveID"), System.Data.DbType.Int32);
                }
            }
        }

        public NBearLite.QueryColumn Title
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _Title;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".Title"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn TableName
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _tableName;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".tableName"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn FileName
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _FileName;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".FileName"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn PrimaryValue
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _primaryValue;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".primaryValue"), System.Data.DbType.Int32);
                }
            }
        }

        public NBearLite.QueryColumn CreateTime
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _CreateTime;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".CreateTime"), System.Data.DbType.DateTime);
                }
            }
        }

        public NBearLite.QueryColumn ExchangeGUID
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _exchangeGUID;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".exchangeGUID"), System.Data.DbType.String);
                }
            }
        }

        public string ___GetTableName()
        {
            return ___TABLE_NAME;
        }

        public @__SOA.ArchiveExt_Columns @__Alias(string aliasName)
        {
            return new @__SOA.ArchiveExt_Columns(aliasName);
        }
    }
}

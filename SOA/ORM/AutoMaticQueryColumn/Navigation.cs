﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5466
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
namespace @__SOA
{


    public class Navigation_Columns : NBearLite.IQueryTable
    {

        private const string ___TABLE_NAME = "Navigation";

        private string ___aliasName;

        private static NBearLite.QueryColumn _ID = new NBearLite.QueryColumn((___TABLE_NAME + ".ID"), System.Data.DbType.Int32);

        private static NBearLite.QueryColumn _GroupName = new NBearLite.QueryColumn((___TABLE_NAME + ".GroupName"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _ItemName = new NBearLite.QueryColumn((___TABLE_NAME + ".ItemName"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _ItemIcon = new NBearLite.QueryColumn((___TABLE_NAME + ".ItemIcon"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _TargetModule = new NBearLite.QueryColumn((___TABLE_NAME + ".TargetModule"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _ParentId = new NBearLite.QueryColumn((___TABLE_NAME + ".ParentId"), System.Data.DbType.Int32);

        private static NBearLite.QueryColumn _ModuleDescribe = new NBearLite.QueryColumn((___TABLE_NAME + ".ModuleDescribe"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _Sort = new NBearLite.QueryColumn((___TABLE_NAME + ".Sort"), System.Data.DbType.Int32);

        private static NBearLite.QueryColumn _ExchangeGUID = new NBearLite.QueryColumn((___TABLE_NAME + ".ExchangeGUID"), System.Data.DbType.String);

        private static NBearLite.QueryColumn _CreateTime = new NBearLite.QueryColumn((___TABLE_NAME + ".CreateTime"), System.Data.DbType.DateTime);

        private static NBearLite.QueryColumn _IsItemSmall = new NBearLite.QueryColumn((___TABLE_NAME + ".IsItemSmall"), System.Data.DbType.Byte);

        public Navigation_Columns(string aliasName)
        {
            this.___aliasName = aliasName;
        }

        public Navigation_Columns()
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

        public NBearLite.QueryColumn GroupName
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _GroupName;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".GroupName"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn ItemName
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _ItemName;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".ItemName"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn ItemIcon
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _ItemIcon;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".ItemIcon"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn TargetModule
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _TargetModule;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".TargetModule"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn ParentId
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _ParentId;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".ParentId"), System.Data.DbType.Int32);
                }
            }
        }

        public NBearLite.QueryColumn ModuleDescribe
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _ModuleDescribe;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".ModuleDescribe"), System.Data.DbType.String);
                }
            }
        }

        public NBearLite.QueryColumn Sort
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _Sort;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".Sort"), System.Data.DbType.Int32);
                }
            }
        }

        public NBearLite.QueryColumn ExchangeGUID
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _ExchangeGUID;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".ExchangeGUID"), System.Data.DbType.String);
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


        public NBearLite.QueryColumn IsItemSmall
        {
            get
            {
                if ((this.___aliasName == ___TABLE_NAME))
                {
                    return _IsItemSmall;
                }
                else
                {
                    return new NBearLite.QueryColumn((this.___aliasName + ".IsItemSmall"), System.Data.DbType.Byte);
                }
            }
        }

        public string ___GetTableName()
        {
            return ___TABLE_NAME;
        }

        public @__SOA.Navigation_Columns @__Alias(string aliasName)
        {
            return new @__SOA.Navigation_Columns(aliasName);
        }
    }
}

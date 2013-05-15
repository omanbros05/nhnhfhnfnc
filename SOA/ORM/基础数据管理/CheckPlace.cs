using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class CheckPlace
    {
        public override string SearchColumn()
        {
            return CheckContent;
        }

        /// <summary>
        /// 更新检查地点
        /// </summary>
        /// <param name="checkPlace">检查地点</param>
        internal void UpdateCheckPlace(CheckPlace checkPlace)
        {
            if (checkPlace.CheckContent == "")
                return;

            CheckPlace databaseCheckPlace = null;
            using (IDataReader reader = DB.Select(DataBases.CheckPlace).Where(DataBases.CheckPlace.CheckContent == checkPlace.CheckContent).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseCheckPlace = ReadRow(reader);
                }
            }

            if (databaseCheckPlace != null)
            {
                databaseCheckPlace.CheckContent = checkPlace.CheckContent;
                databaseCheckPlace.SystemService = this.SystemService;
                databaseCheckPlace.SQLtransaction = this.SQLtransaction;
                databaseCheckPlace.Update();
            }
            else
            {
                checkPlace.SystemService = this.SystemService;
                checkPlace.SQLtransaction = this.SQLtransaction;
                checkPlace.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<CheckPlace>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

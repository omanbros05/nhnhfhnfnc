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
    public partial class Lawyer
    {
        public override string SearchColumn()
        {
            return LawyerName;
        }

        /// <summary>
        /// 更新律师记录
        /// </summary>
        /// <param name="lawyer">律师对象</param>
        internal void UpdateLowyer(Lawyer lawyer)
        {
            if (lawyer.LawyerName == "")
                return;

            Lawyer databaseLawyer = null;
            using (IDataReader reader = DB.Select(DataBases.Lawyer).Where(DataBases.Lawyer.LawyerName == lawyer.LawyerName && DataBases.Lawyer.Sex == lawyer.Sex && DataBases.Lawyer.Job == lawyer.Job).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseLawyer = ReadRow(reader);
                }
            }

            if (databaseLawyer != null)
            {
                if (lawyer.LawyerName != "")
                    databaseLawyer.LawyerName = lawyer.LawyerName;

                if (lawyer.Sex != "")
                    databaseLawyer.Sex = lawyer.Sex;

                if (lawyer.Age != "")
                    databaseLawyer.Age = lawyer.Age;

                if (lawyer.Job != "")
                    databaseLawyer.Job = lawyer.Job;

                databaseLawyer.SystemService = this.SystemService;
                databaseLawyer.SQLtransaction = this.SQLtransaction;
                databaseLawyer.Update();
            }
            else
            {
                lawyer.SystemService = this.SystemService;
                lawyer.SQLtransaction = this.SQLtransaction;
                lawyer.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<Lawyer>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

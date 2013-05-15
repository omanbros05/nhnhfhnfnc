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
    public partial class NaturalPerson
    {
        public override string SearchColumn()
        {
            return PersonName;
        }

        /// <summary>
        /// 更新自然人
        /// </summary>
        /// <param name="person">自然人</param>
        internal void UpdateNaturalPersonByArgs(NaturalPerson person)
        {
            if (person.PersonName == "")
                return;

            NaturalPerson databaseNaturalPersone = null;
            using (IDataReader reader = DB.Select(DataBases.NaturalPerson).Where(DataBases.NaturalPerson.PersonName == person.PersonName && DataBases.NaturalPerson.IDcard == person.IDcard).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseNaturalPersone = ReadRow(reader);
                }
            }

            if (databaseNaturalPersone != null)
            {
                if (person.Sex != "")
                    databaseNaturalPersone.Sex = person.Sex;

                if (person.Age != "")
                    databaseNaturalPersone.Age = person.Age;

                if (person.Address != "")
                    databaseNaturalPersone.Address = person.Address;

                if (person.CompanyName != "")
                    databaseNaturalPersone.CompanyName = person.CompanyName;

                if (person.Job != "")
                    databaseNaturalPersone.Job = person.Job;

                if (person.CompanyAddress != "")
                    databaseNaturalPersone.CompanyAddress = person.CompanyAddress;

                if (person.CompanyTel != "")
                    databaseNaturalPersone.CompanyTel = person.CompanyTel;

                databaseNaturalPersone.SystemService = this.SystemService;
                databaseNaturalPersone.SQLtransaction = this.SQLtransaction;
                databaseNaturalPersone.Update();
            }
            else
            {
                person.SystemService = this.SystemService;
                person.SQLtransaction = this.SQLtransaction;
                person.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<NaturalPerson>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

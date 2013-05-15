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
    public partial class Bank
    {
        public override string SearchColumn()
        {
            return BankName;
        }

        /// <summary>
        /// 根据名称和帐号更新银行信息
        /// </summary>
        ///<param name="bank">银行</param>
        internal void UpdateByNameAccount(Bank bank)
        {
            if (bank.BankName == "")
                return;

            Bank databaseBank = null;
            using (IDataReader reader = DB.Select(DataBases.Bank).Where(DataBases.Bank.BankName == bank.BankName && DataBases.Bank.Account == bank.Account).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseBank = ReadRow(reader);
                }
            }

            if (databaseBank != null)
            {
                if (bank.BankName != "")
                    databaseBank.BankName = bank.BankName;

                if (bank.Account != "")
                    databaseBank.Account = bank.Account;

                databaseBank.SystemService = this.SystemService;
                databaseBank.SQLtransaction = this.SQLtransaction;
                databaseBank.Update();
            }
            else
            {
                bank.SystemService = this.SystemService;
                bank.SQLtransaction = this.SQLtransaction;
                bank.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<Bank>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}

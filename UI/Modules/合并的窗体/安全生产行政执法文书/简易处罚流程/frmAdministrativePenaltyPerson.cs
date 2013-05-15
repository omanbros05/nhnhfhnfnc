using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using EnforceUI.Input;
using SOA;
using SOA.ORM;
using Common;

namespace EnforceForm
{
    public partial class frmAdministrativePenaltyPerson : BaseTableForm
    {
        public AdministrativePenaltyPerson administrativePenaltyPerson;

        public frmAdministrativePenaltyPerson()
        {
            InitializeComponent();
        }

        public frmAdministrativePenaltyPerson(AdministrativePenaltyPerson administrativePenaltyPerson)
            : this()
        {
            this.administrativePenaltyPerson = administrativePenaltyPerson;
        }

        private void frmAdministrativePenaltyPerson_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管罚当〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                DocDate.Value = DateTime.Now;

                GovArea.Text = InvokeUtil.ActiveUser.Area;
                ManageArea.Text = InvokeUtil.ActiveUser.FullName;
                CourtArea.Text = InvokeUtil.ActiveUser.Area;

                SentCompany.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    SentCompany.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                    SentPeople.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                PaymentAddress.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Bank).FullName);
                foreach (SearchWord word in Words)
                    PaymentAddress.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                GovArea.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    GovArea.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                OfficerName1.Items.Clear();
                OfficerName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    OfficerName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    OfficerName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (administrativePenaltyPerson != null)
                {
                    SetEntity(administrativePenaltyPerson);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (administrativePenaltyPerson == null)
                    administrativePenaltyPerson = new AdministrativePenaltyPerson();

                GetEntity(administrativePenaltyPerson);

                NaturalPerson naturalPerson = new NaturalPerson { 
                    PersonName = SentPeople.Text,
                    Sex = SentSex.Text,
                    Age = SentAge.Text,
                    IDcard = SentIDCard.Text,
                    Address = SentAddress.Text,
                    CompanyName = SentCompany.Text,
                    Job = SentJob.Text,
                    CompanyAddress = SentCompanyAddress.Text,
                    CompanyTel = SentTel.Text
                };
                InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);

                Bank bank = new Bank
                {
                    BankName = PaymentAddress.Text,
                    Account = PaymentAccount.Text
                };
                InvokeUtil.SystemService.UpdateBankByNameAccount(bank);

                InvokeUtil.SystemService.EntityUpdate(administrativePenaltyPerson);
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SentPeople_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (SentPeople.SelectedValue != null)
                {
                    SearchWord word = SentPeople.SelectedValue as SearchWord;
                    NaturalPerson person = word.ToObject<NaturalPerson>();
                    SentSex.Text = person.Sex;
                    SentAge.Text = person.Age;
                    SentIDCard.Text = person.IDcard;
                    SentAddress.Text = person.Address;
                    SentCompany.Text = person.CompanyName;
                    SentJob.Text = person.Job;
                    SentCompanyAddress.Text = person.CompanyAddress;
                    SentTel.Text = person.CompanyTel;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void PaymentAddress_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PaymentAddress.SelectedValue != null)
                {
                    SearchWord word = PaymentAddress.SelectedValue as SearchWord;
                    Bank bank = word.ToObject<Bank>();
                    PaymentAccount.Text = bank.Account;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SentCompany_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (SentCompany.SelectedValue != null)
                {
                    SearchWord word = SentCompany.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    SentCompanyAddress.Text = company.CompanyAddress;
                    SentTel.Text = company.Mobile;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程, (int)SOA.ORM.InstrumentsExample.ESimplePunishType.行政L当场R处罚决定书L个人R);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
                    frm.OpenWindow(this);
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            frm.OpenWindow(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

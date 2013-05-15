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
    public partial class frmAdministrativePenaltyCompany : BaseTableForm
    {
        public AdministrativePenaltyCompany administrativePenaltyCompany;

        public frmAdministrativePenaltyCompany()
        {
            InitializeComponent();
        }

        public frmAdministrativePenaltyCompany(AdministrativePenaltyCompany administrativePenaltyCompany)
            : this()
        {
            this.administrativePenaltyCompany = administrativePenaltyCompany;
        }

        private void frmAdministrativePenaltyCompany_Load(object sender, EventArgs e)
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

                CompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                PaymentAddress.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Bank).FullName);
                foreach (SearchWord word in Words)
                    PaymentAddress.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                GovArea.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    GovArea.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                if (administrativePenaltyCompany != null)
                {
                    SetEntity(administrativePenaltyCompany);
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
                if (administrativePenaltyCompany == null)
                    administrativePenaltyCompany = new AdministrativePenaltyCompany();

                GetEntity(administrativePenaltyCompany);

                Company company = new Company
                {
                    CompanyName = CompanyName.Text,
                    CompanyAddress = CompanyAddress.Text,
                    JuridicalPerson = JuridicalName.Text,
                    JuridicalPersonJob = JuridicalJob.Text,
                    CompanyPost = CompanyPost.Text,
                    Mobile = JuridicalTel.Text
                };
                InvokeUtil.SystemService.UpdateCompanyByName(company);

                Bank bank = new Bank { BankName = PaymentAddress.Text, Account = PaymentAccount.Text };
                InvokeUtil.SystemService.UpdateBankByNameAccount(bank);

                InvokeUtil.SystemService.EntityUpdate(administrativePenaltyCompany);
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        
        private void CompanyName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (CompanyName.SelectedValue != null)
                {
                    SearchWord word = CompanyName.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    CompanyAddress.Text = company.CompanyAddress;
                    CompanyPost.Text = company.CompanyPost;
                    JuridicalName.Text = company.JuridicalPerson;
                    JuridicalJob.Text = company.JuridicalPersonJob;
                    JuridicalTel.Text = company.Mobile;
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

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程, (int)SOA.ORM.InstrumentsExample.ESimplePunishType.行政L当场R处罚决定书L单位R);
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

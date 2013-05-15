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
using Maleos.Modules;

namespace EnforceForm
{
    public partial class frmPunishmentDecisionUnit : BaseTableForm
    {
        private PunishmentDecisionUnit punishmentDecisionUnit = null;
        public frmPunishmentDecisionUnit()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPunishmentDecisionUnits"));
        }

        public frmPunishmentDecisionUnit(PunishmentDecisionUnit punishmentDecisionUnit)
            : this()
        {
            this.punishmentDecisionUnit = punishmentDecisionUnit;
        }

        private void frmPunishmentDecisionUnit_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管罚〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;
                ReconsiderationUnitName1.Text = InvokeUtil.ActiveUser.Area;
                ReconsiderationUnitName2.Text = InvokeUtil.ActiveUser.FullName;
                LitigationUnitName.Text = InvokeUtil.ActiveUser.Area;

                PutOnRecordCaseName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    PutOnRecordCaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                ReconsiderationUnitName1.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    ReconsiderationUnitName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                BankName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Bank).FullName);
                foreach (SearchWord word in Words)
                    BankName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                if (punishmentDecisionUnit != null)
                {
                    SetEntity(punishmentDecisionUnit);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (punishmentDecisionUnit == null)
            {
                punishmentDecisionUnit = new PunishmentDecisionUnit();

                punishmentDecisionUnit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(punishmentDecisionUnit);

            Company company = new Company
            {
                CompanyName = PutOnRecordCaseName.Text,
                CompanyAddress = FieldEAddress.Text,
                CompanyPost = FieldEPeopleZio.Text,
                JuridicalPerson = FieldEFName.Text,
                JuridicalPersonJob = FieldEPosition.Text,
                Mobile = FieldEPeoplePhone.Text
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);
            Bank bank = new Bank { BankName = BankName.Text, Account = BankID.Text };
            InvokeUtil.SystemService.UpdateBankByNameAccount(bank);

            InvokeUtil.SystemService.EntityUpdate(punishmentDecisionUnit);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPunishmentDecisionUnits"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        
        private void PutOnRecordCaseName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PutOnRecordCaseName.SelectedValue != null)
                {
                    SearchWord word = PutOnRecordCaseName.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    FieldEAddress.Text = company.CompanyAddress;
                    FieldEPeopleZio.Text = company.CompanyPost;
                    FieldEFName.Text = company.JuridicalPerson;
                    FieldEPosition.Text = company.JuridicalPersonJob;
                    FieldEPeoplePhone.Text = company.Mobile;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void BankName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (BankName.SelectedValue != null)
                {
                    SearchWord word = BankName.SelectedValue as SearchWord;
                    Bank bank = word.ToObject<Bank>();
                    BankID.Text = bank.Account;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (punishmentDecisionUnit == null)
                {
                    punishmentDecisionUnit = new PunishmentDecisionUnit();

                    punishmentDecisionUnit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                punishmentDecisionUnit.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("行政处罚决定书");
                doc.AddField("DocTitle", punishmentDecisionUnit.DocTitle);
                doc.AddField("PutOnRecordCaseName", punishmentDecisionUnit.PutOnRecordCaseName);
                doc.AddField("FieldEAddress", punishmentDecisionUnit.FieldEAddress);
                doc.AddField("FieldEPeopleZio", punishmentDecisionUnit.FieldEPeopleZio);
                doc.AddField("FieldEFName", punishmentDecisionUnit.FieldEFName);
                doc.AddField("FieldEPosition", punishmentDecisionUnit.FieldEPosition);
                doc.AddField("FieldEPeoplePhone", punishmentDecisionUnit.FieldEPeoplePhone);
                doc.AddField("IllegalEvidence", punishmentDecisionUnit.IllegalEvidence);
                doc.AddField("IllegalProvisions", punishmentDecisionUnit.IllegalProvisions);
                doc.AddField("According", punishmentDecisionUnit.According);
                doc.AddField("PunishmentAmount", punishmentDecisionUnit.PunishmentAmount);
                doc.AddField("BankName", punishmentDecisionUnit.BankName);
                doc.AddField("BankID", punishmentDecisionUnit.BankID);
                doc.AddField("ReconsiderationUnitName1", punishmentDecisionUnit.ReconsiderationUnitName1);
                doc.AddField("ReconsiderationUnitName2", punishmentDecisionUnit.ReconsiderationUnitName2);
                doc.AddField("LitigationUnitName", punishmentDecisionUnit.LitigationUnitName);
                doc.AddFootField("DocManageArea", punishmentDecisionUnit.DocManageArea);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmPunishmentDecisionUnits", punishmentDecisionUnit.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚, (int)SOA.ORM.InstrumentsExample.EAdminPunishType.行政处罚决定书单位);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

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
    public partial class frmSpotPunishmentDecisionUnit : BaseTableForm
    {
        private SpotPunishmentDecisionUnit spotPunishmentDecisionUnit = null;
        public frmSpotPunishmentDecisionUnit()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionUnits"));
        }

        public frmSpotPunishmentDecisionUnit(SpotPunishmentDecisionUnit spotPunishmentDecisionUnit)
            : this()
        {
            this.spotPunishmentDecisionUnit = spotPunishmentDecisionUnit;
        }

        private void frmSpotPunishmentDecisionUnit_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管罚当〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;
                ReconsiderationUnitName1.Text = InvokeUtil.ActiveUser.Area;
                ReconsiderationUnitName2.Text = InvokeUtil.ActiveUser.FullName;
                LitigationUnitName.Text = InvokeUtil.ActiveUser.Area;

                PutOnRecordCompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    PutOnRecordCompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                ReconsiderationUnitName1.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    ReconsiderationUnitName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                ExecUserName1.Items.Clear();
                ExecUserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    ExecUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ExecUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                BankName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Bank).FullName);
                foreach (SearchWord word in Words)
                    BankName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                if (spotPunishmentDecisionUnit != null)
                {
                    SetEntity(spotPunishmentDecisionUnit);
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
                SaveData();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionUnits"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void PutOnRecordCompanyName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PutOnRecordCompanyName.SelectedValue != null)
                {
                    SearchWord word = PutOnRecordCompanyName.SelectedValue as SearchWord;
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

        private void SaveData()
        {
            if (spotPunishmentDecisionUnit == null)
            {
                spotPunishmentDecisionUnit = new SpotPunishmentDecisionUnit();

                spotPunishmentDecisionUnit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(spotPunishmentDecisionUnit);

            Company company = new Company
            {
                CompanyName = PutOnRecordCompanyName.Text,
                CompanyAddress = FieldEAddress.Text,
                CompanyPost = FieldEPeopleZio.Text,
                JuridicalPerson = FieldEFName.Text,
                JuridicalPersonJob = FieldEPosition.Text,
                Mobile = FieldEPeoplePhone.Text
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            Bank bank = new Bank { BankName = BankName.Text, Account = BankID.Text };
            InvokeUtil.SystemService.UpdateBankByNameAccount(bank);

            InvokeUtil.SystemService.EntityUpdate(spotPunishmentDecisionUnit);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotPunishmentDecisionUnit == null)
                {
                    spotPunishmentDecisionUnit = new SpotPunishmentDecisionUnit();

                    spotPunishmentDecisionUnit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                spotPunishmentDecisionUnit.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("行政当场处罚决定书");
                doc.AddField("DocTitle", spotPunishmentDecisionUnit.DocTitle);
                doc.AddField("PutOnRecordCompanyName", spotPunishmentDecisionUnit.PutOnRecordCompanyName);
                doc.AddField("FieldEAddress", spotPunishmentDecisionUnit.FieldEAddress);
                doc.AddField("FieldEPeopleZio", spotPunishmentDecisionUnit.FieldEPeopleZio);
                doc.AddField("FieldEFName", spotPunishmentDecisionUnit.FieldEFName);
                doc.AddField("FieldEPosition", spotPunishmentDecisionUnit.FieldEPosition);
                doc.AddField("FieldEPeoplePhone", spotPunishmentDecisionUnit.FieldEPeoplePhone);
                doc.AddField("IllegalEvidence", spotPunishmentDecisionUnit.IllegalEvidence);
                doc.AddField("IllegalProvisions", spotPunishmentDecisionUnit.IllegalProvisions);
                doc.AddField("According", spotPunishmentDecisionUnit.According);
                doc.AddField("PunishmentAmount", spotPunishmentDecisionUnit.PunishmentAmount);
                doc.AddField("IfSpotPay", spotPunishmentDecisionUnit.IfSpotPay ? "√" : "");
                doc.AddField("IfOther", spotPunishmentDecisionUnit.IfOther ? "√" : "");
                doc.AddField("BankName", spotPunishmentDecisionUnit.BankName);
                doc.AddField("BankID", spotPunishmentDecisionUnit.BankID);
                doc.AddField("ReconsiderationUnitName1", spotPunishmentDecisionUnit.ReconsiderationUnitName1);
                doc.AddField("ReconsiderationUnitName2", spotPunishmentDecisionUnit.ReconsiderationUnitName2);
                doc.AddField("LitigationUnitName", spotPunishmentDecisionUnit.LitigationUnitName);
                doc.AddFootField("DocManageArea", spotPunishmentDecisionUnit.DocManageArea);


                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSpotPunishmentDecisionUnits", spotPunishmentDecisionUnit.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚, (int)SOA.ORM.InstrumentsExample.EAdminPunishType.行政当场处罚决定书单位);
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

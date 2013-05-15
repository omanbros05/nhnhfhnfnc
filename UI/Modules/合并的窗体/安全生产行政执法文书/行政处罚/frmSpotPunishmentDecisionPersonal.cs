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
    public partial class frmSpotPunishmentDecisionPersonal : BaseTableForm
    {
        private SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal = null;
        public frmSpotPunishmentDecisionPersonal()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionPersonals"));
        }

        public frmSpotPunishmentDecisionPersonal(SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal)
            : this()
        {
            this.spotPunishmentDecisionPersonal = spotPunishmentDecisionPersonal;
        }

        private void SaveData()
        {
            if (spotPunishmentDecisionPersonal == null)
            {
                spotPunishmentDecisionPersonal = new SpotPunishmentDecisionPersonal();

                spotPunishmentDecisionPersonal.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(spotPunishmentDecisionPersonal);

            NaturalPerson naturalPerson = new NaturalPerson
            {
                Sex = FieldEPeopleSex.Text,
                Age = FieldEPeopleAge.Text,
                CompanyTel = FieldEPeoplePhone.Text,
                Address = FieldEPeopleAddress.Text,
                CompanyName = FieldEPeopleCompanyName.Text,
                Job = FieldEPeoplePosition.Text,
                CompanyAddress = FieldEPeopleCompanyAddress.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);

            Bank bank = new Bank { BankName = BankName.Text, Account = BankID.Text };
            InvokeUtil.SystemService.UpdateBankByNameAccount(bank);

            InvokeUtil.SystemService.EntityUpdate(spotPunishmentDecisionPersonal);
        }
        private void frmSpotPunishmentDecisionPersonal_Load(object sender, EventArgs e)
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

                FieldEPeopleName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    FieldEPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

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
                if (spotPunishmentDecisionPersonal != null)
                {
                    SetEntity(spotPunishmentDecisionPersonal);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionPersonals"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        
        private void FieldEPeopleName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (FieldEPeopleName.SelectedValue != null)
                {
                    SearchWord word = FieldEPeopleName.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    FieldEPeopleSex.Text = naturalPerson.Sex;
                    FieldEPeopleAge.Text = naturalPerson.Age;
                    FieldEPeoplePhone.Text = naturalPerson.CompanyTel;
                    FieldEPeopleAddress.Text = naturalPerson.Address;
                    FieldEPeopleCompanyName.Text = naturalPerson.CompanyName;
                    FieldEPeoplePosition.Text = naturalPerson.Job;
                    FieldEPeopleCompanyAddress.Text = naturalPerson.CompanyAddress;
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
                if (spotPunishmentDecisionPersonal == null)
                {
                    spotPunishmentDecisionPersonal = new SpotPunishmentDecisionPersonal();

                    spotPunishmentDecisionPersonal.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                spotPunishmentDecisionPersonal.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("行政当场处罚决定书个人");
                doc.AddField("DocTitle", spotPunishmentDecisionPersonal.DocTitle);
                doc.AddField("FieldEPeopleName", spotPunishmentDecisionPersonal.FieldEPeopleName);
                doc.AddField("FieldEPeopleSex", spotPunishmentDecisionPersonal.FieldEPeopleSex);
                doc.AddField("FieldEPeopleAge", spotPunishmentDecisionPersonal.FieldEPeopleAge);
                doc.AddField("FieldEPeopleID", spotPunishmentDecisionPersonal.FieldEPeopleID);
                doc.AddField("FieldEPeopleAddress", spotPunishmentDecisionPersonal.FieldEPeopleAddress);
                doc.AddField("FieldEPeopleCompanyName", spotPunishmentDecisionPersonal.FieldEPeopleCompanyName);
                doc.AddField("FieldEPeoplePosition", spotPunishmentDecisionPersonal.FieldEPeoplePosition);
                doc.AddField("FieldEPeopleCompanyAddress", spotPunishmentDecisionPersonal.FieldEPeopleCompanyAddress);
                doc.AddField("FieldEPeoplePhone", spotPunishmentDecisionPersonal.FieldEPeoplePhone);
                doc.AddField("IllegalEvidence", spotPunishmentDecisionPersonal.IllegalEvidence);
                doc.AddField("IllegalProvisions", spotPunishmentDecisionPersonal.IllegalProvisions);
                doc.AddField("According", spotPunishmentDecisionPersonal.According);
                doc.AddField("PunishmentAmount", spotPunishmentDecisionPersonal.PunishmentAmount);
                doc.AddField("IfSpotPay", spotPunishmentDecisionPersonal.IfSpotPay ? "√" : "");
                doc.AddField("IfOther", spotPunishmentDecisionPersonal.IfOther ? "√" : "");
                doc.AddField("BankName", spotPunishmentDecisionPersonal.BankName);
                doc.AddField("BankID", spotPunishmentDecisionPersonal.BankID);
                doc.AddField("ReconsiderationUnitName1", spotPunishmentDecisionPersonal.ReconsiderationUnitName1);
                doc.AddField("ReconsiderationUnitName2", spotPunishmentDecisionPersonal.ReconsiderationUnitName2);
                doc.AddField("LitigationUnitName", spotPunishmentDecisionPersonal.LitigationUnitName);
                doc.AddFootField("DocManageArea", spotPunishmentDecisionPersonal.DocManageArea);
               
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSpotPunishmentDecisionPersonals", spotPunishmentDecisionPersonal.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚, (int)SOA.ORM.InstrumentsExample.EAdminPunishType.行政当场处罚决定书个人);
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

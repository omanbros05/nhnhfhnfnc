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
    public partial class frmPutDown : BaseTableForm
    {
        public PutDown putDown;
        public HearingNotice hearingNotice;

        public frmPutDown()
        {
            InitializeComponent();
            this.DocDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutDowns"));
        }

        public frmPutDown(PutDown putDown)
            : this()
        {
            this.putDown = putDown;
        }

        public frmPutDown(HearingNotice hearingNotice)
            : this()
        {
            this.hearingNotice = hearingNotice;
        }

        private void frmPutDown_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                HearBeginDate.Value = DateTime.Now;
                HearEndDate.Value = DateTime.Now;
                DocDate.Value = DateTime.Now;

                Organ.Text = InvokeUtil.ActiveUser.FullName;
                OrganAddress.Text = InvokeUtil.ActiveUser.FullName + "会议室";

                if (hearingNotice != null)
                {
                    CaseName.Text = hearingNotice.About;
                    OrganAddress.Text = hearingNotice.HearAddress;
                    CompereName.Text = hearingNotice.CompereName;
                    HearName.Text = hearingNotice.HearName1 + "、" + hearingNotice.HearName2;
                    SecretaryName.Text = hearingNotice.SecretaryName;

                    ProposerCompany.Text = hearingNotice.Informant;
                    if (hearingNotice.CompanyID != 0)
                    {
                        Company company = InvokeUtil.SystemService.EntityInit(new Company { CompanyID = hearingNotice.CompanyID }) as Company;
                        ProposerAddress.Text = company.CompanyAddress;
                        LegalRepre.Text = company.JuridicalPerson;
                        LegalRepreSex.Text = company.JuridicalPersonSex;
                        LegalRepreAge.Text = company.JuridicalPersonAge;
                    }

                }
                CaseName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                Investigador1.Items.Clear();
                Investigador2.Items.Clear();
                CompereName.Items.Clear();
                HearName.Items.Clear();
                SecretaryName.Items.Clear();
                ProposerOrAgent.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    Investigador1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    Investigador2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    CompereName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    HearName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    SecretaryName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ProposerOrAgent.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                ProposerCompany.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    ProposerCompany.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Proposer.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    Proposer.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                LegalRepreAgent1.Items.Clear();
                LegalRepreAgent2.Items.Clear();
                ProposerAgent1.Items.Clear();
                ProposerAgen2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Lawyer).FullName);
                foreach (SearchWord word in Words)
                {
                    LegalRepreAgent1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    LegalRepreAgent2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ProposerAgent1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ProposerAgen2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (putDown != null)
                {
                    SetEntity(putDown);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutDowns"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void Investigador1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (Investigador1.SelectedValue != null)
                {
                    SearchWord word = Investigador1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    InvestigadorIDC1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void Investigador2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (Investigador2.SelectedValue != null)
                {
                    SearchWord word = Investigador2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    InvestigadorIDC2.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void ProposerCompany_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ProposerCompany.SelectedValue != null)
                {
                    SearchWord word = ProposerCompany.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    ProposerAddress.Text = company.CompanyAddress;
                    LegalRepre.Text = company.JuridicalPerson;
                    LegalRepreSex.Text = company.JuridicalPersonSex;
                    LegalRepreAge.Text = company.JuridicalPersonAge;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void LegalRepreAgent1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (LegalRepreAgent1.SelectedValue != null)
                {
                    SearchWord word = LegalRepreAgent1.SelectedValue as SearchWord;
                    Lawyer lawyer = word.ToObject<Lawyer>();
                    LegalRepreAgentSex1.Text = lawyer.Sex;
                    LegalRepreAgentAge1.Text = lawyer.Age;
                    LegalRepreAgentJob1.Text = lawyer.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void LegalRepreAgent2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (LegalRepreAgent2.SelectedValue != null)
                {
                    SearchWord word = LegalRepreAgent2.SelectedValue as SearchWord;
                    Lawyer lawyer = word.ToObject<Lawyer>();
                    LegalRepreAgentSex2.Text = lawyer.Sex;
                    LegalRepreAgentAge2.Text = lawyer.Age;
                    LegalRepreAgentJob2.Text = lawyer.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void Proposer_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (Proposer.SelectedValue != null)
                {
                    SearchWord word = Proposer.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    ProposerSex.Text = naturalPerson.Sex;
                    ProposerAge.Text = naturalPerson.Age;
                    ProposerJob.Text = naturalPerson.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void ProposerAgent1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ProposerAgent1.SelectedValue != null)
                {
                    SearchWord word = ProposerAgent1.SelectedValue as SearchWord;
                    Lawyer lawyer = word.ToObject<Lawyer>();
                    ProposerAgentSex1.Text = lawyer.Sex;
                    ProposerAgentAge1.Text = lawyer.Age;
                    ProposerAgentJob1.Text = lawyer.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void ProposerAgen2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ProposerAgen2.SelectedValue != null)
                {
                    SearchWord word = ProposerAgen2.SelectedValue as SearchWord;
                    Lawyer lawyer = word.ToObject<Lawyer>();
                    ProposerAgentSex2.Text = lawyer.Sex;
                    ProposerAgentAge2.Text = lawyer.Age;
                    ProposerAgentJob2.Text = lawyer.Job;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批, (int)SOA.ORM.InstrumentsExample.EHearingChengpiType.听证笔录);
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

        private void SaveData()
        {
            if (putDown == null)
            {
                putDown = new PutDown();

                putDown.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(putDown);

            Officers officer1 = new Officers { OfficersName = Investigador1.Text, Position = InvestigadorIDC1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);
            Officers officer2 = new Officers { OfficersName = Investigador2.Text, Position = InvestigadorIDC2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            Company company = new Company
            {
                CompanyName = ProposerCompany.Text,
                CompanyAddress = ProposerAddress.Text,
                JuridicalPerson = LegalRepre.Text,
                JuridicalPersonSex = LegalRepreSex.Text,
                JuridicalPersonAge = LegalRepreAge.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            Lawyer legalRepreAgent1 = new Lawyer
            {
                LawyerName = LegalRepreAgent1.Text,
                Sex = LegalRepreAgentSex1.Text,
                Age = LegalRepreAgentAge1.Text,
                Job = LegalRepreAgentJob1.Text
            };
            InvokeUtil.SystemService.UpdateLawyer(legalRepreAgent1);

            Lawyer legalRepreAgent2 = new Lawyer
            {
                LawyerName = LegalRepreAgent2.Text,
                Sex = LegalRepreAgentSex2.Text,
                Age = LegalRepreAgentAge2.Text,
                Job = LegalRepreAgentJob2.Text
            };
            InvokeUtil.SystemService.UpdateLawyer(legalRepreAgent2);

            NaturalPerson person = new NaturalPerson
            {
                PersonName = Proposer.Text,
                Sex = ProposerSex.Text,
                Age = ProposerAge.Text,
                Job = ProposerJob.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(person);

            Lawyer proposerAgent1 = new Lawyer
            {
                LawyerName = ProposerAgent1.Text,
                Sex = ProposerAgentSex1.Text,
                Age = ProposerAgentAge1.Text,
                Job = ProposerAgentJob1.Text
            };
            InvokeUtil.SystemService.UpdateLawyer(proposerAgent1);

            Lawyer proposerAgent2 = new Lawyer
            {
                LawyerName = ProposerAgen2.Text,
                Sex = ProposerAgentSex2.Text,
                Age = ProposerAgentAge2.Text,
                Job = ProposerAgentJob2.Text
            };
            InvokeUtil.SystemService.UpdateLawyer(proposerAgent2);

            InvokeUtil.SystemService.EntityUpdate(putDown);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (putDown == null)
                {
                    putDown = new PutDown();

                    putDown.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                putDown.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("听证笔录");
                doc.AddField("CaseName", putDown.CaseName);
                doc.AddField("Organ", putDown.Organ);
                doc.AddField("OrganAddress", putDown.OrganAddress);
                doc.AddField("HearBeginDateYear", putDown.HearBeginDate.Year.ToString());
                doc.AddField("HearBeginDateMonth", putDown.HearBeginDate.Month.ToString());
                doc.AddField("HearBeginDateDay", putDown.HearBeginDate.Day.ToString());
                doc.AddField("HearBeginDateHour", putDown.HearBeginDate.Hour.ToString());
                doc.AddField("HearBeginDateMinute", putDown.HearBeginDate.Minute.ToString());
                doc.AddField("HearEndDateDay", putDown.HearEndDate.Day.ToString());
                doc.AddField("HearEndDateHour", putDown.HearEndDate.Hour.ToString());
                doc.AddField("HearEndDateMinute", putDown.HearEndDate.Minute.ToString());
                doc.AddField("CompereName", putDown.CompereName);
                doc.AddField("HearName", putDown.HearName);
                doc.AddField("SecretaryName", putDown.SecretaryName);
                doc.AddField("Investigador1", putDown.Investigador1);
                doc.AddField("InvestigadorIDC1", putDown.InvestigadorIDC1);
                doc.AddField("Investigador2", putDown.Investigador2);
                doc.AddField("InvestigadorIDC2", putDown.InvestigadorIDC2);
                doc.AddField("ProposerCompany", putDown.ProposerCompany);
                doc.AddField("ProposerAddress", putDown.ProposerAddress);
                doc.AddField("LegalRepre", putDown.LegalRepre);
                doc.AddField("LegalRepreSex", putDown.LegalRepreSex);
                doc.AddField("LegalRepreAge", putDown.LegalRepreAge.ToString());
                doc.AddField("LegalRepreAgent1", putDown.LegalRepreAgent1);
                doc.AddField("LegalRepreAgentSex1", putDown.LegalRepreAgentSex1);
                doc.AddField("LegalRepreAgentAge1", putDown.LegalRepreAgentAge1.ToString());
                doc.AddField("LegalRepreAgentJob1", putDown.LegalRepreAgentJob1);
                doc.AddField("LegalRepreAgent2", putDown.LegalRepreAgent2);
                doc.AddField("LegalRepreAgentSex2", putDown.LegalRepreAgentSex2);
                doc.AddField("LegalRepreAgentAge2", putDown.LegalRepreAgentAge2.ToString());
                doc.AddField("LegalRepreAgentJob2", putDown.LegalRepreAgentJob2);
                doc.AddField("Proposer", putDown.Proposer);
                doc.AddField("ProposerSex", putDown.ProposerSex.ToString());
                doc.AddField("ProposerAge", putDown.ProposerAge.ToString());
                doc.AddField("ProposerJob", putDown.ProposerJob);
                doc.AddField("ProposerAgent1", putDown.ProposerAgent1);
                doc.AddField("ProposerAgentSex1", putDown.ProposerAgentSex1);
                doc.AddField("ProposerAgentAge1", putDown.ProposerAgentAge1.ToString());
                doc.AddField("ProposerAgentJob1", putDown.ProposerAgentJob1);
                doc.AddField("ProposerAgen2", putDown.ProposerAgen2);
                doc.AddField("ProposerAgentSex2", putDown.ProposerAgentSex2);
                doc.AddField("ProposerAgentAge2", putDown.ProposerAgentAge2.ToString());
                doc.AddField("ProposerAgentJob2", putDown.ProposerAgentJob2);
                doc.AddField("ThirdPerson", putDown.ThirdPerson);
                doc.AddField("OhterPerson", putDown.OhterPerson);
                doc.AddField("Record", putDown.Record);
                doc.AddField("ProposerOrAgent", putDown.ProposerOrAgent);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmPutDowns", putDown.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

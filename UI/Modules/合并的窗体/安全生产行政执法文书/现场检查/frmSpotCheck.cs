using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnforceUI;
using EnforceUI.Input;
using SOA.ORM;
using Common;

namespace EnforceForm
{
    public partial class frmSpotCheck : BaseTableForm
    {
        private SpotCheck spotCheck = null;

        public frmSpotCheck()
        {
            InitializeComponent();
            CheckStartTime.Value = DateTime.Now;
            CheckEndTime.Value = DateTime.Now;
            CheckDate.Value = DateTime.Now;

            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e) {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotChecks"));
        }

        public frmSpotCheck(SpotCheck spotCheck)
            : this()
        {
            this.spotCheck = spotCheck;
        }

        public frmSpotCheck(object obj) : this() {
            this.spotCheck = (SpotCheck)obj;
        }

        

        private void frmSpotCheck_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                CheckAddress.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(CheckPlace).FullName);
                foreach (SearchWord word in Words)
                    CheckAddress.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Area.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    Area.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                OfficerName1.Items.Clear();
                OfficerName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    OfficerName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    OfficerName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                Area.Text = InvokeUtil.ActiveUser.Area;

                if (spotCheck != null)
                {
                    SetEntity(spotCheck);
                }
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

        private void OfficerName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (OfficerName1.SelectedValue != null)
                {
                    SearchWord word = OfficerName1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    CID1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void OfficerName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (OfficerName2.SelectedValue != null)
                {
                    SearchWord word = OfficerName2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    CID2.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void OfficerName1_TextChanged(object sender, EventArgs e)
        {
            CheckPerson1.Text = OfficerName1.Text;
        }

        private void OfficerName2_TextChanged(object sender, EventArgs e)
        {
            CheckPerson2.Text = OfficerName2.Text;
        }

        private void JuridicalName_TextChanged(object sender, EventArgs e)
        {
            SiteJuridical.Text = JuridicalName.Text;
        }

        private void SaveData()
        {
            if (spotCheck == null) {
                spotCheck = new SpotCheck();

                spotCheck.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(spotCheck);

            Company company = new Company
            {
                CompanyName = CompanyName.Text,
                CompanyAddress = CompanyAddress.Text,
                JuridicalPerson = JuridicalName.Text,
                JuridicalPersonJob = JuridicalJob.Text,
                Mobile = JuridicalTel.Text
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            CheckPlace checkPlace = new CheckPlace { CheckContent = CheckAddress.Text };
            InvokeUtil.SystemService.UpdateCheckPlace(checkPlace);

            Officers officer1 = new Officers { OfficersName = OfficerName1.Text, CID = CID1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer2 = new Officers { OfficersName = OfficerName2.Text, CID = CID2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            InvokeUtil.SystemService.EntityUpdate(spotCheck);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                //CloseWindow();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotChecks"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotCheck == null) {
                    spotCheck = new SpotCheck();
                    spotCheck.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                spotCheck.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("现场检查记录");
                doc.Entity = spotCheck;
                doc.AddField("CompanyName", spotCheck.CompanyName);
                doc.AddField("CompanyAddress", spotCheck.CompanyAddress);
                doc.AddField("CheckAddress", spotCheck.CheckAddress);
                doc.AddField("JuridicalName", spotCheck.JuridicalName);
                doc.AddField("JuridicalJob", spotCheck.JuridicalJob);
                doc.AddField("JuridicalTel", spotCheck.JuridicalTel);
                doc.AddField("CheckStartTimeYear", spotCheck.CheckStartTime.Year.ToString());
                doc.AddField("CheckStartTimeMonth", spotCheck.CheckStartTime.Month.ToString());
                doc.AddField("CheckStartTimeDay", spotCheck.CheckStartTime.Day.ToString());
                doc.AddField("CheckStartTimeHours", spotCheck.CheckStartTime.Hour.ToString());
                doc.AddField("CheckStartTimeMinute", spotCheck.CheckStartTime.Minute.ToString());
                doc.AddField("CheckEndTimeDay", spotCheck.CheckEndTime.Day.ToString());
                doc.AddField("CheckEndTimeHours", spotCheck.CheckEndTime.Hour.ToString());
                doc.AddField("CheckEndTimeMinute", spotCheck.CheckEndTime.Minute.ToString());
                doc.AddField("Area", spotCheck.Area);
                doc.AddField("OfficerName1", spotCheck.OfficerName1);
                doc.AddField("OfficerName2", spotCheck.OfficerName2);
                doc.AddField("CID1", spotCheck.CID1);
                doc.AddField("CID2", spotCheck.CID2);
                doc.AddField("CheckCondition", spotCheck.CheckCondition);
                doc.AddField("SpotCondition", spotCheck.SpotCondition);
                //doc.AddField("CheckPerson1", spotCheck.CheckPerson1);
                //doc.AddField("CheckPerson2", spotCheck.CheckPerson2);
                //doc.AddField("SiteJuridical", spotCheck.SiteJuridical);
                //doc.AddField("CheckDate", spotCheck.CheckDate.ToString("yyyy年M月d日"));

                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt", 
                    new object[] { doc, "EnforceForm.frmSpotChecks", spotCheck.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场检查记录);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    //frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
                    //frm.OpenWindow(this);

                    SaveData();
                    OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInstrumentsExampleContent",
                            new object[] { InstrumentsExamples.Items[0], "EnforceForm.frmSpotCheck", spotCheck }));
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            //frm.OpenWindow(this);
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers", new object[] { "EnforceForm.frmSpotCheck", spotCheck }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

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
    public partial class frmExplorationRecord : BaseTableForm
    {
        private ExplorationRecord explorationRecord = null;
        public frmExplorationRecord()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmExplorationRecords"));
        }

        public frmExplorationRecord(ExplorationRecord explorationRecord)
            : this()
        {
            this.explorationRecord = explorationRecord;
        }

        private void frmExplorationRecord_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管勘( " + DateTime.Now.Year + " ) 1 号";
                BeganTime.Value = DateTime.Now;
                ToTime.Value = DateTime.Now;
                TheEPeopleName1.Items.Clear();
                TheEPeopleName2.Items.Clear();
                InvitedEPeopleName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    TheEPeopleName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    TheEPeopleName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    InvitedEPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                EUserName1.Items.Clear();
                EUserName2.Items.Clear();
                RecordUserName.Items.Clear();
                QFirstPersonUser1.Items.Clear();
                QFirstPerson2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    EUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    EUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    RecordUserName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPersonUser1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPerson2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (explorationRecord != null)
                {
                    SetEntity(explorationRecord);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmExplorationRecords"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        
        private void EUserName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (EUserName1.SelectedValue != null)
                {
                    SearchWord word = EUserName1.SelectedValue as SearchWord;
                    Officers officers = word.ToObject<Officers>();
                    ECompanyName1.Text = officers.Unit + officers.Position;
                    QFirstPersonUser1.Text = officers.OfficersName;
                    QFirstPersonIDC1.Text = officers.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void EUserName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (EUserName2.SelectedValue != null)
                {
                    SearchWord word = EUserName2.SelectedValue as SearchWord;
                    Officers officers = word.ToObject<Officers>();
                    ECompanyName2.Text = officers.Unit + officers.Position;
                    QFirstPerson2.Text = officers.OfficersName;
                    QFirstPerson2IDC2.Text = officers.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void TheEPeopleName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (TheEPeopleName1.SelectedValue != null)
                {
                    SearchWord word = TheEPeopleName1.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    TheECompanyName1.Text = naturalPerson.CompanyName + naturalPerson.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void TheEPeopleName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (TheEPeopleName2.SelectedValue != null)
                {
                    SearchWord word = TheEPeopleName2.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    TheECompanyName2.Text = naturalPerson.CompanyName + naturalPerson.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void InvitedEPeopleName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (InvitedEPeopleName.SelectedValue != null)
                {
                    SearchWord word = InvitedEPeopleName.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    InvitedECompanyName.Text = naturalPerson.CompanyName + naturalPerson.Job;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void RecordUserName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (RecordUserName.SelectedValue != null)
                {
                    SearchWord word = RecordUserName.SelectedValue as SearchWord;
                    Officers officers = word.ToObject<Officers>();
                    RecordCompanyName.Text = officers.Unit + officers.Position;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void QFirstPersonUser1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (QFirstPersonUser1.SelectedValue != null)
                {
                    SearchWord word = QFirstPersonUser1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    QFirstPersonIDC1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void QFirstPerson2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (QFirstPerson2.SelectedValue != null)
                {
                    SearchWord word = QFirstPerson2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    QFirstPerson2IDC2.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SaveData()
        {
            if (explorationRecord == null)
            {
                explorationRecord = new ExplorationRecord();
                explorationRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            ToTime.Value = DateTime.Parse(BeganTime.Value.ToString("yyyy-MM-dd") + ToTime.Value.ToString(" HH:mm:ss"));

            GetEntity(explorationRecord);

            InvokeUtil.SystemService.EntityUpdate(explorationRecord);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (explorationRecord == null)
                {
                    explorationRecord = new ExplorationRecord();
                    explorationRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                explorationRecord.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("勘验笔录");
                doc.AddField("DocTitle", explorationRecord.DocTitle);
                doc.AddField("BeganTimeYear", explorationRecord.BeganTime.Year.ToString());
                doc.AddField("BeganTimeMonth", explorationRecord.BeganTime.Month.ToString());
                doc.AddField("BeganTimeDay", explorationRecord.BeganTime.Day.ToString());
                doc.AddField("BeganTimeHour", explorationRecord.BeganTime.Hour.ToString());
                doc.AddField("BeganTimeMinute", explorationRecord.BeganTime.Minute.ToString());
                doc.AddField("ToTimeDay", explorationRecord.ToTime.Day.ToString());
                doc.AddField("ToTimeHour", explorationRecord.ToTime.Hour.ToString());
                doc.AddField("ToTimeMinute", explorationRecord.ToTime.Minute.ToString());
                doc.AddField("Address", explorationRecord.Address);
                doc.AddField("Weather", explorationRecord.Weather);
                doc.AddField("EUserName1", explorationRecord.EUserName1);
                doc.AddField("ECompanyName1", explorationRecord.ECompanyName1);
                doc.AddField("EUserName2", explorationRecord.EUserName2);
                doc.AddField("ECompanyName2", explorationRecord.ECompanyName2);
                doc.AddField("TheEPeopleName1", explorationRecord.TheEPeopleName1);
                doc.AddField("TheECompanyName1", explorationRecord.TheECompanyName1);
                doc.AddField("TheEPeopleName2", explorationRecord.TheEPeopleName2);
                doc.AddField("TheECompanyName2", explorationRecord.TheECompanyName2);
                doc.AddField("InvitedEPeopleName", explorationRecord.InvitedEPeopleName);
                doc.AddField("InvitedECompanyName", explorationRecord.InvitedECompanyName);
                doc.AddField("RecordUserName", explorationRecord.RecordUserName);
                doc.AddField("RecordCompanyName", explorationRecord.RecordCompanyName);
                doc.AddField("QFirstPerson1", explorationRecord.QFirstPerson1);
                doc.AddField("QFirstPersonUser1", explorationRecord.QFirstPersonUser1);
                doc.AddField("QFirstPerson2", explorationRecord.QFirstPerson2);
                doc.AddField("QFirstPersonIDC1", explorationRecord.QFirstPersonIDC1);
                doc.AddField("QFirstPerson2IDC2", explorationRecord.QFirstPerson2IDC2);
                doc.AddField("ESituation", explorationRecord.ESituation);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmExplorationRecords", explorationRecord.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.勘验笔录);
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

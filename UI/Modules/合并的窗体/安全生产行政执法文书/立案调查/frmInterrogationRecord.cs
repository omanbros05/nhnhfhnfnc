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
    public partial class frmInterrogationRecord : BaseTableForm
    {
        private InterrogationRecord interrogationRecord = null;
        public frmInterrogationRecord()
        {
            InitializeComponent();
            this.RecordDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInterrogationRecords"));
        }

        public frmInterrogationRecord(InterrogationRecord interrogationRecord)
            : this()
        {
            this.interrogationRecord = interrogationRecord;
        }

        private void frmInterrogationRecord_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                BeganTime.Value = DateTime.Now;
                ToTime.Value = DateTime.Now;
                RecordDate.Value = DateTime.Now;

                BeAskEPeopleName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    BeAskEPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                AskUserName.Items.Clear();
                RecordUserName.Items.Clear();
                QFirstPersonName1.Items.Clear();
                QFirstPerson2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    AskUserName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    RecordUserName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPersonName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPerson2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                QFirstPerson1.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    QFirstPerson1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                if (interrogationRecord != null)
                {
                    interrogationRecord = InvokeUtil.SystemService.EntityInit(interrogationRecord) as InterrogationRecord;
                    SetEntity(interrogationRecord);
                    foreach (EnquireQuestionItem item in interrogationRecord.Items)
                        questionContainer.Add(new AskAndAnswer { Question = item.Question, Answer = item.Anwser });
                }
                if (questionContainer.Controls[0].Controls.Count == 0)
                {
                    questionContainer.Init();
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInterrogationRecords"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        
        private void BeAskEPeopleName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (BeAskEPeopleName.SelectedValue != null)
                {
                    SearchWord word = BeAskEPeopleName.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    BeAskEPeopleSex.Text = naturalPerson.Sex;
                    BeAskEPeopleAge.Text = naturalPerson.Age;
                    BeAskEPeopleID.Text = naturalPerson.IDcard;
                    BeAskEPeopleCompanyName.Text = naturalPerson.CompanyName;
                    BeAskEPeopleAddress.Text = naturalPerson.Address;
                    BeAskEPeoplePhone.Text = naturalPerson.CompanyTel;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void QFirstPersonName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (QFirstPersonName1.SelectedValue != null)
                {
                    SearchWord word = QFirstPersonName1.SelectedValue as SearchWord;
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

        private void AskUserName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (AskUserName.SelectedValue != null)
                {
                    SearchWord word = AskUserName.SelectedValue as SearchWord;
                    Officers officers = word.ToObject<Officers>();
                    AskUserCompanyName.Text = officers.Unit;
                    QFirstPersonName1.Text = officers.OfficersName;
                    QFirstPersonIDC1.Text = officers.CID;
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
                    RecordCompanyName.Text = officers.Unit + "," + officers.Position;
                    QFirstPerson2.Text = officers.OfficersName;
                    QFirstPerson2IDC2.Text = officers.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void SaveData()
        {
            if (interrogationRecord == null)
            {
                interrogationRecord = new InterrogationRecord();
                interrogationRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            ToTime.Value = DateTime.Parse(BeganTime.Value.ToString("yyyy-MM-dd") + ToTime.Value.ToString(" HH:mm:ss"));

            GetEntity(interrogationRecord);

            NaturalPerson naturalPerson = new NaturalPerson
            {
                PersonName = BeAskEPeopleName.Text,
                Sex = BeAskEPeopleSex.Text,
                Age = BeAskEPeopleAge.Text,
                IDcard = BeAskEPeopleID.Text,
                CompanyName = BeAskEPeopleCompanyName.Text,
                Address = BeAskEPeopleAddress.Text,
                CompanyTel = BeAskEPeoplePhone.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);
            Officers officer1 = new Officers { OfficersName = AskUserName.Text, Unit = AskUserCompanyName.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);
            Officers officer2 = new Officers { OfficersName = RecordUserName.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            List<AskAndAnswer> Answers = questionContainer.GetItems();
            interrogationRecord.Items.Clear();
            foreach (AskAndAnswer answer in Answers)
            {
                interrogationRecord.Items.Add(new EnquireQuestionItem { Anwser = answer.Answer, Question = answer.Question });
            }
            InvokeUtil.SystemService.EntityUpdate(interrogationRecord);
            //InvokeUtil.SystemService.EntityUpdate(enquireQuestion);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (interrogationRecord == null)
                {
                    interrogationRecord = new InterrogationRecord();
                    interrogationRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                interrogationRecord.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("询问笔录");
                doc.AddField("BeganTimeYear", interrogationRecord.BeganTime.Year.ToString());
                doc.AddField("BeganTimeMonth", interrogationRecord.BeganTime.Month.ToString());
                doc.AddField("BeganTimeDay", interrogationRecord.BeganTime.Day.ToString());
                doc.AddField("BeganTimeHour", interrogationRecord.BeganTime.Hour.ToString());
                doc.AddField("BeganTimeMinute", interrogationRecord.BeganTime.Minute.ToString());
                doc.AddField("ToTimeDay", interrogationRecord.ToTime.Day.ToString());
                doc.AddField("ToTimeHour", interrogationRecord.ToTime.Hour.ToString());
                doc.AddField("ToTimeMinute", interrogationRecord.ToTime.Minute.ToString());
                doc.AddField("InterrogationRecordCount", interrogationRecord.InterrogationRecordCount.ToString());
                doc.AddField("AskAddress", interrogationRecord.AskAddress);
                doc.AddField("BeAskEPeopleName", interrogationRecord.BeAskEPeopleName);
                doc.AddField("BeAskEPeopleSex", interrogationRecord.BeAskEPeopleSex);
                doc.AddField("BeAskEPeopleAge", interrogationRecord.BeAskEPeopleAge);
                doc.AddField("BeAskEPeopleID", interrogationRecord.BeAskEPeopleID);
                doc.AddField("BeAskEPeopleCompanyName", interrogationRecord.BeAskEPeopleCompanyName);
                doc.AddField("BeAskEPeoplePosition", interrogationRecord.BeAskEPeoplePosition);
                doc.AddField("BeAskEPeopleAddress", interrogationRecord.BeAskEPeopleAddress);
                doc.AddField("BeAskEPeoplePhone", interrogationRecord.BeAskEPeoplePhone);
                doc.AddField("AskUserName", interrogationRecord.AskUserName);
                doc.AddField("AskUserCompanyName", interrogationRecord.AskUserCompanyName);
                doc.AddField("RecordUserName", interrogationRecord.RecordUserName);
                doc.AddField("RecordCompanyName", interrogationRecord.RecordCompanyName);
                doc.AddField("PresentEPeopleName", interrogationRecord.PresentEPeopleName);
                doc.AddField("QFirstPerson1", interrogationRecord.QFirstPerson1 + "安全生产监督管理局的执法");
                doc.AddField("QFirstPersonName1", interrogationRecord.QFirstPersonName1);
                doc.AddField("QFirstPerson2", interrogationRecord.QFirstPerson2);
                doc.AddField("QFirstPersonIDC1", interrogationRecord.QFirstPersonIDC1);
                doc.AddField("QFirstPerson2IDC2", interrogationRecord.QFirstPerson2IDC2);
                doc.AddField("QFirstAnswer", interrogationRecord.QFirstAnswer);
                doc.AddField("QuestionSecond", interrogationRecord.QuestionSecond);
                doc.AddField("QuestionSecondAnswer", interrogationRecord.QuestionSecondAnswer);
                doc.AddField("QuestionThirdAnswer", interrogationRecord.QuestionThirdAnswer);
                //doc.AddField("Questions", interrogationRecord.Questions);
                string Questions = "";
                foreach (EnquireQuestionItem item in interrogationRecord.Items)
                    Questions += "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">问：" + item.Question + "</font><br />"
                        + "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">答：" + item.Anwser + "</font><br />";
                doc.AddField("Questions", Questions,EFieldType.Html);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmInterrogationRecords", interrogationRecord.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.询问笔录);
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

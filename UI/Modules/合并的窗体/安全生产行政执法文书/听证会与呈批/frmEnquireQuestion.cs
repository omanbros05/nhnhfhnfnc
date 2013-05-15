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
    public partial class frmEnquireQuestion : BaseTableForm
    {
        public EnquireQuestion enquireQuestion;

        public frmEnquireQuestion()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEnquireQuestions"));
        }

        public frmEnquireQuestion(EnquireQuestion enquireQuestion)
            : this()
        {
            this.enquireQuestion = enquireQuestion;
        }

        private void frmEnquireQuestion_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                EnquirePerson.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    EnquirePerson.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                EnquirerName.Items.Clear();
                WriterName.Items.Clear();
                QFirstPerson1.Items.Clear();
                QFirstPerson2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    EnquirerName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    WriterName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPerson1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    QFirstPerson2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                QFirstUnit.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    QFirstUnit.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                questionContainer.Entries = new List<AutoCompleteEntry>();
                questionContainer.Entries.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Question).FullName);
                foreach (SearchWord word in Words)
                    questionContainer.Entries.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                if (enquireQuestion != null)
                {
                    enquireQuestion = InvokeUtil.SystemService.EntityInit(enquireQuestion) as EnquireQuestion;
                    SetEntity(enquireQuestion);
                    foreach (EnquireQuestionItem item in enquireQuestion.Items)
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

                if (enquireQuestion == null)
                {
                    enquireQuestion = new EnquireQuestion();

                    enquireQuestion.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                GetEntity(enquireQuestion);
                NaturalPerson naturalPerson = new NaturalPerson
                {
                    Sex = EnquirePersonSex.Text,
                    Age = EnquirePersonAge.Text,
                    IDcard = EnquirePersonIDC.Text,
                    CompanyName = EnquirePersonUnit.Text,
                    Job = EnquirePersonJob.Text,
                    CompanyAddress = EnquirePersonAddress.Text,
                    CompanyTel = EnquirePersonTel.Text
                };
                InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);

                List<AskAndAnswer> Answers = questionContainer.GetItems();
                enquireQuestion.Items.Clear();
                foreach (AskAndAnswer answer in Answers)
                {
                    enquireQuestion.Items.Add(new EnquireQuestionItem { Anwser = answer.Answer, Question = answer.Question });
                }

                InvokeUtil.SystemService.EntityUpdate(enquireQuestion);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEnquireQuestions"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void EnquirePerson_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (EnquirePerson.SelectedValue != null)
                {
                    SearchWord word = EnquirePerson.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    EnquirePersonSex.Text = naturalPerson.Sex;
                    EnquirePersonAge.Text = naturalPerson.Age;
                    EnquirePersonIDC.Text = naturalPerson.IDcard;
                    EnquirePersonUnit.Text = naturalPerson.CompanyName;
                    EnquirePersonJob.Text = naturalPerson.Job;
                    EnquirePersonAddress.Text = naturalPerson.CompanyAddress;
                    EnquirePersonTel.Text = naturalPerson.CompanyTel;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void EnquirerName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (EnquirerName.SelectedValue != null)
                {
                    SearchWord word = EnquirerName.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    EnquirerUnit.Text = officer.Unit;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void WriterName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (WriterName.SelectedValue != null)
                {
                    SearchWord word = WriterName.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    WriterUnit.Text = officer.Unit;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void QFirstPerson1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (QFirstPerson1.SelectedValue != null)
                {
                    SearchWord word = QFirstPerson1.SelectedValue as SearchWord;
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

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批, (int)SOA.ORM.InstrumentsExample.EHearingChengpiType.询问笔录L收集相关证据R);
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (enquireQuestion == null)
                {
                    enquireQuestion = new EnquireQuestion();

                    enquireQuestion.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                enquireQuestion.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("询问笔录");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmEnquireQuestions", enquireQuestion.FilePath }));

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (enquireQuestion == null)
            {
                enquireQuestion = new EnquireQuestion();

                enquireQuestion.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(enquireQuestion);

            InvokeUtil.SystemService.EntityUpdate(enquireQuestion);
        }
    }
}

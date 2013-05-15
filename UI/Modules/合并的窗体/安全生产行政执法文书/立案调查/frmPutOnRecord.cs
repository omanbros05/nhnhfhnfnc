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
    public partial class frmPutOnRecord : BaseTableForm
    {
        private PutOnRecord putOnRecord = null;
        public frmPutOnRecord()
        {
            InitializeComponent();
            this.UndertakerData.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutOnRecords"));
        }

        public frmPutOnRecord(PutOnRecord putOnRecord)
            : this()
        {
            this.putOnRecord = putOnRecord;
        }

        private void frmPutOnRecord_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管立〔" + DateTime.Now.Year + "〕1 号";
                ThisDate.Value = DateTime.Now;
                UndertakerData.Value = DateTime.Now;

                CompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                IllegalTypeName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(IllegalType).FullName);
                foreach (SearchWord word in Words)
                    IllegalTypeName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                CaseSourceName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(CaseSource).FullName);
                foreach (SearchWord word in Words)
                    CaseSourceName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                UndertakerUserName1.Items.Clear();
                UndertakerUserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UndertakerUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UndertakerUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (putOnRecord != null)
                {
                    SetEntity(putOnRecord);
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
               // CloseWindow();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutOnRecords"));
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
                    PeoplePhone.Text = company.Tel;
                    PeopleCondition.Text = "法定代表人：" + company.JuridicalPerson + "，"
                        + company.JuridicalPersonSex + "，" + company.JuridicalPersonAge + "岁，"
                        + company.JuridicalPersonJob;
                    PeopleAddress.Text = company.CompanyAddress;
                    PeopleZip.Text = company.CompanyPost;
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
                if (putOnRecord == null)
                {
                    putOnRecord = new PutOnRecord();
                    putOnRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                putOnRecord.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("立案审批表");
                doc.AddField("DocTitle", putOnRecord.DocTitle);
                doc.AddField("IllegalTypeName", putOnRecord.IllegalTypeName);
                doc.AddField("CaseSourceName", putOnRecord.CaseSourceName);
                doc.AddField("ThisDate", putOnRecord.ThisDate.ToString("yyyy年M月d日"));
                doc.AddField("CaseName", putOnRecord.CaseName);
                doc.AddField("CompanyName", putOnRecord.CompanyName);
                doc.AddField("PeoplePhone", putOnRecord.PeoplePhone);
                doc.AddField("PeopleCondition", putOnRecord.PeopleCondition);
                doc.AddField("PeopleAddress", putOnRecord.PeopleAddress);
                doc.AddField("PeopleZip", putOnRecord.PeopleZip);
                doc.AddField("CaseStatus", putOnRecord.CaseStatus);
                doc.AddField("UndertakerOpinion", putOnRecord.UndertakerOpinion);
                doc.AddField("UndertakerUserName1", putOnRecord.UndertakerUserName1);
                doc.AddField("UndertakerUserName2", putOnRecord.UndertakerUserName2);
                doc.AddField("UndertakerDataDay", putOnRecord.UndertakerData.Day.ToString());
                doc.AddField("UndertakerDataYear", putOnRecord.UndertakerData.Year.ToString());
                doc.AddField("UndertakerDataMonth", putOnRecord.UndertakerData.Month.ToString());
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt", 
                    new object[] { doc, "EnforceForm.frmPutOnRecords", putOnRecord.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {
            if (putOnRecord == null)
            {
                putOnRecord = new PutOnRecord();
                putOnRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }


            GetEntity(putOnRecord);

            Company company = new Company
            {
                CompanyName = CompanyName.Text,
                CompanyAddress = PeopleAddress.Text,
                CompanyPost = PeopleZip.Text,
                Tel = PeoplePhone.Text
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            IllegalType illegalType = new IllegalType
            {
                TypeName = IllegalTypeName.Text,
            };
            InvokeUtil.SystemService.UpdateIllegalTypeByName(illegalType);

            CaseSource caseSource = new CaseSource
            {
                SourceName = CaseSourceName.Text,
            };
            InvokeUtil.SystemService.UpdateCaseSourceByName(caseSource);

            InvokeUtil.SystemService.EntityUpdate(putOnRecord);
        }

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.立案审批表);
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

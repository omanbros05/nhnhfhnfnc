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
    public partial class frmCaseCancel : BaseTableForm
    {
        private CaseCancel caseCancel = null;
        public frmCaseCancel()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.frmCaseCancels"));
        }

        public frmCaseCancel(CaseCancel caseCancel)
            : this()
        {
            this.caseCancel = caseCancel;
        }

        private void frmCaseCancel_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管撤( " + DateTime.Now.Year + " ) 1 号";
                PutOnRecordThisDate.Value = DateTime.Now;
                UndertakerData.Value = DateTime.Now;
                UndertakerUserName1.Items.Clear();
                UndertakerUserName2.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UndertakerUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UndertakerUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                PutOnRecordCaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    PutOnRecordCaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (caseCancel != null)
                {
                    SetEntity(caseCancel);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.frmCaseCancels"));
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
                    PutOnRecord putOnRecord = word.ToObject<PutOnRecord>();
                    PutOnRecordDocTitle.Text = putOnRecord.DocTitle;
                    PutOnRecordPeopleName.Text = putOnRecord.CompanyName;
                    PutOnRecordFName.Text = putOnRecord.PeopleCondition;
                    PutOnRecordPeopleAddress.Text = putOnRecord.PeopleAddress;
                    PutOnRecordPeoplePhone.Text = putOnRecord.PeoplePhone;
                    PutOnRecordSourceName.Text = putOnRecord.CaseSourceName;
                    PutOnRecordUserNames1.Text = putOnRecord.UndertakerUserName1;
                    PutOnRecordUserNames2.Text = putOnRecord.UndertakerUserName2;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SaveData()
        {
            if (caseCancel == null)
            {
                caseCancel = new CaseCancel();

                caseCancel.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(caseCancel);

            InvokeUtil.SystemService.EntityUpdate(caseCancel);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (caseCancel == null)
                {
                    caseCancel = new CaseCancel();

                    caseCancel.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                caseCancel.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件终止（撤销）审批表");
                doc.AddField("DocTitle", caseCancel.DocTitle);
                doc.AddField("PutOnRecordCaseName", caseCancel.PutOnRecordCaseName);
                doc.AddField("PutOnRecordThisDate", caseCancel.PutOnRecordThisDate.ToString("yyyy年MM月dd日"));
                doc.AddField("PutOnRecordDocTitle", caseCancel.PutOnRecordDocTitle);
                doc.AddField("PutOnRecordPeopleName", caseCancel.PutOnRecordPeopleName);
                doc.AddField("PutOnRecordFName", caseCancel.PutOnRecordFName);
                doc.AddField("PutOnRecordPeopleAddress", caseCancel.PutOnRecordPeopleAddress);
                doc.AddField("PutOnRecordPeoplePhone", caseCancel.PutOnRecordPeoplePhone);
                doc.AddField("PutOnRecordSourceName", caseCancel.PutOnRecordSourceName);
                doc.AddField("PutOnRecordUserNames1", caseCancel.PutOnRecordUserNames1 + (caseCancel.PutOnRecordUserNames2!=""?"、"+caseCancel.PutOnRecordUserNames2:""));
                doc.AddField("ResearchDetail", caseCancel.ResearchDetail);
                doc.AddField("RevocationReason", caseCancel.RevocationReason);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmCaseCancels", caseCancel.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.案件终止或撤销审批表);
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

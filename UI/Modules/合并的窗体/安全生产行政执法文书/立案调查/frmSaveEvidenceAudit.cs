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
    public partial class frmSaveEvidenceAudit : BaseTableForm
    {
        private SaveEvidenceAudit saveEvidenceAudit = null;
        public frmSaveEvidenceAudit()
        {
            InitializeComponent();
            this.UndertakerData.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }



        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceAudits"));
        }

        public frmSaveEvidenceAudit(SaveEvidenceAudit saveEvidenceAudit)
            : this()
        {
            this.saveEvidenceAudit = saveEvidenceAudit;
        }

        private void frmSaveEvidenceAudit_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
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
                if (saveEvidenceAudit != null)
                {
                    SetEntity(saveEvidenceAudit);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceAudits"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {

            if (saveEvidenceAudit == null)
            {
                saveEvidenceAudit = new SaveEvidenceAudit();

                saveEvidenceAudit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(saveEvidenceAudit);

            InvokeUtil.SystemService.EntityUpdate(saveEvidenceAudit);
        }
        private void PutOnRecordCaseName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PutOnRecordCaseName.SelectedValue != null)
                {
                    SearchWord word = PutOnRecordCaseName.SelectedValue as SearchWord;
                    PutOnRecord putOnRecord = word.ToObject<PutOnRecord>();
                    PutOnRecordCasePeopleInfo.Text = putOnRecord.CompanyName + "," + putOnRecord.PeopleCondition + "," + putOnRecord.PeopleAddress;
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

                if (saveEvidenceAudit == null)
                {
                    saveEvidenceAudit = new SaveEvidenceAudit();
                    saveEvidenceAudit.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                saveEvidenceAudit.Status = 1;

                SaveData();
                WordDocument doc = new WordDocument("先行登记保存证据审批表");
                doc.AddField("PutOnRecordCaseName", saveEvidenceAudit.PutOnRecordCaseName);
                doc.AddField("PutOnRecordCasePeopleInfo", saveEvidenceAudit.PutOnRecordCasePeopleInfo);
                doc.AddField("PutOnRecordCaseContent", saveEvidenceAudit.PutOnRecordCaseContent);
                doc.AddField("SamplingID", saveEvidenceAudit.SamplingID);
                doc.AddField("ReasonBasis", saveEvidenceAudit.ReasonBasis);
                doc.AddField("SavaWay", saveEvidenceAudit.SavaWay);
                doc.AddField("UndertakerOpinion", saveEvidenceAudit.UndertakerOpinion);
                doc.AddFootField("UndertakerDataYear", saveEvidenceAudit.UndertakerData.Year.ToString());
                doc.AddFootField("UndertakerDataMonth", saveEvidenceAudit.UndertakerData.Month.ToString());
                doc.AddFootField("UndertakerDataDay", saveEvidenceAudit.UndertakerData.Day.ToString());
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSaveEvidenceAudit", saveEvidenceAudit.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.先行登记保存证据处理审批表);
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

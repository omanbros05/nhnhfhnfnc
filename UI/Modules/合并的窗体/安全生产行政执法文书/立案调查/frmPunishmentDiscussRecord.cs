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
    public partial class frmPunishmentDiscussRecord : BaseTableForm
    {
        private PunishmentDiscussRecord punishmentDiscussRecord = null;
        public frmPunishmentDiscussRecord()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPunishmentDiscussRecords"));
        }

        public frmPunishmentDiscussRecord(PunishmentDiscussRecord punishmentDiscussRecord)
            : this()
        {
            this.punishmentDiscussRecord = punishmentDiscussRecord;
        }

        private void frmPunishmentDiscussRecord_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DiscussDate.Value = DateTime.Now;
                HostName.Items.Clear();
                ReportName.Items.Clear();
                RecordUserName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    HostName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ReportName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    RecordUserName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                PutOnRecordCaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    PutOnRecordCaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (punishmentDiscussRecord != null)
                {
                    SetEntity(punishmentDiscussRecord);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPunishmentDiscussRecords"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {

            if (punishmentDiscussRecord == null)
            {
                punishmentDiscussRecord = new PunishmentDiscussRecord();

                punishmentDiscussRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(punishmentDiscussRecord);

            InvokeUtil.SystemService.EntityUpdate(punishmentDiscussRecord);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {

                if (punishmentDiscussRecord == null)
                {
                    punishmentDiscussRecord = new PunishmentDiscussRecord();

                    punishmentDiscussRecord.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                punishmentDiscussRecord.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("行政处罚集体讨论记录");
                doc.AddField("PutOnRecordCaseName", punishmentDiscussRecord.PutOnRecordCaseName);
                doc.AddField("DiscussDate", punishmentDiscussRecord.DiscussDate.ToString("yyyy年MM月dd日"));
                doc.AddField("DiscussAddress", punishmentDiscussRecord.DiscussAddress);
                doc.AddField("HostName", punishmentDiscussRecord.HostName);
                doc.AddField("ReportName", punishmentDiscussRecord.ReportName);
                doc.AddField("RecordUserName", punishmentDiscussRecord.RecordUserName);
                doc.AddField("PDRPeople1", punishmentDiscussRecord.PDRPeople1);
                doc.AddField("PDRPeople2", punishmentDiscussRecord.PDRPeople2);
                doc.AddField("DiscussContent", punishmentDiscussRecord.DiscussContent);
                doc.AddField("RecordContent", punishmentDiscussRecord.RecordContent);
                doc.AddField("Conclusion", punishmentDiscussRecord.Conclusion);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmPunishmentDiscussRecords", punishmentDiscussRecord.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.行政处罚集体讨论记录);
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

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
    public partial class frmDocumentsServiceReply : BaseTableForm
    {
        private DocumentsServiceReply documentsServiceReply = null;
        public frmDocumentsServiceReply()
        {
            InitializeComponent();
        }
        public frmDocumentsServiceReply(DocumentsServiceReply documentsServiceReply)
            : this()
        {
            this.documentsServiceReply = documentsServiceReply;
        }

        private void frmDocumentsServiceReply_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管回( " + DateTime.Now.Year + " ) 1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                CompanyName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                PutOnRecordCaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    PutOnRecordCaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (documentsServiceReply != null)
                {
                    SetEntity(documentsServiceReply);
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
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (documentsServiceReply == null)
                documentsServiceReply = new DocumentsServiceReply();

            GetEntity(documentsServiceReply);
            Company company = new Company
            {
                CompanyName = CompanyName.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);


            InvokeUtil.SystemService.EntityUpdate(documentsServiceReply);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                WordDocument doc = new WordDocument("文书送达回执");
                doc.AddField("PutOnRecordCaseName", documentsServiceReply.PutOnRecordCaseName);
                doc.AddField("CompanyName", documentsServiceReply.CompanyName);
                doc.AddField("DocManageArea", documentsServiceReply.DocManageArea);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚, (int)SOA.ORM.InstrumentsExample.EAdminPunishType.文书送达回执);
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

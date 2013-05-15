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
    public partial class frmEditFineCallsNotice : BaseTableForm
    {
        public FineCallsNotice fineCallsNotice;

        public frmEditFineCallsNotice()
        {
            InitializeComponent();
            this.FormDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmFineCallsNotice"));
        }

        public frmEditFineCallsNotice(FineCallsNotice fineCallsNotice)
            : this()
        {
            this.fineCallsNotice = fineCallsNotice;
        }

        private void frmEditFineCallsNotice_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管催〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FormDate.Value = DateTime.Now;
                if (fineCallsNotice != null)
                {
                    SetEntity(fineCallsNotice);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmFineCallsNotice"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款, (int)SOA.ORM.InstrumentsExample.ECallsFineType.罚款催缴通知书);
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (fineCallsNotice == null)
                {
                    fineCallsNotice = new FineCallsNotice();

                    fineCallsNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                fineCallsNotice.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("罚款催缴通知书");
                doc.AddField("CompanyName", fineCallsNotice.CompanyName);
                doc.AddField("SendCallsDate", fineCallsNotice.SendCallsDate.ToString("yyyy年MM月dd日"));
                doc.AddField("DecideNumber", fineCallsNotice.DecideNumber);
                doc.AddField("EndDate", fineCallsNotice.EndDate.ToString("yyyy年MM月dd日"));
                doc.AddField("Location", fineCallsNotice.Location);
                doc.AddField("DocTitle", fineCallsNotice.DocTitle);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmFineCallsNotice", fineCallsNotice.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {

            if (fineCallsNotice == null)
            {
                fineCallsNotice = new FineCallsNotice();

                fineCallsNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(fineCallsNotice);

            CompanyName.Items.Clear();
            List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
            foreach (SearchWord word in Words)
                CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

            InvokeUtil.SystemService.EntityUpdate(fineCallsNotice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

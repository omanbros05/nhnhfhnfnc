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
    public partial class frmEditContributeFine : BaseTableForm
    {
        public ContributeFine contributeFine;

        public frmEditContributeFine()
        {
            InitializeComponent();
        }

        public frmEditContributeFine(ContributeFine contributeFine)
            : this()
        {
            this.contributeFine = contributeFine;
        }

        private void frmContributeFine_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管催〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FormDate.Value = DateTime.Now;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                CompanyName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (contributeFine != null)
                {
                    SetEntity(contributeFine);
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

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款, (int)SOA.ORM.InstrumentsExample.ECallsFineType.分期缴款批准书);
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
                SaveData();
                WordDocument doc = new WordDocument("延期（分期）缴纳罚款批准书");
                doc.AddField("CompanyName", contributeFine.CompanyName);
                doc.AddField("DocTitle", contributeFine.DocTitle);
                doc.AddField("ContributionsDate", contributeFine.ContributionsDate.ToString("yyyy年MM月dd日"));
                doc.AddField("InstrumentNo", contributeFine.InstrumentNo);
                doc.AddField("FineSumString", contributeFine.FineSumString);
                doc.AddField("FineSum", contributeFine.FineSum.ToString());
                doc.AddField("ExtensionDate", contributeFine.ExtensionDate.ToString("yyyy年MM月dd日"));
                doc.AddField("ExtensionDateString", contributeFine.ExtensionDateString);
                doc.AddField("Period", contributeFine.Period);
                doc.AddField("InstallmentsDate", contributeFine.InstallmentsDate.ToString("yyyy年MM月dd日"));
                doc.AddField("InstallmentsDateString", contributeFine.InstallmentsDateString);
                doc.AddField("InstallmentsSum", contributeFine.InstallmentsSum.ToString());
                doc.AddField("InstallmentsSumString", contributeFine.InstallmentsSumString);
                doc.AddField("InstallmentsBalance", contributeFine.InstallmentsBalance.ToString());
                doc.AddField("InstallmentsBalanceString", contributeFine.InstallmentsBalanceString);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (contributeFine == null)
                contributeFine = new ContributeFine();

            GetEntity(contributeFine);

            InvokeUtil.SystemService.EntityUpdate(contributeFine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

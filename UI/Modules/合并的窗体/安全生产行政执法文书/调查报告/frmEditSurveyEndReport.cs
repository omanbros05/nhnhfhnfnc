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
    public partial class frmEditSurveyEndReport : BaseTableForm
    {
        public SurveyEndReport surveyEndReport;

        public frmEditSurveyEndReport()
        {
            InitializeComponent();
        }

        public frmEditSurveyEndReport(SurveyEndReport surveyEndReport)
            : this()
        {
            this.surveyEndReport = surveyEndReport;
        }

        private void frmEditSurveyEndReport_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CaseName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                UserName1.Items.Clear();
                UserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (surveyEndReport != null)
                {
                    SetEntity(surveyEndReport);
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
                if (surveyEndReport == null)
                    surveyEndReport = new SurveyEndReport();

                GetEntity(surveyEndReport);

                InvokeUtil.SystemService.EntityUpdate(surveyEndReport);
                CommonInvoke.MessageBox("操作成功！");
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
            //try
            //{
            //    EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType., (int)SOA.ORM.InstrumentsExample.ECallsFineType.分期缴款批准书);
            //    if (InstrumentsExamples.Items.Count > 0)
            //    {
            //        frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
            //        frm.OpenWindow(this);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    CommonInvoke.ErrorMessageBox(ex);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

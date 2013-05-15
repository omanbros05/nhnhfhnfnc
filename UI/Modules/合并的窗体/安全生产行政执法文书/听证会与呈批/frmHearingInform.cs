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
    public partial class frmHearingInform : BaseTableForm
    {
        public HearingInform hearingInform;

        public frmHearingInform()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingInforms"));
        }


        public frmHearingInform(HearingInform hearingInform)
            : this()
        {
            this.hearingInform = hearingInform;
        }

        private void frmHearingInform_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管听报〔" + DateTime.Now.Year + "〕1 号";

                CaseName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                CompereName.Items.Clear();
                HearName.Items.Clear();
                SecretaryName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    CompereName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    HearName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    SecretaryName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (hearingInform != null)
                {
                    SetEntity(hearingInform);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingInforms"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批, (int)SOA.ORM.InstrumentsExample.EHearingChengpiType.听证会报告书);
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
                if (hearingInform == null)
                {
                    hearingInform = new HearingInform();

                    hearingInform.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                hearingInform.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("听证会报告书");
                doc.AddField("DocTitle", hearingInform.DocTitle);
                doc.AddField("CaseName", hearingInform.CaseName);
                doc.AddField("CompereName", hearingInform.CompereName);
                doc.AddField("SecretaryName", hearingInform.SecretaryName);
                doc.AddField("HearName", hearingInform.HearName);
                doc.AddField("Summary", hearingInform.Summary);
                doc.AddField("Suggest", hearingInform.Suggest);
                doc.AddField("PrincipalSuggest", hearingInform.PrincipalSuggest);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmHearingInforms", hearingInform.FilePath }));

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (hearingInform == null)
            {
                hearingInform = new HearingInform();

                hearingInform.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(hearingInform);

            InvokeUtil.SystemService.EntityUpdate(hearingInform);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

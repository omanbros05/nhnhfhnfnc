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
    public partial class frmEditContributeFineApproval : BaseTableForm
    {
        public ContributeFineApproval contributeFineApproval;

        public frmEditContributeFineApproval()
        {
            InitializeComponent();
            this.FormDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmContributeFineApproval"));
        }

        public frmEditContributeFineApproval(ContributeFineApproval contributeFineApproval)
            : this()
        {
            this.contributeFineApproval = contributeFineApproval;
        }

        private void frmContributeFineApproval_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                UserName1.Items.Clear();
                UserName2.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                CaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (contributeFineApproval != null)
                {
                    SetEntity(contributeFineApproval);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmContributeFineApproval"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void CaseName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (CaseName.SelectedValue != null)
                {
                    SearchWord word = CaseName.SelectedValue as SearchWord;
                    PutOnRecord putOnRecord = word.ToObject<PutOnRecord>();
                    Party.Text = putOnRecord.CompanyName + "," + putOnRecord.PeopleCondition + "," + putOnRecord.PeopleAddress;
                    Address.Text = putOnRecord.PeopleAddress;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款, (int)SOA.ORM.InstrumentsExample.ECallsFineType.分期缴款审批书);
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
                if (contributeFineApproval == null)
                {
                    contributeFineApproval = new ContributeFineApproval();

                    contributeFineApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                contributeFineApproval.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("延期（分期）缴纳罚款审批表");
                doc.AddField("CaseName", contributeFineApproval.CaseName);
                doc.AddField("PunishInstrumentNo", contributeFineApproval.PunishInstrumentNo);
                doc.AddField("Party", contributeFineApproval.Party);
                doc.AddField("Address", contributeFineApproval.Address);
                doc.AddField("LawFactPunish", contributeFineApproval.LawFactPunish);
                doc.AddField("ExtensionReason", contributeFineApproval.ExtensionReason);
                doc.AddField("UserOpinion", contributeFineApproval.UserOpinion);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmContributeFineApproval", contributeFineApproval.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (contributeFineApproval == null)
            {
                contributeFineApproval = new ContributeFineApproval();

                contributeFineApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(contributeFineApproval);

            InvokeUtil.SystemService.EntityUpdate(contributeFineApproval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

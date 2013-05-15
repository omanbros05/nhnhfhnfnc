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
    public partial class frmEditCaseExtensionClosedApproval : BaseTableForm
    {
        public CaseExtensionClosedApproval caseExtensionClosedApproval;

        public frmEditCaseExtensionClosedApproval()
        {
            InitializeComponent();
            this.FormDate.Value = DateTime.Now;
            this.CaseStartDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseExtensionClosedApproval"));
        }

        public frmEditCaseExtensionClosedApproval(CaseExtensionClosedApproval caseExtensionClosedApproval)
            : this()
        {
            this.caseExtensionClosedApproval = caseExtensionClosedApproval;
        }

        private void frmCaseExtensionClosedApproval_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FormDate.Value = DateTime.Now;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                Party.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    Party.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                CaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (caseExtensionClosedApproval != null)
                {
                    SetEntity(caseExtensionClosedApproval);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseExtensionClosedApproval"));
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
                    CaseStartDate.Value = putOnRecord.ThisDate;
                    Party.Text = putOnRecord.CompanyName;
                    CaseSourceName.Text = putOnRecord.CaseSourceName;
                    Tel.Text = putOnRecord.PeoplePhone;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案, (int)SOA.ORM.InstrumentsExample.ECaseCloasedType.案件延期办结审批表L上级R);
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
                if (caseExtensionClosedApproval == null)
                {
                    caseExtensionClosedApproval = new CaseExtensionClosedApproval();

                    caseExtensionClosedApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                caseExtensionClosedApproval.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件延期办结毕审批表");
                doc.AddField("CaseName", caseExtensionClosedApproval.CaseName);
                doc.AddField("Party", caseExtensionClosedApproval.Party);
                doc.AddField("Legal", caseExtensionClosedApproval.Legal);
                doc.AddField("Address", caseExtensionClosedApproval.Address);
                doc.AddField("Tel", caseExtensionClosedApproval.Tel);
                doc.AddField("CaseSourceName", caseExtensionClosedApproval.CaseSourceName);
                doc.AddField("CaseStartDate", caseExtensionClosedApproval.CaseStartDate.ToString("yyyy年MM月dd日"));
                doc.AddField("ExtensionApproval", caseExtensionClosedApproval.ExtensionApproval);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                  new object[] { doc, "EnforceForm.frmCaseExtensionClosedApproval", caseExtensionClosedApproval.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (caseExtensionClosedApproval == null)
            {
                caseExtensionClosedApproval = new CaseExtensionClosedApproval();

                caseExtensionClosedApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(caseExtensionClosedApproval);

            InvokeUtil.SystemService.EntityUpdate(caseExtensionClosedApproval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

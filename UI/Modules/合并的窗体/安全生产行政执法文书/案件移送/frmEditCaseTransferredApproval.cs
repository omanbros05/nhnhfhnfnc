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
using System.Diagnostics;

namespace EnforceForm
{
    public partial class frmEditCaseTransferredApproval : BaseTableForm
    {
        public CaseTransferredApproval caseTransferredApproval;

        public frmEditCaseTransferredApproval()
        {
            InitializeComponent();
            this.HandleDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseTransferredApproval"));
        }

        public frmEditCaseTransferredApproval(CaseTransferredApproval caseTransferredApproval)
            : this()
        {
            this.caseTransferredApproval = caseTransferredApproval;
        }

        private void frmCaseTransferredApproval_Load(object sender, EventArgs e)
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
                if (caseTransferredApproval != null)
                {
                    SetEntity(caseTransferredApproval);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseTransferredApproval"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送, (int)SOA.ORM.InstrumentsExample.ECaseTransferredType.案件移送审批表);
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
                if (caseTransferredApproval == null)
                {
                    caseTransferredApproval = new CaseTransferredApproval();

                    caseTransferredApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                caseTransferredApproval.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件移送审批表");
                doc.AddField("CaseName", caseTransferredApproval.CaseName);
                doc.AddField("Party", caseTransferredApproval.Party);
                doc.AddField("Address", caseTransferredApproval.Address);
                doc.AddField("ReceiverUnit", caseTransferredApproval.ReceiverUnit);
                doc.AddField("CaseInfo", caseTransferredApproval.CaseInfo);
                doc.AddField("TransferredReason", caseTransferredApproval.TransferredReason);
                doc.AddField("UserReason", caseTransferredApproval.UserReason);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmCaseTransferredApproval", caseTransferredApproval.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (caseTransferredApproval == null)
            {
                caseTransferredApproval = new CaseTransferredApproval();

                caseTransferredApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(caseTransferredApproval);

            InvokeUtil.SystemService.EntityUpdate(caseTransferredApproval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

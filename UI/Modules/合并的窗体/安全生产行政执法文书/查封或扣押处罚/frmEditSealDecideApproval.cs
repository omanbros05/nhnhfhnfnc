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
    public partial class frmEditSealDecideApproval : BaseTableForm
    {
        public SealDecideApproval sealDecideApproval;

        public frmEditSealDecideApproval()
        {
            InitializeComponent();
            this.HandleDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }



        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealDecideApproval"));
        }

        public frmEditSealDecideApproval(SealDecideApproval sealDecideApproval)
            : this()
        {
            this.sealDecideApproval = sealDecideApproval;
        }

        private void frmEditSealDecideApproval_Load(object sender, EventArgs e)
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
                if (sealDecideApproval != null)
                {
                    SetEntity(sealDecideApproval);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealDecideApproval"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚, (int)SOA.ORM.InstrumentsExample.ESealPunishType.查封或扣押决定审批表);
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
                if (sealDecideApproval == null)
                {
                    sealDecideApproval = new SealDecideApproval();

                    sealDecideApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                sealDecideApproval.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("查封(扣押)决定审批表");
                doc.AddField("CaseName", sealDecideApproval.CaseName);
                doc.AddField("CaseStatus", sealDecideApproval.CaseStatus);
                doc.AddField("PartyBaseInfo", sealDecideApproval.PartyBaseInfo);
                doc.AddField("SealContent", sealDecideApproval.SealContent);
                doc.AddField("SealReason", sealDecideApproval.SealReason);
                doc.AddField("UserName1", sealDecideApproval.UserName1);
                doc.AddField("UserName2", sealDecideApproval.UserName2);
                doc.AddField("UserReason", sealDecideApproval.UserReason);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                                    new object[] { doc, "EnforceForm.frmSealDecideApproval", sealDecideApproval.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {

            if (sealDecideApproval == null)
            {
                sealDecideApproval = new SealDecideApproval();

                sealDecideApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(sealDecideApproval);

            InvokeUtil.SystemService.EntityUpdate(sealDecideApproval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

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
    public partial class frmEditSealThingHandleApproval : BaseTableForm
    {
        public SealThingHandleApproval sealThingHandleApproval;

        public frmEditSealThingHandleApproval()
        {
            InitializeComponent();
            this.HandleDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealThingHandleApproval"));
        }

        public frmEditSealThingHandleApproval(SealThingHandleApproval sealThingHandleApproval)
            : this()
        {
            this.sealThingHandleApproval = sealThingHandleApproval;
        }

        private void frmSealThingHandleApproval_Load(object sender, EventArgs e)
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
                if (sealThingHandleApproval != null)
                {
                    SetEntity(sealThingHandleApproval);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealThingHandleApproval"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚, (int)SOA.ORM.InstrumentsExample.ESealPunishType.查封或扣押物品处理审批表);
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
                if (sealThingHandleApproval == null)
                {
                    sealThingHandleApproval = new SealThingHandleApproval();

                    sealThingHandleApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                sealThingHandleApproval.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("查封（扣押）物品处理审批表");
                doc.AddField("CaseName", sealThingHandleApproval.CaseName);
                doc.AddField("PartyBaseInfo", sealThingHandleApproval.PartyBaseInfo);
                doc.AddField("CaseSurveyInfo", sealThingHandleApproval.CaseSurveyInfo);
                doc.AddField("UserReason", sealThingHandleApproval.UserReason);
                doc.AddField("SealDecideNo", sealThingHandleApproval.SealDecideNo);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                                    new object[] { doc, "EnforceForm.frmSealThingHandleApproval", sealThingHandleApproval.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {
            if (sealThingHandleApproval == null)
            {
                sealThingHandleApproval = new SealThingHandleApproval();

                sealThingHandleApproval.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(sealThingHandleApproval);

            InvokeUtil.SystemService.EntityUpdate(sealThingHandleApproval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

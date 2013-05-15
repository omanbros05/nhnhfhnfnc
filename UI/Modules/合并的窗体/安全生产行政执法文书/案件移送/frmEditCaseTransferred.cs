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
    public partial class frmEditCaseTransferred : BaseTableForm
    {
        public CaseTransferred caseTransferred;

        public frmEditCaseTransferred()
        {
            InitializeComponent();
            this.TransferredDate.Value = DateTime.Now;
            this.HandleDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseTransferred"));
        }

        public frmEditCaseTransferred(CaseTransferred caseTransferred)
            : this()
        {
            this.caseTransferred = caseTransferred;
        }

        private void frmEditCaseTransferred_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管移〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                HandleDate.Value = DateTime.Now;
                
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                UnitName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    UnitName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (caseTransferred != null)
                {
                    SetEntity(caseTransferred);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseTransferred"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送, (int)SOA.ORM.InstrumentsExample.ECaseTransferredType.案件移送书);
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            frm.OpenWindow(this);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (caseTransferred == null)
                {
                    caseTransferred = new CaseTransferred();

                    caseTransferred.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                caseTransferred.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件移送书");
                doc.AddField("UnitName", caseTransferred.UnitName);
                doc.AddField("TransferredDate", caseTransferred.TransferredDate.ToString("yyyy年MM月dd日"));
                doc.AddField("CaseName", caseTransferred.CaseName);
                doc.AddField("TransferredReason", caseTransferred.TransferredReason);
                doc.AddField("TransferredLaw", caseTransferred.TransferredLaw);
                doc.AddField("CaseMaterial", caseTransferred.CaseMaterial);
                doc.AddField("DocTitle", caseTransferred.DocTitle);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmCaseTransferred", caseTransferred.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (caseTransferred == null)
            {
                caseTransferred = new CaseTransferred();

                caseTransferred.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(caseTransferred);

            InvokeUtil.SystemService.EntityUpdate(caseTransferred);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("osk.exe"); }
            catch { }
        }
    }
}

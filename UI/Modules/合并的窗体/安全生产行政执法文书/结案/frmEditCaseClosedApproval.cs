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
    public partial class frmEditCaseClosedApproval : BaseTableForm
    {
        private CaseClosedApproval obj = null;
        public frmEditCaseClosedApproval()
        {
            InitializeComponent();
            this.FormDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseClosedApproval"));
        }

        public frmEditCaseClosedApproval(CaseClosedApproval obj)
            : this()
        {
            this.obj = obj;
        }

        private void frmEditCaseClosedApproval_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                Party.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    Party.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                UserName1.Items.Clear();
                UserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
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
                if (obj != null)
                {
                    SetEntity(obj);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseClosedApproval"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案, (int)SOA.ORM.InstrumentsExample.ECaseCloasedType.结案审批表);
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
                if (obj == null)
                {
                    obj = new CaseClosedApproval();

                    obj.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                obj.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("结案审批表");
                doc.AddField("CaseName", obj.CaseName);
                doc.AddField("Party", obj.Party);
                doc.AddField("Legal", obj.Legal);
                doc.AddField("CaseSourceName", obj.CaseSourceName);
                doc.AddField("PunishInstrumentNo", obj.PunishInstrumentNo);
                doc.AddField("CaseStartDate", obj.CaseStartDate.ToString("yyyy年MM月dd日"));
                doc.AddField("CaseEndDate", obj.CaseEndDate.ToString("yyyy年MM月dd日"));
                doc.AddField("PunishDate", obj.PunishDate.ToString("yyyy年MM月dd日"));
                doc.AddField("UserName1", obj.UserName1 + (obj.UserName1 != "" ? "、" + obj.UserName1 : ""));
                doc.AddField("PunishContent", obj.PunishContent);
                doc.AddField("ExecutionResult", obj.ExecutionResult);
                doc.AddField("DocTitle", obj.DocTitle);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmEditCaseClosedApproval", obj.FilePath }));
               
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {

            if (obj == null)
            {
                obj = new CaseClosedApproval();

                obj.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(obj);

            InvokeUtil.SystemService.EntityUpdate(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

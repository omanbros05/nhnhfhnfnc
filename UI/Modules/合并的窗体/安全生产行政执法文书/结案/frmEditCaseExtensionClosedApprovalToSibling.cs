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
    public partial class frmEditCaseExtensionClosedApprovalToSibling : BaseTableForm
    {
        public CaseExtensionClosedApprovalToSibling obj;
        public frmEditCaseExtensionClosedApprovalToSibling()
        {
            InitializeComponent();
            this.FormDate.Value = DateTime.Now;
            this.CaseStartDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseExtensionClosedApprovalToSibling"));
        }
        public frmEditCaseExtensionClosedApprovalToSibling(CaseExtensionClosedApprovalToSibling obj)
            : this()
        {
            this.obj = obj;
        }

        private void frmEditCaseClosedApprovalToSibling_Load(object sender, EventArgs e)
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCaseExtensionClosedApprovalToSibling"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案, (int)SOA.ORM.InstrumentsExample.ECaseCloasedType.案件延期办结审批表L本级R);
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
                    obj = new CaseExtensionClosedApprovalToSibling();

                    obj.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                obj.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件延期办结毕审批表");
                doc.AddField("CaseName", obj.CaseName);
                doc.AddField("Party", obj.Party);
                doc.AddField("Legal", obj.Legal);
                doc.AddField("CaseStartDate", obj.CaseStartDate.ToString("yyyy年MM月dd日"));
                doc.AddField("ExtensionApproval", obj.ExtensionApproval);
                doc.AddField("Address", obj.Address);
                doc.AddField("Tel", obj.Tel);
                doc.AddField("CaseSourceName", obj.CaseSourceName);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                                    new object[] { doc, "EnforceForm.frmEditCaseExtensionClosedApprovalToSibling", obj.FilePath }));
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
                obj = new CaseExtensionClosedApprovalToSibling();

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

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
    public partial class frmInCaseOfTable : BaseTableForm
    {
        private InCaseOfTable inCaseOfTable = null;
        public frmInCaseOfTable()
        {
            InitializeComponent();
            this.UndertakerData.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInCaseOfTables"));
        }

        public frmInCaseOfTable(InCaseOfTable inCaseOfTable)
            : this()
        {
            this.inCaseOfTable = inCaseOfTable;
        }

        private void frmInCaseOfTable_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管处呈〔" + DateTime.Now.Year + "〕1 号";
                UndertakerData.Value = DateTime.Now;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                PutOnRecordPeopleName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    PutOnRecordPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                UndertakerUserName1.Items.Clear();
                UndertakerUserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UndertakerUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UndertakerUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                PutOnRecordCaseName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    PutOnRecordCaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (inCaseOfTable != null)
                {
                    SetEntity(inCaseOfTable);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInCaseOfTables"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        

        private void PutOnRecordCaseName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PutOnRecordCaseName.SelectedValue != null)
                {
                    SearchWord word = PutOnRecordCaseName.SelectedValue as SearchWord;
                    PutOnRecord putOnRecord = word.ToObject<PutOnRecord>();
                    PutOnRecordPeopleAddress.Text = putOnRecord.PeopleAddress;
                    PutOnRecordPeopleName.Text = putOnRecord.CompanyName;
                    CaseSourceName.Text = putOnRecord.CaseSourceName;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void PutOnRecordPeopleName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (PutOnRecordPeopleName.SelectedValue != null)
                {
                    SearchWord word = PutOnRecordPeopleName.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    PutOnRecordFName.Text = company.JuridicalPerson;
                    PutOnRecordPeopleAddress.Text = company.CompanyAddress;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SaveData()
        {
            if (inCaseOfTable == null)
            {
                inCaseOfTable = new InCaseOfTable();

                inCaseOfTable.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(inCaseOfTable);
            Company company = new Company
            {
                CompanyName = PutOnRecordPeopleName.Text,
                JuridicalPerson = PutOnRecordFName.Text,
                CompanyAddress = PutOnRecordPeopleAddress.Text
            };
            Officers officer1 = new Officers { OfficersName = UndertakerUserName1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);
            Officers officer2 = new Officers { OfficersName = UndertakerUserName2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            InvokeUtil.SystemService.EntityUpdate(inCaseOfTable);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (inCaseOfTable == null)
                {
                    inCaseOfTable = new InCaseOfTable();

                    inCaseOfTable.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                inCaseOfTable.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("案件处理呈批表");
                doc.AddField("DocTitle", inCaseOfTable.DocTitle);
                doc.AddField("PutOnRecordCaseName", inCaseOfTable.PutOnRecordCaseName);
                doc.AddField("PutOnRecordPeopleName", inCaseOfTable.PutOnRecordPeopleName);
                doc.AddField("PutOnRecordFName", inCaseOfTable.PutOnRecordFName);
                doc.AddField("PutOnRecordPeopleAddress", inCaseOfTable.PutOnRecordPeopleAddress);
                doc.AddField("CaseSourceName", inCaseOfTable.CaseSourceName);
                doc.AddField("GeneralCase", inCaseOfTable.GeneralCase);
                doc.AddField("IllegalFact", inCaseOfTable.IllegalFact);
                doc.AddField("UndertakerOpinion", inCaseOfTable.UndertakerOpinion);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmInCaseOfTables", inCaseOfTable.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件处理, (int)SOA.ORM.InstrumentsExample.ECaseHandleType.案件处理呈批表);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("osk.exe"); }
            catch { }
        }
    }
}

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
    public partial class frmSaveEvidenceNotice : BaseTableForm
    {
        private SaveEvidenceNotice saveEvidenceNotice = null;
        public frmSaveEvidenceNotice()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            this.ToTime.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceNotices"));
        }

        public frmSaveEvidenceNotice(SaveEvidenceNotice saveEvidenceNotice)
            : this()
        {
            this.saveEvidenceNotice = saveEvidenceNotice;
        }

        private void frmSaveEvidenceNotice_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管先保通〔" + DateTime.Now.Year + "〕 执法－1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;
                ToTime.Value = DateTime.Now;
                QFirstPerson.Text = InvokeUtil.ActiveUser.FullName;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                FieldECompanyName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    FieldECompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (saveEvidenceNotice != null)
                {
                    SetEntity(saveEvidenceNotice);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceNotices"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {

            if (saveEvidenceNotice == null)
            {
                saveEvidenceNotice = new SaveEvidenceNotice();

                saveEvidenceNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(saveEvidenceNotice);

            Company company = new Company
            {
                CompanyName = FieldECompanyName.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            InvokeUtil.SystemService.EntityUpdate(saveEvidenceNotice);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {

                if (saveEvidenceNotice == null)
                {
                    saveEvidenceNotice = new SaveEvidenceNotice();

                    saveEvidenceNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                saveEvidenceNotice.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("先行登记保存证据通知书");
                doc.AddField("DocTitle", saveEvidenceNotice.DocTitle);
                doc.AddField("FieldECompanyName", saveEvidenceNotice.FieldECompanyName);
                doc.AddField("IllegalTypeName", saveEvidenceNotice.IllegalTypeName);
                doc.AddField("ToTime", saveEvidenceNotice.ToTime.ToString("yyyy年MM月dd日"));
                doc.AddField("QFirstPerson", saveEvidenceNotice.QFirstPerson);
                doc.AddFootField("DocManageArea", saveEvidenceNotice.DocManageArea);
                
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSaveEvidenceNotices", saveEvidenceNotice.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.先行登记保存证据通知书);
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
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

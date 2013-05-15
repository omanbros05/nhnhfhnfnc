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
    public partial class frmSaveEvidenceProceDecide : BaseTableForm
    {
        private SaveEvidenceProceDecide saveEvidenceProceDecide = null;
        public frmSaveEvidenceProceDecide()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            this.JData.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceProceDecides"));
        }
        public frmSaveEvidenceProceDecide(SaveEvidenceProceDecide saveEvidenceProceDecide)
            : this()
        {
            this.saveEvidenceProceDecide = saveEvidenceProceDecide;
        }

        private void frmSaveEvidenceProceDecide_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管先保处〔" + DateTime.Now.Year + "〕 1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                JData.Value = DateTime.Now;
                FillDate.Value = DateTime.Now;
                LitigationUnitName1.Text = InvokeUtil.ActiveUser.Area;
                LitigationUnitName2.Text = InvokeUtil.ActiveUser.FullName;
                LitigationUnitName3.Text = InvokeUtil.ActiveUser.Area;

                FieldECompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    FieldECompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                LitigationUnitName1.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    LitigationUnitName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                if (saveEvidenceProceDecide != null)
                {
                    SetEntity(saveEvidenceProceDecide);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSaveEvidenceProceDecides"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {

            if (saveEvidenceProceDecide == null)
            {
                saveEvidenceProceDecide = new SaveEvidenceProceDecide();

                saveEvidenceProceDecide.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(saveEvidenceProceDecide);

            Company company = new Company
            {
                CompanyName = FieldECompanyName.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            InvokeUtil.SystemService.EntityUpdate(saveEvidenceProceDecide);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (saveEvidenceProceDecide == null)
                {
                    saveEvidenceProceDecide = new SaveEvidenceProceDecide();

                    saveEvidenceProceDecide.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                saveEvidenceProceDecide.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("先行登记保存证据处理决定书");
                doc.AddField("DocTitle", saveEvidenceProceDecide.DocTitle);
                doc.AddField("FieldECompanyName", saveEvidenceProceDecide.FieldECompanyName);
                doc.AddField("JData", saveEvidenceProceDecide.JData.ToString("yyyy年MM月dd日"));
                doc.AddField("SamplingContent", saveEvidenceProceDecide.SamplingContent);
                doc.AddField("SaveEvidenceProceAuditDocTitle", saveEvidenceProceDecide.SaveEvidenceProceAuditDocTitle);
                doc.AddField("DecideContent", saveEvidenceProceDecide.DecideContent);
                doc.AddField("LitigationUnitName1", saveEvidenceProceDecide.LitigationUnitName1);
                doc.AddField("LitigationUnitName2", saveEvidenceProceDecide.LitigationUnitName2);
                doc.AddField("LitigationUnitName3", saveEvidenceProceDecide.LitigationUnitName3);
                doc.AddFootField("DocManageArea", saveEvidenceProceDecide.DocManageArea);
                
               OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSaveEvidenceProceDecides", saveEvidenceProceDecide.FilePath }));
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
    }
}

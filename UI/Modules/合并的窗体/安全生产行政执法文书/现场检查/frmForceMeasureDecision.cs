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


namespace EnforceForm
{
    public partial class frmForceMeasureDecision : BaseTableForm
    {
        private ForceMeasureDecision forceMeasureDecision = null;

        public frmForceMeasureDecision()
        {
            InitializeComponent();
        }

        public frmForceMeasureDecision(ForceMeasureDecision forceMeasureDecision)
            : this()
        {
            this.forceMeasureDecision = forceMeasureDecision;
        }

        private void frmForceMeasureDecision_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管强措〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                DocDate.Value = DateTime.Now;
                GovArea.Text = InvokeUtil.ActiveUser.Area;
                ManageArea.Text = InvokeUtil.ActiveUser.FullName;
                CourtArea.Text = InvokeUtil.ActiveUser.Area;

                CompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                GovArea.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    GovArea.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                if (forceMeasureDecision != null)
                {
                    SetEntity(forceMeasureDecision);
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
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisions"));
        }

        private void SaveData() {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (forceMeasureDecision == null) {
                    forceMeasureDecision = new ForceMeasureDecision();
                    forceMeasureDecision.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }

                GetEntity(forceMeasureDecision);

                Company company = new Company
                {
                    CompanyName = CompanyName.Text,
                };
                InvokeUtil.SystemService.UpdateCompanyByName(company);

                InvokeUtil.SystemService.EntityUpdate(forceMeasureDecision);
                //CloseWindow();
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.强制措施决定书L15日内R);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisions"));
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers", new object[] { "EnforceForm.frmForceMeasureDecision", forceMeasureDecision }));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (forceMeasureDecision == null)
                {
                    forceMeasureDecision = new ForceMeasureDecision();
                    forceMeasureDecision.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }

                forceMeasureDecision.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("强制措施决定书");
                doc.AddField("DocTitle", forceMeasureDecision.DocTitle);
                doc.AddField("CompanyName", forceMeasureDecision.CompanyName);
                doc.AddField("Matter", forceMeasureDecision.Matter);
                doc.AddField("Accord", forceMeasureDecision.Accord);
                doc.AddField("EnforceMea", forceMeasureDecision.EnforceMea);
                doc.AddField("GovArea", forceMeasureDecision.GovArea);
                doc.AddField("ManageArea", forceMeasureDecision.ManageArea);
                doc.AddField("CourtArea", forceMeasureDecision.CourtArea);
                doc.AddFootField("DocManageArea", forceMeasureDecision.DocManageArea);
                doc.AddFootField("DocDate", forceMeasureDecision.DocDate.ToString("yyyy年M月d日"));
                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmForceMeasureDecisions", forceMeasureDecision.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

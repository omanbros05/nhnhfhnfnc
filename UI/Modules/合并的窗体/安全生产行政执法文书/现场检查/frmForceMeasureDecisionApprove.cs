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
    public partial class frmForceMeasureDecisionApprove : BaseTableForm
    {
        private ForceMeasureDecisionApprove forceMeasureDecisionApprove = null;

        public frmForceMeasureDecisionApprove()
        {
            InitializeComponent();
        }

        public frmForceMeasureDecisionApprove(ForceMeasureDecisionApprove forceMeasureDecisionApprove)
            : this()
        {
            this.forceMeasureDecisionApprove = forceMeasureDecisionApprove;
        }

        void SaveData() {

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (forceMeasureDecisionApprove == null)
                {
                    forceMeasureDecisionApprove = new ForceMeasureDecisionApprove();
                    forceMeasureDecisionApprove.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }

                GetEntity(forceMeasureDecisionApprove);

                Company company = new Company
                {
                    CompanyName = Party.Text,
                    CompanyAddress = PartyAddress.Text,
                    JuridicalPerson = LegalRepre.Text,
                    Mobile = Tel.Text
                };
                InvokeUtil.SystemService.UpdateCompanyByName(company);

                InvokeUtil.SystemService.EntityUpdate(forceMeasureDecisionApprove);
                
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
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisionApproves"));
            //CloseWindow();
        }

        private void frmForceMeasureDecisionApprove_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SuperviseDate.Value = DateTime.Now;
                PrincipalDate.Value = DateTime.Now;

                Party.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    Party.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Supervise.Items.Clear();
                Principal.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    Supervise.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    Principal.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (forceMeasureDecisionApprove != null)
                {
                    SetEntity(forceMeasureDecisionApprove);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void Party_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (Party.SelectedValue != null)
                {
                    SearchWord word = Party.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    PartyAddress.Text = company.CompanyAddress;
                    LegalRepre.Text = company.JuridicalPerson;
                    Tel.Text = company.Mobile;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.强制措施决定审批表L15日内R);
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

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisionApproves"));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (forceMeasureDecisionApprove == null)
                {
                    forceMeasureDecisionApprove = new ForceMeasureDecisionApprove();
                    forceMeasureDecisionApprove.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                forceMeasureDecisionApprove.Status = 1;
                SaveData();

                WordDocument doc = new WordDocument("强制措施决定审批表");
                doc.Entity = forceMeasureDecisionApprove;
                doc.AddField("Party", forceMeasureDecisionApprove.Party);
                doc.AddField("PartyAddress", forceMeasureDecisionApprove.PartyAddress);
                doc.AddField("LegalRepre", forceMeasureDecisionApprove.LegalRepre);
                doc.AddField("Tel", forceMeasureDecisionApprove.Tel);
                doc.AddField("Matter", forceMeasureDecisionApprove.Matter);
                doc.AddField("Accord", forceMeasureDecisionApprove.Accord);
                doc.AddField("Supervise", forceMeasureDecisionApprove.Supervise);
                doc.AddField("SuperviseDate", forceMeasureDecisionApprove.SuperviseDate.ToString("yyyy年M月d日"));
                doc.AddField("Undertake", forceMeasureDecisionApprove.Undertake);
                doc.AddField("Principal", forceMeasureDecisionApprove.Principal);
                doc.AddField("PrincipalDate", forceMeasureDecisionApprove.PrincipalDate.ToString("yyyy年M月d日"));
                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmForceMeasureDecisionApproves", forceMeasureDecisionApprove.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers",
                new object[] { "EnforceForm.frmOrderDeadlineReform", forceMeasureDecisionApprove }));
        }
    }
}

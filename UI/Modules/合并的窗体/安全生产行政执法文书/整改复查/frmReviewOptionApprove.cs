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
    public partial class frmReviewOptionApprove : BaseTableForm
    {
        public ReviewOptionApprove reviewOptionApprove;

        public frmReviewOptionApprove()
        {
            InitializeComponent();
        }

        public frmReviewOptionApprove(ReviewOptionApprove reviewOptionApprove)
            : this()
        {
            this.reviewOptionApprove = reviewOptionApprove;
        }

        private void frmReviewOptionApprove_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                LeaveTime.Value = DateTime.Now;
                ReceiveTime.Value = DateTime.Now;
                ReviewTime.Value = DateTime.Now;
                ReviewDate.Value = DateTime.Now;
                PrincipalDate.Value = DateTime.Now;

                Party.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    Party.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Reviewer.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                    Reviewer.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                Principal.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                    Principal.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                if (reviewOptionApprove != null)
                {
                    SetEntity(reviewOptionApprove);
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
                if (reviewOptionApprove == null)
                    reviewOptionApprove = new ReviewOptionApprove();

                GetEntity(reviewOptionApprove);

                Company company = new Company
                {
                    CompanyName = Party.Text,
                    CompanyAddress = PartyAddress.Text,
                    JuridicalPerson = LegalRepre.Text,
                    Mobile = Tel.Text
                };
                InvokeUtil.SystemService.UpdateCompanyByName(company);

                InvokeUtil.SystemService.EntityUpdate(reviewOptionApprove);
                CloseWindow();
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查, (int)SOA.ORM.InstrumentsExample.ERectificationReviewType.复查意见审批表);
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

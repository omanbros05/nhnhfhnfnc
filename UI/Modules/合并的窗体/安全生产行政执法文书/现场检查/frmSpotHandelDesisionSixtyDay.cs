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
    public partial class frmSpotHandelDesisionSixtyDay : BaseTableForm
    {
        public SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay;

        public frmSpotHandelDesisionSixtyDay()
        {
            InitializeComponent();
        }

        public frmSpotHandelDesisionSixtyDay(SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay)
            : this()
        {
            this.spotHandelDesisionSixtyDay = spotHandelDesisionSixtyDay;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotHandelDesisionSixtyDay == null)
                    spotHandelDesisionSixtyDay = new SpotHandelDesisionSixtyDay();

                GetEntity(spotHandelDesisionSixtyDay);

                Company company = new Company
                {
                    CompanyName = HandleComp.Text,
                };
                InvokeUtil.SystemService.UpdateCompanyByName(company);

                Officers officer1 = new Officers { OfficersName = OfficerName1.Text, CID = CID1.Text };
                InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

                Officers officer2 = new Officers { OfficersName = OfficerName2.Text, CID = CID2.Text };
                InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

                InvokeUtil.SystemService.EntityUpdate(spotHandelDesisionSixtyDay);
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void frmSpotHandelDesisionSixtyDay_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管强措〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;

                CheckDate.Value = DateTime.Now;
                DocDate.Value = DateTime.Now;

                GovArea.Text = InvokeUtil.ActiveUser.Area;
                ManageArea.Text = InvokeUtil.ActiveUser.FullName;
                CourtArea.Text = InvokeUtil.ActiveUser.Area;

                HandleComp.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    HandleComp.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                GovArea.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(AreaCode).FullName);
                foreach (SearchWord word in Words)
                    GovArea.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                OfficerName1.Items.Clear();
                OfficerName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    OfficerName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    OfficerName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (spotHandelDesisionSixtyDay != null)
                {
                    SetEntity(spotHandelDesisionSixtyDay);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void OfficerName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (OfficerName1.SelectedValue != null)
                {
                    SearchWord word = OfficerName1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    CID1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void OfficerName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (OfficerName2.SelectedValue != null)
                {
                    SearchWord word = OfficerName2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    CID2.Text = officer.CID;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场处理措施决定书L6个月内R);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

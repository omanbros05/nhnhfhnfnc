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
    public partial class frmSpotHandelDesision : BaseTableForm
    {
        private SpotHandelDesision spotHandelDesision = null;
        public frmSpotHandelDesision()
        {
            InitializeComponent();
        }

        public frmSpotHandelDesision(SpotHandelDesision spotHandelDesision)
            : this()
        {
            this.spotHandelDesision = spotHandelDesision;
        }

        public frmSpotHandelDesision(object obj)
            : this()
        {
            this.spotHandelDesision = (SpotHandelDesision)obj;
        }

        private void frmSpotHandelDesision_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管现决〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                CheckDate.Value = DateTime.Now;
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

                OfficerName1.Items.Clear();
                OfficerName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    OfficerName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    OfficerName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (spotHandelDesision != null)
                {
                    SetEntity(spotHandelDesision);
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
                //CloseWindow();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotHandelDesisions"));
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

        private void SaveData()
        {

            if (spotHandelDesision == null)
            {
                spotHandelDesision = new SpotHandelDesision();

                spotHandelDesision.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(spotHandelDesision);

            Company company = new Company
            {
                CompanyName = CompanyName.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            Officers officer1 = new Officers { OfficersName = OfficerName1.Text, CID = CID1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer2 = new Officers { OfficersName = OfficerName2.Text, CID = CID2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            InvokeUtil.SystemService.EntityUpdate(spotHandelDesision);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotHandelDesision == null)
                {
                    spotHandelDesision = new SpotHandelDesision();

                    spotHandelDesision.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }

                spotHandelDesision.Status = 1;

                SaveData();
                WordDocument doc = new WordDocument("现场处理措施决定书");
                doc.AddField("DocTitle", spotHandelDesision.DocTitle);
                doc.AddField("CompanyName", spotHandelDesision.CompanyName);
                doc.AddField("CheckDate", spotHandelDesision.CheckDate.ToString("yyyy年MM月dd日"));
                doc.AddField("Violations", spotHandelDesision.Violations);
                doc.AddField("LegalBasis", spotHandelDesision.LegalBasis);
                doc.AddField("SitHandel", spotHandelDesision.SitHandel);
                doc.AddField("GovArea", spotHandelDesision.GovArea);
                doc.AddField("ManageArea", spotHandelDesision.ManageArea);
                doc.AddField("CourtArea", spotHandelDesision.CourtArea);
                doc.AddFootField("DocManageArea", spotHandelDesision.DocManageArea);
                doc.AddFootField("OfficerName1", spotHandelDesision.OfficerName1);
                doc.AddFootField("CID1", spotHandelDesision.CID1);
                doc.AddFootField("OfficerName2", spotHandelDesision.OfficerName2);
                doc.AddFootField("CID2", spotHandelDesision.CID2);

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSpotHandelDesisions", spotHandelDesision.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场处理措施决定书);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    //frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
                    //frm.OpenWindow(this);
                    SaveData();
                    OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInstrumentsExampleContent",
                            new object[] { InstrumentsExamples.Items[0], "EnforceForm.frmSpotHandelDesision", spotHandelDesision }));
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            //frm.OpenWindow(this);
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers", new object[] { "EnforceForm.frmSpotHandelDesision", spotHandelDesision }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotHandelDesisions"));
        }
    }
}

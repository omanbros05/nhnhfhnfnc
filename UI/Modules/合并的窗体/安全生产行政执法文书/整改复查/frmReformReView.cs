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
    public partial class frmReformReView : BaseTableForm
    {
        public ReformReView reformReView;
        public OrderDeadlineReform orderDeadlineReform;

        public frmReformReView()
        {
            InitializeComponent();
        }

        public frmReformReView(ReformReView reformReView)
            : this()
        {
            this.reformReView = reformReView;
        }

        public frmReformReView(OrderDeadlineReform orderDeadlineReform)
            : this()
        {
            this.orderDeadlineReform = orderDeadlineReform;
        }

        private void frmReformReView_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管复查〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;

                ReviewDate.Value = DateTime.Now;
                DocDate.Value = DateTime.Now;

                if (orderDeadlineReform != null)
                {
                    ReviewCompany.Text = orderDeadlineReform.OrderCompany;
                    Decide.Text = "责令限期整改";
                    DocTitle2.Text = orderDeadlineReform.DocTitle;
                    OfficerName1.Text = orderDeadlineReform.OfficerName1;
                    OfficerName2.Text = orderDeadlineReform.OfficerName2;
                    CID1.Text = orderDeadlineReform.CID1;
                    CID2.Text = orderDeadlineReform.CID2;
                }

                ReviewCompany.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    ReviewCompany.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                OfficerName1.Items.Clear();
                OfficerName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    OfficerName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    OfficerName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (reformReView != null)
                {
                    SetEntity(reformReView);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmReformReViews"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查, (int)SOA.ORM.InstrumentsExample.ERectificationReviewType.整改复查意见书);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    //frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
                    //frm.OpenWindow(this);
                    SaveData();
                    OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInstrumentsExampleContent",
                            new object[] { InstrumentsExamples.Items[0], "EnforceForm.frmReformReView", reformReView }));
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void SaveData()
        {
            if (reformReView == null)
            {
                reformReView = new ReformReView();
                reformReView.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(reformReView);

            Company company = new Company
            {
                CompanyName = ReviewCompany.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            Officers officer1 = new Officers { OfficersName = OfficerName1.Text, CID = CID1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer2 = new Officers { OfficersName = OfficerName2.Text, CID = CID2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            InvokeUtil.SystemService.EntityUpdate(reformReView);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (reformReView == null)
                {
                    reformReView = new ReformReView();
                    reformReView.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                reformReView.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("整改复查意见书");
                doc.AddField("DocTitle", reformReView.DocTitle);
                doc.AddField("ReviewCompany", reformReView.ReviewCompany);
                doc.AddField("ReviewDate", reformReView.ReviewDate.ToString("yyyy年M月d日"));
                doc.AddField("Decide", reformReView.Decide);
                doc.AddField("DocTitle2", reformReView.DocTitle2);
                doc.AddField("Idea", reformReView.Idea);
                doc.AddFootField("OfficerName1", reformReView.OfficerName1);
                doc.AddFootField("CID1", reformReView.CID1);
                doc.AddFootField("OfficerName2", reformReView.OfficerName2);
                doc.AddFootField("CID2", reformReView.CID2);
                doc.AddFootField("DocManageArea", reformReView.DocManageArea);

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmReformReViews", reformReView.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmReformReViews"));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            //frm.OpenWindow(this);
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers",
                new object[] { "EnforceForm.frmReformReView", reformReView }));
        }
    }
}

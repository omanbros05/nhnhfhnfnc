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
    public partial class frmOrderDeadlineReform : BaseTableForm
    {
        private OrderDeadlineReform orderDeadlineReform;

        public frmOrderDeadlineReform()
        {
            InitializeComponent();
            
        }

        public frmOrderDeadlineReform(OrderDeadlineReform orderDeadlineReform)
            : this()
        {
            this.orderDeadlineReform = orderDeadlineReform;
        }

        private void frmOrderDeadlineReform_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管责改〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;

                ReformDate.Value = DateTime.Now;
                DocDate.Value = DateTime.Now;

                GovArea.Text = InvokeUtil.ActiveUser.Area;
                ManageArea.Text = InvokeUtil.ActiveUser.FullName;
                CourtArea.Text = InvokeUtil.ActiveUser.Area;

                OrderCompany.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    OrderCompany.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

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

                if (orderDeadlineReform != null)
                {
                    SetEntity(orderDeadlineReform);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmOrderDeadlineReforms"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (orderDeadlineReform == null)
            {
                orderDeadlineReform = new OrderDeadlineReform();
                orderDeadlineReform.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
          

            GetEntity(orderDeadlineReform);

            Company company = new Company
            {
                CompanyName = OrderCompany.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            Officers officer1 = new Officers { OfficersName = OfficerName1.Text, CID = CID1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer2 = new Officers { OfficersName = OfficerName2.Text, CID = CID2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);

            InvokeUtil.SystemService.EntityUpdate(orderDeadlineReform);
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.责令限期整改指令书L30日内R);
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
                if (orderDeadlineReform == null)
                {
                    orderDeadlineReform = new OrderDeadlineReform();
                    orderDeadlineReform.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                orderDeadlineReform.Status = 1;

                SaveData();
                WordDocument doc = new WordDocument("责令限期整改指令书");
                doc.AddField("DocTitle", orderDeadlineReform.DocTitle);
                doc.AddField("OrderCompany", orderDeadlineReform.OrderCompany);
                doc.AddField("Matter", orderDeadlineReform.Matter);
                doc.AddField("MatterCount", orderDeadlineReform.MatterCount);
                doc.AddField("ReformDate", orderDeadlineReform.ReformDate.ToString("yyyy年M月d日"));
                doc.AddField("GovArea", orderDeadlineReform.GovArea);
                doc.AddField("ManageArea", orderDeadlineReform.ManageArea);
                doc.AddField("CourtArea", orderDeadlineReform.CourtArea);
                doc.AddFootField("OfficerName1", orderDeadlineReform.OfficerName1);
                doc.AddFootField("CID1", orderDeadlineReform.CID1);
                doc.AddFootField("OfficerName2", orderDeadlineReform.OfficerName2);
                doc.AddFootField("CID2", orderDeadlineReform.CID2);
                doc.AddFootField("DocManageArea", orderDeadlineReform.DocManageArea);
                //doc.AddFootField("DocDate", orderDeadlineReform.DocDate.ToString("yyyy年M月d日"));
                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmOrderDeadlineReforms", orderDeadlineReform.FilePath }));
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

        private void DoBack(object sender, EventArgs e) {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmOrderDeadlineReforms"));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            //frm.OpenWindow(this);
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers", new object[] { "EnforceForm.frmOrderDeadlineReform", orderDeadlineReform }));
        }
    }
}

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
    public partial class frmAppraisalEntrust : BaseTableForm
    {
        private AppraisalEntrust appraisalEntrust = null;
        public frmAppraisalEntrust()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);

        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmAppraisalEntrusts"));
        }

        public frmAppraisalEntrust(AppraisalEntrust appraisalEntrust)
            : this()
        {
            this.appraisalEntrust = appraisalEntrust;
        }

        private void frmAppraisalEntrust_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管鉴〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;
                SamplingContentGridViewItems.InitColumnType<SamplingContent>();
                if (appraisalEntrust != null)
                {
                    appraisalEntrust = InvokeUtil.SystemService.EntityInit(appraisalEntrust) as AppraisalEntrust;
                    SetEntity(appraisalEntrust);
                    SamplingID.Text = InvokeUtil.SystemService.GetSamplingDocTitle(appraisalEntrust.SamplingID);
                    SamplingContentGridViewItems.Bind<SamplingContent>(appraisalEntrust.Items);
                }

                AppraisalUnit.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(CheckPlace).FullName);
                foreach (SearchWord word in Words)
                    AppraisalUnit.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                ContactUserName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    ContactUserName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (appraisalEntrust == null)
            {
                appraisalEntrust = new AppraisalEntrust();

                appraisalEntrust.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            SamplingID.Text = InvokeUtil.SystemService.GetSamplingID(SamplingID.Text.Trim()).ToString();
            GetEntity(appraisalEntrust);

            CheckPlace checkPlace = new CheckPlace
            {
                CheckContent = AppraisalUnit.Text,
            };
            InvokeUtil.SystemService.UpdateCheckPlace(checkPlace);
            Officers officer1 = new Officers { OfficersName = ContactUserName.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            InvokeUtil.SystemService.EntityUpdate(appraisalEntrust);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmAppraisalEntrusts"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sid = InvokeUtil.SystemService.GetSamplingID(SamplingID.Text.Trim());
            List<SamplingContent> Items = InvokeUtil.SystemService.GetSamplingContentAll(Sid);
            SamplingContentGridViewItems.Bind<SamplingContent>(Items);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (appraisalEntrust == null)
                {
                    appraisalEntrust = new AppraisalEntrust();
                    appraisalEntrust.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                appraisalEntrust.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("鉴定委托书");
                doc.AddField("DocTitle", appraisalEntrust.DocTitle);
                doc.AddField("AppraisalUnit", appraisalEntrust.AppraisalUnit);
                doc.AddField("AppraisalPoints", appraisalEntrust.AppraisalPoints);
                doc.AddField("AppraisaDate", appraisalEntrust.AppraisaDate.ToString("yyyy年MM月dd日"));
                doc.AddField("ContactUserName", appraisalEntrust.ContactUserName);
                doc.AddField("ContactUserPhone", appraisalEntrust.ContactUserPhone);
                doc.AddFootField("DocManageArea", appraisalEntrust.DocManageArea);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                Grid grid = doc.NewGrid();
                grid.TableMark = "Table";
      
                int i = 0;
                foreach (SamplingContent sc in appraisalEntrust.Items)
                {
                    i++;
                    GridRow row = grid.NewRow();
                    row.AddRowItem(i.ToString());
                    row.AddRowItem(sc.SDocTitle);
                    row.AddRowItem(sc.ItemName);
                    row.AddRowItem(sc.ItemRule);
                    row.AddRowItem(sc.Count.ToString() + sc.ItemUnit);
                }

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmAppraisalEntrust", appraisalEntrust.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.鉴定委托书);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

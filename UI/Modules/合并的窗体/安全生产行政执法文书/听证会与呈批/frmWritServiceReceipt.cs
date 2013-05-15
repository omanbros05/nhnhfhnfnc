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
    public partial class frmWritServiceReceipt : BaseTableForm
    {
        public WritServiceReceipt writServiceReceipt;

        public frmWritServiceReceipt()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmWritServiceReceipts"));
        }

        public frmWritServiceReceipt(WritServiceReceipt writServiceReceipt)
            : this()
        {
            this.writServiceReceipt = writServiceReceipt;
        }

        private void frmWritServiceReceipt_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管回〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName ;

                enforceLawGridViewItems.InitColumnType<WritServiceReceiptItem>();
                CaseName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(PutOnRecord).FullName);
                foreach (SearchWord word in Words)
                {
                    CaseName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                ServiceCompany.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    ServiceCompany.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                if (writServiceReceipt != null)
                {
                    writServiceReceipt = InvokeUtil.SystemService.EntityInit(writServiceReceipt) as WritServiceReceipt;
                    SetEntity(writServiceReceipt);
                    enforceLawGridViewItems.Bind<WritServiceReceiptItem>(writServiceReceipt.Items);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmWritServiceReceipts"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (writServiceReceipt == null)
                {
                    writServiceReceipt = new WritServiceReceipt();

                    writServiceReceipt.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                writServiceReceipt.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("文书送达回执");
                doc.AddField("DocTitle", writServiceReceipt.DocTitle);
                doc.AddField("CaseName", writServiceReceipt.CaseName);
                doc.AddField("ServiceCompany", writServiceReceipt.ServiceCompany);
                doc.AddField("DocManageArea", writServiceReceipt.DocManageArea);
                doc.AddField("Note", writServiceReceipt.Note);
                
                Grid grid = doc.NewGrid();
                grid.TableMark = "Table";
                foreach (WritServiceReceiptItem sc in writServiceReceipt.Items)
                {
                    GridRow row = grid.NewRow();
                    row.AddRowItem(sc.WritName);
                    row.AddRowItem(sc.Recipient);
                    row.AddRowItem(sc.ServiceDate.ToString("yyyy年M月d日"));
                    row.AddRowItem(sc.ServiceAddress);
                    row.AddRowItem(sc.ServiceWay);
                    row.AddRowItem(sc.ServicePerson);
                }

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmWritServiceReceipts", writServiceReceipt.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (writServiceReceipt == null)
            {
                writServiceReceipt = new WritServiceReceipt();

                writServiceReceipt.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            writServiceReceipt.Items.Clear();
            foreach (DataGridViewRow row in enforceLawGridViewItems.Rows)
            {
                if (row.Tag != null)
                    writServiceReceipt.Items.Add(row.Tag as WritServiceReceiptItem);
            }

            GetEntity(writServiceReceipt);

            InvokeUtil.SystemService.EntityUpdate(writServiceReceipt);
        }

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批, (int)SOA.ORM.InstrumentsExample.EHearingChengpiType.文书送达回执);
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

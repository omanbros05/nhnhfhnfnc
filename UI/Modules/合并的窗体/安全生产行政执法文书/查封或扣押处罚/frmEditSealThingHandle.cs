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
using System.Diagnostics;

namespace EnforceForm
{
    public partial class frmEditSealThingHandle : BaseTableForm
    {
        public SealThingHandle sealThingHandle;

        public frmEditSealThingHandle()
        {
            InitializeComponent();
            this.SealDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealThingHandle"));
        }


        public frmEditSealThingHandle(SealThingHandle sealThingHandle)
            : this()
        {
            this.sealThingHandle = sealThingHandle;
        }

        private void frmEditSealThingHandle_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                HandleDate.Value = DateTime.Now;
                Government.Text = InvokeUtil.ActiveUser.Area;
                ManageDepartment.Text = InvokeUtil.ActiveUser.FullName;
                Court.Text = InvokeUtil.ActiveUser.Area;
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                CompanyName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (sealThingHandle != null)
                {
                    SetEntity(sealThingHandle);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealThingHandle"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚, (int)SOA.ORM.InstrumentsExample.ESealPunishType.查封或扣押物品处理决定书);
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
                if (sealThingHandle == null)
                {
                    sealThingHandle = new SealThingHandle();

                    sealThingHandle.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                sealThingHandle.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("查封（扣押）物品处理决定书");
                doc.AddField("DocTitle", sealThingHandle.DocTitle);
                doc.AddField("CompanyName", sealThingHandle.CompanyName);
                doc.AddField("SealDate", sealThingHandle.SealDate.ToString("yyyy年MM月dd日"));
                doc.AddField("SealContent", sealThingHandle.SealContent);
                doc.AddField("SealResult", sealThingHandle.SealResult);
                doc.AddField("ThingCheckNo", sealThingHandle.ThingCheckNo);
                doc.AddField("Government", sealThingHandle.Government);
                doc.AddField("ManageDepartment", sealThingHandle.ManageDepartment);
                doc.AddField("Court", sealThingHandle.Court);
                doc.AddFootField("DocManageArea", sealThingHandle.DocManageArea);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSealThingHandle", sealThingHandle.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {
            if (sealThingHandle == null)
            {
                sealThingHandle = new SealThingHandle();

                sealThingHandle.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(sealThingHandle);

            InvokeUtil.SystemService.EntityUpdate(sealThingHandle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

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
    public partial class frmEditSealDecide : BaseTableForm
    {
        public SealDecide sealDecide;

        public frmEditSealDecide()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealDecide"));
        }

        public frmEditSealDecide(SealDecide sealDecide)
            : this()
        {
            this.sealDecide = sealDecide;
        }

        private void frmEditSealDecide_Load(object sender, EventArgs e)
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
                UserName1.Items.Clear();
                UserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (sealDecide != null)
                {
                    SetEntity(sealDecide);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSealDecide"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚, (int)SOA.ORM.InstrumentsExample.ESealPunishType.查封或扣押决定书);
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

            UseWaitCursor = true;
            Application.DoEvents();
            try
            {
                if (sealDecide == null)
                {
                    sealDecide = new SealDecide();

                    sealDecide.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                SaveData();
                sealDecide.Status = 1;
                WordDocument doc = new WordDocument("查封(扣押)决定书");
                doc.AddField("DocTitle", sealDecide.DocTitle);
                doc.AddField("CompanyName", sealDecide.CompanyName);
                doc.AddField("SealReason", sealDecide.SealReason);
                doc.AddField("SealLaw", sealDecide.SealLaw);
                doc.AddField("Government", sealDecide.Government);
                doc.AddField("ManageDepartment", sealDecide.ManageDepartment);
                doc.AddField("Court", sealDecide.Court);
                doc.AddField("SealLocation", sealDecide.SealLocation);
                doc.AddField("SealStartDate", sealDecide.SealStartDate.ToString(""));
                doc.AddField("SealEndDate", sealDecide.SealEndDate.ToString("yyyy年MM月dd日"));
                doc.AddFootField("DocManageArea", sealDecide.DocManageArea);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmSealDecide", sealDecide.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {
            if (sealDecide == null)
            {
                sealDecide = new SealDecide();

                sealDecide.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(sealDecide);

            InvokeUtil.SystemService.EntityUpdate(sealDecide);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

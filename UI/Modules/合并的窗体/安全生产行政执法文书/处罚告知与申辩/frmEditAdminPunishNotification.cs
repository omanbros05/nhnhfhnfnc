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
    public partial class frmEditAdminPunishNotification : BaseTableForm
    {
        private AdminPunishNotification obj = null;

        public frmEditAdminPunishNotification()
        {
            InitializeComponent();
            this.SendDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmAdminPunishNotification"));
        }

        public frmEditAdminPunishNotification(AdminPunishNotification obj)
            : this()
        {
            this.obj = obj;
        }

        private void frmEditAdminPunishNotification_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                CompanyName.Items.Clear();
                foreach (SearchWord word in Words)
                {
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                Contacter.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    Contacter.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (obj != null)
                {
                    SetEntity(obj);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmAdminPunishNotification"));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩, (int)SOA.ORM.InstrumentsExample.EPunishInformDefenseType.行政处罚告知书);
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

                if (obj == null)
                {
                    obj = new AdminPunishNotification();

                    obj.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                obj.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("行政处罚告知书");
                doc.AddField("DocTitle", obj.DocTitle);
                doc.AddField("CompanyName", obj.CompanyName);
                doc.AddField("BriefCase", obj.BriefCase);
                doc.AddField("CompanyBehavior", obj.CompanyBehavior);
                doc.AddField("LawProvision", obj.LawProvision);
                doc.AddField("Certificate", obj.Certificate);
                doc.AddField("AdminPunish", obj.AdminPunish);
                doc.AddField("Address", obj.Address);
                doc.AddField("Post", obj.Post);
                doc.AddField("Contacter", obj.Contacter);
                doc.AddField("Tel", obj.Tel);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmAdminPunishNotification", obj.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {

            if (obj == null)
            {
                obj = new AdminPunishNotification();

                obj.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(obj);

            InvokeUtil.SystemService.EntityUpdate(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }

    }
}

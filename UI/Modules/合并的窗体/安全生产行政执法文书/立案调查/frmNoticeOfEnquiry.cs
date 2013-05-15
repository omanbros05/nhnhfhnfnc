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
    public partial class frmNoticeOfEnquiry : BaseTableForm
    {
        private NoticeOfEnquiry noticeOfEnquiry = null;
        public frmNoticeOfEnquiry()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmNoticeOfEnquirys"));
        }

        public frmNoticeOfEnquiry(NoticeOfEnquiry noticeOfEnquiry)
            : this()
        {
            this.noticeOfEnquiry = noticeOfEnquiry;
        }

        private void frmNoticeOfEnquiry_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管询〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;
                ToDateTime.Value = DateTime.Now;

                CompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    CompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                IllegalTypeName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(IllegalType).FullName);
                foreach (SearchWord word in Words)
                    IllegalTypeName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                ToAddress.Text = InvokeUtil.ActiveUser.FullName;
                DetpAddress.Text = InvokeUtil.ActiveUser.Address;

                DetpName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    DetpName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (noticeOfEnquiry != null)
                {
                    SetEntity(noticeOfEnquiry);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmNoticeOfEnquirys"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (noticeOfEnquiry == null)
            {
                noticeOfEnquiry = new NoticeOfEnquiry();
                noticeOfEnquiry.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            GetEntity(noticeOfEnquiry);

            Company company = new Company
            {
                CompanyName = CompanyName.Text,
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);

            InvokeUtil.SystemService.EntityUpdate(noticeOfEnquiry);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (noticeOfEnquiry == null)
                {
                    noticeOfEnquiry = new NoticeOfEnquiry();
                    noticeOfEnquiry.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                noticeOfEnquiry.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("询问通知书");
                doc.AddField("DocTitle", noticeOfEnquiry.DocTitle);
                doc.AddField("CompanyName", noticeOfEnquiry.CompanyName);
                doc.AddField("IllegalTypeName", noticeOfEnquiry.IllegalTypeName);
                doc.AddField("ToDateTimeYear", noticeOfEnquiry.ToDateTime.Year.ToString());
                doc.AddField("ToDateTimeMonth", noticeOfEnquiry.ToDateTime.Month.ToString());
                doc.AddField("ToDateTimeDay", noticeOfEnquiry.ToDateTime.Day.ToString());
                string Cord = "";
                //if (noticeOfEnquiry.IfID == true)
                //    Cord += "√ 身份证      ";
                //if (noticeOfEnquiry.IfBusinessLicense == true)
                //    Cord += "√ 营业执照     ";
                //if (noticeOfEnquiry.IfLawID == true)
                //    Cord += "√ 法定代表人身份证明        ";
                //if (noticeOfEnquiry.IfOther == true)
                //    Cord += "√ " + noticeOfEnquiry.OtherDocument;
                if (noticeOfEnquiry.IfID == true)
                    Cord += "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">√ 身份证</font><br/>";
                if (noticeOfEnquiry.IfBusinessLicense == true)
                    Cord += "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">√ 营业执照</font><br/>";
                if (noticeOfEnquiry.IfLawID == true)
                    Cord += "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">√ 法定代表人身份证明</font><br/>";
                if (noticeOfEnquiry.IfOther == true)
                    Cord += "<font style=\"font-family:fangsong_GB2312;font-size:12pz;line-height:26px;\">√ " + noticeOfEnquiry.OtherDocument + "</font>";
                doc.AddField("Cord", Cord, EFieldType.Html);
                doc.AddField("DetpAddress", noticeOfEnquiry.DetpAddress);
                doc.AddField("DetpName", noticeOfEnquiry.DetpName);
                doc.AddField("DetpPhone", noticeOfEnquiry.DetpPhone);
                doc.AddFootField("DocManageArea", noticeOfEnquiry.DocManageArea);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmNoticeOfEnquirys", noticeOfEnquiry.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.询问通知书);
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

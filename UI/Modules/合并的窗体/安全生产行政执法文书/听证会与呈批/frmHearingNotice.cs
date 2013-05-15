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
    public partial class frmHearingNotice : BaseTableForm
    {
        public HearingNotice hearingNotice;

        public frmHearingNotice()
        {
            InitializeComponent();
            this.DocDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingNotices"));
        }

        public frmHearingNotice(HearingNotice hearingNotice)
            : this()
        {
            this.hearingNotice = hearingNotice;
        }

        private void frmHearingNotice_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管听通〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;

                HearDate.Value = DateTime.Now;
                DocDate.Value = DateTime.Now;

                DocManageAddress.Text = InvokeUtil.ActiveUser.FullName + "地址:" + InvokeUtil.ActiveUser.Address;
                DocManagePost.Text = "邮编:" + InvokeUtil.ActiveUser.Post + "      联系人:XXX";
                LinkMan.Text = "联系电话:" + InvokeUtil.ActiveUser.Tel;

                Informant.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    Informant.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));

                CompereName.Items.Clear();
                HearName1.Items.Clear();
                HearName2.Items.Clear();
                SecretaryName.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    CompereName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    HearName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    HearName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    SecretaryName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }

                if (hearingNotice != null)
                {
                    SetEntity(hearingNotice);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingNotices"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void CompereName_SelectedListIndexChangeEvent(object sender, AutoCompleteTextBox.SelectedListIndexChangedArgs e)
        {
            //try
            //{
            //    if (e.SelectedListValue != null)
            //    {
            //        SearchWord word = e.SelectedListValue as SearchWord;
            //        Officers officer = word.ToObject<Officers>();
            //        CompereJob.Text = officer.Position;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CommonInvoke.ErrorMessageBox(ex);
            //}
        }

        private void CompereName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (CompereName.SelectedValue != null)
                {
                    SearchWord word = CompereName.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    CompereJob.Text = officer.Position;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void HearName1_SelectedListIndexChangeEvent(object sender, AutoCompleteTextBox.SelectedListIndexChangedArgs e)
        {
            //try
            //{
            //    if (e.SelectedListValue != null)
            //    {
            //        SearchWord word = e.SelectedListValue as SearchWord;
            //        Officers officer = word.ToObject<Officers>();
            //        HearJob1.Text = officer.Position;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CommonInvoke.ErrorMessageBox(ex);
            //}
        }

        private void HearName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (HearName1.SelectedValue != null)
                {
                    SearchWord word = HearName1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    HearJob1.Text = officer.Position;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void HearName2_SelectedListIndexChangeEvent(object sender, AutoCompleteTextBox.SelectedListIndexChangedArgs e)
        {
            //try
            //{
            //    if (e.SelectedListValue != null)
            //    {
            //        SearchWord word = e.SelectedListValue as SearchWord;
            //        Officers officer = word.ToObject<Officers>();
            //        HearJob2.Text = officer.Position;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CommonInvoke.ErrorMessageBox(ex);
            //}
        }

        private void HearName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (HearName2.SelectedValue != null)
                {
                    SearchWord word = HearName2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    HearJob2.Text = officer.Position;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }
        
        private void SecretaryName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (SecretaryName.SelectedValue != null)
                {
                    SearchWord word = SecretaryName.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    SecretaryJob.Text = officer.Position;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批, (int)SOA.ORM.InstrumentsExample.EHearingChengpiType.听证会通知书);
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
                if (hearingNotice == null)
                {
                    hearingNotice = new HearingNotice();

                    hearingNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                hearingNotice.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("听证会通知书");
                doc.AddField("DocTitle", hearingNotice.DocTitle);
                doc.AddField("Informant", hearingNotice.Informant);
                doc.AddField("About", hearingNotice.About);
                doc.AddField("HearDate", hearingNotice.HearDate.ToString("yyyy年M月d日 H时 m分"));
                doc.AddField("HearAddress", hearingNotice.HearAddress);
                doc.AddField("CompereName", hearingNotice.CompereName);
                doc.AddField("CompereJob", hearingNotice.CompereJob);
                doc.AddField("HearName1", hearingNotice.HearName1);
                doc.AddField("HearJob1", hearingNotice.HearJob1);
                doc.AddField("HearName2", hearingNotice.HearName2);
                doc.AddField("HearJob2", hearingNotice.HearJob2);
                doc.AddField("SecretaryName", hearingNotice.SecretaryName);
                doc.AddField("SecretaryJob", hearingNotice.SecretaryJob);
                doc.AddFootField("DocManageArea", hearingNotice.DocManageArea);
                doc.AddFootField("DocManageArea1", hearingNotice.DocManageArea.Replace("(公章)", ""));
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmHearingNotices", hearingNotice.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (hearingNotice == null)
            {
                hearingNotice = new HearingNotice();

                hearingNotice.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(hearingNotice);

            Officers officer1 = new Officers { OfficersName = HearName1.Text, Position = HearJob1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer2 = new Officers { OfficersName = HearName2.Text, Position = HearJob2.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);

            Officers officer3 = new Officers { OfficersName = CompereName.Text, Position = CompereJob.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer3);

            Officers officer4 = new Officers { OfficersName = SecretaryName.Text, Position = SecretaryJob.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer4);

            if (Informant.SelectedValue != null)
            {
                SearchWord searchWord = Informant.SelectedValue as SearchWord;
                Company company = searchWord.ToObject<Company>();
                hearingNotice.CompanyID = company.CompanyID;
            }

            InvokeUtil.SystemService.EntityUpdate(hearingNotice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

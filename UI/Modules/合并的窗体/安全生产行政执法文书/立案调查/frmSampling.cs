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
    public partial class frmSampling : BaseTableForm
    {
        private Sampling sampling = null;

        public frmSampling()
        {
            InitializeComponent();
            this.FillDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSamplings"));
        }

        public frmSampling(Sampling sampling)
            : this()
        {
            this.sampling = sampling;
        }

        private void frmSampling_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管抽〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                BeganTime.Value = DateTime.Now;
                ToTime.Value = DateTime.Now;
                FillDate.Value = DateTime.Now;

                SamplingContentGridViewItems.InitColumnType<SamplingContent>();
                if (sampling != null)
                {
                    sampling = InvokeUtil.SystemService.EntityInit(sampling) as Sampling;
                    SetEntity(sampling);
                    SamplingContentGridViewItems.Bind<SamplingContent>(sampling.Items);
                }
                FieldECompanyName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Company).FullName);
                foreach (SearchWord word in Words)
                    FieldECompanyName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                FieldEPeopleName.Items.Clear();
                WitnesEPeopleName1.Items.Clear();
                WitnesEPeopleName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    FieldEPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    WitnesEPeopleName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    WitnesEPeopleName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                ExecUserName1.Items.Clear();
                ExecUserName2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    ExecUserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ExecUserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSamplings"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void FieldEPeopleName_TextChanged(object sender, EventArgs e)
        {
            FieldEPeopleName1.Text = FieldEPeopleName.Text;
        }

        private void FieldECompanyName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (FieldECompanyName.SelectedValue != null)
                {
                    SearchWord word = FieldECompanyName.SelectedValue as SearchWord;
                    Company company = word.ToObject<Company>();
                    FieldEPeopleName.Text = company.JuridicalPerson;
                    FieldEAddress.Text = company.CompanyAddress;
                    FieldEPeoplePhone.Text = company.Mobile;
                    FieldEPeopleZio.Text = company.CompanyPost;
                    FieldEPeopleName1.Text = company.JuridicalPerson;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void ExecUserName1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ExecUserName1.SelectedValue != null)
                {
                    SearchWord word = ExecUserName1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    ExecUserNumber1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void ExecUserName2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ExecUserName2.SelectedValue != null)
                {
                    SearchWord word = ExecUserName2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    ExecUserNumber2.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SaveData()
        {
            if (sampling == null)
            {
                sampling = new Sampling();
                sampling.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            sampling.Items.Clear();
            foreach (DataGridViewRow row in SamplingContentGridViewItems.Rows)
            {
                if (row.Tag != null)
                    sampling.Items.Add(row.Tag as SamplingContent);
            }

            ToTime.Value = DateTime.Parse(BeganTime.Value.ToString("yyyy-MM-dd") + ToTime.Value.ToString(" HH:mm:ss"));

            GetEntity(sampling);

            Company company = new Company
            {
                CompanyName = FieldECompanyName.Text,
                CompanyAddress = FieldEAddress.Text,
                Mobile = FieldEPeoplePhone.Text,
                CompanyPost = FieldEPeopleZio.Text
            };
            InvokeUtil.SystemService.UpdateCompanyByName(company);
            NaturalPerson naturalPerson = new NaturalPerson
            {
                PersonName = FieldEPeopleName.Text,
                CompanyName = FieldECompanyName.Text,
                CompanyAddress = FieldEAddress.Text,
                CompanyTel = FieldEPeoplePhone.Text,
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);
            NaturalPerson naturalPerson1 = new NaturalPerson
            {
                PersonName = WitnesEPeopleName1.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson1);
            NaturalPerson naturalPerson2 = new NaturalPerson
            {
                PersonName = WitnesEPeopleName2.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson2);
            Officers officer1 = new Officers { OfficersName = ExecUserName1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer1);
            Officers officer2 = new Officers { OfficersName = ExecUserName1.Text };
            InvokeUtil.SystemService.UpdateOfficersByArgs(officer2);


            InvokeUtil.SystemService.EntityUpdate(sampling);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (sampling == null)
                {
                    sampling = new Sampling();
                    sampling.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                sampling.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("抽样取证凭证");
                doc.AddField("DocTitle", sampling.DocTitle);
                doc.AddField("FieldECompanyName", sampling.FieldECompanyName);
                doc.AddField("FieldEPeopleName", sampling.FieldEPeopleName);
                doc.AddField("FieldEAddress", sampling.FieldEAddress);
                doc.AddField("FieldEPeoplePhone", sampling.FieldEPeoplePhone);
                doc.AddField("FieldEPeopleZio", sampling.FieldEPeopleZio);
                doc.AddField("BeganTimeYear", sampling.BeganTime.Year.ToString());
                doc.AddField("BeganTimeMonth", sampling.BeganTime.Month.ToString());
                doc.AddField("BeganTimeDay", sampling.BeganTime.Day.ToString());
                doc.AddField("BeganTimeHour", sampling.BeganTime.Hour.ToString());
                doc.AddField("BeganTimeMinute", sampling.BeganTime.Minute.ToString());
                doc.AddField("ToTimeDay", sampling.ToTime.Day.ToString());
                doc.AddField("ToTimeHour", sampling.ToTime.Hour.ToString());
                doc.AddField("ToTimeMinute", sampling.ToTime.Minute.ToString());
                doc.AddField("SamplingAddress", sampling.SamplingAddress);
                doc.AddFootField("DocManageArea", sampling.DocManageArea);
                //doc.AddFootField("FirstPageTest", "测试");
                //doc.AddFootField("Test", "测试");

                Grid grid = doc.NewGrid();
                grid.TableMark = "Table";
                int i = 0;
                foreach (SamplingContent sc in sampling.Items)
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
                    new object[] { doc, "EnforceForm.frmSamplings", sampling.FilePath }));
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查, (int)SOA.ORM.InstrumentsExample.ECaseSurveyType.抽样取证凭证);
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

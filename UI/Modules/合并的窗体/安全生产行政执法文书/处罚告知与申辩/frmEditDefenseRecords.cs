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
    public partial class frmEditDefenseRecords : BaseTableForm
    {
        public DefenseRecords defenseRecords;

        public frmEditDefenseRecords()
        {
            InitializeComponent();
            //当前时间
            DateTime dt = DateTime.Now;
            //本月第一天时间    
            DateTime dt_First = dt.AddDays(1 - (dt.Day));
            //获得某年某月的天数  
            int year = dt.Date.Year;
            int month = dt.Date.Month;
            int dayCount = DateTime.DaysInMonth(year, month);
            //本月最后一天时间  
            DateTime dt_Last = dt_First.AddDays(dayCount - 1);
            this.DefenseStartDate.Value = dt_First;
            this.DefenseEndDate.Value = dt_Last;
            this.DefenseDate.Value = DateTime.Now;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmDefenseRecords"));
        }

        public frmEditDefenseRecords(DefenseRecords defenseRecords)
            : this()
        {
            this.defenseRecords = defenseRecords;
        }

        private void frmEditDefenseRecords_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                LawUnit.Text = InvokeUtil.ActiveUser.FullName;
                DefenseUser.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    DefenseUser.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                UserName1.Items.Clear();
                UserName2.Items.Clear();
                UserName3.Items.Clear();
                ProblemUser1.Items.Clear();
                ProblemUser2.Items.Clear();
                Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(Officers).FullName);
                foreach (SearchWord word in Words)
                {
                    UserName1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UserName2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    UserName3.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ProblemUser1.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                    ProblemUser2.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (defenseRecords != null)
                {
                    SetEntity(defenseRecords);
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmDefenseRecords"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void DefenseUser_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (DefenseUser.SelectedValue != null)
                {
                    SearchWord word = DefenseUser.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    Sex.Text = naturalPerson.Sex;
                    Position.Text = naturalPerson.Job;
                    WorkUnit.Text = naturalPerson.CompanyName;
                    Tel.Text = naturalPerson.CompanyTel;
                    Address.Text = naturalPerson.Address;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void ProblemUser1_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ProblemUser1.SelectedValue != null)
                {
                    SearchWord word = ProblemUser1.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    ProblemUserCode1.Text = officer.CID;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void ProblemUser2_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (ProblemUser2.SelectedValue != null)
                {
                    SearchWord word = ProblemUser2.SelectedValue as SearchWord;
                    Officers officer = word.ToObject<Officers>();
                    ProblemUserCode2.Text = officer.CID;
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩, (int)SOA.ORM.InstrumentsExample.EPunishInformDefenseType.当事人陈诉申辩笔录);
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
                if (defenseRecords == null)
                {
                    defenseRecords = new DefenseRecords();

                    defenseRecords.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                defenseRecords.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("当事人陈述申辩笔录");
                doc.AddField("DefenseStartDateYear", defenseRecords.DefenseStartDate.Year.ToString());
                doc.AddField("DefenseStartDateMonth", defenseRecords.DefenseStartDate.Month.ToString());
                doc.AddField("DefenseStartDateDay", defenseRecords.DefenseStartDate.Day.ToString());
                doc.AddField("DefenseStartDateHour", defenseRecords.DefenseStartDate.Hour.ToString());
                doc.AddField("DefenseStartDateMinute", defenseRecords.DefenseStartDate.Minute.ToString());
                doc.AddField("DefenseEndDateDay", defenseRecords.DefenseEndDate.Day.ToString());
                doc.AddField("DefenseEndDateHour", defenseRecords.DefenseEndDate.Hour.ToString());
                doc.AddField("DefenseEndDateMinute", defenseRecords.DefenseEndDate.Minute.ToString());
                doc.AddField("Location", defenseRecords.Location);
                doc.AddField("DefenseUser", defenseRecords.DefenseUser);
                doc.AddField("Sex", defenseRecords.Sex);
                doc.AddField("Position", defenseRecords.Position);
                doc.AddField("WorkUnit", defenseRecords.WorkUnit);
                doc.AddField("Tel", defenseRecords.Tel);
                doc.AddField("Address", defenseRecords.Address);
                doc.AddField("ZipCode", defenseRecords.ZipCode);
                string UserNameStr = defenseRecords.UserName1 + (defenseRecords.UserName2 != "" ? "、" + defenseRecords.UserName2 : "");
                doc.AddField("UserName1", UserNameStr);
                doc.AddField("UserName3", defenseRecords.UserName3);
                doc.AddField("LawUnit", defenseRecords.LawUnit);
                doc.AddField("ProblemResult1", defenseRecords.ProblemResult1);
                doc.AddField("ProblemResult2", defenseRecords.ProblemResult2);
                doc.AddField("ProblemResult3", defenseRecords.ProblemResult3);
                doc.AddField("CaseName", defenseRecords.CaseName);
                doc.AddField("ProblemUser1", defenseRecords.ProblemUser1);
                doc.AddField("ProblemUser2", defenseRecords.ProblemUser2);
                doc.AddField("ProblemUserCode1", defenseRecords.ProblemUserCode1);
                doc.AddField("ProblemUserCode2", defenseRecords.ProblemUserCode2);
                doc.AddField("ProblemResult4", defenseRecords.ProblemResult4);
                doc.AddField("ProblemContent", defenseRecords.ProblemContent);
                doc.AddFootField("DocManageArea", InvokeUtil.ActiveUser.FullName);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt",
                    new object[] { doc, "EnforceForm.frmDefenseRecords", defenseRecords.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void SaveData()
        {

            if (defenseRecords == null)
            {
                defenseRecords = new DefenseRecords();

                defenseRecords.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }
            GetEntity(defenseRecords);

            InvokeUtil.SystemService.EntityUpdate(defenseRecords);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }
    }
}

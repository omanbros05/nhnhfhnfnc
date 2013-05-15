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
    public partial class frmPunishmentDecisionPersonal : BaseTableForm
    {
        private PunishmentDecisionPersonal punishmentDecisionPersonal = null;
        public frmPunishmentDecisionPersonal()
        {
            InitializeComponent();
        }
        public frmPunishmentDecisionPersonal(PunishmentDecisionPersonal punishmentDecisionPersonal)
            : this()
        {
            this.punishmentDecisionPersonal = punishmentDecisionPersonal;
        }

        private void frmPunishmentDecisionPersonal_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DocTitle.Text = InvokeUtil.ActiveUser.Abb + "安监管罚〔" + DateTime.Now.Year + "〕1 号";
                DocManageArea.Text = InvokeUtil.ActiveUser.FullName;
                FillDate.Value = DateTime.Now;

                FieldEPeopleName.Items.Clear();
                List<SearchWord> Words = InvokeUtil.SystemService.SearchWordGetAll(typeof(NaturalPerson).FullName);
                foreach (SearchWord word in Words)
                {
                    FieldEPeopleName.Items.Add(new AutoCompleteEntry(word.Words, word, word.ToIndexArray()));
                }
                if (punishmentDecisionPersonal != null)
                {
                    SetEntity(punishmentDecisionPersonal);
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
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }


        private void FieldEPeopleName_SelectedValueChangedEvent(object sender, EventArgs e)
        {
            try
            {
                if (FieldEPeopleName.SelectedValue != null)
                {
                    SearchWord word = FieldEPeopleName.SelectedValue as SearchWord;
                    NaturalPerson naturalPerson = word.ToObject<NaturalPerson>();
                    FieldEPeopleSex.Text = naturalPerson.Sex;
                    FieldEPeopleAge.Text = naturalPerson.Age;
                    FieldEPeoplePhone.Text = naturalPerson.CompanyTel;
                    FieldEPeopleAddress.Text = naturalPerson.Address;
                    FieldEPeopleCompanyName.Text = naturalPerson.CompanyName;
                    FieldEPeoplePosition.Text = naturalPerson.Job;
                    FieldEPeopleCompanyAddress.Text = naturalPerson.CompanyAddress;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

        private void SaveData()
        {
            if (punishmentDecisionPersonal == null)
                punishmentDecisionPersonal = new PunishmentDecisionPersonal();

            GetEntity(punishmentDecisionPersonal);

            NaturalPerson naturalPerson = new NaturalPerson
            {
                Sex = FieldEPeopleSex.Text,
                Age = FieldEPeopleAge.Text,
                CompanyTel = FieldEPeoplePhone.Text,
                Address = FieldEPeopleAddress.Text,
                CompanyName = FieldEPeopleCompanyName.Text,
                Job = FieldEPeoplePosition.Text,
                CompanyAddress = FieldEPeopleCompanyAddress.Text
            };
            InvokeUtil.SystemService.UpdateNaturalPersonByArgs(naturalPerson);

            InvokeUtil.SystemService.EntityUpdate(punishmentDecisionPersonal);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                WordDocument doc = new WordDocument("行政处罚决定书个人");
                doc.AddField("DocTitle", punishmentDecisionPersonal.DocTitle);
                doc.AddField("FieldEPeopleName", punishmentDecisionPersonal.FieldEPeopleName);
                doc.AddField("FieldEPeopleSex", punishmentDecisionPersonal.FieldEPeopleSex);
                doc.AddField("FieldEPeopleAge", punishmentDecisionPersonal.FieldEPeopleAge);
                doc.AddField("FieldEPeoplePhone", punishmentDecisionPersonal.FieldEPeoplePhone);
                doc.AddField("FieldEPeopleAddress", punishmentDecisionPersonal.FieldEPeopleAddress);
                doc.AddField("FieldEPeopleCompanyName", punishmentDecisionPersonal.FieldEPeopleCompanyName);
                doc.AddField("FieldEPeoplePosition", punishmentDecisionPersonal.FieldEPeoplePosition);
                doc.AddField("FieldEPeopleCompanyAddress", punishmentDecisionPersonal.FieldEPeopleCompanyAddress);
                doc.AddField("FieldEPeopleZip", punishmentDecisionPersonal.FieldEPeopleZip);
                doc.AddField("IllegalEvidence", punishmentDecisionPersonal.IllegalEvidence);
                doc.AddField("IllegalProvisions", punishmentDecisionPersonal.IllegalProvisions);
                doc.AddField("According", punishmentDecisionPersonal.According);
                doc.AddField("PunishmentAmount", punishmentDecisionPersonal.PunishmentAmount);
                doc.AddField("BankName", punishmentDecisionPersonal.BankName);
                doc.AddField("BankID", punishmentDecisionPersonal.BankID);
                doc.AddField("ReconsiderationUnitName1", punishmentDecisionPersonal.ReconsiderationUnitName1);
                doc.AddField("ReconsiderationUnitName2", punishmentDecisionPersonal.ReconsiderationUnitName2);
                doc.AddField("LitigationUnitName", punishmentDecisionPersonal.LitigationUnitName);
                doc.AddFootField("DocManageArea", punishmentDecisionPersonal.DocManageArea);
                
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
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
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚, (int)SOA.ORM.InstrumentsExample.EAdminPunishType.行政处罚决定书个人);
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

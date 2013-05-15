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

namespace EnforceForm
{
    public partial class frmCompanyNoCoalSecurity : BaseTableForm
    {
        public CompanyNoCoalSecurity CompanyNoCoalSecurity;
        public frmCompanyNoCoalSecurity()
        {
            InitializeComponent();
        }
        public frmCompanyNoCoalSecurity(CompanyNoCoalSecurity CompanyNoCoalSecurity)
            : this()
        {
            this.CompanyNoCoalSecurity = CompanyNoCoalSecurity;
        }
        private void frmCompanyNoCoalSecurity_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
                foreach (CompanyArea Area in Areas.Items)
                {
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
                }
                if (Areas.Items.Count > 0)
                {
                    this.comboBox1.Text = Areas.Items[0].AreaName;
                }

                if (CompanyNoCoalSecurity != null)
                {

                    this.CertificateNumber.Text = CompanyNoCoalSecurity.CertificateNumber;
                    EconomicType.Text = CompanyNoCoalSecurity.EconomicType;
                    MiningMethods.Text = CompanyNoCoalSecurity.MiningMethods;
                    PermitRange.Text = CompanyNoCoalSecurity.PermitRange;
                    StandardizationRegister.Text = CompanyNoCoalSecurity.StandardizationRegister;
                    ValidStartDate.Text = CompanyNoCoalSecurity.ValidStartDate.ToString();
                    ValidEndDate.Text = CompanyNoCoalSecurity.ValidEndDate.ToString();

                    CompanyAddress.Text = CompanyNoCoalSecurity.Company.CompanyAddress;
                    CompanyName.Text = CompanyNoCoalSecurity.Company.CompanyName;
                    CompanyPost.Text = CompanyNoCoalSecurity.Company.CompanyPost;
                    JuridicalPerson.Text = CompanyNoCoalSecurity.Company.JuridicalPerson;
                    JuridicalPersonAge.Text = CompanyNoCoalSecurity.Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = CompanyNoCoalSecurity.Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = CompanyNoCoalSecurity.Company.JuridicalPersonSex;
                    Mobile.Text = CompanyNoCoalSecurity.Company.Mobile;
                    Tel.Text = CompanyNoCoalSecurity.Company.Tel;

                    if (CompanyNoCoalSecurity.Company.IsCity == 0)
                    {
                        this.radioButton2.Checked = true;
                    }
                    try
                    {
                        CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyNoCoalSecurity.Company.CompanyAreaID });
                        this.comboBox1.Text = area.AreaName;
                    }
                    catch { }
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
                if (CompanyNoCoalSecurity == null)
                    CompanyNoCoalSecurity = new CompanyNoCoalSecurity();

                //GetEntity(CompanyDangerChemicals);

                CompanyNoCoalSecurity.CertificateNumber = this.CertificateNumber.Text.Trim();
                CompanyNoCoalSecurity.EconomicType = EconomicType.Text.Trim();
                CompanyNoCoalSecurity.MiningMethods = MiningMethods.Text.Trim();
                CompanyNoCoalSecurity.PermitRange = PermitRange.Text.Trim();
                CompanyNoCoalSecurity.StandardizationRegister = StandardizationRegister.Text;
                CompanyNoCoalSecurity.ValidStartDate = DateTime.Parse(ValidStartDate.Text);
                CompanyNoCoalSecurity.ValidEndDate = DateTime.Parse(ValidEndDate.Text);

                CompanyNoCoalSecurity.Company.CompanyAddress = CompanyAddress.Text.Trim();
                CompanyNoCoalSecurity.Company.CompanyName = CompanyName.Text.Trim();
                CompanyNoCoalSecurity.Company.CompanyPost = CompanyPost.Text.Trim();
                CompanyNoCoalSecurity.Company.JuridicalPerson = JuridicalPerson.Text.Trim();
                CompanyNoCoalSecurity.Company.JuridicalPersonAge = JuridicalPersonAge.Text.Trim();
                CompanyNoCoalSecurity.Company.JuridicalPersonJob = JuridicalPersonJob.Text.Trim();
                CompanyNoCoalSecurity.Company.JuridicalPersonSex = JuridicalPersonSex.Text.Trim();
                CompanyNoCoalSecurity.Company.Mobile = Mobile.Text.Trim();
                CompanyNoCoalSecurity.Company.Tel = Tel.Text.Trim();

                if (this.radioButton1.Checked)
                {
                    CompanyNoCoalSecurity.Company.IsCity = 1;
                }
                else
                {
                    CompanyNoCoalSecurity.Company.IsCity = 0;
                }
                CompanyNoCoalSecurity.Company.CompanyAreaID = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);

                InvokeUtil.SystemService.EntityUpdate(CompanyNoCoalSecurity);
                CommonInvoke.MessageBox("操作成功！");
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

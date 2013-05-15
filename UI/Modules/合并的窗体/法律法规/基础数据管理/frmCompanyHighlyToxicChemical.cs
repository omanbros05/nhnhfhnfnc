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
    public partial class frmCompanyHighlyToxicChemical : BaseTableForm
    {
        public CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals;
        public frmCompanyHighlyToxicChemical()
        {
            InitializeComponent();
        }
        public frmCompanyHighlyToxicChemical(CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals)
            : this()
        {
            this.CompanyHighlyToxicChemicals = CompanyHighlyToxicChemicals;
        }
        private void CompanyHighlyToxicChemicals_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CompanyHighlyToxicChemicals != null)
                {

                    this.MainProducts.Text = CompanyHighlyToxicChemicals.MainProducts;
                    this.Registration.Text = CompanyHighlyToxicChemicals.Registration;
                    ValidStartDate.Text = CompanyHighlyToxicChemicals.ValidStartDate.ToString();
                    ValidEndDate.Text = CompanyHighlyToxicChemicals.ValidEndDate.ToString();

                    CompanyAddress.Text = CompanyHighlyToxicChemicals.Company.CompanyAddress;
                    CompanyName.Text = CompanyHighlyToxicChemicals.Company.CompanyName;
                    CompanyPost.Text = CompanyHighlyToxicChemicals.Company.CompanyPost;
                    JuridicalPerson.Text = CompanyHighlyToxicChemicals.Company.JuridicalPerson;
                    JuridicalPersonAge.Text = CompanyHighlyToxicChemicals.Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = CompanyHighlyToxicChemicals.Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = CompanyHighlyToxicChemicals.Company.JuridicalPersonSex;
                    Mobile.Text = CompanyHighlyToxicChemicals.Company.Mobile;
                    Tel.Text = CompanyHighlyToxicChemicals.Company.Tel;
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
                if (CompanyHighlyToxicChemicals == null)
                    CompanyHighlyToxicChemicals = new CompanyHighlyToxicChemicals();

                CompanyHighlyToxicChemicals.MainProducts = MainProducts.Text;
                CompanyHighlyToxicChemicals.Registration = Registration.Text;
                CompanyHighlyToxicChemicals.ValidStartDate = DateTime.Parse(ValidStartDate.Text);
                CompanyHighlyToxicChemicals.ValidEndDate = DateTime.Parse(ValidEndDate.Text);

                CompanyHighlyToxicChemicals.Company.CompanyAddress = CompanyAddress.Text.Trim();
                CompanyHighlyToxicChemicals.Company.CompanyName = CompanyName.Text.Trim();
                CompanyHighlyToxicChemicals.Company.CompanyPost = CompanyPost.Text.Trim();
                CompanyHighlyToxicChemicals.Company.JuridicalPerson = JuridicalPerson.Text.Trim();
                CompanyHighlyToxicChemicals.Company.JuridicalPersonAge = JuridicalPersonAge.Text.Trim();
                CompanyHighlyToxicChemicals.Company.JuridicalPersonJob = JuridicalPersonJob.Text.Trim();
                CompanyHighlyToxicChemicals.Company.JuridicalPersonSex = JuridicalPersonSex.Text.Trim();
                CompanyHighlyToxicChemicals.Company.Mobile = Mobile.Text.Trim();
                CompanyHighlyToxicChemicals.Company.Tel = Tel.Text.Trim();

                InvokeUtil.SystemService.EntityUpdate(CompanyHighlyToxicChemicals);
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


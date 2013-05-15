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
    public partial class frmCompanyDangerChemicalsProduce : BaseTableForm
    {
        public CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce;
        public frmCompanyDangerChemicalsProduce()
        {
            InitializeComponent();
        }
        public frmCompanyDangerChemicalsProduce(CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce)
            : this()
        {
            this.CompanyDangerChemicalsProduce = CompanyDangerChemicalsProduce;
        }
        private void frmCompanyDangerChemicalsProduce_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CompanyDangerChemicalsProduce != null)
                {

                    this.PermitRange.Text = CompanyDangerChemicalsProduce.PermitRange;
                    ValidStartDate.Text = CompanyDangerChemicalsProduce.ValidStartDate.ToString();
                    ValidEndDate.Text = CompanyDangerChemicalsProduce.ValidEndDate.ToString();

                    CompanyAddress.Text = CompanyDangerChemicalsProduce.Company.CompanyAddress;
                    CompanyName.Text = CompanyDangerChemicalsProduce.Company.CompanyName;
                    CompanyPost.Text = CompanyDangerChemicalsProduce.Company.CompanyPost;
                    JuridicalPerson.Text = CompanyDangerChemicalsProduce.Company.JuridicalPerson;
                    JuridicalPersonAge.Text = CompanyDangerChemicalsProduce.Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = CompanyDangerChemicalsProduce.Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = CompanyDangerChemicalsProduce.Company.JuridicalPersonSex;
                    Mobile.Text = CompanyDangerChemicalsProduce.Company.Mobile;
                    Tel.Text = CompanyDangerChemicalsProduce.Company.Tel;
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
                if (CompanyDangerChemicalsProduce == null)
                    CompanyDangerChemicalsProduce = new CompanyDangerChemicalsProduce();

                CompanyDangerChemicalsProduce.PermitRange = PermitRange.Text;
                CompanyDangerChemicalsProduce.ValidStartDate = DateTime.Parse(ValidStartDate.Text);
                CompanyDangerChemicalsProduce.ValidEndDate = DateTime.Parse(ValidEndDate.Text);

                CompanyDangerChemicalsProduce.Company.CompanyAddress = CompanyAddress.Text.Trim();
                CompanyDangerChemicalsProduce.Company.CompanyName = CompanyName.Text.Trim();
                CompanyDangerChemicalsProduce.Company.CompanyPost = CompanyPost.Text.Trim();
                CompanyDangerChemicalsProduce.Company.JuridicalPerson = JuridicalPerson.Text.Trim();
                CompanyDangerChemicalsProduce.Company.JuridicalPersonAge = JuridicalPersonAge.Text.Trim();
                CompanyDangerChemicalsProduce.Company.JuridicalPersonJob = JuridicalPersonJob.Text.Trim();
                CompanyDangerChemicalsProduce.Company.JuridicalPersonSex = JuridicalPersonSex.Text.Trim();
                CompanyDangerChemicalsProduce.Company.Mobile = Mobile.Text.Trim();
                CompanyDangerChemicalsProduce.Company.Tel = Tel.Text.Trim();

                InvokeUtil.SystemService.EntityUpdate(CompanyDangerChemicalsProduce);
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


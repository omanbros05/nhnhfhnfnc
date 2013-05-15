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
    public partial class frmCompanyFirework : BaseTableForm
    {
        public CompanyFireworks CompanyFirework;
        public frmCompanyFirework()
        {
            InitializeComponent();
        }
        public frmCompanyFirework(CompanyFireworks CompanyFirework)
            : this()
        {
            this.CompanyFirework = CompanyFirework;
        }
        private void CompanyFirework_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CompanyFirework != null)
                {

                    this.PermitCertificateNo.Text = CompanyFirework.PermitCertificateNo;
                    PermitBusinessScope.Text = CompanyFirework.PermitBusinessScope;
                    WarehousAddress.Text = CompanyFirework.WarehousAddress;
                    ValidStartDate.Text = CompanyFirework.ValidStartDate.ToString();
                    ValidEndDate.Text = CompanyFirework.ValidEndDate.ToString();

                    CompanyAddress.Text = CompanyFirework.Company.CompanyAddress;
                    CompanyName.Text = CompanyFirework.Company.CompanyName;
                    CompanyPost.Text = CompanyFirework.Company.CompanyPost;
                    JuridicalPerson.Text = CompanyFirework.Company.JuridicalPerson;
                    JuridicalPersonAge.Text = CompanyFirework.Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = CompanyFirework.Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = CompanyFirework.Company.JuridicalPersonSex;
                    Mobile.Text = CompanyFirework.Company.Mobile;
                    Tel.Text = CompanyFirework.Company.Tel;
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
                if (CompanyFirework == null)
                    CompanyFirework = new CompanyFireworks();

                //GetEntity(CompanyDangerChemicals);

                CompanyFirework.PermitBusinessScope = this.PermitBusinessScope.Text.Trim();
                CompanyFirework.PermitCertificateNo = PermitCertificateNo.Text.Trim();
                CompanyFirework.WarehousAddress = WarehousAddress.Text;
                CompanyFirework.ValidStartDate = DateTime.Parse(ValidStartDate.Text);
                CompanyFirework.ValidEndDate = DateTime.Parse(ValidEndDate.Text);

                CompanyFirework.Company.CompanyAddress = CompanyAddress.Text.Trim();
                CompanyFirework.Company.CompanyName = CompanyName.Text.Trim();
                CompanyFirework.Company.CompanyPost = CompanyPost.Text.Trim();
                CompanyFirework.Company.JuridicalPerson = JuridicalPerson.Text.Trim();
                CompanyFirework.Company.JuridicalPersonAge = JuridicalPersonAge.Text.Trim();
                CompanyFirework.Company.JuridicalPersonJob = JuridicalPersonJob.Text.Trim();
                CompanyFirework.Company.JuridicalPersonSex = JuridicalPersonSex.Text.Trim();
                CompanyFirework.Company.Mobile = Mobile.Text.Trim();
                CompanyFirework.Company.Tel = Tel.Text.Trim();

                InvokeUtil.SystemService.EntityUpdate(CompanyFirework);
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


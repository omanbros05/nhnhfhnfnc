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
                EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
                foreach (CompanyArea Area in Areas.Items)
                {
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
                }
                if (Areas.Items.Count > 0)
                {
                    this.comboBox1.Text = Areas.Items[0].AreaName;
                }

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

                    if (CompanyFirework.Company.IsCity == 0)
                    {
                        this.radioButton2.Checked = true;
                    }
                    try
                    {
                        CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyFirework.Company.CompanyAreaID });
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

                if (this.radioButton1.Checked)
                {
                    CompanyFirework.Company.IsCity = 1;
                }
                else
                {
                    CompanyFirework.Company.IsCity = 0;
                }
                CompanyFirework.Company.CompanyAreaID = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);

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


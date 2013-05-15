using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using SOA;
using SOA.ORM;
using Common;

namespace EnforceForm
{
    public partial class frmCompany : BaseTableForm
    {
        Company Company = null;
        public frmCompany()
        {
            InitializeComponent();
            List<CompanyType> Types = InvokeUtil.SystemService.CompanyTypeGetFastAll();
            this.comboBox1.Items.Clear();
            foreach (CompanyType item in Types)
            {
                this.comboBox1.Items.Add(new ComboBoxItemTextValue(item.ID.ToString(), item.CompanyTypeName));
            }
            if (Types.Count > 0)
            {
                this.comboBox1.Text = Types[0].CompanyTypeName;
            }


            EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
            this.comboBox3.Items.Clear();
            foreach (CompanyArea Area in Areas.Items)
            {
                this.comboBox3.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
            }
            if (Areas.Items.Count > 0)
            {
                this.comboBox3.Text = Areas.Items[0].AreaName;
            }

            this.comboBox2.Items.Add(new ComboBoxItemTextValue("1", "是"));
            this.comboBox2.Items.Add(new ComboBoxItemTextValue("0", "否"));
            this.comboBox2.Text = "是";
        }
        public frmCompany(Company Company)
            : this()
        {
            this.Company = Company;
        }
        private void frmCompany_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {

                if (Company != null)
                {
                    CompanyAddress.Text = Company.CompanyAddress;
                    CompanyName.Text = Company.CompanyName;
                    CompanyPost.Text = Company.CompanyPost;
                    JuridicalPerson.Text = Company.JuridicalPerson;
                    JuridicalPersonAge.Text = Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = Company.JuridicalPersonSex;
                    Mobile.Text = Company.Mobile;
                    Tel.Text = Company.Tel;
                    this.BusinessMode.Text = Company.BusinessMode;
                    this.PermitValid.Text = Company.PermitValid;
                    this.BusinessScope.Text = Company.PermitRange;
                    this.WarehousAddress.Text = Company.WarehousAddress;
                    this.txtIDCard.Text = Company.IDCard;

                    if (Company.IsCity == 0)
                    {
                        this.comboBox2.Text = "否";
                    }
                    else if (Company.IsCity == 1)
                    {
                        this.comboBox2.Text = "是";
                    }

                    try
                    {
                        CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = Company.CompanyAreaID });
                        this.comboBox3.Text = area.AreaName;
                    }
                    catch { }

                    try
                    {
                        CompanyType item = (CompanyType)InvokeUtil.SystemService.EntityInit(new CompanyType { ID = Company.CompanyType });
                        this.comboBox1.Text = item.CompanyTypeName;
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {

                if (Company == null)
                {
                    Company = new Company();
                }
                Company.CompanyAddress = CompanyAddress.Text;
                Company.CompanyName = CompanyName.Text;
                Company.CompanyPost = CompanyPost.Text;
                Company.JuridicalPerson = JuridicalPerson.Text;
                Company.JuridicalPersonAge = JuridicalPersonAge.Text;
                Company.JuridicalPersonJob = JuridicalPersonJob.Text;
                Company.JuridicalPersonSex = JuridicalPersonSex.Text;
                Company.Mobile = Mobile.Text;
                Company.Tel = Tel.Text;
                Company.BusinessMode = this.BusinessMode.Text;
                Company.PermitValid = this.PermitValid.Text;
                Company.PermitRange = this.BusinessScope.Text;
                Company.WarehousAddress = this.WarehousAddress.Text;
                Company.IsCity = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue);
                Company.CompanyAreaID = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox3.SelectedItem)).selectValue);
                Company.CompanyType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);

                string temp = "";
                if (txtIDCard.Text.Length == 18)
                {
                    temp = txtIDCard.Text.Substring(6,4);
                }
                else if (txtIDCard.Text.Length == 15)
                {
                    temp = "19" + txtIDCard.Text.Substring(6, 2);
                }
                else
                {
                    temp = (DateTime.Now.Year+1).ToString();
                }
                try
                {
                    int ageStart = Convert.ToInt32(temp);
                    Company.JuridicalPersonAge = (DateTime.Now.Year - ageStart + 1).ToString();
                }
                catch
                {
                    Company.JuridicalPersonAge = "0";
                }
                Company.IDCard = txtIDCard.Text.Trim();
                InvokeUtil.SystemService.EntityUpdate(Company);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCompanys"));
                //CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCompanys"));
        }


    }
}

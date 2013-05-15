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
    public partial class frmCompanys : BaseFormDetails
    {
        bool IsArea = true;
        int CompanyType = -1;
        public frmCompanys()
        {
            InitializeComponent();

            List<CompanyType> Types = InvokeUtil.SystemService.CompanyTypeGetFastAll();
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
            foreach (CompanyType item in Types)
            {
                this.comboBox1.Items.Add(new ComboBoxItemTextValue(item.ID.ToString(), item.CompanyTypeName));
            }
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("-2", "无"));
            this.comboBox1.Text = "全部";


            EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
            this.comboBox3.Items.Clear();
            this.comboBox3.Items.Add(new ComboBoxItemTextValue("-1", "所有"));
            foreach (CompanyArea Area in Areas.Items)
            {
                this.comboBox3.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
            }
            this.comboBox3.Text = "所有";

            //this.comboBox2.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
            //this.comboBox2.Items.Add(new ComboBoxItemTextValue("1", "是"));
            //this.comboBox2.Items.Add(new ComboBoxItemTextValue("0", "否"));
            //this.comboBox2.Text = "全部";
        }
        public frmCompanys(bool isArea,int companyType):this()
        {
            this.IsArea = isArea;
            this.CompanyType = companyType;
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmCompany frm = new frmCompany();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCompany"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            buttonQuery.Enabled = false;

            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            buttonQuery.Enabled = true;

            UseWaitCursor = false;
        }

        public override void Reload()
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += delegate {

                timer.Enabled = false;
                int AreaID = -1;
                if (!IsArea)
                {
                    AreaID = -1;
                    this.comboBox1.Text = "全部";
                    this.comboBox3.Enabled = false;
                }
                else
                { 
                    AreaID =  Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox3.SelectedItem)).selectValue);
                }
                if (CompanyType == -2)
                {
                    CompanyType = -2;
                    this.comboBox1.Text = "无";
                    this.comboBox1.Enabled = false;
                }
                else
                {
                    CompanyType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                }
                EList<Company> Companys = InvokeUtil.SystemService.CompanyNewGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text, CompanyType, AreaID, -1);
                pager.TotalCount = Companys.TotalCount;
                enforceLawGridViewCompany.Rows.Clear();
                foreach (Company Company in Companys.Items)
                {
                    int index = enforceLawGridViewCompany.Rows.Add();
                    DataGridViewRow dr = enforceLawGridViewCompany.Rows[index];
                    dr.Cells[0].Value = Company.CompanyID.ToString();
                    //dr.Cells[1].Value = Company.CompanyType;
                    dr.Cells[2].Value = Company.CompanyName;
                    dr.Cells[3].Value = Company.CompanyAddress;
                    try
                    {
                        CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = Company.CompanyAreaID });
                        dr.Cells[4].Value = area.AreaName;
                    }
                    catch
                    {
                        dr.Cells[4].Value = "--";
                        dr.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    try
                    {
                        CompanyType item = (CompanyType)InvokeUtil.SystemService.EntityInit(new CompanyType { ID = Company.CompanyType });
                        dr.Cells[1].Value = item.CompanyTypeName;
                    }
                    catch
                    {
                        dr.Cells[1].Value = "--";
                        dr.Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    
                    //dr.Cells[4].Value = Company.CompanyAddress;
                    string str = string.Empty;
                    str = Company.CompanyPost;
                    if (str.Trim().Equals(string.Empty))
                    {
                        dr.Cells[5].Value = "--";
                        dr.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else {
                        dr.Cells[5].Value = str;
                    }

                    str = Company.JuridicalPerson;
                    if (str.Trim().Equals(string.Empty))
                    {
                        dr.Cells[6].Value = "--";
                        dr.Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else dr.Cells[6].Value = str;

                    str = Company.IDCard;
                    if (str.Trim().Equals(string.Empty)) {
                        dr.Cells[7].Value = "--";
                        dr.Cells[7].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else dr.Cells[7].Value = str;
                    
                    //dr.Cells[8].Value = Company.JuridicalPersonAge;
                    if (Company.Mobile != "" && Company.Tel != "")
                    {
                        dr.Cells[8].Value = Company.Mobile + " / " + Company.Tel;
                    }
                    else if (Company.Mobile != "")
                    {
                        dr.Cells[8].Value = Company.Mobile;
                    }
                    else if (!Company.Tel.Equals(string.Empty))
                    {
                        dr.Cells[8].Value = Company.Tel;
                    }
                    else { 
                        dr.Cells[8].Value = "--";
                        dr.Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dr.Tag = Company;
                }
            };

            
        }

        private void frmCompanys_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void pager_CurrentPageChangedEvent(object sender, Pager.CurrentPageChangedEventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompany.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompany.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompany.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        Company Company = row.Tag as Company;
                        InvokeUtil.SystemService.EntityRemove(Company);
                        enforceLawGridViewCompany.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompany.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompany.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Company Company = enforceLawGridViewCompany.SelectedRows[0].Tag as Company;

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCompany", new object[]{ Company }));
                //frmCompany frm = new frmCompany(Company);
                //frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                frmCompanyImport frm = new frmCompanyImport();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.Enterprise"));
        }
    }
}

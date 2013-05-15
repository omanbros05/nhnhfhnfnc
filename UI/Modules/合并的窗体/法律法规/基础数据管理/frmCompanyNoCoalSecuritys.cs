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
    public partial class frmCompanyNoCoalSecuritys : BaseFormDetails
    {
        public frmCompanyNoCoalSecuritys()
        {
            InitializeComponent();
        }
        private void frmCompanyNoCoalSecuritys_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InitData();
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

            try
            {
                InitData();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                frmCompanyNoCoalSecurity frm = new frmCompanyNoCoalSecurity();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyNoCoalSecurity CompanyNoCoalSecurity = enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows[0].Tag as CompanyNoCoalSecurity;
                CompanyNoCoalSecurity.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyNoCoalSecurity.CompanyID });
                frmCompanyNoCoalSecurity frm = new frmCompanyNoCoalSecurity(CompanyNoCoalSecurity);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyNoCoalSecurity CompanyNoCoalSecurity = row.Tag as CompanyNoCoalSecurity;
                        CompanyNoCoalSecurity.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyNoCoalSecurity.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyNoCoalSecurity);
                        enforceLawGridViewCompanyNoCoalSecuritys.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void InitData()
        {
            EList<CompanyNoCoalSecurity> CompanyNoCoalSecurity = InvokeUtil.SystemService.CompanyNoCoalSecurityGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text);
            pager.TotalCount = CompanyNoCoalSecurity.TotalCount;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Rows.Clear();
            for (int i = 0; i < CompanyNoCoalSecurity.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyNoCoalSecuritys.Rows.Add();
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["CompanyName"].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["CompanyAddress"].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["CompanyPost"].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["JuridicalPerson"].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["JuridicalPersonSex"].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["JuridicalPersonAge"].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["JuridicalPersonJob"].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonJob;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["Mobile"].Value = CompanyNoCoalSecurity.Items[i].Company.Mobile;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells["Tel"].Value = CompanyNoCoalSecurity.Items[i].Company.Tel;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Tag = CompanyNoCoalSecurity.Items[i];
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                string theFile;
                openFileDialog1.InitialDirectory = Application.ExecutablePath;
                openFileDialog1.Filter = "excel Files(*.xls)|*.xls|All Files(*.*)|*.*";//xlsx
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    theFile = openFileDialog1.FileName;
                    DataTable dt = ExcelToTable(theFile);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        CompanyNoCoalSecurity CompanyNoCoalSecurity = new CompanyNoCoalSecurity();
                        CompanyNoCoalSecurity.CertificateNumber = dt.Rows[j][9].ToString();
                        CompanyNoCoalSecurity.EconomicType = dt.Rows[j][10].ToString();
                        CompanyNoCoalSecurity.MiningMethods = dt.Rows[j][12].ToString();
                        CompanyNoCoalSecurity.PermitRange = dt.Rows[j][13].ToString();
                        CompanyNoCoalSecurity.StandardizationRegister = dt.Rows[j][11].ToString();
                        try
                        {
                            CompanyNoCoalSecurity.ValidStartDate = DateTime.Parse(dt.Rows[j][14].ToString());
                        }
                        catch { }

                        try
                        {
                            CompanyNoCoalSecurity.ValidEndDate = DateTime.Parse(dt.Rows[j][15].ToString());
                        }
                        catch { }

                        CompanyNoCoalSecurity.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyNoCoalSecurity.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyNoCoalSecurity.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyNoCoalSecurity.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyNoCoalSecurity.Company.Tel = dt.Rows[j][5].ToString();

                        EList<CompanyNoCoalSecurity> CompanyList = InvokeUtil.SystemService.CompanyNoCoalSecurityGetAll(1, 20, CompanyNoCoalSecurity.Company.CompanyName);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyNoCoalSecurity);
                        }
                    }
                    Reload();
                    CommonInvoke.MessageBox("操作成功！");
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}


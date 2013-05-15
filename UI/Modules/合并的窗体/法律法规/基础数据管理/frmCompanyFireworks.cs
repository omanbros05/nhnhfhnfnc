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
    public partial class frmCompanyFireworks : BaseFormDetails
    {
        public frmCompanyFireworks()
        {
            InitializeComponent();
        }

        private void frmCompanyFireworks_Load(object sender, EventArgs e)
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
                frmCompanyFirework frm = new frmCompanyFirework();
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
            if (enforceLawGridViewCompanyFireworks.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyFireworks.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyFireworks CompanyFireworks = enforceLawGridViewCompanyFireworks.SelectedRows[0].Tag as CompanyFireworks;
                CompanyFireworks.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyFireworks.CompanyID });
                frmCompanyFirework frm = new frmCompanyFirework(CompanyFireworks);
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
            if (enforceLawGridViewCompanyFireworks.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyFireworks.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyFireworks.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyFireworks CompanyFireworks = row.Tag as CompanyFireworks;
                        CompanyFireworks.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyFireworks.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyFireworks);
                        enforceLawGridViewCompanyFireworks.Rows.Remove(row);
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
            EList<CompanyFireworks> CompanyFireworks = InvokeUtil.SystemService.CompanyFireworksGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text);
            pager.TotalCount = CompanyFireworks.TotalCount;
            this.enforceLawGridViewCompanyFireworks.Rows.Clear();
            for (int i = 0; i < CompanyFireworks.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyFireworks.Rows.Add();
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["CompanyName"].Value = CompanyFireworks.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["CompanyAddress"].Value = CompanyFireworks.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["CompanyPost"].Value = CompanyFireworks.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["JuridicalPerson"].Value = CompanyFireworks.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["JuridicalPersonSex"].Value = CompanyFireworks.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["JuridicalPersonAge"].Value = CompanyFireworks.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["JuridicalPersonJob"].Value = CompanyFireworks.Items[i].Company.JuridicalPersonJob;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["Mobile"].Value = CompanyFireworks.Items[i].Company.Mobile;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells["Tel"].Value = CompanyFireworks.Items[i].Company.Tel;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Tag = CompanyFireworks.Items[i];
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
                        CompanyFireworks CompanyFireworks = new CompanyFireworks();
                        CompanyFireworks.PermitBusinessScope = dt.Rows[j][11].ToString();
                        CompanyFireworks.PermitCertificateNo = dt.Rows[j][9].ToString();
                        CompanyFireworks.WarehousAddress = dt.Rows[j][10].ToString();
                        try
                        {
                            CompanyFireworks.ValidStartDate = DateTime.Parse(dt.Rows[j][12].ToString());
                        }
                        catch { }

                        try
                        {
                            CompanyFireworks.ValidEndDate = DateTime.Parse(dt.Rows[j][13].ToString());
                        }
                        catch { }

                        CompanyFireworks.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyFireworks.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyFireworks.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyFireworks.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyFireworks.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyFireworks.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyFireworks.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyFireworks.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyFireworks.Company.Tel = dt.Rows[j][5].ToString();

                        EList<CompanyFireworks> CompanyList = InvokeUtil.SystemService.CompanyFireworksGetAll(1, 20, CompanyFireworks.Company.CompanyName);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyFireworks);
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

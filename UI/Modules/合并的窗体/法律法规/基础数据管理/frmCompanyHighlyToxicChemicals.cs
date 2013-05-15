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
    public partial class frmCompanyHighlyToxicChemicals : BaseFormDetails
    {
        public frmCompanyHighlyToxicChemicals()
        {
            InitializeComponent();
        }
        private void frmCompanyHighlyToxicChemicals_Load(object sender, EventArgs e)
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
                frmCompanyHighlyToxicChemical frm = new frmCompanyHighlyToxicChemical();
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
            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows[0].Tag as CompanyHighlyToxicChemicals;
                CompanyHighlyToxicChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyHighlyToxicChemicals.CompanyID });
                frmCompanyHighlyToxicChemical frm = new frmCompanyHighlyToxicChemical(CompanyHighlyToxicChemicals);
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
            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = row.Tag as CompanyHighlyToxicChemicals;
                        CompanyHighlyToxicChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyHighlyToxicChemicals.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyHighlyToxicChemicals);
                        enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Remove(row);
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
            EList<CompanyHighlyToxicChemicals> CompanyHighlyToxicChemicals = InvokeUtil.SystemService.CompanyHighlyToxicChemicalsGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text);
            pager.TotalCount = CompanyHighlyToxicChemicals.TotalCount;
            this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Clear();
            for (int i = 0; i < CompanyHighlyToxicChemicals.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Add();
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["CompanyName"].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["CompanyAddress"].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["CompanyPost"].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["JuridicalPerson"].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["JuridicalPersonSex"].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["JuridicalPersonAge"].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["JuridicalPersonJob"].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonJob;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["Mobile"].Value = CompanyHighlyToxicChemicals.Items[i].Company.Mobile;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells["Tel"].Value = CompanyHighlyToxicChemicals.Items[i].Company.Tel;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Tag = CompanyHighlyToxicChemicals.Items[i];
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
                        CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = new CompanyHighlyToxicChemicals();
                        CompanyHighlyToxicChemicals.MainProducts = dt.Rows[j][9].ToString();
                        CompanyHighlyToxicChemicals.Registration = dt.Rows[j][10].ToString();
                        try
                        {
                            CompanyHighlyToxicChemicals.ValidStartDate = DateTime.Parse(dt.Rows[j][11].ToString());
                        }
                        catch { }

                        try
                        {
                            CompanyHighlyToxicChemicals.ValidEndDate = DateTime.Parse(dt.Rows[j][12].ToString());
                        }
                        catch { }

                        CompanyHighlyToxicChemicals.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyHighlyToxicChemicals.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyHighlyToxicChemicals.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyHighlyToxicChemicals.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyHighlyToxicChemicals.Company.Tel = dt.Rows[j][5].ToString();

                        EList<CompanyHighlyToxicChemicals> CompanyList = InvokeUtil.SystemService.CompanyHighlyToxicChemicalsGetAll(1, 20, CompanyHighlyToxicChemicals.Company.CompanyName);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyHighlyToxicChemicals);
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


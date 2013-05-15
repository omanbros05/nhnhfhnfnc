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
    public partial class frmCompanyDangerChemicals : BaseFormDetails
    {
        public frmCompanyDangerChemicals()
        {
            InitializeComponent();
        }
        private void frmCompanyDangerChemicals_Load(object sender, EventArgs e)
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

        private void buttonQuery_Click(object sender, EventArgs e)
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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                frmCompanyDangerChemical frm = new frmCompanyDangerChemical();
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
            if (enforceLawGridViewCompanyDangerChemicals.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyDangerChemicals.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyDangerChemicals CompanyDangerChemicals = enforceLawGridViewCompanyDangerChemicals.SelectedRows[0].Tag as CompanyDangerChemicals;
                CompanyDangerChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicals.CompanyID });
                frmCompanyDangerChemical frm = new frmCompanyDangerChemical(CompanyDangerChemicals);
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
            if (enforceLawGridViewCompanyDangerChemicals.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyDangerChemicals.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyDangerChemicals.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyDangerChemicals CompanyDangerChemicals = row.Tag as CompanyDangerChemicals;
                        CompanyDangerChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicals.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyDangerChemicals);
                        enforceLawGridViewCompanyDangerChemicals.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        public override void Reload()
        {
            EList<CompanyDangerChemicals> CompanyDangerChemicals = InvokeUtil.SystemService.CompanyDangerChemicalsGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text);
            pager.TotalCount = CompanyDangerChemicals.TotalCount;
            this.enforceLawGridViewCompanyDangerChemicals.Rows.Clear();
            for (int i = 0; i < CompanyDangerChemicals.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyDangerChemicals.Rows.Add();
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["CompanyName"].Value = CompanyDangerChemicals.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["CompanyAddress"].Value = CompanyDangerChemicals.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["CompanyPost"].Value = CompanyDangerChemicals.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["JuridicalPerson"].Value = CompanyDangerChemicals.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["JuridicalPersonSex"].Value = CompanyDangerChemicals.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["JuridicalPersonAge"].Value = CompanyDangerChemicals.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["JuridicalPersonJob"].Value = CompanyDangerChemicals.Items[i].Company.JuridicalPersonJob;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["Mobile"].Value = CompanyDangerChemicals.Items[i].Company.Mobile;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Cells["Tel"].Value = CompanyDangerChemicals.Items[i].Company.Tel;
                this.enforceLawGridViewCompanyDangerChemicals.Rows[index].Tag = CompanyDangerChemicals.Items[i];
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
                        CompanyDangerChemicals CompanyDangerChemicals = new CompanyDangerChemicals();
                        CompanyDangerChemicals.BusinessMode = dt.Rows[j][11].ToString();
                        CompanyDangerChemicals.BusinessScope = dt.Rows[j][13].ToString();
                        CompanyDangerChemicals.Certificate = dt.Rows[j][9].ToString();
                        CompanyDangerChemicals.EconomicTypes = dt.Rows[j][10].ToString();
                        CompanyDangerChemicals.WarehousAddress = dt.Rows[j][12].ToString();
                        try
                        {
                            CompanyDangerChemicals.ValidStartDate = DateTime.Parse(dt.Rows[j][14].ToString());
                        }catch { }
                        try
                        {
                            CompanyDangerChemicals.ValidEndDate = DateTime.Parse(dt.Rows[j][15].ToString());
                        }
                        catch { }

                        CompanyDangerChemicals.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyDangerChemicals.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyDangerChemicals.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyDangerChemicals.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyDangerChemicals.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyDangerChemicals.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyDangerChemicals.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyDangerChemicals.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyDangerChemicals.Company.Tel = dt.Rows[j][5].ToString();

                        EList<CompanyDangerChemicals> CompanyDangerChemicalsList = InvokeUtil.SystemService.CompanyDangerChemicalsGetAll(1, 20, CompanyDangerChemicals.Company.CompanyName);
                        if (CompanyDangerChemicalsList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyDangerChemicals);
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

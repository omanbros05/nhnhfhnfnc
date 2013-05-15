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
    public partial class frmCompanyDangerChemicalsProduces : BaseFormDetails
    {
        public frmCompanyDangerChemicalsProduces()
        {
            InitializeComponent();
        }
        private void frmCompanyDangerChemicalsProduces_Load(object sender, EventArgs e)
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
                frmCompanyDangerChemicalsProduce frm = new frmCompanyDangerChemicalsProduce();
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
            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows[0].Tag as CompanyDangerChemicalsProduce;
                CompanyDangerChemicalsProduce.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicalsProduce.CompanyID });
                frmCompanyDangerChemicalsProduce frm = new frmCompanyDangerChemicalsProduce(CompanyDangerChemicalsProduce);
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
            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = row.Tag as CompanyDangerChemicalsProduce;
                        CompanyDangerChemicalsProduce.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicalsProduce.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyDangerChemicalsProduce);
                        enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Remove(row);
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
            EList<CompanyDangerChemicalsProduce> CompanyDangerChemicalsProduce = InvokeUtil.SystemService.CompanyDangerChemicalsProduceGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text);
            pager.TotalCount = CompanyDangerChemicalsProduce.TotalCount;
            this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Clear();
            for (int i = 0; i < CompanyDangerChemicalsProduce.Items.Count; i++)
            {
                int index = this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Add();
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["CompanyName"].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyName;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["CompanyAddress"].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["CompanyPost"].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyPost;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["JuridicalPerson"].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["JuridicalPersonSex"].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["JuridicalPersonAge"].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["JuridicalPersonJob"].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonJob;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["Mobile"].Value = CompanyDangerChemicalsProduce.Items[i].Company.Mobile;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells["Tel"].Value = CompanyDangerChemicalsProduce.Items[i].Company.Tel;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Tag = CompanyDangerChemicalsProduce.Items[i];
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
                        CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = new CompanyDangerChemicalsProduce();
                        CompanyDangerChemicalsProduce.PermitRange = dt.Rows[j][9].ToString();
                        try
                        {
                            CompanyDangerChemicalsProduce.ValidStartDate = DateTime.Parse(dt.Rows[j][10].ToString());
                        }
                        catch { }

                        try
                        {
                            CompanyDangerChemicalsProduce.ValidEndDate = DateTime.Parse(dt.Rows[j][11].ToString());
                        }
                        catch { }

                        CompanyDangerChemicalsProduce.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyDangerChemicalsProduce.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyDangerChemicalsProduce.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyDangerChemicalsProduce.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyDangerChemicalsProduce.Company.Tel = dt.Rows[j][5].ToString();

                        EList<CompanyDangerChemicalsProduce> CompanyList = InvokeUtil.SystemService.CompanyDangerChemicalsProduceGetAll(1, 20, CompanyDangerChemicalsProduce.Company.CompanyName);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyDangerChemicalsProduce);
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

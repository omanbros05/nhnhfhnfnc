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
    public partial class frmAdministrativePenaltyCompanys : BaseFormDetails
    {
        public frmAdministrativePenaltyCompanys()
        {
            InitializeComponent();
        }

        private void frmAdministrativePenaltyCompanys_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //Reload();
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
                frmAdministrativePenaltyCompany frm = new frmAdministrativePenaltyCompany();
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
            if (enforceLawGridViewAdministrativePenaltyCompany.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewAdministrativePenaltyCompany.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                AdministrativePenaltyCompany administrativePenaltyCompany = enforceLawGridViewAdministrativePenaltyCompany.SelectedRows[0].Tag as AdministrativePenaltyCompany;
                frmAdministrativePenaltyCompany frm = new frmAdministrativePenaltyCompany(administrativePenaltyCompany);
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
            if (enforceLawGridViewAdministrativePenaltyCompany.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewAdministrativePenaltyCompany.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewAdministrativePenaltyCompany.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        AdministrativePenaltyCompany administrativePenaltyCompany = row.Tag as AdministrativePenaltyCompany;
                        InvokeUtil.SystemService.EntityRemove(administrativePenaltyCompany);
                        enforceLawGridViewAdministrativePenaltyCompany.Rows.Remove(row);
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
            EList<AdministrativePenaltyCompany> AdministrativePenaltyCompanys = InvokeUtil.SystemService.AdministrativePenaltyCompanyGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = AdministrativePenaltyCompanys.TotalCount;
            enforceLawGridViewAdministrativePenaltyCompany.Bind<AdministrativePenaltyCompany>(AdministrativePenaltyCompanys.Items);
        }
    }
}

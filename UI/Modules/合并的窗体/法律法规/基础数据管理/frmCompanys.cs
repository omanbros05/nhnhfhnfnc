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
        public frmCompanys()
        {
            InitializeComponent();
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
            EList<Company> Companys = InvokeUtil.SystemService.CompanyGetAll(pager.CurrentPage, pager.PageSize,tableTextBoxCompanyName.Text);
            pager.TotalCount = Companys.TotalCount;
            enforceLawGridViewCompany.Bind<Company>(Companys.Items);
        }

        private void frmCompanys_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                enforceLawGridViewCompany.InitColumnType<Company>();
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

            toolStripButtonDel.Enabled = false;
            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompany.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompany.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        Company company = row.Tag as Company;
                        InvokeUtil.SystemService.EntityRemove(company);
                        enforceLawGridViewCompany.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
            toolStripButtonDel.Enabled = true;

            UseWaitCursor = false;
        }
    }
}

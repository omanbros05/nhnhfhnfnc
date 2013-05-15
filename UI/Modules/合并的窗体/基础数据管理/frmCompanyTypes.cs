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
    public partial class frmCompanyTypes : BaseFormDetails
    {
        public frmCompanyTypes()
        {
            InitializeComponent();
        }
        private void frmCompanyTypes_Load(object sender, EventArgs e)
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
        public override void Reload()
        {
            List<CompanyType> CompanyTypes = InvokeUtil.SystemService.CompanyTypeGetFastAll();
            pager.TotalCount = CompanyTypes.Count;
            enforceLawGridViewCompanyType.Bind<CompanyType>(CompanyTypes);
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmEditCompanyType frm = new frmEditCompanyType();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditCompanyType"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompanyType.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyType.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyType CompanyType = enforceLawGridViewCompanyType.SelectedRows[0].Tag as CompanyType;
                //frmEditCompanyType frm = new frmEditCompanyType(CompanyType);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditCompanyType", new object[] { CompanyType }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCompanyType.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyType.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyType.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyType CompanyType = row.Tag as CompanyType;
                        InvokeUtil.SystemService.EntityRemove(CompanyType);
                        enforceLawGridViewCompanyType.Rows.Remove(row);
                    }
                }
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

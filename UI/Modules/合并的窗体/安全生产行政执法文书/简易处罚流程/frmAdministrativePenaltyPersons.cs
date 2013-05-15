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
    public partial class frmAdministrativePenaltyPersons : BaseFormDetails
    {
        public frmAdministrativePenaltyPersons()
        {
            InitializeComponent();
        }

        private void frmAdministrativePenaltyPersons_Load(object sender, EventArgs e)
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
                frmAdministrativePenaltyPerson frm = new frmAdministrativePenaltyPerson();
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
            if (enforceLawGridViewAdministrativePenaltyPerson.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewAdministrativePenaltyPerson.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                AdministrativePenaltyPerson administrativePenaltyPerson = enforceLawGridViewAdministrativePenaltyPerson.SelectedRows[0].Tag as AdministrativePenaltyPerson;
                frmAdministrativePenaltyPerson frm = new frmAdministrativePenaltyPerson(administrativePenaltyPerson);
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
            if (enforceLawGridViewAdministrativePenaltyPerson.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewAdministrativePenaltyPerson.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewAdministrativePenaltyPerson.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        AdministrativePenaltyPerson administrativePenaltyPerson = row.Tag as AdministrativePenaltyPerson;
                        InvokeUtil.SystemService.EntityRemove(administrativePenaltyPerson);
                        enforceLawGridViewAdministrativePenaltyPerson.Rows.Remove(row);
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
            EList<AdministrativePenaltyPerson> AdministrativePenaltyPersons = InvokeUtil.SystemService.AdministrativePenaltyPersonGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = AdministrativePenaltyPersons.TotalCount;
            enforceLawGridViewAdministrativePenaltyPerson.Bind<AdministrativePenaltyPerson>(AdministrativePenaltyPersons.Items);
        }
    }
}

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
    public partial class frmSpotPunishmentDecisionPersonals : BaseFormDetails
    {
        public frmSpotPunishmentDecisionPersonals()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }

        public override void Reload()
        {
            EList<SpotPunishmentDecisionPersonal> SpotPunishmentDecisionPersonals = InvokeUtil.SystemService.SpotPunishmentDecisionPersonalGetAll(pager.CurrentPage, pager.PageSize, TxtDocTitle.Text,TxtFieldEPeopleName.Text);
            pager.TotalCount = SpotPunishmentDecisionPersonals.TotalCount;
            enforceLawGridViewSpotCheck.Bind<SpotPunishmentDecisionPersonal>(SpotPunishmentDecisionPersonals.Items);
        }

        private void frmSpotPunishmentDecisionPersonals_Load(object sender, EventArgs e)
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionPersonal"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotCheck.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSpotCheck.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal = enforceLawGridViewSpotCheck.SelectedRows[0].Tag as SpotPunishmentDecisionPersonal;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotPunishmentDecisionPersonal", new object[] { spotPunishmentDecisionPersonal }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotCheck.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSpotCheck.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSpotCheck.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal = row.Tag as SpotPunishmentDecisionPersonal;
                        InvokeUtil.SystemService.EntityRemove(spotPunishmentDecisionPersonal);
                        enforceLawGridViewSpotCheck.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSpotCheck.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal = rows[0].Tag as SpotPunishmentDecisionPersonal;

            if (spotPunishmentDecisionPersonal.Status == 0)
            {
                CommonInvoke.MessageBox("在导出文书之前无法进行归档。\r\r--选择一条记录\r--点击编辑->导出\r--选择一条记录点击归档", MessageBoxButtons.OK);
                return;
            }

            UseWaitCursor = true;
            Application.DoEvents();


            using (var form = new Maleos.Controls.ArchiveTypeSelector())
            {

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + spotPunishmentDecisionPersonal.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(spotPunishmentDecisionPersonal.ID, DataBases.SpotPunishmentDecisionPersonal.___GetTableName(), spotPunishmentDecisionPersonal.FilePath, "行政当场处罚决定书个人", value,
                            DataBases.SpotPunishmentDecisionPersonal, DataBases.SpotPunishmentDecisionPersonal.Status, DataBases.SpotPunishmentDecisionPersonal.ID);
                        enforceLawGridViewSpotCheck.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;

        }
    }
}

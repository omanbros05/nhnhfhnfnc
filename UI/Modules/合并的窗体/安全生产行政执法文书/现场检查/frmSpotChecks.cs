﻿using System;
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
using Maleos.Modules;

namespace EnforceForm
{
    public partial class frmSpotChecks : BaseFormDetails
    {
        public frmSpotChecks()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);

            tableDateTimePickerBeginCheckDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void DoBack(object sender, EventArgs e) {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmSpotCheck frm = new frmSpotCheck();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotCheck"));
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
                SpotCheck spotCheck = enforceLawGridViewSpotCheck.SelectedRows[0].Tag as SpotCheck;
                //frmSpotCheck frm = new frmSpotCheck(spotCheck);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotCheck", new object[] { spotCheck }));
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

                        SpotCheck spotCheck = row.Tag as SpotCheck;
                        InvokeUtil.SystemService.EntityRemove(spotCheck);
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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSpotCheck.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            SpotCheck spotCheck = rows[0].Tag as SpotCheck;

            if (spotCheck.Status == 0) {
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
                        if (CommonInvoke.MessageBox("是否归档名称为\r\r" + spotCheck.CompanyName + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == System.Windows.Forms.DialogResult.Yes)
                        {
                            int value = form.SelectedValue;
                            Utility.UpdateStatus(spotCheck.ID, DataBases.SpotCheck.___GetTableName(), spotCheck.FilePath,"现场检查记录", value,
                                DataBases.SpotCheck, DataBases.SpotCheck.Status, DataBases.SpotCheck.ID);
                            enforceLawGridViewSpotCheck.Rows.Remove(rows[0]);
                        }
                    }
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

        private void frmSpotChecks_Load(object sender, EventArgs e)
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

        public override void Reload()
        {
            EList<SpotCheck> SpotChecks = InvokeUtil.SystemService.SpotCheckGetAll(pager.CurrentPage, pager.PageSize, tableDateTimePickerBeginCheckDate.Value, tableDateTimePickerEndCheckDate.Value);
            pager.TotalCount = SpotChecks.TotalCount;
            enforceLawGridViewSpotCheck.Bind<SpotCheck>(SpotChecks.Items);
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

        
    }
}

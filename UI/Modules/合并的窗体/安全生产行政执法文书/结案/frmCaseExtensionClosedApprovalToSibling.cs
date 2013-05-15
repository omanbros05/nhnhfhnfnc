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


namespace EnforceForm
{
    public partial class frmCaseExtensionClosedApprovalToSibling : BaseFormDetails
    {
        public frmCaseExtensionClosedApprovalToSibling()
        {
            InitializeComponent();
            //当前时间
            DateTime dt = DateTime.Now;
            //本月第一天时间    
            DateTime dt_First = dt.AddDays(1 - (dt.Day));
            //获得某年某月的天数  
            int year = dt.Date.Year;
            int month = dt.Date.Month;
            int dayCount = DateTime.DaysInMonth(year, month);
            //本月最后一天时间  
            DateTime dt_Last = dt_First.AddDays(dayCount - 1);
            this.tableDateTimePickerBeginCheckDate.Value = dt_First;
            this.tableDateTimePickerEndCheckDate.Value = dt_Last;
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }

        private void frmCaseExtensionClosedApprovalToSibling_Load(object sender, EventArgs e)
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

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmEditCaseExtensionClosedApprovalToSibling frm = new frmEditCaseExtensionClosedApprovalToSibling();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditCaseExtensionClosedApprovalToSibling"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCaseExtensionClosedApproval.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCaseExtensionClosedApproval.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CaseExtensionClosedApprovalToSibling CaseExtensionClosedApprovalToSibling = enforceLawGridViewCaseExtensionClosedApproval.SelectedRows[0].Tag as CaseExtensionClosedApprovalToSibling;
                //frmEditCaseExtensionClosedApprovalToSibling frm = new frmEditCaseExtensionClosedApprovalToSibling(CaseExtensionClosedApprovalToSibling);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditCaseExtensionClosedApprovalToSibling", new object[] { CaseExtensionClosedApprovalToSibling }));

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewCaseExtensionClosedApproval.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCaseExtensionClosedApproval.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCaseExtensionClosedApproval.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CaseExtensionClosedApprovalToSibling CaseExtensionClosedApprovalToSibling = row.Tag as CaseExtensionClosedApprovalToSibling;
                        InvokeUtil.SystemService.EntityRemove(CaseExtensionClosedApprovalToSibling);
                        enforceLawGridViewCaseExtensionClosedApproval.Rows.Remove(row);
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
            EList<CaseExtensionClosedApprovalToSibling> CaseExtensionClosedApprovalToSibling = InvokeUtil.SystemService.CaseExtensionClosedApprovalToSiblingByDate(pager.CurrentPage, pager.PageSize, tableDateTimePickerBeginCheckDate.Value, tableDateTimePickerEndCheckDate.Value);
            pager.TotalCount = CaseExtensionClosedApprovalToSibling.TotalCount;
            enforceLawGridViewCaseExtensionClosedApproval.Bind<CaseExtensionClosedApprovalToSibling>(CaseExtensionClosedApprovalToSibling.Items);
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection rows = enforceLawGridViewCaseExtensionClosedApproval.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            CaseExtensionClosedApprovalToSibling caseExtensionClosedApprovalToSibling = rows[0].Tag as CaseExtensionClosedApprovalToSibling;

            if (caseExtensionClosedApprovalToSibling.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + caseExtensionClosedApprovalToSibling.CaseName + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(caseExtensionClosedApprovalToSibling.ID, DataBases.CaseExtensionClosedApprovalToSibling.___GetTableName(), caseExtensionClosedApprovalToSibling.FilePath, "案件延期办结审批表（本级）", value,
                            DataBases.CaseExtensionClosedApprovalToSibling, DataBases.CaseExtensionClosedApprovalToSibling.Status, DataBases.CaseExtensionClosedApprovalToSibling.ID);
                        enforceLawGridViewCaseExtensionClosedApproval.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}


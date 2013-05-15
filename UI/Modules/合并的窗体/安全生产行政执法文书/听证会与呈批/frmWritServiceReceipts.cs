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
    public partial class frmWritServiceReceipts : BaseFormDetails
    {
        public frmWritServiceReceipts()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }


        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }


        private void frmWritServiceReceipts_Load(object sender, EventArgs e)
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmWritServiceReceipt"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewWritServiceReceipt.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewWritServiceReceipt.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                WritServiceReceipt writServiceReceipt = enforceLawGridViewWritServiceReceipt.SelectedRows[0].Tag as WritServiceReceipt;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmWritServiceReceipt", new object[] { writServiceReceipt }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewWritServiceReceipt.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewWritServiceReceipt.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewWritServiceReceipt.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        WritServiceReceipt writServiceReceipt = row.Tag as WritServiceReceipt;
                        InvokeUtil.SystemService.EntityRemove(writServiceReceipt);
                        enforceLawGridViewWritServiceReceipt.Rows.Remove(row);
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
            EList<WritServiceReceipt> WritServiceReceipts = InvokeUtil.SystemService.WritServiceReceiptGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = WritServiceReceipts.TotalCount;
            enforceLawGridViewWritServiceReceipt.Bind<WritServiceReceipt>(WritServiceReceipts.Items);
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewWritServiceReceipt.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            WritServiceReceipt writServiceReceipt = rows[0].Tag as WritServiceReceipt;

            if (writServiceReceipt.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + writServiceReceipt.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(writServiceReceipt.ID, DataBases.WritServiceReceipt.___GetTableName(), writServiceReceipt.FilePath, "文书送达回执", value,
                            DataBases.WritServiceReceipt, DataBases.WritServiceReceipt.Status, DataBases.WritServiceReceipt.ID);
                        enforceLawGridViewWritServiceReceipt.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

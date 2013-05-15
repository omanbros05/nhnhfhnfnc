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
    public partial class frmHearingNotices : BaseFormDetails
    {
        public frmHearingNotices()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }

        private void frmHearingNotices_Load(object sender, EventArgs e)
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingNotice"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewHearingNotice.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewHearingNotice.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                HearingNotice hearingNotice = enforceLawGridViewHearingNotice.SelectedRows[0].Tag as HearingNotice;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmHearingNotice", new object[] { hearingNotice }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonPutDown_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewHearingNotice.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewHearingNotice.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                HearingNotice hearingNotice = enforceLawGridViewHearingNotice.SelectedRows[0].Tag as HearingNotice;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutDown", new object[] { hearingNotice }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewHearingNotice.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewHearingNotice.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewHearingNotice.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        HearingNotice hearingNotice = row.Tag as HearingNotice;
                        InvokeUtil.SystemService.EntityRemove(hearingNotice);
                        enforceLawGridViewHearingNotice.Rows.Remove(row);
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
            EList<HearingNotice> HearingNotices = InvokeUtil.SystemService.HearingNoticeGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = HearingNotices.TotalCount;
            enforceLawGridViewHearingNotice.Bind<HearingNotice>(HearingNotices.Items);
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewHearingNotice.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            HearingNotice hearingNotice = rows[0].Tag as HearingNotice;

            if (hearingNotice.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + hearingNotice.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(hearingNotice.ID, DataBases.HearingNotice.___GetTableName(), hearingNotice.FilePath, "听证会通知书", value,
                            DataBases.HearingNotice, DataBases.HearingNotice.Status, DataBases.HearingNotice.ID);
                        enforceLawGridViewHearingNotice.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;

        }
    }
}

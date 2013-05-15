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
using Maleos.Modules;

namespace EnforceForm
{
    public partial class frmPutOnRecords : BaseFormDetails
    {
        public frmPutOnRecords()
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

        public override void Reload()
        {
            EList<PutOnRecord> PutOnRecords = InvokeUtil.SystemService.PutOnRecordGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxNumber.Text, tableDateTimePickerBeginCheckDate.Value, tableDateTimePickerEndCheckDate.Value);
            pager.TotalCount = PutOnRecords.TotalCount;
            enforceLawGridViewSpotCheck.Bind<PutOnRecord>(PutOnRecords.Items);

        }
        private void frmPutOnRecords_Load(object sender, EventArgs e)
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
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutOnRecord"));
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
                PutOnRecord putOnRecord = enforceLawGridViewSpotCheck.SelectedRows[0].Tag as PutOnRecord;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPutOnRecord", new object[] { putOnRecord }));
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

                        PutOnRecord putOnRecord = row.Tag as PutOnRecord;
                        InvokeUtil.SystemService.EntityRemove(putOnRecord);
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

            PutOnRecord putOnRecord = rows[0].Tag as PutOnRecord;

            if (putOnRecord.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + putOnRecord.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(putOnRecord.ID, DataBases.PutOnRecord.___GetTableName(), putOnRecord.FilePath, "立案审批表", value,
                            DataBases.PutOnRecord, DataBases.PutOnRecord.Status, DataBases.PutOnRecord.ID);
                        enforceLawGridViewSpotCheck.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

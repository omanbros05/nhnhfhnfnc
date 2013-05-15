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
    public partial class frmSealDecide : BaseFormDetails
    {
        public frmSealDecide()
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

        private void frmSealDecide_Load(object sender, EventArgs e)
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

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditSealDecide"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSealDecide.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSealDecide.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SealDecide sealDecide = enforceLawGridViewSealDecide.SelectedRows[0].Tag as SealDecide;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmEditSealDecide", new object[] { sealDecide }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSealDecide.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSealDecide.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSealDecide.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SealDecide sealDecide = row.Tag as SealDecide;
                        InvokeUtil.SystemService.EntityRemove(sealDecide);
                        enforceLawGridViewSealDecide.Rows.Remove(row);
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
            EList<SealDecide> SealDecides = InvokeUtil.SystemService.SealDecideByDate(pager.CurrentPage, pager.PageSize, tableDateTimePickerBeginCheckDate.Value, tableDateTimePickerEndCheckDate.Value);
            pager.TotalCount = SealDecides.TotalCount;
            enforceLawGridViewSealDecide.Bind<SealDecide>(SealDecides.Items);
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSealDecide.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            SealDecide sealDecide = rows[0].Tag as SealDecide;

            if (sealDecide.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + sealDecide.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(sealDecide.ID, DataBases.SealDecide.___GetTableName(), sealDecide.FilePath, "查封或扣押决定书", value,
                            DataBases.SealDecide, DataBases.SealDecide.Status, DataBases.SealDecide.ID);
                        enforceLawGridViewSealDecide.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

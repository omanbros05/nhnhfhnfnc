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
    public partial class frmSpotShoots : BaseFormDetails
    {
        string rootPath = AppDomain.CurrentDomain.BaseDirectory;

        public frmSpotShoots()
        {
            InitializeComponent();

            tableDateTimePickerBeginCheckDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        }

        private void frmSpotShoots_Load(object sender, EventArgs e)
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
                //frmSpotShoot frm = new frmSpotShoot();
                //frm.OpenWindow(this);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotShoot"));

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotShoot.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSpotShoot.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotShoot spotShoot = InvokeUtil.SystemService.EntityInit(enforceLawGridViewSpotShoot.SelectedRows[0].Tag as SpotShoot) as SpotShoot;
                //frmSpotShoot frm = new frmSpotShoot(spotShoot);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotShoot", new object[] { spotShoot }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotShoot.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSpotShoot.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSpotShoot.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SpotShoot spotShoot = InvokeUtil.SystemService.EntityInit(row.Tag as SpotShoot) as SpotShoot;
                        foreach (SpotShootItem subItem in spotShoot.Items)
                        {
                            System.IO.File.Delete(rootPath + subItem.SpotPhoto);
                        }
                        InvokeUtil.SystemService.EntityRemove(spotShoot);
                        enforceLawGridViewSpotShoot.Rows.Remove(row);
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
            EList<SpotShoot> SpotShoots = InvokeUtil.SystemService.SpotShootGetAll(pager.CurrentPage, pager.PageSize, tableDateTimePickerBeginCheckDate.Value, tableDateTimePickerEndCheckDate.Value);
            pager.TotalCount = SpotShoots.TotalCount;
            enforceLawGridViewSpotShoot.Bind<SpotShoot>(SpotShoots.Items);
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSpotShoot.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            SpotShoot spotShoot = rows[0].Tag as SpotShoot;

            if (spotShoot.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + spotShoot.SpotName + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(spotShoot.ID, DataBases.SpotShoot.___GetTableName(), spotShoot.FilePath, "现场照片", value,
                            DataBases.SpotShoot, DataBases.SpotShoot.Status, DataBases.SpotShoot.ID);
                        enforceLawGridViewSpotShoot.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

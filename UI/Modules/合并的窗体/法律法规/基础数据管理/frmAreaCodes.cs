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
    public partial class frmAreaCodes : BaseFormDetails
    {
        public frmAreaCodes()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            buttonQuery.Enabled = false;
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
            buttonQuery.Enabled = true;

            UseWaitCursor = false;
        }

        public override void Reload()
        {
            EList<AreaCode> AreaCodes = InvokeUtil.SystemService.AreaCodeGetAll(pager.CurrentPage, pager.PageSize, textBoxID.Text, textBoxName.Text);
            pager.TotalCount = AreaCodes.TotalCount;
            enforceLawGridViewAreaCodes.Bind<AreaCode>(AreaCodes.Items);
        }

        private void pager_CurrentPageChangedEvent(object sender, Pager.CurrentPageChangedEventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void frmAreaCodes_Load(object sender, EventArgs e)
        {
            try
            {
                enforceLawGridViewAreaCodes.EntityType = typeof(AreaCode);
                enforceLawGridViewAreaCodes.InitColumnType<AreaCode>();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewAreaCodes.SelectedRows.Count == 0)
                return;

            if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewAreaCodes.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow row in enforceLawGridViewAreaCodes.SelectedRows)
                {
                    if (row.Tag == null)
                        continue;

                    AreaCode areaCode = row.Tag as AreaCode;
                    InvokeUtil.SystemService.EntityRemove(areaCode);
                    enforceLawGridViewAreaCodes.Rows.Remove(row);
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            enforceLawGridViewAreaCodes.AllowUserToAddRows = true;
            DataGridViewRow row = enforceLawGridViewAreaCodes.Rows[enforceLawGridViewAreaCodes.NewRowIndex];
            AreaCode areaCode = new AreaCode();
            areaCode.IsExists = false;
            areaCode.ParentID = 0;
            areaCode.LevelID = 0;
            areaCode.OrderID = 0;
            if (enforceLawGridViewAreaCodes.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow Prow in enforceLawGridViewAreaCodes.SelectedRows)
                {
                    if (Prow.Tag == null)
                        continue;
                    AreaCode aCode = Prow.Tag as AreaCode;
                    areaCode.ParentID = aCode.ID;
                    areaCode.LevelID = aCode.LevelID + 1;
                    areaCode.LevelName = GetLevel(areaCode.LevelID);
                    areaCode.OrderID = InvokeUtil.SystemService.AreaCodeMaxOrderId(areaCode.ParentID) + 1;
                }
            }
            InvokeUtil.SystemService.EntityUpdate(areaCode);
            row.Tag = areaCode;
            Reload();
            enforceLawGridViewAreaCodes.AllowUserToAddRows = false;
        }
        private string GetLevel(int level)
        {
            string levelName = "";
            for (int i = 0; i < level; i++)
            {
                levelName += "｜-";
            }
            return levelName;
        }
        private void toolStripButtonUp_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewAreaCodes.SelectedRows.Count == 0)
                return;
            foreach (DataGridViewRow row in enforceLawGridViewAreaCodes.SelectedRows)
            {
                if (row.Tag == null)
                    continue;

                AreaCode areaCode = row.Tag as AreaCode;
                if (areaCode != null)
                    InvokeUtil.SystemService.AreaCodeMoveAction(areaCode.ID, true, 1);
            }
        }

        private void toolStripButtonDown_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewAreaCodes.SelectedRows.Count == 0)
                return;
            foreach (DataGridViewRow row in enforceLawGridViewAreaCodes.SelectedRows)
            {
                if (row.Tag == null)
                    continue;

                AreaCode areaCode = row.Tag as AreaCode;
                if(areaCode!=null)
                    InvokeUtil.SystemService.AreaCodeMoveAction(areaCode.ID, false, 1);
            }
        }
    }
}

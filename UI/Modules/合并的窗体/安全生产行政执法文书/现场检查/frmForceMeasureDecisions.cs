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
    public partial class frmForceMeasureDecisions : BaseFormDetails
    {
        public frmForceMeasureDecisions()
        {
            InitializeComponent();
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

        private void frmForceMeasureDecisions_Load(object sender, EventArgs e)
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
                //frmForceMeasureDecision frm = new frmForceMeasureDecision();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecision"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewForceMeasureDecision.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewForceMeasureDecision.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ForceMeasureDecision frceMeasureDecision = enforceLawGridViewForceMeasureDecision.SelectedRows[0].Tag as ForceMeasureDecision;
                //frmForceMeasureDecision frm = new frmForceMeasureDecision(frceMeasureDecision);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecision", new object[] { frceMeasureDecision }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewForceMeasureDecision.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewForceMeasureDecision.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewForceMeasureDecision.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ForceMeasureDecision forceMeasureDecision = row.Tag as ForceMeasureDecision;
                        InvokeUtil.SystemService.EntityRemove(forceMeasureDecision);
                        enforceLawGridViewForceMeasureDecision.Rows.Remove(row);
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
            EList<ForceMeasureDecision> ForceMeasureDecisions = InvokeUtil.SystemService.ForceMeasureDecisionGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = ForceMeasureDecisions.TotalCount;
            enforceLawGridViewForceMeasureDecision.Bind<ForceMeasureDecision>(ForceMeasureDecisions.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewForceMeasureDecision.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ForceMeasureDecision forceMeasureDecision = enforceLawGridViewForceMeasureDecision.SelectedRows[0].Tag as ForceMeasureDecision;
                WordDocument doc = new WordDocument("强制措施决定书.rtf");
                doc.AddField("DocTitle", forceMeasureDecision.DocTitle);
                doc.AddField("CompanyName", forceMeasureDecision.CompanyName);
                doc.AddField("Matter", forceMeasureDecision.Matter);
                doc.AddField("Accord", forceMeasureDecision.Accord);
                doc.AddField("EnforceMea", forceMeasureDecision.EnforceMea);
                doc.AddField("GovArea", forceMeasureDecision.GovArea);
                doc.AddField("ManageArea", forceMeasureDecision.ManageArea);
                doc.AddField("CourtArea", forceMeasureDecision.CourtArea);
                doc.AddField("DocManageArea", forceMeasureDecision.DocManageArea);
                doc.AddField("DocDate", forceMeasureDecision.DocDate.ToString("yyyy年M月d日"));
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewForceMeasureDecision.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            ForceMeasureDecision forceMeasureDecision = rows[0].Tag as ForceMeasureDecision;

            if (forceMeasureDecision.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + forceMeasureDecision.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(forceMeasureDecision.ID, DataBases.ForceMeasureDecision.___GetTableName(), forceMeasureDecision.FilePath, "强制措施决定书", value,
                            DataBases.ForceMeasureDecision, DataBases.ForceMeasureDecision.Status, DataBases.ForceMeasureDecision.ID);
                        enforceLawGridViewForceMeasureDecision.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }

        private void header1_Click(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));
        }
    }
}

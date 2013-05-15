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
    public partial class frmForceMeasureDecisionApproves : BaseFormDetails
    {
        public frmForceMeasureDecisionApproves()
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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmForceMeasureDecisionApprove frm = new frmForceMeasureDecisionApprove();
                //frm.OpenWindow(this);

                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisionApprove"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewForceMeasureDecisionApprove.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewForceMeasureDecisionApprove.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ForceMeasureDecisionApprove forceMeasureDecisionApprove = enforceLawGridViewForceMeasureDecisionApprove.SelectedRows[0].Tag as ForceMeasureDecisionApprove;
                //frmForceMeasureDecisionApprove frm = new frmForceMeasureDecisionApprove(forceMeasureDecisionApprove);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmForceMeasureDecisionApprove", 
                    new object[] { forceMeasureDecisionApprove }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewForceMeasureDecisionApprove.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewForceMeasureDecisionApprove.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewForceMeasureDecisionApprove.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ForceMeasureDecisionApprove forceMeasureDecisionApprove = row.Tag as ForceMeasureDecisionApprove;
                        InvokeUtil.SystemService.EntityRemove(forceMeasureDecisionApprove);
                        enforceLawGridViewForceMeasureDecisionApprove.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void frmForceMeasureDecisionApproves_Load(object sender, EventArgs e)
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

        public override void Reload()
        {
            EList<ForceMeasureDecisionApprove> ForceMeasureDecisionApproves = InvokeUtil.SystemService.ForceMeasureDecisionApproveGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxParty.Text);
            pager.TotalCount = ForceMeasureDecisionApproves.TotalCount;
            enforceLawGridViewForceMeasureDecisionApprove.Bind<ForceMeasureDecisionApprove>(ForceMeasureDecisionApproves.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            //if (enforceLawGridViewForceMeasureDecisionApprove.SelectedRows.Count == 0)
            //    return;

            //UseWaitCursor = true;
            //Application.DoEvents();

            //try
            //{
            //    ForceMeasureDecisionApprove forceMeasureDecisionApprove = enforceLawGridViewForceMeasureDecisionApprove.SelectedRows[0].Tag as ForceMeasureDecisionApprove;
            //    WordDocument doc = new WordDocument("强制措施决定审批表.doc");
            //    doc.AddField("Party", forceMeasureDecisionApprove.Party);
            //    doc.AddField("PartyAddress", forceMeasureDecisionApprove.PartyAddress);
            //    doc.AddField("LegalRepre", forceMeasureDecisionApprove.LegalRepre);
            //    doc.AddField("Tel", forceMeasureDecisionApprove.Tel);
            //    doc.AddField("Matter", forceMeasureDecisionApprove.Matter);
            //    doc.AddField("Accord", forceMeasureDecisionApprove.Accord);
            //    doc.AddField("Supervise", forceMeasureDecisionApprove.Supervise);
            //    doc.AddField("SuperviseDate", forceMeasureDecisionApprove.SuperviseDate.ToString("yyyy年M月d日"));
            //    doc.AddField("Undertake", forceMeasureDecisionApprove.Undertake);
            //    doc.AddField("Principal", forceMeasureDecisionApprove.Principal);
            //    doc.AddField("PrincipalDate", forceMeasureDecisionApprove.PrincipalDate.ToString("yyyy年M月d日"));
            //    OutputDocuemnt frm = new OutputDocuemnt(doc);
            //    frm.OpenWindow(this);
            //}
            //catch (Exception ex)
            //{
            //    CommonInvoke.ErrorMessageBox(ex);
            //}

            //UseWaitCursor = false;
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewForceMeasureDecisionApprove.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            ForceMeasureDecisionApprove forceMeasureDecisionApprove = rows[0].Tag as ForceMeasureDecisionApprove;

            if (forceMeasureDecisionApprove.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + forceMeasureDecisionApprove.Party + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(forceMeasureDecisionApprove.ID, DataBases.SpotHandelDesision.___GetTableName(), forceMeasureDecisionApprove.FilePath, "强制措施决定审批", value,
                            DataBases.ForceMeasureDecisionApprove, DataBases.ForceMeasureDecisionApprove.Status, DataBases.ForceMeasureDecisionApprove.ID);
                        enforceLawGridViewForceMeasureDecisionApprove.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

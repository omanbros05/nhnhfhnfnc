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
    public partial class frmReviewOptionApproves : BaseFormDetails
    {
        public frmReviewOptionApproves()
        {
            InitializeComponent();
        }

        private void frmReviewOptionApproves_Load(object sender, EventArgs e)
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
                frmReviewOptionApprove frm = new frmReviewOptionApprove();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReviewOptionApprove.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewReviewOptionApprove.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ReviewOptionApprove reviewOptionApprove = enforceLawGridViewReviewOptionApprove.SelectedRows[0].Tag as ReviewOptionApprove;
                frmReviewOptionApprove frm = new frmReviewOptionApprove(reviewOptionApprove);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReviewOptionApprove.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewReviewOptionApprove.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewReviewOptionApprove.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ReviewOptionApprove reviewOptionApprove = row.Tag as ReviewOptionApprove;
                        InvokeUtil.SystemService.EntityRemove(reviewOptionApprove);
                        enforceLawGridViewReviewOptionApprove.Rows.Remove(row);
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
            EList<ReviewOptionApprove> ReviewOptionApproves = InvokeUtil.SystemService.ReviewOptionApproveGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxParty.Text);
            pager.TotalCount = ReviewOptionApproves.TotalCount;
            enforceLawGridViewReviewOptionApprove.Bind<ReviewOptionApprove>(ReviewOptionApproves.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReviewOptionApprove.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ReviewOptionApprove reviewOptionApprove = enforceLawGridViewReviewOptionApprove.SelectedRows[0].Tag as ReviewOptionApprove;
                WordDocument doc = new WordDocument("复查意见审批表.doc");
                doc.AddField("Party", reviewOptionApprove.Party);
                doc.AddField("PartyAddress", reviewOptionApprove.PartyAddress);
                doc.AddField("LegalRepre", reviewOptionApprove.LegalRepre);
                doc.AddField("Tel", reviewOptionApprove.Tel);
                doc.AddField("RawDecisionID", reviewOptionApprove.RawDecisionID);
                doc.AddField("LeaveTime", reviewOptionApprove.LeaveTime.ToString("yyyy年M月d日"));
                doc.AddField("ReceiveTime", reviewOptionApprove.ReceiveTime.ToString("yyyy年M月d日"));
                doc.AddField("ReviewTime", reviewOptionApprove.ReviewTime.ToString("yyyy年M月d日"));
                doc.AddField("MajorProblems", reviewOptionApprove.MajorProblems);
                doc.AddField("ReviewCondition", reviewOptionApprove.ReviewCondition);
                doc.AddField("Reviewer", reviewOptionApprove.Reviewer);
                doc.AddField("ReviewDate", reviewOptionApprove.ReviewDate.ToString("yyyy年M月d日"));
                doc.AddField("Undertake", reviewOptionApprove.Undertake);
                doc.AddField("Principal", reviewOptionApprove.Principal);
                doc.AddField("PrincipalDate", reviewOptionApprove.PrincipalDate.ToString("yyyy年M月d日"));
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

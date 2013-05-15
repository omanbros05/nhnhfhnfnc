using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceForm;
using EnforceUI;
using Common;
using Maleos.Controls;

namespace Maleos.Modules
{
    public partial class Enforces : BasePage
    {
        public Enforces()
        {
            InitializeComponent();

            TaskService.Instance.AddItemEvent += new TaskService.AddItemEventHandeler(Instance_AddItemEvent);
            TaskService.Instance.RemoveItemEvent += new TaskService.RemoveItemEventHandeler(Instance_RemoveItemEvent);
        }

        private void Instance_RemoveItemEvent(string key, FormState formState)
        {
            try
            {
                if (formState.CurrentForm.FormControl.FormPosition == ShowFormPosition.Default)
                {
                    splitContainerControl1.Panel2.Controls.Clear();
                    if (formState.ParentForm != null)
                    {
                        formState.ParentForm.FormControl.Dock = DockStyle.Fill;
                        formState.ParentForm.FormControl.Reload();
                        splitContainerControl1.Panel2.Controls.Add(formState.ParentForm.FormControl);
                    }
                }
                else
                {
                    FrmMain.Instance.Controls.Clear();
                    if (formState.ParentForm != null)
                    {
                        if (formState.ParentForm.BasePageControl == null)
                        {
                            BaseForm control = formState.ParentForm.FormControl;
                            control.Dock = DockStyle.Fill;
                            control.Reload();
                            FrmMain.Instance.Controls.Add(control);
                        }
                        else
                        {
                            Maleos.Controls.BasePage control = formState.ParentForm.BasePageControl;
                            control.Dock = DockStyle.Fill;
                            control.Reload();
                            FrmMain.Instance.Controls.Add(control);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void Instance_AddItemEvent(string key, FormState formState)
        {
            try
            {
                if (formState.CurrentForm.FormControl.FormPosition == ShowFormPosition.Default)
                {
                    splitContainerControl1.Panel2.Controls.Clear();
                    formState.CurrentForm.FormControl.Dock = DockStyle.Fill;
                    splitContainerControl1.Panel2.Controls.Add(formState.CurrentForm.FormControl);
                }
                else
                {
                    if (FrmMain.Instance.Controls.Count > 0)
                    {
                        if (FrmMain.Instance.Controls[0].GetType().BaseType != typeof(BasePage))
                            formState.ParentForm.FormControl = (BaseForm)FrmMain.Instance.Controls[0];
                        else
                            formState.ParentForm.BasePageControl = (BasePage)FrmMain.Instance.Controls[0];
                    }
                    FrmMain.Instance.Controls.Clear();
                    formState.CurrentForm.FormControl.Dock = DockStyle.Fill;
                    FrmMain.Instance.Controls.Add(formState.CurrentForm.FormControl);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        public override void Reload()
        {
            if (splitContainerControl1.Panel2.Controls.Count > 0)
            {
                ((BaseForm)splitContainerControl1.Panel2.Controls[0]).Reload();
            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            TaskService.Instance.ClearCache();
            TaskService.Instance.AddItemEvent -= new TaskService.AddItemEventHandeler(Instance_AddItemEvent);
            TaskService.Instance.RemoveItemEvent -= new TaskService.RemoveItemEventHandeler(Instance_RemoveItemEvent);
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

        private void navBarItemSpotCheck_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotChecks());
        }

        private void navBarItemSpotHandelDesision_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotHandelDesisions());
        }

        private void navBarItemForceMeasureDecisionApprove_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmForceMeasureDecisionApproves());
        }

        private void navBarItemForceMeasureDecision_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmForceMeasureDecisions());
        }

        private void navBarItemOrderDeadlineReform_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmOrderDeadlineReforms());
        }

        private void navBarItemSpotHandelDesisionSixtyDay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotHandelDesisionSixtyDays());
        }

        private void navBarItemReformReView_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmReformReViews());
        }

        private void navBarItemReviewOptionApprove_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmReviewOptionApproves());
        }

        private void navBarItemPutOnRecord_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPutOnRecords());
        }

        private void navBarItemNoticeOfEnquiry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmNoticeOfEnquirys());
        }

        private void navBarItemInterrogationRecord_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInterrogationRecords());
        }

        private void navBarItemExplorationRecord_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmExplorationRecords());
        }

        private void navBarItemSampling_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSamplings());
        }

        private void navBarItemAppraisalEntrust_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmAppraisalEntrusts());
        }

        private void navBarItemSaveEvidenceAudit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSaveEvidenceAudits());
        }

        private void navBarItemSaveEvidenceNotice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSaveEvidenceNotices());
        }

        private void navBarItemSaveEvidenceProceAudit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSaveEvidenceProceAudits());
        }

        private void navBarItemSaveEvidenceProceDecide_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSaveEvidenceProceDecides());
        }

        private void navBarItemPunishmentDiscussRecord_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPunishmentDiscussRecords());
        }

        private void navBarItemCaseCancel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseCancels());
        }

        private void navBarItemInCaseOfTable_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInCaseOfTables());
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseTransferredApproval());
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseTransferredApproval());
        }

        private void navBarItemSpotShoot_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotShoots());
        }
    }
}

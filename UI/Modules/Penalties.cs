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
    public partial class Penalties : BasePage
    {
        public Penalties()
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

        private void navBarItemAdministrativePenaltyCompany_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmAdministrativePenaltyCompanys());
        }

        private void navBarItemAdministrativePenaltyPerson_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmAdministrativePenaltyPersons());
        }

        private void navBarItemSpotPunishmentDecisionUnit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotPunishmentDecisionUnits());
        }

        private void navBarItemSpotPunishmentDecisionPersonal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotPunishmentDecisionPersonals());
        }

        private void navBarItemPunishmentDecisionUnit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPunishmentDecisionUnits());
        }

        private void navBarItemPunishmentDecisionPersonal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPunishmentDecisionPersonals());
        }

        private void navBarItemDocumentsServiceReply_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmDocumentsServiceReplys());
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem35_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseTransferredApproval());
        }

        private void navBarItem36_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseTransferred());
        }

        private void navBarItem30_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSealDecideApproval());
        }

        private void navBarItem31_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSealDecide());
        }

        private void navBarItem32_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSealThingDetail());
        }

        private void navBarItem33_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSealThingHandleApproval());
        }

        private void navBarItem34_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSealThingHandle());
        }

        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmAdminPunishNotification());
        }

        private void navBarItem28_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmWritServiceReceipts());
        }

        private void navBarItem29_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmDefenseRecords());
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmFineCallsNotice());
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmContributeFineApproval());
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmFineCallsNotice());
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseClosedApproval());
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseExtensionClosedApprovalToSibling());
        }

        private void navBarItem37_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmCaseExtensionClosedApproval());
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

        private void navBarItemSpotPunishmentDecisionUnit_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotPunishmentDecisionUnits());
        }

        private void navBarItemSpotPunishmentDecisionPersonal_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmSpotPunishmentDecisionPersonals());
        }

        private void navBarItemPunishmentDecisionUnit_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPunishmentDecisionUnits());
        }

        private void navBarItemPunishmentDecisionPersonal_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPunishmentDecisionPersonals());
        }

        private void navBarItemDocumentsServiceReply_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmWritServiceReceipts());
        }

        private void navBarItemInCaseOfTable_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInCaseOfTables());
        }

        private void navBarItemHearingNotice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmHearingNotices());
        }

        private void navBarItemPutDown_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmPutDowns());
        }

        private void navBarItemHearingInform_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmHearingInforms());
        }

        private void navBarItemWritServiceReceipt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmWritServiceReceipts());
        }

        private void navBarItemEnquireQuestion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           // TaskService.Instance.Add(new frmEnquireQuestions());
            //TaskService.Instance.Add(new frmInterrogationRecords());
        }
    }
}

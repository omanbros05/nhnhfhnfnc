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
    public partial class InstrumentsExample : BasePage
    {
        public InstrumentsExample()
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

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查));
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查));
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程));
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查));
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送));
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚));
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩));
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批));
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件处理));
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚));
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款));
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmInstrumentsExamples((int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案));
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            TaskService.Instance.ClearCache();
            TaskService.Instance.AddItemEvent -= new TaskService.AddItemEventHandeler(Instance_AddItemEvent);
            TaskService.Instance.RemoveItemEvent -= new TaskService.RemoveItemEventHandeler(Instance_RemoveItemEvent);
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }
        public override void Reload()
        {
            if (splitContainerControl1.Panel2.Controls.Count > 0)
            {
                ((BaseForm)splitContainerControl1.Panel2.Controls[0]).Reload();
            }
        }

    }
}

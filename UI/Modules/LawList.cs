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
    public partial class LawList : BasePage
    {
        public LawList()
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
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.综合));
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.事故调查处理));
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.危险化学品安全));
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.烟花爆竹安全));
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.矿山安全));
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.宣传教育));
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.职业卫生安全));
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.劳动防护用品));
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawLists((int)SOA.ORM.LawFile.ELawType.标准));
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            TaskService.Instance.ClearCache();
            TaskService.Instance.AddItemEvent -= new TaskService.AddItemEventHandeler(Instance_AddItemEvent);
            TaskService.Instance.RemoveItemEvent -= new TaskService.RemoveItemEventHandeler(Instance_RemoveItemEvent);
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawPower(Application.StartupPath + @"\处罚权力\台州市安全生产监督管理局行政处罚自由裁量标准.doc"));
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaskService.Instance.Add(new frmLawPower(Application.StartupPath + @"\处罚权力\台州市安全生产监督管理局行政处罚权力事项汇总表.doc"));
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

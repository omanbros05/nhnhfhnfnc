using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOA;
using SOA.ORM;
using System.IO;

namespace EnforceUI
{
    public partial class BaseTableForm : BaseForm
    {
        public BaseTableForm()
        {
            InitializeComponent();

            FormPosition = ShowFormPosition.FormMain;
        }

        private void BaseTableForm_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(BaseTableForm_MouseWheel);
            panelContent.Focus();
        }

        private void BaseTableForm_MouseWheel(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            mousePoint.Offset(this.Location.X, this.Location.Y);
            if (panelContent.RectangleToScreen(panelContent.DisplayRectangle).Contains(mousePoint))
                panelContent.AutoScrollPosition = new Point(0, panelContent.VerticalScroll.Value - e.Delta);
        }

        /// <summary>
        /// 获取窗体上的对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected virtual void GetEntity(EntityInterface entity)
        {
            Type type = entity.GetType();
            foreach (Control control in panelContent.Controls)
            {
                GetControlValue(control, entity, type);
            }
        }

        private void GetControlValue(Control controlItem,EntityInterface entity,Type type)
        {
            Type controlType = controlItem.GetType().GetInterface(typeof(ITableControl).ToString());
            if (controlType != null)
            {
                ITableControl tableControl = (ITableControl)controlItem;
                Type proType = entity.GetType().GetProperty(tableControl.ControlName).PropertyType;
                type.InvokeMember(tableControl.ControlName, BindingFlags.SetProperty, null, entity, new object[] { Convert.ChangeType(tableControl.ControlText, proType) });
            }

            foreach (Control control in controlItem.Controls)
            {
                GetControlValue(control, entity, type);
            }
        }

        /// 设置窗体上对象的Text值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        protected virtual void SetEntity(EntityInterface entity)
        {
            Type type = entity.GetType();
            foreach (Control control in panelContent.Controls)
            {
                SetControlValue(control, entity, type);
            }
        }

        private void SetControlValue(Control controlItem, EntityInterface entity, Type type)
        {
            Type controlType = controlItem.GetType().GetInterface(typeof(ITableControl).ToString());
            if (controlType != null)
            {
                ITableControl tableControl = (ITableControl)controlItem;
                object obj = type.InvokeMember(tableControl.ControlName, BindingFlags.GetProperty, null, entity, null);
                if (obj != null)
                    tableControl.ControlText = obj.ToString();
            }

            foreach (Control control in controlItem.Controls)
            {
                SetControlValue(control, entity, type);
            }
        }

        private void panelContent_Click(object sender, EventArgs e)
        {
            panelContent.Focus();
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            System.Diagnostics.Process.Start(keyboardPath);
            //System.Diagnostics.Process.Start("osk.exe");
        }
    }
}

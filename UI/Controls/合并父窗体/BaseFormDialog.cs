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

namespace EnforceUI
{
    public partial class BaseFormDialog : BaseForm
    {
        public BaseFormDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
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
                Type controlType = control.GetType().GetInterface(typeof(ITableControl).ToString());
                if (controlType != null)
                {
                    ITableControl tableControl = (ITableControl)control;
                    type.InvokeMember(tableControl.ControlName, BindingFlags.SetProperty, null, entity, new object[] { tableControl.ControlText });
                }
            }
        }

        /// <summary>
        /// 设置窗体上对象的Text值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        protected virtual void SetEntity(EntityInterface entity)
        {
            Type type = entity.GetType();
            foreach (Control control in panelContent.Controls)
            {
                Type controlType = control.GetType().GetInterface(typeof(ITableControl).ToString());
                if (controlType != null)
                {
                    ITableControl tableControl = (ITableControl)control;
                    object obj = type.InvokeMember(tableControl.ControlName, BindingFlags.GetProperty, null, entity, null);
                    if (obj != null)
                        tableControl.ControlText = obj.ToString();
                }
            }
        }
    }
}

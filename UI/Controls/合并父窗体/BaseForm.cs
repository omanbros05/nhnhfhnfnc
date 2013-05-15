using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Common;
using System.Text;
using System.Windows.Forms;
using Maleos.Controls;

namespace EnforceUI
{
    public partial class BaseForm : BasePage
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private ShowFormPosition showFormPosition = ShowFormPosition.Default;
        public ShowFormPosition FormPosition
        {
            get { return showFormPosition; }
            set { showFormPosition = value; }
        }


        public FormState FormValue
        {
            get;
            set;
        }

        private string guid;
        public string GUID
        {
            get 
            {
                if (string.IsNullOrEmpty(guid))
                    guid = CommonInvoke.NewGuid;
                return guid;
            }
        }

        public void OpenWindow()
        {
            OpenWindow(null);
        }

        public void OpenWindow(BaseForm parentForm)
        {
            FormItem formItem = new FormItem { FormControl = this, CurrentPage = GetCurrentPage(), FormControls = GetTableControls() };
            FormItem parent = null;
            if (parentForm != null)
                parent = new FormItem { FormControl = parentForm, FormControls = parentForm.GetTableControls(), CurrentPage = parentForm.GetCurrentPage() };

            FormState formState = new FormState { ParentForm = parent, CurrentForm = formItem };
            TaskService.Instance.Add(this, parentForm);
        }

        public void CloseWindow()
        { 
            FormItem formItem = new FormItem{ FormControl = this};
            FormState formState = new FormState{ CurrentForm = formItem};
            TaskService.Instance.Remove(GUID);
        }

        /// <summary>
        /// 获取控件
        /// </summary>
        /// <returns></returns>
        public virtual List<ITableControl> GetTableControls()
        {
            return new List<ITableControl>();
        }

        public virtual int GetCurrentPage()
        {
            return 1;
        }

        public virtual void SetTableControls()
        { 
            
        }

        public virtual void SetCurrentPage()
        { 
            
        }

        public virtual void Reload()
        { 
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maleos.Controls;

namespace EnforceUI
{
    public enum ShowFormPosition
    { 
        /// <summary>
        /// 默认
        /// </summary>
        Default,
        /// <summary>
        /// 主窗体
        /// </summary>
        FormMain
    }

    public class FormState
    {
        public FormItem ParentForm
        {
            get;
            set;
        }

        public FormItem CurrentForm
        {
            get;
            set;
        }
    }

    public class FormItem
    {
        public BasePage BasePageControl
        {
            get;
            set;
        }

        public BaseForm FormControl
        {
            get;
            set;
        }

        public int CurrentPage
        {
            get;
            set;
        }

        private List<ITableControl> formControls;
        public List<ITableControl> FormControls
        {
            get 
            {
                if (formControls == null)
                    formControls = new List<ITableControl>();

                return formControls;
            }

            set 
            {
                formControls = value;
            }
        }
    }
}

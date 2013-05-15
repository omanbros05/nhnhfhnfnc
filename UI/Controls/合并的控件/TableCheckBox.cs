using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class TableCheckBox : CheckBox,ITableControl
    {
        public TableCheckBox()
        {
            InitializeComponent();
        }

        public TableCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string ControlText
        {
            get { return Convert.ToString(Checked); }
            set { Checked = Convert.ToBoolean(value); }
        }

        public string ControlName
        {
            get { return Name; }
        }
    }
}

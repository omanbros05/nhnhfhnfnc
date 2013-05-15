using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class TableDateTimePicker : DateTimePicker,ITableControl
    {
        public TableDateTimePicker()
        {
            InitializeComponent();
        }

        public TableDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ControlText
        {
            get { return Value.ToString(); }
            set { Value = DateTime.Parse(value); }
        }

        [Browsable(false)]
        public string ControlName
        {
            get { return Name; }
        }
    }
}

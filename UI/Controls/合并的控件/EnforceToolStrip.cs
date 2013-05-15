using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class EnforceToolStrip : ToolStrip
    {
        public EnforceToolStrip()
        {
            InitializeComponent();
        }

        public EnforceToolStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

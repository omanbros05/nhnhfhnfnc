using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class TableLine : PictureBox
    {
        public TableLine()
        {
            InitializeComponent();
        }

        public TableLine(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

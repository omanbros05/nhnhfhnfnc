using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class ScrollPanel : Panel
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWnd);

        public ScrollPanel()
        {
            InitializeComponent();
        }
    }
}

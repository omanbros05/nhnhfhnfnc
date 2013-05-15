using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maleos.Controls
{
    public partial class ArchiveFooter : UserControl
    {
        public ArchiveFooter()
        {
            InitializeComponent();
            this.Height = 110;
        }

        public event EventHandler ButtonEventHandler;

        private void Button_Click(object sender, EventArgs e) {

            ButtonEventHandler(this, null);
        }

        private void ArchiveFooter_Resize(object sender, EventArgs e)
        {
            imageButton1.Location = new Point(62, 27);
            label1.Location = new Point(26, 81);
            this.Height = 110;
        }
    }
}

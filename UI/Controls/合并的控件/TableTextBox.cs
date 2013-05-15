using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class TableTextBox : TextBox, ITableControl
    {
        public TableTextBox()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            // BackColor也可以自己设置
            this.BackColor = Color.White;
        }

        public TableTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private int WM_PAINT = 0x000F;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Pen pen = new Pen(Brushes.Black, 1.5f);
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(pen, new Point(0, this.Size.Height - 1), new Point(this.Size.Width, this.Size.Height - 1));
                }
            }
        }

        public string ControlText
        {
            get { return Text; }
            set { Text = value; }
        }

        public string ControlName
        {
            get { return Name; }
        }
    }
}

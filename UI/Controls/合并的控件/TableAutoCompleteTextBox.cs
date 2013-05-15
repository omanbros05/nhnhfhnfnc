using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using EnforceUI.Input;

namespace EnforceUI
{
    public partial class TableAutoCompleteTextBox : AutoCompleteTextBox,ITableControl
    {
        public TableAutoCompleteTextBox()
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.None;
            // BackColor也可以自己设置
            this.BackColor = Color.White;
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

        public TableAutoCompleteTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
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

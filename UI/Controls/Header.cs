using System;
using System.ComponentModel;

namespace Maleos.Controls
{
    public partial class Header : DevExpress.XtraEditors.XtraUserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DefaultValue(true)]
        public bool BackButtonVisible
        {
            get { return this.BackButton.Visible; }
            set { 
                this.BackButton.Visible = value;
                if (BackButton.Visible == false)
                {
                    BackButton.Size = new System.Drawing.Size(0, 0);
                    lblTitle.Location = new System.Drawing.Point(0, 0);
                }
                else {
                    BackButton.Size = new System.Drawing.Size(46, 48);
                    lblTitle.Location = new System.Drawing.Point(75, 0);
                }
            }
        }
        [Browsable(true)]
        [DefaultValue(true)]
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (BackEvent != null)
            {
                BackEvent(this, null);
            }
        }

        public event EventHandler BackEvent;

        private void Header_Resize(object sender, EventArgs e)
        {
            this.Height = Math.Max(45, 75);
        }

    }
}

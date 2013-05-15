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
    public partial class Footer : UserControl
    {
        public Footer()
        {
            InitializeComponent();

            this.Height = 110;
        }

        [Browsable(true)]
        [DefaultValue(false)]
        public bool DeleteButtonVisible {

            get { return this.BtnDelete.Visible; }

            set { this.BtnDelete.Visible = value;
            this.LblDelete.Visible = value;
            }
        }
        [Browsable(true)]
        [DefaultValue(false)]
        public bool MarkButtonVisible {
            get { return this.BtnMark.Visible; }
            set { this.BtnMark.Visible = value;
            this.LblMark.Visible = value;
            }
        }

        [Browsable(true)]
        public string AddLabel {

            get { return LblAdd.Text; }
            set { LblAdd.Text = value; }
        }

        [Browsable(true)]
        public string DeleteLabel {

            get { return LblDelete.Text; }
            set { LblDelete.Text = value; }
        }

        [Browsable(true)]
        public string MarkLabel {
            get { return LblMark.Text; }
            set { LblMark.Text = value; }
        }

        public event EventHandler AddEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler MarkEvent;

        private void Button_Click(object sender, EventArgs e) {

            ImageButton button = (ImageButton)sender;

            if (button.Name == BtnAdd.Name && AddEvent != null) { 
                AddEvent(this, null);
            }
            else if (button.Name == BtnDelete.Name && DeleteEvent != null) {
                DeleteEvent(this, null);
            }
            else if (button.Name == BtnMark.Name && MarkEvent != null) {

                MarkEvent(this, null);
            }
        } 

        private void Footer_Resize(object sender, EventArgs e)
        {
            BtnAdd.Top = 22;
            BtnDelete.Top = 22;
            BtnMark.Top = 22;

            LblAdd.Top = 71;
            LblDelete.Top = 71;
            LblMark.Top = 71;
        }
    }
}

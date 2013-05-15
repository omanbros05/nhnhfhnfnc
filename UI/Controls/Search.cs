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
    public partial class Search : BasePage
    {

        private readonly int TEXTBOX_SIZE = 200;
        private readonly int PADDING_SIZE = 20;
        private readonly int LEFT = 16;
        private readonly int TOP = 32;
        public Search()
        {
            InitializeComponent();

            InitControls();
        }

        public event EventHandler SearchClick;

        public void SearchButton_Click(object sender, EventArgs e) {

            if (SearchClick != null) {
                SearchClick(this, null);
            }
        
        }

        private void InitControls() {
            NumberTextBox.Text = string.Empty;
            NameTextbox.Text = string.Empty;
            AttrNameTextbox.Text = string.Empty;
            UNCodeTextbox.Text = string.Empty;
        }

        private void Search_Resize(object sender, EventArgs e)
        {
            //foreach (Control control in Controls) {
            //    string name = control.Name;
            //    Type type = control.GetType();
            //    if (type == typeof(TextBox)) {

            //        switch (name) { 
                    
            //            case "NumberTextBox":
            //                control.Location = new Point(LEFT, TOP);
            //                break;
            //            case "NameTextbox":
            //                control.Location = new Point(LEFT + TEXTBOX_SIZE + PADDING_SIZE, TOP);
            //                break;
            //            case "AttrNameTextbox":
            //                control.Location = new Point((LEFT + TEXTBOX_SIZE + PADDING_SIZE) * 2, TOP);
            //                break;
            //            case "UNCodeTextbox":
            //                control.Location = new Point((LEFT + TEXTBOX_SIZE + PADDING_SIZE) * 3, TOP);
            //                break;
                    
            //        }
                
            //    }
            //}
        }
    }
}

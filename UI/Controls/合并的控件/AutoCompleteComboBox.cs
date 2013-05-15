using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class AutoCompleteComboBox : EnforceLawComboBox
    {
        public AutoCompleteComboBox()
            : base()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(AutoCompleteComboBox_KeyPress);
        }

        public AutoCompleteComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void AutoCompleteComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoComplete(this, e, true);
        }

        public void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e, bool limitToList)
        {
            string strFindStr = "";

            if (e.KeyChar == (char)8)
            {
                if (cb.SelectionStart <= 1)
                {
                    cb.Text = "";
                    return;
                }

                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1);
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1);
            }
            else
            {
                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text + e.KeyChar;
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;
            }

            int intIdx = -1;

            // 在combox中搜索字符串

            intIdx = cb.FindString(strFindStr);

            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
            {
                e.Handled = limitToList;
            }

        }
    }
}

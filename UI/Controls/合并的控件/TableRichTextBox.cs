using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class TableRichTextBox : RichTextBox, ITableControl
    {
        public TableRichTextBox()
        {
            InitializeComponent();
        }

        public TableRichTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void CreateContextMenu() { 

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

        private void TableRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && this.SelectionLength == 0) {

                ToolStripItemCollection strips = contextMenuStrip1.Items;
                foreach (ToolStripItem item in strips) {

                    item.Enabled = false;
                }
            }
        }

        //private bool isEnablePasteButton = false;
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;

            if (item.Name == "toolCopy")
            {
                this.Copy();
                //isEnablePasteButton = true;
            }
            else if (item.Name == "toolCut")
            {
                this.Cut();
                //isEnablePasteButton = true;
            }
            else if (item.Name == "toolPaste")
            {
                this.Paste();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (SelectionLength == 0)
            {
                toolCopy.Enabled = false;
                toolCut.Enabled = false;

            }
            else {
                toolCopy.Enabled = true;
                toolCut.Enabled = true;
            }

            IDataObject data = Clipboard.GetDataObject();
            if (data == null ) toolPaste.Enabled = false;
            else toolPaste.Enabled = true;
           
        }
    }
}

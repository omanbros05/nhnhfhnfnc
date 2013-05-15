using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnforceUI.Input
{
    public partial class ValueListBox : ListBox
    {
        public ValueListBox()
        {
            InitializeComponent();
        }

        public ValueListBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public new object SelectedValue
        {
            get 
            {
                if (DataSource != null)
                    return base.SelectedValue;
                else
                {
                    if (SelectedIndex > -1)
                    {
                        ListItem li = SelectedItem as ListItem;
                        if (li != null) return li.ItemValue;
                    }
                    return base.SelectedValue;
                }
            }
            set 
            {
                if (DataSource != null)
                    base.SelectedValue = value;
                else
                {
                    for (int i = 0; i < Items.Count; ++i)
                    {
                        ListItem item = Items[i] as ListItem;
                        if (item != null)
                        {
                            if (item.ItemValue == value)
                            {
                                SelectedIndex = i;
                                return;
                            }
                        }
                        else
                        {
                            base.SelectedValue = value;
                            return;
                        }
                    }

                    SelectedIndex = -1;
                }
            }
        }
    }

    /// <summary>
    /// listbox控件重写Item
    /// </summary>
    public class ListItem
    {
        private string text;
        private object itemValue;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public object ItemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }

        public ListItem(string text, object itemValue)
        {
            this.text = text;
            this.itemValue = itemValue;
        }

        public ListItem(string text)
            : this(text, null)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using EnforceUI.Input;

namespace EnforceUI
{
    public partial class DocumentAutoCompleteTextBox : AutoCompleteTextBox, ITableControl
    {
        public DocumentAutoCompleteTextBox()
        {
            InitializeComponent();
        }

        public DocumentAutoCompleteTextBox(IContainer container)
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

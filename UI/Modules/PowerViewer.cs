using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOA.ORM;

namespace Maleos.Modules
{
    public partial class PowerViewer : Controls.BasePage
    {

        private PowerInventory _inventory;
        private string _module;
        private object _object;
        public PowerViewer()
        {
            InitializeComponent();   
        }

        public PowerViewer(PowerInventory inventory) : this() {

            _inventory = inventory;
        }

        public PowerViewer(PowerInventory inventory, string module, object obj) : this(inventory) {

            _module = module;
            _object = obj;
        }

        private void OnLoad(object sender, EventArgs e) {

            if (_inventory == null)
                richEditControl1.HtmlText = "<font size='28' face='songti'>加载数据出错，请返回重试。</font>";
            else
            {
                string content ="<p style='line-height:30px;font-family:songti;'>" + _inventory.PowerContent;
                content = content.Replace("\n", "</p><p style='line-height:30px;font-family:songti;'>") + "</p>";
                richEditControl1.HtmlText = content;
            }
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new NavigationRequestEventArgs("EnforceForm.frmPowers", new object[]{ _module, _object }));
        }
    }
}

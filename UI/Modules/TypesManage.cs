using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maleos.Controls;
namespace Maleos.Modules
{
    public partial class TypesManage : BasePage
    {
        public TypesManage()
        {
            InitializeComponent();
        }

        private void header1_BackEvent(object sender, EventArgs e) {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }
    }
}

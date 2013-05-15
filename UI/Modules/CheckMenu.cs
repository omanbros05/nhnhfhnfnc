using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Maleos.Controls;
namespace Maleos.Modules
{
    public partial class CheckMenu : BasePage
    {
        public CheckMenu()
        {
            InitializeComponent();

            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.StartPage"));

        }

        private void ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e) {

            DevExpress.XtraEditors.TileItem tile = (DevExpress.XtraEditors.TileItem)sender;
            OnNavigationRequest(new NavigationRequestEventArgs(tile.Tag.ToString()));

        }
    }
}

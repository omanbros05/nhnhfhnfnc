using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maleos.Controls;
using DevExpress.XtraEditors;

namespace Maleos.Modules
{
    public partial class Enterprise : BasePage
    {
        public Enterprise()
        {
            InitializeComponent();
            AddEvent();
        }

        private void AddEvent() {

            foreach (TileGroup group in this.tileControl1.Groups) {

                foreach (TileItem item in group.Items) {

                    item.ItemClick += new TileItemClickEventHandler(TileItemClick);
                }    
            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

        private void TileItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            TileItem item = (TileItem)sender;
            if (item.Id == 2)
                OnNavigationRequest(new NavigationRequestEventArgs(item.Tag.ToString(), new object[]{ false, -2 }));

            OnNavigationRequest(new NavigationRequestEventArgs(item.Tag.ToString()));
        }
    }
}

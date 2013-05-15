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
    /// <summary>
    /// 行政处罚菜单管理
    /// </summary>
    public partial class AdmistrativePenalties : BasePage
    {
        public AdmistrativePenalties()
        {
            InitializeComponent();

            //this.tileControl1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(ItemClick);
            AddEvent();
        }

        private void AddEvent() {

            foreach (TileGroup group in tileControl1.Groups) {
                foreach (TileItem item in group.Items) {

                    item.ItemClick += new TileItemClickEventHandler(ItemClick);
                
                }
            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

        private void ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DevExpress.XtraEditors.TileItem tile = (DevExpress.XtraEditors.TileItem)sender;
            OnNavigationRequest(new NavigationRequestEventArgs(tile.Tag.ToString()));
        }
    }
}

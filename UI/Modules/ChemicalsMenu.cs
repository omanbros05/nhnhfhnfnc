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
    public partial class ChemicalsMenu : BasePage
    {
        public ChemicalsMenu()
        {
            InitializeComponent();

            AddEventToTileItem();
        }

        private void ChemicalsMenu_Resize(object sender, EventArgs e)
        {
            this.tileControl1.Width = this.Width;
            this.tileControl1.Height = this.Height - header1.Height - search1.Height - 10;
            this.tileControl1.Location = new Point(0, 160);
        }

        private void AddEventToTileItem() {

            foreach (TileGroup group in tileControl1.Groups) {

                foreach (TileItem item in group.Items) {

                    item.ItemClick += new TileItemClickEventHandler(TileItemClick);
                }
            }
        }

        private void Search(string number, string name, string alias, string uncode) {

            OnNavigationRequest(new NavigationRequestEventArgs("EnforceForm.frmChemicalsLists", new object[]{ number, name, alias, uncode }));
        }

        private void TileItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e) {
            TileItem item = (TileItem)sender;
            OnNavigationRequest(new NavigationRequestEventArgs(item.Tag.ToString(), new object[]{ item.Id }));
        }

        private void search1_SearchClick(object sender, EventArgs e)
        {
            string number = search1.NumberTextBox.Text.Trim();
            string name = search1.NameTextbox.Text.Trim();
            string alias = search1.AttrNameTextbox.Text.Trim();
            string uncode = search1.UNCodeTextbox.Text.Trim();

            Search(number, name, alias, uncode);
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }
    }
}

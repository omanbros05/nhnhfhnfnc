using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Drawing;

namespace Maleos.Controls
{
    public class TileBuilder {

        DevExpress.XtraEditors.TileControl _control;

        public TileBuilder(bool itemChecked) {
            _control = new DevExpress.XtraEditors.TileControl();

            if (itemChecked) {

                _control.ItemCheckMode = TileItemCheckMode.Single;
            }
        }

        public void AddTileControl(Control parent) {

            DevExpress.XtraEditors.TileControl control = _control;
            control.Dock = DockStyle.Fill;
            parent.Controls.Add(control);

        }

        public DevExpress.XtraEditors.TileControl Tile {

            get {
                if (_control == null) {
                    _control = new DevExpress.XtraEditors.TileControl();
                }
                return _control; 
            }

        }

        public void AddTileGroup(string name) {

            AddTileGroup(name, string.Empty);

        }

        public void AddTileGroup(string name, string title) {

            bool isExists = false;
            
            DevExpress.XtraEditors.TileControl control = _control;
            if (control == null)
            {
                _control = control = new DevExpress.XtraEditors.TileControl();
            }
            DevExpress.XtraEditors.TileGroup group = new DevExpress.XtraEditors.TileGroup();
            group.Name = name;
            group.Text = title;

            foreach (TileGroup tileGroup in control.Groups) {

                if (tileGroup.Name.Equals(name)) {
                    isExists = true;
                    break;
                }
            }

            if (! isExists )
                control.Groups.Add(group);
        }

        public void AddTileItem(string groupName, string tileName, string htmlContent) {

            DevExpress.XtraEditors.TileItem item = new DevExpress.XtraEditors.TileItem();
            foreach (TileGroup group in Tile.Groups) {
                if (groupName.Equals(group.Name)) {
                    item.Name = tileName;
                    item.Text = htmlContent;
                    item.IsLarge = true;
                    group.Items.Add(item);
                }
            }
        }

        public TileItem GetItemByName(string tileName) {
            TileItem temp = null;
            foreach (TileGroup group in Tile.Groups) {
                foreach (TileItem item in group.Items) {

                    if (item.Name.Equals(tileName)) {
                        temp = item;
                        break;
                    }
                }
            }

            return temp;
        }

        public void RemoveItemByName(string tileName) {

            foreach (TileGroup group in Tile.Groups)
            {
                foreach (TileItem item in group.Items)
                {

                    if (item.Name.Equals(tileName))
                    {
                        group.Items.Remove(item);
                        break;
                    }
                }
            }
        }

        public void Target(string tileName) {

            foreach (TileGroup group in Tile.Groups)
            {
                foreach (TileItem item in group.Items)
                {

                    if (item.Name.Equals(tileName))
                    {
                        TileItemElement element = new TileItemElement();
                        element.Text = "<size=10>已归档</size>";
                        element.TextAlignment = TileItemContentAlignment.BottomRight;
                        element.Image = Image.FromFile("Images/Paperclip.png");
                        element.ImageAlignment = TileItemContentAlignment.BottomRight;
                        element.ImageToTextAlignment = TileControlImageToTextAlignment.Left;
                        item.Elements.Add(element);
                        break;
                    }
                }
            }
        }
    }
}

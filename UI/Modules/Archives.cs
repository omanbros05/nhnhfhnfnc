using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using DevExpress.XtraEditors;
using SOA.ORM;
using Maleos.Controls;

namespace Maleos.Modules
{
    public partial class Archives : BasePage
    {
        TileBuilder _builder = new TileBuilder(false);
        public Archives()
        {
            InitializeComponent();
            Init();
        }

        void Init() {
            _builder.AddTileControl(this);
            TileControl control = _builder.Tile;
            control.RowCount = 3;
            control.ShowGroupText = true;
            control.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            control.ItemSize = 120;
            control.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            control.AllowDrag = false;
            control.ItemClick += new TileItemClickEventHandler(TileControl_ItemClick);

            CreateMenu(0);
        }

        private void DoBack(object sender, EventArgs e) {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

        private void CreateMenu(int param)
        {
            SOA.ORM.EList<SOA.ORM.Archive> archives = InvokeUtil.SystemService.ArchiveGetAll();
            StringBuilder textAppend = new StringBuilder();
            string source = string.Empty;
            foreach (SOA.ORM.Archive entity in archives.Items)
            {
                source = entity.Name;

                DateTime dateTime = entity.CreateTimes;
                _builder.AddTileGroup("group_" + dateTime.ToString("yyyyMM"), dateTime.ToString("yyyy/MM"));
                textAppend.Append("<size=14>");
                if (source.Length > 12)
                {
                    textAppend.Append(source.Substring(0, 12));
                    textAppend.Append("<br>");
                    textAppend.Append(source.Substring(12));
                }
                else
                {

                    textAppend.Append(source);
                }

                textAppend.Append("</size>");
                _builder.AddTileItem("group_" + dateTime.ToString("yyyyMM"), "item_" + entity.ID.ToString(), textAppend.ToString());
                textAppend.Clear();
                TileItem tileItem = _builder.GetItemByName("item_" + entity.ID.ToString());
                textAppend.Append("<size=10>");
                textAppend.Append(dateTime.ToString("yyyy年MM月dd日 HH:mm"));
                textAppend.Append("</size>");
                TileItemElement element = new TileItemElement();
                element.Text = textAppend.ToString();
                element.TextAlignment = TileItemContentAlignment.BottomLeft;
                tileItem.Elements.Add(element);

                if (entity.Status == 1)
                {
                    _builder.Target("item_" + entity.ID.ToString());
                }


                textAppend.Clear();
            }

            textAppend = null;
        }

        private void archiveFooter1_ButtonEventHandler(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ArchiveTypeManager"));
        }


        private void TileControl_ItemClick(object sender, TileItemEventArgs e)
        {
            string itemName = e.Item.Name;
            // 从itemName中截取ID值  item_1
            int id = Int32.Parse(itemName.Substring(5));
            // 传递参数到另外一个页面
            // e.Item.Group.Name
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ArchiveViewer", new object[] { id, e.Item.Text }));
        }
    }
}

using System;
using DevExpress.XtraEditors;
using EnforceUI;
using Maleos.Controls;
using System.Text;
using System.Drawing;

namespace Maleos.Modules
{
    public partial class ArchiveTypeManager : BasePage
    {
        TileBuilder _builder = new TileBuilder(true);

        public ArchiveTypeManager()
        {
            InitializeComponent();

            //Archive entity = new Archive();

            //entity.Name = "宁波振华信息科技有限公司日常检查";
            //entity.Status = 0;

            //InvokeUtil.SystemService.EntityUpdate(entity);
            Init();
        }

        void Init() {
            _builder.AddTileControl(this);
            TileControl control = _builder.Tile;
            control.ShowGroupText = true;
            control.RowCount = 3;
            control.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            control.ItemSize = 120;
            control.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            control.AllowDrag = false;
            control.ItemCheckedChanged += new TileItemClickEventHandler(control_RightItemClick);
            //control.ItemClick += new TileItemClickEventHandler(TileControl_ItemClick);
            CreateMenu(0);
        }

        private void DoBack(object sender, EventArgs e)
        {
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
                if (source.Length > 12) {
                    textAppend.Append(source.Substring(0, 12));
                    textAppend.Append("<br>");
                    textAppend.Append(source.Substring(12));
                } else {

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

                if (entity.Status == 1) {
                    _builder.Target("item_" + entity.ID.ToString());
                }


                textAppend.Clear();
            }

            textAppend = null;
        }
        private int _itemID;
        private void control_RightItemClick(object sender, TileItemEventArgs e) {
            byte status = 0;
            if (e.Item.Checked) {
                // TileItem.Name 组成规则 "item_" + Number
                _itemID = Int32.Parse(e.Item.Name.Substring(5));
                SOA.ORM.Archive entity = new SOA.ORM.Archive();
                status = entity.GetStatus(_itemID);
                if (status == 0)
                {
                    footer1.DeleteButtonVisible = true;
                    footer1.MarkButtonVisible = true;
                }
            } else {

                footer1.DeleteButtonVisible = false;
                footer1.MarkButtonVisible = false;
            }

            if (status == 1) {
                footer1.DeleteButtonVisible = false;
                footer1.MarkButtonVisible = false;
            }
        }

        //private void TileControl_ItemClick(object sender, TileItemEventArgs e) {
        //    string itemName = e.Item.Name;
        //    // 从itemName中截取ID值  item_1
        //    int id = Int32.Parse(itemName.Substring(5));
        //    // 传递参数到另外一个页面
        //    // e.Item.Group.Name
        //    OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ArchiveViewer", new object[]{ id, e.Item.Text }));
        //}

        private void footer1_AddEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.AddArchiveType"));
        }

        private void footer1_DeleteEvent(object sender, EventArgs e)
        {
            SOA.ORM.Archive entity = new SOA.ORM.Archive();
            entity.RemoveByID(_itemID);
            _builder.RemoveItemByName("item_" + _itemID.ToString());

            new SOA.ORM.ArchiveExtEntity().RemoveByID(_itemID);

            footer1.DeleteButtonVisible = false;
            footer1.MarkButtonVisible = false;
        }

        private void footer1_MarkEvent(object sender, EventArgs e)
        {
            SOA.ORM.Archive entity = new SOA.ORM.Archive();
            entity.UpdateByID(_itemID, 1);
            _builder.Target("item_" + _itemID.ToString());

            footer1.DeleteButtonVisible = false;
            footer1.MarkButtonVisible = false;
        }
    }
}

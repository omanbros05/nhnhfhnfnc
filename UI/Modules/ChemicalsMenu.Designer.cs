namespace Maleos.Modules
{
    partial class ChemicalsMenu
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.header1 = new Maleos.Controls.Header();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
            this.search1 = new Maleos.Controls.Search();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1103, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "危险化学品与剧毒化学品名录";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // tileControl1
            // 
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl1.Location = new System.Drawing.Point(0, 160);
            this.tileControl1.MaxId = 8;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.RowCount = 3;
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(1103, 713);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Items.Add(this.tileItem5);
            this.tileGroup2.Items.Add(this.tileItem6);
            this.tileGroup2.Items.Add(this.tileItem7);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "危险化学品名录";
            // 
            // tileItem1
            // 
            tileItemElement1.Text = "<size=14>爆炸品</size>";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 0;
            this.tileItem1.IsLarge = true;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "<size=14>压缩气体和液化气体</size>";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.IsLarge = true;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "<size=14>易燃液体</size>";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 2;
            this.tileItem3.IsLarge = true;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem4
            // 
            tileItemElement4.Text = "<size=14>易燃固体、自燃物品和遇<br>湿易燃物品</size>";
            this.tileItem4.Elements.Add(tileItemElement4);
            this.tileItem4.Id = 3;
            this.tileItem4.IsLarge = true;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem5
            // 
            tileItemElement5.Text = "<size=14>氧化剂和有机过氧化物</size>";
            this.tileItem5.Elements.Add(tileItemElement5);
            this.tileItem5.Id = 4;
            this.tileItem5.IsLarge = true;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem6
            // 
            tileItemElement6.Text = "<size=14>毒害品和感染性物品</size>";
            this.tileItem6.Elements.Add(tileItemElement6);
            this.tileItem6.Id = 5;
            this.tileItem6.IsLarge = true;
            this.tileItem6.Name = "tileItem6";
            this.tileItem6.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileItem7
            // 
            tileItemElement7.Text = "<size=14>腐蚀品</size>";
            this.tileItem7.Elements.Add(tileItemElement7);
            this.tileItem7.Id = 6;
            this.tileItem7.IsLarge = true;
            this.tileItem7.Name = "tileItem7";
            this.tileItem7.Tag = "EnforceForm.frmChemicalsLists";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem8);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "剧毒化学品名录";
            // 
            // tileItem8
            // 
            tileItemElement8.Text = "<size=14>剧毒化学品</size>";
            this.tileItem8.Elements.Add(tileItemElement8);
            this.tileItem8.Id = 7;
            this.tileItem8.IsLarge = true;
            this.tileItem8.Name = "tileItem8";
            this.tileItem8.Tag = "EnforceForm.frmChemicalsHighlyToxics";
            // 
            // search1
            // 
            this.search1.Appearance.BackColor = System.Drawing.Color.White;
            this.search1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.Appearance.Options.UseBackColor = true;
            this.search1.Appearance.Options.UseFont = true;
            this.search1.Dock = System.Windows.Forms.DockStyle.Top;
            this.search1.Location = new System.Drawing.Point(0, 75);
            this.search1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(1103, 76);
            this.search1.TabIndex = 2;
            this.search1.SearchClick += new System.EventHandler(this.search1_SearchClick);
            // 
            // ChemicalsMenu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search1);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "ChemicalsMenu";
            this.Size = new System.Drawing.Size(1103, 911);
            this.Resize += new System.EventHandler(this.ChemicalsMenu_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Header header1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem8;
        private Controls.Search search1;
    }
}

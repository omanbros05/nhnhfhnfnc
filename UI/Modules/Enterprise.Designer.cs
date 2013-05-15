namespace Maleos.Modules
{
    partial class Enterprise
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.header1 = new Maleos.Controls.Header();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1143, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "台州市安监管企业";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // tileControl1
            // 
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.AppearanceItem.Normal.Font = new System.Drawing.Font("宋体", 14F);
            this.tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl1.Location = new System.Drawing.Point(0, 75);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(1143, 633);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "企业列表";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem2);
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "企业信息补充";
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "企业类别";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.IsLarge = true;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.Tag = "EnforceForm.frmCompanyTypes";
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "基础信息维护";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 2;
            this.tileItem3.IsLarge = true;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.Tag = "EnforceForm.frmCompanys";
            // 
            // tileItem1
            // 
            tileItemElement1.Text = "企业管理";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 3;
            this.tileItem1.IsLarge = true;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Tag = "EnforceForm.frmCompanys";
            // 
            // Enterprise
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Enterprise";
            this.Size = new System.Drawing.Size(1143, 708);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Header header1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}

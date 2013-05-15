namespace Maleos.Modules
{
    partial class CheckMenu
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.header1 = new Maleos.Controls.Header();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.AppearanceGroupText.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold);
            this.tileControl1.AppearanceGroupText.Options.UseFont = true;
            this.tileControl1.AppearanceItem.Normal.Font = new System.Drawing.Font("华文宋体", 14F);
            this.tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 7;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.RowCount = 3;
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(1261, 754);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem6);
            this.tileGroup2.Items.Add(this.tileItem7);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "现场检查与处理";
            // 
            // tileItem1
            // 
            tileItemElement1.Text = "现场检查记录";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 0;
            this.tileItem1.IsLarge = true;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Tag = "EnforceForm.frmSpotChecks";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "现场处理措施决定书";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.IsLarge = true;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.Tag = "EnforceForm.frmSpotHandelDesisions";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileItem6
            // 
            tileItemElement3.Text = "强制措施决定书";
            this.tileItem6.Elements.Add(tileItemElement3);
            this.tileItem6.Id = 5;
            this.tileItem6.IsLarge = true;
            this.tileItem6.Name = "tileItem6";
            this.tileItem6.Tag = "EnforceForm.frmForceMeasureDecisions";
            this.tileItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileItem7
            // 
            tileItemElement4.Text = "强制措施决定审批";
            this.tileItem7.Elements.Add(tileItemElement4);
            this.tileItem7.Id = 6;
            this.tileItem7.IsLarge = true;
            this.tileItem7.Name = "tileItem7";
            this.tileItem7.Tag = "EnforceForm.frmForceMeasureDecisionApproves";
            this.tileItem7.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileItem3
            // 
            tileItemElement5.Text = "责令限期整改指令书";
            this.tileItem3.Elements.Add(tileItemElement5);
            this.tileItem3.Id = 2;
            this.tileItem3.IsLarge = true;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.Tag = "EnforceForm.frmOrderDeadlineReforms";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "整改复查";
            // 
            // tileItem4
            // 
            tileItemElement6.Text = "整改复查意见书";
            this.tileItem4.Elements.Add(tileItemElement6);
            this.tileItem4.Id = 3;
            this.tileItem4.IsLarge = true;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.Tag = "EnforceForm.frmReformReViews";
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileItem5);
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = "现场取照";
            // 
            // tileItem5
            // 
            tileItemElement7.Text = "现场照片粘贴";
            this.tileItem5.Elements.Add(tileItemElement7);
            this.tileItem5.Id = 4;
            this.tileItem5.IsLarge = true;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.Tag = "EnforceForm.frmSpotShoots";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ItemClick);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1261, 75);
            this.header1.TabIndex = 1;
            this.header1.Title = "执法检查";
            // 
            // CheckMenu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Controls.Add(this.tileControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "CheckMenu";
            this.Size = new System.Drawing.Size(1261, 754);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private Controls.Header header1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
    }
}

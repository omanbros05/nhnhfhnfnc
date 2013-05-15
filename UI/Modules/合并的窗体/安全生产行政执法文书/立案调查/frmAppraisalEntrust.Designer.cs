namespace EnforceForm
{
    partial class frmAppraisalEntrust
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppraisalEntrust));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.ContactUserPhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ContactUserName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.AppraisalPoints = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.AppraisalUnit = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SamplingContentGridViewItems = new EnforceUI.EnforceLawGridView(this.components);
            this.SDocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AppraisaDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label34 = new System.Windows.Forms.Label();
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.SamplingID = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingContentGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.SamplingID);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.AppraisaDate);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.ContactUserPhone);
            this.panelContent.Controls.Add(this.ContactUserName);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.label34);
            this.panelContent.Controls.Add(this.label35);
            this.panelContent.Controls.Add(this.AppraisalPoints);
            this.panelContent.Controls.Add(this.AppraisalUnit);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(804, 763);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 838);
            this.panel1.Size = new System.Drawing.Size(804, 42);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(804, 75);
            this.header1.Title = "鉴定委托书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管鉴〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(172, 135);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管鉴〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(307, 693);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 16);
            this.label27.TabIndex = 17;
            this.label27.Text = "联系电话：";
            // 
            // ContactUserPhone
            // 
            this.ContactUserPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContactUserPhone.BackColor = System.Drawing.Color.White;
            this.ContactUserPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactUserPhone.ControlText = "";
            this.ContactUserPhone.Location = new System.Drawing.Point(394, 694);
            this.ContactUserPhone.Name = "ContactUserPhone";
            this.ContactUserPhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactUserPhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.ContactUserPhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ContactUserPhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContactUserPhone.PopupWidth = 300;
            this.ContactUserPhone.Size = new System.Drawing.Size(258, 19);
            this.ContactUserPhone.TabIndex = 18;
            // 
            // ContactUserName
            // 
            this.ContactUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContactUserName.BackColor = System.Drawing.Color.White;
            this.ContactUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactUserName.ControlText = "";
            this.ContactUserName.Location = new System.Drawing.Point(90, 693);
            this.ContactUserName.Name = "ContactUserName";
            this.ContactUserName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactUserName.PopupOffset = new System.Drawing.Point(12, 0);
            this.ContactUserName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ContactUserName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContactUserName.PopupWidth = 300;
            this.ContactUserName.Size = new System.Drawing.Size(133, 19);
            this.ContactUserName.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 693);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "联系人：";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(25, 656);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 16);
            this.label35.TabIndex = 12;
            this.label35.Text = "请于";
            // 
            // AppraisalPoints
            // 
            this.AppraisalPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppraisalPoints.BackColor = System.Drawing.Color.White;
            this.AppraisalPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppraisalPoints.ControlText = "";
            this.AppraisalPoints.Location = new System.Drawing.Point(112, 610);
            this.AppraisalPoints.Name = "AppraisalPoints";
            this.AppraisalPoints.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppraisalPoints.PopupOffset = new System.Drawing.Point(12, 0);
            this.AppraisalPoints.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.AppraisalPoints.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AppraisalPoints.PopupWidth = 300;
            this.AppraisalPoints.Size = new System.Drawing.Size(540, 19);
            this.AppraisalPoints.TabIndex = 11;
            // 
            // AppraisalUnit
            // 
            this.AppraisalUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppraisalUnit.BackColor = System.Drawing.Color.White;
            this.AppraisalUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppraisalUnit.ControlText = "";
            this.AppraisalUnit.Location = new System.Drawing.Point(29, 183);
            this.AppraisalUnit.Name = "AppraisalUnit";
            this.AppraisalUnit.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppraisalUnit.PopupOffset = new System.Drawing.Point(12, 0);
            this.AppraisalUnit.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.AppraisalUnit.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AppraisalUnit.PopupWidth = 300;
            this.AppraisalUnit.Size = new System.Drawing.Size(252, 19);
            this.AppraisalUnit.TabIndex = 3;
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(471, 782);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(151, 26);
            this.FillDate.TabIndex = 20;
            this.FillDate.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 610);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 10;
            this.label24.Text = "鉴定要求：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(307, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(109, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "鉴定委托书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-24, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 229;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(247, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.SamplingContentGridViewItems);
            this.groupBox2.Location = new System.Drawing.Point(27, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 287);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "取证物品列表：";
            // 
            // SamplingContentGridViewItems
            // 
            this.SamplingContentGridViewItems.AllowUserToAddRows = false;
            this.SamplingContentGridViewItems.AutoUpdate = false;
            this.SamplingContentGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.SamplingContentGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingContentGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SamplingContentGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SDocTitle,
            this.ItemName,
            this.ItemRule,
            this.Count,
            this.ItemUnit});
            this.SamplingContentGridViewItems.Custom = false;
            this.SamplingContentGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SamplingContentGridViewItems.EntityType = null;
            this.SamplingContentGridViewItems.Location = new System.Drawing.Point(3, 22);
            this.SamplingContentGridViewItems.Name = "SamplingContentGridViewItems";
            this.SamplingContentGridViewItems.RowTemplate.Height = 23;
            this.SamplingContentGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SamplingContentGridViewItems.Size = new System.Drawing.Size(622, 262);
            this.SamplingContentGridViewItems.TabIndex = 0;
            // 
            // SDocTitle
            // 
            this.SDocTitle.HeaderText = "抽样编号";
            this.SDocTitle.Name = "SDocTitle";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "证据物品名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 160;
            // 
            // ItemRule
            // 
            this.ItemRule.HeaderText = "规格及批号";
            this.ItemRule.Name = "ItemRule";
            this.ItemRule.Width = 140;
            // 
            // Count
            // 
            this.Count.HeaderText = "数量";
            this.Count.Name = "Count";
            this.Count.Width = 80;
            // 
            // ItemUnit
            // 
            this.ItemUnit.HeaderText = "单位";
            this.ItemUnit.Name = "ItemUnit";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "行抽样取证。抽样取证凭证文号：";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(632, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "依据《中华人民共和国行政处罚法》第三十七条第二款规定，对被抽样取证单位的物品进";
            // 
            // AppraisaDate
            // 
            this.AppraisaDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppraisaDate.CustomFormat = "yyyy年M月d日";
            this.AppraisaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppraisaDate.Location = new System.Drawing.Point(72, 651);
            this.AppraisaDate.Name = "AppraisaDate";
            this.AppraisaDate.Size = new System.Drawing.Size(181, 26);
            this.AppraisaDate.TabIndex = 13;
            this.AppraisaDate.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(259, 656);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(232, 16);
            this.label34.TabIndex = 14;
            this.label34.Text = "前向本行政机关提交鉴定结果。";
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(407, 747);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 19;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SamplingID
            // 
            this.SamplingID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SamplingID.BackColor = System.Drawing.Color.White;
            this.SamplingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingID.ControlText = "";
            this.SamplingID.Location = new System.Drawing.Point(262, 267);
            this.SamplingID.Name = "SamplingID";
            this.SamplingID.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingID.PopupOffset = new System.Drawing.Point(12, 0);
            this.SamplingID.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SamplingID.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SamplingID.PopupWidth = 300;
            this.SamplingID.Size = new System.Drawing.Size(283, 19);
            this.SamplingID.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(551, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "显示物品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAppraisalEntrust
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmAppraisalEntrust";
            this.Size = new System.Drawing.Size(804, 880);
            this.Load += new System.EventHandler(this.frmAppraisalEntrust_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SamplingContentGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private System.Windows.Forms.Label label27;
        private EnforceUI.TableAutoCompleteTextBox ContactUserPhone;
        private EnforceUI.TableAutoCompleteTextBox ContactUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label35;
        private EnforceUI.TableAutoCompleteTextBox AppraisalPoints;
        private EnforceUI.TableAutoCompleteTextBox AppraisalUnit;
        private EnforceUI.TableDateTimePicker FillDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label11;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableDateTimePicker AppraisaDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label34;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.EnforceLawGridView SamplingContentGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.Button button1;
        private EnforceUI.TableAutoCompleteTextBox SamplingID;
    }
}

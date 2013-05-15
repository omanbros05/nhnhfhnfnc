namespace EnforceForm
{
    partial class frmEditCaseTransferred
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCaseTransferred));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.UnitName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TransferredDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TransferredReason = new EnforceUI.TableRichTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TransferredLaw = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CaseMaterial = new EnforceUI.TableRichTextBox(this.components);
            this.HandleDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.HandleDate);
            this.panelContent.Controls.Add(this.btnSelect);
            this.panelContent.Controls.Add(this.CaseMaterial);
            this.panelContent.Controls.Add(this.TransferredReason);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.TransferredDate);
            this.panelContent.Controls.Add(this.TransferredLaw);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.UnitName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 926);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1001);
            this.panel1.Size = new System.Drawing.Size(886, 44);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "案件移送书 > 编辑";
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
            this.DocTitle.ControlText = "(××)安监管移〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(204, 154);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 101;
            this.DocTitle.Text = "(××)安监管移〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(356, 121);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(109, 20);
            this.headerLabel2.TabIndex = 99;
            this.headerLabel2.Text = "案件移送书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(59, 109);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 100;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(312, 81);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 98;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // UnitName
            // 
            this.UnitName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitName.BackColor = System.Drawing.Color.White;
            this.UnitName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitName.ControlText = "";
            this.UnitName.Location = new System.Drawing.Point(59, 194);
            this.UnitName.Name = "UnitName";
            this.UnitName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitName.PopupOffset = new System.Drawing.Point(12, 0);
            this.UnitName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UnitName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UnitName.PopupWidth = 300;
            this.UnitName.Size = new System.Drawing.Size(399, 19);
            this.UnitName.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "本机关于";
            // 
            // TransferredDate
            // 
            this.TransferredDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TransferredDate.CustomFormat = "yyyy年M月d日";
            this.TransferredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransferredDate.Location = new System.Drawing.Point(161, 228);
            this.TransferredDate.Name = "TransferredDate";
            this.TransferredDate.Size = new System.Drawing.Size(168, 26);
            this.TransferredDate.TabIndex = 103;
            this.TransferredDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "：";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(336, 235);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(473, 19);
            this.CaseName.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "一案立案调查，因在调查中发现:";
            // 
            // TransferredReason
            // 
            this.TransferredReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TransferredReason.ControlText = "";
            this.TransferredReason.Location = new System.Drawing.Point(59, 300);
            this.TransferredReason.Name = "TransferredReason";
            this.TransferredReason.Size = new System.Drawing.Size(748, 215);
            this.TransferredReason.TabIndex = 106;
            this.TransferredReason.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "故此案已超出本行政机关管辖范围，根据";
            // 
            // TransferredLaw
            // 
            this.TransferredLaw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TransferredLaw.BackColor = System.Drawing.Color.White;
            this.TransferredLaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransferredLaw.ControlText = "";
            this.TransferredLaw.Location = new System.Drawing.Point(353, 524);
            this.TransferredLaw.Name = "TransferredLaw";
            this.TransferredLaw.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransferredLaw.PopupOffset = new System.Drawing.Point(12, 0);
            this.TransferredLaw.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TransferredLaw.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TransferredLaw.PopupWidth = 300;
            this.TransferredLaw.Size = new System.Drawing.Size(354, 19);
            this.TransferredLaw.TabIndex = 102;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(723, 521);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 23);
            this.btnSelect.TabIndex = 107;
            this.btnSelect.Text = "查询法律";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "的规定，现将该案件移送你单位，请依法处理。";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 104;
            this.label5.Text = "附该案件有关材料：";
            // 
            // CaseMaterial
            // 
            this.CaseMaterial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseMaterial.ControlText = "";
            this.CaseMaterial.Location = new System.Drawing.Point(59, 619);
            this.CaseMaterial.Name = "CaseMaterial";
            this.CaseMaterial.Size = new System.Drawing.Size(748, 151);
            this.CaseMaterial.TabIndex = 106;
            this.CaseMaterial.Text = "";
            // 
            // HandleDate
            // 
            this.HandleDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HandleDate.CustomFormat = "yyyy年M月d日";
            this.HandleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HandleDate.Location = new System.Drawing.Point(580, 842);
            this.HandleDate.Name = "HandleDate";
            this.HandleDate.Size = new System.Drawing.Size(168, 26);
            this.HandleDate.TabIndex = 108;
            this.HandleDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(529, 817);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 139;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditCaseTransferred
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditCaseTransferred";
            this.Size = new System.Drawing.Size(886, 1045);
            this.Load += new System.EventHandler(this.frmEditCaseTransferred_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox UnitName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker TransferredDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private EnforceUI.TableDateTimePicker HandleDate;
        private System.Windows.Forms.Button btnSelect;
        private EnforceUI.TableRichTextBox CaseMaterial;
        private EnforceUI.TableRichTextBox TransferredReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox TransferredLaw;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

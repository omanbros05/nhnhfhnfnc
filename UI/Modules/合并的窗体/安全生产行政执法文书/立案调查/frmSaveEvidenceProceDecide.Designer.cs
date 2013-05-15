namespace EnforceForm
{
    partial class frmSaveEvidenceProceDecide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEvidenceProceDecide));
            this.label10 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecideContent = new EnforceUI.TableRichTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FieldECompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.JData = new EnforceUI.TableDateTimePicker(this.components);
            this.SamplingContent = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.SaveEvidenceProceAuditDocTitle = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.LitigationUnitName3 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.LitigationUnitName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.LitigationUnitName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.LitigationUnitName3);
            this.panelContent.Controls.Add(this.LitigationUnitName2);
            this.panelContent.Controls.Add(this.LitigationUnitName1);
            this.panelContent.Controls.Add(this.SamplingContent);
            this.panelContent.Controls.Add(this.SaveEvidenceProceAuditDocTitle);
            this.panelContent.Controls.Add(this.JData);
            this.panelContent.Controls.Add(this.FieldECompanyName);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.label31);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(824, 616);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Size = new System.Drawing.Size(824, 43);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(824, 75);
            this.header1.Title = "先行登记保存证据处理决定书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 588);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "不停止执行，法律另有规定的除外。";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管先保处〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(190, 135);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 3;
            this.DocTitle.Text = "(××)安监管先保处〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(614, 471);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 16);
            this.label31.TabIndex = 18;
            this.label31.Text = "人民政府";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "法向";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "进行了先行登记保存[文号：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "如果不服本决定，可以依法在60日内向";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "等物品";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "本机关于";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(234, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(269, 20);
            this.headerLabel2.TabIndex = 2;
            this.headerLabel2.Text = "先行登记保存证据处理决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-6, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 286;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(265, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 1;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "日";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "]。";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.DecideContent);
            this.groupBox1.Location = new System.Drawing.Point(81, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 107);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "现依法对上述物品作出如下处理：";
            // 
            // DecideContent
            // 
            this.DecideContent.ControlText = "";
            this.DecideContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecideContent.Location = new System.Drawing.Point(3, 22);
            this.DecideContent.Name = "DecideContent";
            this.DecideContent.Size = new System.Drawing.Size(593, 82);
            this.DecideContent.TabIndex = 0;
            this.DecideContent.Text = "";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "或者";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "申请行政复议，或者在三个月内依";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "人民法院提起行政诉讼，但本决定";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "对你（单位）的";
            // 
            // FieldECompanyName
            // 
            this.FieldECompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldECompanyName.BackColor = System.Drawing.Color.White;
            this.FieldECompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.ControlText = "";
            this.FieldECompanyName.Location = new System.Drawing.Point(41, 173);
            this.FieldECompanyName.Name = "FieldECompanyName";
            this.FieldECompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldECompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldECompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldECompanyName.PopupWidth = 300;
            this.FieldECompanyName.Size = new System.Drawing.Size(275, 19);
            this.FieldECompanyName.TabIndex = 4;
            // 
            // JData
            // 
            this.JData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JData.CustomFormat = "yyyy年M月d日";
            this.JData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JData.Location = new System.Drawing.Point(118, 211);
            this.JData.Name = "JData";
            this.JData.Size = new System.Drawing.Size(158, 26);
            this.JData.TabIndex = 7;
            this.JData.Value = new System.DateTime(2013, 3, 10, 20, 58, 7, 346);
            // 
            // SamplingContent
            // 
            this.SamplingContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SamplingContent.BackColor = System.Drawing.Color.White;
            this.SamplingContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingContent.ControlText = "";
            this.SamplingContent.Location = new System.Drawing.Point(164, 261);
            this.SamplingContent.Name = "SamplingContent";
            this.SamplingContent.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingContent.PopupOffset = new System.Drawing.Point(12, 0);
            this.SamplingContent.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SamplingContent.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SamplingContent.PopupWidth = 300;
            this.SamplingContent.Size = new System.Drawing.Size(460, 19);
            this.SamplingContent.TabIndex = 10;
            // 
            // SaveEvidenceProceAuditDocTitle
            // 
            this.SaveEvidenceProceAuditDocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveEvidenceProceAuditDocTitle.BackColor = System.Drawing.Color.White;
            this.SaveEvidenceProceAuditDocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveEvidenceProceAuditDocTitle.ControlText = "";
            this.SaveEvidenceProceAuditDocTitle.Location = new System.Drawing.Point(238, 305);
            this.SaveEvidenceProceAuditDocTitle.Name = "SaveEvidenceProceAuditDocTitle";
            this.SaveEvidenceProceAuditDocTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveEvidenceProceAuditDocTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.SaveEvidenceProceAuditDocTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SaveEvidenceProceAuditDocTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveEvidenceProceAuditDocTitle.PopupWidth = 300;
            this.SaveEvidenceProceAuditDocTitle.Size = new System.Drawing.Size(174, 19);
            this.SaveEvidenceProceAuditDocTitle.TabIndex = 13;
            // 
            // LitigationUnitName3
            // 
            this.LitigationUnitName3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LitigationUnitName3.BackColor = System.Drawing.Color.White;
            this.LitigationUnitName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName3.ControlText = "";
            this.LitigationUnitName3.Location = new System.Drawing.Point(83, 553);
            this.LitigationUnitName3.Name = "LitigationUnitName3";
            this.LitigationUnitName3.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName3.PopupOffset = new System.Drawing.Point(12, 0);
            this.LitigationUnitName3.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LitigationUnitName3.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LitigationUnitName3.PopupWidth = 300;
            this.LitigationUnitName3.Size = new System.Drawing.Size(349, 19);
            this.LitigationUnitName3.TabIndex = 23;
            // 
            // LitigationUnitName2
            // 
            this.LitigationUnitName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LitigationUnitName2.BackColor = System.Drawing.Color.White;
            this.LitigationUnitName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName2.ControlText = "";
            this.LitigationUnitName2.Location = new System.Drawing.Point(83, 508);
            this.LitigationUnitName2.Name = "LitigationUnitName2";
            this.LitigationUnitName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.LitigationUnitName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LitigationUnitName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LitigationUnitName2.PopupWidth = 300;
            this.LitigationUnitName2.Size = new System.Drawing.Size(349, 19);
            this.LitigationUnitName2.TabIndex = 20;
            // 
            // LitigationUnitName1
            // 
            this.LitigationUnitName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LitigationUnitName1.BackColor = System.Drawing.Color.White;
            this.LitigationUnitName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName1.ControlText = "";
            this.LitigationUnitName1.Location = new System.Drawing.Point(367, 472);
            this.LitigationUnitName1.Name = "LitigationUnitName1";
            this.LitigationUnitName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.LitigationUnitName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LitigationUnitName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LitigationUnitName1.PopupWidth = 300;
            this.LitigationUnitName1.Size = new System.Drawing.Size(243, 19);
            this.LitigationUnitName1.TabIndex = 17;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(428, 616);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 26;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(498, 651);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(154, 26);
            this.FillDate.TabIndex = 27;
            this.FillDate.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // frmSaveEvidenceProceDecide
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSaveEvidenceProceDecide";
            this.Size = new System.Drawing.Size(824, 734);
            this.Load += new System.EventHandler(this.frmSaveEvidenceProceDecide_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableTextTitle DocTitle;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox DecideContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableAutoCompleteTextBox FieldECompanyName;
        private EnforceUI.TableDateTimePicker JData;
        private EnforceUI.TableAutoCompleteTextBox SamplingContent;
        private EnforceUI.TableAutoCompleteTextBox SaveEvidenceProceAuditDocTitle;
        private EnforceUI.TableAutoCompleteTextBox LitigationUnitName3;
        private EnforceUI.TableAutoCompleteTextBox LitigationUnitName2;
        private EnforceUI.TableAutoCompleteTextBox LitigationUnitName1;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker FillDate;

    }
}

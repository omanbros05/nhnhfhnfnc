namespace EnforceForm
{
    partial class frmSpotHandelDesision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpotHandelDesision));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.CheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CourtArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.ManageArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.GovArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.CID2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CID1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.OfficerName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.OfficerName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.SitHandel = new EnforceUI.TableRichTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.LegalBasis = new EnforceUI.TableTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.Violations = new EnforceUI.TableRichTextBox(this.components);
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
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.CheckDate);
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.CourtArea);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.ManageArea);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.GovArea);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.CID2);
            this.panelContent.Controls.Add(this.CID1);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.OfficerName2);
            this.panelContent.Controls.Add(this.OfficerName1);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.SitHandel);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.LegalBasis);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.Violations);
            this.panelContent.Size = new System.Drawing.Size(893, 675);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 750);
            this.panel1.Size = new System.Drawing.Size(893, 45);
            this.panel1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(893, 75);
            this.header1.Title = "现场处理措施决定书 > 编辑";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // btnLaw
            // 
            this.btnLaw.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管现决〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(123, 135);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管现决〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckDate
            // 
            this.CheckDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckDate.CustomFormat = "yyyy年M月d日";
            this.CheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckDate.Location = new System.Drawing.Point(65, 197);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.Size = new System.Drawing.Size(155, 26);
            this.CheckDate.TabIndex = 5;
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(483, 720);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(143, 26);
            this.DocDate.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "人民法院提起行政诉讼，";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-62, 576);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(328, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "但本决定不停止执行，法律另有规定的除外。";
            // 
            // CourtArea
            // 
            this.CourtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CourtArea.BackColor = System.Drawing.Color.White;
            this.CourtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.ControlText = "";
            this.CourtArea.Location = new System.Drawing.Point(229, 530);
            this.CourtArea.Name = "CourtArea";
            this.CourtArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.CourtArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CourtArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CourtArea.PopupWidth = 300;
            this.CourtArea.Size = new System.Drawing.Size(219, 19);
            this.CourtArea.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-60, 533);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // ManageArea
            // 
            this.ManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageArea.BackColor = System.Drawing.Color.White;
            this.ManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.ControlText = "";
            this.ManageArea.Location = new System.Drawing.Point(458, 495);
            this.ManageArea.Name = "ManageArea";
            this.ManageArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.ManageArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ManageArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageArea.PopupWidth = 300;
            this.ManageArea.Size = new System.Drawing.Size(194, 19);
            this.ManageArea.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 498);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "人民政府或者";
            // 
            // GovArea
            // 
            this.GovArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GovArea.BackColor = System.Drawing.Color.White;
            this.GovArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.ControlText = "";
            this.GovArea.Location = new System.Drawing.Point(229, 495);
            this.GovArea.Name = "GovArea";
            this.GovArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.GovArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.GovArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GovArea.PopupWidth = 300;
            this.GovArea.Size = new System.Drawing.Size(112, 19);
            this.GovArea.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-60, 498);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(280, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "如果不服本决定，可以依法在60日内向";
            // 
            // CID2
            // 
            this.CID2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID2.BackColor = System.Drawing.Color.White;
            this.CID2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.ControlText = "";
            this.CID2.Location = new System.Drawing.Point(398, 633);
            this.CID2.Name = "CID2";
            this.CID2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID2.PopupWidth = 300;
            this.CID2.Size = new System.Drawing.Size(242, 19);
            this.CID2.TabIndex = 26;
            // 
            // CID1
            // 
            this.CID1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID1.BackColor = System.Drawing.Color.White;
            this.CID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.ControlText = "";
            this.CID1.Location = new System.Drawing.Point(398, 604);
            this.CID1.Name = "CID1";
            this.CID1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID1.PopupWidth = 300;
            this.CID1.Size = new System.Drawing.Size(242, 19);
            this.CID1.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(348, 636);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "证号：";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(348, 604);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "证号：";
            // 
            // OfficerName2
            // 
            this.OfficerName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName2.BackColor = System.Drawing.Color.White;
            this.OfficerName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.ControlText = "";
            this.OfficerName2.Location = new System.Drawing.Point(160, 633);
            this.OfficerName2.Name = "OfficerName2";
            this.OfficerName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName2.PopupWidth = 300;
            this.OfficerName2.Size = new System.Drawing.Size(169, 19);
            this.OfficerName2.TabIndex = 24;
            this.OfficerName2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName2_SelectedValueChangedEvent);
            // 
            // OfficerName1
            // 
            this.OfficerName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName1.BackColor = System.Drawing.Color.White;
            this.OfficerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.ControlText = "";
            this.OfficerName1.Location = new System.Drawing.Point(160, 604);
            this.OfficerName1.Name = "OfficerName1";
            this.OfficerName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName1.PopupWidth = 300;
            this.OfficerName1.Size = new System.Drawing.Size(169, 19);
            this.OfficerName1.TabIndex = 21;
            this.OfficerName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName1_SelectedValueChangedEvent);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-15, 607);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "安全生产监管执法人员：";
            // 
            // SitHandel
            // 
            this.SitHandel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SitHandel.ControlText = "";
            this.SitHandel.Location = new System.Drawing.Point(-57, 395);
            this.SitHandel.Name = "SitHandel";
            this.SitHandel.Size = new System.Drawing.Size(700, 94);
            this.SitHandel.TabIndex = 11;
            this.SitHandel.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-60, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "的规定，现作出如下现场处理决定：";
            // 
            // LegalBasis
            // 
            this.LegalBasis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LegalBasis.BackColor = System.Drawing.Color.White;
            this.LegalBasis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LegalBasis.ControlText = "";
            this.LegalBasis.Location = new System.Drawing.Point(237, 341);
            this.LegalBasis.Name = "LegalBasis";
            this.LegalBasis.Size = new System.Drawing.Size(403, 19);
            this.LegalBasis.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-60, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "以上存在的问题无法保证安全生产，依据";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "现场检查时，发现你单位有下列违法违规行为和事故隐患：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "我局于";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(-57, 166);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(308, 19);
            this.CompanyName.TabIndex = 3;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(208, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(189, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "现场处理措施决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-48, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 67;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(198, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(332, 684);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 27;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Violations
            // 
            this.Violations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Violations.ControlText = "";
            this.Violations.Location = new System.Drawing.Point(-58, 239);
            this.Violations.Name = "Violations";
            this.Violations.Size = new System.Drawing.Size(700, 94);
            this.Violations.TabIndex = 70;
            this.Violations.Text = "";
            // 
            // frmSpotHandelDesision
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSpotHandelDesision";
            this.Size = new System.Drawing.Size(893, 795);
            this.Load += new System.EventHandler(this.frmSpotHandelDesision_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableDateTimePicker CheckDate;
        private EnforceUI.TableDateTimePicker DocDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox CourtArea;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableAutoCompleteTextBox ManageArea;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox GovArea;
        private System.Windows.Forms.Label label16;
        private EnforceUI.TableAutoCompleteTextBox CID2;
        private EnforceUI.TableAutoCompleteTextBox CID1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox OfficerName2;
        private EnforceUI.TableAutoCompleteTextBox OfficerName1;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableRichTextBox SitHandel;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableTextBox LegalBasis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableRichTextBox Violations;

    }
}

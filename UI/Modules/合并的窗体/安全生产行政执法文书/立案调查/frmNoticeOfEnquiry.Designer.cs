namespace EnforceForm
{
    partial class frmNoticeOfEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoticeOfEnquiry));
            this.ToAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ToDateTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IllegalTypeName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IfOther = new EnforceUI.TableCheckBox(this.components);
            this.IfLawID = new EnforceUI.TableCheckBox(this.components);
            this.IfBusinessLicense = new EnforceUI.TableCheckBox(this.components);
            this.OtherDocument = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.IfID = new EnforceUI.TableCheckBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DetpName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DetpPhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DetpAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.ToAddress);
            this.panelContent.Controls.Add(this.DetpAddress);
            this.panelContent.Controls.Add(this.DetpPhone);
            this.panelContent.Controls.Add(this.DetpName);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.ToDateTime);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.IllegalTypeName);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(848, 612);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 687);
            this.panel1.Size = new System.Drawing.Size(848, 43);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(848, 75);
            this.header1.TabIndex = 2;
            this.header1.Title = "询问通知书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // ToAddress
            // 
            this.ToAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToAddress.BackColor = System.Drawing.Color.White;
            this.ToAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToAddress.ControlText = "";
            this.ToAddress.Location = new System.Drawing.Point(58, 258);
            this.ToAddress.Name = "ToAddress";
            this.ToAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.ToAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ToAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ToAddress.PopupWidth = 300;
            this.ToAddress.Size = new System.Drawing.Size(338, 19);
            this.ToAddress.TabIndex = 11;
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(21, 173);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(208, 19);
            this.CompanyName.TabIndex = 3;
            // 
            // ToDateTime
            // 
            this.ToDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToDateTime.CustomFormat = "yyyy年M月d日 H时";
            this.ToDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTime.Location = new System.Drawing.Point(472, 211);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(177, 26);
            this.ToDateTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "请你于";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "，";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "接受询问调查";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "时到";
            // 
            // IllegalTypeName
            // 
            this.IllegalTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IllegalTypeName.BackColor = System.Drawing.Color.White;
            this.IllegalTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.ControlText = "";
            this.IllegalTypeName.Location = new System.Drawing.Point(74, 217);
            this.IllegalTypeName.Name = "IllegalTypeName";
            this.IllegalTypeName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.PopupOffset = new System.Drawing.Point(12, 0);
            this.IllegalTypeName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.IllegalTypeName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.IllegalTypeName.PopupWidth = 300;
            this.IllegalTypeName.Size = new System.Drawing.Size(322, 19);
            this.IllegalTypeName.TabIndex = 6;
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管询〔2012〕1号";
            this.DocTitle.Location = new System.Drawing.Point(161, 140);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管询〔2012〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(275, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(109, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "询问通知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-36, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 114;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(235, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "因";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(22, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 197);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案件基本情况：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.IfOther);
            this.panel3.Controls.Add(this.IfLawID);
            this.panel3.Controls.Add(this.IfBusinessLicense);
            this.panel3.Controls.Add(this.OtherDocument);
            this.panel3.Controls.Add(this.IfID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 172);
            this.panel3.TabIndex = 0;
            // 
            // IfOther
            // 
            this.IfOther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IfOther.AutoSize = true;
            this.IfOther.ControlText = "False";
            this.IfOther.Location = new System.Drawing.Point(33, 128);
            this.IfOther.Name = "IfOther";
            this.IfOther.Size = new System.Drawing.Size(15, 14);
            this.IfOther.TabIndex = 3;
            this.IfOther.UseVisualStyleBackColor = true;
            // 
            // IfLawID
            // 
            this.IfLawID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IfLawID.AutoSize = true;
            this.IfLawID.ControlText = "False";
            this.IfLawID.Location = new System.Drawing.Point(33, 92);
            this.IfLawID.Name = "IfLawID";
            this.IfLawID.Size = new System.Drawing.Size(171, 20);
            this.IfLawID.TabIndex = 2;
            this.IfLawID.Text = "法定代表人身份证明";
            this.IfLawID.UseVisualStyleBackColor = true;
            // 
            // IfBusinessLicense
            // 
            this.IfBusinessLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IfBusinessLicense.AutoSize = true;
            this.IfBusinessLicense.ControlText = "False";
            this.IfBusinessLicense.Location = new System.Drawing.Point(33, 58);
            this.IfBusinessLicense.Name = "IfBusinessLicense";
            this.IfBusinessLicense.Size = new System.Drawing.Size(91, 20);
            this.IfBusinessLicense.TabIndex = 1;
            this.IfBusinessLicense.Text = "营业执照";
            this.IfBusinessLicense.UseVisualStyleBackColor = true;
            // 
            // OtherDocument
            // 
            this.OtherDocument.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OtherDocument.BackColor = System.Drawing.Color.White;
            this.OtherDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OtherDocument.ControlText = "";
            this.OtherDocument.Location = new System.Drawing.Point(57, 126);
            this.OtherDocument.Name = "OtherDocument";
            this.OtherDocument.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OtherDocument.PopupOffset = new System.Drawing.Point(12, 0);
            this.OtherDocument.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OtherDocument.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OtherDocument.PopupWidth = 300;
            this.OtherDocument.Size = new System.Drawing.Size(543, 19);
            this.OtherDocument.TabIndex = 4;
            // 
            // IfID
            // 
            this.IfID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IfID.AutoSize = true;
            this.IfID.ControlText = "False";
            this.IfID.Location = new System.Drawing.Point(33, 25);
            this.IfID.Name = "IfID";
            this.IfID.Size = new System.Drawing.Size(75, 20);
            this.IfID.TabIndex = 0;
            this.IfID.Text = "身份证";
            this.IfID.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "安全生产监督管理部门地址：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "联系人：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "联系电话：";
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(458, 642);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(167, 26);
            this.FillDate.TabIndex = 21;
            // 
            // DetpName
            // 
            this.DetpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetpName.BackColor = System.Drawing.Color.White;
            this.DetpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpName.ControlText = "";
            this.DetpName.Location = new System.Drawing.Point(116, 555);
            this.DetpName.Name = "DetpName";
            this.DetpName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpName.PopupOffset = new System.Drawing.Point(12, 0);
            this.DetpName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DetpName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DetpName.PopupWidth = 300;
            this.DetpName.Size = new System.Drawing.Size(197, 19);
            this.DetpName.TabIndex = 17;
            // 
            // DetpPhone
            // 
            this.DetpPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetpPhone.BackColor = System.Drawing.Color.White;
            this.DetpPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpPhone.ControlText = "";
            this.DetpPhone.Location = new System.Drawing.Point(419, 555);
            this.DetpPhone.Name = "DetpPhone";
            this.DetpPhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpPhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.DetpPhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DetpPhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DetpPhone.PopupWidth = 300;
            this.DetpPhone.Size = new System.Drawing.Size(231, 19);
            this.DetpPhone.TabIndex = 19;
            // 
            // DetpAddress
            // 
            this.DetpAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetpAddress.BackColor = System.Drawing.Color.White;
            this.DetpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpAddress.ControlText = "";
            this.DetpAddress.Location = new System.Drawing.Point(260, 519);
            this.DetpAddress.Name = "DetpAddress";
            this.DetpAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetpAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.DetpAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DetpAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DetpAddress.PopupWidth = 300;
            this.DetpAddress.Size = new System.Drawing.Size(390, 19);
            this.DetpAddress.TabIndex = 15;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(402, 612);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 20;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 137;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNoticeOfEnquiry
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNoticeOfEnquiry";
            this.Size = new System.Drawing.Size(848, 730);
            this.Load += new System.EventHandler(this.frmNoticeOfEnquiry_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox ToAddress;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.TableDateTimePicker ToDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox IllegalTypeName;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableAutoCompleteTextBox DetpAddress;
        private EnforceUI.TableAutoCompleteTextBox DetpPhone;
        private EnforceUI.TableAutoCompleteTextBox DetpName;
        private EnforceUI.TableDateTimePicker FillDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private EnforceUI.TableCheckBox IfOther;
        private EnforceUI.TableCheckBox IfLawID;
        private EnforceUI.TableCheckBox IfBusinessLicense;
        private EnforceUI.TableAutoCompleteTextBox OtherDocument;
        private EnforceUI.TableCheckBox IfID;
        private System.Windows.Forms.Button button1;
    }
}

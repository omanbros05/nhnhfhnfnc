namespace EnforceForm
{
    partial class frmEditContributeFine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditContributeFine));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ContributionsDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InstrumentNo = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FineSum = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtensionDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Period = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.InstallmentsDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.InstallmentsSum = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.InstallmentsBalance = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.FormDate);
            this.panelContent.Controls.Add(this.InstallmentsDate);
            this.panelContent.Controls.Add(this.ExtensionDate);
            this.panelContent.Controls.Add(this.ContributionsDate);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.FineSum);
            this.panelContent.Controls.Add(this.InstallmentsBalance);
            this.panelContent.Controls.Add(this.InstallmentsSum);
            this.panelContent.Controls.Add(this.Period);
            this.panelContent.Controls.Add(this.InstrumentNo);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 590);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Size = new System.Drawing.Size(886, 35);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
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
            this.DocTitle.ControlText = "(××)安监管缴批〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(164, 151);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 109;
            this.DocTitle.Text = "(××)安监管缴批〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(243, 113);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(269, 20);
            this.headerLabel2.TabIndex = 107;
            this.headerLabel2.Text = "延期（分期）缴纳罚款批准书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(24, 106);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 108;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(277, 81);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 106;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(24, 190);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(399, 19);
            this.CompanyName.TabIndex = 110;
            // 
            // ContributionsDate
            // 
            this.ContributionsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContributionsDate.CustomFormat = "yyyy年M月d日";
            this.ContributionsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ContributionsDate.Location = new System.Drawing.Point(56, 226);
            this.ContributionsDate.Name = "ContributionsDate";
            this.ContributionsDate.Size = new System.Drawing.Size(168, 26);
            this.ContributionsDate.TabIndex = 112;
            this.ContributionsDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "，本机关对你（单位）发出";
            // 
            // InstrumentNo
            // 
            this.InstrumentNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstrumentNo.BackColor = System.Drawing.Color.White;
            this.InstrumentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstrumentNo.ControlText = "";
            this.InstrumentNo.Location = new System.Drawing.Point(422, 228);
            this.InstrumentNo.Name = "InstrumentNo";
            this.InstrumentNo.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstrumentNo.PopupOffset = new System.Drawing.Point(12, 0);
            this.InstrumentNo.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.InstrumentNo.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.InstrumentNo.PopupWidth = 300;
            this.InstrumentNo.Size = new System.Drawing.Size(347, 19);
            this.InstrumentNo.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "号《行政处罚决定书》，作出了对你（单位）罚款";
            // 
            // FineSum
            // 
            this.FineSum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FineSum.BackColor = System.Drawing.Color.White;
            this.FineSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FineSum.ControlText = "";
            this.FineSum.Location = new System.Drawing.Point(387, 266);
            this.FineSum.Name = "FineSum";
            this.FineSum.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FineSum.PopupOffset = new System.Drawing.Point(12, 0);
            this.FineSum.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FineSum.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FineSum.PopupWidth = 300;
            this.FineSum.Size = new System.Drawing.Size(382, 19);
            this.FineSum.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(760, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "（大写）的决定，现根据你（单位）的申请，本机关依据《中华人民共和国行政处罚法》第五十二条的规定";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "，同意你（单位）：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "□延期缴纳罚款。延长至";
            // 
            // ExtensionDate
            // 
            this.ExtensionDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtensionDate.CustomFormat = "yyyy年M月d日";
            this.ExtensionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExtensionDate.Location = new System.Drawing.Point(243, 366);
            this.ExtensionDate.Name = "ExtensionDate";
            this.ExtensionDate.Size = new System.Drawing.Size(168, 26);
            this.ExtensionDate.TabIndex = 112;
            this.ExtensionDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "（大写）止。";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "□分期缴纳罚款。第";
            // 
            // Period
            // 
            this.Period.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Period.BackColor = System.Drawing.Color.White;
            this.Period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Period.ControlText = "";
            this.Period.Location = new System.Drawing.Point(204, 402);
            this.Period.Name = "Period";
            this.Period.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Period.PopupOffset = new System.Drawing.Point(12, 0);
            this.Period.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Period.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Period.PopupWidth = 300;
            this.Period.Size = new System.Drawing.Size(84, 19);
            this.Period.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 113;
            this.label9.Text = "期至";
            // 
            // InstallmentsDate
            // 
            this.InstallmentsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstallmentsDate.CustomFormat = "yyyy年M月d日";
            this.InstallmentsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InstallmentsDate.Location = new System.Drawing.Point(331, 399);
            this.InstallmentsDate.Name = "InstallmentsDate";
            this.InstallmentsDate.Size = new System.Drawing.Size(168, 26);
            this.InstallmentsDate.TabIndex = 112;
            this.InstallmentsDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 16);
            this.label10.TabIndex = 113;
            this.label10.Text = "（大写）前，缴纳罚款";
            // 
            // InstallmentsSum
            // 
            this.InstallmentsSum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstallmentsSum.BackColor = System.Drawing.Color.White;
            this.InstallmentsSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstallmentsSum.ControlText = "";
            this.InstallmentsSum.Location = new System.Drawing.Point(668, 402);
            this.InstallmentsSum.Name = "InstallmentsSum";
            this.InstallmentsSum.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstallmentsSum.PopupOffset = new System.Drawing.Point(12, 0);
            this.InstallmentsSum.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.InstallmentsSum.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.InstallmentsSum.PopupWidth = 300;
            this.InstallmentsSum.Size = new System.Drawing.Size(113, 19);
            this.InstallmentsSum.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(504, 16);
            this.label11.TabIndex = 113;
            this.label11.Text = "元（大写）（每期均应当单独开具本文书）。此外，尚有未缴纳的罚款";
            // 
            // InstallmentsBalance
            // 
            this.InstallmentsBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstallmentsBalance.BackColor = System.Drawing.Color.White;
            this.InstallmentsBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstallmentsBalance.ControlText = "";
            this.InstallmentsBalance.Location = new System.Drawing.Point(525, 435);
            this.InstallmentsBalance.Name = "InstallmentsBalance";
            this.InstallmentsBalance.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstallmentsBalance.PopupOffset = new System.Drawing.Point(12, 0);
            this.InstallmentsBalance.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.InstallmentsBalance.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.InstallmentsBalance.PopupWidth = 300;
            this.InstallmentsBalance.Size = new System.Drawing.Size(157, 19);
            this.InstallmentsBalance.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(312, 16);
            this.label13.TabIndex = 113;
            this.label13.Text = "代收机构以本批准书为据，办理收款手续。";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 511);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(728, 16);
            this.label14.TabIndex = 113;
            this.label14.Text = "逾期缴纳罚款的，依据《中华人民共和国行政处罚法》第五十一条第（一）项的规定，每日按罚款数额";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(360, 16);
            this.label15.TabIndex = 113;
            this.label15.Text = "的3%加处罚款。加处的罚款由代收机构直接收缴。";
            // 
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(593, 616);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(168, 26);
            this.FormDate.TabIndex = 112;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(538, 591);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 114;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(688, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 115;
            this.label12.Text = "元（大写）。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditContributeFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditContributeFine";
            this.Size = new System.Drawing.Size(886, 700);
            this.Load += new System.EventHandler(this.frmContributeFine_Load);
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
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.TableDateTimePicker ContributionsDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker InstallmentsDate;
        private EnforceUI.TableDateTimePicker ExtensionDate;
        private EnforceUI.TableAutoCompleteTextBox FineSum;
        private EnforceUI.TableAutoCompleteTextBox Period;
        private EnforceUI.TableAutoCompleteTextBox InstrumentNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableAutoCompleteTextBox InstallmentsBalance;
        private EnforceUI.TableAutoCompleteTextBox InstallmentsSum;
        private EnforceUI.TableTextTitle DocManageArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

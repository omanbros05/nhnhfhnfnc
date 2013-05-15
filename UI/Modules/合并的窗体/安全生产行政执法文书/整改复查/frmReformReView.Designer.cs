namespace EnforceForm
{
    partial class frmReformReView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReformReView));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ReviewCompany = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Decide = new EnforceUI.TableTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.DocTitle2 = new EnforceUI.TableTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.Idea = new EnforceUI.TableRichTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CID2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CID1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.OfficerName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.OfficerName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
            this.ReviewDate = new EnforceUI.TableDateTimePicker(this.components);
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
            this.panelContent.Controls.Add(this.ReviewDate);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.CID2);
            this.panelContent.Controls.Add(this.CID1);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.OfficerName2);
            this.panelContent.Controls.Add(this.OfficerName1);
            this.panelContent.Controls.Add(this.label23);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.Idea);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.DocTitle2);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.Decide);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.ReviewCompany);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(826, 524);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Size = new System.Drawing.Size(826, 43);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(826, 75);
            this.header1.Title = "整改复查意见书 > 编辑";
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
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(266, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "整改复查意见书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-10, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 33;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(236, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "：";
            // 
            // ReviewCompany
            // 
            this.ReviewCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReviewCompany.BackColor = System.Drawing.Color.White;
            this.ReviewCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReviewCompany.ControlText = "";
            this.ReviewCompany.Location = new System.Drawing.Point(19, 172);
            this.ReviewCompany.Name = "ReviewCompany";
            this.ReviewCompany.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReviewCompany.PopupOffset = new System.Drawing.Point(12, 0);
            this.ReviewCompany.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ReviewCompany.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReviewCompany.PopupWidth = 300;
            this.ReviewCompany.Size = new System.Drawing.Size(283, 19);
            this.ReviewCompany.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "本机关于";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "作出了";
            // 
            // Decide
            // 
            this.Decide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decide.BackColor = System.Drawing.Color.White;
            this.Decide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Decide.ControlText = "责令限期整改";
            this.Decide.Location = new System.Drawing.Point(433, 207);
            this.Decide.Name = "Decide";
            this.Decide.Size = new System.Drawing.Size(171, 19);
            this.Decide.TabIndex = 8;
            this.Decide.Text = "责令限期整改";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "的决定";
            // 
            // DocTitle2
            // 
            this.DocTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle2.BackColor = System.Drawing.Color.White;
            this.DocTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle2.ControlText = "[(××)安监管 责改 〔2012〕1号]";
            this.DocTitle2.Location = new System.Drawing.Point(19, 241);
            this.DocTitle2.Name = "DocTitle2";
            this.DocTitle2.Size = new System.Drawing.Size(252, 19);
            this.DocTitle2.TabIndex = 10;
            this.DocTitle2.Text = "[(××)安监管 责改 〔2012〕1号]";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "，经对你单位整改情况进行复查，提出如下意见：";
            // 
            // Idea
            // 
            this.Idea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Idea.ControlText = "";
            this.Idea.Location = new System.Drawing.Point(19, 266);
            this.Idea.Name = "Idea";
            this.Idea.Size = new System.Drawing.Size(657, 125);
            this.Idea.TabIndex = 12;
            this.Idea.Text = "";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "希望你单位继续加强对事故隐患的排查治理，健全隐患排查治理长效机制，一旦";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(456, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "发现生产安全事故隐患，应及时予以整改消除，确保生产安全。";
            // 
            // CID2
            // 
            this.CID2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID2.BackColor = System.Drawing.Color.White;
            this.CID2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.ControlText = "";
            this.CID2.Location = new System.Drawing.Point(461, 496);
            this.CID2.Name = "CID2";
            this.CID2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID2.PopupWidth = 300;
            this.CID2.Size = new System.Drawing.Size(224, 19);
            this.CID2.TabIndex = 21;
            // 
            // CID1
            // 
            this.CID1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID1.BackColor = System.Drawing.Color.White;
            this.CID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.ControlText = "";
            this.CID1.Location = new System.Drawing.Point(461, 467);
            this.CID1.Name = "CID1";
            this.CID1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID1.PopupWidth = 300;
            this.CID1.Size = new System.Drawing.Size(224, 19);
            this.CID1.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(399, 499);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "证号：";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(399, 467);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 17;
            this.label22.Text = "证号：";
            // 
            // OfficerName2
            // 
            this.OfficerName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName2.BackColor = System.Drawing.Color.White;
            this.OfficerName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.ControlText = "";
            this.OfficerName2.Location = new System.Drawing.Point(211, 496);
            this.OfficerName2.Name = "OfficerName2";
            this.OfficerName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName2.PopupWidth = 300;
            this.OfficerName2.Size = new System.Drawing.Size(169, 19);
            this.OfficerName2.TabIndex = 19;
            this.OfficerName2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName2_SelectedValueChangedEvent);
            // 
            // OfficerName1
            // 
            this.OfficerName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName1.BackColor = System.Drawing.Color.White;
            this.OfficerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.ControlText = "";
            this.OfficerName1.Location = new System.Drawing.Point(211, 467);
            this.OfficerName1.Name = "OfficerName1";
            this.OfficerName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName1.PopupWidth = 300;
            this.OfficerName1.Size = new System.Drawing.Size(169, 19);
            this.OfficerName1.TabIndex = 16;
            this.OfficerName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName1_SelectedValueChangedEvent);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 467);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "安全生产监管执法人员：";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管复查〔2012〕1号";
            this.DocTitle.Location = new System.Drawing.Point(161, 133);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管复查〔2012〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(373, 538);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 22;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(533, 574);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(143, 26);
            this.DocDate.TabIndex = 23;
            // 
            // ReviewDate
            // 
            this.ReviewDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReviewDate.CustomFormat = "yyyy年M月d日";
            this.ReviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReviewDate.Location = new System.Drawing.Point(171, 202);
            this.ReviewDate.Name = "ReviewDate";
            this.ReviewDate.Size = new System.Drawing.Size(194, 26);
            this.ReviewDate.TabIndex = 6;
            // 
            // frmReformReView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmReformReView";
            this.Size = new System.Drawing.Size(826, 642);
            this.Load += new System.EventHandler(this.frmReformReView_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox ReviewCompany;
        private EnforceUI.TableRichTextBox Idea;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableTextBox DocTitle2;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableTextBox Decide;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private EnforceUI.TableAutoCompleteTextBox CID2;
        private EnforceUI.TableAutoCompleteTextBox CID1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private EnforceUI.TableAutoCompleteTextBox OfficerName2;
        private EnforceUI.TableAutoCompleteTextBox OfficerName1;
        private System.Windows.Forms.Label label23;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker DocDate;
        private EnforceUI.TableDateTimePicker ReviewDate;
    }
}

namespace EnforceForm
{
    partial class frmEditFineCallsNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFineCallsNotice));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SendCallsDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DecideNumber = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Location = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
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
            this.panelContent.Controls.Add(this.FormDate);
            this.panelContent.Controls.Add(this.EndDate);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.SendCallsDate);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.Location);
            this.panelContent.Controls.Add(this.DecideNumber);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 380);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Size = new System.Drawing.Size(886, 45);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "罚款催缴通知书 > 编辑";
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
            this.DocTitle.ControlText = "(××)安监管催〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(155, 152);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 105;
            this.DocTitle.Text = "(××)安监管催〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(288, 119);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 103;
            this.headerLabel2.Text = "罚款催缴通知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(15, 107);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 104;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(268, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 102;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(15, 193);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(399, 19);
            this.CompanyName.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "本机关于";
            // 
            // SendCallsDate
            // 
            this.SendCallsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SendCallsDate.CustomFormat = "yyyy年M月d日";
            this.SendCallsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SendCallsDate.Location = new System.Drawing.Point(121, 222);
            this.SendCallsDate.Name = "SendCallsDate";
            this.SendCallsDate.Size = new System.Drawing.Size(168, 26);
            this.SendCallsDate.TabIndex = 108;
            this.SendCallsDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 109;
            this.label2.Text = "发出";
            // 
            // DecideNumber
            // 
            this.DecideNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DecideNumber.BackColor = System.Drawing.Color.White;
            this.DecideNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecideNumber.ControlText = "";
            this.DecideNumber.Location = new System.Drawing.Point(342, 224);
            this.DecideNumber.Name = "DecideNumber";
            this.DecideNumber.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecideNumber.PopupOffset = new System.Drawing.Point(12, 0);
            this.DecideNumber.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DecideNumber.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DecideNumber.PopupWidth = 300;
            this.DecideNumber.Size = new System.Drawing.Size(348, 19);
            this.DecideNumber.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "决定书，要求你（单位）于";
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndDate.CustomFormat = "yyyy年M月d日";
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(218, 256);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(168, 26);
            this.EndDate.TabIndex = 110;
            this.EndDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "前将罚款缴至";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "号行政处罚";
            // 
            // Location
            // 
            this.Location.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Location.BackColor = System.Drawing.Color.White;
            this.Location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location.ControlText = "";
            this.Location.Location = new System.Drawing.Point(491, 258);
            this.Location.Name = "Location";
            this.Location.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location.PopupOffset = new System.Drawing.Point(12, 0);
            this.Location.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Location.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Location.PopupWidth = 300;
            this.Location.Size = new System.Drawing.Size(274, 19);
            this.Location.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(760, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "。因你（单位）至今未履行该处罚决定，现要求你（单位）立即缴纳罚款，并根据《中华人民共和国行政处";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(752, 16);
            this.label8.TabIndex = 109;
            this.label8.Text = "罚法》第五十一条第（一）项的规定，每日按罚款数额的3％加处罚款。加处的罚款由代收机构直接收缴。";
            // 
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(585, 415);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(168, 26);
            this.FormDate.TabIndex = 110;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(537, 390);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 111;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditFineCallsNotice
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditFineCallsNotice";
            this.Size = new System.Drawing.Size(886, 500);
            this.Load += new System.EventHandler(this.frmEditFineCallsNotice_Load);
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
        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableDateTimePicker EndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker SendCallsDate;
        private EnforceUI.TableAutoCompleteTextBox Location;
        private EnforceUI.TableAutoCompleteTextBox DecideNumber;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

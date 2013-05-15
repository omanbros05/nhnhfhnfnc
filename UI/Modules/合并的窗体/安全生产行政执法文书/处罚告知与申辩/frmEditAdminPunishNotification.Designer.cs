namespace EnforceForm
{
    partial class frmEditAdminPunishNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAdminPunishNotification));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BriefCase = new EnforceUI.TableRichTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyBehavior = new EnforceUI.TableRichTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LawProvision = new EnforceUI.TableRichTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Certificate = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.AdminPunish = new EnforceUI.TableRichTextBox(this.components);
            this.Address = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Post = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Contacter = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.Tel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.SendDate = new EnforceUI.TableDateTimePicker(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
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
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.btnSelect);
            this.panelContent.Controls.Add(this.SendDate);
            this.panelContent.Controls.Add(this.Tel);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.Contacter);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.Post);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.Address);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.AdminPunish);
            this.panelContent.Controls.Add(this.Certificate);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.LawProvision);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.CompanyBehavior);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.BriefCase);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 933);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1008);
            this.panel1.Size = new System.Drawing.Size(886, 43);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "行政处罚告知书 > 编辑";
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
            this.DocTitle.ControlText = "(××)安监管罚告〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(153, 153);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 105;
            this.DocTitle.Text = "(××)安监管罚告〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(281, 120);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 103;
            this.headerLabel2.Text = "行政处罚告知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(8, 108);
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
            this.headerLabel1.Location = new System.Drawing.Point(261, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 102;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 196);
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
            this.CompanyName.Location = new System.Drawing.Point(8, 193);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(399, 19);
            this.CompanyName.TabIndex = 106;
            // 
            // BriefCase
            // 
            this.BriefCase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BriefCase.ControlText = "";
            this.BriefCase.Location = new System.Drawing.Point(8, 248);
            this.BriefCase.Name = "BriefCase";
            this.BriefCase.Size = new System.Drawing.Size(748, 65);
            this.BriefCase.TabIndex = 109;
            this.BriefCase.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "简要情况:";
            // 
            // CompanyBehavior
            // 
            this.CompanyBehavior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyBehavior.ControlText = "";
            this.CompanyBehavior.Location = new System.Drawing.Point(6, 347);
            this.CompanyBehavior.Name = "CompanyBehavior";
            this.CompanyBehavior.Size = new System.Drawing.Size(748, 148);
            this.CompanyBehavior.TabIndex = 111;
            this.CompanyBehavior.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "经查，你（单位）存在以下行为:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "上述行为违反了以下规定:";
            // 
            // LawProvision
            // 
            this.LawProvision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LawProvision.ControlText = "";
            this.LawProvision.Location = new System.Drawing.Point(6, 525);
            this.LawProvision.Name = "LawProvision";
            this.LawProvision.Size = new System.Drawing.Size(748, 148);
            this.LawProvision.TabIndex = 111;
            this.LawProvision.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "根据";
            // 
            // Certificate
            // 
            this.Certificate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Certificate.BackColor = System.Drawing.Color.White;
            this.Certificate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Certificate.ControlText = "";
            this.Certificate.Location = new System.Drawing.Point(51, 686);
            this.Certificate.Name = "Certificate";
            this.Certificate.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Certificate.PopupOffset = new System.Drawing.Point(12, 0);
            this.Certificate.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Certificate.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Certificate.PopupWidth = 300;
            this.Certificate.Size = new System.Drawing.Size(605, 19);
            this.Certificate.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 112;
            this.label6.Text = "拟对你（单位）作出以下行政处罚:";
            // 
            // AdminPunish
            // 
            this.AdminPunish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminPunish.ControlText = "";
            this.AdminPunish.Location = new System.Drawing.Point(8, 748);
            this.AdminPunish.Name = "AdminPunish";
            this.AdminPunish.Size = new System.Drawing.Size(748, 65);
            this.AdminPunish.TabIndex = 115;
            this.AdminPunish.Text = "";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.ControlText = "";
            this.Address.Location = new System.Drawing.Point(83, 839);
            this.Address.Name = "Address";
            this.Address.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.PopupOffset = new System.Drawing.Point(12, 0);
            this.Address.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Address.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Address.PopupWidth = 300;
            this.Address.Size = new System.Drawing.Size(401, 19);
            this.Address.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 842);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 116;
            this.label8.Text = "本局地址:";
            // 
            // Post
            // 
            this.Post.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Post.BackColor = System.Drawing.Color.White;
            this.Post.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Post.ControlText = "";
            this.Post.Location = new System.Drawing.Point(580, 839);
            this.Post.Name = "Post";
            this.Post.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Post.PopupOffset = new System.Drawing.Point(12, 0);
            this.Post.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Post.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Post.PopupWidth = 300;
            this.Post.Size = new System.Drawing.Size(176, 19);
            this.Post.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 842);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 118;
            this.label9.Text = "邮政编码:";
            // 
            // Contacter
            // 
            this.Contacter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contacter.BackColor = System.Drawing.Color.White;
            this.Contacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacter.ControlText = "";
            this.Contacter.Location = new System.Drawing.Point(83, 876);
            this.Contacter.Name = "Contacter";
            this.Contacter.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacter.PopupOffset = new System.Drawing.Point(12, 0);
            this.Contacter.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Contacter.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Contacter.PopupWidth = 300;
            this.Contacter.Size = new System.Drawing.Size(401, 19);
            this.Contacter.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 879);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 120;
            this.label10.Text = "联 系 人:";
            // 
            // Tel
            // 
            this.Tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.ControlText = "";
            this.Tel.Location = new System.Drawing.Point(580, 876);
            this.Tel.Name = "Tel";
            this.Tel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.PopupOffset = new System.Drawing.Point(12, 0);
            this.Tel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Tel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tel.PopupWidth = 300;
            this.Tel.Size = new System.Drawing.Size(176, 19);
            this.Tel.TabIndex = 123;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(494, 879);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 122;
            this.label11.Text = "电    话:";
            // 
            // SendDate
            // 
            this.SendDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SendDate.CustomFormat = "yyyy年M月d日";
            this.SendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SendDate.Location = new System.Drawing.Point(572, 958);
            this.SendDate.Name = "SendDate";
            this.SendDate.Size = new System.Drawing.Size(168, 26);
            this.SendDate.TabIndex = 124;
            this.SendDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(668, 686);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 23);
            this.btnSelect.TabIndex = 125;
            this.btnSelect.Text = "查询法律";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(517, 933);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 111;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditAdminPunishNotification
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditAdminPunishNotification";
            this.Size = new System.Drawing.Size(886, 1051);
            this.Load += new System.EventHandler(this.frmEditAdminPunishNotification_Load);
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
        private EnforceUI.TableAutoCompleteTextBox Tel;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableAutoCompleteTextBox Contacter;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox Post;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox Address;
        private System.Windows.Forms.Label label8;
        private EnforceUI.TableRichTextBox AdminPunish;
        private EnforceUI.TableAutoCompleteTextBox Certificate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableRichTextBox LawProvision;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableRichTextBox CompanyBehavior;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableRichTextBox BriefCase;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableDateTimePicker SendDate;
        private System.Windows.Forms.Button btnSelect;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

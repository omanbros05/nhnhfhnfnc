namespace EnforceForm
{
    partial class frmEditContributeFineApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditContributeFineApproval));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.headerLabel3 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine2 = new EnforceUI.TableLine(this.components);
            this.headerLabel4 = new EnforceUI.HeaderLabel(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PunishInstrumentNo = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Address = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.LawFactPunish = new EnforceUI.TableRichTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ExtensionReason = new EnforceUI.TableRichTextBox(this.components);
            this.UserOpinion = new EnforceUI.TableRichTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine2)).BeginInit();
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
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.FormDate);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.UserOpinion);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.ExtensionReason);
            this.panelContent.Controls.Add(this.LawFactPunish);
            this.panelContent.Controls.Add(this.PunishInstrumentNo);
            this.panelContent.Controls.Add(this.Address);
            this.panelContent.Controls.Add(this.Party);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel3);
            this.panelContent.Controls.Add(this.tableLine2);
            this.panelContent.Controls.Add(this.headerLabel4);
            this.panelContent.Size = new System.Drawing.Size(996, 830);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 905);
            this.panel1.Size = new System.Drawing.Size(996, 45);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(996, 75);
            this.header1.Title = "分期缴款审批书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(396, 240);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 106;
            this.headerLabel2.Text = "罚款催缴通知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(123, 228);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 107;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(376, 200);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 105;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // headerLabel3
            // 
            this.headerLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel3.Location = new System.Drawing.Point(288, 124);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(269, 20);
            this.headerLabel3.TabIndex = 106;
            this.headerLabel3.Text = "延期（分期）缴纳罚款审批表";
            // 
            // tableLine2
            // 
            this.tableLine2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine2.BackgroundImage")));
            this.tableLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine2.Location = new System.Drawing.Point(67, 108);
            this.tableLine2.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine2.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine2.Name = "tableLine2";
            this.tableLine2.Size = new System.Drawing.Size(750, 4);
            this.tableLine2.TabIndex = 107;
            this.tableLine2.TabStop = false;
            // 
            // headerLabel4
            // 
            this.headerLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel4.Location = new System.Drawing.Point(320, 80);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(209, 20);
            this.headerLabel4.TabIndex = 105;
            this.headerLabel4.Text = "安全生产行政执法文书";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(156, 166);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(651, 19);
            this.CaseName.TabIndex = 108;
            this.CaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "案件名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 109;
            this.label2.Text = "处罚决定书文号：";
            // 
            // PunishInstrumentNo
            // 
            this.PunishInstrumentNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishInstrumentNo.BackColor = System.Drawing.Color.White;
            this.PunishInstrumentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishInstrumentNo.ControlText = "";
            this.PunishInstrumentNo.Location = new System.Drawing.Point(201, 208);
            this.PunishInstrumentNo.Name = "PunishInstrumentNo";
            this.PunishInstrumentNo.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishInstrumentNo.PopupOffset = new System.Drawing.Point(12, 0);
            this.PunishInstrumentNo.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PunishInstrumentNo.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PunishInstrumentNo.PopupWidth = 300;
            this.PunishInstrumentNo.Size = new System.Drawing.Size(606, 19);
            this.PunishInstrumentNo.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "当 事 人：";
            // 
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(156, 245);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(651, 19);
            this.Party.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "地    址：";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.ControlText = "";
            this.Address.Location = new System.Drawing.Point(156, 283);
            this.Address.Name = "Address";
            this.Address.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.PopupOffset = new System.Drawing.Point(12, 0);
            this.Address.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Address.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Address.PopupWidth = 300;
            this.Address.Size = new System.Drawing.Size(651, 19);
            this.Address.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "违法事实及处罚决定：";
            // 
            // LawFactPunish
            // 
            this.LawFactPunish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LawFactPunish.ControlText = "";
            this.LawFactPunish.Location = new System.Drawing.Point(73, 346);
            this.LawFactPunish.Name = "LawFactPunish";
            this.LawFactPunish.Size = new System.Drawing.Size(734, 126);
            this.LawFactPunish.TabIndex = 110;
            this.LawFactPunish.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "当事人申请延期（分期）缴纳罚款的理由：";
            // 
            // ExtensionReason
            // 
            this.ExtensionReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtensionReason.ControlText = "";
            this.ExtensionReason.Location = new System.Drawing.Point(73, 506);
            this.ExtensionReason.Name = "ExtensionReason";
            this.ExtensionReason.Size = new System.Drawing.Size(734, 151);
            this.ExtensionReason.TabIndex = 110;
            this.ExtensionReason.Text = "";
            // 
            // UserOpinion
            // 
            this.UserOpinion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserOpinion.ControlText = "";
            this.UserOpinion.Location = new System.Drawing.Point(73, 698);
            this.UserOpinion.Name = "UserOpinion";
            this.UserOpinion.Size = new System.Drawing.Size(734, 126);
            this.UserOpinion.TabIndex = 112;
            this.UserOpinion.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "承办人意见：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 841);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "、";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(70, 841);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 114;
            this.label18.Text = "承办人：";
            // 
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(639, 873);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(168, 26);
            this.FormDate.TabIndex = 117;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(139, 842);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(179, 19);
            this.UserName1.TabIndex = 118;
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(345, 842);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(179, 19);
            this.UserName2.TabIndex = 119;
            // 
            // frmEditContributeFineApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerLabel2);
            this.Controls.Add(this.tableLine1);
            this.Controls.Add(this.headerLabel1);
            this.Name = "frmEditContributeFineApproval";
            this.Size = new System.Drawing.Size(996, 950);
            this.Load += new System.EventHandler(this.frmContributeFineApproval_Load);
            this.Controls.SetChildIndex(this.header1, 0);
            this.Controls.SetChildIndex(this.headerLabel1, 0);
            this.Controls.SetChildIndex(this.tableLine1, 0);
            this.Controls.SetChildIndex(this.headerLabel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.HeaderLabel headerLabel3;
        private EnforceUI.TableLine tableLine2;
        private EnforceUI.HeaderLabel headerLabel4;
        private EnforceUI.TableAutoCompleteTextBox PunishInstrumentNo;
        private EnforceUI.TableAutoCompleteTextBox Address;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableRichTextBox UserOpinion;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableRichTextBox ExtensionReason;
        private EnforceUI.TableRichTextBox LawFactPunish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
    }
}

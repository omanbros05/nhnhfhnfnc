namespace EnforceForm
{
    partial class frmEditCaseTransferredApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCaseTransferredApproval));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiverUnit = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CaseInfo = new EnforceUI.TableRichTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.TransferredReason = new EnforceUI.TableRichTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.UserReason = new EnforceUI.TableRichTextBox(this.components);
            this.HandleDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
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
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.HandleDate);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.UserReason);
            this.panelContent.Controls.Add(this.TransferredReason);
            this.panelContent.Controls.Add(this.CaseInfo);
            this.panelContent.Controls.Add(this.Address);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.Party);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.ReceiverUnit);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 829);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 904);
            this.panel1.Size = new System.Drawing.Size(886, 46);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "案件移送审批表 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(284, 120);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 9;
            this.headerLabel2.Text = "案件移送审批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(5, 108);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 10;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(258, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 8;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(88, 162);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(651, 19);
            this.CaseName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "案件名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "当事人：";
            // 
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(88, 200);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(651, 19);
            this.Party.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "地址：";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.ControlText = "";
            this.Address.Location = new System.Drawing.Point(88, 238);
            this.Address.Name = "Address";
            this.Address.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.PopupOffset = new System.Drawing.Point(12, 0);
            this.Address.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Address.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Address.PopupWidth = 300;
            this.Address.Size = new System.Drawing.Size(651, 19);
            this.Address.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "受移送机关：";
            // 
            // ReceiverUnit
            // 
            this.ReceiverUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReceiverUnit.BackColor = System.Drawing.Color.White;
            this.ReceiverUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiverUnit.ControlText = "";
            this.ReceiverUnit.Location = new System.Drawing.Point(112, 279);
            this.ReceiverUnit.Name = "ReceiverUnit";
            this.ReceiverUnit.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiverUnit.PopupOffset = new System.Drawing.Point(12, 0);
            this.ReceiverUnit.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ReceiverUnit.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReceiverUnit.PopupWidth = 300;
            this.ReceiverUnit.Size = new System.Drawing.Size(627, 19);
            this.ReceiverUnit.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "案情简介：";
            // 
            // CaseInfo
            // 
            this.CaseInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseInfo.ControlText = "";
            this.CaseInfo.Location = new System.Drawing.Point(21, 341);
            this.CaseInfo.Name = "CaseInfo";
            this.CaseInfo.Size = new System.Drawing.Size(718, 126);
            this.CaseInfo.TabIndex = 103;
            this.CaseInfo.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "移送理由：";
            // 
            // TransferredReason
            // 
            this.TransferredReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TransferredReason.ControlText = "";
            this.TransferredReason.Location = new System.Drawing.Point(21, 513);
            this.TransferredReason.Name = "TransferredReason";
            this.TransferredReason.Size = new System.Drawing.Size(718, 126);
            this.TransferredReason.TabIndex = 103;
            this.TransferredReason.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "承办人员拟办意见：";
            // 
            // UserReason
            // 
            this.UserReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserReason.ControlText = "";
            this.UserReason.Location = new System.Drawing.Point(21, 677);
            this.UserReason.Name = "UserReason";
            this.UserReason.Size = new System.Drawing.Size(718, 126);
            this.UserReason.TabIndex = 103;
            this.UserReason.Text = "";
            // 
            // HandleDate
            // 
            this.HandleDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HandleDate.CustomFormat = "yyyy年M月d日";
            this.HandleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HandleDate.Location = new System.Drawing.Point(571, 849);
            this.HandleDate.Name = "HandleDate";
            this.HandleDate.Size = new System.Drawing.Size(168, 26);
            this.HandleDate.TabIndex = 107;
            this.HandleDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 828);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 104;
            this.label18.Text = "承办人：";
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(308, 829);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(186, 19);
            this.UserName2.TabIndex = 115;
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(97, 829);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(186, 19);
            this.UserName1.TabIndex = 114;
            // 
            // frmEditCaseTransferredApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditCaseTransferredApproval";
            this.Size = new System.Drawing.Size(886, 950);
            this.Load += new System.EventHandler(this.frmCaseTransferredApproval_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox ReceiverUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableRichTextBox UserReason;
        private EnforceUI.TableRichTextBox TransferredReason;
        private EnforceUI.TableRichTextBox CaseInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableDateTimePicker HandleDate;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
        private EnforceUI.TableAutoCompleteTextBox Address;
    }
}

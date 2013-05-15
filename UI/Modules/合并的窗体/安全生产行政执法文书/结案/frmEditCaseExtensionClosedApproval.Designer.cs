namespace EnforceForm
{
    partial class frmEditCaseExtensionClosedApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCaseExtensionClosedApproval));
            this.CaseStartDate = new EnforceUI.TableDateTimePicker(this.components);
            this.Legal = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CaseSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel3 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine2 = new EnforceUI.TableLine(this.components);
            this.headerLabel4 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Address = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Tel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ExtensionApproval = new EnforceUI.TableRichTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.panelContent.SuspendLayout();
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
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.FormDate);
            this.panelContent.Controls.Add(this.ExtensionApproval);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.CaseStartDate);
            this.panelContent.Controls.Add(this.Tel);
            this.panelContent.Controls.Add(this.Legal);
            this.panelContent.Controls.Add(this.CaseSourceName);
            this.panelContent.Controls.Add(this.Address);
            this.panelContent.Controls.Add(this.Party);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel3);
            this.panelContent.Controls.Add(this.tableLine2);
            this.panelContent.Controls.Add(this.headerLabel4);
            this.panelContent.Size = new System.Drawing.Size(886, 564);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 639);
            this.panel1.Size = new System.Drawing.Size(886, 41);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "案件延期办结审批表 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // CaseStartDate
            // 
            this.CaseStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseStartDate.CustomFormat = "yyyy年M月d日";
            this.CaseStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartDate.Location = new System.Drawing.Point(530, 278);
            this.CaseStartDate.Name = "CaseStartDate";
            this.CaseStartDate.Size = new System.Drawing.Size(181, 26);
            this.CaseStartDate.TabIndex = 134;
            this.CaseStartDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // Legal
            // 
            this.Legal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Legal.BackColor = System.Drawing.Color.White;
            this.Legal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.ControlText = "";
            this.Legal.Location = new System.Drawing.Point(533, 207);
            this.Legal.Name = "Legal";
            this.Legal.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.PopupOffset = new System.Drawing.Point(12, 0);
            this.Legal.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Legal.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Legal.PopupWidth = 300;
            this.Legal.Size = new System.Drawing.Size(225, 19);
            this.Legal.TabIndex = 124;
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseSourceName.BackColor = System.Drawing.Color.White;
            this.CaseSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.ControlText = "";
            this.CaseSourceName.Location = new System.Drawing.Point(94, 281);
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSourceName.PopupWidth = 300;
            this.CaseSourceName.Size = new System.Drawing.Size(353, 19);
            this.CaseSourceName.TabIndex = 127;
            // 
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(84, 204);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(255, 19);
            this.Party.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 129;
            this.label6.Text = "立案日期：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "案件来源：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "法定代表人（负责人）：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "当事人：";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(116, 164);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(642, 19);
            this.CaseName.TabIndex = 123;
            this.CaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "案件名称：";
            // 
            // headerLabel3
            // 
            this.headerLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel3.Location = new System.Drawing.Point(267, 124);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(209, 20);
            this.headerLabel3.TabIndex = 120;
            this.headerLabel3.Text = "案件延期办结毕审批表";
            // 
            // tableLine2
            // 
            this.tableLine2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine2.BackgroundImage")));
            this.tableLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine2.Location = new System.Drawing.Point(14, 107);
            this.tableLine2.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine2.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine2.Name = "tableLine2";
            this.tableLine2.Size = new System.Drawing.Size(750, 4);
            this.tableLine2.TabIndex = 121;
            this.tableLine2.TabStop = false;
            // 
            // headerLabel4
            // 
            this.headerLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel4.Location = new System.Drawing.Point(267, 79);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(209, 20);
            this.headerLabel4.TabIndex = 119;
            this.headerLabel4.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 132;
            this.label7.Text = "地址：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 133;
            this.label8.Text = "联系电话：";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.ControlText = "";
            this.Address.Location = new System.Drawing.Point(66, 245);
            this.Address.Name = "Address";
            this.Address.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.PopupOffset = new System.Drawing.Point(12, 0);
            this.Address.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Address.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Address.PopupWidth = 300;
            this.Address.Size = new System.Drawing.Size(381, 19);
            this.Address.TabIndex = 126;
            // 
            // Tel
            // 
            this.Tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.ControlText = "";
            this.Tel.Location = new System.Drawing.Point(533, 246);
            this.Tel.Name = "Tel";
            this.Tel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.PopupOffset = new System.Drawing.Point(12, 0);
            this.Tel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Tel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tel.PopupWidth = 300;
            this.Tel.Size = new System.Drawing.Size(225, 19);
            this.Tel.TabIndex = 124;
            // 
            // ExtensionApproval
            // 
            this.ExtensionApproval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtensionApproval.ControlText = "";
            this.ExtensionApproval.Location = new System.Drawing.Point(20, 339);
            this.ExtensionApproval.Name = "ExtensionApproval";
            this.ExtensionApproval.Size = new System.Drawing.Size(734, 149);
            this.ExtensionApproval.TabIndex = 136;
            this.ExtensionApproval.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 135;
            this.label10.Text = "案件延期办毕申请：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(736, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "难以在90日内办毕，根据《安全生产违法行为行政处罚办法》第三十一条的规定，申请延期至180日内办";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 135;
            this.label9.Text = "理完毕。";
            // 
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(589, 604);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(138, 26);
            this.FormDate.TabIndex = 137;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(501, 579);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 138;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditCaseExtensionClosedApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditCaseExtensionClosedApproval";
            this.Size = new System.Drawing.Size(886, 680);
            this.Load += new System.EventHandler(this.frmCaseExtensionClosedApproval_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableDateTimePicker CaseStartDate;
        private EnforceUI.TableAutoCompleteTextBox Legal;
        private EnforceUI.TableAutoCompleteTextBox CaseSourceName;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel3;
        private EnforceUI.TableLine tableLine2;
        private EnforceUI.HeaderLabel headerLabel4;
        private EnforceUI.TableAutoCompleteTextBox Tel;
        private EnforceUI.TableAutoCompleteTextBox Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableRichTextBox ExtensionApproval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

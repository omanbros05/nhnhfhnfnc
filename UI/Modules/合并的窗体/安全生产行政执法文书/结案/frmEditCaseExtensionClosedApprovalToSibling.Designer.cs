namespace EnforceForm
{
    partial class frmEditCaseExtensionClosedApprovalToSibling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCaseExtensionClosedApprovalToSibling));
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
            this.ExtensionApproval = new EnforceUI.TableRichTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CaseStartDate = new EnforceUI.TableDateTimePicker(this.components);
            this.Tel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Legal = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CaseSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Address = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel3 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine2 = new EnforceUI.TableLine(this.components);
            this.headerLabel4 = new EnforceUI.HeaderLabel(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
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
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.label18);
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
            this.panelContent.Size = new System.Drawing.Size(886, 609);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 684);
            this.panel1.Size = new System.Drawing.Size(886, 46);
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
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(594, 637);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(138, 26);
            this.FormDate.TabIndex = 159;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // ExtensionApproval
            // 
            this.ExtensionApproval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtensionApproval.ControlText = "";
            this.ExtensionApproval.Location = new System.Drawing.Point(6, 338);
            this.ExtensionApproval.Name = "ExtensionApproval";
            this.ExtensionApproval.Size = new System.Drawing.Size(734, 149);
            this.ExtensionApproval.TabIndex = 158;
            this.ExtensionApproval.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 155;
            this.label9.Text = "理完毕。";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(728, 16);
            this.label5.TabIndex = 157;
            this.label5.Text = "难以在30日内办毕，根据《安全生产违法行为行政处罚办法》第三十一条的规定，申请延期至90日内办";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 156;
            this.label10.Text = "案件延期办毕申请：";
            // 
            // CaseStartDate
            // 
            this.CaseStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseStartDate.CustomFormat = "yyyy年M月d日";
            this.CaseStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartDate.Location = new System.Drawing.Point(516, 277);
            this.CaseStartDate.Name = "CaseStartDate";
            this.CaseStartDate.Size = new System.Drawing.Size(179, 26);
            this.CaseStartDate.TabIndex = 154;
            this.CaseStartDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // Tel
            // 
            this.Tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.ControlText = "";
            this.Tel.Location = new System.Drawing.Point(519, 245);
            this.Tel.Name = "Tel";
            this.Tel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.PopupOffset = new System.Drawing.Point(12, 0);
            this.Tel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Tel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tel.PopupWidth = 300;
            this.Tel.Size = new System.Drawing.Size(225, 19);
            this.Tel.TabIndex = 142;
            // 
            // Legal
            // 
            this.Legal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Legal.BackColor = System.Drawing.Color.White;
            this.Legal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.ControlText = "";
            this.Legal.Location = new System.Drawing.Point(519, 207);
            this.Legal.Name = "Legal";
            this.Legal.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.PopupOffset = new System.Drawing.Point(12, 0);
            this.Legal.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Legal.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Legal.PopupWidth = 300;
            this.Legal.Size = new System.Drawing.Size(225, 19);
            this.Legal.TabIndex = 143;
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseSourceName.BackColor = System.Drawing.Color.White;
            this.CaseSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.ControlText = "";
            this.CaseSourceName.Location = new System.Drawing.Point(80, 280);
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSourceName.PopupWidth = 300;
            this.CaseSourceName.Size = new System.Drawing.Size(353, 19);
            this.CaseSourceName.TabIndex = 146;
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.ControlText = "";
            this.Address.Location = new System.Drawing.Point(52, 244);
            this.Address.Name = "Address";
            this.Address.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.PopupOffset = new System.Drawing.Point(12, 0);
            this.Address.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Address.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Address.PopupWidth = 300;
            this.Address.Size = new System.Drawing.Size(381, 19);
            this.Address.TabIndex = 145;
            // 
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(70, 204);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(255, 19);
            this.Party.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "立案日期：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 149;
            this.label4.Text = "案件来源：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 153;
            this.label8.Text = "联系电话：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 152;
            this.label3.Text = "法定代表人（负责人）：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 150;
            this.label7.Text = "地址：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 151;
            this.label2.Text = "当事人：";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(102, 164);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(642, 19);
            this.CaseName.TabIndex = 141;
            this.CaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 147;
            this.label1.Text = "案件名称：";
            // 
            // headerLabel3
            // 
            this.headerLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel3.Location = new System.Drawing.Point(265, 124);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(189, 20);
            this.headerLabel3.TabIndex = 139;
            this.headerLabel3.Text = "案件延期办毕审批表";
            // 
            // tableLine2
            // 
            this.tableLine2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine2.BackgroundImage")));
            this.tableLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine2.Location = new System.Drawing.Point(0, 107);
            this.tableLine2.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine2.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine2.Name = "tableLine2";
            this.tableLine2.Size = new System.Drawing.Size(750, 4);
            this.tableLine2.TabIndex = 140;
            this.tableLine2.TabStop = false;
            // 
            // headerLabel4
            // 
            this.headerLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel4.Location = new System.Drawing.Point(253, 79);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(209, 20);
            this.headerLabel4.TabIndex = 138;
            this.headerLabel4.Text = "安全生产行政执法文书";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 609);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 161;
            this.label18.Text = "承办人：";
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(280, 609);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(150, 19);
            this.UserName2.TabIndex = 175;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 609);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 174;
            this.label13.Text = "、";
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(98, 609);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(150, 19);
            this.UserName1.TabIndex = 173;
            // 
            // frmEditCaseExtensionClosedApprovalToSibling
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditCaseExtensionClosedApprovalToSibling";
            this.Size = new System.Drawing.Size(886, 730);
            this.Load += new System.EventHandler(this.frmEditCaseClosedApprovalToSibling_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableRichTextBox ExtensionApproval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableDateTimePicker CaseStartDate;
        private EnforceUI.TableAutoCompleteTextBox Tel;
        private EnforceUI.TableAutoCompleteTextBox CaseSourceName;
        private EnforceUI.TableAutoCompleteTextBox Address;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel3;
        private EnforceUI.TableLine tableLine2;
        private EnforceUI.HeaderLabel headerLabel4;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
        private EnforceUI.TableAutoCompleteTextBox Legal;
    }
}

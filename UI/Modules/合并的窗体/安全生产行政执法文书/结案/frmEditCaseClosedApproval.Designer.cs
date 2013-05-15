namespace EnforceForm
{
    partial class frmEditCaseClosedApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCaseClosedApproval));
            this.headerLabel3 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine2 = new EnforceUI.TableLine(this.components);
            this.headerLabel4 = new EnforceUI.HeaderLabel(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Legal = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CaseSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PunishInstrumentNo = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.CaseStartDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.PunishDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.CaseEndDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.PunishContent = new EnforceUI.TableRichTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.ExecutionResult = new EnforceUI.TableRichTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.FormDate = new EnforceUI.TableDateTimePicker(this.components);
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.panelContent.Controls.Add(this.PeoplePhone);
            this.panelContent.Controls.Add(this.PeopleAddress);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.ExecutionResult);
            this.panelContent.Controls.Add(this.FormDate);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.PunishContent);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.CaseEndDate);
            this.panelContent.Controls.Add(this.PunishDate);
            this.panelContent.Controls.Add(this.CaseStartDate);
            this.panelContent.Controls.Add(this.PunishInstrumentNo);
            this.panelContent.Controls.Add(this.Legal);
            this.panelContent.Controls.Add(this.CaseSourceName);
            this.panelContent.Controls.Add(this.Party);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel3);
            this.panelContent.Controls.Add(this.tableLine2);
            this.panelContent.Controls.Add(this.headerLabel4);
            this.panelContent.Size = new System.Drawing.Size(886, 803);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 878);
            this.panel1.Size = new System.Drawing.Size(886, 42);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "结案审批表 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // headerLabel3
            // 
            this.headerLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel3.Location = new System.Drawing.Point(270, 123);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(109, 20);
            this.headerLabel3.TabIndex = 109;
            this.headerLabel3.Text = "结案审批表";
            // 
            // tableLine2
            // 
            this.tableLine2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine2.BackgroundImage")));
            this.tableLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine2.Location = new System.Drawing.Point(-24, 106);
            this.tableLine2.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine2.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine2.Name = "tableLine2";
            this.tableLine2.Size = new System.Drawing.Size(750, 4);
            this.tableLine2.TabIndex = 110;
            this.tableLine2.TabStop = false;
            // 
            // headerLabel4
            // 
            this.headerLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel4.Location = new System.Drawing.Point(229, 78);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(209, 20);
            this.headerLabel4.TabIndex = 108;
            this.headerLabel4.Text = "安全生产行政执法文书";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管结〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(111, 155);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 111;
            this.DocTitle.Text = "(××)安监管结〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(78, 199);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(642, 19);
            this.CaseName.TabIndex = 112;
            this.CaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-17, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "案件名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-21, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "当事人：";
            // 
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(46, 239);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(255, 19);
            this.Party.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "法定代表人（负责人）：";
            // 
            // Legal
            // 
            this.Legal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Legal.BackColor = System.Drawing.Color.White;
            this.Legal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.ControlText = "";
            this.Legal.Location = new System.Drawing.Point(495, 242);
            this.Legal.Name = "Legal";
            this.Legal.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Legal.PopupOffset = new System.Drawing.Point(12, 0);
            this.Legal.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Legal.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Legal.PopupWidth = 300;
            this.Legal.Size = new System.Drawing.Size(225, 19);
            this.Legal.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-21, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "案件来源：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "处罚文书号：";
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseSourceName.BackColor = System.Drawing.Color.White;
            this.CaseSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.ControlText = "";
            this.CaseSourceName.Location = new System.Drawing.Point(56, 334);
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSourceName.PopupWidth = 300;
            this.CaseSourceName.Size = new System.Drawing.Size(245, 19);
            this.CaseSourceName.TabIndex = 112;
            // 
            // PunishInstrumentNo
            // 
            this.PunishInstrumentNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishInstrumentNo.BackColor = System.Drawing.Color.White;
            this.PunishInstrumentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishInstrumentNo.ControlText = "";
            this.PunishInstrumentNo.Location = new System.Drawing.Point(419, 337);
            this.PunishInstrumentNo.Name = "PunishInstrumentNo";
            this.PunishInstrumentNo.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishInstrumentNo.PopupOffset = new System.Drawing.Point(12, 0);
            this.PunishInstrumentNo.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PunishInstrumentNo.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PunishInstrumentNo.PopupWidth = 300;
            this.PunishInstrumentNo.Size = new System.Drawing.Size(301, 19);
            this.PunishInstrumentNo.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-21, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "立案日期：";
            // 
            // CaseStartDate
            // 
            this.CaseStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseStartDate.CustomFormat = "yyyy年M月d日";
            this.CaseStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartDate.Location = new System.Drawing.Point(56, 374);
            this.CaseStartDate.Name = "CaseStartDate";
            this.CaseStartDate.Size = new System.Drawing.Size(150, 26);
            this.CaseStartDate.TabIndex = 118;
            this.CaseStartDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 113;
            this.label7.Text = "处罚日期：";
            // 
            // PunishDate
            // 
            this.PunishDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishDate.CustomFormat = "yyyy年M月d日";
            this.PunishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PunishDate.Location = new System.Drawing.Point(302, 374);
            this.PunishDate.Name = "PunishDate";
            this.PunishDate.Size = new System.Drawing.Size(135, 26);
            this.PunishDate.TabIndex = 118;
            this.PunishDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "申请结案日期：";
            // 
            // CaseEndDate
            // 
            this.CaseEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseEndDate.CustomFormat = "yyyy年M月d日";
            this.CaseEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseEndDate.Location = new System.Drawing.Point(582, 374);
            this.CaseEndDate.Name = "CaseEndDate";
            this.CaseEndDate.Size = new System.Drawing.Size(138, 26);
            this.CaseEndDate.TabIndex = 118;
            this.CaseEndDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-21, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 120;
            this.label18.Text = "承办人：";
            // 
            // PunishContent
            // 
            this.PunishContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishContent.ControlText = "";
            this.PunishContent.Location = new System.Drawing.Point(-18, 480);
            this.PunishContent.Name = "PunishContent";
            this.PunishContent.Size = new System.Drawing.Size(734, 126);
            this.PunishContent.TabIndex = 124;
            this.PunishContent.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-21, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 123;
            this.label10.Text = "处罚内容：";
            // 
            // ExecutionResult
            // 
            this.ExecutionResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecutionResult.ControlText = "";
            this.ExecutionResult.Location = new System.Drawing.Point(-18, 645);
            this.ExecutionResult.Name = "ExecutionResult";
            this.ExecutionResult.Size = new System.Drawing.Size(734, 126);
            this.ExecutionResult.TabIndex = 126;
            this.ExecutionResult.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-21, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 125;
            this.label11.Text = "执行结果：";
            // 
            // FormDate
            // 
            this.FormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormDate.CustomFormat = "yyyy年M月d日";
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormDate.Location = new System.Drawing.Point(581, 791);
            this.FormDate.Name = "FormDate";
            this.FormDate.Size = new System.Drawing.Size(135, 26);
            this.FormDate.TabIndex = 127;
            this.FormDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(238, 425);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(150, 19);
            this.UserName2.TabIndex = 178;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 177;
            this.label13.Text = "、";
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(56, 425);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(150, 19);
            this.UserName1.TabIndex = 176;
            // 
            // PeoplePhone
            // 
            this.PeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeoplePhone.BackColor = System.Drawing.Color.White;
            this.PeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeoplePhone.ControlText = "";
            this.PeoplePhone.Location = new System.Drawing.Point(413, 289);
            this.PeoplePhone.Name = "PeoplePhone";
            this.PeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeoplePhone.PopupWidth = 300;
            this.PeoplePhone.Size = new System.Drawing.Size(307, 19);
            this.PeoplePhone.TabIndex = 180;
            // 
            // PeopleAddress
            // 
            this.PeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeopleAddress.BackColor = System.Drawing.Color.White;
            this.PeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleAddress.ControlText = "";
            this.PeopleAddress.Location = new System.Drawing.Point(46, 286);
            this.PeopleAddress.Name = "PeopleAddress";
            this.PeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeopleAddress.PopupWidth = 300;
            this.PeopleAddress.Size = new System.Drawing.Size(255, 19);
            this.PeopleAddress.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 182;
            this.label9.Text = "联系电话：";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-21, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 181;
            this.label12.Text = "地址：";
            // 
            // frmEditCaseClosedApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditCaseClosedApproval";
            this.Size = new System.Drawing.Size(886, 920);
            this.Load += new System.EventHandler(this.frmEditCaseClosedApproval_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel3;
        private EnforceUI.TableLine tableLine2;
        private EnforceUI.HeaderLabel headerLabel4;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableAutoCompleteTextBox PunishInstrumentNo;
        private EnforceUI.TableAutoCompleteTextBox Legal;
        private EnforceUI.TableAutoCompleteTextBox CaseSourceName;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker CaseEndDate;
        private EnforceUI.TableDateTimePicker PunishDate;
        private EnforceUI.TableDateTimePicker CaseStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableDateTimePicker FormDate;
        private EnforceUI.TableRichTextBox ExecutionResult;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableRichTextBox PunishContent;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
        private EnforceUI.TableAutoCompleteTextBox PeoplePhone;
        private EnforceUI.TableAutoCompleteTextBox PeopleAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

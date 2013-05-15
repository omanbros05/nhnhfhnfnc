namespace EnforceForm
{
    partial class frmEditSurveyEndReport
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
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.FormHeadUnitAbb = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaseHandleResult = new EnforceUI.TableRichTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CaseStartDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.CaseEndDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CaseRetention = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CaseArchivingNo = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.CaseVolume = new EnforceUI.TableTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.CaseItem = new EnforceUI.TableTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CasePage = new EnforceUI.TableTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.AllFondsNo = new EnforceUI.TableTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.AllCaseCatalogNo = new EnforceUI.TableTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.AllCaseVolume = new EnforceUI.TableTextBox(this.components);
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.CasePage);
            this.panelContent.Controls.Add(this.CaseItem);
            this.panelContent.Controls.Add(this.CaseVolume);
            this.panelContent.Controls.Add(this.AllCaseCatalogNo);
            this.panelContent.Controls.Add(this.AllCaseVolume);
            this.panelContent.Controls.Add(this.AllFondsNo);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.CaseEndDate);
            this.panelContent.Controls.Add(this.CaseStartDate);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.CaseHandleResult);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.CaseArchivingNo);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.CaseRetention);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.FormHeadUnitAbb);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 690);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 765);
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
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(347, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(189, 20);
            this.headerLabel1.TabIndex = 99;
            this.headerLabel1.Text = "安全生产监督管理局";
            // 
            // FormHeadUnitAbb
            // 
            this.FormHeadUnitAbb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormHeadUnitAbb.BackColor = System.Drawing.Color.White;
            this.FormHeadUnitAbb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormHeadUnitAbb.ControlText = "";
            this.FormHeadUnitAbb.Location = new System.Drawing.Point(179, 80);
            this.FormHeadUnitAbb.Name = "FormHeadUnitAbb";
            this.FormHeadUnitAbb.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormHeadUnitAbb.PopupOffset = new System.Drawing.Point(12, 0);
            this.FormHeadUnitAbb.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FormHeadUnitAbb.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormHeadUnitAbb.PopupWidth = 300;
            this.FormHeadUnitAbb.Size = new System.Drawing.Size(168, 19);
            this.FormHeadUnitAbb.TabIndex = 103;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(282, 117);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(169, 20);
            this.headerLabel2.TabIndex = 99;
            this.headerLabel2.Text = "行政处罚案件档案";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管案(2010〕号";
            this.DocTitle.Location = new System.Drawing.Point(154, 149);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 104;
            this.DocTitle.Text = "(××)安监管案(2010〕号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(124, 184);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(651, 19);
            this.CaseName.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "案件名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "处理结果：";
            // 
            // CaseHandleResult
            // 
            this.CaseHandleResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseHandleResult.ControlText = "";
            this.CaseHandleResult.Location = new System.Drawing.Point(41, 247);
            this.CaseHandleResult.Name = "CaseHandleResult";
            this.CaseHandleResult.Size = new System.Drawing.Size(734, 126);
            this.CaseHandleResult.TabIndex = 108;
            this.CaseHandleResult.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 107;
            this.label3.Text = "立案时间：";
            // 
            // CaseStartDate
            // 
            this.CaseStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseStartDate.CustomFormat = "yyyy年M月d日";
            this.CaseStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartDate.Location = new System.Drawing.Point(126, 386);
            this.CaseStartDate.Name = "CaseStartDate";
            this.CaseStartDate.Size = new System.Drawing.Size(168, 26);
            this.CaseStartDate.TabIndex = 109;
            this.CaseStartDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "结案时间：";
            // 
            // CaseEndDate
            // 
            this.CaseEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseEndDate.CustomFormat = "yyyy年M月d日";
            this.CaseEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseEndDate.Location = new System.Drawing.Point(126, 428);
            this.CaseEndDate.Name = "CaseEndDate";
            this.CaseEndDate.Size = new System.Drawing.Size(168, 26);
            this.CaseEndDate.TabIndex = 109;
            this.CaseEndDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "保管期限：";
            // 
            // CaseRetention
            // 
            this.CaseRetention.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseRetention.BackColor = System.Drawing.Color.White;
            this.CaseRetention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseRetention.ControlText = "";
            this.CaseRetention.Location = new System.Drawing.Point(124, 473);
            this.CaseRetention.Name = "CaseRetention";
            this.CaseRetention.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseRetention.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseRetention.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseRetention.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseRetention.PopupWidth = 300;
            this.CaseRetention.Size = new System.Drawing.Size(392, 19);
            this.CaseRetention.TabIndex = 105;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 513);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 110;
            this.label18.Text = "承办人：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 106;
            this.label6.Text = "归档号：";
            // 
            // CaseArchivingNo
            // 
            this.CaseArchivingNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseArchivingNo.BackColor = System.Drawing.Color.White;
            this.CaseArchivingNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseArchivingNo.ControlText = "";
            this.CaseArchivingNo.Location = new System.Drawing.Point(123, 548);
            this.CaseArchivingNo.Name = "CaseArchivingNo";
            this.CaseArchivingNo.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseArchivingNo.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseArchivingNo.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseArchivingNo.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseArchivingNo.PopupWidth = 300;
            this.CaseArchivingNo.Size = new System.Drawing.Size(392, 19);
            this.CaseArchivingNo.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "本案分正副卷，本卷为";
            // 
            // CaseVolume
            // 
            this.CaseVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseVolume.BackColor = System.Drawing.Color.White;
            this.CaseVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseVolume.ControlText = "";
            this.CaseVolume.Location = new System.Drawing.Point(226, 583);
            this.CaseVolume.Name = "CaseVolume";
            this.CaseVolume.Size = new System.Drawing.Size(77, 19);
            this.CaseVolume.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 106;
            this.label9.Text = "卷";
            // 
            // CaseItem
            // 
            this.CaseItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseItem.BackColor = System.Drawing.Color.White;
            this.CaseItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseItem.ControlText = "";
            this.CaseItem.Location = new System.Drawing.Point(339, 584);
            this.CaseItem.Name = "CaseItem";
            this.CaseItem.Size = new System.Drawing.Size(77, 19);
            this.CaseItem.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "件";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 106;
            this.label11.Text = "页";
            // 
            // CasePage
            // 
            this.CasePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CasePage.BackColor = System.Drawing.Color.White;
            this.CasePage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CasePage.ControlText = "";
            this.CasePage.Location = new System.Drawing.Point(452, 585);
            this.CasePage.Name = "CasePage";
            this.CasePage.Size = new System.Drawing.Size(77, 19);
            this.CasePage.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 622);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 110;
            this.label12.Text = "全宗号：";
            // 
            // AllFondsNo
            // 
            this.AllFondsNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllFondsNo.BackColor = System.Drawing.Color.White;
            this.AllFondsNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllFondsNo.ControlText = "";
            this.AllFondsNo.Location = new System.Drawing.Point(126, 619);
            this.AllFondsNo.Name = "AllFondsNo";
            this.AllFondsNo.Size = new System.Drawing.Size(179, 19);
            this.AllFondsNo.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 657);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 16);
            this.label13.TabIndex = 110;
            this.label13.Text = "目录号（类别号）：";
            // 
            // AllCaseCatalogNo
            // 
            this.AllCaseCatalogNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllCaseCatalogNo.BackColor = System.Drawing.Color.White;
            this.AllCaseCatalogNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllCaseCatalogNo.ControlText = "";
            this.AllCaseCatalogNo.Location = new System.Drawing.Point(200, 654);
            this.AllCaseCatalogNo.Name = "AllCaseCatalogNo";
            this.AllCaseCatalogNo.Size = new System.Drawing.Size(179, 19);
            this.AllCaseCatalogNo.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 690);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 110;
            this.label14.Text = "案卷号：";
            // 
            // AllCaseVolume
            // 
            this.AllCaseVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllCaseVolume.BackColor = System.Drawing.Color.White;
            this.AllCaseVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllCaseVolume.ControlText = "";
            this.AllCaseVolume.Location = new System.Drawing.Point(126, 687);
            this.AllCaseVolume.Name = "AllCaseVolume";
            this.AllCaseVolume.Size = new System.Drawing.Size(179, 19);
            this.AllCaseVolume.TabIndex = 111;
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(330, 514);
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
            this.UserName1.Location = new System.Drawing.Point(124, 514);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(170, 19);
            this.UserName1.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "、";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 130;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditSurveyEndReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditSurveyEndReport";
            this.Size = new System.Drawing.Size(886, 800);
            this.Load += new System.EventHandler(this.frmEditSurveyEndReport_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox FormHeadUnitAbb;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableTextTitle DocTitle;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableRichTextBox CaseHandleResult;
        private EnforceUI.TableDateTimePicker CaseEndDate;
        private EnforceUI.TableDateTimePicker CaseStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox CaseRetention;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableTextBox CasePage;
        private EnforceUI.TableTextBox CaseItem;
        private EnforceUI.TableTextBox CaseVolume;
        private EnforceUI.TableTextBox AllCaseCatalogNo;
        private EnforceUI.TableTextBox AllCaseVolume;
        private EnforceUI.TableTextBox AllFondsNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox CaseArchivingNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
        private System.Windows.Forms.Button button1;
    }
}

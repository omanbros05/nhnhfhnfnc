namespace EnforceForm
{
    partial class frmInCaseOfTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInCaseOfTable));
            this.CaseSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordPeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordFName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PutOnRecordCaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UndertakerOpinion = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IllegalFact = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GeneralCase = new EnforceUI.TableRichTextBox(this.components);
            this.UndertakerData = new EnforceUI.TableDateTimePicker(this.components);
            this.UndertakerUserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.UndertakerUserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panelContent.Controls.Add(this.UndertakerData);
            this.panelContent.Controls.Add(this.UndertakerUserName2);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.UndertakerUserName1);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.CaseSourceName);
            this.panelContent.Controls.Add(this.PutOnRecordPeopleAddress);
            this.panelContent.Controls.Add(this.PutOnRecordFName);
            this.panelContent.Controls.Add(this.PutOnRecordPeopleName);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.PutOnRecordCaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(815, 834);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 909);
            this.panel1.Size = new System.Drawing.Size(815, 41);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(815, 75);
            this.header1.Title = "案件处理呈批表 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseSourceName.BackColor = System.Drawing.Color.White;
            this.CaseSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.ControlText = "";
            this.CaseSourceName.Location = new System.Drawing.Point(386, 275);
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSourceName.PopupWidth = 300;
            this.CaseSourceName.Size = new System.Drawing.Size(283, 19);
            this.CaseSourceName.TabIndex = 165;
            // 
            // PutOnRecordPeopleAddress
            // 
            this.PutOnRecordPeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordPeopleAddress.BackColor = System.Drawing.Color.White;
            this.PutOnRecordPeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleAddress.ControlText = "";
            this.PutOnRecordPeopleAddress.Location = new System.Drawing.Point(124, 274);
            this.PutOnRecordPeopleAddress.Name = "PutOnRecordPeopleAddress";
            this.PutOnRecordPeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordPeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordPeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordPeopleAddress.PopupWidth = 300;
            this.PutOnRecordPeopleAddress.Size = new System.Drawing.Size(160, 19);
            this.PutOnRecordPeopleAddress.TabIndex = 163;
            // 
            // PutOnRecordFName
            // 
            this.PutOnRecordFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordFName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordFName.ControlText = "";
            this.PutOnRecordFName.Location = new System.Drawing.Point(501, 231);
            this.PutOnRecordFName.Name = "PutOnRecordFName";
            this.PutOnRecordFName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordFName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordFName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordFName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordFName.PopupWidth = 300;
            this.PutOnRecordFName.Size = new System.Drawing.Size(168, 19);
            this.PutOnRecordFName.TabIndex = 162;
            // 
            // PutOnRecordPeopleName
            // 
            this.PutOnRecordPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordPeopleName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleName.ControlText = "";
            this.PutOnRecordPeopleName.Location = new System.Drawing.Point(124, 231);
            this.PutOnRecordPeopleName.Name = "PutOnRecordPeopleName";
            this.PutOnRecordPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordPeopleName.PopupWidth = 300;
            this.PutOnRecordPeopleName.Size = new System.Drawing.Size(160, 19);
            this.PutOnRecordPeopleName.TabIndex = 160;
            this.PutOnRecordPeopleName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.PutOnRecordPeopleName_SelectedValueChangedEvent);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 158;
            this.label10.Text = "案件来源：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 153;
            this.label6.Text = "法定代表人（主要负责人）";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 151;
            this.label4.Text = "地　　址：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 155;
            this.label5.Text = "当  事  人：";
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.ControlText = "";
            this.PutOnRecordCaseName.Location = new System.Drawing.Point(124, 183);
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseName.PopupWidth = 300;
            this.PutOnRecordCaseName.Size = new System.Drawing.Size(545, 19);
            this.PutOnRecordCaseName.TabIndex = 150;
            this.PutOnRecordCaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.PutOnRecordCaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 149;
            this.label1.Text = "案件名称：";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管处呈〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(183, 142);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 148;
            this.DocTitle.Text = "(××)安监管处呈〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(289, 110);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 146;
            this.headerLabel2.Text = "案件处理呈批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-16, 103);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 147;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(255, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 145;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.UndertakerOpinion);
            this.groupBox3.Location = new System.Drawing.Point(41, 650);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 162);
            this.groupBox3.TabIndex = 168;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "承办人意见：";
            // 
            // UndertakerOpinion
            // 
            this.UndertakerOpinion.ControlText = "";
            this.UndertakerOpinion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndertakerOpinion.Location = new System.Drawing.Point(3, 22);
            this.UndertakerOpinion.Name = "UndertakerOpinion";
            this.UndertakerOpinion.Size = new System.Drawing.Size(671, 137);
            this.UndertakerOpinion.TabIndex = 1;
            this.UndertakerOpinion.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.IllegalFact);
            this.groupBox2.Location = new System.Drawing.Point(41, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 162);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "违法事实：";
            // 
            // IllegalFact
            // 
            this.IllegalFact.ControlText = "";
            this.IllegalFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IllegalFact.Location = new System.Drawing.Point(3, 22);
            this.IllegalFact.Name = "IllegalFact";
            this.IllegalFact.Size = new System.Drawing.Size(671, 137);
            this.IllegalFact.TabIndex = 1;
            this.IllegalFact.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.GeneralCase);
            this.groupBox1.Location = new System.Drawing.Point(41, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 162);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案情概况：";
            // 
            // GeneralCase
            // 
            this.GeneralCase.ControlText = "";
            this.GeneralCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralCase.Location = new System.Drawing.Point(3, 22);
            this.GeneralCase.Name = "GeneralCase";
            this.GeneralCase.Size = new System.Drawing.Size(671, 137);
            this.GeneralCase.TabIndex = 1;
            this.GeneralCase.Text = "";
            // 
            // UndertakerData
            // 
            this.UndertakerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerData.CustomFormat = "yyyy年M月d日";
            this.UndertakerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UndertakerData.Location = new System.Drawing.Point(532, 834);
            this.UndertakerData.Name = "UndertakerData";
            this.UndertakerData.Size = new System.Drawing.Size(183, 26);
            this.UndertakerData.TabIndex = 173;
            this.UndertakerData.Value = new System.DateTime(2013, 3, 10, 19, 23, 4, 562);
            // 
            // UndertakerUserName2
            // 
            this.UndertakerUserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName2.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.ControlText = "";
            this.UndertakerUserName2.Location = new System.Drawing.Point(341, 839);
            this.UndertakerUserName2.Name = "UndertakerUserName2";
            this.UndertakerUserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName2.PopupWidth = 300;
            this.UndertakerUserName2.Size = new System.Drawing.Size(150, 19);
            this.UndertakerUserName2.TabIndex = 172;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 839);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 171;
            this.label13.Text = "、";
            // 
            // UndertakerUserName1
            // 
            this.UndertakerUserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName1.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.ControlText = "";
            this.UndertakerUserName1.Location = new System.Drawing.Point(150, 839);
            this.UndertakerUserName1.Name = "UndertakerUserName1";
            this.UndertakerUserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName1.PopupWidth = 300;
            this.UndertakerUserName1.Size = new System.Drawing.Size(150, 19);
            this.UndertakerUserName1.TabIndex = 170;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 839);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 169;
            this.label12.Text = "案件承办人：";
            // 
            // frmInCaseOfTable
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmInCaseOfTable";
            this.Size = new System.Drawing.Size(815, 950);
            this.Load += new System.EventHandler(this.frmInCaseOfTable_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox CaseSourceName;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordPeopleAddress;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordFName;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordPeopleName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName2;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName1;
        private System.Windows.Forms.Label label12;
        private EnforceUI.TableRichTextBox UndertakerOpinion;
        private EnforceUI.TableRichTextBox IllegalFact;
        private EnforceUI.TableRichTextBox GeneralCase;
        private EnforceUI.TableDateTimePicker UndertakerData;
    }
}

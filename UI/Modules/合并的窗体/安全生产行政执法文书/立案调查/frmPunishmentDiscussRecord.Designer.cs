namespace EnforceForm
{
    partial class frmPunishmentDiscussRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPunishmentDiscussRecord));
            this.HostName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DiscussDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DiscussAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordCaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RecordUserName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PDRPeople1 = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiscussContent = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RecordContent = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Conclusion = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PDRPeople2 = new EnforceUI.TableRichTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.groupBox5);
            this.panelContent.Controls.Add(this.groupBox4);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.RecordUserName);
            this.panelContent.Controls.Add(this.ReportName);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.HostName);
            this.panelContent.Controls.Add(this.DiscussDate);
            this.panelContent.Controls.Add(this.DiscussAddress);
            this.panelContent.Controls.Add(this.PutOnRecordCaseName);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(823, 1299);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1374);
            this.panel1.Size = new System.Drawing.Size(823, 46);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(823, 75);
            this.header1.Title = "行政处罚集体讨论记录 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // HostName
            // 
            this.HostName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HostName.BackColor = System.Drawing.Color.White;
            this.HostName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostName.ControlText = "";
            this.HostName.Location = new System.Drawing.Point(111, 241);
            this.HostName.Name = "HostName";
            this.HostName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostName.PopupOffset = new System.Drawing.Point(12, 0);
            this.HostName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HostName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HostName.PopupWidth = 300;
            this.HostName.Size = new System.Drawing.Size(138, 19);
            this.HostName.TabIndex = 9;
            // 
            // DiscussDate
            // 
            this.DiscussDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiscussDate.CustomFormat = "yyyy年M月d日";
            this.DiscussDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DiscussDate.Location = new System.Drawing.Point(132, 190);
            this.DiscussDate.Name = "DiscussDate";
            this.DiscussDate.Size = new System.Drawing.Size(158, 26);
            this.DiscussDate.TabIndex = 5;
            this.DiscussDate.Value = new System.DateTime(2013, 3, 10, 20, 58, 7, 346);
            // 
            // DiscussAddress
            // 
            this.DiscussAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiscussAddress.BackColor = System.Drawing.Color.White;
            this.DiscussAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscussAddress.ControlText = "";
            this.DiscussAddress.Location = new System.Drawing.Point(367, 195);
            this.DiscussAddress.Name = "DiscussAddress";
            this.DiscussAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscussAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.DiscussAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DiscussAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DiscussAddress.PopupWidth = 300;
            this.DiscussAddress.Size = new System.Drawing.Size(315, 19);
            this.DiscussAddress.TabIndex = 7;
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.ControlText = "";
            this.PutOnRecordCaseName.Location = new System.Drawing.Point(127, 144);
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseName.PopupWidth = 300;
            this.PutOnRecordCaseName.Size = new System.Drawing.Size(555, 19);
            this.PutOnRecordCaseName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "；地点：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "讨论时间：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(267, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(209, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "行政处罚集体讨论记录";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-4, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 314;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(267, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "案件名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "主持人：";
            // 
            // ReportName
            // 
            this.ReportName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportName.BackColor = System.Drawing.Color.White;
            this.ReportName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportName.ControlText = "";
            this.ReportName.Location = new System.Drawing.Point(322, 242);
            this.ReportName.Name = "ReportName";
            this.ReportName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportName.PopupOffset = new System.Drawing.Point(12, 0);
            this.ReportName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ReportName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReportName.PopupWidth = 300;
            this.ReportName.Size = new System.Drawing.Size(137, 19);
            this.ReportName.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "汇报人：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "记录人：";
            // 
            // RecordUserName
            // 
            this.RecordUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordUserName.BackColor = System.Drawing.Color.White;
            this.RecordUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordUserName.ControlText = "";
            this.RecordUserName.Location = new System.Drawing.Point(549, 242);
            this.RecordUserName.Name = "RecordUserName";
            this.RecordUserName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordUserName.PopupOffset = new System.Drawing.Point(12, 0);
            this.RecordUserName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.RecordUserName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RecordUserName.PopupWidth = 300;
            this.RecordUserName.Size = new System.Drawing.Size(133, 19);
            this.RecordUserName.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.PDRPeople1);
            this.groupBox2.Location = new System.Drawing.Point(49, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 163);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出席人员姓名及职务：";
            // 
            // PDRPeople1
            // 
            this.PDRPeople1.ControlText = "";
            this.PDRPeople1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDRPeople1.Location = new System.Drawing.Point(3, 22);
            this.PDRPeople1.Name = "PDRPeople1";
            this.PDRPeople1.Size = new System.Drawing.Size(627, 138);
            this.PDRPeople1.TabIndex = 0;
            this.PDRPeople1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.DiscussContent);
            this.groupBox1.Location = new System.Drawing.Point(49, 631);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "讨论内容：";
            // 
            // DiscussContent
            // 
            this.DiscussContent.ControlText = "";
            this.DiscussContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscussContent.Location = new System.Drawing.Point(3, 22);
            this.DiscussContent.Name = "DiscussContent";
            this.DiscussContent.Size = new System.Drawing.Size(626, 141);
            this.DiscussContent.TabIndex = 0;
            this.DiscussContent.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.RecordContent);
            this.groupBox3.Location = new System.Drawing.Point(49, 805);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 384);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "讨论记录：";
            // 
            // RecordContent
            // 
            this.RecordContent.ControlText = "";
            this.RecordContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordContent.Location = new System.Drawing.Point(3, 22);
            this.RecordContent.Name = "RecordContent";
            this.RecordContent.Size = new System.Drawing.Size(626, 359);
            this.RecordContent.TabIndex = 0;
            this.RecordContent.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.Conclusion);
            this.groupBox4.Location = new System.Drawing.Point(49, 1197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 166);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "结论性意见：";
            // 
            // Conclusion
            // 
            this.Conclusion.ControlText = "";
            this.Conclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Conclusion.Location = new System.Drawing.Point(3, 22);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(626, 141);
            this.Conclusion.TabIndex = 0;
            this.Conclusion.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.PDRPeople2);
            this.groupBox5.Location = new System.Drawing.Point(49, 460);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 163);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "列席人员：";
            // 
            // PDRPeople2
            // 
            this.PDRPeople2.ControlText = "";
            this.PDRPeople2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDRPeople2.Location = new System.Drawing.Point(3, 22);
            this.PDRPeople2.Name = "PDRPeople2";
            this.PDRPeople2.Size = new System.Drawing.Size(627, 138);
            this.PDRPeople2.TabIndex = 0;
            this.PDRPeople2.Text = "";
            // 
            // frmPunishmentDiscussRecord
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmPunishmentDiscussRecord";
            this.Size = new System.Drawing.Size(823, 1420);
            this.Load += new System.EventHandler(this.frmPunishmentDiscussRecord_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox HostName;
        private EnforceUI.TableDateTimePicker DiscussDate;
        private EnforceUI.TableAutoCompleteTextBox DiscussAddress;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox RecordUserName;
        private EnforceUI.TableAutoCompleteTextBox ReportName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private EnforceUI.TableRichTextBox Conclusion;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox RecordContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox DiscussContent;
        private System.Windows.Forms.GroupBox groupBox5;
        private EnforceUI.TableRichTextBox PDRPeople2;
        private EnforceUI.TableRichTextBox PDRPeople1;

    }
}

namespace EnforceForm
{
    partial class frmCaseCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaseCancel));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RevocationReason = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResearchDetail = new EnforceUI.TableRichTextBox(this.components);
            this.PutOnRecordSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordFName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordDocTitle = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordThisDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PutOnRecordCaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.UndertakerData = new EnforceUI.TableDateTimePicker(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PutOnRecordPeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordPeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordUserNames2 = new EnforceUI.TableTextBox(this.components);
            this.PutOnRecordUserNames1 = new EnforceUI.TableTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.UndertakerUserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UndertakerUserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
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
            this.panelContent.Controls.Add(this.UndertakerUserName2);
            this.panelContent.Controls.Add(this.UndertakerUserName1);
            this.panelContent.Controls.Add(this.PutOnRecordUserNames2);
            this.panelContent.Controls.Add(this.PutOnRecordUserNames1);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.UndertakerData);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.PutOnRecordPeoplePhone);
            this.panelContent.Controls.Add(this.PutOnRecordPeopleAddress);
            this.panelContent.Controls.Add(this.PutOnRecordSourceName);
            this.panelContent.Controls.Add(this.PutOnRecordFName);
            this.panelContent.Controls.Add(this.PutOnRecordPeopleName);
            this.panelContent.Controls.Add(this.PutOnRecordDocTitle);
            this.panelContent.Controls.Add(this.PutOnRecordThisDate);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.PutOnRecordCaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(815, 790);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 865);
            this.panel1.Size = new System.Drawing.Size(815, 35);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(815, 75);
            this.header1.Title = "案件终止或撤销审批表 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.RevocationReason);
            this.groupBox2.Location = new System.Drawing.Point(57, 610);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 160);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "（撤销）理由：";
            // 
            // RevocationReason
            // 
            this.RevocationReason.ControlText = "";
            this.RevocationReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevocationReason.Location = new System.Drawing.Point(3, 22);
            this.RevocationReason.Name = "RevocationReason";
            this.RevocationReason.Size = new System.Drawing.Size(622, 135);
            this.RevocationReason.TabIndex = 0;
            this.RevocationReason.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.ResearchDetail);
            this.groupBox1.Location = new System.Drawing.Point(57, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 177);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案件调查情况：";
            // 
            // ResearchDetail
            // 
            this.ResearchDetail.ControlText = "";
            this.ResearchDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResearchDetail.Location = new System.Drawing.Point(3, 22);
            this.ResearchDetail.Name = "ResearchDetail";
            this.ResearchDetail.Size = new System.Drawing.Size(622, 152);
            this.ResearchDetail.TabIndex = 0;
            this.ResearchDetail.Text = "";
            // 
            // PutOnRecordSourceName
            // 
            this.PutOnRecordSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordSourceName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordSourceName.ControlText = "";
            this.PutOnRecordSourceName.Location = new System.Drawing.Point(140, 360);
            this.PutOnRecordSourceName.Name = "PutOnRecordSourceName";
            this.PutOnRecordSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordSourceName.PopupWidth = 300;
            this.PutOnRecordSourceName.Size = new System.Drawing.Size(160, 19);
            this.PutOnRecordSourceName.TabIndex = 18;
            // 
            // PutOnRecordFName
            // 
            this.PutOnRecordFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordFName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordFName.ControlText = "";
            this.PutOnRecordFName.Location = new System.Drawing.Point(517, 269);
            this.PutOnRecordFName.Name = "PutOnRecordFName";
            this.PutOnRecordFName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordFName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordFName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordFName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordFName.PopupWidth = 300;
            this.PutOnRecordFName.Size = new System.Drawing.Size(168, 19);
            this.PutOnRecordFName.TabIndex = 12;
            // 
            // PutOnRecordPeopleName
            // 
            this.PutOnRecordPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordPeopleName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleName.ControlText = "";
            this.PutOnRecordPeopleName.Location = new System.Drawing.Point(140, 269);
            this.PutOnRecordPeopleName.Name = "PutOnRecordPeopleName";
            this.PutOnRecordPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordPeopleName.PopupWidth = 300;
            this.PutOnRecordPeopleName.Size = new System.Drawing.Size(160, 19);
            this.PutOnRecordPeopleName.TabIndex = 10;
            // 
            // PutOnRecordDocTitle
            // 
            this.PutOnRecordDocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordDocTitle.BackColor = System.Drawing.Color.White;
            this.PutOnRecordDocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordDocTitle.ControlText = "";
            this.PutOnRecordDocTitle.Location = new System.Drawing.Point(382, 226);
            this.PutOnRecordDocTitle.Name = "PutOnRecordDocTitle";
            this.PutOnRecordDocTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordDocTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordDocTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordDocTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordDocTitle.PopupWidth = 300;
            this.PutOnRecordDocTitle.Size = new System.Drawing.Size(303, 19);
            this.PutOnRecordDocTitle.TabIndex = 8;
            // 
            // PutOnRecordThisDate
            // 
            this.PutOnRecordThisDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordThisDate.CustomFormat = "yyyy年M月d日";
            this.PutOnRecordThisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PutOnRecordThisDate.Location = new System.Drawing.Point(140, 220);
            this.PutOnRecordThisDate.Name = "PutOnRecordThisDate";
            this.PutOnRecordThisDate.Size = new System.Drawing.Size(160, 26);
            this.PutOnRecordThisDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "立案日期：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "承办人：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "法定代表人（主要负责人）";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "案件来源：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "当  事  人：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "立案号：";
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.ControlText = "";
            this.PutOnRecordCaseName.Location = new System.Drawing.Point(140, 182);
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseName.PopupWidth = 300;
            this.PutOnRecordCaseName.Size = new System.Drawing.Size(545, 19);
            this.PutOnRecordCaseName.TabIndex = 4;
            this.PutOnRecordCaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.PutOnRecordCaseName_SelectedValueChangedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "案件名称：";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管撤〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(197, 141);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管撤〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(305, 109);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "案件撤销审批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(0, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 115;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(271, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // UndertakerData
            // 
            this.UndertakerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerData.CustomFormat = "yyyy年M月d日";
            this.UndertakerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UndertakerData.Location = new System.Drawing.Point(517, 791);
            this.UndertakerData.Name = "UndertakerData";
            this.UndertakerData.Size = new System.Drawing.Size(168, 26);
            this.UndertakerData.TabIndex = 29;
            this.UndertakerData.Value = new System.DateTime(2013, 3, 9, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 795);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 16);
            this.label19.TabIndex = 27;
            this.label19.Text = "、";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 796);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "承办人：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "地　　址：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "电　话：";
            // 
            // PutOnRecordPeopleAddress
            // 
            this.PutOnRecordPeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordPeopleAddress.BackColor = System.Drawing.Color.White;
            this.PutOnRecordPeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleAddress.ControlText = "";
            this.PutOnRecordPeopleAddress.Location = new System.Drawing.Point(140, 312);
            this.PutOnRecordPeopleAddress.Name = "PutOnRecordPeopleAddress";
            this.PutOnRecordPeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordPeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordPeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordPeopleAddress.PopupWidth = 300;
            this.PutOnRecordPeopleAddress.Size = new System.Drawing.Size(160, 19);
            this.PutOnRecordPeopleAddress.TabIndex = 14;
            // 
            // PutOnRecordPeoplePhone
            // 
            this.PutOnRecordPeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordPeoplePhone.BackColor = System.Drawing.Color.White;
            this.PutOnRecordPeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeoplePhone.ControlText = "";
            this.PutOnRecordPeoplePhone.Location = new System.Drawing.Point(382, 313);
            this.PutOnRecordPeoplePhone.Name = "PutOnRecordPeoplePhone";
            this.PutOnRecordPeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordPeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordPeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordPeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordPeoplePhone.PopupWidth = 300;
            this.PutOnRecordPeoplePhone.Size = new System.Drawing.Size(303, 19);
            this.PutOnRecordPeoplePhone.TabIndex = 16;
            // 
            // PutOnRecordUserNames2
            // 
            this.PutOnRecordUserNames2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordUserNames2.BackColor = System.Drawing.Color.White;
            this.PutOnRecordUserNames2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordUserNames2.ControlText = "";
            this.PutOnRecordUserNames2.Location = new System.Drawing.Point(554, 361);
            this.PutOnRecordUserNames2.Name = "PutOnRecordUserNames2";
            this.PutOnRecordUserNames2.Size = new System.Drawing.Size(131, 19);
            this.PutOnRecordUserNames2.TabIndex = 22;
            // 
            // PutOnRecordUserNames1
            // 
            this.PutOnRecordUserNames1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordUserNames1.BackColor = System.Drawing.Color.White;
            this.PutOnRecordUserNames1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordUserNames1.ControlText = "";
            this.PutOnRecordUserNames1.Location = new System.Drawing.Point(382, 361);
            this.PutOnRecordUserNames1.Name = "PutOnRecordUserNames1";
            this.PutOnRecordUserNames1.Size = new System.Drawing.Size(135, 19);
            this.PutOnRecordUserNames1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "、";
            // 
            // UndertakerUserName1
            // 
            this.UndertakerUserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName1.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.ControlText = "";
            this.UndertakerUserName1.Location = new System.Drawing.Point(119, 798);
            this.UndertakerUserName1.Name = "UndertakerUserName1";
            this.UndertakerUserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName1.PopupWidth = 300;
            this.UndertakerUserName1.Size = new System.Drawing.Size(135, 19);
            this.UndertakerUserName1.TabIndex = 26;
            // 
            // UndertakerUserName2
            // 
            this.UndertakerUserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName2.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.ControlText = "";
            this.UndertakerUserName2.Location = new System.Drawing.Point(291, 798);
            this.UndertakerUserName2.Name = "UndertakerUserName2";
            this.UndertakerUserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName2.PopupWidth = 300;
            this.UndertakerUserName2.Size = new System.Drawing.Size(135, 19);
            this.UndertakerUserName2.TabIndex = 28;
            // 
            // frmCaseCancel
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmCaseCancel";
            this.Size = new System.Drawing.Size(815, 900);
            this.Load += new System.EventHandler(this.frmCaseCancel_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox RevocationReason;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox ResearchDetail;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordSourceName;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordFName;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordPeopleName;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordDocTitle;
        private EnforceUI.TableDateTimePicker PutOnRecordThisDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableTextBox PutOnRecordUserNames2;
        private EnforceUI.TableTextBox PutOnRecordUserNames1;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableDateTimePicker UndertakerData;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordPeoplePhone;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordPeopleAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName2;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName1;

    }
}

namespace EnforceForm
{
    partial class frmPutOnRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPutOnRecord));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IllegalTypeName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ThisDate = new EnforceUI.TableDateTimePicker(this.components);
            this.CaseSourceName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeopleCondition = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PeopleZip = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaseStatus = new EnforceUI.TableRichTextBox(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UndertakerOpinion = new EnforceUI.TableRichTextBox(this.components);
            this.UndertakerData = new EnforceUI.TableDateTimePicker(this.components);
            this.UndertakerUserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UndertakerUserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panelContent.Controls.Add(this.UndertakerData);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.PeopleZip);
            this.panelContent.Controls.Add(this.PeopleAddress);
            this.panelContent.Controls.Add(this.PeoplePhone);
            this.panelContent.Controls.Add(this.PeopleCondition);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.CaseSourceName);
            this.panelContent.Controls.Add(this.ThisDate);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.IllegalTypeName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(813, 709);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 784);
            this.panel1.Size = new System.Drawing.Size(813, 46);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(813, 75);
            this.header1.Title = "立案审批表 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(261, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(109, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "立案审批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-60, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 4;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(211, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管立〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(137, 140);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管立〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-7, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "案　　由：";
            // 
            // IllegalTypeName
            // 
            this.IllegalTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IllegalTypeName.BackColor = System.Drawing.Color.White;
            this.IllegalTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.ControlText = "";
            this.IllegalTypeName.Location = new System.Drawing.Point(80, 181);
            this.IllegalTypeName.Name = "IllegalTypeName";
            this.IllegalTypeName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.PopupOffset = new System.Drawing.Point(12, 0);
            this.IllegalTypeName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.IllegalTypeName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.IllegalTypeName.PopupWidth = 300;
            this.IllegalTypeName.Size = new System.Drawing.Size(545, 19);
            this.IllegalTypeName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-7, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "案件来源：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "时间：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-7, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "案件名称：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-7, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "当事单位：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "电话：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-7, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "当事人基本情况：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-7, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "当事人地址：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "邮编：";
            // 
            // ThisDate
            // 
            this.ThisDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ThisDate.CustomFormat = "yyyy年M月d日 H时  m分";
            this.ThisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThisDate.Location = new System.Drawing.Point(381, 219);
            this.ThisDate.Name = "ThisDate";
            this.ThisDate.Size = new System.Drawing.Size(244, 26);
            this.ThisDate.TabIndex = 8;
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseSourceName.BackColor = System.Drawing.Color.White;
            this.CaseSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.ControlText = "";
            this.CaseSourceName.Location = new System.Drawing.Point(80, 223);
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseSourceName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseSourceName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseSourceName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSourceName.PopupWidth = 300;
            this.CaseSourceName.Size = new System.Drawing.Size(232, 19);
            this.CaseSourceName.TabIndex = 6;
            // 
            // PeopleCondition
            // 
            this.PeopleCondition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeopleCondition.BackColor = System.Drawing.Color.White;
            this.PeopleCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleCondition.ControlText = "";
            this.PeopleCondition.Location = new System.Drawing.Point(121, 349);
            this.PeopleCondition.Name = "PeopleCondition";
            this.PeopleCondition.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleCondition.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeopleCondition.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeopleCondition.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeopleCondition.PopupWidth = 300;
            this.PeopleCondition.Size = new System.Drawing.Size(504, 19);
            this.PeopleCondition.TabIndex = 16;
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(80, 307);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(232, 19);
            this.CompanyName.TabIndex = 12;
            this.CompanyName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CompanyName_SelectedValueChangedEvent);
            // 
            // PeoplePhone
            // 
            this.PeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeoplePhone.BackColor = System.Drawing.Color.White;
            this.PeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeoplePhone.ControlText = "";
            this.PeoplePhone.Location = new System.Drawing.Point(381, 307);
            this.PeoplePhone.Name = "PeoplePhone";
            this.PeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeoplePhone.PopupWidth = 300;
            this.PeoplePhone.Size = new System.Drawing.Size(244, 19);
            this.PeoplePhone.TabIndex = 14;
            // 
            // PeopleAddress
            // 
            this.PeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeopleAddress.BackColor = System.Drawing.Color.White;
            this.PeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleAddress.ControlText = "";
            this.PeopleAddress.Location = new System.Drawing.Point(92, 381);
            this.PeopleAddress.Name = "PeopleAddress";
            this.PeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeopleAddress.PopupWidth = 300;
            this.PeopleAddress.Size = new System.Drawing.Size(222, 19);
            this.PeopleAddress.TabIndex = 18;
            // 
            // PeopleZip
            // 
            this.PeopleZip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PeopleZip.BackColor = System.Drawing.Color.White;
            this.PeopleZip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleZip.ControlText = "";
            this.PeopleZip.Location = new System.Drawing.Point(381, 381);
            this.PeopleZip.Name = "PeopleZip";
            this.PeopleZip.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleZip.PopupOffset = new System.Drawing.Point(12, 0);
            this.PeopleZip.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PeopleZip.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PeopleZip.PopupWidth = 300;
            this.PeopleZip.Size = new System.Drawing.Size(244, 19);
            this.PeopleZip.TabIndex = 20;
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(80, 265);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(545, 19);
            this.CaseName.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CaseStatus);
            this.groupBox1.Location = new System.Drawing.Point(-3, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 219);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案件基本情况：";
            // 
            // CaseStatus
            // 
            this.CaseStatus.ControlText = "";
            this.CaseStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaseStatus.Location = new System.Drawing.Point(3, 22);
            this.CaseStatus.Name = "CaseStatus";
            this.CaseStatus.Size = new System.Drawing.Size(622, 194);
            this.CaseStatus.TabIndex = 0;
            this.CaseStatus.Text = "";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 811);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "、";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-4, 812);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "承办人：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.UndertakerOpinion);
            this.groupBox2.Location = new System.Drawing.Point(-3, 650);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 145);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "承办人意见";
            // 
            // UndertakerOpinion
            // 
            this.UndertakerOpinion.ControlText = "";
            this.UndertakerOpinion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndertakerOpinion.Location = new System.Drawing.Point(3, 22);
            this.UndertakerOpinion.Name = "UndertakerOpinion";
            this.UndertakerOpinion.Size = new System.Drawing.Size(622, 120);
            this.UndertakerOpinion.TabIndex = 0;
            this.UndertakerOpinion.Text = "";
            // 
            // UndertakerData
            // 
            this.UndertakerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerData.CustomFormat = "yyyy年M月d日";
            this.UndertakerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UndertakerData.Location = new System.Drawing.Point(457, 817);
            this.UndertakerData.Name = "UndertakerData";
            this.UndertakerData.Size = new System.Drawing.Size(168, 26);
            this.UndertakerData.TabIndex = 27;
            this.UndertakerData.Value = new System.DateTime(2013, 3, 21, 21, 2, 0, 0);
            // 
            // UndertakerUserName1
            // 
            this.UndertakerUserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName1.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.ControlText = "";
            this.UndertakerUserName1.Location = new System.Drawing.Point(58, 814);
            this.UndertakerUserName1.Name = "UndertakerUserName1";
            this.UndertakerUserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName1.PopupWidth = 300;
            this.UndertakerUserName1.Size = new System.Drawing.Size(139, 19);
            this.UndertakerUserName1.TabIndex = 24;
            // 
            // UndertakerUserName2
            // 
            this.UndertakerUserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName2.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.ControlText = "";
            this.UndertakerUserName2.Location = new System.Drawing.Point(234, 814);
            this.UndertakerUserName2.Name = "UndertakerUserName2";
            this.UndertakerUserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName2.PopupWidth = 300;
            this.UndertakerUserName2.Size = new System.Drawing.Size(139, 19);
            this.UndertakerUserName2.TabIndex = 26;
            // 
            // frmPutOnRecord
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmPutOnRecord";
            this.Size = new System.Drawing.Size(813, 830);
            this.Load += new System.EventHandler(this.frmPutOnRecord_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableTextTitle DocTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox IllegalTypeName;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private EnforceUI.TableAutoCompleteTextBox PeopleZip;
        private EnforceUI.TableAutoCompleteTextBox PeopleAddress;
        private EnforceUI.TableAutoCompleteTextBox PeoplePhone;
        private EnforceUI.TableAutoCompleteTextBox PeopleCondition;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.TableAutoCompleteTextBox CaseSourceName;
        private EnforceUI.TableDateTimePicker ThisDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox CaseStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox UndertakerOpinion;
        private EnforceUI.TableDateTimePicker UndertakerData;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName2;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName1;


    }
}

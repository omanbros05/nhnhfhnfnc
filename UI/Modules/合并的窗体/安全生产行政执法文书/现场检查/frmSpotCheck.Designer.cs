namespace EnforceForm
{
    partial class frmSpotCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpotCheck));
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.CompanyAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.JuridicalName = new EnforceUI.TableTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.JuridicalJob = new EnforceUI.TableTextBox(this.components);
            this.JuridicalTel = new EnforceUI.TableTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Area = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.OfficerName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.OfficerName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CID1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.CID2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckCondition = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpotCondition = new EnforceUI.TableRichTextBox(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SiteJuridical = new EnforceUI.TableTextBox(this.components);
            this.CheckPerson1 = new EnforceUI.TableTextBox(this.components);
            this.CheckPerson2 = new EnforceUI.TableTextBox(this.components);
            this.CheckStartTime = new EnforceUI.TableDateTimePicker(this.components);
            this.CheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.CheckEndTime = new EnforceUI.TableDateTimePicker(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panelContent.Controls.Add(this.CheckEndTime);
            this.panelContent.Controls.Add(this.CheckDate);
            this.panelContent.Controls.Add(this.CheckStartTime);
            this.panelContent.Controls.Add(this.CheckPerson2);
            this.panelContent.Controls.Add(this.CheckPerson1);
            this.panelContent.Controls.Add(this.SiteJuridical);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.CID2);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.CID1);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.OfficerName2);
            this.panelContent.Controls.Add(this.OfficerName1);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.Area);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.CheckAddress);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.JuridicalTel);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.JuridicalJob);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.JuridicalName);
            this.panelContent.Controls.Add(this.CompanyAddress);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(1135, 848);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 923);
            this.panel1.Size = new System.Drawing.Size(1135, 44);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(1135, 75);
            this.header1.Title = "现场检查记录 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // btnLaw
            // 
            this.btnLaw.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(413, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(142, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 1;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(453, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "现场检查记录";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "被检查单位：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "地  址：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "法定代表人（负责人）:";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(294, 132);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(573, 19);
            this.CompanyName.TabIndex = 3;
            this.CompanyName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CompanyName_SelectedValueChangedEvent);
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyAddress.BackColor = System.Drawing.Color.White;
            this.CompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyAddress.ControlText = "";
            this.CompanyAddress.Location = new System.Drawing.Point(259, 161);
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyAddress.PopupWidth = 300;
            this.CompanyAddress.Size = new System.Drawing.Size(608, 19);
            this.CompanyAddress.TabIndex = 5;
            // 
            // JuridicalName
            // 
            this.JuridicalName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalName.BackColor = System.Drawing.Color.White;
            this.JuridicalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalName.ControlText = "";
            this.JuridicalName.Location = new System.Drawing.Point(362, 197);
            this.JuridicalName.Name = "JuridicalName";
            this.JuridicalName.Size = new System.Drawing.Size(125, 19);
            this.JuridicalName.TabIndex = 7;
            this.JuridicalName.TextChanged += new System.EventHandler(this.JuridicalName_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "职务:";
            // 
            // JuridicalJob
            // 
            this.JuridicalJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalJob.BackColor = System.Drawing.Color.White;
            this.JuridicalJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalJob.ControlText = "";
            this.JuridicalJob.Location = new System.Drawing.Point(545, 197);
            this.JuridicalJob.Name = "JuridicalJob";
            this.JuridicalJob.Size = new System.Drawing.Size(100, 19);
            this.JuridicalJob.TabIndex = 9;
            // 
            // JuridicalTel
            // 
            this.JuridicalTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalTel.BackColor = System.Drawing.Color.White;
            this.JuridicalTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalTel.ControlText = "";
            this.JuridicalTel.Location = new System.Drawing.Point(739, 194);
            this.JuridicalTel.Name = "JuridicalTel";
            this.JuridicalTel.Size = new System.Drawing.Size(128, 19);
            this.JuridicalTel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "联系电话:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "检查场所（或范围）:";
            // 
            // CheckAddress
            // 
            this.CheckAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckAddress.BackColor = System.Drawing.Color.White;
            this.CheckAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckAddress.ControlText = "";
            this.CheckAddress.Location = new System.Drawing.Point(345, 223);
            this.CheckAddress.Name = "CheckAddress";
            this.CheckAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.CheckAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CheckAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CheckAddress.PopupWidth = 300;
            this.CheckAddress.Size = new System.Drawing.Size(522, 19);
            this.CheckAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "检查时间：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "至";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "我们是";
            // 
            // Area
            // 
            this.Area.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Area.BackColor = System.Drawing.Color.White;
            this.Area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Area.ControlText = "";
            this.Area.Location = new System.Drawing.Point(240, 297);
            this.Area.Name = "Area";
            this.Area.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Area.PopupOffset = new System.Drawing.Point(12, 0);
            this.Area.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Area.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Area.PopupWidth = 300;
            this.Area.Size = new System.Drawing.Size(100, 19);
            this.Area.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "安全生产监督管理局执法人员";
            // 
            // OfficerName1
            // 
            this.OfficerName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName1.BackColor = System.Drawing.Color.White;
            this.OfficerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.ControlText = "";
            this.OfficerName1.Location = new System.Drawing.Point(563, 296);
            this.OfficerName1.Name = "OfficerName1";
            this.OfficerName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName1.PopupWidth = 300;
            this.OfficerName1.Size = new System.Drawing.Size(109, 19);
            this.OfficerName1.TabIndex = 21;
            this.OfficerName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName1_SelectedValueChangedEvent);
            this.OfficerName1.TextChanged += new System.EventHandler(this.OfficerName1_TextChanged);
            // 
            // OfficerName2
            // 
            this.OfficerName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName2.BackColor = System.Drawing.Color.White;
            this.OfficerName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.ControlText = "";
            this.OfficerName2.Location = new System.Drawing.Point(709, 296);
            this.OfficerName2.Name = "OfficerName2";
            this.OfficerName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName2.PopupWidth = 300;
            this.OfficerName2.Size = new System.Drawing.Size(126, 19);
            this.OfficerName2.TabIndex = 23;
            this.OfficerName2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.OfficerName2_SelectedValueChangedEvent);
            this.OfficerName2.TextChanged += new System.EventHandler(this.OfficerName2_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(678, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "、";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(841, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "，";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "证件号码为";
            // 
            // CID1
            // 
            this.CID1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID1.BackColor = System.Drawing.Color.White;
            this.CID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.ControlText = "";
            this.CID1.Location = new System.Drawing.Point(244, 329);
            this.CID1.Name = "CID1";
            this.CID1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID1.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID1.PopupWidth = 300;
            this.CID1.Size = new System.Drawing.Size(173, 19);
            this.CID1.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "、";
            // 
            // CID2
            // 
            this.CID2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID2.BackColor = System.Drawing.Color.White;
            this.CID2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.ControlText = "";
            this.CID2.Location = new System.Drawing.Point(446, 329);
            this.CID2.Name = "CID2";
            this.CID2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID2.PopupOffset = new System.Drawing.Point(12, 0);
            this.CID2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CID2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CID2.PopupWidth = 300;
            this.CID2.Size = new System.Drawing.Size(173, 19);
            this.CID2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(634, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "，";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(666, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "这是我们的证件（出示证件）。";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(328, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "现依法对你单位进行现场检查，请予以配合。";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CheckCondition);
            this.groupBox1.Location = new System.Drawing.Point(186, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 219);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查情况:";
            // 
            // CheckCondition
            // 
            this.CheckCondition.ControlText = "";
            this.CheckCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckCondition.Location = new System.Drawing.Point(3, 19);
            this.CheckCondition.Name = "CheckCondition";
            this.CheckCondition.Size = new System.Drawing.Size(658, 197);
            this.CheckCondition.TabIndex = 0;
            this.CheckCondition.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.SpotCondition);
            this.groupBox2.Location = new System.Drawing.Point(183, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 194);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "现场处置情况";
            // 
            // SpotCondition
            // 
            this.SpotCondition.ControlText = "";
            this.SpotCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotCondition.Location = new System.Drawing.Point(3, 19);
            this.SpotCondition.Name = "SpotCondition";
            this.SpotCondition.Size = new System.Drawing.Size(658, 172);
            this.SpotCondition.TabIndex = 0;
            this.SpotCondition.Text = "";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(179, 835);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "检查人员：";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(411, 835);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 16);
            this.label19.TabIndex = 35;
            this.label19.Text = "、";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(179, 867);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "被检查单位现场负责人：";
            // 
            // SiteJuridical
            // 
            this.SiteJuridical.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SiteJuridical.BackColor = System.Drawing.Color.White;
            this.SiteJuridical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SiteJuridical.ControlText = "";
            this.SiteJuridical.Location = new System.Drawing.Point(366, 866);
            this.SiteJuridical.Name = "SiteJuridical";
            this.SiteJuridical.Size = new System.Drawing.Size(186, 19);
            this.SiteJuridical.TabIndex = 39;
            // 
            // CheckPerson1
            // 
            this.CheckPerson1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckPerson1.BackColor = System.Drawing.Color.White;
            this.CheckPerson1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckPerson1.ControlText = "";
            this.CheckPerson1.Location = new System.Drawing.Point(263, 835);
            this.CheckPerson1.Name = "CheckPerson1";
            this.CheckPerson1.Size = new System.Drawing.Size(135, 19);
            this.CheckPerson1.TabIndex = 34;
            // 
            // CheckPerson2
            // 
            this.CheckPerson2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckPerson2.BackColor = System.Drawing.Color.White;
            this.CheckPerson2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckPerson2.ControlText = "";
            this.CheckPerson2.Location = new System.Drawing.Point(441, 835);
            this.CheckPerson2.Name = "CheckPerson2";
            this.CheckPerson2.Size = new System.Drawing.Size(135, 19);
            this.CheckPerson2.TabIndex = 36;
            // 
            // CheckStartTime
            // 
            this.CheckStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckStartTime.CustomFormat = "yyyy年M月d日 H时  m分";
            this.CheckStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckStartTime.Location = new System.Drawing.Point(266, 253);
            this.CheckStartTime.Name = "CheckStartTime";
            this.CheckStartTime.Size = new System.Drawing.Size(244, 26);
            this.CheckStartTime.TabIndex = 15;
            this.CheckStartTime.Value = new System.DateTime(2013, 3, 16, 14, 0, 15, 796);
            // 
            // CheckDate
            // 
            this.CheckDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckDate.CustomFormat = "yyyy年M月d日";
            this.CheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckDate.Location = new System.Drawing.Point(684, 888);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.Size = new System.Drawing.Size(163, 26);
            this.CheckDate.TabIndex = 40;
            this.CheckDate.Value = new System.DateTime(2013, 3, 16, 14, 0, 15, 796);
            // 
            // CheckEndTime
            // 
            this.CheckEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckEndTime.CustomFormat = "d日 H时  m分";
            this.CheckEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckEndTime.Location = new System.Drawing.Point(545, 252);
            this.CheckEndTime.Name = "CheckEndTime";
            this.CheckEndTime.Size = new System.Drawing.Size(171, 26);
            this.CheckEndTime.TabIndex = 17;
            this.CheckEndTime.Value = new System.DateTime(2013, 3, 16, 14, 0, 15, 796);
            // 
            // frmSpotCheck
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSpotCheck";
            this.Size = new System.Drawing.Size(1135, 967);
            this.Load += new System.EventHandler(this.frmSpotCheck_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableLine tableLine1;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableTextBox JuridicalTel;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableTextBox JuridicalJob;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableTextBox JuridicalName;
        private EnforceUI.TableAutoCompleteTextBox CompanyAddress;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.TableAutoCompleteTextBox CheckAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox Area;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableAutoCompleteTextBox OfficerName2;
        private EnforceUI.TableAutoCompleteTextBox OfficerName1;
        private EnforceUI.TableAutoCompleteTextBox CID2;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableAutoCompleteTextBox CID1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableTextBox SiteJuridical;
        private System.Windows.Forms.Label label20;
        private EnforceUI.TableRichTextBox SpotCondition;
        private EnforceUI.TableRichTextBox CheckCondition;
        private EnforceUI.TableTextBox CheckPerson2;
        private EnforceUI.TableTextBox CheckPerson1;
        private EnforceUI.TableDateTimePicker CheckStartTime;
        private EnforceUI.TableDateTimePicker CheckDate;
        private EnforceUI.TableDateTimePicker CheckEndTime;
    }
}

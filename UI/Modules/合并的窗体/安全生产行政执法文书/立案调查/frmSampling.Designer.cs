namespace EnforceForm
{
    partial class frmSampling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSampling));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.WitnesEPeopleName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.WitnesEPeopleName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.ExecUserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label35 = new System.Windows.Forms.Label();
            this.SamplingAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FieldEPeopleZio = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ToTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.FieldEPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldECompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeganTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SamplingContentGridViewItems = new EnforceUI.EnforceLawGridView(this.components);
            this.SDocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecUserNumber1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.ExecUserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ExecUserNumber2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingContentGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.ExecUserNumber2);
            this.panelContent.Controls.Add(this.ExecUserNumber1);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label23);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.WitnesEPeopleName2);
            this.panelContent.Controls.Add(this.label26);
            this.panelContent.Controls.Add(this.WitnesEPeopleName1);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.ExecUserName2);
            this.panelContent.Controls.Add(this.ExecUserName1);
            this.panelContent.Controls.Add(this.label35);
            this.panelContent.Controls.Add(this.SamplingAddress);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.FieldEPeopleZio);
            this.panelContent.Controls.Add(this.FieldEPeoplePhone);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.ToTime);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.FieldEPeopleName);
            this.panelContent.Controls.Add(this.FieldEAddress);
            this.panelContent.Controls.Add(this.FieldEPeopleName1);
            this.panelContent.Controls.Add(this.FieldECompanyName);
            this.panelContent.Controls.Add(this.BeganTime);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(819, 939);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1014);
            this.panel1.Size = new System.Drawing.Size(819, 41);
            this.panel1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(819, 75);
            this.header1.Title = "抽样取证凭证 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.TabIndex = 0;
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管抽〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(182, 135);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管抽〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WitnesEPeopleName2
            // 
            this.WitnesEPeopleName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WitnesEPeopleName2.BackColor = System.Drawing.Color.White;
            this.WitnesEPeopleName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WitnesEPeopleName2.ControlText = "";
            this.WitnesEPeopleName2.Location = new System.Drawing.Point(238, 914);
            this.WitnesEPeopleName2.Name = "WitnesEPeopleName2";
            this.WitnesEPeopleName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WitnesEPeopleName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.WitnesEPeopleName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.WitnesEPeopleName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WitnesEPeopleName2.PopupWidth = 300;
            this.WitnesEPeopleName2.Size = new System.Drawing.Size(119, 19);
            this.WitnesEPeopleName2.TabIndex = 35;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(218, 914);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 34;
            this.label26.Text = "、";
            // 
            // WitnesEPeopleName1
            // 
            this.WitnesEPeopleName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WitnesEPeopleName1.BackColor = System.Drawing.Color.White;
            this.WitnesEPeopleName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WitnesEPeopleName1.ControlText = "";
            this.WitnesEPeopleName1.Location = new System.Drawing.Point(102, 914);
            this.WitnesEPeopleName1.Name = "WitnesEPeopleName1";
            this.WitnesEPeopleName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WitnesEPeopleName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.WitnesEPeopleName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.WitnesEPeopleName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WitnesEPeopleName1.PopupWidth = 300;
            this.WitnesEPeopleName1.Size = new System.Drawing.Size(114, 19);
            this.WitnesEPeopleName1.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 913);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "见证人：";
            // 
            // ExecUserName1
            // 
            this.ExecUserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecUserName1.BackColor = System.Drawing.Color.White;
            this.ExecUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserName1.ControlText = "";
            this.ExecUserName1.Location = new System.Drawing.Point(238, 824);
            this.ExecUserName1.Name = "ExecUserName1";
            this.ExecUserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.ExecUserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ExecUserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExecUserName1.PopupWidth = 300;
            this.ExecUserName1.Size = new System.Drawing.Size(119, 19);
            this.ExecUserName1.TabIndex = 25;
            this.ExecUserName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.ExecUserName1_SelectedValueChangedEvent);
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(36, 823);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(184, 16);
            this.label35.TabIndex = 24;
            this.label35.Text = "安全生产监管执法人员：";
            // 
            // SamplingAddress
            // 
            this.SamplingAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SamplingAddress.BackColor = System.Drawing.Color.White;
            this.SamplingAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingAddress.ControlText = "";
            this.SamplingAddress.Location = new System.Drawing.Point(122, 346);
            this.SamplingAddress.Name = "SamplingAddress";
            this.SamplingAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.SamplingAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SamplingAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SamplingAddress.PopupWidth = 300;
            this.SamplingAddress.Size = new System.Drawing.Size(549, 19);
            this.SamplingAddress.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(632, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "依据《中华人民共和国行政处罚法》第三十七条第二款规定，对被抽样取证单位的下列物";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "抽样地点：";
            // 
            // FieldEPeopleZio
            // 
            this.FieldEPeopleZio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleZio.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleZio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleZio.ControlText = "";
            this.FieldEPeopleZio.Location = new System.Drawing.Point(84, 263);
            this.FieldEPeopleZio.Name = "FieldEPeopleZio";
            this.FieldEPeopleZio.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleZio.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleZio.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleZio.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleZio.PopupWidth = 300;
            this.FieldEPeopleZio.Size = new System.Drawing.Size(217, 19);
            this.FieldEPeopleZio.TabIndex = 12;
            // 
            // FieldEPeoplePhone
            // 
            this.FieldEPeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeoplePhone.BackColor = System.Drawing.Color.White;
            this.FieldEPeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePhone.ControlText = "";
            this.FieldEPeoplePhone.Location = new System.Drawing.Point(476, 222);
            this.FieldEPeoplePhone.Name = "FieldEPeoplePhone";
            this.FieldEPeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeoplePhone.PopupWidth = 300;
            this.FieldEPeoplePhone.Size = new System.Drawing.Size(195, 19);
            this.FieldEPeoplePhone.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "联系电话：";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "邮编：";
            // 
            // ToTime
            // 
            this.ToTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToTime.CustomFormat = "d日 H时  m分";
            this.ToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTime.Location = new System.Drawing.Point(395, 300);
            this.ToTime.Name = "ToTime";
            this.ToTime.Size = new System.Drawing.Size(156, 26);
            this.ToTime.TabIndex = 16;
            this.ToTime.Value = new System.DateTime(2013, 3, 10, 20, 5, 5, 38);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "至";
            // 
            // FieldEPeopleName
            // 
            this.FieldEPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleName.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName.ControlText = "";
            this.FieldEPeopleName.Location = new System.Drawing.Point(575, 179);
            this.FieldEPeopleName.Name = "FieldEPeopleName";
            this.FieldEPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleName.PopupWidth = 300;
            this.FieldEPeopleName.Size = new System.Drawing.Size(96, 19);
            this.FieldEPeopleName.TabIndex = 6;
            this.FieldEPeopleName.TextChanged += new System.EventHandler(this.FieldEPeopleName_TextChanged);
            // 
            // FieldEAddress
            // 
            this.FieldEAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEAddress.BackColor = System.Drawing.Color.White;
            this.FieldEAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEAddress.ControlText = "";
            this.FieldEAddress.Location = new System.Drawing.Point(122, 222);
            this.FieldEAddress.Name = "FieldEAddress";
            this.FieldEAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEAddress.PopupWidth = 300;
            this.FieldEAddress.Size = new System.Drawing.Size(261, 19);
            this.FieldEAddress.TabIndex = 8;
            // 
            // FieldEPeopleName1
            // 
            this.FieldEPeopleName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleName1.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName1.ControlText = "";
            this.FieldEPeopleName1.Location = new System.Drawing.Point(238, 782);
            this.FieldEPeopleName1.Name = "FieldEPeopleName1";
            this.FieldEPeopleName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleName1.PopupWidth = 300;
            this.FieldEPeopleName1.Size = new System.Drawing.Size(155, 19);
            this.FieldEPeopleName1.TabIndex = 23;
            // 
            // FieldECompanyName
            // 
            this.FieldECompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldECompanyName.BackColor = System.Drawing.Color.White;
            this.FieldECompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.ControlText = "";
            this.FieldECompanyName.Location = new System.Drawing.Point(165, 179);
            this.FieldECompanyName.Name = "FieldECompanyName";
            this.FieldECompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldECompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldECompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldECompanyName.PopupWidth = 300;
            this.FieldECompanyName.Size = new System.Drawing.Size(301, 19);
            this.FieldECompanyName.TabIndex = 4;
            this.FieldECompanyName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.FieldECompanyName_SelectedValueChangedEvent);
            // 
            // BeganTime
            // 
            this.BeganTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeganTime.CustomFormat = "yyyy年M月d日 H时  m分";
            this.BeganTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeganTime.Location = new System.Drawing.Point(122, 301);
            this.BeganTime.Name = "BeganTime";
            this.BeganTime.Size = new System.Drawing.Size(244, 26);
            this.BeganTime.TabIndex = 14;
            this.BeganTime.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(33, 781);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(216, 16);
            this.label24.TabIndex = 22;
            this.label24.Text = "被抽样取证单位现场负责人：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "现场负责人：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "单位地址：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "被抽样取证单位：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "勘验时间：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(296, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "抽样取证凭证";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-14, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 229;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(257, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "品进行抽样取证。";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.SamplingContentGridViewItems);
            this.groupBox1.Location = new System.Drawing.Point(37, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 295);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "取证物品列表：";
            // 
            // SamplingContentGridViewItems
            // 
            this.SamplingContentGridViewItems.AutoUpdate = false;
            this.SamplingContentGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.SamplingContentGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingContentGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SamplingContentGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SDocTitle,
            this.ItemName,
            this.ItemRule,
            this.Count,
            this.ItemUnit});
            this.SamplingContentGridViewItems.Custom = false;
            this.SamplingContentGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SamplingContentGridViewItems.EntityType = null;
            this.SamplingContentGridViewItems.Location = new System.Drawing.Point(3, 22);
            this.SamplingContentGridViewItems.Name = "SamplingContentGridViewItems";
            this.SamplingContentGridViewItems.RowTemplate.Height = 23;
            this.SamplingContentGridViewItems.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SamplingContentGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SamplingContentGridViewItems.Size = new System.Drawing.Size(622, 270);
            this.SamplingContentGridViewItems.TabIndex = 0;
            // 
            // SDocTitle
            // 
            this.SDocTitle.HeaderText = "抽样编号";
            this.SDocTitle.Name = "SDocTitle";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "证据物品名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 160;
            // 
            // ItemRule
            // 
            this.ItemRule.HeaderText = "规格及批号";
            this.ItemRule.Name = "ItemRule";
            this.ItemRule.Width = 140;
            // 
            // Count
            // 
            this.Count.HeaderText = "数量";
            this.Count.Name = "Count";
            this.Count.Width = 80;
            // 
            // ItemUnit
            // 
            this.ItemUnit.HeaderText = "单位";
            this.ItemUnit.Name = "ItemUnit";
            // 
            // ExecUserNumber1
            // 
            this.ExecUserNumber1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecUserNumber1.BackColor = System.Drawing.Color.White;
            this.ExecUserNumber1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserNumber1.ControlText = "";
            this.ExecUserNumber1.Location = new System.Drawing.Point(431, 824);
            this.ExecUserNumber1.Name = "ExecUserNumber1";
            this.ExecUserNumber1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserNumber1.PopupOffset = new System.Drawing.Point(12, 0);
            this.ExecUserNumber1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ExecUserNumber1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExecUserNumber1.PopupWidth = 300;
            this.ExecUserNumber1.Size = new System.Drawing.Size(119, 19);
            this.ExecUserNumber1.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(369, 824);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "证号：";
            // 
            // ExecUserName2
            // 
            this.ExecUserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecUserName2.BackColor = System.Drawing.Color.White;
            this.ExecUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserName2.ControlText = "";
            this.ExecUserName2.Location = new System.Drawing.Point(238, 873);
            this.ExecUserName2.Name = "ExecUserName2";
            this.ExecUserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.ExecUserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ExecUserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExecUserName2.PopupWidth = 300;
            this.ExecUserName2.Size = new System.Drawing.Size(119, 19);
            this.ExecUserName2.TabIndex = 28;
            this.ExecUserName2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.ExecUserName2_SelectedValueChangedEvent);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 873);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "证号：";
            // 
            // ExecUserNumber2
            // 
            this.ExecUserNumber2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecUserNumber2.BackColor = System.Drawing.Color.White;
            this.ExecUserNumber2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserNumber2.ControlText = "";
            this.ExecUserNumber2.Location = new System.Drawing.Point(431, 873);
            this.ExecUserNumber2.Name = "ExecUserNumber2";
            this.ExecUserNumber2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecUserNumber2.PopupOffset = new System.Drawing.Point(12, 0);
            this.ExecUserNumber2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ExecUserNumber2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExecUserNumber2.PopupWidth = 300;
            this.ExecUserNumber2.Size = new System.Drawing.Size(119, 19);
            this.ExecUserNumber2.TabIndex = 30;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(406, 942);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 36;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(471, 977);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(158, 26);
            this.FillDate.TabIndex = 37;
            this.FillDate.Value = new System.DateTime(2013, 3, 10, 20, 58, 7, 346);
            // 
            // frmSampling
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSampling";
            this.Size = new System.Drawing.Size(819, 1055);
            this.Load += new System.EventHandler(this.frmSampling_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SamplingContentGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableAutoCompleteTextBox WitnesEPeopleName2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox ExecUserName1;
        private System.Windows.Forms.Label label35;
        private EnforceUI.TableAutoCompleteTextBox SamplingAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleZio;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeoplePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableDateTimePicker ToTime;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleName;
        private EnforceUI.TableAutoCompleteTextBox FieldEAddress;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleName1;
        private EnforceUI.TableAutoCompleteTextBox FieldECompanyName;
        private EnforceUI.TableDateTimePicker BeganTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableAutoCompleteTextBox ExecUserNumber2;
        private EnforceUI.TableAutoCompleteTextBox ExecUserNumber1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label23;
        private EnforceUI.TableAutoCompleteTextBox ExecUserName2;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker FillDate;
        private EnforceUI.TableAutoCompleteTextBox WitnesEPeopleName1;
        private EnforceUI.EnforceLawGridView SamplingContentGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
    }
}

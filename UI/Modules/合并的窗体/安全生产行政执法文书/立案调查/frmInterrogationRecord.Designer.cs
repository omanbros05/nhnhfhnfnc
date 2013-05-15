namespace EnforceForm
{
    partial class frmInterrogationRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterrogationRecord));
            this.BeAskEPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.AskUserCompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.AskUserName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeAskEPeoplePosition = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeAskEPeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeAskEPeopleCompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.AskAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeganTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.RecordDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.ToTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.InterrogationRecordCount = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BeAskEPeopleSex = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.BeAskEPeopleAge = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.BeAskEPeopleID = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BeAskEPeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RecordCompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.RecordUserName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PresentEPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.QuestionSecond = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QFirstAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.QFirstPerson2IDC2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.QFirstPersonIDC1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.QFirstPerson2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.QFirstPersonName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label34 = new System.Windows.Forms.Label();
            this.QFirstPerson1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.questionContainer = new EnforceUI.QuestionContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QuestionThirdAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuestionSecondAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panelContent.Controls.Add(this.groupBox4);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.label36);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.label30);
            this.panelContent.Controls.Add(this.label29);
            this.panelContent.Controls.Add(this.QuestionSecond);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.QFirstPerson2IDC2);
            this.panelContent.Controls.Add(this.label26);
            this.panelContent.Controls.Add(this.QFirstPersonIDC1);
            this.panelContent.Controls.Add(this.label31);
            this.panelContent.Controls.Add(this.label32);
            this.panelContent.Controls.Add(this.label33);
            this.panelContent.Controls.Add(this.QFirstPerson2);
            this.panelContent.Controls.Add(this.QFirstPersonName1);
            this.panelContent.Controls.Add(this.label34);
            this.panelContent.Controls.Add(this.QFirstPerson1);
            this.panelContent.Controls.Add(this.label35);
            this.panelContent.Controls.Add(this.PresentEPeopleName);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.RecordCompanyName);
            this.panelContent.Controls.Add(this.RecordUserName);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.BeAskEPeoplePhone);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.BeAskEPeopleAge);
            this.panelContent.Controls.Add(this.BeAskEPeopleSex);
            this.panelContent.Controls.Add(this.InterrogationRecordCount);
            this.panelContent.Controls.Add(this.ToTime);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.RecordDate);
            this.panelContent.Controls.Add(this.BeAskEPeopleName);
            this.panelContent.Controls.Add(this.AskUserCompanyName);
            this.panelContent.Controls.Add(this.AskUserName);
            this.panelContent.Controls.Add(this.BeAskEPeopleID);
            this.panelContent.Controls.Add(this.BeAskEPeoplePosition);
            this.panelContent.Controls.Add(this.BeAskEPeopleAddress);
            this.panelContent.Controls.Add(this.BeAskEPeopleCompanyName);
            this.panelContent.Controls.Add(this.AskAddress);
            this.panelContent.Controls.Add(this.BeganTime);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(855, 1277);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1352);
            this.panel1.Size = new System.Drawing.Size(855, 43);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(855, 75);
            this.header1.Title = "询问笔录 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // BeAskEPeopleName
            // 
            this.BeAskEPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleName.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleName.ControlText = "";
            this.BeAskEPeopleName.Location = new System.Drawing.Point(206, 237);
            this.BeAskEPeopleName.Name = "BeAskEPeopleName";
            this.BeAskEPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleName.PopupWidth = 300;
            this.BeAskEPeopleName.Size = new System.Drawing.Size(95, 19);
            this.BeAskEPeopleName.TabIndex = 12;
            this.BeAskEPeopleName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.BeAskEPeopleName_SelectedValueChangedEvent);
            // 
            // AskUserCompanyName
            // 
            this.AskUserCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AskUserCompanyName.BackColor = System.Drawing.Color.White;
            this.AskUserCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskUserCompanyName.ControlText = "";
            this.AskUserCompanyName.Location = new System.Drawing.Point(400, 363);
            this.AskUserCompanyName.Name = "AskUserCompanyName";
            this.AskUserCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskUserCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.AskUserCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.AskUserCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AskUserCompanyName.PopupWidth = 300;
            this.AskUserCompanyName.Size = new System.Drawing.Size(329, 19);
            this.AskUserCompanyName.TabIndex = 30;
            // 
            // AskUserName
            // 
            this.AskUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AskUserName.BackColor = System.Drawing.Color.White;
            this.AskUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskUserName.ControlText = "";
            this.AskUserName.Location = new System.Drawing.Point(166, 363);
            this.AskUserName.Name = "AskUserName";
            this.AskUserName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskUserName.PopupOffset = new System.Drawing.Point(12, 0);
            this.AskUserName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.AskUserName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AskUserName.PopupWidth = 300;
            this.AskUserName.Size = new System.Drawing.Size(177, 19);
            this.AskUserName.TabIndex = 28;
            this.AskUserName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.AskUserName_SelectedValueChangedEvent);
            // 
            // BeAskEPeoplePosition
            // 
            this.BeAskEPeoplePosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeoplePosition.BackColor = System.Drawing.Color.White;
            this.BeAskEPeoplePosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeoplePosition.ControlText = "";
            this.BeAskEPeoplePosition.Location = new System.Drawing.Point(588, 279);
            this.BeAskEPeoplePosition.Name = "BeAskEPeoplePosition";
            this.BeAskEPeoplePosition.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeoplePosition.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeoplePosition.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeoplePosition.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeoplePosition.PopupWidth = 300;
            this.BeAskEPeoplePosition.Size = new System.Drawing.Size(141, 19);
            this.BeAskEPeoplePosition.TabIndex = 22;
            // 
            // BeAskEPeopleAddress
            // 
            this.BeAskEPeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleAddress.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleAddress.ControlText = "";
            this.BeAskEPeopleAddress.Location = new System.Drawing.Point(145, 321);
            this.BeAskEPeopleAddress.Name = "BeAskEPeopleAddress";
            this.BeAskEPeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleAddress.PopupWidth = 300;
            this.BeAskEPeopleAddress.Size = new System.Drawing.Size(379, 19);
            this.BeAskEPeopleAddress.TabIndex = 24;
            // 
            // BeAskEPeopleCompanyName
            // 
            this.BeAskEPeopleCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleCompanyName.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleCompanyName.ControlText = "";
            this.BeAskEPeopleCompanyName.Location = new System.Drawing.Point(180, 279);
            this.BeAskEPeopleCompanyName.Name = "BeAskEPeopleCompanyName";
            this.BeAskEPeopleCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleCompanyName.PopupWidth = 300;
            this.BeAskEPeopleCompanyName.Size = new System.Drawing.Size(344, 19);
            this.BeAskEPeopleCompanyName.TabIndex = 20;
            // 
            // AskAddress
            // 
            this.AskAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AskAddress.BackColor = System.Drawing.Color.White;
            this.AskAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskAddress.ControlText = "";
            this.AskAddress.Location = new System.Drawing.Point(184, 195);
            this.AskAddress.Name = "AskAddress";
            this.AskAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.AskAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.AskAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AskAddress.PopupWidth = 300;
            this.AskAddress.Size = new System.Drawing.Size(545, 19);
            this.AskAddress.TabIndex = 10;
            // 
            // BeganTime
            // 
            this.BeganTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeganTime.CustomFormat = "yyyy年M月d日 H时  m分";
            this.BeganTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeganTime.Location = new System.Drawing.Point(180, 148);
            this.BeganTime.Name = "BeganTime";
            this.BeganTime.Size = new System.Drawing.Size(244, 26);
            this.BeganTime.TabIndex = 3;
            this.BeganTime.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "职务：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "询问人：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "住址：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "工作单位：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "被询问人姓名：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "询问地点：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "询问时间：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(375, 110);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(89, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "询问笔录";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(44, 103);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 114;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(315, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // RecordDate
            // 
            this.RecordDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordDate.CustomFormat = "yyyy年M月d日";
            this.RecordDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RecordDate.Location = new System.Drawing.Point(558, 1245);
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.Size = new System.Drawing.Size(168, 26);
            this.RecordDate.TabIndex = 59;
            this.RecordDate.Value = new System.DateTime(2013, 3, 9, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "至";
            // 
            // ToTime
            // 
            this.ToTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToTime.CustomFormat = "d日 H时  m分";
            this.ToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTime.Location = new System.Drawing.Point(453, 147);
            this.ToTime.Name = "ToTime";
            this.ToTime.Size = new System.Drawing.Size(156, 26);
            this.ToTime.TabIndex = 5;
            this.ToTime.Value = new System.DateTime(2013, 3, 10, 20, 5, 5, 38);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(624, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "第";
            // 
            // InterrogationRecordCount
            // 
            this.InterrogationRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InterrogationRecordCount.BackColor = System.Drawing.Color.White;
            this.InterrogationRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterrogationRecordCount.ControlText = "1";
            this.InterrogationRecordCount.Location = new System.Drawing.Point(646, 155);
            this.InterrogationRecordCount.Name = "InterrogationRecordCount";
            this.InterrogationRecordCount.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterrogationRecordCount.PopupOffset = new System.Drawing.Point(12, 0);
            this.InterrogationRecordCount.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.InterrogationRecordCount.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.InterrogationRecordCount.PopupWidth = 300;
            this.InterrogationRecordCount.Size = new System.Drawing.Size(26, 19);
            this.InterrogationRecordCount.TabIndex = 7;
            this.InterrogationRecordCount.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(678, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "次询问";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "性别：";
            // 
            // BeAskEPeopleSex
            // 
            this.BeAskEPeopleSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleSex.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleSex.ControlText = "";
            this.BeAskEPeopleSex.Location = new System.Drawing.Point(352, 238);
            this.BeAskEPeopleSex.Name = "BeAskEPeopleSex";
            this.BeAskEPeopleSex.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleSex.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleSex.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleSex.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleSex.PopupWidth = 300;
            this.BeAskEPeopleSex.Size = new System.Drawing.Size(47, 19);
            this.BeAskEPeopleSex.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "年龄：";
            // 
            // BeAskEPeopleAge
            // 
            this.BeAskEPeopleAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleAge.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleAge.ControlText = "";
            this.BeAskEPeopleAge.Location = new System.Drawing.Point(456, 238);
            this.BeAskEPeopleAge.Name = "BeAskEPeopleAge";
            this.BeAskEPeopleAge.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleAge.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleAge.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleAge.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleAge.PopupWidth = 300;
            this.BeAskEPeopleAge.Size = new System.Drawing.Size(47, 19);
            this.BeAskEPeopleAge.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "身份证号：";
            // 
            // BeAskEPeopleID
            // 
            this.BeAskEPeopleID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeopleID.BackColor = System.Drawing.Color.White;
            this.BeAskEPeopleID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleID.ControlText = "";
            this.BeAskEPeopleID.Location = new System.Drawing.Point(588, 238);
            this.BeAskEPeopleID.Name = "BeAskEPeopleID";
            this.BeAskEPeopleID.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeopleID.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeopleID.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeopleID.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeopleID.PopupWidth = 300;
            this.BeAskEPeopleID.Size = new System.Drawing.Size(141, 19);
            this.BeAskEPeopleID.TabIndex = 18;
            // 
            // BeAskEPeoplePhone
            // 
            this.BeAskEPeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeAskEPeoplePhone.BackColor = System.Drawing.Color.White;
            this.BeAskEPeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeoplePhone.ControlText = "";
            this.BeAskEPeoplePhone.Location = new System.Drawing.Point(588, 322);
            this.BeAskEPeoplePhone.Name = "BeAskEPeoplePhone";
            this.BeAskEPeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeAskEPeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.BeAskEPeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BeAskEPeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeAskEPeoplePhone.PopupWidth = 300;
            this.BeAskEPeoplePhone.Size = new System.Drawing.Size(141, 19);
            this.BeAskEPeoplePhone.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(540, 320);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "电话：";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "单位：";
            // 
            // RecordCompanyName
            // 
            this.RecordCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordCompanyName.BackColor = System.Drawing.Color.White;
            this.RecordCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordCompanyName.ControlText = "";
            this.RecordCompanyName.Location = new System.Drawing.Point(400, 406);
            this.RecordCompanyName.Name = "RecordCompanyName";
            this.RecordCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.RecordCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.RecordCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RecordCompanyName.PopupWidth = 300;
            this.RecordCompanyName.Size = new System.Drawing.Size(329, 19);
            this.RecordCompanyName.TabIndex = 34;
            // 
            // RecordUserName
            // 
            this.RecordUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordUserName.BackColor = System.Drawing.Color.White;
            this.RecordUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordUserName.ControlText = "";
            this.RecordUserName.Location = new System.Drawing.Point(166, 406);
            this.RecordUserName.Name = "RecordUserName";
            this.RecordUserName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordUserName.PopupOffset = new System.Drawing.Point(12, 0);
            this.RecordUserName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.RecordUserName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RecordUserName.PopupWidth = 300;
            this.RecordUserName.Size = new System.Drawing.Size(131, 19);
            this.RecordUserName.TabIndex = 32;
            this.RecordUserName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.RecordUserName_SelectedValueChangedEvent);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(303, 407);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "单位及职务：";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(93, 407);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "记录人：";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(93, 448);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "在场人：";
            // 
            // PresentEPeopleName
            // 
            this.PresentEPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PresentEPeopleName.BackColor = System.Drawing.Color.White;
            this.PresentEPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PresentEPeopleName.ControlText = "";
            this.PresentEPeopleName.Location = new System.Drawing.Point(166, 447);
            this.PresentEPeopleName.Name = "PresentEPeopleName";
            this.PresentEPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PresentEPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PresentEPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PresentEPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PresentEPeopleName.PopupWidth = 300;
            this.PresentEPeopleName.Size = new System.Drawing.Size(563, 19);
            this.PresentEPeopleName.TabIndex = 36;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(125, 758);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(584, 16);
            this.label30.TabIndex = 54;
            this.label30.Text = "如实回答问题的义务，提供虚假情况、作伪证是要负法律责任的。你听清楚了吗？";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(494, 719);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(232, 16);
            this.label29.TabIndex = 53;
            this.label29.Text = "的有关问题向你了解情况，你有";
            // 
            // QuestionSecond
            // 
            this.QuestionSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionSecond.BackColor = System.Drawing.Color.White;
            this.QuestionSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionSecond.ControlText = "";
            this.QuestionSecond.Location = new System.Drawing.Point(219, 719);
            this.QuestionSecond.Name = "QuestionSecond";
            this.QuestionSecond.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionSecond.PopupOffset = new System.Drawing.Point(12, 0);
            this.QuestionSecond.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QuestionSecond.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuestionSecond.PopupWidth = 300;
            this.QuestionSecond.Size = new System.Drawing.Size(269, 19);
            this.QuestionSecond.TabIndex = 52;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(92, 719);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 16);
            this.label28.TabIndex = 51;
            this.label28.Text = "问：我们依法就";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.QFirstAnswer);
            this.groupBox1.Location = new System.Drawing.Point(96, 595);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 93);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答：";
            // 
            // QFirstAnswer
            // 
            this.QFirstAnswer.ControlText = "";
            this.QFirstAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QFirstAnswer.Location = new System.Drawing.Point(3, 22);
            this.QFirstAnswer.Name = "QFirstAnswer";
            this.QFirstAnswer.Size = new System.Drawing.Size(627, 68);
            this.QFirstAnswer.TabIndex = 0;
            this.QFirstAnswer.Text = "";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(124, 567);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 16);
            this.label27.TabIndex = 49;
            this.label27.Text = "你查验清楚了吗？";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(491, 535);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(248, 16);
            this.label19.TabIndex = 48;
            this.label19.Text = "，这是我们的证件（出示证件）。";
            // 
            // QFirstPerson2IDC2
            // 
            this.QFirstPerson2IDC2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson2IDC2.BackColor = System.Drawing.Color.White;
            this.QFirstPerson2IDC2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2IDC2.ControlText = "";
            this.QFirstPerson2IDC2.Location = new System.Drawing.Point(367, 535);
            this.QFirstPerson2IDC2.Name = "QFirstPerson2IDC2";
            this.QFirstPerson2IDC2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2IDC2.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson2IDC2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson2IDC2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson2IDC2.PopupWidth = 300;
            this.QFirstPerson2IDC2.Size = new System.Drawing.Size(109, 19);
            this.QFirstPerson2IDC2.TabIndex = 47;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(336, 535);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 46;
            this.label26.Text = "、";
            // 
            // QFirstPersonIDC1
            // 
            this.QFirstPersonIDC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPersonIDC1.BackColor = System.Drawing.Color.White;
            this.QFirstPersonIDC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonIDC1.ControlText = "";
            this.QFirstPersonIDC1.Location = new System.Drawing.Point(212, 535);
            this.QFirstPersonIDC1.Name = "QFirstPersonIDC1";
            this.QFirstPersonIDC1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonIDC1.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPersonIDC1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPersonIDC1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPersonIDC1.PopupWidth = 300;
            this.QFirstPersonIDC1.Size = new System.Drawing.Size(114, 19);
            this.QFirstPersonIDC1.TabIndex = 45;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(124, 534);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 16);
            this.label31.TabIndex = 44;
            this.label31.Text = "证件号码为";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(715, 494);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(24, 16);
            this.label32.TabIndex = 43;
            this.label32.Text = "，";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(604, 494);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 16);
            this.label33.TabIndex = 41;
            this.label33.Text = "、";
            // 
            // QFirstPerson2
            // 
            this.QFirstPerson2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson2.BackColor = System.Drawing.Color.White;
            this.QFirstPerson2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2.ControlText = "";
            this.QFirstPerson2.Location = new System.Drawing.Point(628, 494);
            this.QFirstPerson2.Name = "QFirstPerson2";
            this.QFirstPerson2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson2.PopupWidth = 300;
            this.QFirstPerson2.Size = new System.Drawing.Size(81, 19);
            this.QFirstPerson2.TabIndex = 42;
            this.QFirstPerson2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.QFirstPerson2_SelectedValueChangedEvent);
            // 
            // QFirstPersonName1
            // 
            this.QFirstPersonName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPersonName1.BackColor = System.Drawing.Color.White;
            this.QFirstPersonName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonName1.ControlText = "";
            this.QFirstPersonName1.Location = new System.Drawing.Point(517, 494);
            this.QFirstPersonName1.Name = "QFirstPersonName1";
            this.QFirstPersonName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPersonName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPersonName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPersonName1.PopupWidth = 300;
            this.QFirstPersonName1.Size = new System.Drawing.Size(81, 19);
            this.QFirstPersonName1.TabIndex = 40;
            this.QFirstPersonName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.QFirstPersonName1_SelectedValueChangedEvent);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(278, 493);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(232, 16);
            this.label34.TabIndex = 39;
            this.label34.Text = "安全生产监督管理局的执法人员";
            // 
            // QFirstPerson1
            // 
            this.QFirstPerson1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson1.BackColor = System.Drawing.Color.White;
            this.QFirstPerson1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson1.ControlText = "";
            this.QFirstPerson1.Location = new System.Drawing.Point(180, 493);
            this.QFirstPerson1.Name = "QFirstPerson1";
            this.QFirstPerson1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson1.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson1.PopupWidth = 300;
            this.QFirstPerson1.Size = new System.Drawing.Size(92, 19);
            this.QFirstPerson1.TabIndex = 38;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(93, 492);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(88, 16);
            this.label35.TabIndex = 37;
            this.label35.Text = "问：我们是";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.questionContainer);
            this.groupBox4.Location = new System.Drawing.Point(96, 1036);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 203);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "问答";
            // 
            // questionContainer
            // 
            this.questionContainer.BackColor = System.Drawing.Color.White;
            this.questionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionContainer.Entries = null;
            this.questionContainer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.questionContainer.Location = new System.Drawing.Point(3, 22);
            this.questionContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionContainer.Name = "questionContainer";
            this.questionContainer.Size = new System.Drawing.Size(623, 178);
            this.questionContainer.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.QuestionThirdAnswer);
            this.groupBox3.Location = new System.Drawing.Point(102, 926);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 86);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "答：";
            // 
            // QuestionThirdAnswer
            // 
            this.QuestionThirdAnswer.ControlText = "";
            this.QuestionThirdAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionThirdAnswer.Location = new System.Drawing.Point(3, 22);
            this.QuestionThirdAnswer.Name = "QuestionThirdAnswer";
            this.QuestionThirdAnswer.Size = new System.Drawing.Size(621, 61);
            this.QuestionThirdAnswer.TabIndex = 0;
            this.QuestionThirdAnswer.Text = "";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(93, 893);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(328, 16);
            this.label36.TabIndex = 56;
            this.label36.Text = "问：你有申请回避的权利，你是否申请回避？";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.QuestionSecondAnswer);
            this.groupBox2.Location = new System.Drawing.Point(99, 793);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 85);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "答：";
            // 
            // QuestionSecondAnswer
            // 
            this.QuestionSecondAnswer.ControlText = "";
            this.QuestionSecondAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionSecondAnswer.Location = new System.Drawing.Point(3, 22);
            this.QuestionSecondAnswer.Name = "QuestionSecondAnswer";
            this.QuestionSecondAnswer.Size = new System.Drawing.Size(624, 60);
            this.QuestionSecondAnswer.TabIndex = 0;
            this.QuestionSecondAnswer.Text = "";
            // 
            // frmInterrogationRecord
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmInterrogationRecord";
            this.Size = new System.Drawing.Size(855, 1395);
            this.Load += new System.EventHandler(this.frmInterrogationRecord_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleName;
        private EnforceUI.TableAutoCompleteTextBox AskUserCompanyName;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeoplePosition;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleAddress;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleCompanyName;
        private EnforceUI.TableAutoCompleteTextBox AskAddress;
        private EnforceUI.TableDateTimePicker BeganTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableDateTimePicker RecordDate;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleSex;
        private EnforceUI.TableAutoCompleteTextBox InterrogationRecordCount;
        private EnforceUI.TableDateTimePicker ToTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableAutoCompleteTextBox RecordCompanyName;
        private EnforceUI.TableAutoCompleteTextBox RecordUserName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeoplePhone;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleAge;
        private EnforceUI.TableAutoCompleteTextBox BeAskEPeopleID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private EnforceUI.TableAutoCompleteTextBox QuestionSecond;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox QFirstAnswer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label19;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson2IDC2;
        private System.Windows.Forms.Label label26;
        private EnforceUI.TableAutoCompleteTextBox QFirstPersonIDC1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson2;
        private EnforceUI.TableAutoCompleteTextBox QFirstPersonName1;
        private System.Windows.Forms.Label label34;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox QuestionThirdAnswer;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox QuestionSecondAnswer;
        private EnforceUI.TableAutoCompleteTextBox PresentEPeopleName;
        private EnforceUI.TableAutoCompleteTextBox AskUserName;
        private EnforceUI.QuestionContainer questionContainer;
    }
}

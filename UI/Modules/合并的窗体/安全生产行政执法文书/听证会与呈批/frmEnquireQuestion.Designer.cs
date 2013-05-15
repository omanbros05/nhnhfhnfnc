namespace EnforceForm
{
    partial class frmEnquireQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnquireQuestion));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnquireCount = new EnforceUI.TableTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.EnquireAddress = new EnforceUI.TableTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.EnquirePersonUnit = new EnforceUI.TableTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.EnquirePersonAge = new EnforceUI.TableTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.EnquirePersonSex = new EnforceUI.TableTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.EnquirePerson = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.EnquirePersonIDC = new EnforceUI.TableTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.EnquirePersonJob = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.EnquirePersonTel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.EnquirePersonAddress = new EnforceUI.TableTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.EnquirerUnit = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.EnquirerName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.WriterUnit = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.WriterName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.Attendee = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.QFirstPerson2IDC2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.QFirstPersonIDC1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.QFirstPerson2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.QFirstPerson1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.QFirstUnit = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QFirstAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.QuestionSecond = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuestionSecondAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QuestionThirdAnswer = new EnforceUI.TableRichTextBox(this.components);
            this.EnquireBeginDate = new EnforceUI.TableDateTimePicker(this.components);
            this.EnquireEndDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label32 = new System.Windows.Forms.Label();
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.questionContainer = new EnforceUI.QuestionContainer();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.EnquireBeginDate);
            this.panelContent.Controls.Add(this.EnquireEndDate);
            this.panelContent.Controls.Add(this.label32);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.label31);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.label30);
            this.panelContent.Controls.Add(this.label29);
            this.panelContent.Controls.Add(this.QuestionSecond);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.QFirstPerson2IDC2);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.QFirstPersonIDC1);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.label23);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.QFirstPerson2);
            this.panelContent.Controls.Add(this.QFirstPerson1);
            this.panelContent.Controls.Add(this.label25);
            this.panelContent.Controls.Add(this.QFirstUnit);
            this.panelContent.Controls.Add(this.label26);
            this.panelContent.Controls.Add(this.Attendee);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.WriterUnit);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.WriterName);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.EnquirerUnit);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.EnquirerName);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.EnquirePersonTel);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.EnquirePersonAddress);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.EnquirePersonJob);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.EnquirePersonIDC);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.EnquirePersonUnit);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.EnquirePersonAge);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.EnquirePersonSex);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.EnquirePerson);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.EnquireAddress);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.EnquireCount);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(810, 1283);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1358);
            this.panel1.Size = new System.Drawing.Size(810, 35);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(810, 75);
            this.header1.Title = "询问笔录 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(319, 108);
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
            this.tableLine1.Location = new System.Drawing.Point(13, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 84;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(259, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "询问时间：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "第";
            // 
            // EnquireCount
            // 
            this.EnquireCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquireCount.BackColor = System.Drawing.Color.White;
            this.EnquireCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquireCount.ControlText = "";
            this.EnquireCount.Location = new System.Drawing.Point(618, 144);
            this.EnquireCount.Name = "EnquireCount";
            this.EnquireCount.Size = new System.Drawing.Size(26, 19);
            this.EnquireCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "次询问";
            // 
            // EnquireAddress
            // 
            this.EnquireAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquireAddress.BackColor = System.Drawing.Color.White;
            this.EnquireAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquireAddress.ControlText = "";
            this.EnquireAddress.Location = new System.Drawing.Point(123, 176);
            this.EnquireAddress.Name = "EnquireAddress";
            this.EnquireAddress.Size = new System.Drawing.Size(583, 19);
            this.EnquireAddress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "询问地点：";
            // 
            // EnquirePersonUnit
            // 
            this.EnquirePersonUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonUnit.BackColor = System.Drawing.Color.White;
            this.EnquirePersonUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonUnit.ControlText = "";
            this.EnquirePersonUnit.Location = new System.Drawing.Point(113, 238);
            this.EnquirePersonUnit.Name = "EnquirePersonUnit";
            this.EnquirePersonUnit.Size = new System.Drawing.Size(233, 19);
            this.EnquirePersonUnit.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "工作单位: ";
            // 
            // EnquirePersonAge
            // 
            this.EnquirePersonAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonAge.BackColor = System.Drawing.Color.White;
            this.EnquirePersonAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonAge.ControlText = "";
            this.EnquirePersonAge.Location = new System.Drawing.Point(423, 201);
            this.EnquirePersonAge.Name = "EnquirePersonAge";
            this.EnquirePersonAge.Size = new System.Drawing.Size(45, 19);
            this.EnquirePersonAge.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "年龄：";
            // 
            // EnquirePersonSex
            // 
            this.EnquirePersonSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonSex.BackColor = System.Drawing.Color.White;
            this.EnquirePersonSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonSex.ControlText = "";
            this.EnquirePersonSex.Location = new System.Drawing.Point(322, 202);
            this.EnquirePersonSex.Name = "EnquirePersonSex";
            this.EnquirePersonSex.Size = new System.Drawing.Size(33, 19);
            this.EnquirePersonSex.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(260, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "性别：";
            // 
            // EnquirePerson
            // 
            this.EnquirePerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePerson.BackColor = System.Drawing.Color.White;
            this.EnquirePerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePerson.ControlText = "";
            this.EnquirePerson.Location = new System.Drawing.Point(158, 203);
            this.EnquirePerson.Name = "EnquirePerson";
            this.EnquirePerson.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePerson.PopupOffset = new System.Drawing.Point(12, 0);
            this.EnquirePerson.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.EnquirePerson.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnquirePerson.PopupWidth = 300;
            this.EnquirePerson.Size = new System.Drawing.Size(95, 19);
            this.EnquirePerson.TabIndex = 13;
            this.EnquirePerson.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.EnquirePerson_SelectedValueChangedEvent);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "被询问人姓名：";
            // 
            // EnquirePersonIDC
            // 
            this.EnquirePersonIDC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonIDC.BackColor = System.Drawing.Color.White;
            this.EnquirePersonIDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonIDC.ControlText = "";
            this.EnquirePersonIDC.Location = new System.Drawing.Point(568, 201);
            this.EnquirePersonIDC.Name = "EnquirePersonIDC";
            this.EnquirePersonIDC.Size = new System.Drawing.Size(145, 19);
            this.EnquirePersonIDC.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "身份证号：";
            // 
            // EnquirePersonJob
            // 
            this.EnquirePersonJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonJob.BackColor = System.Drawing.Color.White;
            this.EnquirePersonJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonJob.ControlText = "";
            this.EnquirePersonJob.Location = new System.Drawing.Point(423, 238);
            this.EnquirePersonJob.Name = "EnquirePersonJob";
            this.EnquirePersonJob.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonJob.PopupOffset = new System.Drawing.Point(12, 0);
            this.EnquirePersonJob.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.EnquirePersonJob.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnquirePersonJob.PopupWidth = 300;
            this.EnquirePersonJob.Size = new System.Drawing.Size(121, 19);
            this.EnquirePersonJob.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "职务：";
            // 
            // EnquirePersonTel
            // 
            this.EnquirePersonTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonTel.BackColor = System.Drawing.Color.White;
            this.EnquirePersonTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonTel.ControlText = "";
            this.EnquirePersonTel.Location = new System.Drawing.Point(423, 272);
            this.EnquirePersonTel.Name = "EnquirePersonTel";
            this.EnquirePersonTel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonTel.PopupOffset = new System.Drawing.Point(12, 0);
            this.EnquirePersonTel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.EnquirePersonTel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnquirePersonTel.PopupWidth = 300;
            this.EnquirePersonTel.Size = new System.Drawing.Size(121, 19);
            this.EnquirePersonTel.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "电话：";
            // 
            // EnquirePersonAddress
            // 
            this.EnquirePersonAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirePersonAddress.BackColor = System.Drawing.Color.White;
            this.EnquirePersonAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirePersonAddress.ControlText = "";
            this.EnquirePersonAddress.Location = new System.Drawing.Point(94, 272);
            this.EnquirePersonAddress.Name = "EnquirePersonAddress";
            this.EnquirePersonAddress.Size = new System.Drawing.Size(233, 19);
            this.EnquirePersonAddress.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "住址：";
            // 
            // EnquirerUnit
            // 
            this.EnquirerUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirerUnit.BackColor = System.Drawing.Color.White;
            this.EnquirerUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirerUnit.ControlText = "";
            this.EnquirerUnit.Location = new System.Drawing.Point(382, 313);
            this.EnquirerUnit.Name = "EnquirerUnit";
            this.EnquirerUnit.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirerUnit.PopupOffset = new System.Drawing.Point(12, 0);
            this.EnquirerUnit.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.EnquirerUnit.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnquirerUnit.PopupWidth = 300;
            this.EnquirerUnit.Size = new System.Drawing.Size(331, 19);
            this.EnquirerUnit.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "单位：";
            // 
            // EnquirerName
            // 
            this.EnquirerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquirerName.BackColor = System.Drawing.Color.White;
            this.EnquirerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirerName.ControlText = "";
            this.EnquirerName.Location = new System.Drawing.Point(110, 313);
            this.EnquirerName.Name = "EnquirerName";
            this.EnquirerName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnquirerName.PopupOffset = new System.Drawing.Point(12, 0);
            this.EnquirerName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.EnquirerName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnquirerName.PopupWidth = 300;
            this.EnquirerName.Size = new System.Drawing.Size(190, 19);
            this.EnquirerName.TabIndex = 29;
            this.EnquirerName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.EnquirerName_SelectedValueChangedEvent);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "询问人：";
            // 
            // WriterUnit
            // 
            this.WriterUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WriterUnit.BackColor = System.Drawing.Color.White;
            this.WriterUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriterUnit.ControlText = "";
            this.WriterUnit.Location = new System.Drawing.Point(423, 348);
            this.WriterUnit.Name = "WriterUnit";
            this.WriterUnit.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriterUnit.PopupOffset = new System.Drawing.Point(12, 0);
            this.WriterUnit.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.WriterUnit.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WriterUnit.PopupWidth = 300;
            this.WriterUnit.Size = new System.Drawing.Size(290, 19);
            this.WriterUnit.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "单位及职务：";
            // 
            // WriterName
            // 
            this.WriterName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WriterName.BackColor = System.Drawing.Color.White;
            this.WriterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriterName.ControlText = "";
            this.WriterName.Location = new System.Drawing.Point(110, 348);
            this.WriterName.Name = "WriterName";
            this.WriterName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriterName.PopupOffset = new System.Drawing.Point(12, 0);
            this.WriterName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.WriterName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WriterName.PopupWidth = 300;
            this.WriterName.Size = new System.Drawing.Size(190, 19);
            this.WriterName.TabIndex = 33;
            this.WriterName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.WriterName_SelectedValueChangedEvent);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "记录人：";
            // 
            // Attendee
            // 
            this.Attendee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Attendee.BackColor = System.Drawing.Color.White;
            this.Attendee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Attendee.ControlText = "";
            this.Attendee.Location = new System.Drawing.Point(110, 388);
            this.Attendee.Name = "Attendee";
            this.Attendee.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Attendee.PopupOffset = new System.Drawing.Point(12, 0);
            this.Attendee.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Attendee.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Attendee.PopupWidth = 300;
            this.Attendee.Size = new System.Drawing.Size(603, 19);
            this.Attendee.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 388);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "在场人：";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(521, 464);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(232, 16);
            this.label19.TabIndex = 50;
            this.label19.Text = "这是我们的证件（出示证件）。";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(489, 464);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 16);
            this.label20.TabIndex = 49;
            this.label20.Text = "，";
            // 
            // QFirstPerson2IDC2
            // 
            this.QFirstPerson2IDC2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson2IDC2.BackColor = System.Drawing.Color.White;
            this.QFirstPerson2IDC2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2IDC2.ControlText = "";
            this.QFirstPerson2IDC2.Location = new System.Drawing.Point(301, 458);
            this.QFirstPerson2IDC2.Name = "QFirstPerson2IDC2";
            this.QFirstPerson2IDC2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2IDC2.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson2IDC2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson2IDC2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson2IDC2.PopupWidth = 300;
            this.QFirstPerson2IDC2.Size = new System.Drawing.Size(173, 19);
            this.QFirstPerson2IDC2.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(278, 464);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "、";
            // 
            // QFirstPersonIDC1
            // 
            this.QFirstPersonIDC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPersonIDC1.BackColor = System.Drawing.Color.White;
            this.QFirstPersonIDC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonIDC1.ControlText = "";
            this.QFirstPersonIDC1.Location = new System.Drawing.Point(99, 458);
            this.QFirstPersonIDC1.Name = "QFirstPersonIDC1";
            this.QFirstPersonIDC1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPersonIDC1.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPersonIDC1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPersonIDC1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPersonIDC1.PopupWidth = 300;
            this.QFirstPersonIDC1.Size = new System.Drawing.Size(173, 19);
            this.QFirstPersonIDC1.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 458);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 16);
            this.label22.TabIndex = 45;
            this.label22.Text = "证件号码为";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(696, 425);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 16);
            this.label23.TabIndex = 44;
            this.label23.Text = "，";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(569, 425);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 16);
            this.label24.TabIndex = 42;
            this.label24.Text = "、";
            // 
            // QFirstPerson2
            // 
            this.QFirstPerson2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson2.BackColor = System.Drawing.Color.White;
            this.QFirstPerson2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2.ControlText = "";
            this.QFirstPerson2.Location = new System.Drawing.Point(599, 425);
            this.QFirstPerson2.Name = "QFirstPerson2";
            this.QFirstPerson2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson2.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson2.PopupWidth = 300;
            this.QFirstPerson2.Size = new System.Drawing.Size(91, 19);
            this.QFirstPerson2.TabIndex = 43;
            this.QFirstPerson2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.QFirstPerson2_SelectedValueChangedEvent);
            // 
            // QFirstPerson1
            // 
            this.QFirstPerson1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson1.BackColor = System.Drawing.Color.White;
            this.QFirstPerson1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson1.ControlText = "";
            this.QFirstPerson1.Location = new System.Drawing.Point(454, 423);
            this.QFirstPerson1.Name = "QFirstPerson1";
            this.QFirstPerson1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson1.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson1.PopupWidth = 300;
            this.QFirstPerson1.Size = new System.Drawing.Size(109, 19);
            this.QFirstPerson1.TabIndex = 41;
            this.QFirstPerson1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.QFirstPerson1_SelectedValueChangedEvent);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(232, 428);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(216, 16);
            this.label25.TabIndex = 40;
            this.label25.Text = "安全生产监督管理局执法人员";
            // 
            // QFirstUnit
            // 
            this.QFirstUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstUnit.BackColor = System.Drawing.Color.White;
            this.QFirstUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstUnit.ControlText = "";
            this.QFirstUnit.Location = new System.Drawing.Point(123, 426);
            this.QFirstUnit.Name = "QFirstUnit";
            this.QFirstUnit.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstUnit.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstUnit.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstUnit.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstUnit.PopupWidth = 300;
            this.QFirstUnit.Size = new System.Drawing.Size(100, 19);
            this.QFirstUnit.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(37, 426);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 16);
            this.label26.TabIndex = 38;
            this.label26.Text = "问:我们是";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(32, 493);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 16);
            this.label27.TabIndex = 51;
            this.label27.Text = "你查验清楚了吗？";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.QFirstAnswer);
            this.groupBox1.Location = new System.Drawing.Point(35, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 100);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答：";
            // 
            // QFirstAnswer
            // 
            this.QFirstAnswer.ControlText = "";
            this.QFirstAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QFirstAnswer.Location = new System.Drawing.Point(3, 22);
            this.QFirstAnswer.Name = "QFirstAnswer";
            this.QFirstAnswer.Size = new System.Drawing.Size(679, 75);
            this.QFirstAnswer.TabIndex = 0;
            this.QFirstAnswer.Text = "";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(35, 642);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 16);
            this.label28.TabIndex = 53;
            this.label28.Text = "问：我们依法就";
            // 
            // QuestionSecond
            // 
            this.QuestionSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionSecond.BackColor = System.Drawing.Color.White;
            this.QuestionSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionSecond.ControlText = "";
            this.QuestionSecond.Location = new System.Drawing.Point(158, 642);
            this.QuestionSecond.Name = "QuestionSecond";
            this.QuestionSecond.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionSecond.PopupOffset = new System.Drawing.Point(12, 0);
            this.QuestionSecond.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QuestionSecond.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuestionSecond.PopupWidth = 300;
            this.QuestionSecond.Size = new System.Drawing.Size(290, 19);
            this.QuestionSecond.TabIndex = 54;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(454, 642);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(264, 16);
            this.label29.TabIndex = 55;
            this.label29.Text = "的有关问题向你了解情况，你有如实";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(71, 674);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(552, 16);
            this.label30.TabIndex = 57;
            this.label30.Text = "回答问题的义务，提供虚假情况、作伪证是要负法律责任的。你听清楚了吗？";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.QuestionSecondAnswer);
            this.groupBox2.Location = new System.Drawing.Point(35, 703);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 100);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "答：";
            // 
            // QuestionSecondAnswer
            // 
            this.QuestionSecondAnswer.ControlText = "";
            this.QuestionSecondAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionSecondAnswer.Location = new System.Drawing.Point(3, 22);
            this.QuestionSecondAnswer.Name = "QuestionSecondAnswer";
            this.QuestionSecondAnswer.Size = new System.Drawing.Size(679, 75);
            this.QuestionSecondAnswer.TabIndex = 0;
            this.QuestionSecondAnswer.Text = "";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(32, 816);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(328, 16);
            this.label31.TabIndex = 59;
            this.label31.Text = "问：你有申请回避的权利，你是否申请回避？";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.QuestionThirdAnswer);
            this.groupBox3.Location = new System.Drawing.Point(32, 848);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 100);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "答：";
            // 
            // QuestionThirdAnswer
            // 
            this.QuestionThirdAnswer.ControlText = "";
            this.QuestionThirdAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionThirdAnswer.Location = new System.Drawing.Point(3, 22);
            this.QuestionThirdAnswer.Name = "QuestionThirdAnswer";
            this.QuestionThirdAnswer.Size = new System.Drawing.Size(679, 75);
            this.QuestionThirdAnswer.TabIndex = 0;
            this.QuestionThirdAnswer.Text = "";
            // 
            // EnquireBeginDate
            // 
            this.EnquireBeginDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquireBeginDate.CustomFormat = "yyyy年M月d日 H时  m分";
            this.EnquireBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EnquireBeginDate.Location = new System.Drawing.Point(102, 140);
            this.EnquireBeginDate.Name = "EnquireBeginDate";
            this.EnquireBeginDate.Size = new System.Drawing.Size(244, 26);
            this.EnquireBeginDate.TabIndex = 3;
            // 
            // EnquireEndDate
            // 
            this.EnquireEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquireEndDate.Checked = false;
            this.EnquireEndDate.CustomFormat = "M月d日  H时  m分";
            this.EnquireEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EnquireEndDate.Location = new System.Drawing.Point(383, 139);
            this.EnquireEndDate.Name = "EnquireEndDate";
            this.EnquireEndDate.Size = new System.Drawing.Size(200, 26);
            this.EnquireEndDate.TabIndex = 5;
            this.EnquireEndDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(353, 144);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(24, 16);
            this.label32.TabIndex = 4;
            this.label32.Text = "至";
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(557, 1326);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(163, 26);
            this.DocDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.questionContainer);
            this.groupBox4.Location = new System.Drawing.Point(32, 954);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 366);
            this.groupBox4.TabIndex = 61;
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
            this.questionContainer.Size = new System.Drawing.Size(679, 341);
            this.questionContainer.TabIndex = 0;
            // 
            // frmEnquireQuestion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEnquireQuestion";
            this.Size = new System.Drawing.Size(810, 1393);
            this.Load += new System.EventHandler(this.frmEnquireQuestion_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableTextBox EnquireCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableTextBox EnquireAddress;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableTextBox EnquirePersonIDC;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableTextBox EnquirePersonUnit;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableTextBox EnquirePersonAge;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableTextBox EnquirePersonSex;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox EnquirePerson;
        private System.Windows.Forms.Label label16;
        private EnforceUI.TableAutoCompleteTextBox EnquirePersonJob;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableAutoCompleteTextBox EnquirePersonTel;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableTextBox EnquirePersonAddress;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox Attendee;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox WriterUnit;
        private System.Windows.Forms.Label label12;
        private EnforceUI.TableAutoCompleteTextBox WriterName;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox EnquirerUnit;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox EnquirerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private EnforceUI.TableAutoCompleteTextBox QuestionSecond;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox QFirstAnswer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson2IDC2;
        private System.Windows.Forms.Label label21;
        private EnforceUI.TableAutoCompleteTextBox QFirstPersonIDC1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson2;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson1;
        private System.Windows.Forms.Label label25;
        private EnforceUI.TableAutoCompleteTextBox QFirstUnit;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox QuestionThirdAnswer;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox QuestionSecondAnswer;
        private EnforceUI.TableDateTimePicker EnquireBeginDate;
        private EnforceUI.TableDateTimePicker EnquireEndDate;
        private System.Windows.Forms.Label label32;
        private EnforceUI.TableDateTimePicker DocDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private EnforceUI.QuestionContainer questionContainer;
    }
}

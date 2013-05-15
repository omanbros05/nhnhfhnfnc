namespace EnforceForm
{
    partial class frmHearingNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHearingNotice));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Informant = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.About = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HearAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CompereName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.CompereJob = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.HearJob1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.HearName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.SecretaryJob = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.SecretaryName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.HearJob2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.HearName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.HearDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocManageAddress = new EnforceUI.TableTextBox(this.components);
            this.DocManagePost = new EnforceUI.TableTextBox(this.components);
            this.LinkMan = new EnforceUI.TableTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
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
            this.panelContent.Controls.Add(this.LinkMan);
            this.panelContent.Controls.Add(this.DocManagePost);
            this.panelContent.Controls.Add(this.DocManageAddress);
            this.panelContent.Controls.Add(this.HearDate);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.label26);
            this.panelContent.Controls.Add(this.label25);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.label23);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.SecretaryJob);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.SecretaryName);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.HearJob2);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.HearName2);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.HearJob1);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.HearName1);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.CompereJob);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.CompereName);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.HearAddress);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.About);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.Informant);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(852, 704);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 779);
            this.panel1.Size = new System.Drawing.Size(852, 41);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(852, 75);
            this.header1.Title = "听证会通知书 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(311, 109);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "听证会通知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(35, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 69;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(281, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "：";
            // 
            // Informant
            // 
            this.Informant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Informant.BackColor = System.Drawing.Color.White;
            this.Informant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Informant.ControlText = "";
            this.Informant.Location = new System.Drawing.Point(35, 177);
            this.Informant.Name = "Informant";
            this.Informant.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Informant.PopupOffset = new System.Drawing.Point(12, 0);
            this.Informant.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Informant.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Informant.PopupWidth = 300;
            this.Informant.Size = new System.Drawing.Size(190, 19);
            this.Informant.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "根据你（单位）申请，关于";
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.About.BackColor = System.Drawing.Color.White;
            this.About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About.ControlText = "";
            this.About.Location = new System.Drawing.Point(238, 208);
            this.About.Name = "About";
            this.About.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About.PopupOffset = new System.Drawing.Point(12, 0);
            this.About.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.About.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.About.PopupWidth = 300;
            this.About.Size = new System.Drawing.Size(403, 19);
            this.About.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "一案，现定";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "于";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "在";
            // 
            // HearAddress
            // 
            this.HearAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearAddress.BackColor = System.Drawing.Color.White;
            this.HearAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearAddress.ControlText = "";
            this.HearAddress.Location = new System.Drawing.Point(324, 246);
            this.HearAddress.Name = "HearAddress";
            this.HearAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearAddress.PopupWidth = 300;
            this.HearAddress.Size = new System.Drawing.Size(333, 19);
            this.HearAddress.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(663, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "（公开、";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "不公开）举行听证会议，请准时出席。";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "听证主持人姓名：";
            // 
            // CompereName
            // 
            this.CompereName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompereName.BackColor = System.Drawing.Color.White;
            this.CompereName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereName.ControlText = "";
            this.CompereName.Location = new System.Drawing.Point(191, 310);
            this.CompereName.Name = "CompereName";
            this.CompereName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompereName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompereName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompereName.PopupWidth = 300;
            this.CompereName.Size = new System.Drawing.Size(190, 19);
            this.CompereName.TabIndex = 15;
            this.CompereName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CompereName_SelectedValueChangedEvent);
            this.CompereName.SelectedListIndexChangeEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedListIndexChangedEventHandeler(this.CompereName_SelectedListIndexChangeEvent);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "职务：";
            // 
            // CompereJob
            // 
            this.CompereJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompereJob.BackColor = System.Drawing.Color.White;
            this.CompereJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereJob.ControlText = "";
            this.CompereJob.Location = new System.Drawing.Point(446, 310);
            this.CompereJob.Name = "CompereJob";
            this.CompereJob.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereJob.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompereJob.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompereJob.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompereJob.PopupWidth = 300;
            this.CompereJob.Size = new System.Drawing.Size(190, 19);
            this.CompereJob.TabIndex = 17;
            // 
            // HearJob1
            // 
            this.HearJob1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearJob1.BackColor = System.Drawing.Color.White;
            this.HearJob1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearJob1.ControlText = "";
            this.HearJob1.Location = new System.Drawing.Point(446, 335);
            this.HearJob1.Name = "HearJob1";
            this.HearJob1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearJob1.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearJob1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearJob1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearJob1.PopupWidth = 300;
            this.HearJob1.Size = new System.Drawing.Size(190, 19);
            this.HearJob1.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "职务：";
            // 
            // HearName1
            // 
            this.HearName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearName1.BackColor = System.Drawing.Color.White;
            this.HearName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName1.ControlText = "";
            this.HearName1.Location = new System.Drawing.Point(191, 335);
            this.HearName1.Name = "HearName1";
            this.HearName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearName1.PopupWidth = 300;
            this.HearName1.Size = new System.Drawing.Size(190, 19);
            this.HearName1.TabIndex = 19;
            this.HearName1.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.HearName1_SelectedValueChangedEvent);
            this.HearName1.SelectedListIndexChangeEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedListIndexChangedEventHandeler(this.HearName1_SelectedListIndexChangeEvent);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 335);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "听证员姓名：";
            // 
            // SecretaryJob
            // 
            this.SecretaryJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SecretaryJob.BackColor = System.Drawing.Color.White;
            this.SecretaryJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryJob.ControlText = "";
            this.SecretaryJob.Location = new System.Drawing.Point(446, 385);
            this.SecretaryJob.Name = "SecretaryJob";
            this.SecretaryJob.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryJob.PopupOffset = new System.Drawing.Point(12, 0);
            this.SecretaryJob.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SecretaryJob.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecretaryJob.PopupWidth = 300;
            this.SecretaryJob.Size = new System.Drawing.Size(190, 19);
            this.SecretaryJob.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(387, 385);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "职务：";
            // 
            // SecretaryName
            // 
            this.SecretaryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SecretaryName.BackColor = System.Drawing.Color.White;
            this.SecretaryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryName.ControlText = "";
            this.SecretaryName.Location = new System.Drawing.Point(191, 385);
            this.SecretaryName.Name = "SecretaryName";
            this.SecretaryName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryName.PopupOffset = new System.Drawing.Point(12, 0);
            this.SecretaryName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SecretaryName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecretaryName.PopupWidth = 300;
            this.SecretaryName.Size = new System.Drawing.Size(190, 19);
            this.SecretaryName.TabIndex = 27;
            this.SecretaryName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.SecretaryName_SelectedValueChangedEvent);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "书记员姓名：";
            // 
            // HearJob2
            // 
            this.HearJob2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearJob2.BackColor = System.Drawing.Color.White;
            this.HearJob2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearJob2.ControlText = "";
            this.HearJob2.Location = new System.Drawing.Point(446, 360);
            this.HearJob2.Name = "HearJob2";
            this.HearJob2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearJob2.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearJob2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearJob2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearJob2.PopupWidth = 300;
            this.HearJob2.Size = new System.Drawing.Size(190, 19);
            this.HearJob2.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(387, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 24;
            this.label20.Text = "职务：";
            // 
            // HearName2
            // 
            this.HearName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearName2.BackColor = System.Drawing.Color.White;
            this.HearName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName2.ControlText = "";
            this.HearName2.Location = new System.Drawing.Point(191, 360);
            this.HearName2.Name = "HearName2";
            this.HearName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearName2.PopupWidth = 300;
            this.HearName2.Size = new System.Drawing.Size(190, 19);
            this.HearName2.TabIndex = 23;
            this.HearName2.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.HearName2_SelectedValueChangedEvent);
            this.HearName2.SelectedListIndexChangeEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedListIndexChangedEventHandeler(this.HearName2_SelectedListIndexChangeEvent);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(49, 360);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 22;
            this.label21.Text = "听证员姓名：";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 418);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(664, 16);
            this.label22.TabIndex = 30;
            this.label22.Text = "根据《中华人民共和国行政处罚法》第四十二条规定，你（单位）可以申请听证主持人回避。";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(49, 450);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 16);
            this.label23.TabIndex = 31;
            this.label23.Text = "注意事项如下：";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(49, 477);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(424, 16);
            this.label24.TabIndex = 32;
            this.label24.Text = "1.请事先准备相关证据，通知证人和委托代理人准时参加。";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 503);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(624, 16);
            this.label25.TabIndex = 33;
            this.label25.Text = "2．委托代理人参加听证的，应当在听证会前向本行政机关提交授权委托书等有关证明。";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(49, 529);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(648, 16);
            this.label26.TabIndex = 34;
            this.label26.Text = "3.申请延期举行的，应当在举行听证会前向本行政机关提出，由本行政机关决定是否延期。";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(50, 555);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(456, 16);
            this.label27.TabIndex = 35;
            this.label27.Text = "4.不按时参加听证会且未事先说明理由的，视为放弃听证权利。";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(50, 591);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 16);
            this.label28.TabIndex = 36;
            this.label28.Text = "特此通知。";
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(543, 640);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(145, 26);
            this.DocDate.TabIndex = 38;
            this.DocDate.Value = new System.DateTime(2013, 3, 10, 0, 0, 0, 0);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管听通〔2012〕1号";
            this.DocTitle.Location = new System.Drawing.Point(201, 134);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管听通〔2012〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(424, 614);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 37;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HearDate
            // 
            this.HearDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearDate.CustomFormat = "yyyy年M月d日 H时 m分";
            this.HearDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HearDate.Location = new System.Drawing.Point(62, 241);
            this.HearDate.Name = "HearDate";
            this.HearDate.Size = new System.Drawing.Size(221, 26);
            this.HearDate.TabIndex = 9;
            this.HearDate.Value = new System.DateTime(2013, 3, 10, 20, 19, 0, 0);
            // 
            // DocManageAddress
            // 
            this.DocManageAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageAddress.BackColor = System.Drawing.Color.White;
            this.DocManageAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageAddress.ControlText = "×××安全生产监督管理局地址：××省××市××区××街××号";
            this.DocManageAddress.Location = new System.Drawing.Point(67, 690);
            this.DocManageAddress.Name = "DocManageAddress";
            this.DocManageAddress.Size = new System.Drawing.Size(492, 19);
            this.DocManageAddress.TabIndex = 70;
            this.DocManageAddress.Text = "×××安全生产监督管理局地址：××省××市××区××街××号";
            // 
            // DocManagePost
            // 
            this.DocManagePost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManagePost.BackColor = System.Drawing.Color.White;
            this.DocManagePost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManagePost.ControlText = "邮  编：××××××      联系人：××× ";
            this.DocManagePost.Location = new System.Drawing.Point(67, 715);
            this.DocManagePost.Name = "DocManagePost";
            this.DocManagePost.Size = new System.Drawing.Size(345, 19);
            this.DocManagePost.TabIndex = 71;
            this.DocManagePost.Text = "邮  编：××××××      联系人：××× ";
            // 
            // LinkMan
            // 
            this.LinkMan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LinkMan.BackColor = System.Drawing.Color.White;
            this.LinkMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkMan.ControlText = "联系电话：××××—××××××××";
            this.LinkMan.Location = new System.Drawing.Point(67, 740);
            this.LinkMan.Name = "LinkMan";
            this.LinkMan.Size = new System.Drawing.Size(345, 19);
            this.LinkMan.TabIndex = 72;
            this.LinkMan.Text = "联系电话：××××—××××××××";
            // 
            // frmHearingNotice
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmHearingNotice";
            this.Size = new System.Drawing.Size(852, 820);
            this.Load += new System.EventHandler(this.frmHearingNotice_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox Informant;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox About;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private EnforceUI.TableAutoCompleteTextBox HearAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private EnforceUI.TableAutoCompleteTextBox SecretaryJob;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox SecretaryName;
        private System.Windows.Forms.Label label19;
        private EnforceUI.TableAutoCompleteTextBox HearJob2;
        private System.Windows.Forms.Label label20;
        private EnforceUI.TableAutoCompleteTextBox HearName2;
        private System.Windows.Forms.Label label21;
        private EnforceUI.TableAutoCompleteTextBox HearJob1;
        private System.Windows.Forms.Label label16;
        private EnforceUI.TableAutoCompleteTextBox HearName1;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableAutoCompleteTextBox CompereJob;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox CompereName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private EnforceUI.TableDateTimePicker DocDate;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker HearDate;
        private EnforceUI.TableTextBox DocManageAddress;
        private EnforceUI.TableTextBox LinkMan;
        private EnforceUI.TableTextBox DocManagePost;
    }
}

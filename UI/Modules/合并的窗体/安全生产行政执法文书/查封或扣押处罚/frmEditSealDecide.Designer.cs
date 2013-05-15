namespace EnforceForm
{
    partial class frmEditSealDecide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSealDecide));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.SealReason = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.SealLaw = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Government = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ManageDepartment = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.Court = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SealLocation = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.SealStartDate = new EnforceUI.TableDateTimePicker(this.components);
            this.SealEndDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.HandleDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
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
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.btnSelect);
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.HandleDate);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.SealStartDate);
            this.panelContent.Controls.Add(this.SealEndDate);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.SealLocation);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.ManageDepartment);
            this.panelContent.Controls.Add(this.Court);
            this.panelContent.Controls.Add(this.Government);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.SealLaw);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.SealReason);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 623);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 698);
            this.panel1.Size = new System.Drawing.Size(886, 42);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "查封或扣押决定书 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(273, 120);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(169, 20);
            this.headerLabel2.TabIndex = 6;
            this.headerLabel2.Text = "查封(扣押)决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(0, 108);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 7;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(253, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 5;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(33, 190);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(399, 19);
            this.CompanyName.TabIndex = 40;
            // 
            // SealReason
            // 
            this.SealReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealReason.BackColor = System.Drawing.Color.White;
            this.SealReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealReason.ControlText = "";
            this.SealReason.Location = new System.Drawing.Point(230, 230);
            this.SealReason.Name = "SealReason";
            this.SealReason.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealReason.PopupOffset = new System.Drawing.Point(12, 0);
            this.SealReason.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SealReason.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SealReason.PopupWidth = 300;
            this.SealReason.Size = new System.Drawing.Size(481, 19);
            this.SealReason.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "经查，你（单位）存在";
            // 
            // SealLaw
            // 
            this.SealLaw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealLaw.BackColor = System.Drawing.Color.White;
            this.SealLaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealLaw.ControlText = "";
            this.SealLaw.Location = new System.Drawing.Point(119, 262);
            this.SealLaw.Name = "SealLaw";
            this.SealLaw.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealLaw.PopupOffset = new System.Drawing.Point(12, 0);
            this.SealLaw.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SealLaw.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SealLaw.PopupWidth = 300;
            this.SealLaw.Size = new System.Drawing.Size(499, 19);
            this.SealLaw.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "问题，根据";
            // 
            // Government
            // 
            this.Government.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Government.BackColor = System.Drawing.Color.White;
            this.Government.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Government.ControlText = "";
            this.Government.Location = new System.Drawing.Point(320, 361);
            this.Government.Name = "Government";
            this.Government.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Government.PopupOffset = new System.Drawing.Point(12, 0);
            this.Government.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Government.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Government.PopupWidth = 300;
            this.Government.Size = new System.Drawing.Size(97, 19);
            this.Government.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "如不服本决定，可以依法在60日内向";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "人民政府或者";
            // 
            // ManageDepartment
            // 
            this.ManageDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageDepartment.BackColor = System.Drawing.Color.White;
            this.ManageDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageDepartment.ControlText = "";
            this.ManageDepartment.Location = new System.Drawing.Point(527, 361);
            this.ManageDepartment.Name = "ManageDepartment";
            this.ManageDepartment.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageDepartment.PopupOffset = new System.Drawing.Point(12, 0);
            this.ManageDepartment.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ManageDepartment.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageDepartment.PopupWidth = 300;
            this.ManageDepartment.Size = new System.Drawing.Size(184, 19);
            this.ManageDepartment.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // Court
            // 
            this.Court.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Court.BackColor = System.Drawing.Color.White;
            this.Court.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Court.ControlText = "";
            this.Court.Location = new System.Drawing.Point(305, 390);
            this.Court.Name = "Court";
            this.Court.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Court.PopupOffset = new System.Drawing.Point(12, 0);
            this.Court.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Court.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Court.PopupWidth = 300;
            this.Court.Size = new System.Drawing.Size(232, 19);
            this.Court.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "人民法院提起行政诉讼，";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "查封（扣押）地点：";
            // 
            // SealLocation
            // 
            this.SealLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealLocation.BackColor = System.Drawing.Color.White;
            this.SealLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealLocation.ControlText = "";
            this.SealLocation.Location = new System.Drawing.Point(176, 501);
            this.SealLocation.Name = "SealLocation";
            this.SealLocation.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SealLocation.PopupOffset = new System.Drawing.Point(12, 0);
            this.SealLocation.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SealLocation.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SealLocation.PopupWidth = 300;
            this.SealLocation.Size = new System.Drawing.Size(535, 19);
            this.SealLocation.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 542);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "查封（扣押）期限：";
            // 
            // SealStartDate
            // 
            this.SealStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealStartDate.CustomFormat = "yyyy年M月d日  H时  m分";
            this.SealStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SealStartDate.Location = new System.Drawing.Point(176, 538);
            this.SealStartDate.Name = "SealStartDate";
            this.SealStartDate.Size = new System.Drawing.Size(200, 26);
            this.SealStartDate.TabIndex = 54;
            this.SealStartDate.Value = new System.DateTime(2013, 3, 7, 0, 0, 0, 0);
            // 
            // SealEndDate
            // 
            this.SealEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealEndDate.Checked = false;
            this.SealEndDate.CustomFormat = "M月d日  H时  m分";
            this.SealEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SealEndDate.Location = new System.Drawing.Point(461, 538);
            this.SealEndDate.Name = "SealEndDate";
            this.SealEndDate.Size = new System.Drawing.Size(200, 26);
            this.SealEndDate.TabIndex = 52;
            this.SealEndDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(411, 542);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 53;
            this.label16.Text = "至";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 583);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 16);
            this.label18.TabIndex = 55;
            this.label18.Text = "行政执法人员：";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(328, 583);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "、";
            // 
            // HandleDate
            // 
            this.HandleDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HandleDate.CustomFormat = "yyyy年M月d日";
            this.HandleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HandleDate.Location = new System.Drawing.Point(493, 662);
            this.HandleDate.Name = "HandleDate";
            this.HandleDate.Size = new System.Drawing.Size(168, 26);
            this.HandleDate.TabIndex = 59;
            this.HandleDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "：";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 298);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(696, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "的规定，现决定对查封（扣押）清单所列物品予以查封（扣押）。在查封（扣押）期间，未经本局";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(440, 16);
            this.label20.TabIndex = 47;
            this.label20.Text = "同意，任何人不得隐匿、转移、变卖、损毁本决定所列物品。";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 427);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(328, 16);
            this.label21.TabIndex = 50;
            this.label21.Text = "但本决定不停止执行，法律另有规定的除外。";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 462);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(216, 16);
            this.label22.TabIndex = 50;
            this.label22.Text = "查封（扣押）物品：清单附后";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管查(扣)(2010〕 号";
            this.DocTitle.Location = new System.Drawing.Point(154, 157);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 102;
            this.DocTitle.Text = "(××)安监管查(扣)(2010〕 号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(148, 584);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(177, 19);
            this.UserName1.TabIndex = 103;
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(351, 584);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(186, 19);
            this.UserName2.TabIndex = 104;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(625, 265);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 23);
            this.btnSelect.TabIndex = 108;
            this.btnSelect.Text = "查询法律";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(444, 637);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 109;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditSealDecide
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEditSealDecide";
            this.Size = new System.Drawing.Size(886, 740);
            this.Load += new System.EventHandler(this.frmEditSealDecide_Load);
            this.Click += new System.EventHandler(this.frmEditSealDecide_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private EnforceUI.TableAutoCompleteTextBox SealReason;
        private System.Windows.Forms.Label label8;
        private EnforceUI.TableAutoCompleteTextBox SealLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableAutoCompleteTextBox ManageDepartment;
        private EnforceUI.TableAutoCompleteTextBox Court;
        private EnforceUI.TableAutoCompleteTextBox Government;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableAutoCompleteTextBox SealLaw;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableDateTimePicker SealStartDate;
        private EnforceUI.TableDateTimePicker SealEndDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableDateTimePicker HandleDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
        private System.Windows.Forms.Button btnSelect;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

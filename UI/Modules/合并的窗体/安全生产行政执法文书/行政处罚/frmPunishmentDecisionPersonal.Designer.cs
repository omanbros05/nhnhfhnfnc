namespace EnforceForm
{
    partial class frmPunishmentDecisionPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPunishmentDecisionPersonal));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.FieldEPeopleZip = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeoplePosition = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleCompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.FieldEPeopleCompanyAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeoplePhone = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleAge = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleSex = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldEPeopleName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IllegalEvidence = new EnforceUI.TableRichTextBox(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PunishmentAmount = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.LitigationUnitName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ReconsiderationUnitName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ReconsiderationUnitName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BankID = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.BankName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PunishmentMoney = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.According = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.IllegalProvisions = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
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
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.label30);
            this.panelContent.Controls.Add(this.label29);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.PunishmentAmount);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.LitigationUnitName);
            this.panelContent.Controls.Add(this.ReconsiderationUnitName2);
            this.panelContent.Controls.Add(this.ReconsiderationUnitName1);
            this.panelContent.Controls.Add(this.BankID);
            this.panelContent.Controls.Add(this.BankName);
            this.panelContent.Controls.Add(this.PunishmentMoney);
            this.panelContent.Controls.Add(this.According);
            this.panelContent.Controls.Add(this.IllegalProvisions);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label25);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.FieldEPeopleZip);
            this.panelContent.Controls.Add(this.FieldEPeoplePosition);
            this.panelContent.Controls.Add(this.FieldEPeopleCompanyName);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.FieldEPeopleCompanyAddress);
            this.panelContent.Controls.Add(this.FieldEPeopleAddress);
            this.panelContent.Controls.Add(this.FieldEPeoplePhone);
            this.panelContent.Controls.Add(this.FieldEPeopleAge);
            this.panelContent.Controls.Add(this.FieldEPeopleSex);
            this.panelContent.Controls.Add(this.FieldEPeopleName);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(819, 1088);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1163);
            this.panel1.Size = new System.Drawing.Size(819, 35);
            this.panel1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(819, 75);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管罚〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(182, 136);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 3;
            this.DocTitle.Text = "(××)安监管罚〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FieldEPeopleZip
            // 
            this.FieldEPeopleZip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleZip.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleZip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleZip.ControlText = "";
            this.FieldEPeopleZip.Location = new System.Drawing.Point(543, 278);
            this.FieldEPeopleZip.Name = "FieldEPeopleZip";
            this.FieldEPeopleZip.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleZip.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleZip.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleZip.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleZip.PopupWidth = 300;
            this.FieldEPeopleZip.Size = new System.Drawing.Size(128, 19);
            this.FieldEPeopleZip.TabIndex = 21;
            // 
            // FieldEPeoplePosition
            // 
            this.FieldEPeoplePosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeoplePosition.BackColor = System.Drawing.Color.White;
            this.FieldEPeoplePosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePosition.ControlText = "";
            this.FieldEPeoplePosition.Location = new System.Drawing.Point(84, 276);
            this.FieldEPeoplePosition.Name = "FieldEPeoplePosition";
            this.FieldEPeoplePosition.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePosition.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeoplePosition.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeoplePosition.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeoplePosition.PopupWidth = 300;
            this.FieldEPeoplePosition.Size = new System.Drawing.Size(118, 19);
            this.FieldEPeoplePosition.TabIndex = 17;
            // 
            // FieldEPeopleCompanyName
            // 
            this.FieldEPeopleCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleCompanyName.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleCompanyName.ControlText = "";
            this.FieldEPeopleCompanyName.Location = new System.Drawing.Point(435, 230);
            this.FieldEPeopleCompanyName.Name = "FieldEPeopleCompanyName";
            this.FieldEPeopleCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleCompanyName.PopupWidth = 300;
            this.FieldEPeopleCompanyName.Size = new System.Drawing.Size(236, 19);
            this.FieldEPeopleCompanyName.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "所在单位：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "邮编：";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "职务：";
            // 
            // FieldEPeopleCompanyAddress
            // 
            this.FieldEPeopleCompanyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleCompanyAddress.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleCompanyAddress.ControlText = "";
            this.FieldEPeopleCompanyAddress.Location = new System.Drawing.Point(285, 278);
            this.FieldEPeopleCompanyAddress.Name = "FieldEPeopleCompanyAddress";
            this.FieldEPeopleCompanyAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleCompanyAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleCompanyAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleCompanyAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleCompanyAddress.PopupWidth = 300;
            this.FieldEPeopleCompanyAddress.Size = new System.Drawing.Size(203, 19);
            this.FieldEPeopleCompanyAddress.TabIndex = 19;
            // 
            // FieldEPeopleAddress
            // 
            this.FieldEPeopleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleAddress.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleAddress.ControlText = "";
            this.FieldEPeopleAddress.Location = new System.Drawing.Point(113, 230);
            this.FieldEPeopleAddress.Name = "FieldEPeopleAddress";
            this.FieldEPeopleAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleAddress.PopupWidth = 300;
            this.FieldEPeopleAddress.Size = new System.Drawing.Size(241, 19);
            this.FieldEPeopleAddress.TabIndex = 13;
            // 
            // FieldEPeoplePhone
            // 
            this.FieldEPeoplePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeoplePhone.BackColor = System.Drawing.Color.White;
            this.FieldEPeoplePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePhone.ControlText = "";
            this.FieldEPeoplePhone.Location = new System.Drawing.Point(532, 180);
            this.FieldEPeoplePhone.Name = "FieldEPeoplePhone";
            this.FieldEPeoplePhone.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeoplePhone.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeoplePhone.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeoplePhone.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeoplePhone.PopupWidth = 300;
            this.FieldEPeoplePhone.Size = new System.Drawing.Size(139, 19);
            this.FieldEPeoplePhone.TabIndex = 11;
            // 
            // FieldEPeopleAge
            // 
            this.FieldEPeopleAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleAge.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleAge.ControlText = "";
            this.FieldEPeopleAge.Location = new System.Drawing.Point(375, 179);
            this.FieldEPeopleAge.Name = "FieldEPeopleAge";
            this.FieldEPeopleAge.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleAge.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleAge.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleAge.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleAge.PopupWidth = 300;
            this.FieldEPeopleAge.Size = new System.Drawing.Size(71, 19);
            this.FieldEPeopleAge.TabIndex = 9;
            // 
            // FieldEPeopleSex
            // 
            this.FieldEPeopleSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleSex.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleSex.ControlText = "";
            this.FieldEPeopleSex.Location = new System.Drawing.Point(254, 180);
            this.FieldEPeopleSex.Name = "FieldEPeopleSex";
            this.FieldEPeopleSex.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleSex.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleSex.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleSex.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleSex.PopupWidth = 300;
            this.FieldEPeopleSex.Size = new System.Drawing.Size(56, 19);
            this.FieldEPeopleSex.TabIndex = 7;
            // 
            // FieldEPeopleName
            // 
            this.FieldEPeopleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldEPeopleName.BackColor = System.Drawing.Color.White;
            this.FieldEPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName.ControlText = "";
            this.FieldEPeopleName.Location = new System.Drawing.Point(113, 180);
            this.FieldEPeopleName.Name = "FieldEPeopleName";
            this.FieldEPeopleName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldEPeopleName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldEPeopleName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldEPeopleName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldEPeopleName.PopupWidth = 300;
            this.FieldEPeopleName.Size = new System.Drawing.Size(89, 19);
            this.FieldEPeopleName.TabIndex = 5;
            this.FieldEPeopleName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.FieldEPeopleName_SelectedValueChangedEvent);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "年龄：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "单位地址：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "家庭住址：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "被处罚人：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(254, 109);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(239, 20);
            this.headerLabel2.TabIndex = 2;
            this.headerLabel2.Text = "行政处罚决定书（个人） ";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-14, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 362;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(257, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 1;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.IllegalEvidence);
            this.groupBox2.Location = new System.Drawing.Point(39, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 272);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细：";
            // 
            // IllegalEvidence
            // 
            this.IllegalEvidence.ControlText = "";
            this.IllegalEvidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IllegalEvidence.Location = new System.Drawing.Point(3, 22);
            this.IllegalEvidence.Name = "IllegalEvidence";
            this.IllegalEvidence.Size = new System.Drawing.Size(626, 247);
            this.IllegalEvidence.TabIndex = 0;
            this.IllegalEvidence.Text = "";
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(397, 1065);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 399;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(462, 1100);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(158, 26);
            this.FillDate.TabIndex = 398;
            this.FillDate.Value = new System.DateTime(2013, 3, 10, 20, 58, 7, 346);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(39, 1005);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 16);
            this.label30.TabIndex = 5;
            this.label30.Text = "定强制执行。";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(39, 967);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(632, 16);
            this.label29.TabIndex = 3;
            this.label29.Text = "议、不提起行政诉讼又不履行的，本机关将依法申请人民法院强制执行或者依照有关规定";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(657, 710);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "。";
            // 
            // PunishmentAmount
            // 
            this.PunishmentAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishmentAmount.BackColor = System.Drawing.Color.White;
            this.PunishmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishmentAmount.ControlText = "零";
            this.PunishmentAmount.Location = new System.Drawing.Point(114, 707);
            this.PunishmentAmount.Name = "PunishmentAmount";
            this.PunishmentAmount.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishmentAmount.PopupOffset = new System.Drawing.Point(12, 0);
            this.PunishmentAmount.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PunishmentAmount.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PunishmentAmount.PopupWidth = 300;
            this.PunishmentAmount.Size = new System.Drawing.Size(267, 19);
            this.PunishmentAmount.TabIndex = 30;
            this.PunishmentAmount.Text = "零";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(382, 707);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "的行政处罚。小写";
            // 
            // LitigationUnitName
            // 
            this.LitigationUnitName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LitigationUnitName.BackColor = System.Drawing.Color.White;
            this.LitigationUnitName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName.ControlText = "";
            this.LitigationUnitName.Location = new System.Drawing.Point(519, 889);
            this.LitigationUnitName.Name = "LitigationUnitName";
            this.LitigationUnitName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LitigationUnitName.PopupOffset = new System.Drawing.Point(12, 0);
            this.LitigationUnitName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LitigationUnitName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LitigationUnitName.PopupWidth = 300;
            this.LitigationUnitName.Size = new System.Drawing.Size(156, 19);
            this.LitigationUnitName.TabIndex = 47;
            // 
            // ReconsiderationUnitName2
            // 
            this.ReconsiderationUnitName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReconsiderationUnitName2.BackColor = System.Drawing.Color.White;
            this.ReconsiderationUnitName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReconsiderationUnitName2.ControlText = "";
            this.ReconsiderationUnitName2.Location = new System.Drawing.Point(76, 889);
            this.ReconsiderationUnitName2.Name = "ReconsiderationUnitName2";
            this.ReconsiderationUnitName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReconsiderationUnitName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.ReconsiderationUnitName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ReconsiderationUnitName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReconsiderationUnitName2.PopupWidth = 300;
            this.ReconsiderationUnitName2.Size = new System.Drawing.Size(156, 19);
            this.ReconsiderationUnitName2.TabIndex = 45;
            // 
            // ReconsiderationUnitName1
            // 
            this.ReconsiderationUnitName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReconsiderationUnitName1.BackColor = System.Drawing.Color.White;
            this.ReconsiderationUnitName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReconsiderationUnitName1.ControlText = "";
            this.ReconsiderationUnitName1.Location = new System.Drawing.Point(363, 844);
            this.ReconsiderationUnitName1.Name = "ReconsiderationUnitName1";
            this.ReconsiderationUnitName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReconsiderationUnitName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.ReconsiderationUnitName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ReconsiderationUnitName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReconsiderationUnitName1.PopupWidth = 300;
            this.ReconsiderationUnitName1.Size = new System.Drawing.Size(239, 19);
            this.ReconsiderationUnitName1.TabIndex = 41;
            // 
            // BankID
            // 
            this.BankID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BankID.BackColor = System.Drawing.Color.White;
            this.BankID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankID.ControlText = "";
            this.BankID.Location = new System.Drawing.Point(85, 800);
            this.BankID.Name = "BankID";
            this.BankID.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankID.PopupOffset = new System.Drawing.Point(12, 0);
            this.BankID.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BankID.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BankID.PopupWidth = 300;
            this.BankID.Size = new System.Drawing.Size(283, 19);
            this.BankID.TabIndex = 37;
            // 
            // BankName
            // 
            this.BankName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BankName.BackColor = System.Drawing.Color.White;
            this.BankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankName.ControlText = "";
            this.BankName.Location = new System.Drawing.Point(416, 756);
            this.BankName.Name = "BankName";
            this.BankName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankName.PopupOffset = new System.Drawing.Point(12, 0);
            this.BankName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BankName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BankName.PopupWidth = 300;
            this.BankName.Size = new System.Drawing.Size(252, 19);
            this.BankName.TabIndex = 35;
            // 
            // PunishmentMoney
            // 
            this.PunishmentMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PunishmentMoney.BackColor = System.Drawing.Color.White;
            this.PunishmentMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishmentMoney.ControlText = "0";
            this.PunishmentMoney.Location = new System.Drawing.Point(524, 707);
            this.PunishmentMoney.Name = "PunishmentMoney";
            this.PunishmentMoney.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PunishmentMoney.PopupOffset = new System.Drawing.Point(12, 0);
            this.PunishmentMoney.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PunishmentMoney.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PunishmentMoney.PopupWidth = 300;
            this.PunishmentMoney.Size = new System.Drawing.Size(127, 19);
            this.PunishmentMoney.TabIndex = 32;
            this.PunishmentMoney.Text = "0";
            // 
            // According
            // 
            this.According.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.According.BackColor = System.Drawing.Color.White;
            this.According.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.According.ControlText = "";
            this.According.Location = new System.Drawing.Point(73, 663);
            this.According.Name = "According";
            this.According.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.According.PopupOffset = new System.Drawing.Point(12, 0);
            this.According.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.According.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.According.PopupWidth = 300;
            this.According.Size = new System.Drawing.Size(544, 19);
            this.According.TabIndex = 27;
            // 
            // IllegalProvisions
            // 
            this.IllegalProvisions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IllegalProvisions.BackColor = System.Drawing.Color.White;
            this.IllegalProvisions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalProvisions.ControlText = "";
            this.IllegalProvisions.Location = new System.Drawing.Point(153, 621);
            this.IllegalProvisions.Name = "IllegalProvisions";
            this.IllegalProvisions.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalProvisions.PopupOffset = new System.Drawing.Point(12, 0);
            this.IllegalProvisions.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.IllegalProvisions.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.IllegalProvisions.PopupWidth = 300;
            this.IllegalProvisions.Size = new System.Drawing.Size(464, 19);
            this.IllegalProvisions.TabIndex = 24;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(36, 621);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 16);
            this.label24.TabIndex = 23;
            this.label24.Text = "以上事实违反了";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 756);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(376, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "处以罚款的，罚款自收到本决定书之日起15日内缴至";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 707);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "决定给予：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "依据";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 663);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "的规定，";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "的规定，";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 888);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 16);
            this.label25.TabIndex = 44;
            this.label25.Text = "或者";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 843);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(312, 16);
            this.label21.TabIndex = 39;
            this.label21.Text = "如果不服本处罚决定，可以依法在60日内向";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(374, 803);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(312, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "，到期不缴每日按罚款数额的3%加处罚款。";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(39, 930);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(632, 16);
            this.label28.TabIndex = 4;
            this.label28.Text = "人民法院提起行政诉讼，但本决定不停止执行，法律另有规定的除外。逾期不申请行政复";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(238, 888);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(280, 16);
            this.label27.TabIndex = 46;
            this.label27.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(602, 844);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = "人民政府";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 800);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "账号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 138;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPunishmentDecisionPersonal
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmPunishmentDecisionPersonal";
            this.Size = new System.Drawing.Size(819, 1198);
            this.Load += new System.EventHandler(this.frmPunishmentDecisionPersonal_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeoplePosition;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleCompanyName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleCompanyAddress;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleAddress;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeoplePhone;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleAge;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleSex;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox IllegalEvidence;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker FillDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableAutoCompleteTextBox PunishmentAmount;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableAutoCompleteTextBox LitigationUnitName;
        private EnforceUI.TableAutoCompleteTextBox ReconsiderationUnitName2;
        private EnforceUI.TableAutoCompleteTextBox ReconsiderationUnitName1;
        private EnforceUI.TableAutoCompleteTextBox BankID;
        private EnforceUI.TableAutoCompleteTextBox BankName;
        private EnforceUI.TableAutoCompleteTextBox PunishmentMoney;
        private EnforceUI.TableAutoCompleteTextBox According;
        private EnforceUI.TableAutoCompleteTextBox IllegalProvisions;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableAutoCompleteTextBox FieldEPeopleZip;
        private System.Windows.Forms.Button button1;
    }
}

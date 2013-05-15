namespace EnforceForm
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PermitValid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BusinessMode = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.BusinessScope = new EnforceUI.TableRichTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.WarehousAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDCard = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mobile = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Tel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.JuridicalPersonJob = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.CompanyPost = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CompanyAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JuridicalPersonAge = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.JuridicalPersonSex = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.JuridicalPerson = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.panelContent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(900, 731);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 806);
            this.panel1.Size = new System.Drawing.Size(900, 44);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(900, 75);
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Visible = false;
            // 
            // btnLaw
            // 
            this.btnLaw.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.PermitValid);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.BusinessMode);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.BusinessScope);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.WarehousAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(24, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(750, 289);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // PermitValid
            // 
            this.PermitValid.Location = new System.Drawing.Point(132, 228);
            this.PermitValid.Name = "PermitValid";
            this.PermitValid.Size = new System.Drawing.Size(340, 26);
            this.PermitValid.TabIndex = 153;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 152;
            this.label15.Text = "有效期：";
            // 
            // BusinessMode
            // 
            this.BusinessMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BusinessMode.BackColor = System.Drawing.Color.White;
            this.BusinessMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusinessMode.ControlText = "";
            this.BusinessMode.Location = new System.Drawing.Point(132, 40);
            this.BusinessMode.Name = "BusinessMode";
            this.BusinessMode.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusinessMode.PopupOffset = new System.Drawing.Point(12, 0);
            this.BusinessMode.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BusinessMode.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BusinessMode.PopupWidth = 300;
            this.BusinessMode.Size = new System.Drawing.Size(585, 19);
            this.BusinessMode.TabIndex = 151;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 150;
            this.label14.Text = "经营方式：";
            // 
            // BusinessScope
            // 
            this.BusinessScope.ControlText = "";
            this.BusinessScope.Location = new System.Drawing.Point(132, 120);
            this.BusinessScope.Name = "BusinessScope";
            this.BusinessScope.Size = new System.Drawing.Size(585, 89);
            this.BusinessScope.TabIndex = 147;
            this.BusinessScope.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "许可范围：";
            // 
            // WarehousAddress
            // 
            this.WarehousAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WarehousAddress.BackColor = System.Drawing.Color.White;
            this.WarehousAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehousAddress.ControlText = "";
            this.WarehousAddress.Location = new System.Drawing.Point(132, 71);
            this.WarehousAddress.Name = "WarehousAddress";
            this.WarehousAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehousAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.WarehousAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.WarehousAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WarehousAddress.PopupWidth = 300;
            this.WarehousAddress.Size = new System.Drawing.Size(585, 19);
            this.WarehousAddress.TabIndex = 145;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 144;
            this.label10.Text = "仓储地址：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtIDCard);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Mobile);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.JuridicalPersonJob);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CompanyPost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CompanyAddress);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.JuridicalPersonAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.JuridicalPersonSex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.JuridicalPerson);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(750, 260);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(309, 180);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 24);
            this.comboBox3.TabIndex = 160;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 159;
            this.label11.Text = "区域：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 24);
            this.comboBox2.TabIndex = 158;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 157;
            this.label16.Text = "市级：";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDCard.BackColor = System.Drawing.Color.White;
            this.txtIDCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCard.ControlText = "";
            this.txtIDCard.Location = new System.Drawing.Point(534, 62);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCard.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtIDCard.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtIDCard.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDCard.PopupWidth = 300;
            this.txtIDCard.Size = new System.Drawing.Size(183, 19);
            this.txtIDCard.TabIndex = 156;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 155;
            this.label12.Text = "身份证：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 24);
            this.comboBox1.TabIndex = 148;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Mobile
            // 
            this.Mobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mobile.BackColor = System.Drawing.Color.White;
            this.Mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobile.ControlText = "";
            this.Mobile.Location = new System.Drawing.Point(584, 102);
            this.Mobile.Name = "Mobile";
            this.Mobile.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobile.PopupOffset = new System.Drawing.Point(12, 0);
            this.Mobile.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Mobile.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mobile.PopupWidth = 300;
            this.Mobile.Size = new System.Drawing.Size(133, 19);
            this.Mobile.TabIndex = 147;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 146;
            this.label7.Text = "手机：";
            // 
            // Tel
            // 
            this.Tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.ControlText = "";
            this.Tel.Location = new System.Drawing.Point(360, 102);
            this.Tel.Name = "Tel";
            this.Tel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.PopupOffset = new System.Drawing.Point(12, 0);
            this.Tel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Tel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tel.PopupWidth = 300;
            this.Tel.Size = new System.Drawing.Size(146, 19);
            this.Tel.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 144;
            this.label8.Text = "电话：";
            // 
            // JuridicalPersonJob
            // 
            this.JuridicalPersonJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalPersonJob.BackColor = System.Drawing.Color.White;
            this.JuridicalPersonJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonJob.ControlText = "";
            this.JuridicalPersonJob.Location = new System.Drawing.Point(132, 102);
            this.JuridicalPersonJob.Name = "JuridicalPersonJob";
            this.JuridicalPersonJob.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonJob.PopupOffset = new System.Drawing.Point(12, 0);
            this.JuridicalPersonJob.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.JuridicalPersonJob.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.JuridicalPersonJob.PopupWidth = 300;
            this.JuridicalPersonJob.Size = new System.Drawing.Size(162, 19);
            this.JuridicalPersonJob.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 142;
            this.label9.Text = "法人职务：";
            // 
            // CompanyPost
            // 
            this.CompanyPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyPost.BackColor = System.Drawing.Color.White;
            this.CompanyPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyPost.ControlText = "";
            this.CompanyPost.Location = new System.Drawing.Point(584, 142);
            this.CompanyPost.Name = "CompanyPost";
            this.CompanyPost.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyPost.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyPost.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyPost.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyPost.PopupWidth = 300;
            this.CompanyPost.Size = new System.Drawing.Size(133, 19);
            this.CompanyPost.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 140;
            this.label5.Text = "邮编：";
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyAddress.BackColor = System.Drawing.Color.White;
            this.CompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyAddress.ControlText = "";
            this.CompanyAddress.Location = new System.Drawing.Point(132, 142);
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyAddress.PopupWidth = 300;
            this.CompanyAddress.Size = new System.Drawing.Size(374, 19);
            this.CompanyAddress.TabIndex = 139;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(70, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 16);
            this.label29.TabIndex = 138;
            this.label29.Text = "类型：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "地址：";
            // 
            // JuridicalPersonAge
            // 
            this.JuridicalPersonAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalPersonAge.BackColor = System.Drawing.Color.White;
            this.JuridicalPersonAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonAge.ControlText = "";
            this.JuridicalPersonAge.Location = new System.Drawing.Point(553, 218);
            this.JuridicalPersonAge.Name = "JuridicalPersonAge";
            this.JuridicalPersonAge.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonAge.PopupOffset = new System.Drawing.Point(12, 0);
            this.JuridicalPersonAge.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.JuridicalPersonAge.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.JuridicalPersonAge.PopupWidth = 300;
            this.JuridicalPersonAge.Size = new System.Drawing.Size(133, 19);
            this.JuridicalPersonAge.TabIndex = 137;
            this.JuridicalPersonAge.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 136;
            this.label3.Text = "年龄：";
            this.label3.Visible = false;
            // 
            // JuridicalPersonSex
            // 
            this.JuridicalPersonSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalPersonSex.BackColor = System.Drawing.Color.White;
            this.JuridicalPersonSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonSex.ControlText = "";
            this.JuridicalPersonSex.Location = new System.Drawing.Point(360, 62);
            this.JuridicalPersonSex.Name = "JuridicalPersonSex";
            this.JuridicalPersonSex.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPersonSex.PopupOffset = new System.Drawing.Point(12, 0);
            this.JuridicalPersonSex.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.JuridicalPersonSex.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.JuridicalPersonSex.PopupWidth = 300;
            this.JuridicalPersonSex.Size = new System.Drawing.Size(83, 19);
            this.JuridicalPersonSex.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "性别：";
            // 
            // JuridicalPerson
            // 
            this.JuridicalPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalPerson.BackColor = System.Drawing.Color.White;
            this.JuridicalPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPerson.ControlText = "";
            this.JuridicalPerson.Location = new System.Drawing.Point(132, 62);
            this.JuridicalPerson.Name = "JuridicalPerson";
            this.JuridicalPerson.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalPerson.PopupOffset = new System.Drawing.Point(12, 0);
            this.JuridicalPerson.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.JuridicalPerson.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.JuridicalPerson.PopupWidth = 300;
            this.JuridicalPerson.Size = new System.Drawing.Size(162, 19);
            this.JuridicalPerson.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "法定代表人：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(132, 27);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(585, 19);
            this.CompanyName.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "企业名称：";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(24, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 121;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(332, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(89, 20);
            this.headerLabel1.TabIndex = 120;
            this.headerLabel1.Text = "企业信息";
            // 
            // frmCompany
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(900, 850);
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox BusinessMode;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableRichTextBox BusinessScope;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox WarehousAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableAutoCompleteTextBox Mobile;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox Tel;
        private System.Windows.Forms.Label label8;
        private EnforceUI.TableAutoCompleteTextBox JuridicalPersonJob;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox CompanyPost;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableAutoCompleteTextBox CompanyAddress;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox JuridicalPersonSex;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox JuridicalPerson;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox PermitValid;
        private EnforceUI.TableAutoCompleteTextBox txtIDCard;
        private System.Windows.Forms.Label label12;
        private EnforceUI.TableAutoCompleteTextBox JuridicalPersonAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;

    }
}

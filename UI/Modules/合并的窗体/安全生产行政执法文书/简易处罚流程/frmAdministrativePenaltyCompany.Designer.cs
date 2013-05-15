namespace EnforceForm
{
    partial class frmAdministrativePenaltyCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrativePenaltyCompany));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CompanyAddress = new EnforceUI.TableTextBox(this.components);
            this.CompanyPost = new EnforceUI.TableTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.JuridicalTel = new EnforceUI.TableTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.JuridicalJob = new EnforceUI.TableTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.JuridicalName = new EnforceUI.TableTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Proof = new EnforceUI.TableRichTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.Deregulation = new EnforceUI.TableTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LegalRule = new EnforceUI.TableTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.AdministrativePenalty = new EnforceUI.TableTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PaymentAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.PaymentAccount = new EnforceUI.TableTextBox(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CourtArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.ManageArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.GovArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.OfficerName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.OfficerName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.PromptCash = new EnforceUI.TableCheckBox(this.components);
            this.TimeQuantumCash = new EnforceUI.TableCheckBox(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.btnSelect);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.TimeQuantumCash);
            this.panelContent.Controls.Add(this.PromptCash);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.OfficerName2);
            this.panelContent.Controls.Add(this.label29);
            this.panelContent.Controls.Add(this.OfficerName1);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.label27);
            this.panelContent.Controls.Add(this.label22);
            this.panelContent.Controls.Add(this.label23);
            this.panelContent.Controls.Add(this.CourtArea);
            this.panelContent.Controls.Add(this.label24);
            this.panelContent.Controls.Add(this.ManageArea);
            this.panelContent.Controls.Add(this.label25);
            this.panelContent.Controls.Add(this.GovArea);
            this.panelContent.Controls.Add(this.label26);
            this.panelContent.Controls.Add(this.label21);
            this.panelContent.Controls.Add(this.label20);
            this.panelContent.Controls.Add(this.PaymentAccount);
            this.panelContent.Controls.Add(this.label19);
            this.panelContent.Controls.Add(this.PaymentAddress);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.label17);
            this.panelContent.Controls.Add(this.AdministrativePenalty);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.LegalRule);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.Deregulation);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.JuridicalTel);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.JuridicalJob);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.JuridicalName);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.CompanyPost);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.CompanyAddress);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(837, 850);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 925);
            this.panel1.Size = new System.Drawing.Size(837, 35);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(837, 75);
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
            this.headerLabel2.Location = new System.Drawing.Point(319, 109);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "行政处罚决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(43, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 45;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(289, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(163, 184);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(244, 19);
            this.CompanyName.TabIndex = 4;
            this.CompanyName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.CompanyName_SelectedValueChangedEvent);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "被处罚单位：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "地  址：";
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyAddress.BackColor = System.Drawing.Color.White;
            this.CompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyAddress.ControlText = "";
            this.CompanyAddress.Location = new System.Drawing.Point(131, 222);
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.Size = new System.Drawing.Size(305, 19);
            this.CompanyAddress.TabIndex = 6;
            // 
            // CompanyPost
            // 
            this.CompanyPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyPost.BackColor = System.Drawing.Color.White;
            this.CompanyPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyPost.ControlText = "";
            this.CompanyPost.Location = new System.Drawing.Point(518, 222);
            this.CompanyPost.Name = "CompanyPost";
            this.CompanyPost.Size = new System.Drawing.Size(225, 19);
            this.CompanyPost.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "邮编：";
            // 
            // JuridicalTel
            // 
            this.JuridicalTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalTel.BackColor = System.Drawing.Color.White;
            this.JuridicalTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalTel.ControlText = "";
            this.JuridicalTel.Location = new System.Drawing.Point(610, 258);
            this.JuridicalTel.Name = "JuridicalTel";
            this.JuridicalTel.Size = new System.Drawing.Size(128, 19);
            this.JuridicalTel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "联系电话:";
            // 
            // JuridicalJob
            // 
            this.JuridicalJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalJob.BackColor = System.Drawing.Color.White;
            this.JuridicalJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalJob.ControlText = "";
            this.JuridicalJob.Location = new System.Drawing.Point(416, 261);
            this.JuridicalJob.Name = "JuridicalJob";
            this.JuridicalJob.Size = new System.Drawing.Size(100, 19);
            this.JuridicalJob.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "职务:";
            // 
            // JuridicalName
            // 
            this.JuridicalName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JuridicalName.BackColor = System.Drawing.Color.White;
            this.JuridicalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JuridicalName.ControlText = "";
            this.JuridicalName.Location = new System.Drawing.Point(233, 261);
            this.JuridicalName.Name = "JuridicalName";
            this.JuridicalName.Size = new System.Drawing.Size(125, 19);
            this.JuridicalName.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "法定代表人（负责人）:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Proof);
            this.groupBox1.Location = new System.Drawing.Point(56, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "违法事实及证据";
            // 
            // Proof
            // 
            this.Proof.ControlText = "";
            this.Proof.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Proof.Location = new System.Drawing.Point(3, 22);
            this.Proof.Name = "Proof";
            this.Proof.Size = new System.Drawing.Size(681, 125);
            this.Proof.TabIndex = 0;
            this.Proof.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "以上事实违反了";
            // 
            // Deregulation
            // 
            this.Deregulation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Deregulation.BackColor = System.Drawing.Color.White;
            this.Deregulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Deregulation.ControlText = "";
            this.Deregulation.Location = new System.Drawing.Point(233, 445);
            this.Deregulation.Name = "Deregulation";
            this.Deregulation.Size = new System.Drawing.Size(329, 19);
            this.Deregulation.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(659, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "的规定，依";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "据";
            // 
            // LegalRule
            // 
            this.LegalRule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LegalRule.BackColor = System.Drawing.Color.White;
            this.LegalRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LegalRule.ControlText = "";
            this.LegalRule.Location = new System.Drawing.Point(86, 480);
            this.LegalRule.Name = "LegalRule";
            this.LegalRule.Size = new System.Drawing.Size(519, 19);
            this.LegalRule.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(611, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "的规定，决定给予";
            // 
            // AdministrativePenalty
            // 
            this.AdministrativePenalty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdministrativePenalty.BackColor = System.Drawing.Color.White;
            this.AdministrativePenalty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdministrativePenalty.ControlText = "";
            this.AdministrativePenalty.Location = new System.Drawing.Point(59, 514);
            this.AdministrativePenalty.Name = "AdministrativePenalty";
            this.AdministrativePenalty.Size = new System.Drawing.Size(237, 19);
            this.AdministrativePenalty.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(302, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "的行政处罚。";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(56, 546);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(280, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "罚款的履行方式和期限（见打√处）：";
            // 
            // PaymentAddress
            // 
            this.PaymentAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentAddress.BackColor = System.Drawing.Color.White;
            this.PaymentAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentAddress.ControlText = "";
            this.PaymentAddress.Location = new System.Drawing.Point(387, 606);
            this.PaymentAddress.Name = "PaymentAddress";
            this.PaymentAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PaymentAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PaymentAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PaymentAddress.PopupWidth = 300;
            this.PaymentAddress.Size = new System.Drawing.Size(111, 19);
            this.PaymentAddress.TabIndex = 27;
            this.PaymentAddress.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.PaymentAddress_SelectedValueChangedEvent);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(515, 606);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "，账号";
            // 
            // PaymentAccount
            // 
            this.PaymentAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentAccount.BackColor = System.Drawing.Color.White;
            this.PaymentAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentAccount.ControlText = "";
            this.PaymentAccount.Location = new System.Drawing.Point(577, 606);
            this.PaymentAccount.Name = "PaymentAccount";
            this.PaymentAccount.Size = new System.Drawing.Size(134, 19);
            this.PaymentAccount.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(717, 606);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "，到";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 638);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(280, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "期不缴每日按罚款数额的3%加处罚款。";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(568, 707);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(184, 16);
            this.label22.TabIndex = 38;
            this.label22.Text = "人民法院提起行政诉讼，";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(53, 741);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(696, 16);
            this.label23.TabIndex = 39;
            this.label23.Text = "但本决定不停止执行，法律另有规定的除外。逾期不申请行政复议、不提起行政诉讼又不履行的，";
            // 
            // CourtArea
            // 
            this.CourtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CourtArea.BackColor = System.Drawing.Color.White;
            this.CourtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.ControlText = "";
            this.CourtArea.Location = new System.Drawing.Point(345, 704);
            this.CourtArea.Name = "CourtArea";
            this.CourtArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.CourtArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CourtArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CourtArea.PopupWidth = 300;
            this.CourtArea.Size = new System.Drawing.Size(217, 19);
            this.CourtArea.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(56, 707);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(280, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // ManageArea
            // 
            this.ManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageArea.BackColor = System.Drawing.Color.White;
            this.ManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.ControlText = "";
            this.ManageArea.Location = new System.Drawing.Point(592, 669);
            this.ManageArea.Name = "ManageArea";
            this.ManageArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.ManageArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ManageArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageArea.PopupWidth = 300;
            this.ManageArea.Size = new System.Drawing.Size(188, 19);
            this.ManageArea.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(486, 669);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 16);
            this.label25.TabIndex = 34;
            this.label25.Text = "人民政府或者";
            // 
            // GovArea
            // 
            this.GovArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GovArea.BackColor = System.Drawing.Color.White;
            this.GovArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.ControlText = "";
            this.GovArea.Location = new System.Drawing.Point(387, 669);
            this.GovArea.Name = "GovArea";
            this.GovArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.GovArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.GovArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GovArea.PopupWidth = 300;
            this.GovArea.Size = new System.Drawing.Size(93, 19);
            this.GovArea.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(99, 672);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(280, 16);
            this.label26.TabIndex = 32;
            this.label26.Text = "如果不服本决定，可以依法在60日内向";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(53, 770);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(472, 16);
            this.label27.TabIndex = 40;
            this.label27.Text = "本机关将依法申请人民法院强制执行或者依照有关规定强制执行。";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(99, 802);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(248, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "安全生产监管执法人员（签名）：";
            // 
            // OfficerName1
            // 
            this.OfficerName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName1.BackColor = System.Drawing.Color.White;
            this.OfficerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.ControlText = "";
            this.OfficerName1.Location = new System.Drawing.Point(345, 802);
            this.OfficerName1.Name = "OfficerName1";
            this.OfficerName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName1.PopupWidth = 300;
            this.OfficerName1.Size = new System.Drawing.Size(112, 19);
            this.OfficerName1.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(463, 802);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 16);
            this.label29.TabIndex = 46;
            this.label29.Text = " 、";
            // 
            // OfficerName2
            // 
            this.OfficerName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OfficerName2.BackColor = System.Drawing.Color.White;
            this.OfficerName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.ControlText = "";
            this.OfficerName2.Location = new System.Drawing.Point(501, 802);
            this.OfficerName2.Name = "OfficerName2";
            this.OfficerName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficerName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.OfficerName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OfficerName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OfficerName2.PopupWidth = 300;
            this.OfficerName2.Size = new System.Drawing.Size(112, 19);
            this.OfficerName2.TabIndex = 43;
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管罚当〔2012〕1号";
            this.DocTitle.Location = new System.Drawing.Point(204, 132);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管罚当〔2012〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PromptCash
            // 
            this.PromptCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PromptCash.AutoSize = true;
            this.PromptCash.ControlText = "False";
            this.PromptCash.Location = new System.Drawing.Point(102, 575);
            this.PromptCash.Name = "PromptCash";
            this.PromptCash.Size = new System.Drawing.Size(91, 20);
            this.PromptCash.TabIndex = 25;
            this.PromptCash.Text = "当场缴纳";
            this.PromptCash.UseVisualStyleBackColor = true;
            // 
            // TimeQuantumCash
            // 
            this.TimeQuantumCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeQuantumCash.AutoSize = true;
            this.TimeQuantumCash.ControlText = "False";
            this.TimeQuantumCash.Location = new System.Drawing.Point(102, 606);
            this.TimeQuantumCash.Name = "TimeQuantumCash";
            this.TimeQuantumCash.Size = new System.Drawing.Size(267, 20);
            this.TimeQuantumCash.TabIndex = 26;
            this.TimeQuantumCash.Text = "自收到本决定书之日起15日内缴至";
            this.TimeQuantumCash.UseVisualStyleBackColor = true;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(427, 844);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 44;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(578, 880);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(143, 26);
            this.DocDate.TabIndex = 45;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(570, 441);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 23);
            this.btnSelect.TabIndex = 126;
            this.btnSelect.Text = "查询法律";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdministrativePenaltyCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmAdministrativePenaltyCompany";
            this.Size = new System.Drawing.Size(837, 960);
            this.Load += new System.EventHandler(this.frmAdministrativePenaltyCompany_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableTextBox CompanyPost;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableTextBox CompanyAddress;
        private System.Windows.Forms.Label label8;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableTextBox JuridicalTel;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableTextBox JuridicalJob;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableTextBox JuridicalName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox Proof;
        private EnforceUI.TableTextBox LegalRule;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableTextBox Deregulation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private EnforceUI.TableTextBox AdministrativePenalty;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private EnforceUI.TableTextBox PaymentAccount;
        private System.Windows.Forms.Label label19;
        private EnforceUI.TableAutoCompleteTextBox PaymentAddress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private EnforceUI.TableAutoCompleteTextBox CourtArea;
        private System.Windows.Forms.Label label24;
        private EnforceUI.TableAutoCompleteTextBox ManageArea;
        private System.Windows.Forms.Label label25;
        private EnforceUI.TableAutoCompleteTextBox GovArea;
        private System.Windows.Forms.Label label26;
        private EnforceUI.TableAutoCompleteTextBox OfficerName2;
        private System.Windows.Forms.Label label29;
        private EnforceUI.TableAutoCompleteTextBox OfficerName1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableCheckBox TimeQuantumCash;
        private EnforceUI.TableCheckBox PromptCash;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker DocDate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button1;
    }
}

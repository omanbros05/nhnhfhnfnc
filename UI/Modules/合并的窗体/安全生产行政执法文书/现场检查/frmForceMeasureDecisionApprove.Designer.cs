namespace EnforceForm
{
    partial class frmForceMeasureDecisionApprove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForceMeasureDecisionApprove));
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.Party = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PartyAddress = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Tel = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LegalRepre = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Matter = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Accord = new EnforceUI.TableRichTextBox(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Supervise = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.SuperviseDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Undertake = new EnforceUI.TableRichTextBox(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.Principal = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PrincipalDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.Tel);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.LegalRepre);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.PartyAddress);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.Party);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Size = new System.Drawing.Size(845, 799);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 874);
            this.panel1.Size = new System.Drawing.Size(845, 45);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(845, 75);
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // btnLaw
            // 
            this.btnLaw.Click += new System.EventHandler(this.btnLaw_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "当事人：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(269, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(189, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "强制措施决定审批表";
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
            this.tableLine1.TabIndex = 7;
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
            // Party
            // 
            this.Party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Party.BackColor = System.Drawing.Color.White;
            this.Party.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.ControlText = "";
            this.Party.Location = new System.Drawing.Point(89, 151);
            this.Party.Name = "Party";
            this.Party.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party.PopupOffset = new System.Drawing.Point(12, 0);
            this.Party.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Party.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Party.PopupWidth = 300;
            this.Party.Size = new System.Drawing.Size(244, 19);
            this.Party.TabIndex = 3;
            this.Party.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.Party_SelectedValueChangedEvent);
            // 
            // PartyAddress
            // 
            this.PartyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PartyAddress.BackColor = System.Drawing.Color.White;
            this.PartyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartyAddress.ControlText = "";
            this.PartyAddress.Location = new System.Drawing.Point(400, 151);
            this.PartyAddress.Name = "PartyAddress";
            this.PartyAddress.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartyAddress.PopupOffset = new System.Drawing.Point(12, 0);
            this.PartyAddress.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PartyAddress.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PartyAddress.PopupWidth = 300;
            this.PartyAddress.Size = new System.Drawing.Size(313, 19);
            this.PartyAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "地址：";
            // 
            // Tel
            // 
            this.Tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.ControlText = "";
            this.Tel.Location = new System.Drawing.Point(490, 186);
            this.Tel.Name = "Tel";
            this.Tel.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.PopupOffset = new System.Drawing.Point(12, 0);
            this.Tel.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Tel.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tel.PopupWidth = 300;
            this.Tel.Size = new System.Drawing.Size(223, 19);
            this.Tel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "联系电话：";
            // 
            // LegalRepre
            // 
            this.LegalRepre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LegalRepre.BackColor = System.Drawing.Color.White;
            this.LegalRepre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LegalRepre.ControlText = "";
            this.LegalRepre.Location = new System.Drawing.Point(233, 186);
            this.LegalRepre.Name = "LegalRepre";
            this.LegalRepre.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LegalRepre.PopupOffset = new System.Drawing.Point(12, 0);
            this.LegalRepre.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LegalRepre.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LegalRepre.PopupWidth = 300;
            this.LegalRepre.Size = new System.Drawing.Size(145, 19);
            this.LegalRepre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "法定代表人（主要负责人）：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Matter);
            this.groupBox1.Location = new System.Drawing.Point(13, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 208);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存在主要问题";
            // 
            // Matter
            // 
            this.Matter.ControlText = "";
            this.Matter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Matter.Location = new System.Drawing.Point(3, 22);
            this.Matter.Name = "Matter";
            this.Matter.Size = new System.Drawing.Size(694, 183);
            this.Matter.TabIndex = 0;
            this.Matter.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.Accord);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(13, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 208);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "建议措施及依据";
            // 
            // Accord
            // 
            this.Accord.ControlText = "";
            this.Accord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accord.Location = new System.Drawing.Point(3, 22);
            this.Accord.Name = "Accord";
            this.Accord.Size = new System.Drawing.Size(694, 146);
            this.Accord.TabIndex = 0;
            this.Accord.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Supervise);
            this.panel3.Controls.Add(this.SuperviseDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 37);
            this.panel3.TabIndex = 1;
            // 
            // Supervise
            // 
            this.Supervise.BackColor = System.Drawing.Color.White;
            this.Supervise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supervise.ControlText = "";
            this.Supervise.Location = new System.Drawing.Point(342, 10);
            this.Supervise.Name = "Supervise";
            this.Supervise.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supervise.PopupOffset = new System.Drawing.Point(12, 0);
            this.Supervise.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Supervise.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Supervise.PopupWidth = 300;
            this.Supervise.Size = new System.Drawing.Size(186, 19);
            this.Supervise.TabIndex = 1;
            // 
            // SuperviseDate
            // 
            this.SuperviseDate.CustomFormat = "yyyy年M月d日";
            this.SuperviseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SuperviseDate.Location = new System.Drawing.Point(534, 7);
            this.SuperviseDate.Name = "SuperviseDate";
            this.SuperviseDate.Size = new System.Drawing.Size(157, 26);
            this.SuperviseDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "监督检查人员：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.Undertake);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Location = new System.Drawing.Point(13, 651);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 176);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "承办机构意见";
            // 
            // Undertake
            // 
            this.Undertake.ControlText = "";
            this.Undertake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Undertake.Location = new System.Drawing.Point(3, 22);
            this.Undertake.Name = "Undertake";
            this.Undertake.Size = new System.Drawing.Size(694, 114);
            this.Undertake.TabIndex = 0;
            this.Undertake.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Principal);
            this.panel4.Controls.Add(this.PrincipalDate);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 37);
            this.panel4.TabIndex = 1;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Principal.ControlText = "";
            this.Principal.Location = new System.Drawing.Point(322, 11);
            this.Principal.Name = "Principal";
            this.Principal.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Principal.PopupOffset = new System.Drawing.Point(12, 0);
            this.Principal.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Principal.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Principal.PopupWidth = 300;
            this.Principal.Size = new System.Drawing.Size(197, 19);
            this.Principal.TabIndex = 1;
            // 
            // PrincipalDate
            // 
            this.PrincipalDate.CustomFormat = "yyyy年M月d日";
            this.PrincipalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PrincipalDate.Location = new System.Drawing.Point(525, 6);
            this.PrincipalDate.Name = "PrincipalDate";
            this.PrincipalDate.Size = new System.Drawing.Size(166, 26);
            this.PrincipalDate.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "负责人：";
            // 
            // frmForceMeasureDecisionApprove
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmForceMeasureDecisionApprove";
            this.Size = new System.Drawing.Size(845, 919);
            this.Load += new System.EventHandler(this.frmForceMeasureDecisionApprove_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox Tel;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox LegalRepre;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox PartyAddress;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox Party;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox Matter;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox Accord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox Undertake;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableDateTimePicker PrincipalDate;
        private EnforceUI.TableDateTimePicker SuperviseDate;
        private EnforceUI.TableAutoCompleteTextBox Principal;
        private EnforceUI.TableAutoCompleteTextBox Supervise;
    }
}

namespace EnforceForm
{
    partial class frmForceMeasureDecision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForceMeasureDecision));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Matter = new EnforceUI.TableRichTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Accord = new EnforceUI.TableTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.EnforceMea = new EnforceUI.TableRichTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.CourtArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.ManageArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.GovArea = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.DocDate = new EnforceUI.TableDateTimePicker(this.components);
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
            this.panelContent.Controls.Add(this.DocDate);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label15);
            this.panelContent.Controls.Add(this.CourtArea);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.ManageArea);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.GovArea);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.EnforceMea);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.Accord);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.Matter);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(793, 831);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 906);
            this.panel1.Size = new System.Drawing.Size(793, 48);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(793, 75);
            this.header1.Title = "强制措施决定书 > 编辑";
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
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(272, 122);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(149, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "强制措施决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-4, 115);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 10;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(242, 92);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(18, 183);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(283, 19);
            this.CompanyName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "我局在现场检查时，发现你单位（现场）存在下列问题：";
            // 
            // Matter
            // 
            this.Matter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Matter.ControlText = "";
            this.Matter.Location = new System.Drawing.Point(17, 253);
            this.Matter.Name = "Matter";
            this.Matter.Size = new System.Drawing.Size(700, 234);
            this.Matter.TabIndex = 6;
            this.Matter.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "以上存在的问题无法保障安全生产，依据";
            // 
            // Accord
            // 
            this.Accord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Accord.BackColor = System.Drawing.Color.White;
            this.Accord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Accord.ControlText = "";
            this.Accord.Location = new System.Drawing.Point(17, 523);
            this.Accord.Name = "Accord";
            this.Accord.Size = new System.Drawing.Size(608, 19);
            this.Accord.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "决定采取以下强制措施：";
            // 
            // EnforceMea
            // 
            this.EnforceMea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnforceMea.ControlText = "";
            this.EnforceMea.Location = new System.Drawing.Point(17, 579);
            this.EnforceMea.Name = "EnforceMea";
            this.EnforceMea.Size = new System.Drawing.Size(700, 96);
            this.EnforceMea.TabIndex = 10;
            this.EnforceMea.Text = "";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 762);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(328, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "但本决定不停止执行，法律另有规定的除外。";
            // 
            // CourtArea
            // 
            this.CourtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CourtArea.BackColor = System.Drawing.Color.White;
            this.CourtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.ControlText = "";
            this.CourtArea.Location = new System.Drawing.Point(306, 716);
            this.CourtArea.Name = "CourtArea";
            this.CourtArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourtArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.CourtArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CourtArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CourtArea.PopupWidth = 300;
            this.CourtArea.Size = new System.Drawing.Size(219, 19);
            this.CourtArea.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 719);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // ManageArea
            // 
            this.ManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageArea.BackColor = System.Drawing.Color.White;
            this.ManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.ControlText = "";
            this.ManageArea.Location = new System.Drawing.Point(524, 681);
            this.ManageArea.Name = "ManageArea";
            this.ManageArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.ManageArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ManageArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageArea.PopupWidth = 300;
            this.ManageArea.Size = new System.Drawing.Size(213, 19);
            this.ManageArea.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 684);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "人民政府或者";
            // 
            // GovArea
            // 
            this.GovArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GovArea.BackColor = System.Drawing.Color.White;
            this.GovArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.ControlText = "";
            this.GovArea.Location = new System.Drawing.Point(306, 681);
            this.GovArea.Name = "GovArea";
            this.GovArea.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GovArea.PopupOffset = new System.Drawing.Point(12, 0);
            this.GovArea.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.GovArea.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GovArea.PopupWidth = 300;
            this.GovArea.Size = new System.Drawing.Size(100, 19);
            this.GovArea.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 684);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "如果不服本决定，可以依法在60日内向";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 719);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "人民法院提起行政诉讼，";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管强措〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(167, 145);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管强措〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(426, 831);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 19;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocDate
            // 
            this.DocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocDate.CustomFormat = "yyyy年M月d日";
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocDate.Location = new System.Drawing.Point(552, 869);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(144, 26);
            this.DocDate.TabIndex = 20;
            // 
            // frmForceMeasureDecision
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmForceMeasureDecision";
            this.Size = new System.Drawing.Size(793, 954);
            this.Load += new System.EventHandler(this.frmForceMeasureDecision_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableRichTextBox Matter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Label label10;
        private EnforceUI.TableTextBox Accord;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableRichTextBox EnforceMea;
        private System.Windows.Forms.Label label15;
        private EnforceUI.TableAutoCompleteTextBox CourtArea;
        private System.Windows.Forms.Label label14;
        private EnforceUI.TableAutoCompleteTextBox ManageArea;
        private System.Windows.Forms.Label label13;
        private EnforceUI.TableAutoCompleteTextBox GovArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker DocDate;
    }
}

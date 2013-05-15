namespace EnforceForm
{
    partial class frmHearingInform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHearingInform));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CompereName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.HearName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.SecretaryName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Summary = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Suggest = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PrincipalSuggest = new EnforceUI.TableRichTextBox(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.SecretaryName);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.HearName);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.CompereName);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(871, 731);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 806);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Title = "听证会报告书 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(320, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "听证会报告书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(44, 101);
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
            this.headerLabel1.Location = new System.Drawing.Point(290, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "案件名称：";
            // 
            // CompereName
            // 
            this.CompereName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompereName.BackColor = System.Drawing.Color.White;
            this.CompereName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereName.ControlText = "";
            this.CompereName.Location = new System.Drawing.Point(160, 214);
            this.CompereName.Name = "CompereName";
            this.CompereName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompereName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompereName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompereName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompereName.PopupWidth = 300;
            this.CompereName.Size = new System.Drawing.Size(113, 19);
            this.CompereName.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "听证主持人：";
            // 
            // HearName
            // 
            this.HearName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HearName.BackColor = System.Drawing.Color.White;
            this.HearName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName.ControlText = "";
            this.HearName.Location = new System.Drawing.Point(357, 211);
            this.HearName.Name = "HearName";
            this.HearName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HearName.PopupOffset = new System.Drawing.Point(12, 0);
            this.HearName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.HearName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.HearName.PopupWidth = 300;
            this.HearName.Size = new System.Drawing.Size(160, 19);
            this.HearName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "听证员：";
            // 
            // SecretaryName
            // 
            this.SecretaryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SecretaryName.BackColor = System.Drawing.Color.White;
            this.SecretaryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryName.ControlText = "";
            this.SecretaryName.Location = new System.Drawing.Point(593, 208);
            this.SecretaryName.Name = "SecretaryName";
            this.SecretaryName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretaryName.PopupOffset = new System.Drawing.Point(12, 0);
            this.SecretaryName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SecretaryName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecretaryName.PopupWidth = 300;
            this.SecretaryName.Size = new System.Drawing.Size(151, 19);
            this.SecretaryName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "书记员:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Summary);
            this.groupBox1.Location = new System.Drawing.Point(53, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 224);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "听证会基本情况摘要：（详见听证会笔录，笔录附后）";
            // 
            // Summary
            // 
            this.Summary.ControlText = "";
            this.Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Summary.Location = new System.Drawing.Point(3, 22);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(685, 199);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.Suggest);
            this.groupBox2.Location = new System.Drawing.Point(56, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 152);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "听证意见及建议";
            // 
            // Suggest
            // 
            this.Suggest.ControlText = "";
            this.Suggest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suggest.Location = new System.Drawing.Point(3, 22);
            this.Suggest.Name = "Suggest";
            this.Suggest.Size = new System.Drawing.Size(682, 127);
            this.Suggest.TabIndex = 0;
            this.Suggest.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.PrincipalSuggest);
            this.groupBox3.Location = new System.Drawing.Point(56, 651);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 152);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "负责人审核意见";
            // 
            // PrincipalSuggest
            // 
            this.PrincipalSuggest.ControlText = "";
            this.PrincipalSuggest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrincipalSuggest.Location = new System.Drawing.Point(3, 22);
            this.PrincipalSuggest.Name = "PrincipalSuggest";
            this.PrincipalSuggest.Size = new System.Drawing.Size(682, 127);
            this.PrincipalSuggest.TabIndex = 0;
            this.PrincipalSuggest.Text = "";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "()安监管听报〔〕1号";
            this.DocTitle.Location = new System.Drawing.Point(218, 134);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "()安监管听报〔〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(144, 171);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(600, 19);
            this.CaseName.TabIndex = 4;
            // 
            // frmHearingInform
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmHearingInform";
            this.Size = new System.Drawing.Size(871, 850);
            this.Load += new System.EventHandler(this.frmHearingInform_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox Summary;
        private EnforceUI.TableAutoCompleteTextBox SecretaryName;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox HearName;
        private System.Windows.Forms.Label label8;
        private EnforceUI.TableAutoCompleteTextBox CompereName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox Suggest;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox PrincipalSuggest;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
    }
}

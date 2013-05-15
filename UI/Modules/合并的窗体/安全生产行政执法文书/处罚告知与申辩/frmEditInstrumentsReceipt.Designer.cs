namespace EnforceForm
{
    partial class frmEditInstrumentsReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditInstrumentsReceipt));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableAutoCompleteTextBox1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SealReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRichTextBox1 = new EnforceUI.TableRichTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.tableRichTextBox1);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.panel3);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.tableAutoCompleteTextBox1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 679);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 754);
            this.panel1.Size = new System.Drawing.Size(886, 46);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
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
            this.headerLabel2.Location = new System.Drawing.Point(299, 109);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 106;
            this.headerLabel2.Text = "文书送达回执";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(11, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 107;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(264, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 105;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "案件名称:";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(83, 139);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(673, 19);
            this.CompanyName.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "受送达单位（个人）:";
            // 
            // tableAutoCompleteTextBox1
            // 
            this.tableAutoCompleteTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableAutoCompleteTextBox1.BackColor = System.Drawing.Color.White;
            this.tableAutoCompleteTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableAutoCompleteTextBox1.ControlText = "";
            this.tableAutoCompleteTextBox1.Location = new System.Drawing.Point(170, 175);
            this.tableAutoCompleteTextBox1.Name = "tableAutoCompleteTextBox1";
            this.tableAutoCompleteTextBox1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableAutoCompleteTextBox1.PopupOffset = new System.Drawing.Point(12, 0);
            this.tableAutoCompleteTextBox1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.tableAutoCompleteTextBox1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.tableAutoCompleteTextBox1.PopupWidth = 300;
            this.tableAutoCompleteTextBox1.Size = new System.Drawing.Size(586, 19);
            this.tableAutoCompleteTextBox1.TabIndex = 111;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(46, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 375);
            this.panel3.TabIndex = 113;
            // 
            // enforceLawGridViewSpotCheck
            // 
            this.enforceLawGridViewSpotCheck.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotCheck.AutoUpdate = false;
            this.enforceLawGridViewSpotCheck.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewSpotCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SealReason,
            this.DocTitle,
            this.FormDate});
            this.enforceLawGridViewSpotCheck.Custom = false;
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 23;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(745, 375);
            this.enforceLawGridViewSpotCheck.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "送达文书名称、文号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 240;
            // 
            // SealReason
            // 
            this.SealReason.HeaderText = "送达地点";
            this.SealReason.Name = "SealReason";
            this.SealReason.ReadOnly = true;
            this.SealReason.Width = 260;
            // 
            // DocTitle
            // 
            this.DocTitle.HeaderText = "送达方式";
            this.DocTitle.Name = "DocTitle";
            // 
            // FormDate
            // 
            this.FormDate.HeaderText = "送达人";
            this.FormDate.Name = "FormDate";
            // 
            // tableRichTextBox1
            // 
            this.tableRichTextBox1.ControlText = "";
            this.tableRichTextBox1.Location = new System.Drawing.Point(45, 621);
            this.tableRichTextBox1.Name = "tableRichTextBox1";
            this.tableRichTextBox1.Size = new System.Drawing.Size(741, 125);
            this.tableRichTextBox1.TabIndex = 115;
            this.tableRichTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "备注:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 126;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditInstrumentsReceipt
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmEditInstrumentsReceipt";
            this.Size = new System.Drawing.Size(886, 800);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableAutoCompleteTextBox tableAutoCompleteTextBox1;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Panel panel3;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSpotCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SealReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormDate;
        private EnforceUI.TableRichTextBox tableRichTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

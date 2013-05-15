namespace EnforceForm
{
    partial class frmLawQuery
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.txtName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOutPut = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.enforceLawGridViewLawFile = new EnforceUI.EnforceLawGridView(this.components);
            this.LawTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewLawFile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Visible = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panel4);
            this.panelContent.Controls.Add(this.panel5);
            this.panelContent.Controls.Add(this.panel3);
            this.panelContent.Size = new System.Drawing.Size(871, 590);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 665);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(383, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(560, 5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 30;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // txtName
            // 
            this.txtName.ControlText = "";
            this.txtName.Location = new System.Drawing.Point(52, 3);
            this.txtName.Name = "txtName";
            this.txtName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.PopupWidth = 300;
            this.txtName.Size = new System.Drawing.Size(282, 26);
            this.txtName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "类型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "标题:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonQuery);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(13, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 31);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.enforceToolStrip);
            this.panel4.Location = new System.Drawing.Point(13, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 29);
            this.panel4.TabIndex = 33;
            // 
            // enforceToolStrip
            // 
            this.enforceToolStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDel,
            this.toolStripSeparator3,
            this.toolStripButtonOutPut});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(825, 25);
            this.enforceToolStrip.TabIndex = 10;
            this.enforceToolStrip.Text = "enforceToolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::Maleos.Properties.Resources.application_add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonAdd.Text = "添加";
            this.toolStripButtonAdd.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = global::Maleos.Properties.Resources.application_edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonEdit.Text = "编辑";
            this.toolStripButtonEdit.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.Image = global::Maleos.Properties.Resources.application_delete;
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // toolStripButtonOutPut
            // 
            this.toolStripButtonOutPut.Image = global::Maleos.Properties.Resources.layout;
            this.toolStripButtonOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutPut.Name = "toolStripButtonOutPut";
            this.toolStripButtonOutPut.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonOutPut.Text = "查看";
            this.toolStripButtonOutPut.Click += new System.EventHandler(this.toolStripButtonOutPut_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.enforceLawGridViewLawFile);
            this.panel5.Location = new System.Drawing.Point(13, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(825, 381);
            this.panel5.TabIndex = 34;
            // 
            // enforceLawGridViewLawFile
            // 
            this.enforceLawGridViewLawFile.AllowUserToAddRows = false;
            this.enforceLawGridViewLawFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enforceLawGridViewLawFile.AutoUpdate = false;
            this.enforceLawGridViewLawFile.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewLawFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewLawFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewLawFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LawTitle,
            this.LawFilePath});
            this.enforceLawGridViewLawFile.Custom = false;
            this.enforceLawGridViewLawFile.EntityType = null;
            this.enforceLawGridViewLawFile.Location = new System.Drawing.Point(8, 8);
            this.enforceLawGridViewLawFile.Name = "enforceLawGridViewLawFile";
            this.enforceLawGridViewLawFile.ReadOnly = true;
            this.enforceLawGridViewLawFile.RowTemplate.Height = 23;
            this.enforceLawGridViewLawFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewLawFile.Size = new System.Drawing.Size(802, 381);
            this.enforceLawGridViewLawFile.TabIndex = 10;
            // 
            // LawTitle
            // 
            this.LawTitle.HeaderText = "标题";
            this.LawTitle.Name = "LawTitle";
            this.LawTitle.ReadOnly = true;
            this.LawTitle.Width = 380;
            // 
            // LawFilePath
            // 
            this.LawFilePath.HeaderText = "文件路径";
            this.LawFilePath.Name = "LawFilePath";
            this.LawFilePath.ReadOnly = true;
            this.LawFilePath.Width = 380;
            // 
            // frmLawQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmLawQuery";
            this.Size = new System.Drawing.Size(871, 700);
            this.Load += new System.EventHandler(this.frmLawQuery_Load);
            this.panelContent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewLawFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutPut;
        private System.Windows.Forms.Panel panel5;
        private EnforceUI.EnforceLawGridView enforceLawGridViewLawFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawFilePath;
    }
}

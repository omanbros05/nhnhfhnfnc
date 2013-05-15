namespace EnforceForm
{
    partial class frmDocumentsServiceReplys
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
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.DocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutOnRecordCaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.TxtDocTitle = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 407);
            this.pager.Size = new System.Drawing.Size(699, 33);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(699, 38);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Size = new System.Drawing.Size(699, 27);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Size = new System.Drawing.Size(699, 342);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.TxtDocTitle);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(699, 38);
            // 
            // enforceToolStrip
            // 
            this.enforceToolStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDel});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(699, 25);
            this.enforceToolStrip.TabIndex = 8;
            this.enforceToolStrip.Text = "enforceToolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::Maleos.Properties.Resources.application_add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonAdd.Text = "添加";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = global::Maleos.Properties.Resources.application_edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonEdit.Text = "编辑";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.Image = global::Maleos.Properties.Resources.application_delete;
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // enforceLawGridViewSpotCheck
            // 
            this.enforceLawGridViewSpotCheck.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotCheck.AutoUpdate = false;
            this.enforceLawGridViewSpotCheck.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewSpotCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocTitle,
            this.PutOnRecordCaseName});
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 23;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(699, 342);
            this.enforceLawGridViewSpotCheck.TabIndex = 7;
            // 
            // DocTitle
            // 
            this.DocTitle.FillWeight = 150F;
            this.DocTitle.HeaderText = "文号";
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Width = 150;
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.HeaderText = "案件名称";
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.Width = 400;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(256, 7);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 14;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // TxtDocTitle
            // 
            this.TxtDocTitle.ControlText = "";
            this.TxtDocTitle.Location = new System.Drawing.Point(75, 7);
            this.TxtDocTitle.Name = "TxtDocTitle";
            this.TxtDocTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDocTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.TxtDocTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TxtDocTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtDocTitle.PopupWidth = 300;
            this.TxtDocTitle.Size = new System.Drawing.Size(175, 23);
            this.TxtDocTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "文号:";
            // 
            // frmDocumentsServiceReplys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmDocumentsServiceReplys";
            this.Size = new System.Drawing.Size(699, 440);
            this.Load += new System.EventHandler(this.frmDocumentsServiceReplys_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSpotCheck;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox TxtDocTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutOnRecordCaseName;
    }
}

namespace EnforceForm
{
    partial class frmCompanyNoCoalSecuritys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableTextBoxCompanyName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.buttonQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewCompanyNoCoalSecuritys = new EnforceUI.EnforceLawGridView(this.components);
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuridicalPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuridicalPersonSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuridicalPersonAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuridicalPersonJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewCompanyNoCoalSecuritys)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewCompanyNoCoalSecuritys);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnImport);
            this.panel4.Controls.Add(this.tableTextBoxCompanyName);
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.label1);
            // 
            // tableTextBoxCompanyName
            // 
            this.tableTextBoxCompanyName.ControlText = "";
            this.tableTextBoxCompanyName.Location = new System.Drawing.Point(97, 4);
            this.tableTextBoxCompanyName.Name = "tableTextBoxCompanyName";
            this.tableTextBoxCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableTextBoxCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.tableTextBoxCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.tableTextBoxCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.tableTextBoxCompanyName.PopupWidth = 300;
            this.tableTextBoxCompanyName.Size = new System.Drawing.Size(190, 23);
            this.tableTextBoxCompanyName.TabIndex = 16;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(293, 4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 15;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "企业名称:";
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
            this.enforceToolStrip.Size = new System.Drawing.Size(694, 25);
            this.enforceToolStrip.TabIndex = 5;
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
            this.toolStripSeparator1.Visible = false;
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
            this.toolStripSeparator2.Visible = false;
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
            // enforceLawGridViewCompanyNoCoalSecuritys
            // 
            this.enforceLawGridViewCompanyNoCoalSecuritys.AutoUpdate = true;
            this.enforceLawGridViewCompanyNoCoalSecuritys.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewCompanyNoCoalSecuritys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewCompanyNoCoalSecuritys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewCompanyNoCoalSecuritys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.CompanyAddress,
            this.CompanyPost,
            this.JuridicalPerson,
            this.JuridicalPersonSex,
            this.JuridicalPersonAge,
            this.JuridicalPersonJob,
            this.Mobile,
            this.Tel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enforceLawGridViewCompanyNoCoalSecuritys.DefaultCellStyle = dataGridViewCellStyle2;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewCompanyNoCoalSecuritys.EntityType = null;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewCompanyNoCoalSecuritys.Name = "enforceLawGridViewCompanyNoCoalSecuritys";
            this.enforceLawGridViewCompanyNoCoalSecuritys.RowTemplate.Height = 23;
            this.enforceLawGridViewCompanyNoCoalSecuritys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Size = new System.Drawing.Size(694, 329);
            this.enforceLawGridViewCompanyNoCoalSecuritys.TabIndex = 3;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "企业名称";
            this.CompanyName.Name = "CompanyName";
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.HeaderText = "企业地址";
            this.CompanyAddress.Name = "CompanyAddress";
            // 
            // CompanyPost
            // 
            this.CompanyPost.HeaderText = "企业邮编";
            this.CompanyPost.Name = "CompanyPost";
            // 
            // JuridicalPerson
            // 
            this.JuridicalPerson.HeaderText = "法人/负责人";
            this.JuridicalPerson.Name = "JuridicalPerson";
            // 
            // JuridicalPersonSex
            // 
            this.JuridicalPersonSex.HeaderText = "法人性别";
            this.JuridicalPersonSex.Name = "JuridicalPersonSex";
            this.JuridicalPersonSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JuridicalPersonSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // JuridicalPersonAge
            // 
            this.JuridicalPersonAge.HeaderText = "法人年龄";
            this.JuridicalPersonAge.Name = "JuridicalPersonAge";
            this.JuridicalPersonAge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JuridicalPersonAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // JuridicalPersonJob
            // 
            this.JuridicalPersonJob.HeaderText = "法人职务";
            this.JuridicalPersonJob.Name = "JuridicalPersonJob";
            this.JuridicalPersonJob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JuridicalPersonJob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "联系方式(手机)";
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 120;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "联系方式(电话)";
            this.Tel.Name = "Tel";
            this.Tel.Width = 120;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(374, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 17;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmCompanyNoCoalSecuritys
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmCompanyNoCoalSecuritys";
            this.Load += new System.EventHandler(this.frmCompanyNoCoalSecuritys_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewCompanyNoCoalSecuritys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.DocumentAutoCompleteTextBox tableTextBoxCompanyName;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label label1;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewCompanyNoCoalSecuritys;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuridicalPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuridicalPersonSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuridicalPersonAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuridicalPersonJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

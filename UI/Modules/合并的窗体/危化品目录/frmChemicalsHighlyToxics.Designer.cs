namespace EnforceForm
{
    partial class frmChemicalsHighlyToxics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtAlias = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.txtName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOutPut = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewChemicalsHighlyToxic = new EnforceUI.EnforceLawGridView(this.components);
            this.ChemicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalNameEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalAliasEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewChemicalsHighlyToxic)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 667);
            this.pager.Size = new System.Drawing.Size(945, 33);
            this.pager.CurrentPageChangedEvent += new EnforceUI.Pager.CurrentPageChangedHandeler(this.pager_CurrentPageChangedEvent);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Size = new System.Drawing.Size(945, 34);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Size = new System.Drawing.Size(945, 27);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewChemicalsHighlyToxic);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Size = new System.Drawing.Size(945, 541);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnImport);
            this.panel4.Controls.Add(this.txtAlias);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(945, 34);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(418, 7);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtAlias
            // 
            this.txtAlias.ControlText = "";
            this.txtAlias.Location = new System.Drawing.Point(205, 8);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlias.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtAlias.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtAlias.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtAlias.PopupWidth = 300;
            this.txtAlias.Size = new System.Drawing.Size(112, 23);
            this.txtAlias.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "别名:";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(335, 8);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 22;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // txtName
            // 
            this.txtName.ControlText = "";
            this.txtName.Location = new System.Drawing.Point(51, 6);
            this.txtName.Name = "txtName";
            this.txtName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.PopupWidth = 300;
            this.txtName.Size = new System.Drawing.Size(104, 23);
            this.txtName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "化学名:";
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
            this.enforceToolStrip.Size = new System.Drawing.Size(945, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOutPut
            // 
            this.toolStripButtonOutPut.Image = global::Maleos.Properties.Resources.layout;
            this.toolStripButtonOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutPut.Name = "toolStripButtonOutPut";
            this.toolStripButtonOutPut.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonOutPut.Text = "导出文书";
            // 
            // enforceLawGridViewChemicalsHighlyToxic
            // 
            this.enforceLawGridViewChemicalsHighlyToxic.AllowUserToAddRows = false;
            this.enforceLawGridViewChemicalsHighlyToxic.AutoUpdate = false;
            this.enforceLawGridViewChemicalsHighlyToxic.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewChemicalsHighlyToxic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewChemicalsHighlyToxic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.enforceLawGridViewChemicalsHighlyToxic.ColumnHeadersHeight = 40;
            this.enforceLawGridViewChemicalsHighlyToxic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewChemicalsHighlyToxic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChemicalName,
            this.ChemicalAlias,
            this.ChemicalNameEn,
            this.ChemicalAliasEn,
            this.Formula,
            this.CAS,
            this.UN});
            this.enforceLawGridViewChemicalsHighlyToxic.Custom = false;
            this.enforceLawGridViewChemicalsHighlyToxic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewChemicalsHighlyToxic.EntityType = null;
            this.enforceLawGridViewChemicalsHighlyToxic.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewChemicalsHighlyToxic.Name = "enforceLawGridViewChemicalsHighlyToxic";
            this.enforceLawGridViewChemicalsHighlyToxic.ReadOnly = true;
            this.enforceLawGridViewChemicalsHighlyToxic.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceLawGridViewChemicalsHighlyToxic.RowTemplate.Height = 36;
            this.enforceLawGridViewChemicalsHighlyToxic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewChemicalsHighlyToxic.Size = new System.Drawing.Size(945, 541);
            this.enforceLawGridViewChemicalsHighlyToxic.TabIndex = 7;
            // 
            // ChemicalName
            // 
            this.ChemicalName.HeaderText = "化学名";
            this.ChemicalName.Name = "ChemicalName";
            this.ChemicalName.ReadOnly = true;
            this.ChemicalName.Width = 120;
            // 
            // ChemicalAlias
            // 
            this.ChemicalAlias.HeaderText = "别名";
            this.ChemicalAlias.Name = "ChemicalAlias";
            this.ChemicalAlias.ReadOnly = true;
            this.ChemicalAlias.Width = 120;
            // 
            // ChemicalNameEn
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.ChemicalNameEn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ChemicalNameEn.HeaderText = "化学名(英文)";
            this.ChemicalNameEn.Name = "ChemicalNameEn";
            this.ChemicalNameEn.ReadOnly = true;
            this.ChemicalNameEn.Width = 200;
            // 
            // ChemicalAliasEn
            // 
            this.ChemicalAliasEn.HeaderText = "别名(英文)";
            this.ChemicalAliasEn.Name = "ChemicalAliasEn";
            this.ChemicalAliasEn.ReadOnly = true;
            this.ChemicalAliasEn.Width = 200;
            // 
            // Formula
            // 
            this.Formula.HeaderText = "分子式";
            this.Formula.Name = "Formula";
            this.Formula.ReadOnly = true;
            this.Formula.Width = 120;
            // 
            // CAS
            // 
            this.CAS.HeaderText = "CAS号";
            this.CAS.Name = "CAS";
            this.CAS.ReadOnly = true;
            // 
            // UN
            // 
            this.UN.HeaderText = "UN号";
            this.UN.Name = "UN";
            this.UN.ReadOnly = true;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(945, 75);
            this.header1.TabIndex = 4;
            this.header1.Title = "剧毒化学品目录";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // frmChemicalsHighlyToxics
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmChemicalsHighlyToxics";
            this.Size = new System.Drawing.Size(945, 700);
            this.Load += new System.EventHandler(this.frmChemicalsHighlyToxics_Load);
            this.Controls.SetChildIndex(this.header1, 0);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pager, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewChemicalsHighlyToxic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private EnforceUI.DocumentAutoCompleteTextBox txtAlias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox txtName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutPut;
        private EnforceUI.EnforceLawGridView enforceLawGridViewChemicalsHighlyToxic;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalNameEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalAliasEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UN;
    }
}

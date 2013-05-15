namespace EnforceForm
{
    partial class frmChemicalsLists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.txtNumber = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.enforceLawGridViewChemicalsList = new EnforceUI.EnforceLawGridView(this.components);
            this.ChemicalsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalsAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalsUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewChemicalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 667);
            this.pager.Size = new System.Drawing.Size(1171, 33);
            this.pager.CurrentPageChangedEvent += new EnforceUI.Pager.CurrentPageChangedHandeler(this.pager_CurrentPageChangedEvent);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Size = new System.Drawing.Size(1171, 34);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Size = new System.Drawing.Size(1171, 27);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewChemicalsList);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Size = new System.Drawing.Size(1171, 541);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.txtNumber);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(1171, 34);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(584, 6);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 14;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.ControlText = "";
            this.txtNumber.Location = new System.Drawing.Point(43, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtNumber.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtNumber.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtNumber.PopupWidth = 300;
            this.txtNumber.Size = new System.Drawing.Size(104, 23);
            this.txtNumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "编号:";
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
            this.toolStripSeparator3});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(1171, 25);
            this.enforceToolStrip.TabIndex = 7;
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
            // enforceLawGridViewChemicalsList
            // 
            this.enforceLawGridViewChemicalsList.AllowUserToAddRows = false;
            this.enforceLawGridViewChemicalsList.AutoUpdate = false;
            this.enforceLawGridViewChemicalsList.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewChemicalsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewChemicalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewChemicalsList.ColumnHeadersHeight = 40;
            this.enforceLawGridViewChemicalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewChemicalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChemicalsNumber,
            this.ChemicalsName,
            this.ChemicalsAlias,
            this.ChemicalsUN,
            this.ChemicalsType});
            this.enforceLawGridViewChemicalsList.Custom = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enforceLawGridViewChemicalsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.enforceLawGridViewChemicalsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewChemicalsList.EntityType = null;
            this.enforceLawGridViewChemicalsList.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewChemicalsList.Name = "enforceLawGridViewChemicalsList";
            this.enforceLawGridViewChemicalsList.ReadOnly = true;
            this.enforceLawGridViewChemicalsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceLawGridViewChemicalsList.RowTemplate.Height = 36;
            this.enforceLawGridViewChemicalsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewChemicalsList.Size = new System.Drawing.Size(1171, 541);
            this.enforceLawGridViewChemicalsList.TabIndex = 6;
            // 
            // ChemicalsNumber
            // 
            this.ChemicalsNumber.HeaderText = "编号";
            this.ChemicalsNumber.Name = "ChemicalsNumber";
            this.ChemicalsNumber.ReadOnly = true;
            this.ChemicalsNumber.Width = 150;
            // 
            // ChemicalsName
            // 
            this.ChemicalsName.HeaderText = "名称";
            this.ChemicalsName.Name = "ChemicalsName";
            this.ChemicalsName.ReadOnly = true;
            this.ChemicalsName.Width = 360;
            // 
            // ChemicalsAlias
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ChemicalsAlias.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChemicalsAlias.HeaderText = "别名";
            this.ChemicalsAlias.Name = "ChemicalsAlias";
            this.ChemicalsAlias.ReadOnly = true;
            this.ChemicalsAlias.Width = 200;
            // 
            // ChemicalsUN
            // 
            this.ChemicalsUN.HeaderText = "UN号";
            this.ChemicalsUN.Name = "ChemicalsUN";
            this.ChemicalsUN.ReadOnly = true;
            this.ChemicalsUN.Width = 150;
            // 
            // ChemicalsType
            // 
            this.ChemicalsType.HeaderText = "所属类别";
            this.ChemicalsType.Name = "ChemicalsType";
            this.ChemicalsType.ReadOnly = true;
            this.ChemicalsType.Width = 250;
            // 
            // txtName
            // 
            this.txtName.ControlText = "";
            this.txtName.Location = new System.Drawing.Point(202, 7);
            this.txtName.Name = "txtName";
            this.txtName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.PopupWidth = 300;
            this.txtName.Size = new System.Drawing.Size(112, 23);
            this.txtName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "分类:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1171, 75);
            this.header1.TabIndex = 4;
            this.header1.Title = "危险化学品-爆炸品";
            this.header1.BackEvent += new System.EventHandler(this.DoBack);
            // 
            // frmChemicalsLists
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmChemicalsLists";
            this.Size = new System.Drawing.Size(1171, 700);
            this.Load += new System.EventHandler(this.frmChemicalsLists_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewChemicalsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private EnforceUI.EnforceLawGridView enforceLawGridViewChemicalsList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private EnforceUI.DocumentAutoCompleteTextBox txtName;
        private System.Windows.Forms.Label label2;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalsAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalsUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalsType;
    }
}

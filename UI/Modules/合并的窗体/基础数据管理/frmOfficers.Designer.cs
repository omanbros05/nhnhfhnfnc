namespace EnforceForm
{
    partial class frmOfficers
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
            this.enforceLawGridViewOfficers = new EnforceUI.EnforceLawGridView(this.components);
            this.OfficersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentAutoCompleteTextBoxName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.buttonQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewOfficers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewOfficers);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.documentAutoCompleteTextBoxName);
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.label1);
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
            this.enforceToolStrip.TabIndex = 2;
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
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // enforceLawGridViewOfficers
            // 
            this.enforceLawGridViewOfficers.AutoUpdate = true;
            this.enforceLawGridViewOfficers.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewOfficers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewOfficers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewOfficers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfficersName,
            this.Unit,
            this.Position,
            this.CID});
            this.enforceLawGridViewOfficers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewOfficers.EntityType = null;
            this.enforceLawGridViewOfficers.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewOfficers.Name = "enforceLawGridViewOfficers";
            this.enforceLawGridViewOfficers.RowTemplate.Height = 23;
            this.enforceLawGridViewOfficers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewOfficers.Size = new System.Drawing.Size(694, 329);
            this.enforceLawGridViewOfficers.TabIndex = 1;
            // 
            // OfficersName
            // 
            this.OfficersName.HeaderText = "姓名";
            this.OfficersName.Name = "OfficersName";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            // 
            // Position
            // 
            this.Position.HeaderText = "职务";
            this.Position.Name = "Position";
            // 
            // CID
            // 
            this.CID.HeaderText = "证件号";
            this.CID.Name = "CID";
            // 
            // documentAutoCompleteTextBoxName
            // 
            this.documentAutoCompleteTextBoxName.ControlText = "";
            this.documentAutoCompleteTextBoxName.Location = new System.Drawing.Point(55, 6);
            this.documentAutoCompleteTextBoxName.Name = "documentAutoCompleteTextBoxName";
            this.documentAutoCompleteTextBoxName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentAutoCompleteTextBoxName.PopupOffset = new System.Drawing.Point(12, 0);
            this.documentAutoCompleteTextBoxName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.documentAutoCompleteTextBoxName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.documentAutoCompleteTextBoxName.PopupWidth = 300;
            this.documentAutoCompleteTextBoxName.Size = new System.Drawing.Size(190, 23);
            this.documentAutoCompleteTextBoxName.TabIndex = 10;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(251, 6);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 9;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名:";
            // 
            // frmOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmOfficers";
            this.Load += new System.EventHandler(this.frmOfficerss_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewOfficers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewOfficers;
        private EnforceUI.DocumentAutoCompleteTextBox documentAutoCompleteTextBoxName;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
    }
}

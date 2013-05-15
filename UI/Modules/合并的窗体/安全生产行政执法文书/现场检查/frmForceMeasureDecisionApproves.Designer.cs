namespace EnforceForm
{
    partial class frmForceMeasureDecisionApproves
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
            this.enforceLawGridViewForceMeasureDecisionApprove = new EnforceUI.EnforceLawGridView(this.components);
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegalRepre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOutPut = new System.Windows.Forms.ToolStripButton();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.documentAutoCompleteTextBoxParty = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewForceMeasureDecisionApprove)).BeginInit();
            this.enforceToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(3, 78);
            this.panelTop.Size = new System.Drawing.Size(954, 36);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(3, 116);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewForceMeasureDecisionApprove);
            this.panel3.Location = new System.Drawing.Point(3, 144);
            this.panel3.Size = new System.Drawing.Size(954, 336);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.documentAutoCompleteTextBoxParty);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(954, 36);
            // 
            // enforceLawGridViewForceMeasureDecisionApprove
            // 
            this.enforceLawGridViewForceMeasureDecisionApprove.AllowUserToAddRows = false;
            this.enforceLawGridViewForceMeasureDecisionApprove.AutoUpdate = false;
            this.enforceLawGridViewForceMeasureDecisionApprove.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewForceMeasureDecisionApprove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewForceMeasureDecisionApprove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewForceMeasureDecisionApprove.ColumnHeadersHeight = 40;
            this.enforceLawGridViewForceMeasureDecisionApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewForceMeasureDecisionApprove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Party,
            this.LegalRepre,
            this.Tel});
            this.enforceLawGridViewForceMeasureDecisionApprove.Custom = false;
            this.enforceLawGridViewForceMeasureDecisionApprove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewForceMeasureDecisionApprove.EntityType = null;
            this.enforceLawGridViewForceMeasureDecisionApprove.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewForceMeasureDecisionApprove.Name = "enforceLawGridViewForceMeasureDecisionApprove";
            this.enforceLawGridViewForceMeasureDecisionApprove.ReadOnly = true;
            this.enforceLawGridViewForceMeasureDecisionApprove.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceLawGridViewForceMeasureDecisionApprove.RowTemplate.Height = 36;
            this.enforceLawGridViewForceMeasureDecisionApprove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewForceMeasureDecisionApprove.Size = new System.Drawing.Size(954, 336);
            this.enforceLawGridViewForceMeasureDecisionApprove.TabIndex = 3;
            // 
            // Party
            // 
            this.Party.HeaderText = "当事人";
            this.Party.Name = "Party";
            this.Party.ReadOnly = true;
            this.Party.Width = 300;
            // 
            // LegalRepre
            // 
            this.LegalRepre.HeaderText = "法定代表人";
            this.LegalRepre.Name = "LegalRepre";
            this.LegalRepre.ReadOnly = true;
            this.LegalRepre.Width = 120;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "联系电话";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 150;
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
            this.toolStripButton1,
            this.toolStripButtonOutPut});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(954, 25);
            this.enforceToolStrip.TabIndex = 4;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Maleos.Properties.Resources.savedoc;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "归档";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonOutPut
            // 
            this.toolStripButtonOutPut.Image = global::Maleos.Properties.Resources.layout;
            this.toolStripButtonOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutPut.Name = "toolStripButtonOutPut";
            this.toolStripButtonOutPut.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonOutPut.Text = "浏览";
            this.toolStripButtonOutPut.Visible = false;
            this.toolStripButtonOutPut.Click += new System.EventHandler(this.toolStripButtonOutPut_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(250, 6);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 5;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // documentAutoCompleteTextBoxParty
            // 
            this.documentAutoCompleteTextBoxParty.ControlText = "";
            this.documentAutoCompleteTextBoxParty.Location = new System.Drawing.Point(69, 6);
            this.documentAutoCompleteTextBoxParty.Name = "documentAutoCompleteTextBoxParty";
            this.documentAutoCompleteTextBoxParty.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentAutoCompleteTextBoxParty.PopupOffset = new System.Drawing.Point(12, 0);
            this.documentAutoCompleteTextBoxParty.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.documentAutoCompleteTextBoxParty.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.documentAutoCompleteTextBoxParty.PopupWidth = 300;
            this.documentAutoCompleteTextBoxParty.Size = new System.Drawing.Size(175, 23);
            this.documentAutoCompleteTextBoxParty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "当事人:";
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(960, 75);
            this.header1.TabIndex = 4;
            this.header1.Title = "强制措施决定审批";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // frmForceMeasureDecisionApproves
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmForceMeasureDecisionApproves";
            this.Load += new System.EventHandler(this.frmForceMeasureDecisionApproves_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewForceMeasureDecisionApprove)).EndInit();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.EnforceLawGridView enforceLawGridViewForceMeasureDecisionApprove;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox documentAutoCompleteTextBoxParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutPut;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegalRepre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
    }
}

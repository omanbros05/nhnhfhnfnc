namespace EnforceForm
{
    partial class frmSpotHandelDesisionSixtyDays
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
            this.documentAutoCompleteTextBoxDocTitle = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOutPut = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSpotHandelDesisionSixtyDay = new EnforceUI.EnforceLawGridView(this.components);
            this.DocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotHandelDesisionSixtyDay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotHandelDesisionSixtyDay);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.documentAutoCompleteTextBoxDocTitle);
            this.panel4.Controls.Add(this.label1);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(231, 6);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 8;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // documentAutoCompleteTextBoxDocTitle
            // 
            this.documentAutoCompleteTextBoxDocTitle.ControlText = "";
            this.documentAutoCompleteTextBoxDocTitle.Location = new System.Drawing.Point(50, 6);
            this.documentAutoCompleteTextBoxDocTitle.Name = "documentAutoCompleteTextBoxDocTitle";
            this.documentAutoCompleteTextBoxDocTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentAutoCompleteTextBoxDocTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.documentAutoCompleteTextBoxDocTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.documentAutoCompleteTextBoxDocTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.documentAutoCompleteTextBoxDocTitle.PopupWidth = 300;
            this.documentAutoCompleteTextBoxDocTitle.Size = new System.Drawing.Size(175, 23);
            this.documentAutoCompleteTextBoxDocTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "文号:";
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
            this.toolStripButtonOutPut.Click += new System.EventHandler(this.toolStripButtonOutPut_Click);
            // 
            // enforceLawGridViewSpotHandelDesisionSixtyDay
            // 
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.AutoUpdate = false;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocTitle,
            this.HandleComp,
            this.DocDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.DefaultCellStyle = dataGridViewCellStyle3;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.EntityType = null;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.Name = "enforceLawGridViewSpotHandelDesisionSixtyDay";
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.ReadOnly = true;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.RowTemplate.Height = 23;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.Size = new System.Drawing.Size(694, 329);
            this.enforceLawGridViewSpotHandelDesisionSixtyDay.TabIndex = 4;
            // 
            // DocTitle
            // 
            this.DocTitle.HeaderText = "文号";
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.ReadOnly = true;
            this.DocTitle.Width = 200;
            // 
            // HandleComp
            // 
            this.HandleComp.HeaderText = "处理单位";
            this.HandleComp.Name = "HandleComp";
            this.HandleComp.ReadOnly = true;
            // 
            // DocDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DocDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.DocDate.HeaderText = "文档日期";
            this.DocDate.Name = "DocDate";
            this.DocDate.ReadOnly = true;
            // 
            // frmSpotHandelDesisionSixtyDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSpotHandelDesisionSixtyDays";
            this.Load += new System.EventHandler(this.frmSpotHandelDesisionSixtyDays_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotHandelDesisionSixtyDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.DocumentAutoCompleteTextBox documentAutoCompleteTextBoxDocTitle;
        private System.Windows.Forms.Label label1;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSpotHandelDesisionSixtyDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutPut;
    }
}

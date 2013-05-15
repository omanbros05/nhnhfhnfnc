namespace EnforceForm
{
    partial class frmPunishmentDecisionUnits
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
            this.buttonQuery = new System.Windows.Forms.Button();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.DocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutOnRecordCaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunishmentMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPutOnRecordCompanyName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDocTitle = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(3, 78);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(3, 131);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(3, 159);
            this.panel3.Size = new System.Drawing.Size(954, 321);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtPutOnRecordCompanyName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TxtDocTitle);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonQuery);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(484, 13);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(73, 23);
            this.buttonQuery.TabIndex = 23;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
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
            this.toolStripButtonTar});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(954, 25);
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
            // toolStripButtonTar
            // 
            this.toolStripButtonTar.Image = global::Maleos.Properties.Resources.savedoc;
            this.toolStripButtonTar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTar.Name = "toolStripButtonTar";
            this.toolStripButtonTar.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonTar.Text = "归档";
            this.toolStripButtonTar.Click += new System.EventHandler(this.toolStripButtonTar_Click);
            // 
            // enforceLawGridViewSpotCheck
            // 
            this.enforceLawGridViewSpotCheck.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotCheck.AutoUpdate = false;
            this.enforceLawGridViewSpotCheck.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSpotCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeight = 40;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewSpotCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocTitle,
            this.PutOnRecordCaseName,
            this.PunishmentMoney,
            this.FillDate});
            this.enforceLawGridViewSpotCheck.Custom = false;
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSpotCheck.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 36;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(954, 321);
            this.enforceLawGridViewSpotCheck.TabIndex = 9;
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
            this.PutOnRecordCaseName.HeaderText = "被处罚单位";
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.Width = 200;
            // 
            // PunishmentMoney
            // 
            this.PunishmentMoney.HeaderText = "行政处罚金额";
            this.PunishmentMoney.Name = "PunishmentMoney";
            this.PunishmentMoney.Width = 150;
            // 
            // FillDate
            // 
            this.FillDate.HeaderText = "生成日期";
            this.FillDate.Name = "FillDate";
            this.FillDate.Width = 150;
            // 
            // TxtPutOnRecordCompanyName
            // 
            this.TxtPutOnRecordCompanyName.ControlText = "";
            this.TxtPutOnRecordCompanyName.Location = new System.Drawing.Point(297, 13);
            this.TxtPutOnRecordCompanyName.Name = "TxtPutOnRecordCompanyName";
            this.TxtPutOnRecordCompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPutOnRecordCompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.TxtPutOnRecordCompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TxtPutOnRecordCompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtPutOnRecordCompanyName.PopupWidth = 300;
            this.TxtPutOnRecordCompanyName.Size = new System.Drawing.Size(175, 23);
            this.TxtPutOnRecordCompanyName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "被处罚单位:";
            // 
            // TxtDocTitle
            // 
            this.TxtDocTitle.ControlText = "";
            this.TxtDocTitle.Location = new System.Drawing.Point(66, 13);
            this.TxtDocTitle.Name = "TxtDocTitle";
            this.TxtDocTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDocTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.TxtDocTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TxtDocTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtDocTitle.PopupWidth = 300;
            this.TxtDocTitle.Size = new System.Drawing.Size(149, 23);
            this.TxtDocTitle.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "文号:";
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(960, 75);
            this.header1.TabIndex = 12;
            this.header1.Title = "行政处罚决定书单位";
            // 
            // frmPunishmentDecisionUnits
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmPunishmentDecisionUnits";
            this.Load += new System.EventHandler(this.frmPunishmentDecisionUnits_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pager, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.header1, 0);
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

        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSpotCheck;
        private EnforceUI.DocumentAutoCompleteTextBox TxtPutOnRecordCompanyName;
        private System.Windows.Forms.Label label2;
        private EnforceUI.DocumentAutoCompleteTextBox TxtDocTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutOnRecordCaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunishmentMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}

namespace EnforceForm
{
    partial class frmPutOnRecords
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
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.DocTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IllegalTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThisDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDateTimePickerEndCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableDateTimePickerBeginCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.buttonQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.documentAutoCompleteTextBoxNumber = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
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
            this.panelTop.Location = new System.Drawing.Point(3, 63);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(3, 115);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(3, 145);
            this.panel3.Size = new System.Drawing.Size(954, 335);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.documentAutoCompleteTextBoxNumber);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tableDateTimePickerEndCheckDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tableDateTimePickerBeginCheckDate);
            this.panel4.Controls.Add(this.buttonQuery);
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
            this.enforceToolStrip.TabIndex = 3;
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
            this.CompanyName,
            this.IllegalTypeName,
            this.CaseSourceName,
            this.ThisDate});
            this.enforceLawGridViewSpotCheck.Custom = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enforceLawGridViewSpotCheck.DefaultCellStyle = dataGridViewCellStyle2;
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            this.enforceLawGridViewSpotCheck.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 36;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(954, 335);
            this.enforceLawGridViewSpotCheck.TabIndex = 2;
            // 
            // DocTitle
            // 
            this.DocTitle.HeaderText = "文号";
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "当事单位";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 140;
            // 
            // IllegalTypeName
            // 
            this.IllegalTypeName.HeaderText = "案由";
            this.IllegalTypeName.Name = "IllegalTypeName";
            this.IllegalTypeName.ReadOnly = true;
            this.IllegalTypeName.Width = 140;
            // 
            // CaseSourceName
            // 
            this.CaseSourceName.HeaderText = "案件来源";
            this.CaseSourceName.Name = "CaseSourceName";
            this.CaseSourceName.ReadOnly = true;
            this.CaseSourceName.Width = 140;
            // 
            // ThisDate
            // 
            this.ThisDate.HeaderText = "立案日期";
            this.ThisDate.Name = "ThisDate";
            this.ThisDate.ReadOnly = true;
            this.ThisDate.Width = 140;
            // 
            // tableDateTimePickerEndCheckDate
            // 
            this.tableDateTimePickerEndCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerEndCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerEndCheckDate.Location = new System.Drawing.Point(424, 15);
            this.tableDateTimePickerEndCheckDate.Name = "tableDateTimePickerEndCheckDate";
            this.tableDateTimePickerEndCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerEndCheckDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "立案日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "～";
            // 
            // tableDateTimePickerBeginCheckDate
            // 
            this.tableDateTimePickerBeginCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerBeginCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerBeginCheckDate.Location = new System.Drawing.Point(242, 14);
            this.tableDateTimePickerBeginCheckDate.Name = "tableDateTimePickerBeginCheckDate";
            this.tableDateTimePickerBeginCheckDate.Size = new System.Drawing.Size(150, 23);
            this.tableDateTimePickerBeginCheckDate.TabIndex = 11;
            this.tableDateTimePickerBeginCheckDate.Value = new System.DateTime(2013, 3, 9, 15, 10, 41, 390);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(592, 15);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 9;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "文号:";
            // 
            // documentAutoCompleteTextBoxNumber
            // 
            this.documentAutoCompleteTextBoxNumber.ControlText = "";
            this.documentAutoCompleteTextBoxNumber.Location = new System.Drawing.Point(53, 14);
            this.documentAutoCompleteTextBoxNumber.Name = "documentAutoCompleteTextBoxNumber";
            this.documentAutoCompleteTextBoxNumber.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentAutoCompleteTextBoxNumber.PopupOffset = new System.Drawing.Point(12, 0);
            this.documentAutoCompleteTextBoxNumber.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.documentAutoCompleteTextBoxNumber.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.documentAutoCompleteTextBoxNumber.PopupWidth = 300;
            this.documentAutoCompleteTextBoxNumber.Size = new System.Drawing.Size(118, 23);
            this.documentAutoCompleteTextBoxNumber.TabIndex = 14;
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
            this.header1.Title = "立案审批表";
            // 
            // frmPutOnRecords
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmPutOnRecords";
            this.Load += new System.EventHandler(this.frmPutOnRecords_Load);
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
        private EnforceUI.TableDateTimePicker tableDateTimePickerEndCheckDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableDateTimePicker tableDateTimePickerBeginCheckDate;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label label3;
        private EnforceUI.DocumentAutoCompleteTextBox documentAutoCompleteTextBoxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IllegalTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseSourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThisDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}

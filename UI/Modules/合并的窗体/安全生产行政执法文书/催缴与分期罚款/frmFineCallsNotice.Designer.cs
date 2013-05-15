namespace EnforceForm
{
    partial class frmFineCallsNotice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewFineCallsNotice = new EnforceUI.EnforceLawGridView(this.components);
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendCallsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDateTimePickerBeginCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.tableDateTimePickerEndCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.header1 = new Maleos.Controls.Header();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewFineCallsNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 667);
            this.pager.Size = new System.Drawing.Size(945, 33);
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
            this.panel3.Controls.Add(this.enforceLawGridViewFineCallsNotice);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Size = new System.Drawing.Size(945, 541);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableDateTimePickerBeginCheckDate);
            this.panel4.Controls.Add(this.tableDateTimePickerEndCheckDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Size = new System.Drawing.Size(945, 34);
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
            // enforceLawGridViewFineCallsNotice
            // 
            this.enforceLawGridViewFineCallsNotice.AllowUserToAddRows = false;
            this.enforceLawGridViewFineCallsNotice.AutoUpdate = false;
            this.enforceLawGridViewFineCallsNotice.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewFineCallsNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewFineCallsNotice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.enforceLawGridViewFineCallsNotice.ColumnHeadersHeight = 40;
            this.enforceLawGridViewFineCallsNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewFineCallsNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.SendCallsDate,
            this.EndDate,
            this.Location,
            this.FormDate});
            this.enforceLawGridViewFineCallsNotice.Custom = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enforceLawGridViewFineCallsNotice.DefaultCellStyle = dataGridViewCellStyle5;
            this.enforceLawGridViewFineCallsNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewFineCallsNotice.EntityType = null;
            this.enforceLawGridViewFineCallsNotice.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewFineCallsNotice.Name = "enforceLawGridViewFineCallsNotice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewFineCallsNotice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.enforceLawGridViewFineCallsNotice.RowTemplate.Height = 36;
            this.enforceLawGridViewFineCallsNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewFineCallsNotice.Size = new System.Drawing.Size(945, 541);
            this.enforceLawGridViewFineCallsNotice.TabIndex = 8;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "当事人";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 200;
            // 
            // SendCallsDate
            // 
            this.SendCallsDate.HeaderText = "发出时间";
            this.SendCallsDate.Name = "SendCallsDate";
            this.SendCallsDate.ReadOnly = true;
            this.SendCallsDate.Width = 120;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "缴款截止时间";
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 120;
            // 
            // Location
            // 
            this.Location.HeaderText = "缴款地点";
            this.Location.Name = "Location";
            this.Location.Width = 200;
            // 
            // FormDate
            // 
            this.FormDate.HeaderText = "日期";
            this.FormDate.Name = "FormDate";
            this.FormDate.Width = 120;
            // 
            // tableDateTimePickerBeginCheckDate
            // 
            this.tableDateTimePickerBeginCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerBeginCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerBeginCheckDate.Location = new System.Drawing.Point(69, 9);
            this.tableDateTimePickerBeginCheckDate.Name = "tableDateTimePickerBeginCheckDate";
            this.tableDateTimePickerBeginCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerBeginCheckDate.TabIndex = 33;
            // 
            // tableDateTimePickerEndCheckDate
            // 
            this.tableDateTimePickerEndCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerEndCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerEndCheckDate.Location = new System.Drawing.Point(259, 9);
            this.tableDateTimePickerEndCheckDate.Name = "tableDateTimePickerEndCheckDate";
            this.tableDateTimePickerEndCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerEndCheckDate.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "～";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(423, 4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 30;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(945, 75);
            this.header1.TabIndex = 11;
            this.header1.Title = "罚款催缴通知书";
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
            // frmFineCallsNotice
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmFineCallsNotice";
            this.Size = new System.Drawing.Size(945, 700);
            this.Load += new System.EventHandler(this.frmFineCallsNotice_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewFineCallsNotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewFineCallsNotice;
        private EnforceUI.TableDateTimePicker tableDateTimePickerBeginCheckDate;
        private EnforceUI.TableDateTimePicker tableDateTimePickerEndCheckDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendCallsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}

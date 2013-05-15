namespace EnforceForm
{
    partial class frmEnquireQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableDateTimePickerBeginCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.tableDateTimePickerEndCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewEnquireQuestion = new EnforceUI.EnforceLawGridView(this.components);
            this.EnquireBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnquireEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnquireCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnquirePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header1 = new Maleos.Controls.Header();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewEnquireQuestion)).BeginInit();
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
            this.panel3.Controls.Add(this.enforceLawGridViewEnquireQuestion);
            this.panel3.Location = new System.Drawing.Point(3, 160);
            this.panel3.Size = new System.Drawing.Size(954, 320);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableDateTimePickerBeginCheckDate);
            this.panel4.Controls.Add(this.tableDateTimePickerEndCheckDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonQuery);
            // 
            // tableDateTimePickerBeginCheckDate
            // 
            this.tableDateTimePickerBeginCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerBeginCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerBeginCheckDate.Location = new System.Drawing.Point(76, 14);
            this.tableDateTimePickerBeginCheckDate.Name = "tableDateTimePickerBeginCheckDate";
            this.tableDateTimePickerBeginCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerBeginCheckDate.TabIndex = 13;
            // 
            // tableDateTimePickerEndCheckDate
            // 
            this.tableDateTimePickerEndCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerEndCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerEndCheckDate.Location = new System.Drawing.Point(266, 14);
            this.tableDateTimePickerEndCheckDate.Name = "tableDateTimePickerEndCheckDate";
            this.tableDateTimePickerEndCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerEndCheckDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "笔录日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "～";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(430, 14);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 10;
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
            // enforceLawGridViewEnquireQuestion
            // 
            this.enforceLawGridViewEnquireQuestion.AllowUserToAddRows = false;
            this.enforceLawGridViewEnquireQuestion.AutoUpdate = false;
            this.enforceLawGridViewEnquireQuestion.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewEnquireQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewEnquireQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.enforceLawGridViewEnquireQuestion.ColumnHeadersHeight = 40;
            this.enforceLawGridViewEnquireQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewEnquireQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnquireBeginDate,
            this.EnquireEndDate,
            this.EnquireCount,
            this.EnquirePerson,
            this.DocDate});
            this.enforceLawGridViewEnquireQuestion.Custom = false;
            this.enforceLawGridViewEnquireQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewEnquireQuestion.EntityType = null;
            this.enforceLawGridViewEnquireQuestion.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewEnquireQuestion.Name = "enforceLawGridViewEnquireQuestion";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewEnquireQuestion.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.enforceLawGridViewEnquireQuestion.RowHeadersWidth = 36;
            this.enforceLawGridViewEnquireQuestion.RowTemplate.Height = 23;
            this.enforceLawGridViewEnquireQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewEnquireQuestion.Size = new System.Drawing.Size(954, 320);
            this.enforceLawGridViewEnquireQuestion.TabIndex = 2;
            // 
            // EnquireBeginDate
            // 
            dataGridViewCellStyle12.Format = "F";
            dataGridViewCellStyle12.NullValue = null;
            this.EnquireBeginDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.EnquireBeginDate.HeaderText = "询问开始时间";
            this.EnquireBeginDate.Name = "EnquireBeginDate";
            this.EnquireBeginDate.Width = 200;
            // 
            // EnquireEndDate
            // 
            dataGridViewCellStyle13.Format = "F";
            dataGridViewCellStyle13.NullValue = null;
            this.EnquireEndDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.EnquireEndDate.HeaderText = "询问结束时间";
            this.EnquireEndDate.Name = "EnquireEndDate";
            this.EnquireEndDate.Width = 200;
            // 
            // EnquireCount
            // 
            this.EnquireCount.HeaderText = "询问次数";
            this.EnquireCount.Name = "EnquireCount";
            // 
            // EnquirePerson
            // 
            this.EnquirePerson.HeaderText = "被询问人姓名";
            this.EnquirePerson.Name = "EnquirePerson";
            this.EnquirePerson.Width = 200;
            // 
            // DocDate
            // 
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.DocDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.DocDate.HeaderText = "笔录日期";
            this.DocDate.Name = "DocDate";
            this.DocDate.Width = 120;
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
            this.header1.Title = "询问笔录";
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
            // frmEnquireQuestions
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Name = "frmEnquireQuestions";
            this.Load += new System.EventHandler(this.frmEnquireQuestions_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewEnquireQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableDateTimePicker tableDateTimePickerBeginCheckDate;
        private EnforceUI.TableDateTimePicker tableDateTimePickerEndCheckDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewEnquireQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnquireBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnquireEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnquireCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnquirePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}

namespace EnforceForm
{
    partial class frmSealThingHandleApproval
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
            this.label2 = new System.Windows.Forms.Label();
            this.tableDateTimePickerBeginCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.tableDateTimePickerEndCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSealThingHandleApproval = new EnforceUI.EnforceLawGridView(this.components);
            this.CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyBaseInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SealDecideNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSealThingHandleApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 731);
            this.pager.Size = new System.Drawing.Size(925, 33);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Size = new System.Drawing.Size(925, 34);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Size = new System.Drawing.Size(925, 27);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSealThingHandleApproval);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Size = new System.Drawing.Size(925, 605);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonQuery);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tableDateTimePickerBeginCheckDate);
            this.panel4.Controls.Add(this.tableDateTimePickerEndCheckDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(925, 34);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(432, 6);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 13;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "～";
            // 
            // tableDateTimePickerBeginCheckDate
            // 
            this.tableDateTimePickerBeginCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerBeginCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerBeginCheckDate.Location = new System.Drawing.Point(78, 9);
            this.tableDateTimePickerBeginCheckDate.Name = "tableDateTimePickerBeginCheckDate";
            this.tableDateTimePickerBeginCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerBeginCheckDate.TabIndex = 12;
            this.tableDateTimePickerBeginCheckDate.Value = new System.DateTime(2013, 3, 7, 0, 0, 0, 0);
            // 
            // tableDateTimePickerEndCheckDate
            // 
            this.tableDateTimePickerEndCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerEndCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerEndCheckDate.Location = new System.Drawing.Point(268, 9);
            this.tableDateTimePickerEndCheckDate.Name = "tableDateTimePickerEndCheckDate";
            this.tableDateTimePickerEndCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerEndCheckDate.TabIndex = 14;
            this.tableDateTimePickerEndCheckDate.Value = new System.DateTime(2013, 3, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "日期:";
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
            this.enforceToolStrip.Size = new System.Drawing.Size(925, 25);
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
            // toolStripButtonTar
            // 
            this.toolStripButtonTar.Image = global::Maleos.Properties.Resources.savedoc;
            this.toolStripButtonTar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTar.Name = "toolStripButtonTar";
            this.toolStripButtonTar.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonTar.Text = "归档";
            this.toolStripButtonTar.Click += new System.EventHandler(this.toolStripButtonTar_Click);
            // 
            // enforceLawGridViewSealThingHandleApproval
            // 
            this.enforceLawGridViewSealThingHandleApproval.AllowUserToAddRows = false;
            this.enforceLawGridViewSealThingHandleApproval.AutoUpdate = false;
            this.enforceLawGridViewSealThingHandleApproval.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSealThingHandleApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSealThingHandleApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enforceLawGridViewSealThingHandleApproval.ColumnHeadersHeight = 40;
            this.enforceLawGridViewSealThingHandleApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewSealThingHandleApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseName,
            this.PartyBaseInfo,
            this.SealDecideNo,
            this.HandleDate});
            this.enforceLawGridViewSealThingHandleApproval.Custom = false;
            this.enforceLawGridViewSealThingHandleApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSealThingHandleApproval.EntityType = null;
            this.enforceLawGridViewSealThingHandleApproval.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSealThingHandleApproval.Name = "enforceLawGridViewSealThingHandleApproval";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSealThingHandleApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.enforceLawGridViewSealThingHandleApproval.RowTemplate.Height = 36;
            this.enforceLawGridViewSealThingHandleApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSealThingHandleApproval.Size = new System.Drawing.Size(925, 605);
            this.enforceLawGridViewSealThingHandleApproval.TabIndex = 5;
            // 
            // CaseName
            // 
            this.CaseName.HeaderText = "案件名称";
            this.CaseName.Name = "CaseName";
            this.CaseName.ReadOnly = true;
            this.CaseName.Width = 240;
            // 
            // PartyBaseInfo
            // 
            this.PartyBaseInfo.HeaderText = "当事人及基本情况";
            this.PartyBaseInfo.Name = "PartyBaseInfo";
            this.PartyBaseInfo.ReadOnly = true;
            this.PartyBaseInfo.Width = 260;
            // 
            // SealDecideNo
            // 
            this.SealDecideNo.HeaderText = "决定书文号";
            this.SealDecideNo.Name = "SealDecideNo";
            this.SealDecideNo.ReadOnly = true;
            this.SealDecideNo.Width = 200;
            // 
            // HandleDate
            // 
            this.HandleDate.HeaderText = "日期";
            this.HandleDate.Name = "HandleDate";
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(925, 75);
            this.header1.TabIndex = 12;
            this.header1.Title = "查封或扣押物品处理审批表";
            // 
            // frmSealThingHandleApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmSealThingHandleApproval";
            this.Size = new System.Drawing.Size(925, 764);
            this.LocationChanged += new System.EventHandler(this.frmSealThingHandleApproval_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSealThingHandleApproval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableDateTimePicker tableDateTimePickerBeginCheckDate;
        private EnforceUI.TableDateTimePicker tableDateTimePickerEndCheckDate;
        private System.Windows.Forms.Label label1;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSealThingHandleApproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyBaseInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SealDecideNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}

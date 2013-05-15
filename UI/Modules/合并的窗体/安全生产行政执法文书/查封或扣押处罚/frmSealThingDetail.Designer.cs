namespace EnforceForm
{
    partial class frmSealThingDetail
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
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.ThingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingNoe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.Location = new System.Drawing.Point(0, 719);
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
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Size = new System.Drawing.Size(925, 593);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(925, 34);
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
            this.enforceToolStrip.Size = new System.Drawing.Size(925, 25);
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
            this.toolStripButtonAdd.Visible = false;
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
            this.toolStripButtonEdit.Visible = false;
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
            // 
            // enforceLawGridViewSpotCheck
            // 
            this.enforceLawGridViewSpotCheck.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotCheck.AutoUpdate = false;
            this.enforceLawGridViewSpotCheck.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewSpotCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThingName,
            this.ThingModel,
            this.ThingPlace,
            this.ThingGrade,
            this.ThingUnit,
            this.ThingPrice,
            this.ThingNumber,
            this.ThingNoe});
            this.enforceLawGridViewSpotCheck.Custom = false;
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 23;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(925, 593);
            this.enforceLawGridViewSpotCheck.TabIndex = 5;
            // 
            // ThingName
            // 
            this.ThingName.HeaderText = "名称";
            this.ThingName.Name = "ThingName";
            this.ThingName.ReadOnly = true;
            this.ThingName.Width = 150;
            // 
            // ThingModel
            // 
            this.ThingModel.HeaderText = "规格型号";
            this.ThingModel.Name = "ThingModel";
            this.ThingModel.ReadOnly = true;
            // 
            // ThingPlace
            // 
            this.ThingPlace.HeaderText = "产地";
            this.ThingPlace.Name = "ThingPlace";
            this.ThingPlace.ReadOnly = true;
            // 
            // ThingGrade
            // 
            this.ThingGrade.HeaderText = "成色（品级）";
            this.ThingGrade.Name = "ThingGrade";
            // 
            // ThingUnit
            // 
            this.ThingUnit.HeaderText = "单位";
            this.ThingUnit.Name = "ThingUnit";
            // 
            // ThingPrice
            // 
            this.ThingPrice.HeaderText = "价格";
            this.ThingPrice.Name = "ThingPrice";
            // 
            // ThingNumber
            // 
            this.ThingNumber.HeaderText = "数量";
            this.ThingNumber.Name = "ThingNumber";
            // 
            // ThingNoe
            // 
            this.ThingNoe.HeaderText = "备注";
            this.ThingNoe.Name = "ThingNoe";
            // 
            // frmSealThingDetail
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmSealThingDetail";
            this.Size = new System.Drawing.Size(925, 752);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingNoe;
    }
}

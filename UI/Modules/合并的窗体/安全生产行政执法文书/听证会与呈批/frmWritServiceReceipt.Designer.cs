namespace EnforceForm
{
    partial class frmWritServiceReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWritServiceReceipt));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enforceLawGridViewItems = new EnforceUI.EnforceLawGridView(this.components);
            this.WritName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Note = new EnforceUI.TableRichTextBox(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ServiceCompany = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.ServiceCompany);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.enforceLawGridViewItems);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(849, 503);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Size = new System.Drawing.Size(849, 42);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(849, 75);
            this.header1.Title = "文书送达回执 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(325, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "文书送达回执";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(49, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(700, 4);
            this.tableLine1.TabIndex = 81;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(295, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "案件名称：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "受送达单位（个人）:";
            // 
            // enforceLawGridViewItems
            // 
            this.enforceLawGridViewItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enforceLawGridViewItems.AutoUpdate = false;
            this.enforceLawGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enforceLawGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enforceLawGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WritName,
            this.Recipient,
            this.ServiceDate,
            this.ServiceAddress,
            this.ServiceWay,
            this.ServicePerson});
            this.enforceLawGridViewItems.Custom = false;
            this.enforceLawGridViewItems.EntityType = null;
            this.enforceLawGridViewItems.Location = new System.Drawing.Point(57, 243);
            this.enforceLawGridViewItems.Name = "enforceLawGridViewItems";
            this.enforceLawGridViewItems.RowTemplate.Height = 23;
            this.enforceLawGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.enforceLawGridViewItems.Size = new System.Drawing.Size(692, 150);
            this.enforceLawGridViewItems.TabIndex = 7;
            // 
            // WritName
            // 
            this.WritName.HeaderText = "送达文书名称、文号";
            this.WritName.Name = "WritName";
            this.WritName.Width = 120;
            // 
            // Recipient
            // 
            this.Recipient.HeaderText = "收件人签名或者盖章";
            this.Recipient.Name = "Recipient";
            this.Recipient.Width = 120;
            // 
            // ServiceDate
            // 
            this.ServiceDate.HeaderText = "送达日期";
            this.ServiceDate.Name = "ServiceDate";
            // 
            // ServiceAddress
            // 
            this.ServiceAddress.HeaderText = "送达地点";
            this.ServiceAddress.Name = "ServiceAddress";
            // 
            // ServiceWay
            // 
            this.ServiceWay.HeaderText = "送达方式";
            this.ServiceWay.Name = "ServiceWay";
            // 
            // ServicePerson
            // 
            this.ServicePerson.HeaderText = "送达人";
            this.ServicePerson.Name = "ServicePerson";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Note);
            this.groupBox1.Location = new System.Drawing.Point(57, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备注";
            // 
            // Note
            // 
            this.Note.ControlText = "";
            this.Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Note.Location = new System.Drawing.Point(3, 22);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(686, 103);
            this.Note.TabIndex = 0;
            this.Note.Text = "";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管听报〔2012〕1号";
            this.DocTitle.Location = new System.Drawing.Point(218, 134);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "(××)安监管听报〔2012〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(438, 418);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(311, 19);
            this.DocManageArea.TabIndex = 8;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(148, 165);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(583, 19);
            this.CaseName.TabIndex = 4;
            // 
            // ServiceCompany
            // 
            this.ServiceCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServiceCompany.BackColor = System.Drawing.Color.White;
            this.ServiceCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceCompany.ControlText = "";
            this.ServiceCompany.Location = new System.Drawing.Point(214, 208);
            this.ServiceCompany.Name = "ServiceCompany";
            this.ServiceCompany.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceCompany.PopupOffset = new System.Drawing.Point(12, 0);
            this.ServiceCompany.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ServiceCompany.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ServiceCompany.PopupWidth = 300;
            this.ServiceCompany.Size = new System.Drawing.Size(517, 19);
            this.ServiceCompany.TabIndex = 6;
            // 
            // frmWritServiceReceipt
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmWritServiceReceipt";
            this.Size = new System.Drawing.Size(849, 620);
            this.Load += new System.EventHandler(this.frmWritServiceReceipt_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label7;
        private EnforceUI.EnforceLawGridView enforceLawGridViewItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox Note;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableTextTitle DocManageArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn WritName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePerson;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private EnforceUI.TableAutoCompleteTextBox ServiceCompany;
    }
}

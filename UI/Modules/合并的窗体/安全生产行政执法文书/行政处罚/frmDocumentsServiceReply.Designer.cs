namespace EnforceForm
{
    partial class frmDocumentsServiceReply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentsServiceReply));
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.PutOnRecordCaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.PutOnRecordCaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(813, 257);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Size = new System.Drawing.Size(813, 35);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(813, 75);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "XX安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(387, 284);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 301;
            this.DocManageArea.Text = "XX安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.ControlText = "";
            this.PutOnRecordCaseName.Location = new System.Drawing.Point(127, 183);
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseName.PopupWidth = 300;
            this.PutOnRecordCaseName.Size = new System.Drawing.Size(540, 19);
            this.PutOnRecordCaseName.TabIndex = 289;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 287;
            this.label11.Text = "案件名称：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(302, 110);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(129, 20);
            this.headerLabel2.TabIndex = 284;
            this.headerLabel2.Text = "文书送达回执";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-9, 102);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 285;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(262, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 283;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 287;
            this.label1.Text = "受送达单位（个人）：";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(216, 226);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(451, 19);
            this.CompanyName.TabIndex = 289;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 282;
            this.button1.Text = "打开软键盘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDocumentsServiceReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDocumentsServiceReply";
            this.Size = new System.Drawing.Size(813, 367);
            this.Load += new System.EventHandler(this.frmDocumentsServiceReply_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseName;
        private System.Windows.Forms.Label label11;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

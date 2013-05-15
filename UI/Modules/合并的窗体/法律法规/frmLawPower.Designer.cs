namespace EnforceForm
{
    partial class frmLawPower
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
            this.doc = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Visible = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.doc);
            this.panelContent.Size = new System.Drawing.Size(945, 665);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Size = new System.Drawing.Size(945, 35);
            // 
            // doc
            // 
            this.doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doc.Location = new System.Drawing.Point(38, 17);
            this.doc.Name = "doc";
            this.doc.Options.MailMerge.KeepLastParagraph = false;
            this.doc.ReadOnly = true;
            this.doc.Size = new System.Drawing.Size(868, 631);
            this.doc.TabIndex = 2;
            // 
            // frmLawPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmLawPower";
            this.Size = new System.Drawing.Size(945, 700);
            this.Load += new System.EventHandler(this.frmLawPower_Load);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl doc;
    }
}

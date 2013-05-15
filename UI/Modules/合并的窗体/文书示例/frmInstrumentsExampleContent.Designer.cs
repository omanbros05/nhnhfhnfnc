namespace EnforceForm
{
    partial class frmInstrumentsExampleContent
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
            // buttonExport
            // 
            this.buttonExport.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Visible = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.doc);
            this.panelContent.Size = new System.Drawing.Size(871, 640);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 715);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.BackEvent += new System.EventHandler(this.DoBack);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Visible = false;
            // 
            // doc
            // 
            this.doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doc.Location = new System.Drawing.Point(1, 81);
            this.doc.Name = "doc";
            this.doc.Options.MailMerge.KeepLastParagraph = false;
            this.doc.Size = new System.Drawing.Size(868, 557);
            this.doc.TabIndex = 2;
            // 
            // frmInstrumentsExampleContent
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmInstrumentsExampleContent";
            this.Size = new System.Drawing.Size(871, 750);
            this.Load += new System.EventHandler(this.frmInstrumentsExampleContent_Load);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl doc;
    }
}

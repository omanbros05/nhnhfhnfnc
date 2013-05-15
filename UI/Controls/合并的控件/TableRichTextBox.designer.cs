namespace EnforceUI
{
    partial class TableRichTextBox
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCopy,
            this.toolCut,
            this.toolPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 103);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolCopy
            // 
            this.toolCopy.AutoSize = false;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(94, 33);
            this.toolCopy.Text = "复制";
            // 
            // toolCut
            // 
            this.toolCut.AutoSize = false;
            this.toolCut.Name = "toolCut";
            this.toolCut.Size = new System.Drawing.Size(94, 33);
            this.toolCut.Text = "剪切";
            // 
            // toolPaste
            // 
            this.toolPaste.AutoSize = false;
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Size = new System.Drawing.Size(94, 33);
            this.toolPaste.Text = "粘贴";
            // 
            // TableRichTextBox
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableRichTextBox_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolCopy;
        private System.Windows.Forms.ToolStripMenuItem toolCut;
        private System.Windows.Forms.ToolStripMenuItem toolPaste;



    }
}

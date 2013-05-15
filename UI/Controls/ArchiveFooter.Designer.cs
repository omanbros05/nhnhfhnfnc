namespace Maleos.Controls
{
    partial class ArchiveFooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveFooter));
            this.imageButton1 = new Maleos.Controls.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageButton1
            // 
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.DownImage")));
            this.imageButton1.HoverImage = null;
            this.imageButton1.Location = new System.Drawing.Point(62, 27);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.NormalImage")));
            this.imageButton1.Size = new System.Drawing.Size(40, 40);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton1.TabIndex = 0;
            this.imageButton1.TabStop = false;
            this.imageButton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "执法档案类型维护";
            // 
            // ArchiveFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageButton1);
            this.Name = "ArchiveFooter";
            this.Size = new System.Drawing.Size(1096, 110);
            this.Resize += new System.EventHandler(this.ArchiveFooter_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageButton imageButton1;
        private System.Windows.Forms.Label label1;
    }
}

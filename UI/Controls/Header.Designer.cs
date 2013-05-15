namespace Maleos.Controls
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.lblTitle = new System.Windows.Forms.Label();
            this.BackButton = new Maleos.Controls.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "台州市安监移动执法系统";
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackButton.DownImage = ((System.Drawing.Image)(resources.GetObject("BackButton.DownImage")));
            this.BackButton.HoverImage = ((System.Drawing.Image)(resources.GetObject("BackButton.HoverImage")));
            this.BackButton.Location = new System.Drawing.Point(14, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("BackButton.NormalImage")));
            this.BackButton.Size = new System.Drawing.Size(43, 43);
            this.BackButton.TabIndex = 2;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Header
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.lblTitle);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1577, 65);
            this.Resize += new System.EventHandler(this.Header_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Controls.ImageButton BackButton;
    }
}

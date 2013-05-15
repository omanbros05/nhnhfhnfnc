namespace Maleos.Modules
{
    partial class LauncherExt
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
            this.launcher1 = new Maleos.Controls.Launcher();
            this.header1 = new Maleos.Controls.Header();
            this.SuspendLayout();
            // 
            // launcher1
            // 
            this.launcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launcher1.Location = new System.Drawing.Point(0, 0);
            this.launcher1.Name = "launcher1";
            this.launcher1.Padding = new System.Windows.Forms.Padding(0, 75, 0, 0);
            this.launcher1.Size = new System.Drawing.Size(1180, 658);
            this.launcher1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1180, 75);
            this.header1.TabIndex = 1;
            this.header1.Title = "台州市安监移动执法系统";
            // 
            // LauncherExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Controls.Add(this.launcher1);
            this.Name = "LauncherExt";
            this.Size = new System.Drawing.Size(1180, 658);
            this.ResumeLayout(false);

        }

        #endregion

        private Maleos.Controls.Launcher launcher1;
        private Controls.Header header1;
    }
}

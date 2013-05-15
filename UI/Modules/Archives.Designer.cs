namespace Maleos.Modules
{
    partial class Archives
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
            this.header1 = new Maleos.Controls.Header();
            this.archiveFooter1 = new Maleos.Controls.ArchiveFooter();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1146, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "执法档案";
            this.header1.BackEvent += new System.EventHandler(this.DoBack);
            // 
            // archiveFooter1
            // 
            this.archiveFooter1.BackColor = System.Drawing.Color.ForestGreen;
            this.archiveFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.archiveFooter1.Location = new System.Drawing.Point(0, 474);
            this.archiveFooter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.archiveFooter1.Name = "archiveFooter1";
            this.archiveFooter1.Size = new System.Drawing.Size(1146, 110);
            this.archiveFooter1.TabIndex = 1;
            this.archiveFooter1.ButtonEventHandler += new System.EventHandler(this.archiveFooter1_ButtonEventHandler);
            // 
            // Archives
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.archiveFooter1);
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Archives";
            this.Size = new System.Drawing.Size(1146, 584);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Header header1;
        private Controls.ArchiveFooter archiveFooter1;
    }
}

namespace EnforceUI
{
    partial class BaseFormDetails
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
            this.pager = new EnforceUI.Pager();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pager
            // 
            this.pager.CurrentPage = 1;
            this.pager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pager.Location = new System.Drawing.Point(0, 487);
            this.pager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pager.Name = "pager";
            this.pager.PageSize = 20;
            this.pager.Size = new System.Drawing.Size(960, 33);
            this.pager.TabIndex = 0;
            this.pager.TotalCount = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel4);
            this.panelTop.Location = new System.Drawing.Point(3, 121);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(954, 50);
            this.panelTop.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 50);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 27);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 260);
            this.panel3.TabIndex = 3;
            // 
            // BaseFormDetails
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BaseFormDetails";
            this.Size = new System.Drawing.Size(960, 520);
            this.Resize += new System.EventHandler(this.BaseFormDetails_Resize);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Pager pager;
        protected System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel4;

    }
}

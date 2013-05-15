using Maleos.Modules;
namespace Maleos.Modules
{
    partial class ArchiveTypeManager
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
            this.footer1 = new Maleos.Controls.Footer();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1416, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "执法档案类型维护";
            this.header1.BackEvent += new System.EventHandler(this.DoBack);
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.ForestGreen;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 516);
            this.footer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.footer1.MaximumSize = new System.Drawing.Size(1303, 156);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1303, 95);
            this.footer1.TabIndex = 1;
            this.footer1.AddEvent += new System.EventHandler(this.footer1_AddEvent);
            this.footer1.DeleteEvent += new System.EventHandler(this.footer1_DeleteEvent);
            this.footer1.MarkEvent += new System.EventHandler(this.footer1_MarkEvent);
            // 
            // ArchiveTypeManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "ArchiveTypeManager";
            this.Size = new System.Drawing.Size(1416, 611);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Header header1;
        private Controls.Footer footer1;
    }
}

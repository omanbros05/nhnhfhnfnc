namespace Maleos.Controls
{
    partial class Footer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Footer));
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblDelete = new System.Windows.Forms.Label();
            this.LblMark = new System.Windows.Forms.Label();
            this.BtnMark = new Maleos.Controls.ImageButton();
            this.BtnDelete = new Maleos.Controls.ImageButton();
            this.BtnAdd = new Maleos.Controls.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdd.ForeColor = System.Drawing.Color.White;
            this.LblAdd.Location = new System.Drawing.Point(47, 71);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(35, 14);
            this.LblAdd.TabIndex = 1;
            this.LblAdd.Text = "添加";
            this.LblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDelete
            // 
            this.LblDelete.AutoSize = true;
            this.LblDelete.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDelete.ForeColor = System.Drawing.Color.White;
            this.LblDelete.Location = new System.Drawing.Point(153, 71);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(35, 14);
            this.LblDelete.TabIndex = 1;
            this.LblDelete.Text = "删除";
            this.LblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDelete.Visible = false;
            // 
            // LblMark
            // 
            this.LblMark.AutoSize = true;
            this.LblMark.Font = new System.Drawing.Font("宋体", 10F);
            this.LblMark.ForeColor = System.Drawing.Color.White;
            this.LblMark.Location = new System.Drawing.Point(247, 72);
            this.LblMark.Name = "LblMark";
            this.LblMark.Size = new System.Drawing.Size(63, 14);
            this.LblMark.TabIndex = 4;
            this.LblMark.Text = "最终归档";
            this.LblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMark.Visible = false;
            // 
            // BtnMark
            // 
            this.BtnMark.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMark.DownImage = ((System.Drawing.Image)(resources.GetObject("BtnMark.DownImage")));
            this.BtnMark.HoverImage = null;
            this.BtnMark.Location = new System.Drawing.Point(257, 22);
            this.BtnMark.Name = "BtnMark";
            this.BtnMark.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnMark.NormalImage")));
            this.BtnMark.Size = new System.Drawing.Size(40, 40);
            this.BtnMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnMark.TabIndex = 3;
            this.BtnMark.TabStop = false;
            this.BtnMark.Visible = false;
            this.BtnMark.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDelete.DownImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.DownImage")));
            this.BtnDelete.HoverImage = null;
            this.BtnDelete.Location = new System.Drawing.Point(148, 20);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.NormalImage")));
            this.BtnDelete.Size = new System.Drawing.Size(42, 42);
            this.BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAdd.DownImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.DownImage")));
            this.BtnAdd.HoverImage = null;
            this.BtnAdd.Location = new System.Drawing.Point(44, 22);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.NormalImage")));
            this.BtnAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.LblMark);
            this.Controls.Add(this.BtnMark);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblDelete);
            this.Controls.Add(this.LblAdd);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(1117, 110);
            this.Resize += new System.EventHandler(this.Footer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageButton BtnAdd;
        private System.Windows.Forms.Label LblAdd;
        private Controls.ImageButton BtnDelete;
        private System.Windows.Forms.Label LblDelete;
        private Controls.ImageButton BtnMark;
        private System.Windows.Forms.Label LblMark;

    }
}

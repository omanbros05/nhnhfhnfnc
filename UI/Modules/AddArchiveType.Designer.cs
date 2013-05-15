namespace Maleos.Modules
{
    partial class AddArchiveType
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
            this.TextBoxArchiveType = new EnforceUI.Input.CoolTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelValidation = new System.Windows.Forms.Label();
            this.footer1 = new Maleos.Controls.Footer();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1148, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "执法档案类型添加";
            this.header1.BackEvent += new System.EventHandler(this.DoBack);
            // 
            // TextBoxArchiveType
            // 
            this.TextBoxArchiveType.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxArchiveType.BorderColor = System.Drawing.Color.ForestGreen;
            this.TextBoxArchiveType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxArchiveType.Font = new System.Drawing.Font("宋体", 25F);
            this.TextBoxArchiveType.Location = new System.Drawing.Point(133, 227);
            this.TextBoxArchiveType.Name = "TextBoxArchiveType";
            this.TextBoxArchiveType.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxArchiveType.PopupWidth = 120;
            this.TextBoxArchiveType.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.TextBoxArchiveType.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxArchiveType.Size = new System.Drawing.Size(812, 47);
            this.TextBoxArchiveType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(136, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入需要添加的执法档案名称";
            // 
            // LabelValidation
            // 
            this.LabelValidation.AutoSize = true;
            this.LabelValidation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelValidation.ForeColor = System.Drawing.Color.Red;
            this.LabelValidation.Location = new System.Drawing.Point(140, 281);
            this.LabelValidation.Name = "LabelValidation";
            this.LabelValidation.Size = new System.Drawing.Size(39, 21);
            this.LabelValidation.TabIndex = 4;
            this.LabelValidation.Text = "text";
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.ForestGreen;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 524);
            this.footer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1148, 96);
            this.footer1.TabIndex = 5;
            this.footer1.AddEvent += new System.EventHandler(this.footer1_AddEvent);
            // 
            // AddArchiveType
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.LabelValidation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxArchiveType);
            this.Controls.Add(this.header1);
            this.Name = "AddArchiveType";
            this.Size = new System.Drawing.Size(1148, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Header header1;
        private EnforceUI.Input.CoolTextBox TextBoxArchiveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelValidation;
        private Controls.Footer footer1;
    }
}

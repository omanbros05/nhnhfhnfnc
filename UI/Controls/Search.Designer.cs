namespace Maleos.Controls
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.NumberTextBox = new EnforceUI.Input.CoolTextBox();
            this.imageButton1 = new Maleos.Controls.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextbox = new EnforceUI.Input.CoolTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AttrNameTextbox = new EnforceUI.Input.CoolTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UNCodeTextbox = new EnforceUI.Input.CoolTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberTextBox.BorderColor = System.Drawing.Color.LightGray;
            this.NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberTextBox.Font = new System.Drawing.Font("宋体", 14F);
            this.NumberTextBox.Location = new System.Drawing.Point(16, 32);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NumberTextBox.PopupWidth = 120;
            this.NumberTextBox.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.NumberTextBox.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.NumberTextBox.Size = new System.Drawing.Size(200, 30);
            this.NumberTextBox.TabIndex = 0;
            // 
            // imageButton1
            // 
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = null;
            this.imageButton1.HoverImage = null;
            this.imageButton1.Location = new System.Drawing.Point(970, 0);
            this.imageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.NormalImage")));
            this.imageButton1.Size = new System.Drawing.Size(41, 72);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageButton1.TabIndex = 1;
            this.imageButton1.TabStop = false;
            this.imageButton1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "编号";
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextbox.BorderColor = System.Drawing.Color.LightGray;
            this.NameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextbox.Font = new System.Drawing.Font("宋体", 14F);
            this.NameTextbox.Location = new System.Drawing.Point(260, 32);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NameTextbox.PopupWidth = 120;
            this.NameTextbox.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.NameTextbox.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextbox.Size = new System.Drawing.Size(200, 30);
            this.NameTextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(261, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称";
            // 
            // AttrNameTextbox
            // 
            this.AttrNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.AttrNameTextbox.BorderColor = System.Drawing.Color.LightGray;
            this.AttrNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttrNameTextbox.Font = new System.Drawing.Font("宋体", 14F);
            this.AttrNameTextbox.Location = new System.Drawing.Point(504, 32);
            this.AttrNameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AttrNameTextbox.Name = "AttrNameTextbox";
            this.AttrNameTextbox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AttrNameTextbox.PopupWidth = 120;
            this.AttrNameTextbox.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.AttrNameTextbox.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.AttrNameTextbox.Size = new System.Drawing.Size(200, 30);
            this.AttrNameTextbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(505, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "别名";
            // 
            // UNCodeTextbox
            // 
            this.UNCodeTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.UNCodeTextbox.BorderColor = System.Drawing.Color.LightGray;
            this.UNCodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UNCodeTextbox.Font = new System.Drawing.Font("宋体", 14F);
            this.UNCodeTextbox.Location = new System.Drawing.Point(748, 32);
            this.UNCodeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UNCodeTextbox.Name = "UNCodeTextbox";
            this.UNCodeTextbox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UNCodeTextbox.PopupWidth = 120;
            this.UNCodeTextbox.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.UNCodeTextbox.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.UNCodeTextbox.Size = new System.Drawing.Size(200, 30);
            this.UNCodeTextbox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(749, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "UN编码";
            // 
            // Search
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.UNCodeTextbox);
            this.Controls.Add(this.AttrNameTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NumberTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(1186, 72);
            this.Resize += new System.EventHandler(this.Search_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageButton imageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public EnforceUI.Input.CoolTextBox NumberTextBox;
        public EnforceUI.Input.CoolTextBox NameTextbox;
        public EnforceUI.Input.CoolTextBox AttrNameTextbox;
        public EnforceUI.Input.CoolTextBox UNCodeTextbox;
    }
}

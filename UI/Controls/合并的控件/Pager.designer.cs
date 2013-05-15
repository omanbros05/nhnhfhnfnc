namespace EnforceUI
{
    partial class Pager
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPageCount = new System.Windows.Forms.ComboBox();
            this.buttonPageTop = new System.Windows.Forms.Button();
            this.buttonBeforePage = new System.Windows.Forms.Button();
            this.textBoxCurrentpage = new System.Windows.Forms.TextBox();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "每页条数:";
            // 
            // comboBoxPageCount
            // 
            this.comboBoxPageCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPageCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageCount.FormattingEnabled = true;
            this.comboBoxPageCount.Location = new System.Drawing.Point(76, 4);
            this.comboBoxPageCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPageCount.Name = "comboBoxPageCount";
            this.comboBoxPageCount.Size = new System.Drawing.Size(79, 25);
            this.comboBoxPageCount.TabIndex = 1;
            this.comboBoxPageCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageCount_SelectedIndexChanged);
            // 
            // buttonPageTop
            // 
            this.buttonPageTop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPageTop.Location = new System.Drawing.Point(161, 5);
            this.buttonPageTop.Name = "buttonPageTop";
            this.buttonPageTop.Size = new System.Drawing.Size(29, 23);
            this.buttonPageTop.TabIndex = 2;
            this.buttonPageTop.Text = "|<";
            this.buttonPageTop.UseVisualStyleBackColor = true;
            this.buttonPageTop.Click += new System.EventHandler(this.buttonPageTop_Click);
            // 
            // buttonBeforePage
            // 
            this.buttonBeforePage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBeforePage.Location = new System.Drawing.Point(196, 5);
            this.buttonBeforePage.Name = "buttonBeforePage";
            this.buttonBeforePage.Size = new System.Drawing.Size(29, 23);
            this.buttonBeforePage.TabIndex = 3;
            this.buttonBeforePage.Text = "<";
            this.buttonBeforePage.UseVisualStyleBackColor = true;
            this.buttonBeforePage.Click += new System.EventHandler(this.buttonBeforePage_Click);
            // 
            // textBoxCurrentpage
            // 
            this.textBoxCurrentpage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCurrentpage.Enabled = false;
            this.textBoxCurrentpage.Location = new System.Drawing.Point(231, 5);
            this.textBoxCurrentpage.Name = "textBoxCurrentpage";
            this.textBoxCurrentpage.Size = new System.Drawing.Size(36, 23);
            this.textBoxCurrentpage.TabIndex = 4;
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLastPage.Location = new System.Drawing.Point(308, 5);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(29, 23);
            this.buttonLastPage.TabIndex = 6;
            this.buttonLastPage.Text = ">|";
            this.buttonLastPage.UseVisualStyleBackColor = true;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNextPage.Location = new System.Drawing.Point(273, 5);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(29, 23);
            this.buttonNextPage.TabIndex = 5;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(343, 8);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(211, 17);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "总计 71 条记录，每页 30 条，共 3 页";
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonLastPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.textBoxCurrentpage);
            this.Controls.Add(this.buttonBeforePage);
            this.Controls.Add(this.buttonPageTop);
            this.Controls.Add(this.comboBoxPageCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(564, 33);
            this.Load += new System.EventHandler(this.Pager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPageCount;
        private System.Windows.Forms.Button buttonPageTop;
        private System.Windows.Forms.Button buttonBeforePage;
        private System.Windows.Forms.TextBox textBoxCurrentpage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Label labelMessage;
    }
}

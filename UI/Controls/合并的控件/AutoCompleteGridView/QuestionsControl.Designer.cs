namespace EnforceUI
{
    partial class QuestionsControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoCompleteTextBoxAsk = new EnforceUI.Input.AutoCompleteTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "问:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.autoCompleteTextBoxAsk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 33);
            this.panel1.TabIndex = 1;
            // 
            // autoCompleteTextBoxAsk
            // 
            this.autoCompleteTextBoxAsk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCompleteTextBoxAsk.Location = new System.Drawing.Point(39, 0);
            this.autoCompleteTextBoxAsk.Name = "autoCompleteTextBoxAsk";
            this.autoCompleteTextBoxAsk.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autoCompleteTextBoxAsk.PopupOffset = new System.Drawing.Point(12, 0);
            this.autoCompleteTextBoxAsk.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.autoCompleteTextBoxAsk.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.autoCompleteTextBoxAsk.PopupWidth = 300;
            this.autoCompleteTextBoxAsk.Size = new System.Drawing.Size(598, 26);
            this.autoCompleteTextBoxAsk.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDel);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(637, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 33);
            this.panel2.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(42, 4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(25, 22);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "-";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(25, 22);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "答:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAnswer.Location = new System.Drawing.Point(39, 33);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(668, 60);
            this.richTextBoxAnswer.TabIndex = 3;
            this.richTextBoxAnswer.Text = "";
            // 
            // QuestionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionsControl";
            this.Size = new System.Drawing.Size(707, 93);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Input.AutoCompleteTextBox autoCompleteTextBoxAsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;

    }
}

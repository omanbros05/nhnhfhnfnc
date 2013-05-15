namespace EnforceUI
{
    partial class BaseTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLaw = new System.Windows.Forms.Button();
            this.btnkeyboard = new System.Windows.Forms.Button();
            this.buttonShowExample = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelContent = new EnforceUI.ScrollPanel();
            this.header1 = new Maleos.Controls.Header();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLaw);
            this.panel2.Controls.Add(this.btnkeyboard);
            this.panel2.Controls.Add(this.buttonShowExample);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Controls.Add(this.buttonOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(435, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnLaw
            // 
            this.btnLaw.Location = new System.Drawing.Point(343, 5);
            this.btnLaw.Name = "btnLaw";
            this.btnLaw.Size = new System.Drawing.Size(75, 35);
            this.btnLaw.TabIndex = 4;
            this.btnLaw.Text = "查询法律";
            this.btnLaw.UseVisualStyleBackColor = true;
            // 
            // btnkeyboard
            // 
            this.btnkeyboard.Location = new System.Drawing.Point(260, 5);
            this.btnkeyboard.Name = "btnkeyboard";
            this.btnkeyboard.Size = new System.Drawing.Size(75, 35);
            this.btnkeyboard.TabIndex = 3;
            this.btnkeyboard.Text = "打开键盘";
            this.btnkeyboard.UseVisualStyleBackColor = true;
            this.btnkeyboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Location = new System.Drawing.Point(179, 5);
            this.buttonShowExample.Name = "buttonShowExample";
            this.buttonShowExample.Size = new System.Drawing.Size(75, 35);
            this.buttonShowExample.TabIndex = 2;
            this.buttonShowExample.Text = "查看示例";
            this.buttonShowExample.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(17, 5);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 35);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "导出";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(98, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "保存";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelContent.Location = new System.Drawing.Point(0, 75);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(871, 448);
            this.panelContent.TabIndex = 3;
            this.panelContent.Click += new System.EventHandler(this.panelContent_Click);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(871, 75);
            this.header1.TabIndex = 0;
            this.header1.Title = "台州市安监移动执法系统";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 44);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Maleos.Properties.Resources.line1400;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 1);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaseTableForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.panel1);
            this.Name = "BaseTableForm";
            this.Size = new System.Drawing.Size(871, 567);
            this.Load += new System.EventHandler(this.BaseTableForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button buttonExport;
        protected System.Windows.Forms.Button buttonOK;
        protected EnforceUI.ScrollPanel panelContent;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected Maleos.Controls.Header header1;
        protected System.Windows.Forms.Button buttonShowExample;
        protected System.Windows.Forms.Button btnkeyboard;
        protected System.Windows.Forms.Button btnLaw;
    }
}
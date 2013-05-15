namespace EnforceForm
{
    partial class frmLawList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLawList));
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.btnBrowse);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.txtPath);
            this.panelContent.Controls.Add(this.txtTitle);
            this.panelContent.Size = new System.Drawing.Size(886, 350);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Size = new System.Drawing.Size(886, 35);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Visible = false;
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(60, 105);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 153;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(341, 79);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(89, 20);
            this.headerLabel1.TabIndex = 151;
            this.headerLabel1.Text = "法律法规";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 150;
            this.label1.Text = "标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.ControlText = "";
            this.txtTitle.Location = new System.Drawing.Point(189, 140);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtTitle.PopupWidth = 300;
            this.txtTitle.Size = new System.Drawing.Size(567, 19);
            this.txtTitle.TabIndex = 152;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 150;
            this.label2.Text = "选择文件：";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.ControlText = "";
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(189, 196);
            this.txtPath.Name = "txtPath";
            this.txtPath.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtPath.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtPath.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPath.PopupWidth = 300;
            this.txtPath.Size = new System.Drawing.Size(479, 19);
            this.txtPath.TabIndex = 152;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(681, 192);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 156;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmLawList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmLawList";
            this.Size = new System.Drawing.Size(886, 460);
            this.Load += new System.EventHandler(this.frmLawList_Load);
            this.Click += new System.EventHandler(this.frmLawList_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableAutoCompleteTextBox txtTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
    }
}

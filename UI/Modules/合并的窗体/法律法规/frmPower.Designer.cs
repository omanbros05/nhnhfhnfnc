namespace EnforceForm
{
    partial class frmPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPower));
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
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
            this.panelContent.Controls.Add(this.txtContent);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.txtSubject);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.txtNumber);
            this.panelContent.Controls.Add(this.comboBox1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label29);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.txtTitle);
            this.panelContent.Size = new System.Drawing.Size(871, 581);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 656);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
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
            this.tableLine1.Location = new System.Drawing.Point(13, 104);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 157;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(294, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(89, 20);
            this.headerLabel1.TabIndex = 155;
            this.headerLabel1.Text = "行政处罚";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 154;
            this.label1.Text = "标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.ControlText = "";
            this.txtTitle.Location = new System.Drawing.Point(105, 139);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtTitle.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtTitle.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtTitle.PopupWidth = 300;
            this.txtTitle.Size = new System.Drawing.Size(625, 19);
            this.txtTitle.TabIndex = 156;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 24);
            this.comboBox1.TabIndex = 159;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(43, 186);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 16);
            this.label29.TabIndex = 158;
            this.label29.Text = "类型：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 160;
            this.label2.Text = "权力编码：";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumber.BackColor = System.Drawing.Color.White;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.ControlText = "";
            this.txtNumber.Location = new System.Drawing.Point(312, 186);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtNumber.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtNumber.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtNumber.PopupWidth = 300;
            this.txtNumber.Size = new System.Drawing.Size(163, 19);
            this.txtNumber.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 162;
            this.label3.Text = "实施主体：";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubject.BackColor = System.Drawing.Color.White;
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.ControlText = "";
            this.txtSubject.Location = new System.Drawing.Point(584, 188);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.PopupOffset = new System.Drawing.Point(12, 0);
            this.txtSubject.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txtSubject.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtSubject.PopupWidth = 300;
            this.txtSubject.Size = new System.Drawing.Size(146, 19);
            this.txtSubject.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 158;
            this.label4.Text = "内容：";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContent.Location = new System.Drawing.Point(46, 249);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(684, 400);
            this.txtContent.TabIndex = 164;
            this.txtContent.Text = "";
            // 
            // frmPower
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmPower";
            this.Size = new System.Drawing.Size(871, 700);
            this.Load += new System.EventHandler(this.frmPower_Load);
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
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableAutoCompleteTextBox txtNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label4;
    }
}

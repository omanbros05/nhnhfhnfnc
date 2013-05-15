namespace EnforceForm
{
    partial class frmEditSealThingHandle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSealThingHandle));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.CompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.SealDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SealContent = new EnforceUI.TableRichTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ThingCheckNo = new EnforceUI.TableTextTitle(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SealResult = new EnforceUI.TableRichTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Government = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ManageDepartment = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Court = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HandleDate = new EnforceUI.TableDateTimePicker(this.components);
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.HandleDate);
            this.panelContent.Controls.Add(this.ManageDepartment);
            this.panelContent.Controls.Add(this.Court);
            this.panelContent.Controls.Add(this.Government);
            this.panelContent.Controls.Add(this.ThingCheckNo);
            this.panelContent.Controls.Add(this.SealResult);
            this.panelContent.Controls.Add(this.SealContent);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.SealDate);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.CompanyName);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 778);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 853);
            this.panel1.Size = new System.Drawing.Size(886, 47);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "查封或扣押物品处理决定书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(239, 117);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(249, 20);
            this.headerLabel2.TabIndex = 41;
            this.headerLabel2.Text = "查封(扣押)物品处理决定书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-1, 108);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 42;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(252, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 40;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "(××)安监管查（扣）〔2010〕1号";
            this.DocTitle.Location = new System.Drawing.Point(148, 153);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(427, 19);
            this.DocTitle.TabIndex = 97;
            this.DocTitle.Text = "(××)安监管查（扣）〔2010〕1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.ControlText = "";
            this.CompanyName.Location = new System.Drawing.Point(-1, 186);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyName.PopupWidth = 300;
            this.CompanyName.Size = new System.Drawing.Size(399, 19);
            this.CompanyName.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "：";
            // 
            // SealDate
            // 
            this.SealDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealDate.CustomFormat = "yyyy年M月d日";
            this.SealDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SealDate.Location = new System.Drawing.Point(108, 222);
            this.SealDate.Name = "SealDate";
            this.SealDate.Size = new System.Drawing.Size(168, 26);
            this.SealDate.TabIndex = 100;
            this.SealDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "本机关于";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "对你的物品：";
            // 
            // SealContent
            // 
            this.SealContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealContent.ControlText = "";
            this.SealContent.Location = new System.Drawing.Point(0, 260);
            this.SealContent.Name = "SealContent";
            this.SealContent.Size = new System.Drawing.Size(748, 163);
            this.SealContent.TabIndex = 102;
            this.SealContent.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "进行了查封（扣押）[文号：";
            // 
            // ThingCheckNo
            // 
            this.ThingCheckNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ThingCheckNo.BackColor = System.Drawing.Color.White;
            this.ThingCheckNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThingCheckNo.ControlText = "(××)安监管查（扣）〔2010〕1号";
            this.ThingCheckNo.Location = new System.Drawing.Point(183, 436);
            this.ThingCheckNo.Name = "ThingCheckNo";
            this.ThingCheckNo.Size = new System.Drawing.Size(321, 19);
            this.ThingCheckNo.TabIndex = 103;
            this.ThingCheckNo.Text = "(××)安监管查（扣）〔2010〕1号";
            this.ThingCheckNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "]。现依法对上述物品作出如下";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "处理：";
            // 
            // SealResult
            // 
            this.SealResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SealResult.ControlText = "";
            this.SealResult.Location = new System.Drawing.Point(0, 501);
            this.SealResult.Name = "SealResult";
            this.SealResult.Size = new System.Drawing.Size(748, 163);
            this.SealResult.TabIndex = 102;
            this.SealResult.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 677);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 16);
            this.label8.TabIndex = 101;
            this.label8.Text = "如果不服本决定，可以依法在60日内向";
            // 
            // Government
            // 
            this.Government.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Government.BackColor = System.Drawing.Color.White;
            this.Government.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Government.ControlText = "";
            this.Government.Location = new System.Drawing.Point(308, 673);
            this.Government.Name = "Government";
            this.Government.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Government.PopupOffset = new System.Drawing.Point(12, 0);
            this.Government.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Government.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Government.PopupWidth = 300;
            this.Government.Size = new System.Drawing.Size(120, 19);
            this.Government.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "人民政府或者";
            // 
            // ManageDepartment
            // 
            this.ManageDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageDepartment.BackColor = System.Drawing.Color.White;
            this.ManageDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageDepartment.ControlText = "";
            this.ManageDepartment.Location = new System.Drawing.Point(538, 674);
            this.ManageDepartment.Name = "ManageDepartment";
            this.ManageDepartment.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageDepartment.PopupOffset = new System.Drawing.Point(12, 0);
            this.ManageDepartment.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ManageDepartment.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageDepartment.PopupWidth = 300;
            this.ManageDepartment.Size = new System.Drawing.Size(209, 19);
            this.ManageDepartment.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 710);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 16);
            this.label9.TabIndex = 101;
            this.label9.Text = "申请行政复议，或者在三个月内依法向";
            // 
            // Court
            // 
            this.Court.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Court.BackColor = System.Drawing.Color.White;
            this.Court.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Court.ControlText = "";
            this.Court.Location = new System.Drawing.Point(277, 708);
            this.Court.Name = "Court";
            this.Court.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Court.PopupOffset = new System.Drawing.Point(12, 0);
            this.Court.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Court.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Court.PopupWidth = 300;
            this.Court.Size = new System.Drawing.Size(120, 19);
            this.Court.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 711);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "人民法院提起行政诉讼，但本决定不停止执行，法";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 745);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 101;
            this.label11.Text = "律另有规定的除外。";
            // 
            // HandleDate
            // 
            this.HandleDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HandleDate.CustomFormat = "yyyy年M月d日";
            this.HandleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HandleDate.Location = new System.Drawing.Point(579, 803);
            this.HandleDate.Name = "HandleDate";
            this.HandleDate.Size = new System.Drawing.Size(168, 26);
            this.HandleDate.TabIndex = 105;
            this.HandleDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(519, 778);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 110;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditSealThingHandle
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEditSealThingHandle";
            this.Size = new System.Drawing.Size(886, 900);
            this.Load += new System.EventHandler(this.frmEditSealThingHandle_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableTextTitle DocTitle;
        private EnforceUI.TableAutoCompleteTextBox CompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker SealDate;
        private EnforceUI.TableDateTimePicker HandleDate;
        private EnforceUI.TableAutoCompleteTextBox ManageDepartment;
        private EnforceUI.TableAutoCompleteTextBox Court;
        private EnforceUI.TableAutoCompleteTextBox Government;
        private EnforceUI.TableTextTitle ThingCheckNo;
        private EnforceUI.TableRichTextBox SealResult;
        private EnforceUI.TableRichTextBox SealContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableTextTitle DocManageArea;
    }
}

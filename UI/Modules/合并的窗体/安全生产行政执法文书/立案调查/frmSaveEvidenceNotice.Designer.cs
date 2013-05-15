namespace EnforceForm
{
    partial class frmSaveEvidenceNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEvidenceNotice));
            this.DocTitle = new EnforceUI.TableTextTitle(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.QFirstPerson = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.IllegalTypeName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.FieldECompanyName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.ToTime = new EnforceUI.TableDateTimePicker(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DocManageArea = new EnforceUI.TableTextTitle(this.components);
            this.FillDate = new EnforceUI.TableDateTimePicker(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.DocManageArea);
            this.panelContent.Controls.Add(this.FillDate);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label13);
            this.panelContent.Controls.Add(this.label16);
            this.panelContent.Controls.Add(this.DocTitle);
            this.panelContent.Controls.Add(this.label31);
            this.panelContent.Controls.Add(this.QFirstPerson);
            this.panelContent.Controls.Add(this.IllegalTypeName);
            this.panelContent.Controls.Add(this.FieldECompanyName);
            this.panelContent.Controls.Add(this.ToTime);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(824, 654);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 729);
            this.panel1.Size = new System.Drawing.Size(824, 47);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(824, 75);
            this.header1.Title = "先行登记保存证据通知书 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // DocTitle
            // 
            this.DocTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocTitle.BackColor = System.Drawing.Color.White;
            this.DocTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocTitle.ControlText = "()安监管先保通〔〕执法-1号";
            this.DocTitle.Location = new System.Drawing.Point(190, 142);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(358, 19);
            this.DocTitle.TabIndex = 2;
            this.DocTitle.Text = "()安监管先保通〔〕执法-1号";
            this.DocTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(582, 459);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 16);
            this.label31.TabIndex = 15;
            this.label31.Text = "接受对先行";
            // 
            // QFirstPerson
            // 
            this.QFirstPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QFirstPerson.BackColor = System.Drawing.Color.White;
            this.QFirstPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson.ControlText = "";
            this.QFirstPerson.Location = new System.Drawing.Point(245, 459);
            this.QFirstPerson.Name = "QFirstPerson";
            this.QFirstPerson.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QFirstPerson.PopupOffset = new System.Drawing.Point(12, 0);
            this.QFirstPerson.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.QFirstPerson.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.QFirstPerson.PopupWidth = 300;
            this.QFirstPerson.Size = new System.Drawing.Size(331, 19);
            this.QFirstPerson.TabIndex = 14;
            // 
            // IllegalTypeName
            // 
            this.IllegalTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IllegalTypeName.BackColor = System.Drawing.Color.White;
            this.IllegalTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.ControlText = "";
            this.IllegalTypeName.Location = new System.Drawing.Point(201, 240);
            this.IllegalTypeName.Name = "IllegalTypeName";
            this.IllegalTypeName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IllegalTypeName.PopupOffset = new System.Drawing.Point(12, 0);
            this.IllegalTypeName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.IllegalTypeName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.IllegalTypeName.PopupWidth = 300;
            this.IllegalTypeName.Size = new System.Drawing.Size(326, 19);
            this.IllegalTypeName.TabIndex = 6;
            // 
            // FieldECompanyName
            // 
            this.FieldECompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FieldECompanyName.BackColor = System.Drawing.Color.White;
            this.FieldECompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.ControlText = "";
            this.FieldECompanyName.Location = new System.Drawing.Point(47, 191);
            this.FieldECompanyName.Name = "FieldECompanyName";
            this.FieldECompanyName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FieldECompanyName.PopupOffset = new System.Drawing.Point(12, 0);
            this.FieldECompanyName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.FieldECompanyName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FieldECompanyName.PopupWidth = 300;
            this.FieldECompanyName.Size = new System.Drawing.Size(275, 19);
            this.FieldECompanyName.TabIndex = 3;
            // 
            // ToTime
            // 
            this.ToTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToTime.CustomFormat = "yyyy年M月d日";
            this.ToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTime.Location = new System.Drawing.Point(44, 454);
            this.ToTime.Name = "ToTime";
            this.ToTime.Size = new System.Drawing.Size(154, 26);
            this.ToTime.TabIndex = 12;
            this.ToTime.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "行为。为确保调查取";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "你（单位）涉嫌";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(254, 115);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(229, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "先行登记保存证据通知书";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-6, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 229;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(265, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(648, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "证工作，依据《中华人民共和国行政处罚法》第三十七条第二款的规定，本行政机关决定对";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(600, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "你（单位）的有关证据（证据名称、数量等详见附后清单）采取先行登记保存措施。";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(77, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "注意事项：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "1、对先行登记保存的证据，本行政机关将在七日内依法作出处理决定。请你（单位）";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "日到";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "登记保存证据的处理决定。";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(568, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "保管的义务，不得有短缺、灭失、损毁或擅自移动等改变证据物品的任何行为。";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(608, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "2、对就地先行登记保存的证据，在本行政机关作出处理决定前，你（单位）负有妥善";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "3、请核对证据清单后，签名确认。";
            // 
            // DocManageArea
            // 
            this.DocManageArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DocManageArea.BackColor = System.Drawing.Color.White;
            this.DocManageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocManageArea.ControlText = "安全生产监督管理局";
            this.DocManageArea.Location = new System.Drawing.Point(428, 664);
            this.DocManageArea.Name = "DocManageArea";
            this.DocManageArea.Size = new System.Drawing.Size(280, 19);
            this.DocManageArea.TabIndex = 20;
            this.DocManageArea.Text = "安全生产监督管理局";
            this.DocManageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FillDate
            // 
            this.FillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillDate.CustomFormat = "yyyy年M月d日";
            this.FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FillDate.Location = new System.Drawing.Point(502, 699);
            this.FillDate.Name = "FillDate";
            this.FillDate.Size = new System.Drawing.Size(158, 26);
            this.FillDate.TabIndex = 21;
            this.FillDate.Value = new System.DateTime(2013, 3, 10, 20, 58, 7, 346);
            // 
            // frmSaveEvidenceNotice
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSaveEvidenceNotice";
            this.Size = new System.Drawing.Size(824, 776);
            this.Load += new System.EventHandler(this.frmSaveEvidenceNotice_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableTextTitle DocTitle;
        private System.Windows.Forms.Label label31;
        private EnforceUI.TableAutoCompleteTextBox QFirstPerson;
        private EnforceUI.TableAutoCompleteTextBox IllegalTypeName;
        private EnforceUI.TableAutoCompleteTextBox FieldECompanyName;
        private EnforceUI.TableDateTimePicker ToTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableTextTitle DocManageArea;
        private EnforceUI.TableDateTimePicker FillDate;
    }
}

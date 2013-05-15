namespace EnforceForm
{
    partial class frmSaveEvidenceProceAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEvidenceProceAudit));
            this.UndertakerUserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UndertakerOpinion = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReasonBasis = new EnforceUI.TableRichTextBox(this.components);
            this.UndertakerUserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SamplingID = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordCasePeopleInfo = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.PutOnRecordCaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UndertakerData = new EnforceUI.TableDateTimePicker(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PutOnRecordCaseContent = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panelContent.Controls.Add(this.UndertakerUserName2);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.UndertakerUserName1);
            this.panelContent.Controls.Add(this.label14);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.SamplingID);
            this.panelContent.Controls.Add(this.PutOnRecordCaseContent);
            this.panelContent.Controls.Add(this.PutOnRecordCasePeopleInfo);
            this.panelContent.Controls.Add(this.PutOnRecordCaseName);
            this.panelContent.Controls.Add(this.UndertakerData);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(807, 574);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Size = new System.Drawing.Size(807, 43);
            this.panel1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(807, 75);
            this.header1.Title = "先行登记保存证据处理审批表 > 编辑";
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // UndertakerUserName2
            // 
            this.UndertakerUserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName2.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.ControlText = "";
            this.UndertakerUserName2.Location = new System.Drawing.Point(229, 609);
            this.UndertakerUserName2.Name = "UndertakerUserName2";
            this.UndertakerUserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName2.PopupWidth = 300;
            this.UndertakerUserName2.Size = new System.Drawing.Size(109, 19);
            this.UndertakerUserName2.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.UndertakerOpinion);
            this.groupBox2.Location = new System.Drawing.Point(41, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 127);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "承办人意见：";
            // 
            // UndertakerOpinion
            // 
            this.UndertakerOpinion.ControlText = "";
            this.UndertakerOpinion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndertakerOpinion.Location = new System.Drawing.Point(3, 22);
            this.UndertakerOpinion.Name = "UndertakerOpinion";
            this.UndertakerOpinion.Size = new System.Drawing.Size(626, 102);
            this.UndertakerOpinion.TabIndex = 0;
            this.UndertakerOpinion.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.ReasonBasis);
            this.groupBox1.Location = new System.Drawing.Point(41, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提请理由及依据：";
            // 
            // ReasonBasis
            // 
            this.ReasonBasis.ControlText = "";
            this.ReasonBasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReasonBasis.Location = new System.Drawing.Point(3, 22);
            this.ReasonBasis.Name = "ReasonBasis";
            this.ReasonBasis.Size = new System.Drawing.Size(626, 102);
            this.ReasonBasis.TabIndex = 0;
            this.ReasonBasis.Text = "";
            // 
            // UndertakerUserName1
            // 
            this.UndertakerUserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerUserName1.BackColor = System.Drawing.Color.White;
            this.UndertakerUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.ControlText = "";
            this.UndertakerUserName1.Location = new System.Drawing.Point(105, 608);
            this.UndertakerUserName1.Name = "UndertakerUserName1";
            this.UndertakerUserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UndertakerUserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UndertakerUserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UndertakerUserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UndertakerUserName1.PopupWidth = 300;
            this.UndertakerUserName1.Size = new System.Drawing.Size(95, 19);
            this.UndertakerUserName1.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 608);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "、";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 608);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "承办人：";
            // 
            // SamplingID
            // 
            this.SamplingID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SamplingID.BackColor = System.Drawing.Color.White;
            this.SamplingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingID.ControlText = "";
            this.SamplingID.Location = new System.Drawing.Point(174, 288);
            this.SamplingID.Name = "SamplingID";
            this.SamplingID.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SamplingID.PopupOffset = new System.Drawing.Point(12, 0);
            this.SamplingID.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SamplingID.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SamplingID.PopupWidth = 300;
            this.SamplingID.Size = new System.Drawing.Size(496, 19);
            this.SamplingID.TabIndex = 9;
            // 
            // PutOnRecordCasePeopleInfo
            // 
            this.PutOnRecordCasePeopleInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCasePeopleInfo.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCasePeopleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCasePeopleInfo.ControlText = "";
            this.PutOnRecordCasePeopleInfo.Location = new System.Drawing.Point(182, 198);
            this.PutOnRecordCasePeopleInfo.Name = "PutOnRecordCasePeopleInfo";
            this.PutOnRecordCasePeopleInfo.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCasePeopleInfo.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCasePeopleInfo.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCasePeopleInfo.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCasePeopleInfo.PopupWidth = 300;
            this.PutOnRecordCasePeopleInfo.Size = new System.Drawing.Size(491, 19);
            this.PutOnRecordCasePeopleInfo.TabIndex = 5;
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseName.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.ControlText = "";
            this.PutOnRecordCaseName.Location = new System.Drawing.Point(124, 153);
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseName.PopupWidth = 300;
            this.PutOnRecordCaseName.Size = new System.Drawing.Size(546, 19);
            this.PutOnRecordCaseName.TabIndex = 3;
            this.PutOnRecordCaseName.SelectedValueChangedEvent += new EnforceUI.Input.AutoCompleteTextBox.SelectedValueChangedEventHandeler(this.PutOnRecordCaseName_SelectedValueChangedEvent);
            // 
            // UndertakerData
            // 
            this.UndertakerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UndertakerData.CustomFormat = "yyyy年M月d日";
            this.UndertakerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UndertakerData.Location = new System.Drawing.Point(479, 617);
            this.UndertakerData.Name = "UndertakerData";
            this.UndertakerData.Size = new System.Drawing.Size(191, 26);
            this.UndertakerData.TabIndex = 17;
            this.UndertakerData.Value = new System.DateTime(2013, 3, 10, 20, 5, 4, 998);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "证据名称及数量：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "当事人及基本情况：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "案件名称：";
            // 
            // headerLabel2
            // 
            this.headerLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel2.Location = new System.Drawing.Point(225, 108);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(269, 20);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "先行登记保存证据处理审批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(-12, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 282;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(259, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "案件基本情况：";
            // 
            // PutOnRecordCaseContent
            // 
            this.PutOnRecordCaseContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PutOnRecordCaseContent.BackColor = System.Drawing.Color.White;
            this.PutOnRecordCaseContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseContent.ControlText = "";
            this.PutOnRecordCaseContent.Location = new System.Drawing.Point(182, 242);
            this.PutOnRecordCaseContent.Name = "PutOnRecordCaseContent";
            this.PutOnRecordCaseContent.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PutOnRecordCaseContent.PopupOffset = new System.Drawing.Point(12, 0);
            this.PutOnRecordCaseContent.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.PutOnRecordCaseContent.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PutOnRecordCaseContent.PopupWidth = 300;
            this.PutOnRecordCaseContent.Size = new System.Drawing.Size(491, 19);
            this.PutOnRecordCaseContent.TabIndex = 7;
            // 
            // frmSaveEvidenceProceAudit
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSaveEvidenceProceAudit";
            this.Size = new System.Drawing.Size(807, 692);
            this.Load += new System.EventHandler(this.frmSaveEvidenceProceAudit_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName2;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox UndertakerOpinion;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox ReasonBasis;
        private EnforceUI.TableAutoCompleteTextBox UndertakerUserName1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableAutoCompleteTextBox SamplingID;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCasePeopleInfo;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox PutOnRecordCaseContent;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableDateTimePicker UndertakerData;

    }
}

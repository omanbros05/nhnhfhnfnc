namespace EnforceForm
{
    partial class frmEditSealThingHandleApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSealThingHandleApproval));
            this.headerLabel2 = new EnforceUI.HeaderLabel(this.components);
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.CaseName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartyBaseInfo = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SealDecideNo = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CaseSurveyInfo = new EnforceUI.TableRichTextBox(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UserReason = new EnforceUI.TableRichTextBox(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.HandleDate = new EnforceUI.TableDateTimePicker(this.components);
            this.UserName2 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.UserName1 = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panelContent.Controls.Add(this.UserName2);
            this.panelContent.Controls.Add(this.UserName1);
            this.panelContent.Controls.Add(this.HandleDate);
            this.panelContent.Controls.Add(this.label18);
            this.panelContent.Controls.Add(this.groupBox4);
            this.panelContent.Controls.Add(this.groupBox3);
            this.panelContent.Controls.Add(this.groupBox2);
            this.panelContent.Controls.Add(this.groupBox1);
            this.panelContent.Controls.Add(this.CaseName);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.headerLabel2);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Size = new System.Drawing.Size(886, 880);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 955);
            this.panel1.Size = new System.Drawing.Size(886, 45);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(886, 75);
            this.header1.Title = "查封或扣押物品处理审批表 > 编辑";
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
            this.headerLabel2.Location = new System.Drawing.Point(261, 115);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(269, 20);
            this.headerLabel2.TabIndex = 6;
            this.headerLabel2.Text = "查封（扣押）物品处理审批表";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(20, 105);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 7;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(291, 80);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(209, 20);
            this.headerLabel1.TabIndex = 5;
            this.headerLabel1.Text = "安全生产行政执法文书";
            // 
            // CaseName
            // 
            this.CaseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaseName.BackColor = System.Drawing.Color.White;
            this.CaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.ControlText = "";
            this.CaseName.Location = new System.Drawing.Point(146, 156);
            this.CaseName.Name = "CaseName";
            this.CaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.CaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseName.PopupWidth = 300;
            this.CaseName.Size = new System.Drawing.Size(578, 19);
            this.CaseName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "案件名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.PartyBaseInfo);
            this.groupBox1.Location = new System.Drawing.Point(60, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 141);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当事人及基本情况:";
            // 
            // PartyBaseInfo
            // 
            this.PartyBaseInfo.ControlText = "";
            this.PartyBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartyBaseInfo.Location = new System.Drawing.Point(3, 22);
            this.PartyBaseInfo.Name = "PartyBaseInfo";
            this.PartyBaseInfo.Size = new System.Drawing.Size(658, 116);
            this.PartyBaseInfo.TabIndex = 0;
            this.PartyBaseInfo.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.SealDecideNo);
            this.groupBox2.Location = new System.Drawing.Point(57, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 141);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查封（扣押）决定书文号:";
            // 
            // SealDecideNo
            // 
            this.SealDecideNo.ControlText = "";
            this.SealDecideNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SealDecideNo.Location = new System.Drawing.Point(3, 22);
            this.SealDecideNo.Name = "SealDecideNo";
            this.SealDecideNo.Size = new System.Drawing.Size(658, 116);
            this.SealDecideNo.TabIndex = 0;
            this.SealDecideNo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.CaseSurveyInfo);
            this.groupBox3.Location = new System.Drawing.Point(57, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 175);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "案件调查情况:";
            // 
            // CaseSurveyInfo
            // 
            this.CaseSurveyInfo.ControlText = "";
            this.CaseSurveyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaseSurveyInfo.Location = new System.Drawing.Point(3, 22);
            this.CaseSurveyInfo.Name = "CaseSurveyInfo";
            this.CaseSurveyInfo.Size = new System.Drawing.Size(658, 150);
            this.CaseSurveyInfo.TabIndex = 0;
            this.CaseSurveyInfo.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.UserReason);
            this.groupBox4.Location = new System.Drawing.Point(54, 681);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 175);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "承办人意见:";
            // 
            // UserReason
            // 
            this.UserReason.ControlText = "";
            this.UserReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserReason.Location = new System.Drawing.Point(3, 22);
            this.UserReason.Name = "UserReason";
            this.UserReason.Size = new System.Drawing.Size(658, 150);
            this.UserReason.TabIndex = 0;
            this.UserReason.Text = "";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 888);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "承办人：";
            // 
            // HandleDate
            // 
            this.HandleDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HandleDate.CustomFormat = "yyyy年M月d日";
            this.HandleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HandleDate.Location = new System.Drawing.Point(547, 915);
            this.HandleDate.Name = "HandleDate";
            this.HandleDate.Size = new System.Drawing.Size(168, 26);
            this.HandleDate.TabIndex = 60;
            this.HandleDate.Value = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            // 
            // UserName2
            // 
            this.UserName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName2.BackColor = System.Drawing.Color.White;
            this.UserName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.ControlText = "";
            this.UserName2.Location = new System.Drawing.Point(324, 888);
            this.UserName2.Name = "UserName2";
            this.UserName2.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName2.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName2.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName2.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName2.PopupWidth = 300;
            this.UserName2.Size = new System.Drawing.Size(186, 19);
            this.UserName2.TabIndex = 113;
            // 
            // UserName1
            // 
            this.UserName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserName1.BackColor = System.Drawing.Color.White;
            this.UserName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.ControlText = "";
            this.UserName1.Location = new System.Drawing.Point(130, 888);
            this.UserName1.Name = "UserName1";
            this.UserName1.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName1.PopupOffset = new System.Drawing.Point(12, 0);
            this.UserName1.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UserName1.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserName1.PopupWidth = 300;
            this.UserName1.Size = new System.Drawing.Size(186, 19);
            this.UserName1.TabIndex = 112;
            // 
            // frmEditSealThingHandleApproval
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEditSealThingHandleApproval";
            this.Size = new System.Drawing.Size(886, 1000);
            this.Load += new System.EventHandler(this.frmSealThingHandleApproval_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.HeaderLabel headerLabel2;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
        private EnforceUI.TableAutoCompleteTextBox CaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnforceUI.TableRichTextBox PartyBaseInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private EnforceUI.TableRichTextBox UserReason;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnforceUI.TableRichTextBox CaseSurveyInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnforceUI.TableRichTextBox SealDecideNo;
        private System.Windows.Forms.Label label18;
        private EnforceUI.TableDateTimePicker HandleDate;
        private EnforceUI.TableAutoCompleteTextBox UserName2;
        private EnforceUI.TableAutoCompleteTextBox UserName1;
    }
}

namespace EnforceForm
{
    partial class frmChemicalsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChemicalsList));
            this.ChemicalsAlias = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.ChemicalsUN = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ChemicalsNumber = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ChemicalsName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
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
            this.panelContent.Controls.Add(this.ChemicalsAlias);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.ChemicalsUN);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.ChemicalsNumber);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.ChemicalsName);
            this.panelContent.Size = new System.Drawing.Size(886, 290);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 365);
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
            // ChemicalsAlias
            // 
            this.ChemicalsAlias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalsAlias.BackColor = System.Drawing.Color.White;
            this.ChemicalsAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsAlias.ControlText = "";
            this.ChemicalsAlias.Location = new System.Drawing.Point(169, 227);
            this.ChemicalsAlias.Name = "ChemicalsAlias";
            this.ChemicalsAlias.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsAlias.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalsAlias.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalsAlias.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalsAlias.PopupWidth = 300;
            this.ChemicalsAlias.Size = new System.Drawing.Size(585, 19);
            this.ChemicalsAlias.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 142;
            this.label9.Text = "别名：";
            // 
            // ChemicalsUN
            // 
            this.ChemicalsUN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalsUN.BackColor = System.Drawing.Color.White;
            this.ChemicalsUN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsUN.ControlText = "";
            this.ChemicalsUN.Location = new System.Drawing.Point(169, 270);
            this.ChemicalsUN.Name = "ChemicalsUN";
            this.ChemicalsUN.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsUN.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalsUN.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalsUN.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalsUN.PopupWidth = 300;
            this.ChemicalsUN.Size = new System.Drawing.Size(585, 19);
            this.ChemicalsUN.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "UN号：";
            // 
            // ChemicalsNumber
            // 
            this.ChemicalsNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalsNumber.BackColor = System.Drawing.Color.White;
            this.ChemicalsNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsNumber.ControlText = "";
            this.ChemicalsNumber.Location = new System.Drawing.Point(169, 187);
            this.ChemicalsNumber.Name = "ChemicalsNumber";
            this.ChemicalsNumber.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsNumber.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalsNumber.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalsNumber.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalsNumber.PopupWidth = 300;
            this.ChemicalsNumber.Size = new System.Drawing.Size(585, 19);
            this.ChemicalsNumber.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "编号：";
            // 
            // ChemicalsName
            // 
            this.ChemicalsName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalsName.BackColor = System.Drawing.Color.White;
            this.ChemicalsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsName.ControlText = "";
            this.ChemicalsName.Location = new System.Drawing.Point(169, 152);
            this.ChemicalsName.Name = "ChemicalsName";
            this.ChemicalsName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalsName.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalsName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalsName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalsName.PopupWidth = 300;
            this.ChemicalsName.Size = new System.Drawing.Size(585, 19);
            this.ChemicalsName.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "名称：";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(64, 101);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 120;
            this.tableLine1.TabStop = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(335, 78);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(149, 20);
            this.headerLabel1.TabIndex = 119;
            this.headerLabel1.Text = "危险化学品目录";
            // 
            // frmChemicalsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmChemicalsList";
            this.Size = new System.Drawing.Size(886, 400);
            this.Load += new System.EventHandler(this.frmChemicalsList_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox ChemicalsAlias;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableAutoCompleteTextBox ChemicalsUN;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableAutoCompleteTextBox ChemicalsNumber;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableAutoCompleteTextBox ChemicalsName;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.HeaderLabel headerLabel1;
    }
}

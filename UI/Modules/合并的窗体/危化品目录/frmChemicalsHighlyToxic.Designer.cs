namespace EnforceForm
{
    partial class frmChemicalsHighlyToxic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChemicalsHighlyToxic));
            this.ChemicalNameEn = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tableLine1 = new EnforceUI.TableLine(this.components);
            this.ChemicalAliasEn = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.headerLabel1 = new EnforceUI.HeaderLabel(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChemicalAlias = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ChemicalName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.Formula = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CAS = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.UN = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LimitedRange = new EnforceUI.TableRichTextBox(this.components);
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
            this.panelContent.Controls.Add(this.LimitedRange);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.UN);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.CAS);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.Formula);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.ChemicalNameEn);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.tableLine1);
            this.panelContent.Controls.Add(this.ChemicalAliasEn);
            this.panelContent.Controls.Add(this.headerLabel1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.ChemicalAlias);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.ChemicalName);
            this.panelContent.Size = new System.Drawing.Size(886, 540);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 615);
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
            // ChemicalNameEn
            // 
            this.ChemicalNameEn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalNameEn.BackColor = System.Drawing.Color.White;
            this.ChemicalNameEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalNameEn.ControlText = "";
            this.ChemicalNameEn.Location = new System.Drawing.Point(176, 209);
            this.ChemicalNameEn.Name = "ChemicalNameEn";
            this.ChemicalNameEn.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalNameEn.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalNameEn.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalNameEn.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalNameEn.PopupWidth = 300;
            this.ChemicalNameEn.Size = new System.Drawing.Size(567, 19);
            this.ChemicalNameEn.TabIndex = 153;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "化学名(英文)：";
            // 
            // tableLine1
            // 
            this.tableLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLine1.BackgroundImage")));
            this.tableLine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLine1.Location = new System.Drawing.Point(47, 99);
            this.tableLine1.MaximumSize = new System.Drawing.Size(900, 4);
            this.tableLine1.MinimumSize = new System.Drawing.Size(100, 4);
            this.tableLine1.Name = "tableLine1";
            this.tableLine1.Size = new System.Drawing.Size(750, 4);
            this.tableLine1.TabIndex = 147;
            this.tableLine1.TabStop = false;
            // 
            // ChemicalAliasEn
            // 
            this.ChemicalAliasEn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalAliasEn.BackColor = System.Drawing.Color.White;
            this.ChemicalAliasEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalAliasEn.ControlText = "";
            this.ChemicalAliasEn.Location = new System.Drawing.Point(176, 252);
            this.ChemicalAliasEn.Name = "ChemicalAliasEn";
            this.ChemicalAliasEn.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalAliasEn.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalAliasEn.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalAliasEn.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalAliasEn.PopupWidth = 300;
            this.ChemicalAliasEn.Size = new System.Drawing.Size(567, 19);
            this.ChemicalAliasEn.TabIndex = 151;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headerLabel1.Location = new System.Drawing.Point(318, 76);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(149, 20);
            this.headerLabel1.TabIndex = 145;
            this.headerLabel1.Text = "剧毒化学品目录";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 150;
            this.label4.Text = "别名(英文)：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "别名：";
            // 
            // ChemicalAlias
            // 
            this.ChemicalAlias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalAlias.BackColor = System.Drawing.Color.White;
            this.ChemicalAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalAlias.ControlText = "";
            this.ChemicalAlias.Location = new System.Drawing.Point(176, 169);
            this.ChemicalAlias.Name = "ChemicalAlias";
            this.ChemicalAlias.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalAlias.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalAlias.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalAlias.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalAlias.PopupWidth = 300;
            this.ChemicalAlias.Size = new System.Drawing.Size(567, 19);
            this.ChemicalAlias.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "化学名：";
            // 
            // ChemicalName
            // 
            this.ChemicalName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChemicalName.BackColor = System.Drawing.Color.White;
            this.ChemicalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalName.ControlText = "";
            this.ChemicalName.Location = new System.Drawing.Point(176, 134);
            this.ChemicalName.Name = "ChemicalName";
            this.ChemicalName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChemicalName.PopupOffset = new System.Drawing.Point(12, 0);
            this.ChemicalName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ChemicalName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChemicalName.PopupWidth = 300;
            this.ChemicalName.Size = new System.Drawing.Size(567, 19);
            this.ChemicalName.TabIndex = 146;
            // 
            // Formula
            // 
            this.Formula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Formula.BackColor = System.Drawing.Color.White;
            this.Formula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Formula.ControlText = "";
            this.Formula.Location = new System.Drawing.Point(175, 294);
            this.Formula.Name = "Formula";
            this.Formula.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Formula.PopupOffset = new System.Drawing.Point(12, 0);
            this.Formula.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Formula.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Formula.PopupWidth = 300;
            this.Formula.Size = new System.Drawing.Size(567, 19);
            this.Formula.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 154;
            this.label2.Text = "分子式：";
            // 
            // CAS
            // 
            this.CAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CAS.BackColor = System.Drawing.Color.White;
            this.CAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CAS.ControlText = "";
            this.CAS.Location = new System.Drawing.Point(176, 339);
            this.CAS.Name = "CAS";
            this.CAS.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CAS.PopupOffset = new System.Drawing.Point(12, 0);
            this.CAS.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.CAS.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CAS.PopupWidth = 300;
            this.CAS.Size = new System.Drawing.Size(567, 19);
            this.CAS.TabIndex = 157;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 156;
            this.label3.Text = "CAS号：";
            // 
            // UN
            // 
            this.UN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UN.BackColor = System.Drawing.Color.White;
            this.UN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UN.ControlText = "";
            this.UN.Location = new System.Drawing.Point(176, 388);
            this.UN.Name = "UN";
            this.UN.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UN.PopupOffset = new System.Drawing.Point(12, 0);
            this.UN.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.UN.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UN.PopupWidth = 300;
            this.UN.Size = new System.Drawing.Size(567, 19);
            this.UN.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 158;
            this.label5.Text = "UN号：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 160;
            this.label7.Text = "受限范围：";
            // 
            // LimitedRange
            // 
            this.LimitedRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LimitedRange.ControlText = "";
            this.LimitedRange.Location = new System.Drawing.Point(174, 433);
            this.LimitedRange.Name = "LimitedRange";
            this.LimitedRange.Size = new System.Drawing.Size(567, 101);
            this.LimitedRange.TabIndex = 161;
            this.LimitedRange.Text = "";
            // 
            // frmChemicalsHighlyToxic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmChemicalsHighlyToxic";
            this.Size = new System.Drawing.Size(886, 650);
            this.Load += new System.EventHandler(this.frmChemicalsHighlyToxic_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableAutoCompleteTextBox ChemicalNameEn;
        private System.Windows.Forms.Label label9;
        private EnforceUI.TableLine tableLine1;
        private EnforceUI.TableAutoCompleteTextBox ChemicalAliasEn;
        private EnforceUI.HeaderLabel headerLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableAutoCompleteTextBox ChemicalAlias;
        private System.Windows.Forms.Label label1;
        private EnforceUI.TableAutoCompleteTextBox ChemicalName;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox UN;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableAutoCompleteTextBox CAS;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableAutoCompleteTextBox Formula;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableRichTextBox LimitedRange;
    }
}

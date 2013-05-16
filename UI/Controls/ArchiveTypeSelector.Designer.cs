namespace Maleos.Controls
{
    partial class ArchiveTypeSelector
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
            this.BtnYes = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.btnModType = new DevExpress.XtraEditors.SimpleButton();
            this.coolTbox = new EnforceUI.Input.CoolTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(299, 387);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 46);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "确定";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(380, 387);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 46);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxControl1.Appearance.Options.UseFont = true;
            this.listBoxControl1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.listBoxControl1.HotTrackItems = true;
            this.listBoxControl1.ItemHeight = 32;
            this.listBoxControl1.Location = new System.Drawing.Point(36, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(375, 296);
            this.listBoxControl1.TabIndex = 2;
            // 
            // btnModType
            // 
            this.btnModType.Location = new System.Drawing.Point(36, 347);
            this.btnModType.Name = "btnModType";
            this.btnModType.Size = new System.Drawing.Size(85, 46);
            this.btnModType.TabIndex = 3;
            this.btnModType.Text = "新增档案名称";
            this.btnModType.Click += new System.EventHandler(this.btnModType_Click);
            // 
            // coolTbox
            // 
            this.coolTbox.BackColor = System.Drawing.SystemColors.Window;
            this.coolTbox.BorderColor = System.Drawing.Color.DarkGray;
            this.coolTbox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolTbox.Location = new System.Drawing.Point(36, 314);
            this.coolTbox.Name = "coolTbox";
            this.coolTbox.Padding = new System.Windows.Forms.Padding(4);
            this.coolTbox.PopupWidth = 120;
            this.coolTbox.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.coolTbox.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.coolTbox.Size = new System.Drawing.Size(375, 27);
            this.coolTbox.TabIndex = 4;
            // 
            // ArchiveTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(467, 442);
            this.Controls.Add(this.coolTbox);
            this.Controls.Add(this.btnModType);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiveTypeSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择归档位置";
            this.Resize += new System.EventHandler(this.ArchiveTypeSelector_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnYes;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnModType;
        private EnforceUI.Input.CoolTextBox coolTbox;
    }
}
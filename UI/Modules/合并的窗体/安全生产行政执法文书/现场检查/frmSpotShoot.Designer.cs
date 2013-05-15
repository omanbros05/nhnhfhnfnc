namespace EnforceForm
{
    partial class frmSpotShoot
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
            this.pictureBoxShoot1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShoot2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShootAddress1 = new EnforceUI.TableTextBox(this.components);
            this.PhotoIllustr1 = new EnforceUI.TableTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.PhotoIllustr2 = new EnforceUI.TableTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ShootAddress2 = new EnforceUI.TableTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShootDate = new EnforceUI.TableDateTimePicker(this.components);
            this.SpotName = new EnforceUI.TableAutoCompleteTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsertImage1 = new System.Windows.Forms.Button();
            this.buttonInsertImage2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoot2)).BeginInit();
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
            this.panelContent.Controls.Add(this.buttonInsertImage2);
            this.panelContent.Controls.Add(this.ShootDate);
            this.panelContent.Controls.Add(this.buttonInsertImage1);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.PhotoIllustr2);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.ShootAddress2);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.PhotoIllustr1);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.ShootAddress1);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.SpotName);
            this.panelContent.Controls.Add(this.pictureBoxShoot2);
            this.panelContent.Controls.Add(this.pictureBoxShoot1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Size = new System.Drawing.Size(1123, 540);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Size = new System.Drawing.Size(1123, 44);
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Size = new System.Drawing.Size(1123, 75);
            this.header1.Title = "现场照片取证 > 编辑";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // buttonShowExample
            // 
            this.buttonShowExample.Click += new System.EventHandler(this.buttonShowExample_Click);
            // 
            // pictureBoxShoot1
            // 
            this.pictureBoxShoot1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShoot1.BackgroundImage = global::Maleos.Properties.Resources.请插入图片;
            this.pictureBoxShoot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShoot1.InitialImage = null;
            this.pictureBoxShoot1.Location = new System.Drawing.Point(21, 182);
            this.pictureBoxShoot1.Name = "pictureBoxShoot1";
            this.pictureBoxShoot1.Size = new System.Drawing.Size(445, 301);
            this.pictureBoxShoot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShoot1.TabIndex = 4;
            this.pictureBoxShoot1.TabStop = false;
            // 
            // pictureBoxShoot2
            // 
            this.pictureBoxShoot2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShoot2.BackgroundImage = global::Maleos.Properties.Resources.请插入图片;
            this.pictureBoxShoot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShoot2.Location = new System.Drawing.Point(489, 182);
            this.pictureBoxShoot2.Name = "pictureBoxShoot2";
            this.pictureBoxShoot2.Size = new System.Drawing.Size(423, 301);
            this.pictureBoxShoot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShoot2.TabIndex = 5;
            this.pictureBoxShoot2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "拍摄地点:";
            // 
            // ShootAddress1
            // 
            this.ShootAddress1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShootAddress1.BackColor = System.Drawing.Color.White;
            this.ShootAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShootAddress1.ControlText = "";
            this.ShootAddress1.Location = new System.Drawing.Point(128, 525);
            this.ShootAddress1.Name = "ShootAddress1";
            this.ShootAddress1.Size = new System.Drawing.Size(301, 19);
            this.ShootAddress1.TabIndex = 8;
            // 
            // PhotoIllustr1
            // 
            this.PhotoIllustr1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhotoIllustr1.BackColor = System.Drawing.Color.White;
            this.PhotoIllustr1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhotoIllustr1.ControlText = "";
            this.PhotoIllustr1.Location = new System.Drawing.Point(128, 550);
            this.PhotoIllustr1.Name = "PhotoIllustr1";
            this.PhotoIllustr1.Size = new System.Drawing.Size(301, 19);
            this.PhotoIllustr1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "图片说明:";
            // 
            // PhotoIllustr2
            // 
            this.PhotoIllustr2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhotoIllustr2.BackColor = System.Drawing.Color.White;
            this.PhotoIllustr2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhotoIllustr2.ControlText = "";
            this.PhotoIllustr2.Location = new System.Drawing.Point(593, 553);
            this.PhotoIllustr2.Name = "PhotoIllustr2";
            this.PhotoIllustr2.Size = new System.Drawing.Size(301, 19);
            this.PhotoIllustr2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "图片说明:";
            // 
            // ShootAddress2
            // 
            this.ShootAddress2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShootAddress2.BackColor = System.Drawing.Color.White;
            this.ShootAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShootAddress2.ControlText = "";
            this.ShootAddress2.Location = new System.Drawing.Point(593, 528);
            this.ShootAddress2.Name = "ShootAddress2";
            this.ShootAddress2.Size = new System.Drawing.Size(301, 19);
            this.ShootAddress2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "拍摄地点:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "拍摄时间:";
            // 
            // ShootDate
            // 
            this.ShootDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShootDate.CustomFormat = "yyyy年M月d日";
            this.ShootDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShootDate.Location = new System.Drawing.Point(128, 587);
            this.ShootDate.Name = "ShootDate";
            this.ShootDate.Size = new System.Drawing.Size(158, 26);
            this.ShootDate.TabIndex = 16;
            // 
            // SpotName
            // 
            this.SpotName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpotName.BackColor = System.Drawing.Color.White;
            this.SpotName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpotName.ControlText = "";
            this.SpotName.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SpotName.Location = new System.Drawing.Point(163, 120);
            this.SpotName.Name = "SpotName";
            this.SpotName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpotName.PopupOffset = new System.Drawing.Point(12, 0);
            this.SpotName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SpotName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SpotName.PopupWidth = 300;
            this.SpotName.Size = new System.Drawing.Size(332, 34);
            this.SpotName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(501, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "现场检查图片";
            // 
            // buttonInsertImage1
            // 
            this.buttonInsertImage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInsertImage1.Location = new System.Drawing.Point(372, 489);
            this.buttonInsertImage1.Name = "buttonInsertImage1";
            this.buttonInsertImage1.Size = new System.Drawing.Size(94, 23);
            this.buttonInsertImage1.TabIndex = 17;
            this.buttonInsertImage1.Text = "插入图片";
            this.buttonInsertImage1.UseVisualStyleBackColor = true;
            this.buttonInsertImage1.Click += new System.EventHandler(this.buttonInsertImage1_Click);
            // 
            // buttonInsertImage2
            // 
            this.buttonInsertImage2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInsertImage2.Location = new System.Drawing.Point(818, 489);
            this.buttonInsertImage2.Name = "buttonInsertImage2";
            this.buttonInsertImage2.Size = new System.Drawing.Size(94, 23);
            this.buttonInsertImage2.TabIndex = 18;
            this.buttonInsertImage2.Text = "插入图片";
            this.buttonInsertImage2.UseVisualStyleBackColor = true;
            this.buttonInsertImage2.Click += new System.EventHandler(this.buttonInsertImage2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图片文件|*.jpg;*.bmp;*.png";
            this.openFileDialog.Title = "选择图片";
            // 
            // frmSpotShoot
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmSpotShoot";
            this.Size = new System.Drawing.Size(1123, 659);
            this.Load += new System.EventHandler(this.frmSpotShoot_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoot2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShoot2;
        private System.Windows.Forms.PictureBox pictureBoxShoot1;
        private System.Windows.Forms.Label label3;
        private EnforceUI.TableTextBox ShootAddress1;
        private EnforceUI.TableTextBox PhotoIllustr2;
        private System.Windows.Forms.Label label5;
        private EnforceUI.TableTextBox ShootAddress2;
        private System.Windows.Forms.Label label6;
        private EnforceUI.TableTextBox PhotoIllustr1;
        private System.Windows.Forms.Label label4;
        private EnforceUI.TableDateTimePicker ShootDate;
        private System.Windows.Forms.Label label7;
        private EnforceUI.TableAutoCompleteTextBox SpotName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertImage2;
        private System.Windows.Forms.Button buttonInsertImage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

namespace Maleos.Modules
{
    partial class frmSynchro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxExportFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenExport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBoxImportFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenImport = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewLogs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 30);
            this.panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(647, 30);
            this.progressBar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 174);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 174);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExport);
            this.tabPage1.Controls.Add(this.textBoxExportFileName);
            this.tabPage1.Controls.Add(this.buttonOpenExport);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "导出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(558, 14);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "导出";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxExportFileName
            // 
            this.textBoxExportFileName.BackColor = System.Drawing.Color.White;
            this.textBoxExportFileName.Location = new System.Drawing.Point(8, 14);
            this.textBoxExportFileName.Name = "textBoxExportFileName";
            this.textBoxExportFileName.ReadOnly = true;
            this.textBoxExportFileName.Size = new System.Drawing.Size(491, 23);
            this.textBoxExportFileName.TabIndex = 1;
            // 
            // buttonOpenExport
            // 
            this.buttonOpenExport.Location = new System.Drawing.Point(505, 14);
            this.buttonOpenExport.Name = "buttonOpenExport";
            this.buttonOpenExport.Size = new System.Drawing.Size(48, 23);
            this.buttonOpenExport.TabIndex = 0;
            this.buttonOpenExport.Text = "...";
            this.buttonOpenExport.UseVisualStyleBackColor = true;
            this.buttonOpenExport.Click += new System.EventHandler(this.buttonOpenExport_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonImport);
            this.tabPage2.Controls.Add(this.textBoxImportFileName);
            this.tabPage2.Controls.Add(this.buttonOpenImport);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "导入";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(558, 14);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "导入";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // textBoxImportFileName
            // 
            this.textBoxImportFileName.BackColor = System.Drawing.Color.White;
            this.textBoxImportFileName.Location = new System.Drawing.Point(8, 14);
            this.textBoxImportFileName.Name = "textBoxImportFileName";
            this.textBoxImportFileName.ReadOnly = true;
            this.textBoxImportFileName.Size = new System.Drawing.Size(491, 23);
            this.textBoxImportFileName.TabIndex = 4;
            // 
            // buttonOpenImport
            // 
            this.buttonOpenImport.Location = new System.Drawing.Point(505, 14);
            this.buttonOpenImport.Name = "buttonOpenImport";
            this.buttonOpenImport.Size = new System.Drawing.Size(48, 23);
            this.buttonOpenImport.TabIndex = 3;
            this.buttonOpenImport.Text = "...";
            this.buttonOpenImport.UseVisualStyleBackColor = true;
            this.buttonOpenImport.Click += new System.EventHandler(this.buttonOpenImport_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "数据导出文件|*.xdb";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "数据导出文件|*.xdb";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewLogs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 101);
            this.panel3.TabIndex = 2;
            // 
            // listViewLogs
            // 
            this.listViewLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLogs.Location = new System.Drawing.Point(0, 0);
            this.listViewLogs.Name = "listViewLogs";
            this.listViewLogs.Size = new System.Drawing.Size(647, 101);
            this.listViewLogs.TabIndex = 0;
            this.listViewLogs.UseCompatibleStateImageBehavior = false;
            this.listViewLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "信息";
            this.columnHeader1.Width = 500;
            // 
            // frmSynchro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSynchro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据同步";
            this.Load += new System.EventHandler(this.frmSynchro_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxExportFileName;
        private System.Windows.Forms.Button buttonOpenExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBoxImportFileName;
        private System.Windows.Forms.Button buttonOpenImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listViewLogs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
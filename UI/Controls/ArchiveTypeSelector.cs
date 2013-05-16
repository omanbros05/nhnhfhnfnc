﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SOA.ORM;
using EnforceUI;

namespace Maleos.Controls
{
    public partial class ArchiveTypeSelector : DevExpress.XtraEditors.XtraForm
    {
        public ArchiveTypeSelector()
        {
            InitializeComponent();

            BandingListControl();
        }

        private void BandingListControl() {

            SOA.ORM.Archive archive = new SOA.ORM.Archive();
            DataSet ds = archive.GetDataSetWithoutArchived();
            listBoxControl1.DataSource = ds.Tables[0];
            listBoxControl1.DisplayMember = "Name";
            listBoxControl1.ValueMember = "ID";
            this.coolTbox.Text = "";
            
        }

        public int SelectedValue { get; set; }

        private void ArchiveTypeSelector_Resize(object sender, EventArgs e)
        {
            //listBoxControl1.Size = new Size(this.Width - 40, BtnCancel.Top - 10);
           // listBoxControl1.Location = new Point(0, 0);
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedIndex >= 0)
            {
                int value = (int)listBoxControl1.GetItemValue(listBoxControl1.SelectedIndex);
                SelectedValue = value;
            }

            if (this.Validate()) {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.Validate()) {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnModType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.coolTbox.Text))
            {
                this.coolTbox.BorderColor = Color.Red;
                return;
            }

            Archive entity = new Archive();

            entity.Name = this.coolTbox.Text.Trim();
            entity.CreateTimes = DateTime.Now;
            entity.Status = 0;
            InvokeUtil.SystemService.EntityUpdate(entity);
            SOA.ORM.Archive archive = new SOA.ORM.Archive();
            DataSet ds = archive.GetDataSetWithoutArchived();
            listBoxControl1.DataSource = ds.Tables[0];
            listBoxControl1.DisplayMember = "Name";
            listBoxControl1.ValueMember = "ID";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using EnforceUI.Input;
using SOA;
using SOA.ORM;
using Common;

namespace EnforceForm
{
    public partial class frmSamplings : BaseFormDetails
    {
        public frmSamplings()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }

        public override void Reload()
        {
            EList<Sampling> Samplings = InvokeUtil.SystemService.SamplingGetAll(pager.CurrentPage, pager.PageSize, TxtDocTitle.Text, TxtCompanyName.Text);
            pager.TotalCount = Samplings.TotalCount;
            enforceLawGridViewSpotCheck.Bind<Sampling>(Samplings.Items);
        }

        private void frmSamplings_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSampling"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotCheck.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSpotCheck.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Sampling sampling = enforceLawGridViewSpotCheck.SelectedRows[0].Tag as Sampling;
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSampling", new object[] { sampling }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotCheck.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSpotCheck.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSpotCheck.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        Sampling sampling = row.Tag as Sampling;
                        InvokeUtil.SystemService.EntityRemove(sampling);
                        enforceLawGridViewSpotCheck.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{System.Diagnostics.Process.Start("osk.exe");}catch { }
        }

        private void toolStripButtonTar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSpotCheck.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            Sampling sampling = rows[0].Tag as Sampling;

            if (sampling.Status == 0)
            {
                CommonInvoke.MessageBox("在导出文书之前无法进行归档。\r\r--选择一条记录\r--点击编辑->导出\r--选择一条记录点击归档", MessageBoxButtons.OK);
                return;
            }

            UseWaitCursor = true;
            Application.DoEvents();


            using (var form = new Maleos.Controls.ArchiveTypeSelector())
            {

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + sampling.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(sampling.ID, DataBases.Sampling.___GetTableName(), sampling.FilePath, "现场处理措施决定书", value,
                            DataBases.Sampling, DataBases.Sampling.Status, DataBases.Sampling.ID);
                        enforceLawGridViewSpotCheck.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

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
    public partial class frmSurveyEndReport: BaseFormDetails
    {
        public frmSurveyEndReport()
        {
            InitializeComponent();
        }

        private void frmSurveyEndReport_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //Reload();
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
                frmEditSurveyEndReport frm = new frmEditSurveyEndReport();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSurveyEndReport.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSurveyEndReport.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SurveyEndReport surveyEndReport = enforceLawGridViewSurveyEndReport.SelectedRows[0].Tag as SurveyEndReport;
                frmEditSurveyEndReport frm = new frmEditSurveyEndReport(surveyEndReport);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSurveyEndReport.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSurveyEndReport.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSurveyEndReport.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SurveyEndReport surveyEndReport = row.Tag as SurveyEndReport;
                        InvokeUtil.SystemService.EntityRemove(surveyEndReport);
                        enforceLawGridViewSurveyEndReport.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        public override void Reload()
        {
            EList<SurveyEndReport> SurveyEndReports = InvokeUtil.SystemService.SurveyEndReportGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = SurveyEndReports.TotalCount;
            enforceLawGridViewSurveyEndReport.Bind<SurveyEndReport>(SurveyEndReports.Items);
        }
    }
}

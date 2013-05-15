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
using Maleos.Modules;

namespace EnforceForm
{
    public partial class frmSpotHandelDesisionSixtyDays : BaseFormDetails
    {
        public frmSpotHandelDesisionSixtyDays()
        {
            InitializeComponent();
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
                frmSpotHandelDesisionSixtyDay frm = new frmSpotHandelDesisionSixtyDay();
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
            if (enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay = enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows[0].Tag as SpotHandelDesisionSixtyDay;
                frmSpotHandelDesisionSixtyDay frm = new frmSpotHandelDesisionSixtyDay(spotHandelDesisionSixtyDay);
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
            if (enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay = row.Tag as SpotHandelDesisionSixtyDay;
                        InvokeUtil.SystemService.EntityRemove(spotHandelDesisionSixtyDay);
                        enforceLawGridViewSpotHandelDesisionSixtyDay.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void frmSpotHandelDesisionSixtyDays_Load(object sender, EventArgs e)
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

        public override void Reload()
        {
            EList<SpotHandelDesisionSixtyDay> SpotHandelDesisionSixtyDays = InvokeUtil.SystemService.SpotHandelDesisionSixtyDayGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = SpotHandelDesisionSixtyDays.TotalCount;
            enforceLawGridViewSpotHandelDesisionSixtyDay.Bind<SpotHandelDesisionSixtyDay>(SpotHandelDesisionSixtyDays.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay = enforceLawGridViewSpotHandelDesisionSixtyDay.SelectedRows[0].Tag as SpotHandelDesisionSixtyDay;
                WordDocument doc = new WordDocument("现场处理措施决定书(6个月内).doc");
                doc.AddField("DocTitle", spotHandelDesisionSixtyDay.DocTitle);
                doc.AddField("HandleComp", spotHandelDesisionSixtyDay.HandleComp);
                doc.AddField("CheckDateYear", spotHandelDesisionSixtyDay.CheckDate.Year.ToString());
                doc.AddField("CheckDateMonth", spotHandelDesisionSixtyDay.CheckDate.Month.ToString());
                doc.AddField("CheckDateDay", spotHandelDesisionSixtyDay.CheckDate.Day.ToString());
                doc.AddField("Danger", spotHandelDesisionSixtyDay.Danger);
                doc.AddField("LegalBasis", spotHandelDesisionSixtyDay.LegalBasis);
                doc.AddField("SitHandel", spotHandelDesisionSixtyDay.SitHandel);
                doc.AddField("GovArea", spotHandelDesisionSixtyDay.GovArea);
                doc.AddField("ManageArea", spotHandelDesisionSixtyDay.ManageArea);
                doc.AddField("CourtArea", spotHandelDesisionSixtyDay.CourtArea);
                doc.AddField("OfficerName1", spotHandelDesisionSixtyDay.OfficerName1);
                doc.AddField("CID1", spotHandelDesisionSixtyDay.CID1);
                doc.AddField("OfficerName2", spotHandelDesisionSixtyDay.OfficerName2);
                doc.AddField("CID2", spotHandelDesisionSixtyDay.CID2);
                doc.AddField("DocManageArea", spotHandelDesisionSixtyDay.DocManageArea);
                doc.AddField("DocDate", spotHandelDesisionSixtyDay.DocDate.ToString("yyyy年M月d日"));
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

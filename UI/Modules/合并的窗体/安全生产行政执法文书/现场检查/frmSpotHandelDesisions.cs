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
    public partial class frmSpotHandelDesisions : BaseFormDetails
    {
        public frmSpotHandelDesisions()
        {
            InitializeComponent();

            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));

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

        private void frmSpotHandelDesisions_Load(object sender, EventArgs e)
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
                //frmSpotHandelDesision frm = new frmSpotHandelDesision();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotHandelDesision"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e) {
            if (enforceLawGridViewSpotHandelDesision.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewSpotHandelDesision.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotHandelDesision spotHandelDesision = enforceLawGridViewSpotHandelDesision.SelectedRows[0].Tag as SpotHandelDesision;
                //frmSpotHandelDesision frm = new frmSpotHandelDesision(spotHandelDesision);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotHandelDesision", new object[] { spotHandelDesision }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotHandelDesision.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewSpotHandelDesision.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewSpotHandelDesision.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        SpotHandelDesision spotHandelDesision = row.Tag as SpotHandelDesision;
                        InvokeUtil.SystemService.EntityRemove(spotHandelDesision);
                        enforceLawGridViewSpotHandelDesision.Rows.Remove(row);
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
            EList<SpotHandelDesision> SpotHandelDesisions = InvokeUtil.SystemService.SpotHandelDesisionGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = SpotHandelDesisions.TotalCount;

            enforceLawGridViewSpotHandelDesision.Bind<SpotHandelDesision>(SpotHandelDesisions.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewSpotHandelDesision.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SpotHandelDesision spotHandelDesision = enforceLawGridViewSpotHandelDesision.SelectedRows[0].Tag as SpotHandelDesision;
                WordDocument doc = new WordDocument("现场处理措施决定书.doc");
                doc.AddField("DocTitle", spotHandelDesision.DocTitle);
                doc.AddField("CompanyName", spotHandelDesision.CompanyName);
                doc.AddField("CheckDateYear", spotHandelDesision.CheckDate.Year.ToString());
                doc.AddField("CheckDateMonth", spotHandelDesision.CheckDate.Month.ToString());
                doc.AddField("CheckDateDay", spotHandelDesision.CheckDate.Day.ToString());
                doc.AddField("Violations", spotHandelDesision.Violations);
                doc.AddField("LegalBasis", spotHandelDesision.LegalBasis);
                doc.AddField("SitHandel", spotHandelDesision.SitHandel);
                doc.AddField("GovArea", spotHandelDesision.GovArea);
                doc.AddField("ManageArea", spotHandelDesision.ManageArea);
                doc.AddField("CourtArea", spotHandelDesision.CourtArea);
                doc.AddField("OfficerName1", spotHandelDesision.OfficerName1);
                doc.AddField("CID1", spotHandelDesision.CID1);
                doc.AddField("OfficerName2", spotHandelDesision.OfficerName2);
                doc.AddField("CID2", spotHandelDesision.CID2);
                doc.AddField("DocManageArea", spotHandelDesision.DocManageArea);
                doc.AddField("DocDate", spotHandelDesision.DocDate.ToString("yyyy年M月d日"));
                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt", new object[] { doc }));
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewSpotHandelDesision.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            SpotHandelDesision spotHandelDesision = rows[0].Tag as SpotHandelDesision;

            if (spotHandelDesision.Status == 0)
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
                        if (CommonInvoke.MessageBox("是否归档名称为\r\r" + spotHandelDesision.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == System.Windows.Forms.DialogResult.Yes)
                        {
                            int value = form.SelectedValue;
                            Utility.UpdateStatus(spotHandelDesision.ID, DataBases.SpotHandelDesision.___GetTableName(), spotHandelDesision.FilePath, "现场处理措施决定书", value,
                                DataBases.SpotHandelDesision, DataBases.SpotHandelDesision.Status, DataBases.SpotHandelDesision.ID);
                            enforceLawGridViewSpotHandelDesision.Rows.Remove(rows[0]);
                        }
                    }
                }

            UseWaitCursor = false;
        }
    }
}

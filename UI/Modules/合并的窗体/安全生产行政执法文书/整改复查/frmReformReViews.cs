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
    public partial class frmReformReViews : BaseFormDetails
    {
        public frmReformReViews()
        {
            InitializeComponent();
            header1.BackEvent += new EventHandler(DoBack);
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));

        }

        private void frmReformReViews_Load(object sender, EventArgs e)
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
                //frmReformReView frm = new frmReformReView();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmReformReView"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReformReView.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewReformReView.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ReformReView reformReView = enforceLawGridViewReformReView.SelectedRows[0].Tag as ReformReView;
                //frmReformReView frm = new frmReformReView(reformReView);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmReformReView", new object[] { reformReView }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReformReView.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewReformReView.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewReformReView.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ReformReView reformReView = row.Tag as ReformReView;
                        InvokeUtil.SystemService.EntityRemove(reformReView);
                        enforceLawGridViewReformReView.Rows.Remove(row);
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
            EList<ReformReView> ReformReViews = InvokeUtil.SystemService.ReformReViewGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = ReformReViews.TotalCount;
            enforceLawGridViewReformReView.Bind<ReformReView>(ReformReViews.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewReformReView.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ReformReView reformReView = enforceLawGridViewReformReView.SelectedRows[0].Tag as ReformReView;
                WordDocument doc = new WordDocument("整改复查意见书.rtf");
                doc.AddField("DocTitle", reformReView.DocTitle);
                doc.AddField("ReviewCompany", reformReView.ReviewCompany);
                doc.AddField("ReviewDateYear", reformReView.ReviewDate.Year.ToString());
                doc.AddField("ReviewDateMonth", reformReView.ReviewDate.Month.ToString());
                doc.AddField("ReviewDateDay", reformReView.ReviewDate.Day.ToString());
                doc.AddField("Decide", reformReView.Decide);
                doc.AddField("DocTitle2", reformReView.DocTitle2);
                doc.AddField("Idea", reformReView.Idea);
                doc.AddField("OfficerName1", reformReView.OfficerName1);
                doc.AddField("CID1", reformReView.CID1);
                doc.AddField("OfficerName2", reformReView.OfficerName2);
                doc.AddField("CID2", reformReView.CID2);
                doc.AddField("DocManageArea", reformReView.DocManageArea);
                doc.AddField("DocDate", reformReView.DocDate.ToString("yyyy年M月d日"));

                Grid grid = doc.NewGrid();
                grid.TableMark = "Table";
                GridRow row = grid.NewRow();
                row.AddRowItem("台安监管回2012 (1) 号");
                row.AddRowItem("张三");
                row.AddRowItem("2012-01-01");
                row.AddRowItem("宁波");
                row.AddRowItem("当面");
                row.AddRowItem("李四");

                row = grid.NewRow();
                row.AddRowItem("台安监管回2012 (2) 号");
                row.AddRowItem("王五");
                row.AddRowItem("2013-12-01");
                row.AddRowItem("宁波");
                row.AddRowItem("当面");
                row.AddRowItem("李四");
                OutputDocuemnt frm = new OutputDocuemnt(doc);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewReformReView.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            ReformReView reformReView = rows[0].Tag as ReformReView;

            if (reformReView.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + reformReView.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(reformReView.ID, DataBases.ReformReView.___GetTableName(), reformReView.FilePath, "整改复查意见书", value,
                            DataBases.ReformReView, DataBases.ReformReView.Status, DataBases.ReformReView.ID);
                        enforceLawGridViewReformReView.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }
    }
}

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
    public partial class frmOrderDeadlineReforms : BaseFormDetails
    {
        public frmOrderDeadlineReforms()
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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //frmOrderDeadlineReform frm = new frmOrderDeadlineReform();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmOrderDeadlineReform"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                OrderDeadlineReform orderDeadlineReform = enforceLawGridViewOrderDeadlineReforms.SelectedRows[0].Tag as OrderDeadlineReform;
                //frmOrderDeadlineReform frm = new frmOrderDeadlineReform(orderDeadlineReform);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmOrderDeadlineReform",new object[]{ orderDeadlineReform }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonReformReView_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                OrderDeadlineReform orderDeadlineReform = enforceLawGridViewOrderDeadlineReforms.SelectedRows[0].Tag as OrderDeadlineReform;
                frmReformReView frm = new frmReformReView(orderDeadlineReform);
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
            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewOrderDeadlineReforms.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewOrderDeadlineReforms.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        OrderDeadlineReform orderDeadlineReform = row.Tag as OrderDeadlineReform;
                        InvokeUtil.SystemService.EntityRemove(orderDeadlineReform);
                        enforceLawGridViewOrderDeadlineReforms.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void frmOrderDeadlineReforms_Load(object sender, EventArgs e)
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

        public override void Reload()
        {
            EList<OrderDeadlineReform> OrderDeadlineReforms = InvokeUtil.SystemService.OrderDeadlineReformGetAll(pager.CurrentPage, pager.PageSize, documentAutoCompleteTextBoxDocTitle.Text);
            pager.TotalCount = OrderDeadlineReforms.TotalCount;
            enforceLawGridViewOrderDeadlineReforms.Bind<OrderDeadlineReform>(OrderDeadlineReforms.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewOrderDeadlineReforms.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                OrderDeadlineReform orderDeadlineReform = enforceLawGridViewOrderDeadlineReforms.SelectedRows[0].Tag as OrderDeadlineReform;
                WordDocument doc = new WordDocument("责令限期整改指令书.doc");
                doc.AddField("DocTitle", orderDeadlineReform.DocTitle);
                doc.AddField("OrderCompany", orderDeadlineReform.OrderCompany);
                doc.AddField("Matter", orderDeadlineReform.Matter);
                doc.AddField("MatterCount", orderDeadlineReform.MatterCount);
                doc.AddField("ReformDateYear", orderDeadlineReform.ReformDate.Year.ToString());
                doc.AddField("ReformDateMonth", orderDeadlineReform.ReformDate.Month.ToString());
                doc.AddField("ReformDateDay", orderDeadlineReform.ReformDate.Day.ToString());
                doc.AddField("GovArea", orderDeadlineReform.GovArea);
                doc.AddField("ManageArea", orderDeadlineReform.ManageArea);
                doc.AddField("CourtArea", orderDeadlineReform.CourtArea);
                doc.AddField("OfficerName1", orderDeadlineReform.OfficerName1);
                doc.AddField("CID1", orderDeadlineReform.CID1);
                doc.AddField("OfficerName2", orderDeadlineReform.OfficerName2);
                doc.AddField("CID2", orderDeadlineReform.CID2);
                doc.AddField("DocManageArea", orderDeadlineReform.DocManageArea);
                doc.AddField("DocDate", orderDeadlineReform.DocDate.ToString("yyyy年M月d日"));
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
            DataGridViewSelectedRowCollection rows = enforceLawGridViewOrderDeadlineReforms.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;

            OrderDeadlineReform orderDeadlineReform = rows[0].Tag as OrderDeadlineReform;

            if (orderDeadlineReform.Status == 0)
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
                    if (CommonInvoke.MessageBox("是否归档名称为\r\r" + orderDeadlineReform.DocTitle + "\r\r的记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        int value = form.SelectedValue;
                        Utility.UpdateStatus(orderDeadlineReform.ID, DataBases.OrderDeadlineReform.___GetTableName(), orderDeadlineReform.FilePath, "责令限期整改指令书", value,
                            DataBases.OrderDeadlineReform, DataBases.OrderDeadlineReform.Status, DataBases.OrderDeadlineReform.ID);
                        enforceLawGridViewOrderDeadlineReforms.Rows.Remove(rows[0]);
                    }
                }
            }

            UseWaitCursor = false;
        }

        
    }
}

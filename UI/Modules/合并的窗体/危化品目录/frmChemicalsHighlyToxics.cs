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
    public partial class frmChemicalsHighlyToxics : BaseFormDetails
    {
        public frmChemicalsHighlyToxics()
        {
            InitializeComponent();
        }

        public frmChemicalsHighlyToxics(int param) :this() {
        
        }

        private void frmChemicalsHighlyToxics_Load(object sender, EventArgs e)
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
                frmChemicalsHighlyToxic frm = new frmChemicalsHighlyToxic();
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
            if (enforceLawGridViewChemicalsHighlyToxic.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewChemicalsHighlyToxic.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ChemicalsHighlyToxic chemicalsHighlyToxic = enforceLawGridViewChemicalsHighlyToxic.SelectedRows[0].Tag as ChemicalsHighlyToxic;
                frmChemicalsHighlyToxic frm = new frmChemicalsHighlyToxic(chemicalsHighlyToxic);
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
            if (enforceLawGridViewChemicalsHighlyToxic.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewChemicalsHighlyToxic.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewChemicalsHighlyToxic.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ChemicalsHighlyToxic chemicalsHighlyToxic = row.Tag as ChemicalsHighlyToxic;
                        InvokeUtil.SystemService.EntityRemove(chemicalsHighlyToxic);
                        enforceLawGridViewChemicalsHighlyToxic.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void pager_CurrentPageChangedEvent(object sender, Pager.CurrentPageChangedEventArgs e)
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
            EList<ChemicalsHighlyToxic> ChemicalsHighlyToxics = InvokeUtil.SystemService.ChemicalsHighlyToxicGetAll(pager.CurrentPage, pager.PageSize, this.txtName.Text, this.txtAlias.Text);
            pager.TotalCount = ChemicalsHighlyToxics.TotalCount;
            enforceLawGridViewChemicalsHighlyToxic.Bind<ChemicalsHighlyToxic>(ChemicalsHighlyToxics.Items);
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\剧毒化学品目录\" + "judu.xls");
                //this.enforceLawGridViewChemicalsHighlyToxic.DataSource = dt;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    ChemicalsHighlyToxic ChemicalsHighlyToxic = new ChemicalsHighlyToxic();
                    ChemicalsHighlyToxic.ChemicalName = dt.Rows[j][0].ToString();
                    ChemicalsHighlyToxic.ChemicalAlias = dt.Rows[j][1].ToString();
                    ChemicalsHighlyToxic.ChemicalNameEn = dt.Rows[j][2].ToString();
                    ChemicalsHighlyToxic.ChemicalAliasEn = dt.Rows[j][3].ToString();
                    ChemicalsHighlyToxic.Formula = dt.Rows[j][4].ToString();
                    ChemicalsHighlyToxic.CAS = dt.Rows[j][5].ToString();
                    ChemicalsHighlyToxic.UN = dt.Rows[j][6].ToString();
                    ChemicalsHighlyToxic.LimitedRange = dt.Rows[j][7].ToString();

                    /*EList<ChemicalsHighlyToxic> ChemicalsHighlyToxics = InvokeUtil.SystemService.ChemicalsHighlyToxicGetAll(1, 20, ChemicalsHighlyToxic.ChemicalName, ChemicalsHighlyToxic.ChemicalAlias);
                    if (ChemicalsHighlyToxics.Items.Count <= 0)
                    {
                        InvokeUtil.SystemService.EntityUpdate(ChemicalsHighlyToxic);
                    }
                    */

                    InvokeUtil.SystemService.EntityUpdate(ChemicalsHighlyToxic);
                }
                Reload();
                CommonInvoke.MessageBox("操作成功！");
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.ChemicalsMenu"));
        }

        ///// <summary>
        ///// 用oledb方式读取excel到datatable
        ///// </summary>
        ///// <remarks></remarks>
        ///// <param name="strPath">文件存放路径</param>
        ///// <returns></returns>
        //private static System.Data.DataTable GetData(string strPath)
        //{
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    try
        //    {
        //        string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strPath + ";" + "Extended Properties=Excel 8.0;";
        //        string strSheetName = "";
        //        using (OleDbConnection con = new OleDbConnection(strCon))
        //        {
        //            con.Open();
        //            System.Data.DataTable dtTemp = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        //            strSheetName = dtTemp.Rows[0][2].ToString().Trim();
        //        }
        //        String strCmd = "select * from [" + strSheetName + "]";
        //        OleDbDataAdapter cmd = new OleDbDataAdapter(strCmd, strCon);
        //        cmd.Fill(dt);
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //    return dt;
        //}

    }
}

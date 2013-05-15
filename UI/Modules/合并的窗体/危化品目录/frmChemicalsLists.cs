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
    public partial class frmChemicalsLists : BaseFormDetails
    {
        int ChemicalsListType = -1;
        public frmChemicalsLists()
        {
            InitializeComponent();
        }
        public frmChemicalsLists(int Type)
            : this()
        {
            ChemicalsListType = Type;
        }

        private string _number = string.Empty;
        private string _name = string.Empty;
        private string _alias = string.Empty;
        private string _uncode = string.Empty;

        public frmChemicalsLists(string number, string name, string alias, string uncode) : this(-1) {

            _number = number;
            _name = name;
            _alias = alias;
            _uncode = uncode;
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
        private void frmChemicalsLists_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Insert(0, "所有分类");

                if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.爆炸品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EExplosivesType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EExplosivesType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.毒害品和感染性物品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EToxicType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EToxicType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.腐蚀品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECorrosiveType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECorrosiveType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.压缩气体和液化气体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EGasType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EGasType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.氧化剂和有机过氧化物)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EOxidantType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EOxidantType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃固体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECombustibleSolidType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECombustibleSolidType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃液体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECombustibleLiquidType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECombustibleLiquidType)i).ToString();
                        this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                    }
                }
                comboBox1.SelectedIndex = 0;

                //InitData();
                //if (ChemicalsListType != (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃固体)
                //{
                //    this.labelFormTitle.Text = ((SOA.ORM.ChemicalsList.EChemicalsType)ChemicalsListType).ToString();
                //}
                //else
                //{
                //    this.labelFormTitle.Text = "易燃固体、自燃物品和遇湿易燃物品";
                //}
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
                frmChemicalsList frm = new frmChemicalsList(ChemicalsListType);
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
            if (enforceLawGridViewChemicalsList.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewChemicalsList.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                ChemicalsList chemicalsList = enforceLawGridViewChemicalsList.SelectedRows[0].Tag as ChemicalsList;
                frmChemicalsList frm = new frmChemicalsList(chemicalsList, ChemicalsListType);
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
            if (enforceLawGridViewChemicalsList.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewChemicalsList.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewChemicalsList.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        ChemicalsList chemicalsList = row.Tag as ChemicalsList;
                        InvokeUtil.SystemService.EntityRemove(chemicalsList);
                        enforceLawGridViewChemicalsList.Rows.Remove(row);
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
            int SelectValue = -1;

            if (_number == string.Empty) {

                _number = txtNumber.Text.Trim();
            }

            if (_name == string.Empty) {
                _name = txtName.Text.Trim();
            
            }
            try
            {
                if (this.comboBox1.SelectedItem.ToString() != "所有分类" && this.comboBox1.SelectedItem.ToString() != "")
                {
                    SelectValue = Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                    
                }
            }
            catch
            { }
            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(pager.CurrentPage, pager.PageSize, _number, _name,_alias, ChemicalsListType, SelectValue, _uncode);
            pager.TotalCount = ChemicalsLists.TotalCount;
            enforceLawGridViewChemicalsList.Bind<ChemicalsList>(ChemicalsLists.Items);
            DataGridViewRowCollection collection = enforceLawGridViewChemicalsList.Rows;

            foreach (DataGridViewRow row in collection) {
                int value = (int)row.Cells[4].Value;
                switch (value) { 
                
                    case 0:
                        row.Cells[4].Value = "爆炸品";
                        break;
                    case 1:
                        row.Cells[4].Value = "压缩气体和液化气体";
                        break;
                    case 2:
                        row.Cells[4].Value = "易燃液体";
                        break;
                    case 3:
                        row.Cells[4].Value = "易燃固体";
                        break;
                    case 4:
                        row.Cells[4].Value = "氧化剂和有机过氧化物";
                        break;
                    case 5:
                        row.Cells[4].Value = "毒害品和感染性物品";
                        break;
                    case 6:
                        row.Cells[4].Value = "腐蚀品";
                        break;
                
                }
            }
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

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.ChemicalsMenu"));
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //this.enforceLawGridViewChemicalsList.DataSource = GetData(@"E:\移动办公\newEnforceLaw\trunk\src\Maleos\UI\bin\Debug\危化品\6\6-70.xls");
                if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.爆炸品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EExplosivesType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EExplosivesType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","",  -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.毒害品和感染性物品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EToxicType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EToxicType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.腐蚀品)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECorrosiveType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECorrosiveType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.压缩气体和液化气体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EGasType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EGasType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.氧化剂和有机过氧化物)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.EOxidantType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.EOxidantType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃固体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECombustibleSolidType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECombustibleSolidType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
                }
                else if (ChemicalsListType == (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃液体)
                {
                    foreach (int i in Enum.GetValues(typeof(SOA.ORM.ChemicalsList.ECombustibleLiquidType)))
                    {
                        int value = i;
                        string text = ((SOA.ORM.ChemicalsList.ECombustibleLiquidType)i).ToString();
                        DataTable dt = ExcelToTable(System.Environment.CurrentDirectory + @"\危化品\" + ChemicalsListType + @"\" + ChemicalsListType + "-" + value + ".xls");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            ChemicalsList chemicalsList = new ChemicalsList();
                            chemicalsList.ChemicalsType = ChemicalsListType;
                            chemicalsList.ChemicalsChildType = i;
                            chemicalsList.ChemicalsNumber = dt.Rows[j][0].ToString();
                            chemicalsList.ChemicalsName = dt.Rows[j][1].ToString();
                            chemicalsList.ChemicalsAlias = dt.Rows[j][2].ToString();
                            chemicalsList.ChemicalsUN = dt.Rows[j][3].ToString();

                            EList<ChemicalsList> ChemicalsLists = InvokeUtil.SystemService.ChemicalsListGetAll(1, 20, chemicalsList.ChemicalsNumber, "","", -1, -1, chemicalsList.ChemicalsUN);
                            if (ChemicalsLists.Items.Count <= 0)
                            {
                                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
                            }
                        }
                    }
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


    }
    public class ComboBoxItemTextValue
    {
        public string selectText;
        public string selectValue;

        public ComboBoxItemTextValue(string _selectValue, string _selectText)
        {
            selectValue = _selectValue;
            selectText = _selectText;
        }
        public override string ToString()
        {
            return selectText;
        }
    }

}

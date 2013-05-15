using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using SOA;
using SOA.ORM;
using Common;
using System.IO;
using System.Data.OleDb;

namespace EnforceForm
{
    public partial class frmCompanyImport : BaseTableForm
    {
        public frmCompanyImport()
        {
            InitializeComponent();
            List<CompanyType> Types = InvokeUtil.SystemService.CompanyTypeGetFastAll();
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("-1", "请选择类型"));
            foreach (CompanyType item in Types)
            {
                this.comboBox1.Items.Add(new ComboBoxItemTextValue(item.ID.ToString(), item.CompanyTypeName));
            }
            this.comboBox1.Text = "请选择类型";


            EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
            this.comboBox3.Items.Clear();
            this.comboBox3.Items.Add(new ComboBoxItemTextValue("-1", "请选择区域"));
            foreach (CompanyArea Area in Areas.Items)
            {
                this.comboBox3.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
            }
            this.comboBox3.Text = "请选择区域";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.txtPath.Text = ShowSaveFileDialog();
        }
        private string ShowSaveFileDialog()
        {
            string theFile;
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "excel Files(*.xls)|*.xls|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = openFileDialog1.FileName;
                string desfolderdir = Application.StartupPath + @"\Company";
                string FileName = Path.GetFileName(theFile);
                if (!Directory.Exists(desfolderdir)) { Directory.CreateDirectory(desfolderdir); }
                if (File.Exists(desfolderdir + @"\" + FileName))
                {
                    File.Delete(desfolderdir + @"\" + FileName);
                }
                File.Copy(theFile, desfolderdir + @"\" + FileName);

                return @"\Company" + @"\" + FileName;
            }
            else
            {
                return "";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue) == -1)
            {
                CommonInvoke.MessageBox("请选择类型！");
                return;
            }
            if (Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox3.SelectedItem)).selectValue) == -1)
            {
                CommonInvoke.MessageBox("请选择区域！");
                return;
            }

            string path = Application.StartupPath + @"\" + this.txtPath.Text.Trim();
            if (!File.Exists(path))
            { 
                CommonInvoke.MessageBox("文件不存在，请重新选择！");
                return;
            }

            DataTable dt = ExcelToTable(path);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                Company Company = new SOA.ORM.Company();

                Company.CompanyName = dt.Rows[j][0].ToString();
                Company.JuridicalPerson = dt.Rows[j][1].ToString();
                Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                Company.IDCard = dt.Rows[j][3].ToString();
                Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                Company.Mobile = dt.Rows[j][5].ToString();
                Company.CompanyAddress = dt.Rows[j][6].ToString();
                Company.CompanyPost = dt.Rows[j][7].ToString();
                Company.BusinessMode = dt.Rows[j][8].ToString();
                Company.WarehousAddress = dt.Rows[j][9].ToString();
                Company.PermitRange = dt.Rows[j][10].ToString();
                Company.PermitValid = dt.Rows[j][11].ToString();
                Company.IsCity = 1;
                Company.CompanyType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                    Company.CompanyAreaID = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox3.SelectedItem)).selectValue);

                EList<Company> CompanyList = InvokeUtil.SystemService.CompanyGetAllByName(Company.CompanyName);
                if (CompanyList.Items.Count <= 0)
                {
                    InvokeUtil.SystemService.EntityUpdate(Company);
                }
            }
            CommonInvoke.MessageBox("操作成功！");
        }
        /// <summary>
        /// 用oledb方式读取excel到datatable
        /// </summary>
        /// <remarks></remarks>
        /// <param name="strPath">文件存放路径</param>
        /// <returns></returns>
        public System.Data.DataTable ExcelToTable(string strPath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strPath + ";" + "Extended Properties=Excel 8.0;";
                string strSheetName = "";
                using (OleDbConnection con = new OleDbConnection(strCon))
                {
                    con.Open();
                    System.Data.DataTable dtTemp = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    strSheetName = dtTemp.Rows[0][2].ToString().Trim();
                }
                String strCmd = "select * from [" + strSheetName + "]";
                OleDbDataAdapter cmd = new OleDbDataAdapter(strCmd, strCon);
                cmd.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EnforceUI
{
    public partial class BaseFormDetails : BaseForm
    {
        public BaseFormDetails()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        public override List<ITableControl> GetTableControls()
        {
            List<ITableControl> TableControls = new List<ITableControl>();

            foreach (Control control in panelTop.Controls)
            {
                Type controlType = control.GetType().GetInterface(typeof(ITableControl).ToString());
                if (controlType != null)
                    TableControls.Add(control as ITableControl);
            }

            return TableControls;
        }

        public override int GetCurrentPage()
        {
            return pager.CurrentPage;
        }

        public override void SetTableControls()
        {
            if (FormValue != null)
            {
                foreach (ITableControl control in FormValue.CurrentForm.FormControls)
                {
                    foreach (Control panelControl in panelTop.Controls)
                    {
                        if (control.ControlName == panelControl.Name)
                        {
                            ITableControl pcon = panelControl as ITableControl;
                            pcon.ControlText = control.ControlText;
                        }
                    }
                }
            }
        }

        public override void SetCurrentPage()
        {
            if (FormValue != null)
            {
                pager.CurrentPage = FormValue.CurrentForm.CurrentPage;
            }
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

        private void BaseFormDetails_Resize(object sender, EventArgs e)
        {
            panelTop.Width = this.Width;
            panelTop.Location = new Point(0, 65);
            panel2.Width = this.Width;
            panel2.Location = new Point(0, 65 + panelTop.Height);
            panel3.Width = this.Width;
            panel3.Height = this.Height - (65 + panelTop.Height + panel2.Height) - pager.Height;
            panel3.Location = new Point(0, 65 + panelTop.Height + panel2.Height);
        }
    }
}

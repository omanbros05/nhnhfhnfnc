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
using System.IO;

namespace EnforceForm
{
    public partial class frmLawQuery : BaseTableForm
    {
         int LawType = -1;
         public frmLawQuery()
        {
            InitializeComponent();
        }
        public frmLawQuery(int LawType):this()
        {
            this.LawType = LawType;
        }

        private void frmLawQuery_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InitData();

                //SelectValue = Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
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
                LawType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                InitData();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void InitData()
        {
            //if (LawType == (int)SOA.ORM.LawFile.ELawType.宣传教育)
            //{
            //    this.labelFormTitle.Text = "宣传教育、培训考核";
            //}
            //else
            //{
            //    this.labelFormTitle.Text = ((SOA.ORM.LawFile.ELawType)LawType).ToString();
            //}
            this.comboBox1.Items.Clear();
            foreach (int i in Enum.GetValues(typeof(SOA.ORM.LawFile.ELawType)))
            {
                int value = i;
                string text = ((SOA.ORM.LawFile.ELawType)i).ToString();
                if (i == (int)SOA.ORM.LawFile.ELawType.宣传教育)
                {
                    text = "宣传教育、培训考核";
                }
                this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
            }
            if (LawType != (int)SOA.ORM.LawFile.ELawType.宣传教育)
            {
                this.comboBox1.Text = ((SOA.ORM.LawFile.ELawType)LawType).ToString();
            }
            else
            {
                this.comboBox1.Text = "宣传教育、培训考核";
            }

            EList<LawFile> LawFiles = InvokeUtil.SystemService.LawFileGetAll(1, 1000, txtName.Text, LawType);
            //pager.TotalCount = LawFiles.TotalCount;
            enforceLawGridViewLawFile.Bind<LawFile>(LawFiles.Items);
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewLawFile.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewLawFile.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                LawFile lawFile = enforceLawGridViewLawFile.SelectedRows[0].Tag as LawFile;
                //frmLawList frm = new frmLawList(lawFile);
                frmLawContent frm = new frmLawContent(lawFile);
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

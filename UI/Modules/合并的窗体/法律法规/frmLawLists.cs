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
    public partial class frmLawLists : BaseFormDetails
    {
        int LawType = -1;
        public frmLawLists()
        {
            InitializeComponent();

            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
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
            this.comboBox1.Text = "全部";
            //LawType = -1;
            //if (LawType != (int)SOA.ORM.LawFile.ELawType.宣传教育)
            //{
            //    this.comboBox1.Text = ((SOA.ORM.LawFile.ELawType)LawType).ToString();
            //}
            //else
            //{
            //    this.comboBox1.Text = "宣传教育、培训考核";
            //}
        }
        public frmLawLists(int LawType):this()
        {
            this.LawType = LawType;
            //LawType = -1;
        }
        private void frmLawLists_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //Reload();
               
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
                //frmLawList frm = new frmLawList(LawType);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmLawList", new object[]{ LawType }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
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
                //frmLawContents frm = new frmLawContents();
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmLawList", new object[] { lawFile }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewLawFile.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewLawFile.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewLawFile.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;


                        LawFile lawFile = row.Tag as LawFile;
                        string FilePath = lawFile.LawFilePath;
                        InvokeUtil.SystemService.EntityRemove(lawFile);
                        enforceLawGridViewLawFile.Rows.Remove(row);

                        if (System.IO.File.Exists(FilePath))
                        {
                            System.IO.File.Delete(FilePath);
                        }
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
            //if (LawType == (int)SOA.ORM.LawFile.ELawType.宣传教育)
            //{
            //    this.labelFormTitle.Text = "宣传教育、培训考核";
            //}
            //else
            //{
            //    this.labelFormTitle.Text = ((SOA.ORM.LawFile.ELawType)LawType).ToString();
            //}


            EList<LawFile> LawFiles = InvokeUtil.SystemService.LawFileGetAll(pager.CurrentPage, pager.PageSize, txtName.Text, Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue));// Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue)
            pager.TotalCount = LawFiles.TotalCount;
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
                //frmLawContent frm = new frmLawContent(lawFile);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmLawContent", new object[]{ lawFile }));
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

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.StartPage"));
        }

    }
    

}

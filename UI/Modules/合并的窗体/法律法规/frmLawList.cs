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
    public partial class frmLawList : BaseTableForm
    {
        public LawFile lawFile;
        public int LawType = -1;
        public frmLawList()
        {
            InitializeComponent();
        }
        public frmLawList(int Type)
            : this()
        {
            this.LawType = Type;
        }
        public frmLawList(LawFile lawFile)
            : this()
        {
            this.lawFile = lawFile;
            LawType = lawFile.LawType;
        }

        private void frmLawList_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (lawFile != null)
                {
                    this.txtTitle.Text = lawFile.LawTitle;
                    this.txtPath.Text = lawFile.LawFilePath;
                }
                if (LawType == (int)SOA.ORM.LawFile.ELawType.宣传教育)
                {
                    this.headerLabel1.Text = "宣传教育、培训考核";
                }
                else
                {
                    this.headerLabel1.Text = ((SOA.ORM.LawFile.ELawType)LawType).ToString();
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private string ShowSaveFileDialog()
        {
            string theFile;
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "word Files(*.doc)|*.doc|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = openFileDialog1.FileName;
                string desfolderdir = Application.StartupPath + @"\" + ((SOA.ORM.LawFile.ELawType)LawType).ToString();
                string FileName = Path.GetFileName(theFile);
                if (!Directory.Exists(desfolderdir)) { Directory.CreateDirectory(desfolderdir); }
                if (File.Exists(desfolderdir + @"\" + FileName))
                {
                    File.Delete(desfolderdir + @"\" + FileName);
                }
                File.Copy(theFile, desfolderdir + @"\" + FileName );

                return @"\" + ((SOA.ORM.LawFile.ELawType)LawType).ToString() + @"\" + FileName;  
;
            }
            else
            {
                return "";
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (lawFile == null)
                    lawFile = new LawFile();

                if (this.txtTitle.Text.Trim() == "")
                {
                    CommonInvoke.MessageBox("标题不能为空！");
                    return;
                }

                lawFile.LawTitle = this.txtTitle.Text.Trim();
                lawFile.LawType = LawType;
                string path = this.txtPath.Text.Trim();
                if (path != "")
                {
                    lawFile.LawFilePath = path;
                }
                InvokeUtil.SystemService.EntityUpdate(lawFile);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmLawLists"));
                //CommonInvoke.MessageBox("操作成功！");
                //CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtPath.Text = ShowSaveFileDialog();
        }
    }
}

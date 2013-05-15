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
    public partial class frmLawContent : BaseTableForm
    {
        LawFile lawFile = null;
        string Path = String.Empty;
        public frmLawContent()
        {
            InitializeComponent();
        }
        public frmLawContent(LawFile lawFile):this()
        {
            this.lawFile = lawFile;
        }
        public frmLawContent(string path)
            : this()
        {
            this.Path = path;
        }

        private void frmLawContent_Load(object sender, EventArgs e)
        {
            //this.doc.ReadOnly = true;
            if (lawFile != null)
            {
                this.doc.LoadDocument(Application.StartupPath + @"\" +  lawFile.LawFilePath, DevExpress.XtraRichEdit.DocumentFormat.Doc);
            }
            else if (Path != "")
            {
                this.doc.LoadDocument(Path, DevExpress.XtraRichEdit.DocumentFormat.Doc);
                this.header1.Visible = false;
                //this.doc.Location = new Point(0, 0);
                this.doc.Height += this.header1.Height;
            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmLawLists"));
        }
    }
}

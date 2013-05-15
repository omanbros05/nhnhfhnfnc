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
    public partial class frmLawPower : BaseFormDialog
    {
        string Path = String.Empty;
        public frmLawPower()
        {
            InitializeComponent();
            FormPosition = ShowFormPosition.FormMain;
        }
        public frmLawPower(string path)
            : this()
        {
            this.Path = path;
        }

        private void frmLawPower_Load(object sender, EventArgs e)
        {
            if (Path != "")
            {
                this.doc.LoadDocument(Path, DevExpress.XtraRichEdit.DocumentFormat.Doc);
            }
        }
    }
}

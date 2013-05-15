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
    public partial class frmInstrumentsExampleContent : BaseTableForm
    {
        public int ParentType = -1;
        public int ChildType = -1;
        public string Path = String.Empty;
        private string _moduleName;
        private object _object;
        public frmInstrumentsExampleContent()
        {
            InitializeComponent();
        }
        public frmInstrumentsExampleContent(int ParentType, int ChildType)
            : this()
        {
            this.ParentType = ParentType;
            this.ChildType = ChildType;
        }
        public frmInstrumentsExampleContent(InstrumentsExample InstrumentsExample, string moduleName, object obj)
            : this()
        {
            this.ParentType = InstrumentsExample.InstrumentsType;
            this.ChildType = InstrumentsExample.InstrumentsChildType;
            this._moduleName = moduleName;
            this._object = obj;
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new Maleos.NavigationRequestEventArgs(_moduleName, new object[]{_object}));
        }

        public frmInstrumentsExampleContent(InstrumentsExample InstrumentsExample)
            : this()
        {
            this.ParentType = InstrumentsExample.InstrumentsType;
            this.ChildType = InstrumentsExample.InstrumentsChildType;
        }

        public frmInstrumentsExampleContent(string path)
            : this()
        {
            this.Path = path;
        }

        private void frmInstrumentsExampleContent_Load(object sender, EventArgs e)
        {
            if (Path != "")
            {
                this.doc.LoadDocument(Path, DevExpress.XtraRichEdit.DocumentFormat.Doc);
            }
            else
            {
                EList<InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", ParentType, ChildType);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    this.doc.LoadDocument(Application.StartupPath + @"\" + InstrumentsExamples.Items[0].InstrumentsPath, DevExpress.XtraRichEdit.DocumentFormat.Doc);
                }
            }
        }
    }
}

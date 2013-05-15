using System.ComponentModel;

namespace Maleos.Controls
{
    public partial class Launcher : DevExpress.XtraEditors.XtraUserControl
    {
        public Launcher()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public DevExpress.XtraRichEdit.RichEditControl RichEditControl
        {
            get { return this.richEditControl1; }
        }
    }
}

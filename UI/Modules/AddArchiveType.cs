using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOA.ORM;
using EnforceUI;

namespace Maleos.Modules
{
    public partial class AddArchiveType : Controls.BasePage
    {
        public AddArchiveType()
        {
            InitializeComponent();
            TextBoxArchiveType.Text = string.Empty;
            LabelValidation.Text = string.Empty;
        }

        private void DoBack(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ArchiveTypeManager"));
        }

        private void footer1_AddEvent(object sender, EventArgs e)
        {
            if (TextBoxArchiveType.Text.Trim().Length == 0) {

                LabelValidation.Text = "*文本框不能为空，需输入相应的文字。";

            } else {

                LabelValidation.Text = string.Empty;

                Archive entity = new Archive();

                entity.Name = TextBoxArchiveType.Text;
                entity.CreateTimes = DateTime.Now;
                entity.Status = 0;

                InvokeUtil.SystemService.EntityUpdate(entity);

                OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ArchiveTypeManager"));
            }
        }
    }
}

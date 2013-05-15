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

namespace EnforceForm
{
    public partial class frmEditCompanyType : BaseTableForm
    {
        CompanyType CompanyType = null;
        public frmEditCompanyType()
        {
            InitializeComponent();
        }
        public frmEditCompanyType(CompanyType companyType)
            : this()
        {
            CompanyType = companyType;
        }

        private void frmEditCompanyType_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {

                if (CompanyType != null)
                {
                    SetEntity(CompanyType);
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void SaveData()
        {
            if (CompanyType == null)
                CompanyType = new CompanyType();

            GetEntity(CompanyType);

            InvokeUtil.SystemService.EntityUpdate(CompanyType);
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmCompanyTypes"));
        }
    }
}

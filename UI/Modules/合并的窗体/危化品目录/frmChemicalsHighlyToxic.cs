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
    public partial class frmChemicalsHighlyToxic : BaseTableForm
    {
        public ChemicalsHighlyToxic chemicalsHighlyToxic;

        public frmChemicalsHighlyToxic()
        {
            InitializeComponent();
        }

        public frmChemicalsHighlyToxic(ChemicalsHighlyToxic chemicalsHighlyToxic)
            : this()
        {
            this.chemicalsHighlyToxic = chemicalsHighlyToxic;
        }

        private void frmChemicalsHighlyToxic_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (chemicalsHighlyToxic != null)
                {
                    SetEntity(chemicalsHighlyToxic);
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
                if (chemicalsHighlyToxic == null)
                    chemicalsHighlyToxic = new ChemicalsHighlyToxic();

                GetEntity(chemicalsHighlyToxic);

                InvokeUtil.SystemService.EntityUpdate(chemicalsHighlyToxic);
                CommonInvoke.MessageBox("操作成功！");
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

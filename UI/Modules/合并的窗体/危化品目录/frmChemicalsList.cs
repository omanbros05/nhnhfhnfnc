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
    public partial class frmChemicalsList : BaseTableForm
    {
        int ChemicalsType = -1;
        public ChemicalsList chemicalsList;

        public frmChemicalsList()
        {
            InitializeComponent();
        }
        public frmChemicalsList(int Type)
            : this()
        {
            ChemicalsType = Type;
        }

        public frmChemicalsList(ChemicalsList chemicalsList,int Type)
            : this()
        {
            this.chemicalsList = chemicalsList;
            ChemicalsType = Type;
        }

        private void frmChemicalsList_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (chemicalsList != null)
                {
                    SetEntity(chemicalsList);
                    if (ChemicalsType != (int)SOA.ORM.ChemicalsList.EChemicalsType.易燃固体)
                    {
                        this.headerLabel1.Text = ((SOA.ORM.ChemicalsList.EChemicalsType)ChemicalsType).ToString();
                    }
                    else
                    {
                        this.headerLabel1.Text = "易燃固体、自燃物品和遇湿易燃物品";
                    }
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
                if (chemicalsList == null)
                    chemicalsList = new ChemicalsList();

                GetEntity(chemicalsList);
                chemicalsList.ChemicalsType = ChemicalsType;
                InvokeUtil.SystemService.EntityUpdate(chemicalsList);
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

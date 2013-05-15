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
    public partial class frmPower : BaseTableForm
    {
        PowerInventory Power = null;
        public frmPower()
        {
            InitializeComponent();
        }
        public frmPower(PowerInventory Power)
            : this()
        {
            this.Power = Power;
        }

        private void frmPower_Load(object sender, EventArgs e)
        {
             UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                this.comboBox1.Items.Clear();
                int Count = 0;
                string Temp = "";
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.PowerInventory.EPowerType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.PowerInventory.EPowerType)i).ToString().Replace("L", "(").Replace("R", ")").Replace("D", "、");
                    if (Count == 0)
                    {
                        Temp = text;
                        Count++;
                    }
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                this.comboBox1.Text = Temp;

                if (Power != null)
                {
                    this.txtTitle.Text = Power.PowerName;
                    this.txtNumber.Text = Power.PowerNumber;
                    this.txtSubject.Text = Power.PowerSubject;
                    this.comboBox1.Text = ((SOA.ORM.PowerInventory.EPowerType)Power.PowerType).ToString();
                    this.txtContent.Text = Power.PowerContent;
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
                if (Power == null)
                    Power = new PowerInventory();

                if (this.txtTitle.Text.Trim() == "")
                {
                    CommonInvoke.MessageBox("标题不能为空！");
                    return;
                }

                Power.PowerName = this.txtTitle.Text.Trim();
                Power.PowerType = Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                Power.PowerNumber = this.txtNumber.Text;
                Power.PowerSubject = this.txtSubject.Text;
                Power.PowerContent = this.txtContent.Text;
                InvokeUtil.SystemService.EntityUpdate(Power);
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

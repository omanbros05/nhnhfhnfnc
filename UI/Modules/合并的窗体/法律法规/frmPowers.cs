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
    public partial class frmPowers : BaseFormDetails
    {
        public frmPowers()
        {
            InitializeComponent();
        }
        private string _moduleName;
        private object _object;
        public frmPowers(string module, object obj) : this() {
            _moduleName = module;
            _object = obj;
        }

        private void DoBack(object sender, EventArgs e) {
            if (_object == null)
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.StartPage"));
            else
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs(_moduleName, new object[]{ _object }));
            
        }

        private void frmPowers_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                this.comboBox1.Items.Clear();
                this.comboBox1.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.PowerInventory.EPowerType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.PowerInventory.EPowerType)i).ToString().Replace("L", "(").Replace("R", ")").Replace("D", "、");
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                this.comboBox1.Text = "全部";

                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                frmPower frm = new frmPower();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewPowerInventory.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewPowerInventory.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                PowerInventory Power = enforceLawGridViewPowerInventory.SelectedRows[0].Tag as PowerInventory;
                frmPower frm = new frmPower(Power);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewPowerInventory.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewPowerInventory.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewPowerInventory.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        PowerInventory Power = row.Tag as PowerInventory;
                        InvokeUtil.SystemService.EntityRemove(Power);
                        enforceLawGridViewPowerInventory.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        public override void Reload()
        {
            int SelectValue = -1;
            try
            {
                if (this.comboBox1.SelectedItem.ToString() != "全部" && this.comboBox1.SelectedItem.ToString() != "")
                {
                    SelectValue = Convert.ToInt32(((EnforceForm.ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                }
            }
            catch
            { }

            EList<PowerInventory> PowerInventorys = InvokeUtil.SystemService.PowerGetAll(pager.CurrentPage, pager.PageSize, this.txtName.Text, SelectValue);
            pager.TotalCount = PowerInventorys.TotalCount;
            enforceLawGridViewPowerInventory.Rows.Clear();
            foreach (PowerInventory Power in PowerInventorys.Items)
            {
                int index = enforceLawGridViewPowerInventory.Rows.Add();
                DataGridViewRow dr = enforceLawGridViewPowerInventory.Rows[index];
                dr.Cells[0].Value = ((SOA.ORM.PowerInventory.EPowerType)Power.PowerType).ToString();
                dr.Cells[1].Value = Power.PowerNumber;
                dr.Cells[2].Value = Power.PowerName;
                dr.Tag = Power;
            }
        }
        private void pager_CurrentPageChangedEvent(object sender, Pager.CurrentPageChangedEventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = enforceLawGridViewPowerInventory.SelectedRows;
            if (rows.Count == 0)
                return;

            if (rows[0].Tag == null)
                return;


            try
            {
                PowerInventory Power = rows[0].Tag as PowerInventory;
                //frmPower frm = new frmPower(Power);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.PowerViewer", new object[]{ Power , _moduleName, _object}));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

        }

    }
}

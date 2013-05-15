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
    public partial class frmInstrumentsExamples : BaseFormDetails
    {
        int ParentType = -1;
        public frmInstrumentsExamples()
        {
            InitializeComponent();
        }
        public frmInstrumentsExamples(int ParentType)
            : this()
        {
            this.ParentType = ParentType;
        }

        private void frmInstrumentsExamples_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                this.comboBox1.Items.Clear();
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EInstrumentsType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EInstrumentsType)i).ToString().Replace("L","(").Replace("R",")");
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                this.comboBox1.Text = ((SOA.ORM.InstrumentsExample.EInstrumentsType)ParentType).ToString();
                InitData();
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
                InitData();
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
                frmInstrumentsExample frm = new frmInstrumentsExample(Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
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
            if (enforceLawGridViewInstrumentsExample.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewInstrumentsExample.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InstrumentsExample InstrumentsExample = enforceLawGridViewInstrumentsExample.SelectedRows[0].Tag as InstrumentsExample;
                frmInstrumentsExample frm = new frmInstrumentsExample(InstrumentsExample);
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
            if (enforceLawGridViewInstrumentsExample.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewInstrumentsExample.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewInstrumentsExample.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;


                        InstrumentsExample InstrumentsExample = row.Tag as InstrumentsExample;
                        string FilePath = InstrumentsExample.InstrumentsPath;
                        InvokeUtil.SystemService.EntityRemove(InstrumentsExample);
                        enforceLawGridViewInstrumentsExample.Rows.Remove(row);

                        if (System.IO.File.Exists(FilePath))
                        {
                            System.IO.File.Delete(FilePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void InitData()
        {
            EList<InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(pager.CurrentPage, pager.PageSize, this.txtName.Text.Trim(), ParentType, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
            pager.TotalCount = InstrumentsExamples.TotalCount;
            enforceLawGridViewInstrumentsExample.Bind<InstrumentsExample>(InstrumentsExamples.Items);
        }

        private void toolStripButtonAdd_Click_1(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                frmInstrumentsExample frm = new frmInstrumentsExample();
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            this.comboBox2.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
            int Type = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
            if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESiteInspectionType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件处理)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseHandleType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseHandleType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseTransferredType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseTransferredType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESealPunishType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESealPunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EPunishInformDefenseType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EPunishInformDefenseType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECallsFineType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECallsFineType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESimplePunishType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESimplePunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseCloasedType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseCloasedType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseSurveyType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseSurveyType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EHearingChengpiType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EHearingChengpiType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESiteInspectionType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EAdminPunishType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EAdminPunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ERectificationReviewType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ERectificationReviewType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
            }

            this.comboBox2.Text = "全部";
        }

        private void toolStripButtonOutPut_Click(object sender, EventArgs e)
        {
            if (enforceLawGridViewInstrumentsExample.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewInstrumentsExample.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InstrumentsExample InstrumentsExample = enforceLawGridViewInstrumentsExample.SelectedRows[0].Tag as InstrumentsExample;
                frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExample);
                frm.OpenWindow(this);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}

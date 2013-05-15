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
    public partial class frmInstrumentsFolders : BaseFormDetails
    {
        int ParentType = -1;
        public frmInstrumentsFolders()
        {
            InitializeComponent();
        }
        public frmInstrumentsFolders(int ParentType)
            : this()
        {
            this.ParentType = ParentType;
        }

        private void frmInstrumentsFolders_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                this.comboBox1.Items.Clear();
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EInstrumentsType)))
                {
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EInstrumentsType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox1.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                this.comboBox1.Text = ((SOA.ORM.InstrumentsExample.EInstrumentsType)ParentType).ToString();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        public override void Reload()
        {
            EList<InstrumentsHistoryFolder> Folders = InvokeUtil.SystemService.InstrumentsHistoryFolderGetAll(pager.CurrentPage, pager.PageSize, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox3.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox4.SelectedItem)).selectValue));
            pager.TotalCount = Folders.TotalCount;
            enforceLawGridViewInstrumentsFolder.Rows.Clear();
            foreach (InstrumentsHistoryFolder Folder in Folders.Items)
            {
                int index = enforceLawGridViewInstrumentsFolder.Rows.Add();
                DataGridViewRow dr = enforceLawGridViewInstrumentsFolder.Rows[index];
                dr.Cells[0].Value = Folder.ID.ToString();
                string text = "";
                if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
                {
                    text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件处理)
                {
                    text = ((SOA.ORM.InstrumentsExample.ECaseHandleType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送)
                {
                    text = ((SOA.ORM.InstrumentsExample.ECaseTransferredType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚)
                {
                    text = ((SOA.ORM.InstrumentsExample.ESealPunishType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩)
                {
                    text = ((SOA.ORM.InstrumentsExample.EPunishInformDefenseType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款)
                {
                    text = ((SOA.ORM.InstrumentsExample.ECallsFineType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程)
                {
                    text = ((SOA.ORM.InstrumentsExample.ESimplePunishType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案)
                {
                    text = ((SOA.ORM.InstrumentsExample.ECaseCloasedType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查)
                {
                    text = ((SOA.ORM.InstrumentsExample.ECaseSurveyType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.听证会与呈批)
                {
                    text = ((SOA.ORM.InstrumentsExample.EHearingChengpiType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
                {
                    text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚)
                {
                    text = ((SOA.ORM.InstrumentsExample.EAdminPunishType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else if (Folder.InstrumentsParentType == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查)
                {
                    text = ((SOA.ORM.InstrumentsExample.ERectificationReviewType)Folder.InstrumentsChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                dr.Cells[1].Value = text;
                dr.Cells[2].Value = Folder.InstrumentsYear + "年" + Folder.InstrumentsMonth + "月";
            }
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
    }
}

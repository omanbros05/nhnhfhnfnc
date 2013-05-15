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
    public partial class frmInstrumentsExample : BaseTableForm
    {
        public int ParentType = -1;
        public int ChildType = -1;
        public InstrumentsExample instrumentsExample;

        public frmInstrumentsExample()
        {
            InitializeComponent();
        }
        public frmInstrumentsExample(int ParentType,int ChildType):this()
        {
            this.ParentType = ParentType;
            this.ChildType = ChildType;
        }
        public frmInstrumentsExample(InstrumentsExample instrumentsExample)
            : this()
        {
            this.instrumentsExample = instrumentsExample;
            this.ParentType = instrumentsExample.InstrumentsType;
            this.ChildType = instrumentsExample.InstrumentsChildType;
        }

        private void frmInstrumentsExample_Load(object sender, EventArgs e)
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

                InitData();
                if (instrumentsExample != null)
                {
                    this.txtTitle.Text = instrumentsExample.InstrumentsTitle;
                    this.txtPath.Text = instrumentsExample.InstrumentsPath;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private string ShowSaveFileDialog()
        {
            string theFile;
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "word Files(*.doc)|*.doc|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = openFileDialog1.FileName;
                string desfolderdir = Application.StartupPath + @"\文书示例";
                string FileName = Path.GetFileName(theFile);
                if (!Directory.Exists(desfolderdir)) { Directory.CreateDirectory(desfolderdir); }
                if (File.Exists(desfolderdir + @"\" + FileName))
                {
                    File.Delete(desfolderdir + @"\" + FileName);
                }
                File.Copy(theFile, desfolderdir + @"\" + FileName);

                return @"\文书示例" + @"\" + FileName;
            }
            else
            {
                return "";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (instrumentsExample == null)
                    instrumentsExample = new InstrumentsExample();


                instrumentsExample.InstrumentsTitle = txtTitle.Text.Trim();
                instrumentsExample.InstrumentsType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
                instrumentsExample.InstrumentsChildType = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue);
                string path = this.txtPath.Text.Trim();
                if (path != "")
                {
                    instrumentsExample.InstrumentsPath = path;
                }

                InvokeUtil.SystemService.EntityUpdate(instrumentsExample);
                CommonInvoke.MessageBox("操作成功！");
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void InitData()
        { 
            this.comboBox2.Items.Clear();
            int Type = Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue);
            int count = 0;
            if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESiteInspectionType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件处理)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseHandleType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseHandleType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseHandleType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseHandleType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.案件移送)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseTransferredType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseTransferredType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseTransferredType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseTransferredType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.查封或扣押处罚)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESealPunishType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESealPunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESealPunishType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESealPunishType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.处罚告知与申辩)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EPunishInformDefenseType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EPunishInformDefenseType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EPunishInformDefenseType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EPunishInformDefenseType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.催缴与分期罚款)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECallsFineType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECallsFineType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECallsFineType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECallsFineType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.简易处罚流程)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESimplePunishType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESimplePunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESimplePunishType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESimplePunishType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.结案与延期结案)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseCloasedType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseCloasedType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseCloasedType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseCloasedType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.立案调查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ECaseSurveyType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ECaseSurveyType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseSurveyType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ECaseSurveyType)count).ToString().Replace("L", "(").Replace("R", ")");
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
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EHearingChengpiType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EHearingChengpiType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ESiteInspectionType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ESiteInspectionType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.行政处罚)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.EAdminPunishType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.EAdminPunishType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EAdminPunishType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.EAdminPunishType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
            else if (Type == (int)SOA.ORM.InstrumentsExample.EInstrumentsType.整改复查)
            {
                foreach (int i in Enum.GetValues(typeof(SOA.ORM.InstrumentsExample.ERectificationReviewType)))
                {
                    if (count == 0)
                    {
                        count = i;
                    }
                    int value = i;
                    string text = ((SOA.ORM.InstrumentsExample.ERectificationReviewType)i).ToString().Replace("L", "(").Replace("R", ")");
                    this.comboBox2.Items.Add(new ComboBoxItemTextValue(value.ToString(), text));
                }
                if (Type == ParentType && ChildType != -1)
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ERectificationReviewType)ChildType).ToString().Replace("L", "(").Replace("R", ")");
                }
                else
                {
                    this.comboBox2.Text = ((SOA.ORM.InstrumentsExample.ERectificationReviewType)count).ToString().Replace("L", "(").Replace("R", ")");
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtPath.Text = ShowSaveFileDialog();
        }
    }
}

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
    public partial class frmCompanyHighlyToxicChemicals : BaseFormDetails
    {
        public frmCompanyHighlyToxicChemicals()
        {
            InitializeComponent();

            EList<CompanyArea> Areas = InvokeUtil.SystemService.CompanyAreaGetAll();
            this.comboBox2.Items.Clear();
            this.comboBox2.Items.Add(new ComboBoxItemTextValue("-1", "所有"));
            foreach (CompanyArea Area in Areas.Items)
            {
                this.comboBox2.Items.Add(new ComboBoxItemTextValue(Area.ID.ToString(), Area.AreaName));
            }
            this.comboBox2.Text = "所有";

            this.comboBox1.Items.Add(new ComboBoxItemTextValue("-1", "全部"));
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("1", "是"));
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("0", "否"));
            this.comboBox1.Text = "全部";
        }
        private void frmCompanyHighlyToxicChemicals_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //InitData();
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
                frmCompanyHighlyToxicChemical frm = new frmCompanyHighlyToxicChemical();
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
            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows[0].Tag as CompanyHighlyToxicChemicals;
                CompanyHighlyToxicChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyHighlyToxicChemicals.CompanyID });
                frmCompanyHighlyToxicChemical frm = new frmCompanyHighlyToxicChemical(CompanyHighlyToxicChemicals);
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
            if (enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyHighlyToxicChemicals.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = row.Tag as CompanyHighlyToxicChemicals;
                        CompanyHighlyToxicChemicals.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyHighlyToxicChemicals.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyHighlyToxicChemicals);
                        enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
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

        public override void Reload()
        {
            EList<CompanyHighlyToxicChemicals> CompanyHighlyToxicChemicals = InvokeUtil.SystemService.CompanyHighlyToxicChemicalsGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
            pager.TotalCount = CompanyHighlyToxicChemicals.TotalCount;
            this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Clear();
            for (int i = 0; i < CompanyHighlyToxicChemicals.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows.Add();

                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[0].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[3].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[4].Value = CompanyHighlyToxicChemicals.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[5].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[6].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[7].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[8].Value = CompanyHighlyToxicChemicals.Items[i].Company.JuridicalPersonJob;
                if (CompanyHighlyToxicChemicals.Items[i].Company.Mobile == "" || CompanyHighlyToxicChemicals.Items[i].Company.Tel == "")
                {
                    if (CompanyHighlyToxicChemicals.Items[i].Company.Mobile != "")
                    {
                        this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[9].Value = CompanyHighlyToxicChemicals.Items[i].Company.Mobile;
                    }
                    else
                    {
                        this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[9].Value = CompanyHighlyToxicChemicals.Items[i].Company.Tel;
                    }
                }
                else
                {
                    this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[9].Value = CompanyHighlyToxicChemicals.Items[i].Company.Mobile + "/" + CompanyHighlyToxicChemicals.Items[i].Company.Tel;
                }


                this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Tag = CompanyHighlyToxicChemicals.Items[i];

                if (CompanyHighlyToxicChemicals.Items[i].Company.IsCity == 1)
                {
                    this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[1].Value = "是";
                }
                else
                {
                    this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[1].Value = "否";
                }
                try
                {
                    CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyHighlyToxicChemicals.Items[i].Company.CompanyAreaID });
                    this.enforceLawGridViewCompanyHighlyToxicChemicals.Rows[index].Cells[2].Value = area.AreaName;
                }
                catch
                { }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                string theFile;
                openFileDialog1.InitialDirectory = Application.ExecutablePath;
                openFileDialog1.Filter = "excel Files(*.xls)|*.xls|All Files(*.*)|*.*";//xlsx
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    theFile = openFileDialog1.FileName;
                    DataTable dt = ExcelToTable(theFile);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        CompanyHighlyToxicChemicals CompanyHighlyToxicChemicals = new CompanyHighlyToxicChemicals();
                        CompanyHighlyToxicChemicals.MainProducts = dt.Rows[j][9].ToString();
                        CompanyHighlyToxicChemicals.Registration = dt.Rows[j][10].ToString();

                        try
                        {
                            if (dt.Rows[j][11].ToString() != "")
                            {
                                string[] DateString = dt.Rows[j][11].ToString().Split('-');
                                if (dt.Rows[j][11].ToString().IndexOf("-") == -1)
                                {
                                    DateString = dt.Rows[j][11].ToString().Split('至');
                                }
                                if (dt.Rows[j][11].ToString().IndexOf("-") == -1 && dt.Rows[j][11].ToString().IndexOf("至") == -1)
                                {
                                    DateString = dt.Rows[j][11].ToString().Split('到');
                                }
                                if (DateString.Length <= 0)
                                {
                                    CompanyHighlyToxicChemicals.ValidStartDate = DateTime.Parse("1900-01-01");
                                    CompanyHighlyToxicChemicals.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else if (DateString.Length == 1)
                                {
                                    CompanyHighlyToxicChemicals.ValidStartDate = DateTime.Parse(DateString[0]);
                                    CompanyHighlyToxicChemicals.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else
                                {
                                    if (DateString.Length > 0)
                                    {
                                        CompanyHighlyToxicChemicals.ValidStartDate = DateTime.Parse(DateString[0]);
                                    }
                                    if (DateString.Length > 1)
                                    {
                                        CompanyHighlyToxicChemicals.ValidEndDate = DateTime.Parse(DateString[1]);
                                    }
                                }
                            }
                        }
                        catch { }

                        CompanyHighlyToxicChemicals.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyHighlyToxicChemicals.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyHighlyToxicChemicals.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyHighlyToxicChemicals.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyHighlyToxicChemicals.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyHighlyToxicChemicals.Company.Tel = dt.Rows[j][5].ToString();

                        if (dt.Rows[j][12].ToString() != "")
                        {
                            CompanyHighlyToxicChemicals.Company.IsCity = 1;
                        }
                        else
                        {
                            CompanyHighlyToxicChemicals.Company.IsCity = 0;
                        }
                        CompanyArea Area = InvokeUtil.SystemService.CompanyAreaGetOne(dt.Rows[j][13].ToString());
                        CompanyHighlyToxicChemicals.Company.CompanyAreaID = Area.ID;

                        EList<CompanyHighlyToxicChemicals> CompanyList = InvokeUtil.SystemService.CompanyHighlyToxicChemicalsGetAll(1, 20, CompanyHighlyToxicChemicals.Company.CompanyName,-1,-1);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyHighlyToxicChemicals);
                        }
                    }
                    Reload();
                    CommonInvoke.MessageBox("操作成功！");
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}


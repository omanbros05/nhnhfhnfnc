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
    public partial class frmCompanyNoCoalSecuritys : BaseFormDetails
    {
        public frmCompanyNoCoalSecuritys()
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
        private void frmCompanyNoCoalSecuritys_Load(object sender, EventArgs e)
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
                frmCompanyNoCoalSecurity frm = new frmCompanyNoCoalSecurity();
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
            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyNoCoalSecurity CompanyNoCoalSecurity = enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows[0].Tag as CompanyNoCoalSecurity;
                CompanyNoCoalSecurity.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyNoCoalSecurity.CompanyID });
                frmCompanyNoCoalSecurity frm = new frmCompanyNoCoalSecurity(CompanyNoCoalSecurity);
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
            if (enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyNoCoalSecuritys.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyNoCoalSecurity CompanyNoCoalSecurity = row.Tag as CompanyNoCoalSecurity;
                        CompanyNoCoalSecurity.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyNoCoalSecurity.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyNoCoalSecurity);
                        enforceLawGridViewCompanyNoCoalSecuritys.Rows.Remove(row);
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
            EList<CompanyNoCoalSecurity> CompanyNoCoalSecurity = InvokeUtil.SystemService.CompanyNoCoalSecurityGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
            pager.TotalCount = CompanyNoCoalSecurity.TotalCount;
            this.enforceLawGridViewCompanyNoCoalSecuritys.Rows.Clear();
            for (int i = 0; i < CompanyNoCoalSecurity.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyNoCoalSecuritys.Rows.Add();

                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[0].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[3].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[4].Value = CompanyNoCoalSecurity.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[5].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[6].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[7].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[8].Value = CompanyNoCoalSecurity.Items[i].Company.JuridicalPersonJob;
                if (CompanyNoCoalSecurity.Items[i].Company.Mobile == "" || CompanyNoCoalSecurity.Items[i].Company.Tel == "")
                {
                    if (CompanyNoCoalSecurity.Items[i].Company.Mobile != "")
                    {
                        this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[9].Value = CompanyNoCoalSecurity.Items[i].Company.Mobile;
                    }
                    else
                    {
                        this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[9].Value = CompanyNoCoalSecurity.Items[i].Company.Tel;
                    }
                }
                else
                {
                    this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[9].Value = CompanyNoCoalSecurity.Items[i].Company.Mobile + "/" + CompanyNoCoalSecurity.Items[i].Company.Tel;
                }


                this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Tag = CompanyNoCoalSecurity.Items[i];
                if (CompanyNoCoalSecurity.Items[i].Company.IsCity == 1)
                {
                    this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[1].Value = "是";
                }
                else
                {
                    this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[1].Value = "否";
                }
                try
                {
                    CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyNoCoalSecurity.Items[i].Company.CompanyAreaID });
                    this.enforceLawGridViewCompanyNoCoalSecuritys.Rows[index].Cells[2].Value = area.AreaName;
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
                        CompanyNoCoalSecurity CompanyNoCoalSecurity = new CompanyNoCoalSecurity();
                        CompanyNoCoalSecurity.CertificateNumber = dt.Rows[j][9].ToString();
                        CompanyNoCoalSecurity.EconomicType = dt.Rows[j][10].ToString();
                        CompanyNoCoalSecurity.MiningMethods = dt.Rows[j][12].ToString();
                        CompanyNoCoalSecurity.PermitRange = dt.Rows[j][13].ToString();
                        CompanyNoCoalSecurity.StandardizationRegister = dt.Rows[j][11].ToString();
                        try
                        {
                            if (dt.Rows[j][14].ToString() != "")
                            {
                                string[] DateString = dt.Rows[j][14].ToString().Split('-');
                                if (dt.Rows[j][14].ToString().IndexOf("-") == -1)
                                {
                                    DateString = dt.Rows[j][14].ToString().Split('至');
                                }
                                if (dt.Rows[j][14].ToString().IndexOf("-") == -1 && dt.Rows[j][14].ToString().IndexOf("至") == -1)
                                {
                                    DateString = dt.Rows[j][14].ToString().Split('到');
                                }
                                if (DateString.Length <= 0)
                                {
                                    CompanyNoCoalSecurity.ValidStartDate = DateTime.Parse("1900-01-01");
                                    CompanyNoCoalSecurity.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else if (DateString.Length == 1)
                                {
                                    CompanyNoCoalSecurity.ValidStartDate = DateTime.Parse(DateString[0]);
                                    CompanyNoCoalSecurity.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else
                                {
                                    if (DateString.Length > 0)
                                    {
                                        CompanyNoCoalSecurity.ValidStartDate = DateTime.Parse(DateString[0]);
                                    }
                                    if (DateString.Length > 1)
                                    {
                                        CompanyNoCoalSecurity.ValidEndDate = DateTime.Parse(DateString[1]);
                                    }
                                }
                            }
                        }
                        catch { }

                        CompanyNoCoalSecurity.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyNoCoalSecurity.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyNoCoalSecurity.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyNoCoalSecurity.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyNoCoalSecurity.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyNoCoalSecurity.Company.Tel = dt.Rows[j][5].ToString();

                        if (dt.Rows[j][15].ToString() != "")
                        {
                            CompanyNoCoalSecurity.Company.IsCity = 1;
                        }
                        else
                        {
                            CompanyNoCoalSecurity.Company.IsCity = 0;
                        }
                        CompanyArea Area = InvokeUtil.SystemService.CompanyAreaGetOne(dt.Rows[j][16].ToString());
                        CompanyNoCoalSecurity.Company.CompanyAreaID = Area.ID;

                        EList<CompanyNoCoalSecurity> CompanyList = InvokeUtil.SystemService.CompanyNoCoalSecurityGetAll(1, 20, CompanyNoCoalSecurity.Company.CompanyName,-1,-1);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyNoCoalSecurity);
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


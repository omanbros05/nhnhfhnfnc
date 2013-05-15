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
    public partial class frmCompanyFireworks : BaseFormDetails
    {
        public frmCompanyFireworks()
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
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("1","是"));
            this.comboBox1.Items.Add(new ComboBoxItemTextValue("0", "否"));
            this.comboBox1.Text = "全部";
        }

        private void frmCompanyFireworks_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                //Reload();
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
                frmCompanyFirework frm = new frmCompanyFirework();
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
            if (enforceLawGridViewCompanyFireworks.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewCompanyFireworks.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyFireworks CompanyFireworks = enforceLawGridViewCompanyFireworks.SelectedRows[0].Tag as CompanyFireworks;
                CompanyFireworks.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyFireworks.CompanyID });
                frmCompanyFirework frm = new frmCompanyFirework(CompanyFireworks);
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
            if (enforceLawGridViewCompanyFireworks.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewCompanyFireworks.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewCompanyFireworks.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyFireworks CompanyFireworks = row.Tag as CompanyFireworks;
                        CompanyFireworks.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyFireworks.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyFireworks);
                        enforceLawGridViewCompanyFireworks.Rows.Remove(row);
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
            EList<CompanyFireworks> CompanyFireworks = InvokeUtil.SystemService.CompanyFireworksGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
            pager.TotalCount = CompanyFireworks.TotalCount;
            this.enforceLawGridViewCompanyFireworks.Rows.Clear();
            for (int i = 0; i < CompanyFireworks.Items.Count; i++)
            {
                int index = this.enforceLawGridViewCompanyFireworks.Rows.Add();

                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[0].Value = CompanyFireworks.Items[i].Company.CompanyName;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[3].Value = CompanyFireworks.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[4].Value = CompanyFireworks.Items[i].Company.CompanyPost;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[5].Value = CompanyFireworks.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[6].Value = CompanyFireworks.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[7].Value = CompanyFireworks.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[8].Value = CompanyFireworks.Items[i].Company.JuridicalPersonJob;
                if (CompanyFireworks.Items[i].Company.Mobile == "" || CompanyFireworks.Items[i].Company.Tel == "")
                {
                    if (CompanyFireworks.Items[i].Company.Mobile != "")
                    {
                        this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[9].Value = CompanyFireworks.Items[i].Company.Mobile;
                    }
                    else
                    {
                        this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[9].Value = CompanyFireworks.Items[i].Company.Tel;
                    }
                }
                else
                {
                    this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[9].Value = CompanyFireworks.Items[i].Company.Mobile + "/" + CompanyFireworks.Items[i].Company.Tel;
                }



                if (CompanyFireworks.Items[i].Company.IsCity == 1)
                {
                    this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[1].Value = "是";
                }
                else
                {
                    this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[1].Value = "否";
                }
                try
                {
                    CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyFireworks.Items[i].Company.CompanyAreaID });
                    this.enforceLawGridViewCompanyFireworks.Rows[index].Cells[2].Value = area.AreaName;
                }
                catch
                { }

                this.enforceLawGridViewCompanyFireworks.Rows[index].Tag = CompanyFireworks.Items[i];
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
                        CompanyFireworks CompanyFireworks = new CompanyFireworks();
                        CompanyFireworks.PermitBusinessScope = dt.Rows[j][11].ToString();
                        CompanyFireworks.PermitCertificateNo = dt.Rows[j][9].ToString();
                        CompanyFireworks.WarehousAddress = dt.Rows[j][10].ToString();

                        try
                        {
                            if (dt.Rows[j][12].ToString() != "")
                            {
                                string[] DateString = dt.Rows[j][12].ToString().Split('-');
                                if (dt.Rows[j][12].ToString().IndexOf("-") == -1)
                                {
                                    DateString = dt.Rows[j][12].ToString().Split('至');
                                }
                                if (dt.Rows[j][12].ToString().IndexOf("-") == -1 && dt.Rows[j][12].ToString().IndexOf("至") == -1)
                                {
                                    DateString = dt.Rows[j][12].ToString().Split('到');
                                }
                                if (DateString.Length <= 0)
                                {
                                    CompanyFireworks.ValidStartDate = DateTime.Parse("1900-01-01");
                                    CompanyFireworks.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else if (DateString.Length == 1)
                                {
                                    CompanyFireworks.ValidStartDate = DateTime.Parse(DateString[0]);
                                    CompanyFireworks.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else
                                {
                                    if (DateString.Length > 0)
                                    {
                                        CompanyFireworks.ValidStartDate = DateTime.Parse(DateString[0]);
                                    }
                                    if (DateString.Length > 1)
                                    {
                                        CompanyFireworks.ValidEndDate = DateTime.Parse(DateString[1]);
                                    }
                                }
                            }
                        }
                        catch { }

                        //CompanyFireworks.Company = new Company();
                        CompanyFireworks.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyFireworks.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyFireworks.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyFireworks.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyFireworks.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyFireworks.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyFireworks.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyFireworks.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyFireworks.Company.Tel = dt.Rows[j][5].ToString();

                        if (dt.Rows[j][13].ToString() != "")
                        {
                            CompanyFireworks.Company.IsCity = 1;
                        }
                        else
                        {
                            CompanyFireworks.Company.IsCity = 0;
                        }
                        CompanyArea Area = InvokeUtil.SystemService.CompanyAreaGetOne(dt.Rows[j][14].ToString());
                        CompanyFireworks.Company.CompanyAreaID = Area.ID;

                        EList<CompanyFireworks> CompanyList = InvokeUtil.SystemService.CompanyFireworksGetAll(1, 20, CompanyFireworks.Company.CompanyName,-1,-1);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyFireworks);
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

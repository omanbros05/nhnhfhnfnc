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
    public partial class frmCompanyDangerChemicalsProduces : BaseFormDetails
    {
        public frmCompanyDangerChemicalsProduces()
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
        private void frmCompanyDangerChemicalsProduces_Load(object sender, EventArgs e)
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
                frmCompanyDangerChemicalsProduce frm = new frmCompanyDangerChemicalsProduce();
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
            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count == 0)
                return;

            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows[0].Tag == null)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows[0].Tag as CompanyDangerChemicalsProduce;
                CompanyDangerChemicalsProduce.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicalsProduce.CompanyID });
                frmCompanyDangerChemicalsProduce frm = new frmCompanyDangerChemicalsProduce(CompanyDangerChemicalsProduce);
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
            if (enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count == 0)
                return;

            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CommonInvoke.MessageBox("是否删除这" + enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows.Count + "项记录？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in enforceLawGridViewfrmCompanyDangerChemicalsProduces.SelectedRows)
                    {
                        if (row.Tag == null)
                            continue;

                        CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = row.Tag as CompanyDangerChemicalsProduce;
                        CompanyDangerChemicalsProduce.Company = (Company)InvokeUtil.SystemService.EntityInit(new Company { CompanyID = CompanyDangerChemicalsProduce.CompanyID });
                        InvokeUtil.SystemService.EntityRemove(CompanyDangerChemicalsProduce);
                        enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Remove(row);
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
            EList<CompanyDangerChemicalsProduce> CompanyDangerChemicalsProduce = InvokeUtil.SystemService.CompanyDangerChemicalsProduceGetAll(pager.CurrentPage, pager.PageSize, tableTextBoxCompanyName.Text, Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox1.SelectedItem)).selectValue), Convert.ToInt32(((ComboBoxItemTextValue)(this.comboBox2.SelectedItem)).selectValue));
            pager.TotalCount = CompanyDangerChemicalsProduce.TotalCount;
            this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Clear();
            for (int i = 0; i < CompanyDangerChemicalsProduce.Items.Count; i++)
            {
                int index = this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows.Add();
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[0].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyName;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[3].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyAddress;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[4].Value = CompanyDangerChemicalsProduce.Items[i].Company.CompanyPost;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[5].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPerson;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[6].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonSex;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[7].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonAge;
                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[8].Value = CompanyDangerChemicalsProduce.Items[i].Company.JuridicalPersonJob;
                if (CompanyDangerChemicalsProduce.Items[i].Company.Mobile == "" || CompanyDangerChemicalsProduce.Items[i].Company.Tel == "")
                {
                    if (CompanyDangerChemicalsProduce.Items[i].Company.Mobile != "")
                    {
                        this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[9].Value = CompanyDangerChemicalsProduce.Items[i].Company.Mobile;
                    }
                    else
                    {
                        this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[9].Value = CompanyDangerChemicalsProduce.Items[i].Company.Tel;
                    }
                }
                else
                {
                    this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[9].Value = CompanyDangerChemicalsProduce.Items[i].Company.Mobile + "/" + CompanyDangerChemicalsProduce.Items[i].Company.Tel;
                }


                this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Tag = CompanyDangerChemicalsProduce.Items[i];

                if (CompanyDangerChemicalsProduce.Items[i].Company.IsCity == 1)
                {
                    this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[1].Value = "是";
                }
                else
                {
                    this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[1].Value = "否";
                }
                try
                {
                    CompanyArea area = (CompanyArea)InvokeUtil.SystemService.EntityInit(new CompanyArea { ID = CompanyDangerChemicalsProduce.Items[i].Company.CompanyAreaID });
                    this.enforceLawGridViewfrmCompanyDangerChemicalsProduces.Rows[index].Cells[2].Value = area.AreaName;
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
                        CompanyDangerChemicalsProduce CompanyDangerChemicalsProduce = new CompanyDangerChemicalsProduce();
                        CompanyDangerChemicalsProduce.PermitRange = dt.Rows[j][9].ToString();
                        try
                        {
                            if (dt.Rows[j][10].ToString() != "")
                            {
                                string[] DateString = dt.Rows[j][10].ToString().Split('-');
                                if (dt.Rows[j][10].ToString().IndexOf("-") == -1)
                                {
                                    DateString = dt.Rows[j][10].ToString().Split('至');
                                }
                                if (dt.Rows[j][10].ToString().IndexOf("-") == -1 && dt.Rows[j][10].ToString().IndexOf("至") == -1)
                                {
                                    DateString = dt.Rows[j][10].ToString().Split('到');
                                }
                                if (DateString.Length <= 0)
                                {
                                    CompanyDangerChemicalsProduce.ValidStartDate = DateTime.Parse("1900-01-01");
                                    CompanyDangerChemicalsProduce.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else if (DateString.Length == 1)
                                {
                                    CompanyDangerChemicalsProduce.ValidStartDate = DateTime.Parse(DateString[0]);
                                    CompanyDangerChemicalsProduce.ValidEndDate = DateTime.Parse("1900-01-01");
                                }
                                else
                                {
                                    if (DateString.Length > 0)
                                    {
                                        CompanyDangerChemicalsProduce.ValidStartDate = DateTime.Parse(DateString[0]);
                                    }
                                    if (DateString.Length > 1)
                                    {
                                        CompanyDangerChemicalsProduce.ValidEndDate = DateTime.Parse(DateString[1]);
                                    }
                                }
                            }
                        }
                        catch { }

                        CompanyDangerChemicalsProduce.Company.CompanyAddress = dt.Rows[j][7].ToString();
                        CompanyDangerChemicalsProduce.Company.CompanyName = dt.Rows[j][0].ToString();
                        CompanyDangerChemicalsProduce.Company.CompanyPost = dt.Rows[j][8].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPerson = dt.Rows[j][1].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonAge = dt.Rows[j][3].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonJob = dt.Rows[j][4].ToString();
                        CompanyDangerChemicalsProduce.Company.JuridicalPersonSex = dt.Rows[j][2].ToString();
                        CompanyDangerChemicalsProduce.Company.Mobile = dt.Rows[j][6].ToString();
                        CompanyDangerChemicalsProduce.Company.Tel = dt.Rows[j][5].ToString();

                        if (dt.Rows[j][11].ToString() != "")
                        {
                            CompanyDangerChemicalsProduce.Company.IsCity = 1;
                        }
                        else
                        {
                            CompanyDangerChemicalsProduce.Company.IsCity = 0;
                        }
                        CompanyArea Area = InvokeUtil.SystemService.CompanyAreaGetOne(dt.Rows[j][12].ToString());
                        CompanyDangerChemicalsProduce.Company.CompanyAreaID = Area.ID;

                        EList<CompanyDangerChemicalsProduce> CompanyList = InvokeUtil.SystemService.CompanyDangerChemicalsProduceGetAll(1, 20, CompanyDangerChemicalsProduce.Company.CompanyName,-1,-1);
                        if (CompanyList.Items.Count <= 0)
                        {
                            InvokeUtil.SystemService.EntityUpdate(CompanyDangerChemicalsProduce);
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

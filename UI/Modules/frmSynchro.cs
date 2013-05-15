using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Threading;
using SOA;
using SOA.ORM;
using NBear.Mapping;
using NBearLite;
using Common;

namespace Maleos.Modules
{
    public partial class frmSynchro : Form
    {
        public frmSynchro()
        {
            InitializeComponent();
        }

        private void buttonOpenExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                textBoxExportFileName.Text = saveFileDialog.FileName;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(
                delegate {
                    if (textBoxExportFileName.Text.Trim() == "")
                        return;

                    buttonExport.Enabled = false;
                    buttonOpenExport.Enabled = false;
                    listViewLogs.Items.Clear();
                    try
                    {
                        listViewLogs.Items.Insert(0,"正在准备导出...");
                        XElement Elements = new XElement("Elements");
                        List<EntityInterface> Entitys = new List<EntityInterface>();
                        Assembly assembly = Assembly.Load("SOA");
                        Type[] Types = assembly.GetExportedTypes();
                        progressBar.Maximum = Types.Length + 2;
                        progressBar.Value = 1;
                        listViewLogs.Items.Insert(0,"正在搜集导出数据...");
                        foreach (Type type in Types)
                        {
                            SynchroAttribute[] Attributes = (SynchroAttribute[])type.GetCustomAttributes(typeof(SynchroAttribute), true);
                            if (Attributes.Length > 0)
                            {
                                EntityInterface entity = Activator.CreateInstance(type) as EntityInterface;
                                foreach (EntityInterface item in entity.GetSynchroAll())
                                {
                                    string xml = Common.Serializer.XMLSerialize(item);
                                    XElement element = new XElement("Element", xml);
                                    element.Add(new XAttribute("AssemblyType", item.GetType().FullName));
                                    Elements.Add(element);
                                }
                            }

                            progressBar.Value += 1;
                        }
                        listViewLogs.Items.Insert(0,"搜集完毕,正在压缩数据...");
                        string result = Common.StringCompress.CompressString(System.Text.Encoding.UTF8.GetBytes(Elements.ToString()));
                        listViewLogs.Items.Insert(0,"正在写入文件" + textBoxExportFileName.Text.Trim() + "...");
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(textBoxExportFileName.Text.Trim(), false, Encoding.UTF8))
                        {
                            sw.Write(result);
                            sw.Close();
                            progressBar.Value += 1;
                        }
                        listViewLogs.Items.Insert(0,"写入文件" + textBoxExportFileName.Text.Trim() + "完成...");
                    }
                    catch (Exception ex)
                    {
                        listViewLogs.Items.Insert(0,"导出失败(原因:" + ex.Message + ")");
                    }
                    buttonExport.Enabled = true;
                    buttonOpenExport.Enabled = true;
                }
                );
           
        }

        private void buttonOpenImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                textBoxImportFileName.Text = openFileDialog.FileName;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(
                delegate {
                    buttonOpenImport.Enabled = false;
                    buttonOpenImport.Enabled = false;
                    try
                    {
                        if (textBoxImportFileName.Text.Trim() == "")
                            return;

                        listViewLogs.Items.Clear();
                        progressBar.Maximum = 100;
                        progressBar.Value = 0;
                        listViewLogs.Items.Insert(0,"开始导入...");
                        string file = "";
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(textBoxImportFileName.Text.Trim(), Encoding.UTF8)) 
                        {
                            listViewLogs.Items.Insert(0,"正在读取文件...");
                            file = sr.ReadToEnd();
                            file = Encoding.UTF8.GetString(Common.StringCompress.DecompressString(file));
                            listViewLogs.Items.Add("文件读取成功...");
                            progressBar.Value += 1;
                        }
                        Assembly assembly = Assembly.Load("SOA");
                        listViewLogs.Items.Insert(0,"开始分析...");
                        progressBar.Value += 1;
                        XElement Elements = XElement.Parse(file);
                        listViewLogs.Items.Insert(0,"分析成功...");
                        progressBar.Value += 1;
                        if (Elements.HasElements)
                        {
                            progressBar.Maximum = 3 + Elements.Elements().Count();
                            listViewLogs.Items.Insert(0,"正在进行数据同步...");
                            foreach (XElement element in Elements.Elements())
                            {
                                EntityInterface entity = (EntityInterface)Common.Serializer.Deserialize
                                    (assembly.GetType(element.Attribute("AssemblyType").Value), element.Value);

                                entity.UpdateSynchro();
                                progressBar.Value += 1;
                            }
                            listViewLogs.Items.Insert(0,"数据同步成功...");
                        }
                    }
                    catch (Exception ex)
                    {
                        listViewLogs.Items.Insert(0,"数据同步失败(原因:" + ex.Message + ")");
                    }
                    buttonOpenImport.Enabled = true;
                    buttonOpenImport.Enabled = true;
                }
                );
            
        }

        private void frmSynchro_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Serialization;
using EnforceForm;
using EnforceUI;
using SOA;
using SOA.ORM;
using Common;

namespace Maleos.Modules
{
    public partial class OutputDocuemnt : BaseForm
    {
        WordDocument docObj = null;
        private string _moduleName;
        private string _fileName;

        public OutputDocuemnt()
        {
            InitializeComponent();

            FormPosition = ShowFormPosition.FormMain;

            saveFileDialog.InitialDirectory = Application.StartupPath;
        }

        public OutputDocuemnt(WordDocument wordDoc)
            : this()
        {
            this.docObj = wordDoc;
            Fill();
        }

        public OutputDocuemnt(WordDocument wordDoc, string moduleName) : this() {
            this.docObj = wordDoc;
            Fill();
            _moduleName = moduleName;
        }

        public OutputDocuemnt(WordDocument wordDoc, string moduleName, string fileName) : this() {

            this.docObj = wordDoc;
            _moduleName = moduleName;
            _fileName = fileName;
            Fill();
        }

        private void Fill()
        {
            doc.Document.BeginUpdate();
            try
            {
                string templeate = System.Configuration.ConfigurationManager.AppSettings["Template"].ToString();
                string path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + "\\" + templeate + "\\" + docObj.DocName + ".rtf");
                doc.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.Rtf);
                
                
                //填充字段
                foreach (DocField field in docObj.Fields)
                {
                    if (doc.Document.Bookmarks[field.MarkName] != null)
                    {
                        if (field.FieldType == EFieldType.Text)
                            doc.Document.InsertText(doc.Document.Bookmarks[field.MarkName].Range.Start, (string)field.MarkValue);
                        else if (field.FieldType == EFieldType.Html)
                            doc.Document.InsertHtmlText(doc.Document.Bookmarks[field.MarkName].Range.Start, (string)field.MarkValue);
                        else if (field.FieldType == EFieldType.Image)
                            doc.Document.InsertImage(doc.Document.Bookmarks[field.MarkName].Range.Start, (Image)field.MarkValue);
                    }
                }

                foreach (DocField foot in docObj.FootFields)
                {
                    //超变态的东西，无参的BeginUpdateFooter居然不行。。。只能第一页、奇数页、偶数页一页页地更新
                    DevExpress.XtraRichEdit.API.Native.SubDocument footer = doc.Document.Sections[0].BeginUpdateFooter(DevExpress.XtraRichEdit.API.Native.HeaderFooterType.First);
                    if(footer.Bookmarks[foot.MarkName] != null)
                        footer.InsertText(footer.Bookmarks[foot.MarkName].Range.Start, (string)foot.MarkValue);
                    doc.Document.Sections[0].EndUpdateFooter(footer);

                    footer = doc.Document.Sections[0].BeginUpdateFooter(DevExpress.XtraRichEdit.API.Native.HeaderFooterType.Odd);
                    if (footer.Bookmarks[foot.MarkName] != null)
                        footer.InsertText(footer.Bookmarks[foot.MarkName].Range.Start, (string)foot.MarkValue);
                    doc.Document.Sections[0].EndUpdateFooter(footer);

                    footer = doc.Document.Sections[0].BeginUpdateFooter(DevExpress.XtraRichEdit.API.Native.HeaderFooterType.Even);
                    if (footer.Bookmarks[foot.MarkName] != null)
                        footer.InsertText(footer.Bookmarks[foot.MarkName].Range.Start, (string)foot.MarkValue);
                    doc.Document.Sections[0].EndUpdateFooter(footer);
                }

                for (int i = 0; i < doc.Document.Tables.Count; i++)
                {
                    DevExpress.XtraRichEdit.API.Native.Table table = doc.Document.Tables.ElementAtOrDefault(i);
                    if (table != null)
                    {
                        table.BeginUpdate();
                        try
                        {
                            Grid grid = null;
                            //获取第一行中对表格的配置
                            string config = doc.Document.GetText(table.FirstRow.Range).Trim();

                            if (config == "")
                                continue;

                            if (config.IndexOf("Mark") == -1)
                                continue;

                            string[] spConfig = config.Split(',');

                            int insertBeginRow = 0;
                            string tableMark = string.Empty;
                            foreach (string s in spConfig)
                            {
                                if (s.IndexOf("Mark") != -1)
                                {
                                    tableMark = s.Replace("Mark=", "");
                                    grid = docObj.FindGrid(tableMark);
                                    if (grid == null)
                                        throw new Exception("模板中不存在Mark为" + tableMark + "的表！");
                                }

                                if (s.IndexOf("InsertBeginRow=") != -1)
                                    insertBeginRow = Convert.ToInt32(s.Replace("InsertBeginRow=", ""));
                            }

                            table.FirstRow.Delete();//删除第一行
                            for (int j = 0; j < grid.Rows.Count; j++)
                            {
                                GridRow gridRow = grid.Rows[j];
                                DevExpress.XtraRichEdit.API.Native.TableRow row = table.Rows.InsertAfter(insertBeginRow);
                                for (int k = 0; k < gridRow.Items.Count; k++)
                                    doc.Document.InsertText(row[k].Range.Start, gridRow.Items[k]);
                            }
                        }
                        catch { }
                        finally
                        {
                            table.EndUpdate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                doc.Document.EndUpdate();
                // 打开文档后，自动保存到指定目录。
                //doc.Document.SaveDocument(_fileName, DevExpress.XtraRichEdit.DocumentFormat.Doc);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void doc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) {
                doc.Document.SaveDocument(_fileName, DevExpress.XtraRichEdit.DocumentFormat.Rtf);
                e.Handled = true;
            }
                
        }

        private void barButtonItemSaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            doc.Document.SaveDocument(_fileName, DevExpress.XtraRichEdit.DocumentFormat.Rtf);

        }

        private void barButtonItemSaveDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                string docPath = AppDomain.CurrentDomain.BaseDirectory + "Archives";
                if (!System.IO.Directory.Exists(docPath))
                    System.IO.Directory.CreateDirectory(docPath);

                if (docObj.Entity != null)
                {
                    EntityInterface entity = docObj.Entity.UpdateImportDocument(docObj.DocName);
                    if (entity != null)
                    {
                        ImportDocument importDocument = entity as ImportDocument;
                        string fileName = docPath + "\\" + importDocument.DiskDocName + ".doc";
                        if (System.IO.File.Exists(fileName))
                        {
                            if (Common.CommonInvoke.MessageBox("文档已存在是否替换原先文档？(如继续将替换原先的文档)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                return;
                        }
                        doc.Document.SaveDocument(fileName, DevExpress.XtraRichEdit.DocumentFormat.Doc);
                        CommonInvoke.MessageBox("操作成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs(_moduleName));
        }

        private void doc_DocumentLoaded(object sender, EventArgs e)
        {
            doc.Document.SaveDocument(_fileName, DevExpress.XtraRichEdit.DocumentFormat.Rtf);
        }
    }
}

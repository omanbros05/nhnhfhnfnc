using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using SOA.ORM;
using Common;

namespace Maleos.Modules
{
    public partial class ArchiveViewer : Controls.BasePage
    {
        public ArchiveViewer()
        {
            InitializeComponent();
        }
        private int _id;
        private string _name;

        public ArchiveViewer(int id, string name) : this() {
            _id = id;
            _name = name;

            Fill();
            SetHeaderTitle();
        }

        private void Fill() {
            DataSet ds = Utility.GetArchiveExtByArchiveId(_id);
            listBoxControl1.DataSource = ds.Tables[0];
            listBoxControl1.DisplayMember = "Title";
            listBoxControl1.ValueMember = "FileName";

            if (ds.Tables[0].Rows.Count > 0) {
                string path = (string)listBoxControl1.GetItemValue(0);
                LoadDoc(path);
                //richEditControl1.Document.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.Rtf);
            } else {

                this.Controls.Remove(listBoxControl1);
                this.Controls.Remove(richEditControl1);
                this.BackgroundImage = Image.FromFile("images/Under_Construction.png");
                this.BackgroundImageLayout = ImageLayout.Center;
            }
        }

        private void LoadDoc(string file) {

            //richEditControl1.Document.LoadDocument(file, DevExpress.XtraRichEdit.DocumentFormat.Rtf);

            if (System.IO.File.Exists(file))
                richEditControl1.LoadDocument(file);
            else {
                richEditControl1.CreateNewDocument();
                richEditControl1.Document.AppendText("所要打开的文件不存在磁盘上，可能已经被物理删除或移动到其他位置。");
            }
        }

        private void SetHeaderTitle() {

            header1.Title = _name.Replace("<size=14>", "").Replace("<br>", "").Replace("</size>","");
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {

            var obj = listBoxControl1.GetItemValue(listBoxControl1.SelectedIndex);
            if (obj.GetType() == typeof(string))
            {
                LoadDoc((string)obj);
            }
        }

        private void DoBack(object sender, EventArgs e) {

            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.Archives"));
        }
    }
}

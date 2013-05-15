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
using Maleos.Modules;
using System.IO;
using System.Drawing.Imaging;

namespace EnforceForm
{
    public partial class frmSpotShoot : BaseTableForm
    {
        string dirPath = "/SpotPic/";
        string rootPath = AppDomain.CurrentDomain.BaseDirectory;

        public SpotShoot spotShoot;

        public frmSpotShoot()
        {
            InitializeComponent();
        }

        public frmSpotShoot(SpotShoot spotShoot)
            : this()
        {
            this.spotShoot = spotShoot;
        }

        private void frmSpotShoot_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotShoot != null)
                {
                    SpotName.Text = spotShoot.SpotName;
                    ShootDate.Value = spotShoot.ShootDate;


                    for (int i = 0; i < spotShoot.Items.Count; i++)
                    {
                        SpotShootItem item = spotShoot.Items[i];

                        string dir = item.SpotPhoto.Remove(0, 1);

                        if (i == 0)
                        {
                            pictureBoxShoot1.Image = (Image)Bitmap.FromFile(dir);
                            pictureBoxShoot1.Tag = item.SpotPhoto;
                            ShootAddress1.Text = item.ShootAddress;
                            PhotoIllustr1.Text = item.PhotoIllustr;
                        }

                        if (i == 1)
                        {
                            pictureBoxShoot2.Image = (Image)Bitmap.FromFile(dir);
                            pictureBoxShoot2.Tag = item.SpotPhoto;
                            ShootAddress2.Text = item.ShootAddress;
                            PhotoIllustr2.Text = item.PhotoIllustr;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                SaveData();
                //CloseWindow();
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotShoots"));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonInsertImage1_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InsertImage(pictureBoxShoot1);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void buttonInsertImage2_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                InsertImage(pictureBoxShoot2);
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private string SaveFile(PictureBox pictureBox)
        { 
            string fullPath = Path.Combine(rootPath + dirPath);
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);

            string fileName = CommonInvoke.NewGuid + ".jpg";

            pictureBox.Image.Save(fullPath + fileName);

            return dirPath + fileName;
        }

        private string SaveFile(Image image) {
            if (image == null)
                return string.Empty;
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            string fileName = CommonInvoke.NewGuid + ".jpg";
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            image.Dispose();
            image = null;

            string dir = dirPath.Remove(0, 1).Replace("/", "\\");

            FileStream outStream = File.OpenWrite(rootPath + dir + fileName);
            ms.WriteTo(outStream);
            outStream.Flush();
            outStream.Close();
            outStream.Dispose();
            outStream = null;
 
            return dirPath + fileName;
        }


        private void InsertImage(PictureBox pictureBox)
        {
            try
            {
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        byte[] file = new byte[fs.Length];
                        fs.Read(file, 0, (int)fs.Length);
                        using (MemoryStream ms = new MemoryStream(file))
                        {
                            pictureBox.Image = Image.FromStream(new MemoryStream(file));
                            pictureBox.Tag = file;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private MemoryStream LoadImage(string filename) {
            using (MemoryStream ms = new MemoryStream())
            {
                Image image = Image.FromFile(filename);
                image.Save(ms, ImageFormat.Bmp);

                return ms;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (spotShoot == null)
                {
                    spotShoot = new SpotShoot();
                    spotShoot.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
                }
                spotShoot.Status = 1;
                SaveData();
                WordDocument doc = new WordDocument("现场图片");

                doc.AddField("SpotName", spotShoot.SpotName);
 
                //pictureBoxShoot1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                string dir = spotShoot.Items[0].SpotPhoto.Remove(0, 1);
                Image image = CommonInvoke.ResizeImageFile(LoadImage(dir).ToArray(), 330, 320);
                doc.AddField("SpotPhoto1",image , EFieldType.Image);
                doc.AddField("ShootAddress1", ShootAddress1.Text);
                doc.AddField("PhotoIllustr1", PhotoIllustr1.Text);

                //pictureBoxShoot2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                dir = spotShoot.Items[1].SpotPhoto.Remove(0, 1);
                image = CommonInvoke.ResizeImageFile(LoadImage(dir).ToArray(), 330, 320);
                doc.AddField("SpotPhoto2", image, EFieldType.Image);

                
                doc.AddField("ShootAddress2", ShootAddress2.Text);
                doc.AddField("PhotoIllustr2", PhotoIllustr2.Text);

                //OutputDocuemnt frm = new OutputDocuemnt(doc);
                //frm.OpenWindow(this);
                OnNavigationRequest(new Maleos.NavigationRequestEventArgs("Maleos.Modules.OutputDocuemnt", 
                    new object[] { doc, "EnforceForm.frmSpotShoots", spotShoot.FilePath }));
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }

        private void SaveData()
        {
            if (spotShoot == null)
            {
                spotShoot = new SpotShoot();
                spotShoot.FilePath = Utility.GetFileSavePath() + Utility.BuilderFileName();
            }

            spotShoot.SpotName = SpotName.Text;
            spotShoot.ShootDate = ShootDate.Value;

            Image image1 = (Image)pictureBoxShoot1.Image.Clone();
            pictureBoxShoot1.Image.Dispose();
            pictureBoxShoot1.Image = null;
            Image image2 = (Image)pictureBoxShoot2.Image.Clone();
            pictureBoxShoot2.Image.Dispose();
            pictureBoxShoot2.Image = null;

            int length = spotShoot.Items.Count;
            string[] filename = new string[length];

            for (int i = 0; i < length; i++) {

                filename[i] = spotShoot.Items[i].SpotPhoto;
            }

            //foreach (SpotShootItem subItem in spotShoot.Items)
            //{
            //    File.Delete(subItem.SpotPhoto);
            //}

            spotShoot.Items.Clear();
            SpotShootItem item = new SpotShootItem();
            item.SpotPhoto = SaveFile(image1);//SaveFile(pictureBoxShoot1);
            item.ShootAddress = ShootAddress1.Text;
            item.PhotoIllustr = PhotoIllustr1.Text;
            spotShoot.Items.Add(item);

            item = new SpotShootItem();
            item.SpotPhoto = SaveFile(image2);//SaveFile(pictureBoxShoot2);
            item.ShootAddress = ShootAddress2.Text;
            item.PhotoIllustr = PhotoIllustr2.Text;

            spotShoot.Items.Add(item);

            InvokeUtil.SystemService.EntityUpdate(spotShoot);

            for (int i = 0; i < length; i++) {

                File.Delete(filename[i]);
            }
        }

        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            try
            {
                //frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(Application.StartupPath + @"\文书示例\拍照取证.doc");
                //frm.OpenWindow(this);
                EList<SOA.ORM.InstrumentsExample> InstrumentsExamples = InvokeUtil.SystemService.InstrumentsExampleGetAll(1, 10, "", (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查, (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场检查记录);
                if (InstrumentsExamples.Items.Count > 0)
                {
                    //frmInstrumentsExampleContent frm = new frmInstrumentsExampleContent(InstrumentsExamples.Items[0]);
                    //frm.OpenWindow(this);

                    SaveData();
                    OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmInstrumentsExampleContent",
                            new object[] { InstrumentsExamples.Items[0], "EnforceForm.frmSpotShoot", spotShoot }));
                }

            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmSpotShoots"));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //frmLawQuery frm = new frmLawQuery((int)SOA.ORM.LawFile.ELawType.综合);
            //frm.OpenWindow(this);
            SaveData();
            OnNavigationRequest(new Maleos.NavigationRequestEventArgs("EnforceForm.frmPowers", new object[] { "EnforceForm.frmSpotShoot", spotShoot }));
        }
    }
}


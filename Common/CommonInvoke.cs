using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Common
{
    public class CommonInvoke
    {
        const string PASSWORD = "123456";

        /// <summary>
        /// 返回GUID
        /// </summary>
        public static string NewGuid
        {
            get
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        /// <summary>
        /// 新密码
        /// </summary>
        public static string NewPassWord
        {
            get
            {
                return Cryptography.EncryptString(PASSWORD);
            }
        }

        /// <summary>
        /// 当前时间字符串
        /// </summary>
        public static string CurrentDateString
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        public static Image ResizeImageFile(byte[] imageFile, int targetSizeW, int targetSizeH)
        {
            byte[] file = ResizeImageFileBytes(imageFile, targetSizeW, targetSizeH);
            using (MemoryStream ms = new MemoryStream(file))
            {
                return Image.FromStream(ms);
            }

        }

        public static byte[] ResizeImageFileBytes(byte[] imageFile, int targetSizeW, int targetSizeH)
        {
            System.Drawing.Image original = System.Drawing.Image.FromStream(new MemoryStream(imageFile));
            int targetH, targetW;
            targetW = targetSizeW;
            targetH = (int)(original.Height * ((float)targetSizeW / (float)original.Width));
            if (targetH > targetSizeH)
            {
                targetH = targetSizeH;
                targetW = (int)(original.Width * ((float)targetSizeH / (float)original.Height));
            }
            if (targetSizeW < (int)original.Width || targetSizeH < (int)original.Height)
            {
                System.Drawing.Image imgPhoto = System.Drawing.Image.FromStream(new MemoryStream(imageFile));
                // Create a new blank canvas.  The resized image will be drawn on this canvas.
                Bitmap bmPhoto = new Bitmap(targetW, targetH, PixelFormat.Format24bppRgb);
                bmPhoto.SetResolution(72, 72);
                Graphics grPhoto = Graphics.FromImage(bmPhoto);
                grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
                grPhoto.DrawImage(imgPhoto, new Rectangle(0, 0, targetW, targetH), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel);
                // Save out to memory and then to a file.  We dispose of all objects to make sure the files don't stay locked.
                MemoryStream mm = new MemoryStream();
                bmPhoto.Save(mm, System.Drawing.Imaging.ImageFormat.Jpeg);
                original.Dispose();
                imgPhoto.Dispose();
                bmPhoto.Dispose();
                grPhoto.Dispose();
                return mm.GetBuffer();
            }
            else
            {
                return imageFile;
            }
        }

        public static Type GetCSharpVariableType(DbType dbType)
        {
            switch (dbType)
            {

                case DbType.AnsiString: return typeof(string);
                case DbType.AnsiStringFixedLength: return typeof(string);
                case DbType.Binary: return typeof(byte[]);
                case DbType.Boolean: return typeof(bool);
                case DbType.Byte: return typeof(byte);
                case DbType.Currency: return typeof(decimal);
                case DbType.Date: return typeof(DateTime);
                case DbType.DateTime: return typeof(DateTime);
                case DbType.Decimal: return typeof(decimal);
                case DbType.Double: return typeof(double);
                case DbType.Guid: return typeof(Guid);
                case DbType.Int16: return typeof(short);
                case DbType.Int32: return typeof(int);
                case DbType.Int64: return typeof(long);
                case DbType.Object: return typeof(object);
                case DbType.SByte: return typeof(sbyte);
                case DbType.Single: return typeof(float);
                case DbType.String: return typeof(string);
                case DbType.StringFixedLength: return typeof(string);
                case DbType.Time: return typeof(TimeSpan);
                case DbType.UInt16: return typeof(ushort);
                case DbType.UInt32: return typeof(uint);
                case DbType.UInt64: return typeof(ulong);
                case DbType.VarNumeric: return typeof(decimal);
                default:
                    {
                        return typeof(object);
                    }
            }
        }

        #region 通用对话框
        /// <summary>
        /// 显示对话框
        /// </summary>
        public static DialogResult MessageBox(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return System.Windows.Forms.MessageBox.Show(text, "系统", buttons, icon);
        }
        public static DialogResult MessageBox(string text, MessageBoxIcon icon)
        {
            return MessageBox(text, MessageBoxButtons.OK, icon);
        }
        public static DialogResult MessageBox(string text, MessageBoxButtons buttons)
        {
            return MessageBox(text, buttons, MessageBoxIcon.Information);
        }
        public static DialogResult MessageBox(string text)
        {
            return MessageBox(text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ErrorMessageBox(string message)
        {
            return MessageBox(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ErrorMessageBox(Exception ex)
        {
            return MessageBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
           
        #endregion
    }
}

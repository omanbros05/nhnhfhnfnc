using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using SOA;
using SOA.ORM;
using EnforceUI;

namespace Maleos
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserInfo user = InvokeUtil.SystemService.GetActiveUser();

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            SkinManager.EnableFormSkins();
            SkinBlobXmlCreator skinCreator = new SkinBlobXmlCreator("MetroBlack",
                "Maleos.UI.SkinData.", typeof(Program).Assembly, null);
            SkinManager.Default.RegisterSkin(skinCreator);

            UserLookAndFeel.Default.SetSkinStyle("Metropolis");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen1));

            int i = new Random().Next(5000);
            if (i <= 2000 || i % 1000 == 0)
                i = 2 * i;

            System.Threading.Thread.Sleep(i);

            // 根据当年年份创建一个文件夹，文件夹规则：archives/'yyyy'
            // 1、检索当前目录是否存在，不存在则创建
            string folder = DateTime.Now.ToString("yyyy");
            string root = "archives/";
            string path = root + folder;
            bool folderExists = System.IO.Directory.Exists(path);
            
            if (!folderExists) {
                System.IO.Directory.CreateDirectory(path);
            }
            Application.Run(new FrmMain());
        }
    }
}

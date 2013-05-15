using System;
using Maleos.Model;

namespace Maleos.Modules
{
    public partial class LauncherExt : Controls.BasePage
    {
        public LauncherExt() : this(null, PageType.None, null) {
           // 构造函数重载调用
        }

        public LauncherExt(string fileName, PageType type, object entity) {

            InitializeComponent();

            // 在需要使用到Header控件中的BackEvent事件时，首先在构造函数中进行事件的注册，
            // 其次，在当前窗体（或用户控件）中，创建对应的事件调用类，如header1_BackEvent(...)
            // 最后调用BasePage类中的OnNavigationRequestEventHandler函数，参数是NavigationRequestEventArgs
            // 的实例对象，请参考header1_BackEvent函数
            header1.BackEvent += new EventHandler(header1_BackEvent);

            //if (string.IsNullOrEmpty(fileName) || type == PageType.None || entity == null) return;
        }

        void InitData(object entity, PageType type) {
            if (entity == null) return;

            

            switch (type) { 
                case PageType.ApprovalCases :
                    ApprovalCasesInfo approvalCasesInfo = (ApprovalCasesInfo)entity;
                    IApprovalCases approvalCases = new ApprovalCases();
                    approvalCases.Insert(RichEditControl.Document, approvalCasesInfo);
                break;


            }
        }

        private void header1_BackEvent(object sender, EventArgs e)
        {
            // 例如，点击返回按钮时，将页面回调到首页，则使用如下代码
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage"));

            // 如果需要向被调用的页面传递参数时，则使用如下代码（在调用带参数的实体时，需要在该实体中实现构造函数的参数传递）
            // OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.StartPage", new object[]{"param1", "param2"});
        }

        private DevExpress.XtraRichEdit.RichEditControl RichEditControl {
            get { return launcher1.RichEditControl; }
        }

        private void LoadDoc(string fileName) {
            string path = Utilities.GetRelativePath(fileName);
            if (!string.IsNullOrEmpty(path)) {
                RichEditControl.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.Doc);
            }
        }

    }

    /// <summary>
    /// 系统中使用到的各种使用小组件函数，实现应用程序中的各种小功能。
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// 根据文件名称所有文件的绝对路径包括文件的名称
        /// </summary>
        /// <param name="name">带后缀的文件名称</param>
        /// <returns>如果搜索到文件的路径则返回文件以及文件的绝对路径，否则返回空字符</returns>
        public static string GetRelativePath(string name) {
            name = "Template\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++)
            {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
    }
}

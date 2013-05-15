using System;
using System.Windows.Forms;

namespace Maleos
{

    public enum PageType { 
        None,
        ApprovalCases
    }

    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain() {
            InitializeComponent();
            //Helpers.ColorHelper.MainForm = this;
        }

        void LoadPage(string pageName, object[] args) {
            // 利用反射机制进行对象的实例化，这有助于应用程序的可扩展性，但从某种意义上降低了程序运行的效率
            Maleos.Controls.BasePage control = (Maleos.Controls.BasePage)System.Reflection.Assembly.Load(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name).CreateInstance(
                pageName, true, System.Reflection.BindingFlags.CreateInstance, null, args, null, null);
            control.Dock = DockStyle.Fill;
            control.NavigationRequest += new NavigationRequestEventHandler(NavigationRequestHandler);
            this.Controls.Clear();
            this.Controls.Add(control);
        }

        public void LoadPage(string pageName) {

            Maleos.Controls.BasePage control = (Maleos.Controls.BasePage)System.Reflection.Assembly.Load(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name).CreateInstance(pageName);
            control.Dock = DockStyle.Fill;
            control.NavigationRequest += new NavigationRequestEventHandler(NavigationRequestHandler);
            this.Controls.Clear();
            this.Controls.Add(control);
        }

        public void ShowWaitForm() {

            if (splashScreenManager2.IsSplashFormVisible)
                splashScreenManager2.CloseWaitForm();
            splashScreenManager2.ShowWaitForm();
        
        }

        public void CloseWaitForm() {
            if (splashScreenManager2.IsSplashFormVisible) {
                splashScreenManager2.CloseWaitForm();
            }
        }

        void NavigationRequestHandler(object sender, NavigationRequestEventArgs e) {

            ShowWaitForm();
            // 根据不同参数进行页面调用，如果调用的页面需要传递参数，则传递“object[]”
            if (e.Args == null)
            {
                LoadPage(e.PageName);
            }
            else
            {
                LoadPage(e.PageName, e.Args);
            }
            CloseWaitForm();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            // 加载首页
            LoadPage("Maleos.Modules.StartPage");
        }

        public static Form Instance {
            get { return new FrmMain(); }
        }

        public static void Shutdown() {

            if (Common.CommonInvoke.MessageBox("正在注销系统。\r\r--点击“是”按钮成功注销\r\r--点击“否”按钮取消退出程序",
                 System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question)
                 == System.Windows.Forms.DialogResult.Yes) {
                System.Environment.Exit(0);
            }
        }
    }


    // 利用委托加载窗体，这样可以避免在某些地方需要实例化对象调用（部分地方实例化对象不方便，但事件可以做到）
    public delegate void NavigationRequestEventHandler(object sender, NavigationRequestEventArgs e);

    public class NavigationRequestEventArgs : EventArgs {

        public NavigationRequestEventArgs(string pageName)
        {
            PageName = pageName;
        }

        public NavigationRequestEventArgs(string pageName, object[] args) {
            PageName = pageName;
            Args = args;
        }

        public string PageName { get; set; }
        public object[] Args { get; set; }
    }
}
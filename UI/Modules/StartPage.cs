using Maleos.Controls;
namespace Maleos.Modules
{
    public partial class StartPage : BasePage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void tiFactories_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            // 需要调用某个窗体时（在这里全部采用用户控件的方式实现），调用BasePage中的
            // OnNavigationRequest函数，其参数为FrmMain中的NavigationRequestEventArgs对象，
            // 需要实例化该对象。
            // 注：NavigationRequestEventArgs类不属于FrmMain类的一部分，只是存在于同一个命
            // 名空间中，后期需要对该类进行维护优化，把代码从FrmMain类文件中移除。
            //OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.Factories"));
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.Enterprise"));

        }

        private void tiHistory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.LauncherExt", new object[]{"ocr.doc", PageType.ApprovalCases, null}));
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.Archives"));
        }

        private void tiInspect_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.CheckMenu"));
        }

        private void tiPenalize_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.Penalties"));
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.AdmistrativePenalties"));
        }

        private void tiMSDS_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ChemicalsList"));
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.ChemicalsMenu"));
        }

        private void tiLawFile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.LawList"));
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.LegalMenu"));
        }

        private void tiModule_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("Maleos.Modules.InstrumentsExample"));
        }
        private void tiDataSync_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSynchro frm = new frmSynchro();
            frm.ShowDialog(this);
        }

        private void tiPower_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OnNavigationRequest(new NavigationRequestEventArgs("EnforceForm.frmPowers"));
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmMain.Shutdown();
        }
    }
}


namespace Maleos.Controls
{
    public partial class BasePage : DevExpress.XtraEditors.XtraUserControl
    {
        public BasePage()
        {
            InitializeComponent();
        }

        public event NavigationRequestEventHandler NavigationRequest;

        protected void OnNavigationRequest(NavigationRequestEventArgs args)
        {
            if (NavigationRequest != null)
            {
                NavigationRequest(this, args);
            }
        }

        public virtual void Reload()
        { }
    }
}

using ProfilePage.Views;

namespace ProfilePage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
        }
    }
}

using ProfilePage.ViewModels;

namespace ProfilePage
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }
    }

}

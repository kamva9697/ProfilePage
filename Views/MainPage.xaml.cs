using ProfilePage.ViewModels;
using ProfilePage.Views;

namespace ProfilePage
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        async void NagivateToEditPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditPage(), true);
        }

    }

}

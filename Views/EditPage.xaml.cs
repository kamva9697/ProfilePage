using Android.Net;

namespace ProfilePage.Views;


public partial class EditPage : ContentPage
{
    public EditPage()
    {
        InitializeComponent();
    }

        async void BackToPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
}
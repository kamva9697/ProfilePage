using Microsoft.Extensions.Logging;
using ProfilePage.ViewModels;
using ProfilePage.Views;

namespace ProfilePage
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Cache Page and ViewModel States
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            // Ephemeral Page, has no state.
            builder.Services.AddTransient<EditPage>();

            return builder.Build();
        }
    }
}

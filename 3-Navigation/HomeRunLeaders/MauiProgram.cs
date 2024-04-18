using Microsoft.Extensions.Logging;
using HomeRunLeaders.View;
using HomeRunLeaders.Services;

namespace HomeRunLeaders
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<LeadersService>();
            builder.Services.AddSingleton<LeadersViewModel>();

            builder.Services.AddSingleton<MainPage>();
            return builder.Build();
        }
    }
}

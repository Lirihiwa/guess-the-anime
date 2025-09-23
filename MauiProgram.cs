using Microsoft.Extensions.Logging;

namespace GuessTheAnime
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
                    fonts.AddFont("Yourmate.ttf", "Yourmate");
                });

            return builder.Build();
        }
    }
}

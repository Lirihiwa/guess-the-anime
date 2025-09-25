using GuessTheAnime.Services.Alert;
using GuessTheAnime.Services.Song.Loader;
using GuessTheAnime.Services.Song.Player;

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

            builder.Services.AddSingleton<ILoader, HttpSongLoader>();
            builder.Services.AddSingleton<IPlayer, SongPlayer>();
            builder.Services.AddSingleton<IAlertService, AlertService>();

            return builder.Build();
        }
    }
}

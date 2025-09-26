using GuessTheAnime.Services.Alert;
using GuessTheAnime.Services.Loader;
using GuessTheAnime.Services.Player;
using GuessTheAnime.Services.Timer;
using Microsoft.Maui.LifecycleEvents;

namespace GuessTheAnime
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureLifecycleEvents(events =>
                {
#if ANDROID
                    events.AddAndroid(android => android
                    .OnCreate((activity, bundle) =>
                    {
                        activity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
                    }));
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Yourmate.ttf", "Yourmate");
                });

            builder.Services.AddSingleton<IHttpLoader, HttpSongLoader>();
            builder.Services.AddSingleton<IPlayer, SongPlayer>();
            builder.Services.AddSingleton<IAlertService, AlertService>();
            builder.Services.AddSingleton<ITimerService, TimerService>();


            return builder.Build();
        }
    }
}

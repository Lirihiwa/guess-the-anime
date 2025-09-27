using GuessTheAnime.Services.Loader;
using GuessTheAnime.Services.Player;
using GuessTheAnime.Services.Timer;
using GuessTheAnime.Utils;

namespace GuessTheAnime.Services.Quiz
{
    public class QuizService : IQuizService
    {
        private ITimerService _timer;
        private IHttpLoader _httpSongLoader;
        private IPlayer _songPlayer;

        public QuizService(IHttpLoader httpLoader, IPlayer songPlayer, ITimerService timer)
        {
            _timer = timer;
            _httpSongLoader = httpLoader;
            _songPlayer = songPlayer;

            OpeningFullLoaded += OnOpeningFullLoaded;
        }

        public event Action<int>? TimeChanged
        {
            add => _timer.TimeIsChanged += value;
            remove => _timer.TimeIsChanged -= value;
        }

        public event Action<int>? RoundChanged;

        public event Action? TimeToGuess
        {
            add => _timer.TimesUp += value;
            remove => _timer.TimesUp -= value;
        }

        public event Action? Choice;
        public event Action? NextRoundRequired;
        public event Action<Stream>? OpeningFullLoaded
        {
            add => _httpSongLoader.Loaded += value;
            remove => _httpSongLoader.Loaded -= value;
        }

        public async void Initialize()
        {
            _timer.Start(5);
            await _httpSongLoader.LoadAsStreamAsync(UrlGenerator.GetUrlForOpening("BlaCk BuLLet", 1));
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        private void OnOpeningFullLoaded(Stream stream)
        {
            _songPlayer.Play(stream);
        }
    }
}

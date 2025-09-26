using GuessTheAnime.Services.Loader;
using GuessTheAnime.Services.Player;
using GuessTheAnime.Services.Timer;
using GuessTheAnime.Utils;

namespace GuessTheAnime.Services.Quiz
{
    public class QuizService : IQuizService
    {
        private IHttpLoader _httpSongLoader;
        private IPlayer _songPlayer;
        private ITimerService _timer;

        public QuizService(IHttpLoader httpLoader, IPlayer songPlayer, ITimerService timer)
        {
            _httpSongLoader = httpLoader;
            _songPlayer = songPlayer;
            _timer = timer;

            _timer.TimeIsChanged += OnTimeChanged;
            _timer.TimesUp += OnTimesUp;

            //_timer.Start(5);
        }

        public event Action<int>? OnTimeChanged;
        public event Action<int>? OnRoundChanged;
        public event Action? OnTimeToGuess;
        public event Action? OnChoice;
        public event Action? OnNextRoundRequired;
        public event Action? OnOpeningFullLoaded;

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        private void OnTimerChanged(int seconds) => OnTimeChanged?.Invoke(seconds);

        private void OnTimesUp() => OnTimeToGuess?.Invoke();
    }
}

using System.Timers;

namespace GuessTheAnime.Services.Timer
{
    public class TimerService : ITimerService
    {
        private System.Timers.Timer _timer;
        private int _timeout;
        private const int _interval = 1000;

        public event Action? TimesUp;
        public event Action<int>? TimeIsChanged;

        public TimerService()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = _interval;
            _timer.AutoReset = true;

            _timer.Elapsed += OnTimerElapsed;
        }

        public void Start(int timeout)
        {
            Timeout = timeout;
            
            _timer.Start();
        }

        private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
        {
            Timeout--;
        }

        private int Timeout
        {
            get { return  _timeout; }
            set
            {
                if (value == 0)
                {
                    _timer.Stop();
                    TimeIsChanged?.Invoke(value);
                    TimesUp?.Invoke();
                    return;
                }

                _timeout = value;
                TimeIsChanged?.Invoke(value);
            }
        }
    }
}

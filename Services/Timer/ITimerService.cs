namespace GuessTheAnime.Services.Timer
{
    public interface ITimerService
    {
        void Start(int timeout);

        event Action TimesUp;
        event Action<int> TimeIsChanged;
    }
}

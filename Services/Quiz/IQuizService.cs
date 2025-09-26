namespace GuessTheAnime.Services.Quiz
{
    public interface IQuizService
    {
        void Start();
        void Stop();

        /// <summary>
        /// Вызывается если оставшееся время изменилось
        /// </summary>
        event Action<int> OnTimeChanged;

        /// <summary>
        /// Вызывается при смене раунда
        /// </summary>
        event Action<int> OnRoundChanged;

        /// <summary>
        /// Вызывается когда время прослушивания вышло
        /// </summary>
        event Action OnTimeToGuess;

        /// <summary>
        /// Вызывается когда игрок сделал выбор
        /// </summary>
        event Action OnChoice;

        /// <summary>
        /// Вызывается при создании нового раунда
        /// </summary>
        event Action OnNextRoundRequired;

        /// <summary>
        /// Вызывается когда опенинг готов в воспроизведению
        /// </summary>
        event Action OnOpeningFullLoaded;
    }
}

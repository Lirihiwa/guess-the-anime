namespace GuessTheAnime.Services.Quiz
{
    public interface IQuizService
    {
        void Initialize();
        void Stop();

        /// <summary>
        /// Вызывается если оставшееся время изменилось
        /// </summary>
        event Action<int> TimeChanged;

        /// <summary>
        /// Вызывается при смене раунда
        /// </summary>
        event Action<int> RoundChanged;

        /// <summary>
        /// Вызывается когда время прослушивания вышло
        /// </summary>
        event Action TimeToGuess;

        /// <summary>
        /// Вызывается когда игрок сделал выбор
        /// </summary>
        event Action Choice;

        /// <summary>
        /// Вызывается при создании нового раунда
        /// </summary>
        event Action NextRoundRequired;

        /// <summary>
        /// Вызывается когда опенинг готов в воспроизведению
        /// </summary>
        event Action<Stream> OpeningFullLoaded;
    }
}

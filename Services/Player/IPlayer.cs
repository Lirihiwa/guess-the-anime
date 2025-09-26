namespace GuessTheAnime.Services.Player
{
    public interface IPlayer
    {
        void Play(Stream stream);
        void Stop();
    }
}

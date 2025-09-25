namespace GuessTheAnime.Services.Song.Player
{
    public interface IPlayer
    {
        void Play(Stream stream);
        void Stop();
    }
}

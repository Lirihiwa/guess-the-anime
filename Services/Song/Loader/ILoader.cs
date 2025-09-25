namespace GuessTheAnime.Services.Song.Loader
{
    public interface ILoader
    {
        Task<Stream> LoadAsStreamAsync(string url);
    }
}

namespace GuessTheAnime.Services.Loader
{
    public interface IHttpLoader
    {
        Task<Stream> LoadAsStreamAsync(string url);
    }
}

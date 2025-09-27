namespace GuessTheAnime.Services.Loader
{
    public interface IHttpLoader
    {
        Task LoadAsStreamAsync(string url);

        event Action<Stream>? Loaded;
    }
}

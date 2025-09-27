namespace GuessTheAnime.Services.Loader
{
    public class HttpLoader : IHttpLoader
    {
        public async Task LoadAsStreamAsync(string url)
        {
            using HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            var stream = await httpResponseMessage.Content.ReadAsStreamAsync();

            Loaded?.Invoke(stream);
        }

        public event Action<Stream>? Loaded;
    }
}

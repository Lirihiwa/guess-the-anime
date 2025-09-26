namespace GuessTheAnime.Services.Loader
{
    public class HttpSongLoader : IHttpLoader
    {
        public async Task<Stream> LoadAsStreamAsync(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                return await httpResponseMessage.Content.ReadAsStreamAsync();
            }
        }
    }
}

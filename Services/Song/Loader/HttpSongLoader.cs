namespace GuessTheAnime.Services.Song.Loader
{
    public class HttpSongLoader : ILoader
    {
        public async Task<Stream> LoadAsStreamAsync(string url)
        {
            using (HttpClient http = new HttpClient())
            {
                HttpResponseMessage responseMessage = await http.GetAsync(url);
                return await responseMessage.Content.ReadAsStreamAsync();
            }
        }
    }
}

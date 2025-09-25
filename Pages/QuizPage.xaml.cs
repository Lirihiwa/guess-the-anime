using GuessTheAnime.Services.Song.Loader;
using GuessTheAnime.Services.Song.Player;

namespace GuessTheAnime;

public partial class QuizPage : ContentPage
{
	private ILoader _httpSongLoader;
	private IPlayer _songPlayer;

	public QuizPage(ILoader httpSongLoader, IPlayer songPlayer)
	{
		InitializeComponent();

		_httpSongLoader = httpSongLoader;
		_songPlayer = songPlayer;
    }

	//private async void r(object sender, EventArgs e)
	//{
	//	var path = Path.Combine(path1: DotEnv.GetFileServerURL(),
	//							path2: "Black Bullet - OP 1.mp3");

	//	var stream = await _httpSongLoader.LoadAsStreamAsync(path);

	//	await _songPlayer.PlayAsync(stream);
	//}
}
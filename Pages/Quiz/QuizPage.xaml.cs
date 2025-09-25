using GuessTheAnime.Pages.Quiz;
using GuessTheAnime.Services.Song.Loader;
using GuessTheAnime.Services.Song.Player;
using GuessTheAnime.Services.Timer;

namespace GuessTheAnime;

public partial class QuizPage : ContentPage
{
	private ILoader _httpSongLoader;
	private IPlayer _songPlayer;
	private ITimerService _timer;

	public QuizPage(ILoader httpSongLoader, IPlayer songPlayer, ITimerService timer)
	{
		InitializeComponent();

		PastelRainbowAnimation.StartAnimation(this);

		_httpSongLoader = httpSongLoader;
		_songPlayer = songPlayer;
		_timer = timer;

		_timer.TimeIsChanged += OnTimeChanged;
        _timer.TimesUp += OnTimesUp;

		_timer.Start(5);
    }

    private void OnTimesUp()
    {
		_songPlayer.Play(_httpSongLoader.LoadAsStreamAsync(SecretValue.GetFileServerURL() + "Gintama - OP 13.mp3").Result);
    }

	private void OnTimeChanged(int currentTime)
	{
		MainThread.BeginInvokeOnMainThread(() =>
		{
			Sec.Text = currentTime.ToString();
		});
	}

	//private async void r(object sender, EventArgs e)
	//{
	//	var path = Path.Combine(path1: DotEnv.GetFileServerURL(),
	//							path2: "Black Bullet - OP 1.mp3");

	//	var stream = await _httpSongLoader.LoadAsStreamAsync(path);

	//	await _songPlayer.PlayAsync(stream);
	//}
}
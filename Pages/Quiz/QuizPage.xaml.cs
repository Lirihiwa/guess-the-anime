using GuessTheAnime.Pages.Quiz;
using GuessTheAnime.Services.Loader;
using GuessTheAnime.Services.Player;
using GuessTheAnime.Services.Timer;

namespace GuessTheAnime;

public partial class QuizPage : ContentPage
{
	private IHttpLoader _httpSongLoader;
	private IPlayer _songPlayer;
	private ITimerService _timer;

	public QuizPage(IHttpLoader httpSongLoader, IPlayer songPlayer, ITimerService timer)
	{
		InitializeComponent();

		_httpSongLoader = httpSongLoader;
		_songPlayer = songPlayer;
		_timer = timer;

		_timer.TimeIsChanged += OnTimeChanged;
        _timer.TimesUp += OnTimesUp;

		_timer.Start(5);
    }

    private void OnTimesUp()
    {
		var url = Path.Combine(SecretValue.GetFileServerURL(), "openings", "My Hero Academia - OP 7.mp3");
		_songPlayer.Play(_httpSongLoader.LoadAsStreamAsync(url).Result);
    }

	private void OnTimeChanged(int currentTime)
	{
		MainThread.BeginInvokeOnMainThread(() =>
		{
			Sec.Text = currentTime.ToString();
		});
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        PastelRainbowAnimation.StartAnimation(this);
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		PastelRainbowAnimation.StopAnimation();
		_songPlayer.Stop();
	}

	//private async void r(object sender, EventArgs e)
	//{
	//	var path = Path.Combine(path1: DotEnv.GetFileServerURL(),
	//							path2: "Black Bullet - OP 1.mp3");

	//	var stream = await _httpSongLoader.LoadAsStreamAsync(path);

	//	await _songPlayer.PlayAsync(stream);
	//}
}
using GuessTheAnime.Pages.Quiz;
using GuessTheAnime.Services.Loader;
using GuessTheAnime.Services.Player;
using GuessTheAnime.Services.Quiz;
using GuessTheAnime.Services.Timer;
using GuessTheAnime.Utils;

namespace GuessTheAnime;

public partial class QuizPage : ContentPage
{
    private IQuizService _quizService;

	public QuizPage(IQuizService quizService)
	{
		InitializeComponent();

        _quizService = quizService;
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
	}

	//private async void r(object sender, EventArgs e)
	//{
	//	var path = Path.Combine(path1: DotEnv.GetFileServerURL(),
	//							path2: "Black Bullet - OP 1.mp3");

	//	var stream = await _httpSongLoader.LoadAsStreamAsync(path);

	//	await _songPlayer.PlayAsync(stream);
	//}
}
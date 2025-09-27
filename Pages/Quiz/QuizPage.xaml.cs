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

    public QuizPage(IQuizService quizService, IHttpLoader httpLoader, IPlayer songPlayer)
	{
		InitializeComponent();

        _quizService = quizService;

		_quizService.TimeToGuess += OnTimeToGuess;
		_quizService.TimeChanged += OnTimeChanged;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
		PastelRainbowAnimation.StartAnimation(this);
		_quizService.Initialize();
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		PastelRainbowAnimation.StopAnimation();
	}

	private async void OnTimeToGuess()
	{
		
    }

	private void OnTimeChanged(int second)
	{
		MainThread.BeginInvokeOnMainThread(() =>
		{
			Sec.Text = second.ToString();
		});
	}
}
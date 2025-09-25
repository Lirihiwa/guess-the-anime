namespace GuessTheAnime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            PastelRainbowAnimation.StartAnimation(HD, intervalMs: 75);
        }

        private async void Start_Clicked(object sender, EventArgs e)
        {
            await PageTransition.PushAsync("quiz");
        }
    }
}

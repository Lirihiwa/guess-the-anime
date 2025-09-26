namespace GuessTheAnime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Start_Clicked(object sender, EventArgs e)
        {
            await PageTransition.PushAsync("quiz");
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
    }
}

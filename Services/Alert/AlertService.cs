namespace GuessTheAnime.Services.Alert
{
    public class AlertService : IAlertService
    {
        public void Display(string title, string message)
        {
            Shell.Current.CurrentPage.DisplayAlert(title: title,
                                                 message: message,
                                                 cancel: "OK");
        }

        public void Display(string message)
        {
            Display(title: "Something went wrong...", message);
        }

        public void Display()
        {
            Display(title: "Something went wrong...", message: "Unknown error");
        }
    }
}

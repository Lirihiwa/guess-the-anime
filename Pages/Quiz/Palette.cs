namespace GuessTheAnime.Pages.Quiz
{
    internal class Palette
    {
        private static Random _random;

        static Palette()
        {
            _random = new Random();
        }

        public static Color GetRandom()
        {
            return Color.FromArgb(_palette[_random.Next(_palette.Length)]);
        }

        private static string[] _palette = {
            "#fbf8cc",
            "#fde4cf",
            "#ffcfd2",
            "#f1c0e8",
            "#cfbaf0",
            "#a3c4f3",
            "#90dbf4",
            "#8eecf5",
            "#98f5e1",
            "#b9fbc0"
        };
    }
}

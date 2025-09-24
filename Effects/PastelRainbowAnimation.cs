using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnime
{
    public class PastelRainbowAnimation
    {
        private static Color? _currentColor;
        private static System.Timers.Timer? _timer;
        private static double _hue = 0;

        public static void StartAnimation(VisualElement element, int intervalMs = 50)
        {
            _timer = new System.Timers.Timer(intervalMs);
            _timer.Elapsed += (s, e) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    _hue = (_hue + 0.005) % 1.0;

                    _currentColor = Color.FromHsla(_hue, 0.6, 0.8, 1.0);

                    element.BackgroundColor = _currentColor;
                });
            };
            _timer.Start();
        }

        public void StopAnimation()
        {
            _timer?.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnime
{
    public static class PageTransition
    {
        public static async Task PushAsync(Page newPage)
        {
            await Shell.Current.Navigation.PushAsync(newPage);
        }

        public static async Task PopAsync()
        {
            await Shell.Current.Navigation.PopAsync();
        }
    }
}

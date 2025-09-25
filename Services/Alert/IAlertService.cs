using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnime.Services.Alert
{
    public interface IAlertService
    {
        void Display(string title, string message);
        void Display(string message);
        void Display();
    }
}

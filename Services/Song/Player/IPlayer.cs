using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnime.Services.Song.Player
{
    public interface IPlayer
    {
        Task PlayAsync(Stream stream);
        void Stop();
    }
}

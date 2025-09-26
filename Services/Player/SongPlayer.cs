using GuessTheAnime.Services.Alert;
using Plugin.Maui.Audio;

namespace GuessTheAnime.Services.Player
{
    public class SongPlayer : IPlayer
    {
        private IAudioManager _audioManager;
        private IAudioPlayer _player;
        private IAlertService _alertService;

        public SongPlayer(IAlertService alertService)
        {
            _audioManager = AudioManager.Current;
            _player = _audioManager.CreatePlayer();
            _alertService = alertService;
        }

        public void Play(Stream stream)
        {
            try
            {
                _player.SetSource(stream);
                _player?.Play();
            }
            catch (Exception ex)
            {
                _alertService.Display(ex.Message);
            }
        }

        public void Stop()
        {
            _player.Stop();
        }
    }
}

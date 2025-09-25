using GuessTheAnime.Services.Alert;
using Plugin.Maui.Audio;

namespace GuessTheAnime.Services.Song.Player
{
    public class SongPlayer : IPlayer
    {
        private IAudioManager _audioManager;
        private IAudioPlayer? _player;

        private IAlertService _alertService;

        public SongPlayer(IAlertService alertService)
        {
            _audioManager = AudioManager.Current;
            _alertService = alertService;
        }

        public async Task PlayAsync(Stream stream)
        {
            try
            {
                Stop();

                _player = _audioManager?.CreatePlayer(stream);
                _player?.Play();
            }
            catch (Exception ex)
            {
                _alertService.Display(ex.Message);
            }
        }

        public void Stop()
        {
            _player?.Stop();
            _player?.Dispose();
        }
    }
}

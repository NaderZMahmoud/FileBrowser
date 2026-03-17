using LibVLCSharp.Shared;

namespace FileBrowser
{
    public partial class VideosForm : Form
    {
        private static readonly HashSet<string> VideoExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".m4v", ".mpg", ".mpeg"
        };

        private readonly List<string> _videoPaths = [];
        private int _currentIndex = -1;

        private LibVLC? _libVLC;
        private MediaPlayer? _mediaPlayer;
        private readonly System.Windows.Forms.Timer _positionTimer = new() { Interval = 250 };
        private bool _isSeeking;

        public VideosForm()
        {
            InitializeComponent();

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            _mediaPlayer.Volume = trackBarVolume.Value;

            videoView.MediaPlayer = _mediaPlayer;

            _mediaPlayer.Playing += (s, e) => BeginInvoke(OnPlayerStateChanged);
            _mediaPlayer.Paused += (s, e) => BeginInvoke(OnPlayerStateChanged);
            _mediaPlayer.Stopped += (s, e) => BeginInvoke(OnPlayerStopped);
            _mediaPlayer.EndReached += (s, e) => BeginInvoke(OnPlayerStopped);

            _positionTimer.Tick += PositionTimer_Tick;
            _positionTimer.Start();
        }

        private void BtnBrowse_Click(object? sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select a folder containing videos",
                ShowNewFolderButton = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            txtPath.Text = dialog.SelectedPath;
            LoadVideos(dialog.SelectedPath);
        }

        private void LoadVideos(string folderPath)
        {
            StopPlayback();

            _videoPaths.Clear();
            _currentIndex = -1;
            listBoxVideos.Items.Clear();

            var files = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Where(f => VideoExtensions.Contains(Path.GetExtension(f)))
                .OrderBy(f => f, StringComparer.OrdinalIgnoreCase);

            _videoPaths.AddRange(files);

            foreach (var file in _videoPaths)
            {
                listBoxVideos.Items.Add(Path.GetFileName(file));
            }

            if (_videoPaths.Count > 0)
            {
                _currentIndex = 0;
                listBoxVideos.SelectedIndex = 0;
            }

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            btnPrevious.Enabled = _currentIndex > 0;
            btnNext.Enabled = _currentIndex < _videoPaths.Count - 1;

            if (_videoPaths.Count == 0)
            {
                lblStatus.Text = "No videos found.";
            }
            else
            {
                var fileName = Path.GetFileName(_videoPaths[_currentIndex]);
                lblStatus.Text = $"{_currentIndex + 1} / {_videoPaths.Count}  —  {fileName}";
            }
        }

        private void PlayVideo(string filePath)
        {
            if (_libVLC is null || _mediaPlayer is null)
                return;

            var media = new Media(_libVLC, filePath);
            _mediaPlayer.Play(media);
            media.Dispose();

            btnPlay.Enabled = true;
            btnStop.Enabled = true;
            btnPlay.Text = "⏸ Pause";
        }

        private void StopPlayback()
        {
            if (_mediaPlayer is null)
                return;

            if (_mediaPlayer.IsPlaying)
                _mediaPlayer.Stop();

            btnPlay.Text = "▶ Play";
            btnPlay.Enabled = _currentIndex >= 0;
            btnStop.Enabled = false;
            trackBarSeek.Value = 0;
            lblTime.Text = "00:00 / 00:00";
        }

        private void BtnPlay_Click(object? sender, EventArgs e)
        {
            if (_mediaPlayer is null)
                return;

            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
            }
            else if (_mediaPlayer.Media is not null)
            {
                _mediaPlayer.Play();
            }
            else if (_currentIndex >= 0 && _currentIndex < _videoPaths.Count)
            {
                PlayVideo(_videoPaths[_currentIndex]);
            }
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            StopPlayback();
        }

        private void TrackBarSeek_Scroll(object? sender, EventArgs e)
        {
            if (_mediaPlayer is null || !_mediaPlayer.IsPlaying)
                return;

            _isSeeking = true;
            _mediaPlayer.Position = trackBarSeek.Value / 1000f;
            _isSeeking = false;
        }

        private void TrackBarVolume_Scroll(object? sender, EventArgs e)
        {
            if (_mediaPlayer is not null)
                _mediaPlayer.Volume = trackBarVolume.Value;
        }

        private void PositionTimer_Tick(object? sender, EventArgs e)
        {
            if (_mediaPlayer is null || !_mediaPlayer.IsPlaying || _isSeeking)
                return;

            var pos = _mediaPlayer.Position;
            var len = _mediaPlayer.Length;

            if (pos >= 0 && len > 0)
            {
                trackBarSeek.Value = Math.Clamp((int)(pos * 1000), 0, 1000);

                var current = TimeSpan.FromMilliseconds(pos * len);
                var total = TimeSpan.FromMilliseconds(len);
                lblTime.Text = $"{current:mm\\:ss} / {total:mm\\:ss}";
            }
        }

        private void OnPlayerStateChanged()
        {
            if (_mediaPlayer is null)
                return;

            btnPlay.Text = _mediaPlayer.IsPlaying ? "⏸ Pause" : "▶ Play";
            btnStop.Enabled = true;
        }

        private void OnPlayerStopped()
        {
            btnPlay.Text = "▶ Play";
            btnPlay.Enabled = _currentIndex >= 0;
            btnStop.Enabled = false;
            trackBarSeek.Value = 0;
            lblTime.Text = "00:00 / 00:00";
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                listBoxVideos.SelectedIndex = _currentIndex;
                UpdateStatus();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (_currentIndex < _videoPaths.Count - 1)
            {
                _currentIndex++;
                listBoxVideos.SelectedIndex = _currentIndex;
                UpdateStatus();
            }
        }

        private void ListBoxVideos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBoxVideos.SelectedIndex >= 0)
            {
                _currentIndex = listBoxVideos.SelectedIndex;
                UpdateStatus();
            }
        }

        private void ListBoxVideos_DoubleClick(object? sender, EventArgs e)
        {
            if (_currentIndex >= 0 && _currentIndex < _videoPaths.Count)
            {
                PlayVideo(_videoPaths[_currentIndex]);
            }
        }

        private void VideosForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    BtnPrevious_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Right:
                    BtnNext_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Space:
                    BtnPlay_Click(sender, e);
                    e.Handled = true;
                    break;
            }
        }

        private void VideosForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _positionTimer.Stop();
            _positionTimer.Dispose();

            if (_mediaPlayer is not null)
            {
                _mediaPlayer.Stop();
                _mediaPlayer.Dispose();
                _mediaPlayer = null;
            }

            if (_libVLC is not null)
            {
                _libVLC.Dispose();
                _libVLC = null;
            }
        }
    }
}

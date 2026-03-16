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

        public VideosForm()
        {
            InitializeComponent();
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
                var filePath = _videoPaths[_currentIndex];
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
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
            }
        }
    }
}

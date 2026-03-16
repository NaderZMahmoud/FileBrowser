using SixLabors.ImageSharp;

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        private static readonly HashSet<string> ImageExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".jpg", ".jpeg", ".jfif", ".png", ".bmp", ".gif", ".tiff", ".tif", ".webp", ".ico"
        };

        private readonly List<string> _imagePaths = [];
        private int _currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object? sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select a folder containing images",
                ShowNewFolderButton = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            txtPath.Text = dialog.SelectedPath;
            LoadImages(dialog.SelectedPath);
        }

        private void LoadImages(string folderPath)
        {
            _imagePaths.Clear();
            _currentIndex = -1;

            var files = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Where(f => ImageExtensions.Contains(Path.GetExtension(f)))
                .OrderBy(f => f, StringComparer.OrdinalIgnoreCase);

            _imagePaths.AddRange(files);

            if (_imagePaths.Count > 0)
            {
                _currentIndex = 0;
                ShowCurrentImage();
            }
            else
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = null;
                UpdateStatus();
            }
        }

        private void ShowCurrentImage()
        {
            if (_currentIndex < 0 || _currentIndex >= _imagePaths.Count)
                return;

            pictureBox.Image?.Dispose();

            var filePath = _imagePaths[_currentIndex];
            MemoryStream ms;

            if (string.Equals(Path.GetExtension(filePath), ".webp", StringComparison.OrdinalIgnoreCase))
            {
                ms = new MemoryStream();
                using var img = SixLabors.ImageSharp.Image.Load(filePath);
                img.SaveAsPng(ms);
                ms.Position = 0;
            }
            else
            {
                var bytes = File.ReadAllBytes(filePath);
                ms = new MemoryStream(bytes);
            }

            pictureBox.Image = System.Drawing.Image.FromStream(ms);

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            btnPrevious.Enabled = _currentIndex > 0;
            btnNext.Enabled = _currentIndex < _imagePaths.Count - 1;

            if (_imagePaths.Count == 0)
            {
                lblStatus.Text = "No images found.";
            }
            else
            {
                var fileName = Path.GetFileName(_imagePaths[_currentIndex]);
                lblStatus.Text = $"{_currentIndex + 1} / {_imagePaths.Count}  —  {fileName}";
            }
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                ShowCurrentImage();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (_currentIndex < _imagePaths.Count - 1)
            {
                _currentIndex++;
                ShowCurrentImage();
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
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

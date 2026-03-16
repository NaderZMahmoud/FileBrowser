using SixLabors.ImageSharp;

namespace FileBrowser
{
    public partial class ImagesForm : Form
    {
        private static readonly HashSet<string> ImageExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".jpg", ".jpeg", ".jfif", ".jpe", ".png", ".bmp", ".dib",
            ".gif", ".tiff", ".tif", ".webp", ".tga", ".pbm", ".qoi", ".ico"
        };

        private static readonly HashSet<string> ImageSharpExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".webp", ".tga", ".pbm", ".qoi"
        };

        private readonly List<string> _imagePaths = [];
        private int _currentIndex = -1;

        public ImagesForm()
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

            if (ImageSharpExtensions.Contains(Path.GetExtension(filePath)))
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
                txtImageNumber.Text = "";
                txtImageNumber.Enabled = false;
                lblStatus.Text = "No images found.";
            }
            else
            {
                txtImageNumber.Enabled = true;
                txtImageNumber.Text = (_currentIndex + 1).ToString();
                var fileName = Path.GetFileName(_imagePaths[_currentIndex]);
                lblStatus.Text = $"/ {_imagePaths.Count}  —  {fileName}";
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

        private void TxtImageNumber_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (int.TryParse(txtImageNumber.Text, out int number)
                    && number >= 1
                    && number <= _imagePaths.Count)
                {
                    _currentIndex = number - 1;
                    ShowCurrentImage();
                }
                else
                {
                    // Revert to the current valid value
                    txtImageNumber.Text = (_currentIndex + 1).ToString();
                }
            }
        }

        private void ImagesForm_KeyDown(object? sender, KeyEventArgs e)
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

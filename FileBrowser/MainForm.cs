namespace FileBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnImages_Click(object? sender, EventArgs e)
        {
            var imagesForm = new ImagesForm();
            imagesForm.Show();
        }

        private void BtnVideos_Click(object? sender, EventArgs e)
        {
            var videosForm = new VideosForm();
            videosForm.Show();
        }
    }
}

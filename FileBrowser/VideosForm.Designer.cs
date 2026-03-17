namespace FileBrowser
{
    partial class VideosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPath = new TextBox();
            btnBrowse = new Button();
            listBoxVideos = new ListBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblStatus = new Label();
            panelTop = new Panel();
            panelBottom = new Panel();
            splitContainer = new SplitContainer();
            videoView = new LibVLCSharp.WinForms.VideoView();
            panelPlayerControls = new Panel();
            btnPlay = new Button();
            btnStop = new Button();
            trackBarSeek = new TrackBar();
            lblTime = new Label();
            trackBarVolume = new TrackBar();
            lblVolume = new Label();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView).BeginInit();
            panelPlayerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.Controls.Add(btnBrowse);
            panelTop.Controls.Add(txtPath);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1124, 44);

            // txtPath
            txtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPath.Location = new Point(8, 10);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(1000, 23);
            txtPath.TabIndex = 0;
            txtPath.PlaceholderText = "Select a folder containing videos...";

            // btnBrowse
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(1016, 9);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 25);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;

            // panelBottom
            panelBottom.Controls.Add(btnPrevious);
            panelBottom.Controls.Add(lblStatus);
            panelBottom.Controls.Add(btnNext);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 626);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1124, 42);

            // btnPrevious
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.Enabled = false;
            btnPrevious.Location = new Point(8, 8);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 28);
            btnPrevious.TabStop = false;
            btnPrevious.Text = "▲ Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;

            // lblStatus
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Location = new Point(96, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(932, 28);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // btnNext
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Enabled = false;
            btnNext.Location = new Point(1036, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabStop = false;
            btnNext.Text = "Next ▼";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;

            // splitContainer
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 44);
            splitContainer.Name = "splitContainer";
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.SplitterDistance = 280;
            splitContainer.Size = new Size(1124, 582);

            // splitContainer.Panel1 - video list
            splitContainer.Panel1.Controls.Add(listBoxVideos);
            splitContainer.Panel1MinSize = 180;

            // splitContainer.Panel2 - video player
            splitContainer.Panel2.Controls.Add(videoView);
            splitContainer.Panel2.Controls.Add(panelPlayerControls);

            // listBoxVideos
            listBoxVideos.Dock = DockStyle.Fill;
            listBoxVideos.Font = new Font("Segoe UI", 10F);
            listBoxVideos.IntegralHeight = false;
            listBoxVideos.Location = new Point(0, 0);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new Size(280, 582);
            listBoxVideos.TabIndex = 2;
            listBoxVideos.SelectedIndexChanged += ListBoxVideos_SelectedIndexChanged;
            listBoxVideos.DoubleClick += ListBoxVideos_DoubleClick;

            // videoView
            videoView.BackColor = Color.Black;
            videoView.Dock = DockStyle.Fill;
            videoView.Location = new Point(0, 0);
            videoView.MediaPlayer = null;
            videoView.Name = "videoView";
            videoView.Size = new Size(840, 538);
            videoView.TabIndex = 0;

            // panelPlayerControls
            panelPlayerControls.Controls.Add(btnPlay);
            panelPlayerControls.Controls.Add(btnStop);
            panelPlayerControls.Controls.Add(trackBarSeek);
            panelPlayerControls.Controls.Add(lblTime);
            panelPlayerControls.Controls.Add(lblVolume);
            panelPlayerControls.Controls.Add(trackBarVolume);
            panelPlayerControls.Dock = DockStyle.Bottom;
            panelPlayerControls.Location = new Point(0, 538);
            panelPlayerControls.Name = "panelPlayerControls";
            panelPlayerControls.Size = new Size(840, 44);

            // btnPlay
            btnPlay.Enabled = false;
            btnPlay.Location = new Point(4, 8);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(60, 28);
            btnPlay.TabStop = false;
            btnPlay.Text = "▶ Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;

            // btnStop
            btnStop.Enabled = false;
            btnStop.Location = new Point(68, 8);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(50, 28);
            btnStop.TabStop = false;
            btnStop.Text = "⏹ Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;

            // trackBarSeek
            trackBarSeek.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            trackBarSeek.AutoSize = false;
            trackBarSeek.Location = new Point(122, 8);
            trackBarSeek.Maximum = 1000;
            trackBarSeek.Name = "trackBarSeek";
            trackBarSeek.Size = new Size(470, 28);
            trackBarSeek.TabStop = false;
            trackBarSeek.TickStyle = TickStyle.None;
            trackBarSeek.Scroll += TrackBarSeek_Scroll;

            // lblTime
            lblTime.Anchor = AnchorStyles.Right;
            lblTime.Location = new Point(596, 8);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(110, 28);
            lblTime.Text = "00:00 / 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;

            // lblVolume
            lblVolume.Anchor = AnchorStyles.Right;
            lblVolume.Location = new Point(710, 8);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(18, 28);
            lblVolume.Text = "🔊";
            lblVolume.TextAlign = ContentAlignment.MiddleCenter;

            // trackBarVolume
            trackBarVolume.Anchor = AnchorStyles.Right;
            trackBarVolume.AutoSize = false;
            trackBarVolume.Location = new Point(730, 8);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(100, 28);
            trackBarVolume.TabStop = false;
            trackBarVolume.TickStyle = TickStyle.None;
            trackBarVolume.Value = 75;
            trackBarVolume.Scroll += TrackBarVolume_Scroll;

            // VideosForm
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 668);
            Controls.Add(splitContainer);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            KeyPreview = true;
            MinimumSize = new Size(800, 550);
            Name = "VideosForm";
            Text = "Video Browser";
            KeyDown += VideosForm_KeyDown;
            FormClosing += VideosForm_FormClosing;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoView).EndInit();
            panelPlayerControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private TextBox txtPath;
        private Button btnBrowse;
        private ListBox listBoxVideos;
        private Panel panelBottom;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblStatus;
        private SplitContainer splitContainer;
        private LibVLCSharp.WinForms.VideoView videoView;
        private Panel panelPlayerControls;
        private Button btnPlay;
        private Button btnStop;
        private TrackBar trackBarSeek;
        private Label lblTime;
        private TrackBar trackBarVolume;
        private Label lblVolume;
    }
}

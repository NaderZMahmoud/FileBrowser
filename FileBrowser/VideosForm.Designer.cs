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
            lblVolume = new Label();
            trackBarVolume = new TrackBar();
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
            // 
            // txtPath
            // 
            txtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPath.Location = new Point(8, 10);
            txtPath.Name = "txtPath";
            txtPath.PlaceholderText = "Select a folder containing videos...";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(1214, 31);
            txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(1230, 9);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 35);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // listBoxVideos
            // 
            listBoxVideos.Dock = DockStyle.Fill;
            listBoxVideos.Font = new Font("Segoe UI", 10F);
            listBoxVideos.IntegralHeight = false;
            listBoxVideos.Location = new Point(0, 0);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new Size(180, 768);
            listBoxVideos.TabIndex = 2;
            listBoxVideos.SelectedIndexChanged += ListBoxVideos_SelectedIndexChanged;
            listBoxVideos.DoubleClick += ListBoxVideos_DoubleClick;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.Enabled = false;
            btnPrevious.Location = new Point(8, 8);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 28);
            btnPrevious.TabIndex = 0;
            btnPrevious.TabStop = false;
            btnPrevious.Text = "▲ Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Enabled = false;
            btnNext.Location = new Point(1250, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 2;
            btnNext.TabStop = false;
            btnNext.Text = "Next ▼";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Location = new Point(96, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1146, 28);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnBrowse);
            panelTop.Controls.Add(txtPath);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1338, 44);
            panelTop.TabIndex = 2;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnPrevious);
            panelBottom.Controls.Add(lblStatus);
            panelBottom.Controls.Add(btnNext);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 812);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1338, 42);
            panelBottom.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 44);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(listBoxVideos);
            splitContainer.Panel1MinSize = 180;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(videoView);
            splitContainer.Panel2.Controls.Add(panelPlayerControls);
            splitContainer.Size = new Size(1338, 768);
            splitContainer.SplitterDistance = 180;
            splitContainer.TabIndex = 0;
            // 
            // videoView
            // 
            videoView.BackColor = Color.Black;
            videoView.Dock = DockStyle.Fill;
            videoView.Location = new Point(0, 0);
            videoView.MediaPlayer = null;
            videoView.Name = "videoView";
            videoView.Size = new Size(1154, 724);
            videoView.TabIndex = 0;
            // 
            // panelPlayerControls
            // 
            panelPlayerControls.Controls.Add(btnPlay);
            panelPlayerControls.Controls.Add(btnStop);
            panelPlayerControls.Controls.Add(trackBarSeek);
            panelPlayerControls.Controls.Add(lblTime);
            panelPlayerControls.Controls.Add(lblVolume);
            panelPlayerControls.Controls.Add(trackBarVolume);
            panelPlayerControls.Dock = DockStyle.Bottom;
            panelPlayerControls.Location = new Point(0, 724);
            panelPlayerControls.Name = "panelPlayerControls";
            panelPlayerControls.Size = new Size(1154, 44);
            panelPlayerControls.TabIndex = 1;
            // 
            // btnPlay
            // 
            btnPlay.Enabled = false;
            btnPlay.Location = new Point(4, 8);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(60, 28);
            btnPlay.TabIndex = 0;
            btnPlay.TabStop = false;
            btnPlay.Text = "▶ Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(68, 8);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(50, 28);
            btnStop.TabIndex = 1;
            btnStop.TabStop = false;
            btnStop.Text = "⏹ Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // trackBarSeek
            // 
            trackBarSeek.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            trackBarSeek.AutoSize = false;
            trackBarSeek.Location = new Point(122, 8);
            trackBarSeek.Maximum = 1000;
            trackBarSeek.Name = "trackBarSeek";
            trackBarSeek.Size = new Size(784, 28);
            trackBarSeek.TabIndex = 2;
            trackBarSeek.TabStop = false;
            trackBarSeek.TickStyle = TickStyle.None;
            trackBarSeek.Scroll += TrackBarSeek_Scroll;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Right;
            lblTime.Location = new Point(910, 8);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(110, 28);
            lblTime.TabIndex = 3;
            lblTime.Text = "00:00 / 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVolume
            // 
            lblVolume.Anchor = AnchorStyles.Right;
            lblVolume.Location = new Point(1024, 8);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(18, 28);
            lblVolume.TabIndex = 4;
            lblVolume.Text = "🔊";
            lblVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Anchor = AnchorStyles.Right;
            trackBarVolume.AutoSize = false;
            trackBarVolume.Location = new Point(1044, 8);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(100, 28);
            trackBarVolume.TabIndex = 5;
            trackBarVolume.TabStop = false;
            trackBarVolume.TickStyle = TickStyle.None;
            trackBarVolume.Value = 75;
            trackBarVolume.Scroll += TrackBarVolume_Scroll;
            // 
            // VideosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 854);
            Controls.Add(splitContainer);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            KeyPreview = true;
            MinimumSize = new Size(800, 550);
            Name = "VideosForm";
            Text = "Video Browser";
            FormClosing += VideosForm_FormClosing;
            KeyDown += VideosForm_KeyDown;
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

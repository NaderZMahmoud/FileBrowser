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
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();

            // panelTop
            panelTop.Controls.Add(btnBrowse);
            panelTop.Controls.Add(txtPath);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1024, 44);

            // txtPath
            txtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPath.Location = new Point(8, 10);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(900, 23);
            txtPath.TabIndex = 0;
            txtPath.PlaceholderText = "Select a folder containing videos...";

            // btnBrowse
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(916, 9);
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
            panelBottom.Location = new Point(0, 526);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1024, 42);

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
            lblStatus.Size = new Size(832, 28);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // btnNext
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Enabled = false;
            btnNext.Location = new Point(936, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabStop = false;
            btnNext.Text = "Next ▼";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;

            // listBoxVideos
            listBoxVideos.Dock = DockStyle.Fill;
            listBoxVideos.Font = new Font("Segoe UI", 10F);
            listBoxVideos.IntegralHeight = false;
            listBoxVideos.Location = new Point(0, 44);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new Size(1024, 482);
            listBoxVideos.TabIndex = 2;
            listBoxVideos.SelectedIndexChanged += ListBoxVideos_SelectedIndexChanged;
            listBoxVideos.DoubleClick += ListBoxVideos_DoubleClick;

            // VideosForm
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 568);
            Controls.Add(listBoxVideos);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            KeyPreview = true;
            MinimumSize = new Size(640, 480);
            Name = "VideosForm";
            Text = "Video Browser";
            KeyDown += VideosForm_KeyDown;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
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
    }
}

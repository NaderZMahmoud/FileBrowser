namespace FileBrowser
{
    partial class MainForm
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
            btnImages = new Button();
            btnVideos = new Button();
            lblTitle = new Label();
            SuspendLayout();

            // lblTitle
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "File Browser";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // btnImages
            btnImages.Font = new Font("Segoe UI", 12F);
            btnImages.Location = new Point(50, 100);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(300, 60);
            btnImages.TabIndex = 1;
            btnImages.Text = "🖼️  Browse Images";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += BtnImages_Click;

            // btnVideos
            btnVideos.Font = new Font("Segoe UI", 12F);
            btnVideos.Location = new Point(50, 180);
            btnVideos.Name = "btnVideos";
            btnVideos.Size = new Size(300, 60);
            btnVideos.TabIndex = 2;
            btnVideos.Text = "🎬  Browse Videos";
            btnVideos.UseVisualStyleBackColor = true;
            btnVideos.Click += BtnVideos_Click;

            // MainForm
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 280);
            Controls.Add(lblTitle);
            Controls.Add(btnImages);
            Controls.Add(btnVideos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Browser";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnImages;
        private Button btnVideos;
    }
}

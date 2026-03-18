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
            tabControl = new TabControl();
            tabImages = new TabPage();
            imagesControl = new ImagesControl();
            tabVideos = new TabPage();
            videosControl = new VideosControl();
            tabControl.SuspendLayout();
            tabImages.SuspendLayout();
            tabVideos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabImages);
            tabControl.Controls.Add(tabVideos);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 11F);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1264, 801);
            tabControl.TabIndex = 0;
            // 
            // tabImages
            // 
            tabImages.Controls.Add(imagesControl);
            tabImages.Location = new Point(4, 39);
            tabImages.Name = "tabImages";
            tabImages.Size = new Size(1256, 758);
            tabImages.TabIndex = 0;
            tabImages.Text = "🖼️  Images";
            tabImages.UseVisualStyleBackColor = true;
            // 
            // imagesControl
            // 
            imagesControl.Dock = DockStyle.Fill;
            imagesControl.Location = new Point(0, 0);
            imagesControl.Name = "imagesControl";
            imagesControl.Size = new Size(1256, 758);
            imagesControl.TabIndex = 0;
            // 
            // tabVideos
            // 
            tabVideos.Controls.Add(videosControl);
            tabVideos.Location = new Point(4, 39);
            tabVideos.Name = "tabVideos";
            tabVideos.Size = new Size(1256, 758);
            tabVideos.TabIndex = 1;
            tabVideos.Text = "🎬  Videos";
            tabVideos.UseVisualStyleBackColor = true;
            // 
            // videosControl
            // 
            videosControl.Dock = DockStyle.Fill;
            videosControl.Location = new Point(0, 0);
            videosControl.Name = "videosControl";
            videosControl.Size = new Size(1256, 758);
            videosControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 801);
            Controls.Add(tabControl);
            MinimumSize = new Size(800, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Browser";
            tabControl.ResumeLayout(false);
            tabImages.ResumeLayout(false);
            tabVideos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabImages;
        private ImagesControl imagesControl;
        private TabPage tabVideos;
        private VideosControl videosControl;
    }
}

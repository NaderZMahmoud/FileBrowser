namespace FileBrowser
{
    partial class ImagesForm
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
            pictureBox = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            txtImageNumber = new TextBox();
            lblStatus = new Label();
            panelTop = new Panel();
            panelBottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            txtPath.PlaceholderText = "Select a folder containing images...";

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
            panelBottom.Controls.Add(txtImageNumber);
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
            btnPrevious.Text = "◀ Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;

            // txtImageNumber
            txtImageNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtImageNumber.Location = new Point(96, 10);
            txtImageNumber.Name = "txtImageNumber";
            txtImageNumber.Size = new Size(60, 23);
            txtImageNumber.TextAlign = HorizontalAlignment.Center;
            txtImageNumber.TabIndex = 2;
            txtImageNumber.KeyDown += TxtImageNumber_KeyDown;

            // lblStatus
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Location = new Point(164, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(764, 28);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // btnNext
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Enabled = false;
            btnNext.Location = new Point(936, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabStop = false;
            btnNext.Text = "Next ▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;

            // pictureBox
            pictureBox.BackColor = SystemColors.ControlDark;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 44);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1024, 482);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;

            // ImagesForm
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 568);
            Controls.Add(pictureBox);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            KeyPreview = true;
            MinimumSize = new Size(640, 480);
            Name = "ImagesForm";
            Text = "Photo Browser";
            KeyDown += ImagesForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private TextBox txtPath;
        private Button btnBrowse;
        private PictureBox pictureBox;
        private Panel panelBottom;
        private Button btnPrevious;
        private TextBox txtImageNumber;
        private Button btnNext;
        private Label lblStatus;
    }
}

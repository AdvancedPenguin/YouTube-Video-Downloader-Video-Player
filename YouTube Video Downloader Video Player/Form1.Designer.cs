namespace YouTubeDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TextBox txtVideoUrl;
        private Button btnDownload;
        private ProgressBar progressBar;
        private Button btnPlayInstrumental;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVideoUrl = new TextBox();
            btnDownload = new Button();
            progressBar = new ProgressBar();
            btnPlayInstrumental = new Button();
            Link = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtVideoUrl
            // 
            txtVideoUrl.Location = new Point(95, 30);
            txtVideoUrl.Margin = new Padding(5, 6, 5, 6);
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.Size = new Size(497, 31);
            txtVideoUrl.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.ForestGreen;
            btnDownload.Location = new Point(31, 87);
            btnDownload.Margin = new Padding(5, 6, 5, 6);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(224, 80);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(31, 198);
            progressBar.Margin = new Padding(5, 6, 5, 6);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(561, 44);
            progressBar.TabIndex = 2;
            // 
            // btnPlayInstrumental
            // 
            btnPlayInstrumental.BackColor = Color.FromArgb(128, 128, 255);
            btnPlayInstrumental.Location = new Point(31, 283);
            btnPlayInstrumental.Margin = new Padding(5, 6, 5, 6);
            btnPlayInstrumental.Name = "btnPlayInstrumental";
            btnPlayInstrumental.Size = new Size(224, 65);
            btnPlayInstrumental.TabIndex = 3;
            btnPlayInstrumental.Text = "Bored? Play Instrumental";
            btnPlayInstrumental.UseVisualStyleBackColor = false;
            btnPlayInstrumental.Click += btnPlayInstrumental_Click;
            // 
            // Link
            // 
            Link.AutoSize = true;
            Link.Location = new Point(31, 30);
            Link.Name = "Link";
            Link.Size = new Size(47, 25);
            Link.TabIndex = 4;
            Link.Text = "Link:";
            Link.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 115);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 5;
            label1.Text = "This process usually takes a long time";
            label1.Click += label1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 386);
            Controls.Add(label1);
            Controls.Add(Link);
            Controls.Add(btnPlayInstrumental);
            Controls.Add(progressBar);
            Controls.Add(btnDownload);
            Controls.Add(txtVideoUrl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YouTube Downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Link;
        private Label label1;
    }
}

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Media;
using System.Windows.Forms;
using VideoLibrary;

namespace YouTubeDownloader
{
    public partial class MainForm : Form
    {
        private const string AlertSoundPath = "C:\\Users\\alexd\\source\\repos\\YouTube Video Downloader Video Player\\YouTube Video Downloader Video Player\\bin\\Debug\\net6.0-windows\\Fanfare.wav"; // Replace with the actual path to your .wav file

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtVideoUrl.Text.Trim();

            if (!string.IsNullOrEmpty(videoUrl))
            {
                try
                {
                    var youtube = YouTube.Default;
                    var video = youtube.GetAllVideos(videoUrl).OrderByDescending(v => v.Resolution).FirstOrDefault();

                    if (video != null)
                    {
                        string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), video.FullName);

                        using (var client = new WebClient())
                        {
                            client.DownloadProgressChanged += (s, args) =>
                            {
                                progressBar.Value = args.ProgressPercentage;
                            };

                            client.DownloadFileCompleted += (s, args) =>
                            {
                                MessageBox.Show("Download completed successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                progressBar.Value = 0;

                                // Play sound
                                PlayAlertSound();

                                // Close VLC
                                CloseVlc();
                            };

                            client.DownloadFileAsync(new Uri(video.Uri), savePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No video found or unable to retrieve video information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid YouTube video URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPlayInstrumental_Click(object sender, EventArgs e)
        {
            string instrumentalVideoPath = @"C:\Users\alexd\source\repos\YouTube Video Downloader Video Player\YouTube Video Downloader Video Player\bin\Debug\net6.0-windows\Monty Python Intermission and Main Street U.S.A. by John Hobbs.mp4";
            string vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe"; // Adjust the path as needed

            try
            {
                if (File.Exists(instrumentalVideoPath) && File.Exists(vlcPath))
                {
                    Process.Start(vlcPath, "\"" + instrumentalVideoPath + "\"");
                }
                else
                {
                    MessageBox.Show("Either VLC or the instrumental video file not found at the specified paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while playing the instrumental video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayAlertSound()
        {
            if (File.Exists(AlertSoundPath))
            {
                using (var soundPlayer = new SoundPlayer(AlertSoundPath))
                {
                    soundPlayer.Play();
                }
            }
            else
            {
                MessageBox.Show("Alert sound file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseVlc()
        {
            Process[] vlcProcesses = Process.GetProcessesByName("vlc");

            foreach (Process process in vlcProcesses)
            {
                process.CloseMainWindow();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Video_Converter
{
    public partial class Form1 : MaterialForm
    {
        private string inputFilePath;
        private string inputFileName;
        private string[] videoExtensions = { ".mp4", ".avi", ".mkv", ".mov", ".flv", ".wmv", ".ts" };
        private TimeSpan totalDuration;
        private MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            btnConvert.Enabled = false;
        }

        private void btnSelectVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.flv;*.wmv;*.webm;*.ts";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = openFileDialog.FileName;
                    inputFileName = openFileDialog.SafeFileName;
                    txtSelectedFile.Text = inputFilePath;

                    string inputExtension = Path.GetExtension(inputFilePath).ToLower();
                    cmbOutputFormat.Items.Clear();
                    cmbOutputFormat.Items.AddRange(videoExtensions.Where(ext => ext != inputExtension).ToArray());

                    // Get the duration of the selected video
                    totalDuration = GetVideoDuration(inputFilePath);

                    ValidateInputs();
                }
            }


        }

        private void chkUpscale_CheckedChanged(object sender, EventArgs e)
        {
            cmbResolution.Visible = chkUpscale.Checked;
            ValidateInputs();
        }

        private void InputsChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void ValidateInputs()
        {
            bool isValid = !string.IsNullOrEmpty(inputFilePath) &&
                           cmbOutputFormat.SelectedItem != null &&
                           (!chkUpscale.Checked || cmbResolution.SelectedItem != null);

            btnConvert.Enabled = isValid;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbOutputFormat.SelectedItem == null)
            {
                MessageBox.Show("Please select an output format.");
                return;
            }

            string outputExtension = cmbOutputFormat.SelectedItem.ToString();
            string outputFileName = Path.ChangeExtension(Path.GetFileName(inputFilePath), outputExtension);
            string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string outputFilePath = Path.Combine(downloadsFolder, outputFileName);

            // Retrieve resolution before starting the background worker
            string resolution = null;
            if (chkUpscale.Checked && cmbResolution.SelectedItem != null)
            {
                resolution = cmbResolution.SelectedItem.ToString();
            }

            progressBar.Value = 0;
            lblStatus.Text = "Converting...";

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (s, ev) => ConvertVideo(inputFilePath, outputFilePath, resolution, worker);
            worker.ProgressChanged += (s, ev) => progressBar.Invoke(new Action(() => progressBar.Value = ev.ProgressPercentage));
            worker.RunWorkerCompleted += (s, ev) =>
            {
                progressBar.Invoke(new Action(() => progressBar.Value = 100));
                lblStatus.Invoke(new Action(() => lblStatus.Text = "Conversion completed"));
                CustomMessageBox.ShowDialogBox("Conversion completed", "Alert !", outputFilePath, true);
            };

            worker.RunWorkerAsync();
        }

        private void ConvertVideo(string inputFile, string outputFile, string resolution, BackgroundWorker worker)
        {
            string upscaleArgs = string.Empty;
            if (!string.IsNullOrEmpty(resolution))
            {
                upscaleArgs = $" -vf scale={GetResolutionScale(resolution)}";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"-hwaccel nvdec -i \"{inputFile}\"{upscaleArgs} -c:v h264_nvenc -preset hq -qp 0 -c:a copy \"{outputFile}\" -y",
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.ErrorDataReceived += (sender, args) =>
                {
                    if (args.Data != null)
                    {
                        string data = args.Data;
                        // Example progress output: "frame=  240 fps= 24 q=24.0 size=    1024kB time=00:00:10.00 bitrate= 838.2kbits/s speed=0.5x"
                        var match = Regex.Match(data, @"time=(\d+:\d+:\d+\.\d+)");
                        if (match.Success)
                        {
                            TimeSpan currentTime = TimeSpan.Parse(match.Groups[1].Value);
                            int progress = (int)(currentTime.TotalSeconds / totalDuration.TotalSeconds * 100);
                            worker.ReportProgress(progress);
                        }
                    }
                };

                process.Start();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }

        private string GetResolutionScale(string resolution)
        {
            switch (resolution)
            {
                case "720p":
                    return "1280:720";
                case "1080p":
                    return "1920:1080";
                case "1440p":
                    return "2560:1440";
                case "4K":
                    return "3840:2160";
                default:
                    return null;
            }
        }

        private TimeSpan GetVideoDuration(string inputFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"-i \"{inputFile}\"",
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();
                string output = process.StandardError.ReadToEnd();
                process.WaitForExit();

                var match = Regex.Match(output, @"Duration: (\d+:\d+:\d+\.\d+)");
                if (match.Success)
                {
                    return TimeSpan.Parse(match.Groups[1].Value);
                }
            }

            return TimeSpan.Zero;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = @"start https://github.com/Konohamaru04/Video-Converter";
                process.Start();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowDialogBox(ex.Message, "Error!");
            }
            
        }
    }
}

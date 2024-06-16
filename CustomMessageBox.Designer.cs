using System.Diagnostics;
using System.Windows.Forms;

namespace Video_Converter
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Enabled = false;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 15F);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(6, 67);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(463, 127);
            materialMultiLineTextBox1.TabIndex = 0;
            materialMultiLineTextBox1.Text = resources.GetString("materialMultiLineTextBox1.Text");
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(180, 6);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(77, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Cancel";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(95, 6);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 2;
            materialButton2.Text = "Ok";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Visible = false;
            materialButton2.Click += materialButton2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(materialButton1);
            flowLayoutPanel1.Controls.Add(materialButton2);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(208, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(261, 52);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // CustomMessageBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(470, 248);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(materialMultiLineTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 450);
            MinimizeBox = false;
            MinimumSize = new Size(470, 248);
            Name = "CustomMessageBox";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomMessageBox_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public static void ShowDialogBox(string message)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message);
            customMessageBox.ShowDialog();
        }

        public static void ShowDialogBox(string message, string folderPath, bool isExport = false)
        {
            
            if (isExport && folderPath != null)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox(message, isExport);
                if (customMessageBox.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "explorer.exe",
                            Arguments = folderPath,
                            UseShellExecute = true
                        };
                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                CustomMessageBox customMessageBox = new CustomMessageBox(message);
                customMessageBox.ShowDialog();
            }
            
        }

        public static void ShowDialogBox(string message, Size size)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, size);
            customMessageBox.ShowDialog();
        }

        public static void ShowDialogBox(string message, string title)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
            customMessageBox.ShowDialog();
        }

        public static void ShowDialogBox(string message, string title, string folderPath, bool isExport = false)
        {
            if (isExport && folderPath != null)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox(message, title, isExport);
                if (customMessageBox.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "explorer.exe",
                            Arguments = folderPath,
                            UseShellExecute = true
                        };
                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
                customMessageBox.ShowDialog();
            }
            
        }

        public static void ShowDialogBox(string message, string title, Size size)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, title, size);
            customMessageBox.ShowDialog();
        }

        public static DialogResult ShowDialogBox(string message, string title, DialogType dialogType)
        {

            CustomMessageBox customMessageBox = new CustomMessageBox(message, title, dialogType);
            if (customMessageBox.ShowDialog() == DialogResult.OK)
            {
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }

        public static DialogResult ShowDialogBox(string message, string title, DialogType dialogType, Size size)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, title, dialogType, size);
            if (customMessageBox.ShowDialog() == DialogResult.OK)
            {
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }

        public enum DialogType {
            Submit
        }

        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
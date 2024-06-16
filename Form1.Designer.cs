namespace Video_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblSelectedFile = new MaterialSkin.Controls.MaterialLabel();
            txtSelectedFile = new TextBox();
            btnSelectVideo = new MaterialSkin.Controls.MaterialButton();
            cmbOutputFormat = new MaterialSkin.Controls.MaterialComboBox();
            chkUpscale = new MaterialSkin.Controls.MaterialCheckbox();
            cmbResolution = new MaterialSkin.Controls.MaterialComboBox();
            btnConvert = new MaterialSkin.Controls.MaterialButton();
            progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            lblStatus = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // lblSelectedFile
            // 
            resources.ApplyResources(lblSelectedFile, "lblSelectedFile");
            lblSelectedFile.Depth = 0;
            lblSelectedFile.MouseState = MaterialSkin.MouseState.HOVER;
            lblSelectedFile.Name = "lblSelectedFile";
            // 
            // txtSelectedFile
            // 
            resources.ApplyResources(txtSelectedFile, "txtSelectedFile");
            txtSelectedFile.Name = "txtSelectedFile";
            // 
            // btnSelectVideo
            // 
            resources.ApplyResources(btnSelectVideo, "btnSelectVideo");
            btnSelectVideo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSelectVideo.Depth = 0;
            btnSelectVideo.HighEmphasis = true;
            btnSelectVideo.Icon = null;
            btnSelectVideo.MouseState = MaterialSkin.MouseState.HOVER;
            btnSelectVideo.Name = "btnSelectVideo";
            btnSelectVideo.NoAccentTextColor = Color.Empty;
            btnSelectVideo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSelectVideo.UseAccentColor = false;
            btnSelectVideo.UseVisualStyleBackColor = true;
            btnSelectVideo.Click += btnSelectVideo_Click;
            // 
            // cmbOutputFormat
            // 
            cmbOutputFormat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbOutputFormat.AutoResize = false;
            cmbOutputFormat.BackColor = Color.FromArgb(255, 255, 255);
            cmbOutputFormat.Depth = 0;
            cmbOutputFormat.DrawMode = DrawMode.OwnerDrawVariable;
            cmbOutputFormat.DropDownHeight = 174;
            cmbOutputFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOutputFormat.DropDownWidth = 121;
            resources.ApplyResources(cmbOutputFormat, "cmbOutputFormat");
            cmbOutputFormat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbOutputFormat.FormattingEnabled = true;
            cmbOutputFormat.MouseState = MaterialSkin.MouseState.OUT;
            cmbOutputFormat.Name = "cmbOutputFormat";
            cmbOutputFormat.StartIndex = 0;
            cmbOutputFormat.SelectedIndexChanged += InputsChanged;
            // 
            // chkUpscale
            // 
            resources.ApplyResources(chkUpscale, "chkUpscale");
            chkUpscale.Depth = 0;
            chkUpscale.MouseLocation = new Point(-1, -1);
            chkUpscale.MouseState = MaterialSkin.MouseState.HOVER;
            chkUpscale.Name = "chkUpscale";
            chkUpscale.ReadOnly = false;
            chkUpscale.Ripple = true;
            chkUpscale.UseVisualStyleBackColor = true;
            chkUpscale.CheckedChanged += chkUpscale_CheckedChanged;
            // 
            // cmbResolution
            // 
            cmbResolution.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbResolution.AutoResize = false;
            cmbResolution.BackColor = Color.FromArgb(255, 255, 255);
            cmbResolution.Depth = 0;
            cmbResolution.DrawMode = DrawMode.OwnerDrawVariable;
            cmbResolution.DropDownHeight = 174;
            cmbResolution.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResolution.DropDownWidth = 121;
            resources.ApplyResources(cmbResolution, "cmbResolution");
            cmbResolution.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbResolution.FormattingEnabled = true;
            cmbResolution.Items.AddRange(new object[] { resources.GetString("cmbResolution.Items"), resources.GetString("cmbResolution.Items1"), resources.GetString("cmbResolution.Items2"), resources.GetString("cmbResolution.Items3") });
            cmbResolution.MouseState = MaterialSkin.MouseState.OUT;
            cmbResolution.Name = "cmbResolution";
            cmbResolution.StartIndex = 0;
            cmbResolution.SelectedIndexChanged += InputsChanged;
            // 
            // btnConvert
            // 
            resources.ApplyResources(btnConvert, "btnConvert");
            btnConvert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConvert.Depth = 0;
            btnConvert.HighEmphasis = true;
            btnConvert.Icon = null;
            btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            btnConvert.Name = "btnConvert";
            btnConvert.NoAccentTextColor = Color.Empty;
            btnConvert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConvert.UseAccentColor = false;
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // progressBar
            // 
            progressBar.Depth = 0;
            resources.ApplyResources(progressBar, "progressBar");
            progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            progressBar.Name = "progressBar";
            // 
            // lblStatus
            // 
            lblStatus.Depth = 0;
            resources.ApplyResources(lblStatus, "lblStatus");
            lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            lblStatus.Name = "lblStatus";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(materialLabel1, "materialLabel1");
            materialLabel1.Depth = 0;
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel1);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(btnConvert);
            Controls.Add(cmbResolution);
            Controls.Add(chkUpscale);
            Controls.Add(cmbOutputFormat);
            Controls.Add(btnSelectVideo);
            Controls.Add(txtSelectedFile);
            Controls.Add(lblSelectedFile);
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialLabel lblSelectedFile;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private MaterialSkin.Controls.MaterialButton btnSelectVideo;
        private MaterialSkin.Controls.MaterialComboBox cmbOutputFormat;
        private MaterialSkin.Controls.MaterialCheckbox chkUpscale;
        private MaterialSkin.Controls.MaterialComboBox cmbResolution;
        private MaterialSkin.Controls.MaterialButton btnConvert;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel lblStatus;

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

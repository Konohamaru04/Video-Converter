using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Converter
{
    public partial class CustomMessageBox : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private bool IsShowInFolder = false;

        public CustomMessageBox(string message)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            materialButton1.Text = "Ok";
        }

        public CustomMessageBox(string message, bool isShowInFolder)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialButton1.AutoSize = true;
            materialMultiLineTextBox1.Text = message;
            materialButton1.Text = "Show In Folder";
            IsShowInFolder = isShowInFolder;
        }

        public CustomMessageBox(string message, Size size)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            materialButton1.Text = "Ok";
            this.Size = new Size(size.Width, size.Height);
        }

        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            this.Text = title;
            materialButton1.Text = "Ok";
        }

        public CustomMessageBox(string message, string title, bool isShowInFolder)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            this.Text = title;
            materialButton1.AutoSize = true;
            materialMultiLineTextBox1.Text = message;
            materialButton1.Text = "Show In Folder";
            IsShowInFolder = isShowInFolder;
        }

        public CustomMessageBox(string message, string title, Size size)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            this.Text = title;
            materialButton1.Text = "Ok";
            this.Size = size;
        }

        public CustomMessageBox(string message, string title, DialogType dialogType)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            this.Text = title;

            if(dialogType == DialogType.Submit)
            {
                materialButton2.Visible = true;
            }
        }

        public CustomMessageBox(string message, string title, DialogType dialogType, Size size)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Choose your desired theme
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialMultiLineTextBox1.Text = message;
            this.Text = title;
            this.Size = size;
            if (dialogType == DialogType.Submit)
            {
                materialButton2.Visible = true;
            }
        }


        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Cancel button
            if (IsShowInFolder)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Ok button
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainerLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = urlLabel.Text; // Get the URL from the label
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Join my discord to report the issue or leave a comment.");
                return;
            }

            using (var client = new WebClient())
            {
                try
                {
                    Uri uri = new Uri(url);

                    // Get the file name from the URL
                    string fileName = Path.GetFileName(uri.LocalPath);

                    // Set the download path in ProgramData folder
                    string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), fileName);

                    // Download the file from URL to the ProgramData folder
                    client.DownloadFile(url, downloadPath);

                    MessageBox.Show("Done.");

                    // Start the application after download completion
                    Process.Start(downloadPath);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Error downloading file: " + ex.Message, "Download Error");
                }
            }
        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneImageButton5_Click(object sender, EventArgs e)
        {
            NFSU_ uc =  new NFSU_();
            addUserControl(uc);
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

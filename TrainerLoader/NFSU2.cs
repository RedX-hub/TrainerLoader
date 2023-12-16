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
    public partial class NFSU_ : UserControl
    {
        public NFSU_()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
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

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            string url = urlLabel2.Text; // Get the URL from the label
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

        private void urlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string url = urlLabel3.Text; // Get the URL from the label
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

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            string url = urlLabel4.Text; // Get the URL from the label
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

        private void NFSU__Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
        }
    }
}
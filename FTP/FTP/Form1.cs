using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class Form1 : Form
    {
        private string ftpServerUrl;
        private string ftpUsername ;
        private string ftpPassword ;
        private bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDownload.Enabled = false;
            buttonUpload.Enabled = false;
            buttonView.Enabled = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to the FTP server first.");
                return;
            }

            list.Items.Clear();

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerUrl);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string line = reader.ReadLine();
                        while (!string.IsNullOrEmpty(line))
                        {
                            list.Items.Add(line);
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                ftpServerUrl = textBoxServerIP.Text;
                ftpUsername = textBoxUsername.Text;
                ftpPassword = textBoxPassword.Text;
                try
                {
                    buttonDownload.Enabled = true;
                    buttonUpload.Enabled = true;
                    buttonView.Enabled = true;
                    textBoxServerIP.ReadOnly = true;
                    textBoxUsername.ReadOnly = true;
                    textBoxPassword.ReadOnly = true;
                    buttonConnect.Text = "Disconnect";
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerUrl);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        isConnected = true;
                        MessageBox.Show("Connected to FTP server successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                isConnected = false;
                buttonDownload.Enabled = false;
                buttonUpload.Enabled = false;
                buttonView.Enabled = false;
                textBoxServerIP.ReadOnly = false;
                textBoxUsername.ReadOnly = false;
                textBoxPassword.ReadOnly = false;
                buttonConnect.Text = "Connect";
                MessageBox.Show("Disconnected to FTP server successfully.");
            }
        }

        private void textBoxServerIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to the FTP server first.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string selectedFileName = Path.GetFileName(selectedFilePath);

                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerUrl + "/" + selectedFileName);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                    using (FileStream fileStream = File.OpenRead(selectedFilePath))
                    {
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            fileStream.CopyTo(requestStream);
                        }
                    }

                    MessageBox.Show("File uploaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to the FTP server first.");
                return;
            }

            if (list.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            string selectedFile = list.SelectedItems[0].Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = selectedFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFileDialog.FileName;

                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerUrl + "/" + selectedFile);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;

                    request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                            {
                                responseStream.CopyTo(fileStream);
                            }
                        }
                    }

                    MessageBox.Show("File downloaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

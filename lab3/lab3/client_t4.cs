﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Threading;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace lab3
{
    public partial class client_t4 : Form
    {
        public client_t4()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btn_OK.Enabled = true;
            btn_Send.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_SendImage.Enabled = false;
            txt_Message.ReadOnly = true;
            txt_Name1.ReadOnly = true;
        }
        IPEndPoint IP;
        Socket client;

        private void client_t4_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string ip = txt_IP.Text;
            if (!int.TryParse(txt_Port.Text, out int test1) || txt_Port.Text == "")
            {
                MessageBox.Show("mời nhập đúng cổng là một số nguyên!!!");
                return;
            }
            if (!IPAddress.TryParse(ip, out IPAddress test) || txt_IP.Text == "") 
            {
                MessageBox.Show("mời nhập đúng địa chỉ IP!!!");
                return;
            }
            

            IP = new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(txt_Port.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
                client.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã vào phòng "));
                MessageBox.Show("Ket noi thanh cong !", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi toi server !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            btn_OK.Enabled = false;
            btn_Send.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_SendImage.Enabled = true;
            txt_Message.ReadOnly = false;
            txt_Name1.ReadOnly = false;
            txt_Name.ReadOnly = true;
            txt_Port.ReadOnly = true;
            txt_IP.ReadOnly = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_IP.Text = "";
            txt_Port.Text = "";
            client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã rời phòng "));
            client?.Close();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                Send();
                AddMess(txt_Name.Text + ": " + txt_Message.Text);
            }
            catch
            {

                MessageBox.Show("Chưa kết nối tới server nên không thể gửi tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        void Send()
        {
            if (txt_Message.Text != string.Empty)
            {
                if (txt_Name1.Text == string.Empty)
                {
                    byte[] data = Encoding.UTF8.GetBytes(txt_Name.Text + ": " + txt_Message.Text);
                    client?.Send(data);
                }
                else
                {
                    byte[] data = Encoding.UTF8.GetBytes(txt_Name.Text + ": " + txt_Message.Text + "@" + txt_Name1.Text + "@");
                    client?.Send(data);
                }


            }
        }
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client?.Receive(data);
                    string mess = Encoding.UTF8.GetString(data);
                    AddMess(mess);

                        if (mess.Contains("(PR.IMAGE)"))
                    {
                        byte[] imageSizeBytes = new byte[4];
                        client?.Receive(imageSizeBytes);
                        int imageSize = BitConverter.ToInt32(imageSizeBytes, 0);

                        // Nhận ảnh
                        byte[] imageData = new byte[imageSize];
                        client?.Receive(imageData);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pb_Avatar.Image = null;
                            Image image = Image.FromStream(ms);
                            Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                            pb_Avatar.Image = thumb;
                        }
                    }


                }
            }
            catch
            {
                Close();
            }
        }
        void AddMess(string s)
        {
            // string a = txtName.Text + ": " + s;
            lv_ShowConversation.Items.Add(new ListViewItem() { Text = s });
            txt_Message.Clear();
        }
        private void btn_SendImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string k = ofd.FileName;
            //MessageBox.Show(k);
            byte[] imageData = File.ReadAllBytes(k);
            string s = "";
            if (txt_Name1.Text != string.Empty)
            {
                s = "$" + txt_Name1.Text + "$";
            }
            client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " (IMG) " + s));



            // Gửi kích thước ảnh
            int imageSize = imageData.Length;
            byte[] imageSizeBytes = BitConverter.GetBytes(imageSize);
            client?.Send(imageSizeBytes);
            // Gửi ảnh
            client?.Send(imageData);

            System.Drawing.Image image = System.Drawing.Image.FromFile(k); // đọc file ảnh từ đường dẫn
            System.Drawing.Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
            pb_Avatar.Image = thumb; // hiển thị ảnh lên PictureBox



        }

        private void client_t4_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thoát?");
            try
            {
                client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã rời phòng "));
                client?.Close();
            }
            catch { }
        }
    }
}

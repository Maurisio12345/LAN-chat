using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.ComTypes;

namespace Chatti
{
    public partial class Form1: Form
    {

        TcpClient client;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            //vontti
            txtChatbox.Font = new Font("Consolas", 15);

        }

        private void HandleClient(TcpClient client)
        {

        }


        public void BtnSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                // variablet
                string nimi = txtName.Text;
                string message = txtMessage.Text;

                // checkataan onko teksti boxi tyhjä
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtName.Text)) // jos ei kirjoita mitään chatissä ei tule lukemaan mitään
                {
                    return;
                }
               // katsotaan anonyymi tila
               if (chckAnonyymi.Checked)
                   nimi = "Anonyymi";

                string messageSend = nimi + " " + DateTime.Now.ToString("HH:mm") + " Said:" + Environment.NewLine + message + Environment.NewLine;

                byte[] data = Encoding.ASCII.GetBytes(messageSend);

                if (client == null || !client.Connected)
                {
                    client = new TcpClient("127.0.0.1", 1234); // or your server IP
                }

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length); // <== Send to server




            }
            catch (Exception ex)
            {   // kirjataan errorit
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // basic clear feature ei midii ihmeit
            // ei clearaa serversidellä vaan clientsidellä elikkä viestit pysyy servulla
            txtChatbox.Clear();
            // kirjoitetaan chattiin että se on tyhjennetty!
            txtChatbox.Text = "Chat has been cleared";
        }


        public void btnServer_Click(object sender, EventArgs e)
        {
            // tehdään omassa thredissä
            Task.Run(() =>
            {
                TcpListener server = new TcpListener(IPAddress.Any, 1234);
                server.Start();

                List<TcpClient> clients = new List<TcpClient>();

                this.Invoke((Action)(() =>
                {
                    txtChatbox.Text += "starting server...\r\n";
                }));

                while (true)
                {
                    TcpClient newClient = server.AcceptTcpClient();
                    clients.Add(newClient);

                    Task.Run(() =>
                    {
                        NetworkStream stream = newClient.GetStream();
                        byte[] buffer = new byte[1024];

                        while (true)
                        {
                            try
                            {
                                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                                if (bytesRead == 0) break; // disconnected

                                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                                this.Invoke((Action)(() =>
                                {
                                    txtChatbox.AppendText(message + "\r\n");
                                }));

                                foreach (var client in clients)
                                {
                                    try
                                    {
                                        NetworkStream s = client.GetStream();
                                        byte[] msgBytes = Encoding.ASCII.GetBytes(message);
                                        s.Write(msgBytes, 0, msgBytes.Length);
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                            catch
                            {
                                break;
                            }
                        }

                        clients.Remove(newClient);
                        newClient.Close();
                    });
                }
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    client = new TcpClient("127.0.0.1", 1234);
                    stream = client.GetStream();

                    Task.Run(() =>
                    {
                        byte[] buffer = new byte[1024];
                        while (true)
                        {
                            try
                            {
                                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                                if (bytesRead == 0) break;

                                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                                this.Invoke((Action)(() =>
                                {
                                    txtChatbox.AppendText(message + "\r\n");
                                }));
                            }
                            catch
                            {
                                break;
                            }
                        }
                    });

                    txtChatbox.AppendText("Connected to server.\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluetoothClientCSharp
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (portBox.Text == "" || iPBox.Text == "")
            {
                MessageBox.Show("One of the fields was left blank. Make sure to fill them both in correctly.", "Field blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (connectButton.Text == "Disconnect")
            {
                connectButton.Text = "Connect";
            }
            else
            {
                connectButton.Text = "Disconnect";
                try
                {
                    TcpListener listener = new TcpListener(Convert.ToInt32(portBox.Text));
                    listener.Start();
                    Socket socket = listener.AcceptSocket();
                    Stream networkStream = new NetworkStream(socket);
                    IPAddress address = IPAddress.Parse(iPBox.Text);
         
                    IPEndPoint endPoint = new IPEndPoint(address, 9000);
                    socket.Connect(endPoint);

                    byte[] data = new byte[1024];
                    int i = socket.Receive(data);
                    string stringReceived = Encoding.ASCII.GetString(data, 0, i);
                    addToListView(stringReceived);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addToListView(string value)
        {
            for (int i = 0; i < 9; i++)
            {
                string[] items = new string[1];
                items[0] = "hello";
                ListViewItem item = new ListViewItem(items);
                outputView.Items.Add(item);
            }
        }
    }
}

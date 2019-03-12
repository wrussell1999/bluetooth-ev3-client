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
using System.Threading;

namespace BluetoothClientCSharp
{
    public partial class Client : Form
    {
        Socket socket;
        IPEndPoint iPEndPoint;
        private Boolean isSending = false;
        Thread thread;
        List<string> outputList = new List<string>();
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

                IPHostEntry host = Dns.GetHostEntry(iPBox.Text);
                IPAddress iPAddress = host.AddressList[0];
                iPEndPoint = new IPEndPoint(iPAddress, Convert.ToInt32(portBox.Text));
                socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                if (!isSending)
                {
                    isSending = true;
                    thread = new Thread(Run);
                    //thread.IsBackground = true;
                    thread.Start();
                }
            }
        }

        public void Run()
        {
            try
            {
                socket.Connect(iPEndPoint);
                Console.WriteLine("Conected to " + socket.RemoteEndPoint.ToString());
                while (isSending)
                {
                    byte[] data = new byte[1024];
                    int received = socket.Receive(data);
                    string output = Encoding.UTF8.GetString(data, 0, received);
                    Console.WriteLine(output);
                    if (output != "")
                    {
                        outputList.Add(output);
                    }
                    addToListView(output);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connectButton.InvokeRequired)
                {
                    connectButton.Invoke((MethodInvoker) delegate()
                    {
                        connectButton.Text = "Connect";
                    });
                }
            }
        }

        public void StopSending()
        {
            isSending = false;
            if (thread.Join(200) == false)
            {
                thread.Abort();
            }
            thread = null;
        }

        private void addToListView(string value)
        {
            if (outputView.InvokeRequired)
            {
                outputView.Invoke((MethodInvoker) delegate()
                {        
                    outputView.Items.Clear();            
                    for (int i = 0; i < outputList.Count; i++)
                    {
                        string output = outputList[i].ToString().Trim();
                        string[] items = {output};
                        Console.WriteLine(output);   
                        ListViewItem item = new ListViewItem(items);
                        outputView.Items.Add(item);
                    }
                    outputView.Refresh();
                });
            }
            Console.WriteLine("Done listview " + outputList.Count);
            Console.WriteLine(outputView.Items.Count);
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            StopSending();
        }
    }
}

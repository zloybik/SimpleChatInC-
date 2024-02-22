using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 7000);

            NetworkStream stream = tcpClient.GetStream();
            byte[] buffer = new byte[1024];
            stream.Read(buffer, 0, buffer.Length);
            string end = Encoding.ASCII.GetString(buffer);
            MessageBox.Show(end);
            tcpClient.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Reflection;

namespace Envia
{
    public partial class Form1 : Form
    {
        bool laco = true;
        Thread mythread;
        Socket socketRecebeEnvia = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.2"), 9070);
        byte[] data = new byte[1024];
        int qtdbytes;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("User1: " + textBox1.Text);
            socketRecebeEnvia.SendTo(Encoding.ASCII.GetBytes("User1: " + textBox1.Text), endereco);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketRecebeEnvia.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Estado do chat: Mensagens ativadas.";
            mythread = new Thread(new ThreadStart(this.meuProcesso));
            mythread.Start();
        }
        private void meuProcesso()
        {
            socketRecebeEnvia.Bind(endereco);
            while (laco == true)
            {
                qtdbytes = socketRecebeEnvia.ReceiveFrom(data, ref endereco);
                listBox1.Invoke((Action)delegate()
                {
                    listBox1.Items.Add(Encoding.ASCII.GetString(data, 0, qtdbytes));
                    Refresh();
                });

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Estado do chat: Mensagens desativadas.";
            mythread.Abort();
        }
    }
}

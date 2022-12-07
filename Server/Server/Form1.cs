using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        StreamReader streamReader;
        StreamWriter streamWriter;

        private void Connect_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(connect);
            thread1.IsBackground = true;
            thread1.Start();
        }   

        private void connect()
        {
            TcpClient tcpClient1 = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox3.Text));

            tcpClient1.Connect(ipEnd);
            writeRichTextbox("¼­¹ö ¿¬°á µÊ");

            streamReader = new StreamReader(tcpClient1.GetStream());
            streamWriter = new StreamWriter(tcpClient1.GetStream());
            streamWriter.AutoFlush = true;

            while (tcpClient1.Connected)
            {
                string receiveData1 = streamReader.ReadLine();
                writeRichTextbox(receiveData1);
            }
        }

        private void writeRichTextbox(string data)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(data + "\r\n"); });
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string sendData1 = textBox2.Text;
            streamWriter.WriteLine(sendData1);
        }
    }
}
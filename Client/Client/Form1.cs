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

namespace Client
{

    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        StreamReader streamReader1;
        StreamWriter streamWriter1;

        private void button2_Click(object sender, EventArgs e) // connect button 클릭시
        {
            Thread thread1 = new Thread(connect); // Thread 객체 생성, Form과는 별도 쓰레드에서 connect 함수가 실행된다.
            thread1.IsBackground = true; // Form 종료시 thread1 종료
            thread1.Start(); // 시작
        }

        private void connect() // Main폼과는 별도로 작동, thread1에 연결됨.
        {
            TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox3.Text));
            tcpListener1.Start();
            writeRichTextBox("클라이언트 준비 서버 기다리는 중..");

            TcpClient tcpClient1 = tcpListener1.AcceptTcpClient();
            writeRichTextBox("서버 연결 됨");

            streamReader1 = new StreamReader(tcpClient1.GetStream());
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());
            streamWriter1.AutoFlush = true; 
            while (tcpClient1.Connected)
            {
                string receiveData1 = streamReader1.ReadLine();
                writeRichTextBox(receiveData1);
            }
        }

        private void writeRichTextBox(string str)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(str + "\r\n"); });
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string sendData1 = textBox2.Text;
            streamWriter1.WriteLine(sendData1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Ip 
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Port
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
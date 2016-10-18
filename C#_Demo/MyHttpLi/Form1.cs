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

namespace MyHttpLi
{
    public partial class Form1 : Form
    {
        HttpListener hl;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
            hl = new HttpListener();
            hl.Prefixes.Add(@"Http://localhost:8081/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Http正在监听......";
            hl.Start();
            Run();
        }

        private async Task Run()
        {
            Task t = Task.Run(() =>
            {
                while (true)
                {
                    HttpListenerContext hc = hl.GetContext();
                    //HttpListenerRequest hr = hc.Request;
                    HttpListenerResponse hp = hc.Response;
                    sw = new StreamWriter(hp.OutputStream);
                    sw.WriteLine("the message is comes from server");
                    sw.Close();
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Http监听关闭......";
            hl.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource;
        CancellationToken token;
        Task task;
        public Form1()
        {
            InitializeComponent();
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labA();
            lookdog();
        }

        private async Task labA()
        {
            task = Task.Run(() => { Thread.Sleep(2000); }, token);
            await task;
            this.label2.Text = "第1阶段";
            await task.ContinueWith((x) => { Thread.Sleep(3000); }, token);
            this.label2.Text += "--第2阶段";
            await task.ContinueWith((x) => { Thread.Sleep(3000); }, token);
            this.label2.Text += "--第3阶段";
        }

        private async Task lookdog()
        {
            while(true)
            {
               this.label3.Text = task.Status.ToString();
               await Task.Delay(1000);
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
    }
}

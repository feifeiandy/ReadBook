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
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public delegate void run();
        public delegate void mydele(string s);
        public int Count { get; set; }
        string dir = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                dir = AppDomain.CurrentDomain.BaseDirectory + @"1.xml";
                XDocument xml = XDocument.Load(dir);
                XElement ele = xml.Element("pc");
                var pc = from i in ele.Elements()
                         select i;
                foreach (var item in pc)
                {
                    if (item.Name == "ID")
                    {
                        this.textBox1.Text = item.Value;
                    }
                    if (item.Name == "BT")
                    {
                        this.textBox2.Text = item.Value;
                    }
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xml = XDocument.Load(this.dir);
                XElement ele = xml.Element("pc");
                var pc = from i in ele.Elements()
                         select i;
                foreach (var item in pc)
                {
                    if (item.Name == "ID")
                    {
                        item.SetValue(textBox1.Text);
                    }
                    if (item.Name == "BT")
                    {
                        item.SetValue(textBox2.Text);
                    }
                }
                xml.Save(this.dir);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //public delegate void run();
            //public delegate void mydele(string s);
            mydele dele = new mydele(temp);
            dele.BeginInvoke("开启线程异步计算...", null, null);
        }
        public void temp(string s)
        {
            MessageBox.Show(s);
            for (int i = 0; i < 2000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Count += j;
                }
            }
            run r = new run(fun);
            this.BeginInvoke(r, null);
        }

        private void fun()
        {
            this.textBox3.Text = Count.ToString();
        }
    }
}

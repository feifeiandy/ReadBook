using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public  EventHandler btn1;
        public  EventHandler btn2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn1 += butt1;
            btn1 += butt2;
            btn2 += butt2;
        }
        private void butt1(object sender, EventArgs e)
        {
            this.button1.Height = 30;
            this.button1.Width = 30;
            //this.button1.Visible = false;
        }
        private void butt2(object sender, EventArgs e)
        {
            this.button2.Height = 80;
            this.button2.Width = 220;
            //this.button2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn1(sender,e);
        }
    }
}

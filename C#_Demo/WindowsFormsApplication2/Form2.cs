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
    public partial class Form2 : Form
    {
        Form1 F;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.F = new Form1();
            this.F.Show();
            this.F.btn1 += Cick;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Cick(object sender, EventArgs e)
        {
            MessageBox.Show("121");
        }
    }
}

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
using WindowsFormsApplication3.Models;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
             run();
            SysUser sys = await this.login(this.textBox1.Text);
            if (sys.Password==this.textBox2.Text)
            {
                MessageBox.Show("密码正确");
                this.flag = false;
                this.progressBar1.Visible = false;
            }
            else
            {
                MessageBox.Show("密码不正确");
            }
            
        }

        private async Task run()
        {
            this.progressBar1.Value = 0;

            while (flag)
            {
                this.progressBar1.Value +=1;
                await sleep();
                if (this.progressBar1.Value == 100)
                {
                    this.progressBar1.Value = 0;
                }
            }
        }

        private async Task sleep()
        {
            Task a = new Task(() => { Thread.Sleep(100); });
            a.Start();
            await a;
        }

        private async Task<SysUser> login(string ID)
        {

            Task<SysUser> login = new Task<SysUser>(

              () => {
                  aisino_mesContext context = new aisino_mesContext();
                  SysUser s = context.Set<SysUser>().Single(c => c.LoginName == ID);
                  return s;
              });
            login.Start();
            SysUser ln = await login;
            return ln;
        }


    }

    class Login
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}

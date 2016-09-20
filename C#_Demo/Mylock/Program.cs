using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mylock
{
    class Program
    {
        private readonly object lk = new object();
        static void Main(string[] args)
        {                     
            Program p = new Program();
            Task<int> t= p.read(3000);

            Task<int> go = t.ContinueWith<int>((x) => {Thread.Sleep(2000); return 123; });

            //(x) => { new Task(() => { Thread.Sleep(1000); Console.WriteLine("ssss"); }).Start(); }
            p.write();
            Console.WriteLine("main...run");
            Console.Read();
        }

        private async Task<int> read(int A)
        {
            Task<int> a = new Task<int>(() => {
                lock (this.lk)
                {
                    Thread.Sleep(A);
                    Console.WriteLine("正在读取......");
                    return A;
                }
            });
            a.Start();
            int t = await a;
           return t;
        }

        private void ct(Task tk)
        {

        }

        private async void write()
        {
            Task a = new Task(() =>
            {
                lock (this.lk)
                {
                    Console.WriteLine("正在写入......");
                }
            });
            a.Start();
            await a;
        }
    }
}

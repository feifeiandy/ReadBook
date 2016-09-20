using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Task a = new Task(pg.Temp);
            a.Start();
            Console.WriteLine("-----------------------------------------");
            Console.Read();
        }

        public async void Temp()
        {
            await get();
       
        }

        public async Task get()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage temp = await client.GetAsync("http://www.baidu.com");
            HttpContent ht = temp.Content;
            Console.WriteLine(ht.Headers);
        } 
    }

    
}

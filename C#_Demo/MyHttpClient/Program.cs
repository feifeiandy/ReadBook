using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MyHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program pg = new Program();
            //Task a = new Task(pg.Temp);
            //a.Start();
            //Console.WriteLine("-----------------------------------------");
            //Console.Read();
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(@"http://www.baidu.com");
            //http.Headers.Add(HttpRequestHeader.Accept, @"text");
            http.Method = "POST";
            http.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-us");
            //http.Headers.Add(HttpRequestHeader.Cookie, @"_bsi=17929308146762715123_00_0_I_R_11_0303_C02F_N_I_I_0");
            http.Date = DateTime.Now;
            HttpWebResponse res = (HttpWebResponse)http.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream(),Encoding.UTF8);
            Console.Write(sr.ReadToEnd());
            sr.Close();
            res.Close();
            Console.ReadLine();
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

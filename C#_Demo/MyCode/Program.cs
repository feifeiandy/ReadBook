using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo file = new FileInfo(@"D://z.code");
            //FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //string a = "a";
            //BinaryFormatter fm = new BinaryFormatter();
            //Person p = new Person() { ID = 12, Name = "中国" };
            //fm.Serialize(fs,p);
            //fs.Write(Encoding.UTF8.GetBytes(a), 0, Encoding.UTF8.GetBytes(a).Length);
            //fs.Flush();

            //fs.Position = 0;
            //Person dp = (Person)fm.Deserialize(fs);
            ////Console.WriteLine(dp.Name);
            //fs.Position = 0;
            //byte[] b = new byte[20];
            //fs.Read(b, 0, Encoding.UTF8.GetBytes(a).Length);
            //string str = Encoding.UTF8.GetString(b);
            //Console.WriteLine(str);
            //fs.Close();

            // 序列化


            //byte[] bytes = new byte[] { 97,98,99};
            //char[] chars = Encoding.ASCII.GetChars(bytes);
            //Array.ForEach(chars,(x)=>{Console.WriteLine(x);});

            WebClient web = new WebClient();
            Console.WriteLine("正在下载.....");
            web.DownloadFile(@"ftp://192.168.10.101/test.txt","D://s2.txt");
            Console.WriteLine("下载完成.....");
            Console.Read();
        }
    }

    [Serializable]
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

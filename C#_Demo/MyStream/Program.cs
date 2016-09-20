using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFG";
            byte[] strByte = System.Text.Encoding.Default.GetBytes(str);
            FileInfo file = new FileInfo(@"D://2.txt");
            FileStream fs = file.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(str);
            sw.Flush();
            char[] ch = new char[strByte.Length];
            fs.Position = 0;
            StreamReader sr = new StreamReader(fs);
            sr.Read(ch, 0, strByte.Length);
            Console.WriteLine(ch);
            Console.Read();
            sw.Close();
            sr.Close();
            ////string s = "ABC";
            //byte[] b1 = new byte[10];
            //MemoryStream ms = new MemoryStream(b1);
            //BufferedStream bf = new BufferedStream(ms);
            //StreamWriter sw = new StreamWriter(bf);

            //sw.Write(s);
            
            //sw.Flush();
            //ms.Position = 0;
            //StreamReader sr = new StreamReader(bf);
            //string sk = sr.ReadLine();
            //Console.WriteLine(sk);
            //Console.Read();
        }
    }
}

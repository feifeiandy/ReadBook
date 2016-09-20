using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] cChar = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            //string sData = "abc";
            //byte[] byteData = Encoding.Default.GetBytes(cChar);
            //byte[] stringData = Encoding.Default.GetBytes(sData);
            //Console.WriteLine(byteData[0]);
            //Console.WriteLine(stringData[0]);

            //FileInfo f = new FileInfo("D://4.b");
            //FileStream file =(f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite));
            //BinaryWriter bw = new BinaryWriter(file);

            //bw.Write("abcdefg");
            //bw.Write("ABCDEFG");
            //bw.Flush();

            //BinaryReader br = new BinaryReader(file);
            //file.Position = 0;
            //string s = br.ReadString() + br.ReadString();
            //bw.Close();
            //Console.WriteLine(s);

            //string uri = @"http://scimg.jb51.net/allimg/160815/103-160Q509544OC.jpg";
            //WebClient web = new WebClient();
            //web.DownloadFile(uri,"D://3.png");

            //string PageInputStr = "靠.TMMD,今天真不爽....";
            //string RegexStr = @"靠|TMMD|妈的";
            //Regex rep_regex = new Regex(RegexStr);
            //Console.WriteLine("用户输入信息：{0}", PageInputStr);
            //Console.WriteLine("页面显示信息：{0}", rep_regex.Replace(PageInputStr, "***"));
            string version = Environment.Version.ToString();
            if (string.Compare(version, "4.0.30319") < 1)
            {
                Console.WriteLine("请安装 .NET FrameWork 4.5");
            }
            Console.WriteLine();
            Console.Read();

        }

        public void fun()
        {
        }
    }
}

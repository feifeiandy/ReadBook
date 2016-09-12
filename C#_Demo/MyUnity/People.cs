using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnityTest
{
    public class People : IPeople
    {
        public People()
        {
            Console.WriteLine("系统构造People...........");
        }
        public void print(string s)
        {
            Console.WriteLine(s);
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}

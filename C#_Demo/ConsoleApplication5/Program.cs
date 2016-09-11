using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            XiaoDong boy = new XiaoDong() { Name = "小东" };
            Girl girl = new Girl() {Name="娇娇"};
            Proxy proxy = new Proxy(boy);
            proxy.GiveFlows(girl);
            Console.Read();
        }

        
    }
    class XiaoDong:Boy
    { 
    }
}

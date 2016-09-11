using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Proxy:IGiveGift
    {
        private string name;
        public Proxy(Boy boy)
        {
            this.name = boy.Name;
        }
        public void GiveFlows(Girl girl)
        {
            //Girl girl = new Girl() { Name="娇娇"};
            Console.WriteLine(girl.Name+":给你礼物！我是：gg"+this.name);
        }
    }
}

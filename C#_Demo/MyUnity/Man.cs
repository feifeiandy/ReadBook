using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnityTest
{
    public class Man:IHuman
    {
        IPeople p;
        [InjectionConstructor]
        public Man(IPeople p)
        {
            this.p = p;
            
        }
        public void run(string s)
        {
            this.p.print(s);
        }

        public int sum(int a,int b)
        {
            return this.p.sum(a,b);
        }
    }
}

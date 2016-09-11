using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man() { MyProperty=1};

            Func<Human> h = () =>m;
            Console.WriteLine(h().MyProperty);

          
            Action<Man> a = new Action<Man>(fun);
            a(m);
        
            Console.Read();
        }

        public static void fun(Human m)
        {
            Console.WriteLine(m.MyProperty);
        }
    }


    public class Human
    {
        public int MyProperty { get; set; }
    }

    public class Man:Human
    {
        public override string ToString()
        {
            return "123";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.fun(x=>x.run("abc"));

            P.fun(x=>x.sum(1,3));
            Console.Read();
        }

        public void fun(Expression<Action<IOring>> ac)
        {
            MyClass my = new MyClass();
            ac.Compile()(my);
        }
    }

    public interface IOring
    {
        void run(object a);

        void sum(int a, int b);
    }

    class MyClass:IOring
    {
        public void run(object a)
        {
            Console.WriteLine(a);
        }

        public void sum(int a,int b)
        {
            Console.WriteLine(a + b); 
        }
    }
}

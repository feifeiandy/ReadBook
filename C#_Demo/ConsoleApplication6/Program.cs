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
        public delegate void delerun(IOring x);
        delerun deletemp;
        delerun deletempSecond;

        static void Main(string[] args)
        {
            Console.WriteLine("方法参数使用Action声明");
            Program P = new Program();
            P.fun(x => x.run("abc"));
            P.fun(P.FX);
            Console.WriteLine();

            Console.WriteLine("方法参数使用Delegate声明");
            P.delerunTest(x => x.run("FX"));
            Console.WriteLine("---------------------------------");
            P.delerunTest(P.FX);
            P.delerunTest(P.FX2);
            Console.WriteLine();

            P.deletempSecond += (X) => { X.run("xx"); };
            P.deletempSecond(new MyClass());

            Console.WriteLine("Delegate通过方法传递给类");
            P.test();
            Console.Read();

        }
        public void fun(Action<IOring> ac)
        {
            MyClass my = new MyClass();
            ac(my);
        }

        public void delerunTest(delerun run)
        {
            MyClass my = new MyClass();
            run(my);

            deletemp = run;
        }

        public void test()
        {
            MyBob my = new MyBob();
            this.deletemp(my);
        }

        public void FX(IOring x)
        {
            string a = "FX";
            x.run(a);
        }
        public void FX2(IOring x)
        {
            string a = "FX2";
            x.run(a);
        }
        //public void fun(Expression<Action<IOring>> ac)
        //{
        //    MyClass my = new MyClass();
        //    ac.Compile()(my);
        //}


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

        public static void to(string s)
        {
            Console.WriteLine(s);
        }
    }

    class MyBob : IOring
    {
        public void run(object a)
        {
            Console.WriteLine(a.ToString()+"委托中间层");
        }

        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void to(string s)
        {
            Console.WriteLine(s);
        }
    }
}

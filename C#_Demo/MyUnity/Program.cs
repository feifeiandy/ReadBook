using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MyUnityTest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection unity = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            unity.Configure(container,"myunity");

           IHuman man= container.Resolve<IHuman>("hu");
           Console.WriteLine(man.sum(1,2));
           Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Duck;

namespace Sample3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ReSharper disable AssignNullToNotNullAttribute

            var duckPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "duck.dll");
            var iDuck = (Assembly.LoadFile(duckPath)
                                 .GetTypes()
                                 .Where(t => !t.IsInterface)
                                 .Where(t => typeof (IDuck).IsAssignableFrom(t))).First();

            IDuck instance = Activator.CreateInstance(iDuck) as IDuck;
            dynamic dynInstance = Activator.CreateInstance(iDuck);
            if (instance != null)
            {
                Console.WriteLine("From typed:" + instance.Quack());
                Console.WriteLine("From dynamics:" + dynInstance.Quack());
            }

            // ReSharper restore AssignNullToNotNullAttribute
            Console.ReadLine();
        }
    }
}
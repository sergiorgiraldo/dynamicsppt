using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Program
    {
        static void Main()
        {
            var dateTime = new DateTime(2012, 12, 12);
            dynamic dt = Print(dateTime); 
            Console.WriteLine(dt is DateTime);
            Console.ReadLine();
        }
        static dynamic Print(dynamic what)
        {
            Console.WriteLine(what);
            return what;
        }
    }
}

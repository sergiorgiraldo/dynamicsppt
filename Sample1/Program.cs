using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intFoo = 2;
            int intBar = 3;
            Console.WriteLine(intFoo + intBar);
            dynamic dynFoo = 2;
            dynamic dynBar = 3;
            Console.WriteLine(dynFoo + dynBar);
            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;

namespace Sample7
{
    internal class Program
    {
        private static void Main()
        {
            dynamic a = 10;
            dynamic b = 32;
            dynamic sum = a + b;
            Console.WriteLine(sum);
            Thread.Sleep(500);
        }
    }
}
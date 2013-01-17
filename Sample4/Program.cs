using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck;
// ReSharper disable PossibleNullReferenceException

namespace Sample4
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myDuck = new MyDuck();
            var duck = myDuck as IDuck;
            Console.WriteLine("From dynamics:" + duck.Quack());
            Console.ReadLine();
        }
    }

    class MyDuck
    {
        public string Quack()
        {
            return "Quack!";
        }

        public void Walk(int howFar)
        {
            Console.WriteLine("Walked " + howFar);
        }
    }
}
// ReSharper restore PossibleNullReferenceException

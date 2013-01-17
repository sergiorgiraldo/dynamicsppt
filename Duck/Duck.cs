using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public class Duck : IDuck
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

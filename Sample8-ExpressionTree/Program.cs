using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sample8_ExpressionTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Way1();
            Way2();
            Console.ReadLine();
        }

        private static void Way1()
        {
            Expression<Action<string>> printExpression = (what) => Console.WriteLine(what);

            printExpression.Compile()("Hello World");
        }

        private static void Way2()
        {
            ParameterExpression param = Expression.Parameter(typeof (string), "what");

            MethodCallExpression methodCall = Expression.Call(
                typeof (Console).GetMethod("WriteLine", new[] {typeof (string)}), param);

            Expression.Lambda<Action<string>>(methodCall, new[] {param}).Compile()("Hello World");
        }
    }
}
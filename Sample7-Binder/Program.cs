using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace Sample7_Binder
{
    internal class Program
    {
        private static void Main()
        {

            #region (...)
            CSharpArgumentInfo argumentInfo = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
            var returnLabel = Expression.Label("_");
            var a = Expression.Parameter(typeof (object));
            var b = Expression.Parameter(typeof (object));
            #endregion
            var adding = Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Program),
                                                new[]
                                                    {
                                                        argumentInfo,
                                                        argumentInfo
                                                    });
            var codeAdding = adding.Bind(new object[] {10, 32},
                                         new ReadOnlyCollection<ParameterExpression>(new List<ParameterExpression>
                                             {
                                                 a,
                                                 b
                                             }),
                                         returnLabel);
            var resultAdding =
                Expression.Lambda(Expression.Dynamic(adding, typeof (object),
                                                     new Expression[]
                                                         {
                                                             Expression.Constant(10), Expression.Constant(32)
                                                         }))
                          .Compile()
                          .DynamicInvoke();
        }
    }
}
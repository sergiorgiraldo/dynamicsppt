// ReSharper disable InconsistentNaming
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace Sample2_Decompiled
{
    internal class Program
    {
        private static void Main()
        {
            object obj1 = 10;
            object obj2 = 32;
            if (Main_SiteContainer0._Site1 == null)
                Main_SiteContainer0._Site1 =
                    CallSite<Func<CallSite, object, object, object>>.Create(
                        Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Program),
                                               new[]
                                                   {
                                                       CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                                                       CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
                                                   }));
            
            object obj3 = Main_SiteContainer0._Site1.Target(Main_SiteContainer0._Site1, obj1, obj2);
            
            if (Main_SiteContainer0._Site2 == null)
                Main_SiteContainer0._Site2 =
                    CallSite<Action<CallSite, Type, object>>.Create(
                        Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof (Program),
                                            new[]
                                                {
                                                    CSharpArgumentInfo.Create(
                                                        CSharpArgumentInfoFlags.UseCompileTimeType |
                                                        CSharpArgumentInfoFlags.IsStaticType, null),
                                                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
                                                }));
            
            Main_SiteContainer0._Site2.Target(Main_SiteContainer0._Site2, typeof (Console), obj3);
            
            Thread.Sleep(500);
        }

        private static class Main_SiteContainer0
        {
            public static CallSite<Func<CallSite, object, object, object>> _Site1;
            public static CallSite<Action<CallSite, Type, object>> _Site2;
        }
    }
}
// ReSharper restore InconsistentNaming
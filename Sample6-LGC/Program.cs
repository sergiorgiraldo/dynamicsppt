using System;
using OpCodes = System.Reflection.Emit.OpCodes;

namespace Sample6_LGC
{
    internal class Program
    {
        private static void Main()
        {
            System.Reflection.Emit.DynamicMethod lgcMethod =
                new System.Reflection.Emit.DynamicMethod("HelloWorld",
                                                         typeof (void),
                                                         new Type[] {},
                                                         typeof (Program),
                                                         false);

            System.Reflection.Emit.ILGenerator il = lgcMethod.GetILGenerator();

            il.Emit(OpCodes.Ldstr, "Hello World");
            il.Emit(OpCodes.Call, typeof (Console).GetMethod("WriteLine", new[] {typeof (string)}));
            il.Emit(OpCodes.Call, typeof (Console).GetMethod("ReadLine"));
            il.Emit(OpCodes.Ret);

            lgcMethod.Invoke(null, null);
        }
    }
}
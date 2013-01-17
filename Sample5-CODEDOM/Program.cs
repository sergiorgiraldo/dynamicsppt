using System;
using System.Reflection;
using Microsoft.CSharp;
using CodeDom = System.CodeDom.Compiler;

namespace Sample5_CODEDOM
{
    internal class Program
    {
        private static void Main()

        {
            var tc = new TestCompile();
            tc.Execute();
        }
    }

    public sealed class TestCompile
    {
        public void Execute()
        {
            var cscp = new CSharpCodeProvider();
            Compile(cscp);
        }


        private void Compile(CodeDom.CodeDomProvider provider)
        {
            const string source =
                "public class Sample5Mem {public void Do(){System.Console.WriteLine(\"Hello World\");System.Console.ReadLine();} }";


            var param = new CodeDom.CompilerParameters
                {
                    GenerateExecutable = false,
                    IncludeDebugInformation = false,
                    GenerateInMemory = true
                };
            CodeDom.CompilerResults cr = provider.CompileAssemblyFromSource(param, source);
            object instance = cr.CompiledAssembly.CreateInstance("Sample5Mem");
            if (instance != null)
            {
                Type type = instance.GetType();
                type.InvokeMember("Do",
                                  BindingFlags.InvokeMethod | BindingFlags.Default,
                                  null,
                                  instance,
                                  null);
            }
        }
    }
}
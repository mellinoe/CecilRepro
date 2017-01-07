using System;
using Mono.Cecil;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AssemblyDefinition.ReadAssembly(args[0]).Write(args[1]);
        }
    }
}

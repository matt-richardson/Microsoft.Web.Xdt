using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NUnit.Common;
using NUnitLite;

namespace TestRunner
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var testAssembly = typeof(Program).GetTypeInfo().Assembly;
            return new AutoRun(testAssembly).Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}

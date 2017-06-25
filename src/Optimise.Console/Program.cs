using System;
using Optimise.Logic;

namespace Optimise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestingVSCode test = new TestingVSCode(55);
            Console.WriteLine("Number returned from Test class is {0}.", test.ANumber);
              }
    }
}

using System;

namespace TestBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Assembly: {ThisAssembly.AssemblyVersion}");
            Console.WriteLine($"Assembly: {ThisAssembly.AssemblyFileVersion}");
            Console.WriteLine($"Another release");
        }
    }
}

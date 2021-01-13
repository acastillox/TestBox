using System;

namespace TestBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current Version: {ThisAssembly.Version}");
            Console.WriteLine($"Current Version: {ThisAssembly.SimpleVersion}");
            Console.WriteLine($"Current Version: {ThisAssembly.InformationalVersion}");
            Console.WriteLine($"Another log");
        }
    }
}

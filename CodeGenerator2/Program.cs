using System;

namespace CodeGenerator2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hello("Vincent");
            new ForTestOnly.ForTestOnly();
            Console.ReadLine();
        }

        static partial void Hello(string Name);
    }
}

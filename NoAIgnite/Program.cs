using System;

namespace NoAIgnite
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter();
            Console.WriteLine(conv.Start(args));
        }
    }
}

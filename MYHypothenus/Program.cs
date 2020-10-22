using System;

namespace Hypothenus
{
    class Program
    {
        static void Main(string[] args)
        {
            Hypothenus hypothenuse = new Hypothenuse(4, 5);

            Console.WriteLine($"{hypothenuse.Hypothenes()}");
        }
    }
}
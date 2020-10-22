using System;

namespace MinimumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter you second number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter you third number: ");
            float num3 = float.Parse(Console.ReadLine());


            float Min = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine($"The smallest number is {Min}");
        }
    }
}

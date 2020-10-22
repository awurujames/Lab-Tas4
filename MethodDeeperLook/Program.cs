using System;

namespace MethodDeeperLook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerPower(3, 3));
        }

        static int IntegerPower(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;


        }


    }
}

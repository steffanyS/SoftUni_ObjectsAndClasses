using System;
using System.Numerics;

namespace _03_BigFactorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }

        public static BigInteger Fact(int num)
        {
            BigInteger fact=1;
            for (int i = 1; i <=num; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}

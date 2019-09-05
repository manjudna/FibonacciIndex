using System;
using System.Numerics;

namespace FibonacciIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the index number: ");
            var number = Console.ReadLine();

            string result = string.Format("The Fibonacci number at index {0} is {1}" ,number, Fib(Convert.ToInt32(number)));
            Console.WriteLine(result);
            Console.ReadLine();
        }

              

        /// <summary>
        /// returns the fib number at given 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static BigInteger Fib(int n)
        {
            int number = n ;                                       
            BigInteger[] Fib = new BigInteger[n+1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            var v = (BigInteger)Fib[number];
            return Fib[number];
        }


    }
}

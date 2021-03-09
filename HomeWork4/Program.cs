using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число");

            int n = int.Parse(Console.ReadLine());

            for (int j = 2; j < n; j++)
            {
                bool isPrime = IsPrime(j);

                if (isPrime)
                {
                    Console.Write(j + " ");
                }

            }


        }
        private static bool IsPrime(int n)

        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}

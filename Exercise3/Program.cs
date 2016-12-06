using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение простого числа\n");
            bool prost = true;
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            if (prost)
            {
                Console.WriteLine("\nЧисло простое");
            }
            else
            {
                Console.WriteLine("\nЧисло не простое");
            }
            Console.ReadKey();
        }
    }
}

using System;
namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Поиск простых чисел в диапазоне\n");
            long g = 0, a = 1;
            Console.Write("Начало диапазона: ");
            long k = long.Parse(Console.ReadLine());
            Console.Write("Конец диапазона: ");
            long n = long.Parse(Console.ReadLine());
            Console.Write("\nРешето Эратосфена:\n");

            for (int i = 1; i <= n; i++)
            {
                a++;
                for (int z = 2; z <= n; z++)
                {
                    if (a == z) { }
                    else if (a % z != 0) { }
                    else if (a % z == 0) { g++; }
                }
                if (a > k)
                {
                    if (g == 0)
                    {
                        Console.Write("{0}\t", a);
                    }
                }
                g = 0;
            }
            Console.WriteLine("\n\nГотово!");
            Console.ReadLine();
        }
    }
}

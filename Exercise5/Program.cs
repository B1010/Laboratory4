using System;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Определение наибольшего числа из 3 введённых\n");
            Console.Write("Первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Третье число: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("\n{0}", a);
                    }
                    else
                    {
                        Console.WriteLine("\n{0}", a);
                    }
                }
                else
                {
                    Console.WriteLine("\n{0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a < c)
                    {
                        Console.WriteLine("\n{0}", b);
                    }
                    else
                    {
                        Console.WriteLine("\n{0}", b);
                    }
                }
                else
                {
                    Console.WriteLine("\n{0}", c);
                }
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вывод введённых чисел в порядке возрастания\n");
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
                        Console.WriteLine("\n{0} -> {1} -> {2}", c, b, a);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} -> {1} -> {2}", b, c, a);
                    }
                }
                else
                {
                    Console.WriteLine("\n{0} -> {1} -> {2}", b, a, c);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a < c)
                    {
                        Console.WriteLine("\n{0} -> {1} -> {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} -> {1} -> {2}", c, a, b);
                    }
                }
                else
                {
                    Console.WriteLine("\n{0} -> {1} -> {2}", a, b, c);
                }
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Exercise7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Поиск отрицательных чисел, при их нахождении они возводится в квадрат и если результат больше 20, умножается на 2\n");
            Console.Write("Первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Третье число: ");
            double c = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("\nВсе числа положительные!");
            }
            if (a < 0)
            {
                double initnum = a;
                a = Math.Pow(a, 2);
                if (a > 20)
                {
                    a = a * 2;
                    Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, a);
                }
                else { Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, a); }
                initnum = 0;
            }
            if (b < 0)
            {
                double initnum = b;
                b = Math.Pow(b, 2);
                if (b > 20)
                {
                    b = b * 2;
                    Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, b);
                }
                else { Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, b); }
                initnum = 0;
            }
            if (c < 0)
            {
                double initnum = c;
                c = Math.Pow(c, 2);
                if (c > 20)
                {
                    c = c * 2;
                    Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, c);
                }
                else { Console.Write("\nГотово! Первоначальное число: {0}. Результат: {1}", initnum, c); }
            }
            Console.ReadLine();
        }
    }
}

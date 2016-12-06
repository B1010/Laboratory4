using System;

namespace Exercise8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Определение значения функции\n");
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                x = 1;
            }
            if (x == 0)
            {
                x = 0;
            }
            if (x < 0)
            {
                x = -1;
            }

            Console.WriteLine("(x)= {0}", x);
            Console.ReadLine();
        }
    }
}

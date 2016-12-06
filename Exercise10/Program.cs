using System;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер кирпича");
            Console.Write("Сторона a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Сторона b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Сторона c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите размер отверстия");
            Console.Write("Сторона d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Сторона e = ");
            double e = double.Parse(Console.ReadLine());

            if ((a <= d) && (b <= e) || (a <= e) && (b <= d) || (c <= d) && (b <= e) || (c <= e) && (b <= d) || (c <= d) && (a <= e) || (c <= e) && (a <= d))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}

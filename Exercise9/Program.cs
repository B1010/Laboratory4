using System;
namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Определение типа треугольника\n");
            Console.WriteLine("Введите значение сторон треугольника\n");
            Console.Write("Сторона a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Сторона b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Сторона c = ");
            double c = double.Parse(Console.ReadLine());

            if (!(a + b > c) || !(a + c > b) || !(c + b > a))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдна из сторон треугольника задана неверно");
                Console.ResetColor();
            }
            else if ((a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))) || (b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))) || (c == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2))))
            {
                Console.WriteLine("\nТреугольник прямоугольный");
            }
            else if ((a == b) && (b == c) && (c == a))
            {
                Console.WriteLine("\nТреугольник равносторонний");
            }
            else if ((a == b) || (b == c) || (c == a))
            {
                Console.WriteLine("\nТреугольник равнобедренный");
            }
            else if (!(a == b) && !(b == c) && !(c == a))
            {
                Console.WriteLine("\nТреугольник разносторонний");
            }
            Console.ReadLine();
        }
    }
}

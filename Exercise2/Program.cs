using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Определение шестизначного \"счастливого\" числа\n");
            Console.Write("Введите шестизначное число: ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();

            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("Число счастливое: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("Число не счастливое: {0} != {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("Число введено не правильно!");

            Console.Read();
        }
    }
}

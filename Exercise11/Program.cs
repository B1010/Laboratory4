using System;

namespace Exercise11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добавить \"год\",\"года\" или \"лет\" к введённому возрасту\n");
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            int iAGE = age % 10;
            int jAGE = age % 100;

            //Если число оканчивается на 1, то "год". Если на 2,3,4, то "года". Если на 0,5,6,7,8,9, то "лет"

            if (age < 0)
            {
                Console.WriteLine("Вы не ввели количество лет \n");
            }
            else if (age == 1 || (iAGE == 1 && jAGE != 11))
            {
                Console.WriteLine("{0} год", age);
            }
            else if (iAGE > 1 && iAGE < 5 && jAGE != 12 && jAGE != 13 && jAGE != 14)
            {
                Console.WriteLine("{0} года", age);
            }
            else
            {
                Console.WriteLine("{0} лет", age);
            }
            Console.ReadLine();
        }
    }
}

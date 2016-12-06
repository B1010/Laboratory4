using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Перевод числа из двоичной системы счисления в десятичную или наоборот\n");
            Console.Write("Введите число: ");
            string iDECBIN = Console.ReadLine();

            Console.Write("В какую систему счисления вы хотите перевести число? (DEC или BIN): ");
            string SELECTED_CODE = Convert.ToString(Console.ReadLine().ToUpper());

            if (SELECTED_CODE == "DEC")
            {
                int toDEC = Convert.ToInt32(iDECBIN, 2);
                Console.WriteLine("\nВаш результат в десятичной системе счисления: " + toDEC);
            }
            else if (SELECTED_CODE == "BIN")
            {
                long iBINDEC = long.Parse(iDECBIN);
                iDECBIN = Convert.ToString(iBINDEC, 2);
                Console.WriteLine("\nВаш результат в двоичной системе счисления: " + iDECBIN);
            }
            else
            {
                Console.WriteLine("\nПеревод в данную систему счисления невозможен, или система счисления была введена неправильно");
            }
            Console.ReadLine();
        }
    }
}

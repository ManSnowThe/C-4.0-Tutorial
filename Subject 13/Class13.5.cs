// Использовать вложенный блок try.
using System;

namespace ca2
{
    class NestTrys
    {
        static void Main()
        {
            // Здесь массив numer длиннее массива denom.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            try
            { // внешний блок try
                for (int i = 0; i < numer.Length; i++)
                {
                    try
                    { // вложенный блок try
                        Console.WriteLine(numer[i] + " / " +
                        denom[i] + " равно " +
                        numer[i] / denom[i]);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Делить на нуль нельзя!");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Подходящий элемент не найден.");
                Console.WriteLine("Неисправимая ошибка - программа прервана.");
            }
        }
    }
}

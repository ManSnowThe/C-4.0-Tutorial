// Изящно обработать исключительную ситуацию и продолжить выполнение программы.
// Использовать несколько операторов catch.
using System;

namespace ca2
{
    class ExcDemo3
    {
       static void Main()
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            for(int i=0; i< numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    // Перехватить исключение.
                    Console.WriteLine("Делить на нуль нельзя!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Подходящий элемент не найден.");
                }
            }
        }
    }
}

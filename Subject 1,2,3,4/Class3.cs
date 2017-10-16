// Вычислить сумму и произведение чисел от 1 до 10.
using System;

namespace ca2
{
    class CodeBlockDemo2
    {
        static void Main()
        {
            int sum, proiz, i;

            sum = 0;
            proiz = 1;

            for(i=1; i<=10; i++)
            {
                sum = sum + i;
                proiz = proiz * i;
            }
            Console.WriteLine("Сумма равна " +sum);
            Console.WriteLine("Произведение равно " +proiz);
        }
    }
}
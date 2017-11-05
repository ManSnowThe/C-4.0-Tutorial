// Еще один пример применения метода Format().
using System;

namespace ca2
{
    class FormatDemo2
    {
        static void Main()
        {
            int i;
            int sum = 0;
            int prod = 1;
            string str;

            // Отобразить текущую сумму и произведение чисел от 1 до 10.
            for(i=1; i<=10; i++)
            {
                sum += i;
                prod *= i;
                str = String.Format("Сумма:{0,3:D} Произведение:{1,8:D}", sum, prod);
                Console.WriteLine(str);
            }
        }
    }
}

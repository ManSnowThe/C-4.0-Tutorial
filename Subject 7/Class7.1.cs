// Вычислить среднее арифметическое ряда значений.
using System;

namespace ca2
{
    class Avarage
    {
       static void Main()
        {
            int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
            int avar = 0;

            for (int i=0; i<10; i++)
            avar = avar + nums[i];

            avar = avar / 10;

            Console.WriteLine("Среднее " + avar);
            
        }
    }
}
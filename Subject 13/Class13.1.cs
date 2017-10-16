// Продемонстрировать обработку исключительной ситуации.
using System;

namespace ca2
{
    class ExcDemo1
    {
        static void Main()
        {
            int[] nums = new int[4];

            try
            {
                Console.WriteLine("До генерирования исключения.");

                // Сгенерировать исключение в связи с выходом индекса за границы массива.                for(int i=0; i<10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);                }
                Console.WriteLine("Не подлежит выводу.");
            }

            catch(IndexOutOfRangeException)
            {
                // Перехватить исключение.
                Console.WriteLine("Индекс вышел за границы массива!");
            }
            Console.WriteLine("После блока перехвата исключения.");
        }
    }
}

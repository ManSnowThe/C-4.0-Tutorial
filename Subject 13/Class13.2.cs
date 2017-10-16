/* Исключение может быть сгенерировано одним методом
и перехвачено другим. */
using System;

namespace ca2
{
    class ExcTest
    {
        //  Сгенерировать исключение.
        public static void GenException()
        {
            int[] nums= new int[4];

            Console.WriteLine("До генерирования исключения.");
            
            // Сгенерировать исключение в связи с выходом индекса массива.
            for(int i=0; i<10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}] : {1}", i, nums[i]);
            }
            Console.WriteLine("Не подлежит выводу");
        }
    }
    class ExcDemo2
    {
        static void Main()
        {
            try
            {
                ExcTest.GenException();
            }
            catch (IndexOutOfRangeException)
            {
                // Перехватить исключение.
                Console.WriteLine("Индекс вышел за границы массива!");
            }
            Console.WriteLine("После блока перехвата исключения.");
        }
    }
}

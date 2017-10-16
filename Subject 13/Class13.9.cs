// Использовать члены класса Exception.
using System;

namespace ca2
{
    class ExcTest
    {
        public static void GenException()
        {
            int[] nums = new int[4];

            Console.WriteLine("До генерирования исключения.");
            
            // Сгенерировать исключение в связи с выходом за границы массива.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
            Console.WriteLine("He подлежит выводу");
        }
    }
    class UseExcept
    {
        static void Main()
        {
            try
            {
                ExcTest.GenException();
            }
            catch(IndexOutOfRangeException exc)
            {
                Console.WriteLine("Стандартное сообщение таково: ");
                Console.WriteLine(exc); // Вызвать метод ToString()
                Console.WriteLine("Свойство StackTrace: " + exc.StackTrace);
                Console.WriteLine("Свойство Message: " + exc.Message);
                Console.WriteLine("Свойство TargetSite: " + exc.TargetSite);
            }
            Console.WriteLine("После блока перехвата исключений.");
        }
    }
}

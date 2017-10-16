// Использовать поле типа static для подсчета
// экземпляров существующих объектов.using System;

namespace ca2
{
    class CountInst
    {
        static int count = 0;
        // Инкрементировать подсчет, когда создается объект.
        public CountInst()
        {
            count++;
        }
        // Декрементировать подсчет, когда уничтожается объект.
        ~CountInst()
        {
            count--;
        }
        public static int GetCount()
        {
            return count;
        }
    }
    class CountDemo
    {
        static void Main()
        {
            CountInst ob;
            
            for(int i = 0; i < 10; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Текущий подсчет: " + CountInst.GetCount());
            }
        }
    }
}

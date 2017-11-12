// Простой пример коллекции типа BlockingCollection.
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ca2
{
    class BlockingDemo
    {
        static BlockingCollection<char> bc;

        // Произвести и поставить символы от А до Z.
        static void Producer()
        {
            for(char ch = 'A'; ch <='Z'; ch++)
            {
                bc.Add(ch);
                Console.WriteLine("Производится символ " + ch);
            }
        }
        // Потребить 26 символов.
        static void Consumer()
        {
            for (int i = 0; i < 26; i++)
                Console.WriteLine("Потребляется символ: " + bc.Take());
        }
        static void Main()
        {
            // Использовать блокирующую коллекцию, ограниченную 4 элементами.
            bc = new BlockingCollection<char>(4);

            // Создать задачи поставщика и потребителя.
            Task Prod = new Task(Producer);
            Task Con = new Task(Consumer);

            // Запустить задачи.
            Prod.Start();
            Con.Start();

            // Ожидать завершения обеих задач.
            try
            {
                Task.WaitAll(Prod, Con);
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Prod.Dispose();
                Con.Dispose();
                bc.Dispose();
            }
        }
    }
}

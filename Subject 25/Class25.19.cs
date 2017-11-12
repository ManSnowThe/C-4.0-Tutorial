// Применение методов CompleteAdding(), TryTake() и свойства IsCompleted.
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class BlockingDemo
    {
        static BlockingCollection<char> bc;

        // Произвести и поставить символы от А до Z.
        static void Producer()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                bc.Add(ch);
                Console.WriteLine("Производится символ " + ch);
            }
            bc.CompleteAdding();
        }
        // Потреблять символы до тех пор, пока их будет производить поставщик.
        static void Consumer()
        {
            char ch;

            while (!bc.IsCompleted)
            {
                if(bc.TryTake(out ch))
                Console.WriteLine("Потребляется символ: " + ch);
            }
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

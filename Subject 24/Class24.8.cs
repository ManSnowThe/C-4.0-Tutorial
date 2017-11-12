// Простой пример отмены задачи с использованием опроса.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoCancelTask
    {
        // Метод, исполняемый как задача.
        static void MyTask(Object ct)
        {
            CancellationToken cancelTok = (CancellationToken)ct;
            
            // Проверить, отменена ли задача, прежде чем запускать ее.
            cancelTok.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                // В данном примере для отслеживания отмены задачи применяется опрос.
                if (cancelTok.IsCancellationRequested)
                {
                    Console.WriteLine("Получен запрос на отмену задачи.");
                    cancelTok.ThrowIfCancellationRequested();
                }
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() подсчет равен " + count);
            }
            Console.WriteLine("MyTask завершен");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");
            
            // Создать объект источника признаков отмены.
            CancellationTokenSource cancelTokSrc = new CancellationTokenSource();
            
            // Запустить задачу, передав признак отмены ей самой и делегату.
            Task tsk = Task.Factory.StartNew(MyTask, cancelTokSrc.Token, cancelTokSrc.Token);
            
            // Дать задаче возможность исполняться вплоть до ее отмены.
            Thread.Sleep(2000);
            try
            {
                // Отменить задачу.
                cancelTokSrc.Cancel();
                
                // Приостановить выполнение метода Main() до тех пор,
                // пока не завершится задача tsk.
                tsk.Wait();
            }
            catch (AggregateException exc)
            {
                if (tsk.IsCanceled)
                    Console.WriteLine("\nЗадача tsk отменена\n");
                // Для просмотра исключения снять комментарии со следующей строки кода:
                // Console.WriteLine(ехc);
            }
            finally
            {
                tsk.Dispose();
                cancelTokSrc.Dispose();
            }
            Console.WriteLine("Основной поток завершен.");
        }
    }
}

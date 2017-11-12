// Возвратить значение из задачи.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoTask
    {
        // Простейший метод, возвращающий результат и не принимающий аргументов.
        static bool MyTask()
        {
            return true;
        }
        // Этот метод возвращает сумму из положительного целого значения,
        // которое ему передается в качестве единственного параметра
        static int SumIt(object v)
        {
            int x = (int)v;
            int sum = 0;

            for (; x > 0; x--)
                sum += x;
            return sum;
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Сконструировать объект первой задачи.
            Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);

            Console.WriteLine("Результат после выполнения задачи MyTask: " + tsk.Result);

            // Сконструировать объект второй задачи.
            Task<int> tsk2 = Task<int>.Factory.StartNew(SumIt, 3);

            Console.WriteLine("Результат после выполнения задачи SumIt: " + tsk2.Result);

            tsk.Dispose();
            tsk2.Dispose();

            Console.WriteLine("Основной поток завершен.");
        }
    }
}